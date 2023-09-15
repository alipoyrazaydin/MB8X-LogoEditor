Imports System.IO
Imports KIGIPUX.Bitmap

Namespace Global.KIGIPUX.Binary.VESTEL.MB8X
    Public Class LogoBinary
        '' Vestel's Logo Parser and Editor
        '' Made by Ali Poyraz AYDIN,
        '' With demonstrations of how it works.

        '' Vestel's Image Header. Works like this: VCODE(4 Bytes) + WIDTH(2 Bytes) + EMPTY(2 Bytes) + HEIGHT(2 Bytes) + EMPTY(2 Bytes)
        '' Width and Height are Big-Endian (56 05 = 0x0556 = 1366)
        Shared VestelImageBINHeader As Byte() = {&H0, &H4, &H20, &H0, &H56, &H5, &H0, &H0, &H0, &H3, &H0, &H0}

        '' Vestel's Image Footer. Works like this: VCODE(0x0D 0x00) + EMPTY(2 Bytes) + HIGH(12 Bytes) + STRLENGTH(2 Byte) + EMPTY(2 BYTES) + STRING
        '' String Length is Big-Endian (56 05 = 0x0556 = 1366)
        Shared VestelImageBINFooter As Byte() = {&HD, &H0, &H0, &H0, &HFF, &HFF, &HFF, &HFF, &HFF, &HFF, &HFF, &HFF, &HFF, &HFF, &HFF, &HFF, &H1E, &H0, &H0, &H0}

#Region "Custom Types"
        Public Structure VestelImageHeaderInfo
            Dim ImageWidth As Integer
            Dim ImageHeight As Integer
        End Structure

        Public Structure VestelImageFooterInfo
            Dim Filename As String
        End Structure

        Public Structure VestelImageInfo
            Dim Image As Drawing.Bitmap
            Dim Header As VestelImageHeaderInfo
            Dim Footer As VestelImageFooterInfo
        End Structure

        Public Class InvalidFileHeaderException
            Inherits Exception
            Public Sub New(m As String)
                MyBase.New(m & " has an invalid Vestel Logo Binary Header.")
            End Sub
        End Class

        Public Class InvalidFileFooterException
            Inherits Exception
            Public Sub New(m As String)
                MyBase.New(m & " has an invalid Vestel Logo Binary Footer.")
            End Sub
        End Class
#End Region
#Region "Functions"
        Private Shared Function CreateImageHeader(iW As Integer, iH As Integer) As Byte()
            '' iW is Image Width, iH is Image Height
            Dim iWhex As Byte() = (Function() As Byte()
                                       Dim iWhexStr = iW.ToString("X02").PadLeft(4, "0")
                                       Return {Convert.ToByte(iWhexStr.Substring(2), 16), Convert.ToByte(iWhexStr.Substring(0, 2), 16)}
                                   End Function)()
            Dim iHhex As Byte() = (Function() As Byte()
                                       Dim iHhexStr = iH.ToString("X02").PadLeft(4, "0")
                                       Return {Convert.ToByte(iHhexStr.Substring(2), 16), Convert.ToByte(iHhexStr.Substring(0, 2), 16)}
                                   End Function)()
            Dim vBINHeader As Byte() = LogoBinary.VestelImageBINHeader
            vBINHeader(4) = iWhex(0)
            vBINHeader(5) = iWhex(1)
            vBINHeader(8) = iHhex(0)
            vBINHeader(9) = iHhex(1)
            Return vBINHeader
        End Function
        Private Shared Function CreateImageFooter(fname As String) As Byte()
            '' fname is Filename
            Dim fNameLhex As Byte() = (Function() As Byte()
                                           Dim fNameLhexStr = fname.Length.ToString("X02").PadLeft(4, "0")
                                           Return {Convert.ToByte(fNameLhexStr.Substring(2), 16), Convert.ToByte(fNameLhexStr.Substring(0, 2), 16)}
                                       End Function)()
            Dim fNamehex As Byte() = System.Text.Encoding.ASCII.GetBytes(fname)
            Dim vBINFooter As Byte() = LogoBinary.VestelImageBINFooter
            vBINFooter(16) = fNameLhex(0)
            vBINFooter(17) = fNameLhex(1)

            Dim output As Byte() = New Byte(vBINFooter.Length + fNamehex.Length - 1) {}
            Array.Copy(vBINFooter, 0, output, 0, vBINFooter.Length)
            Array.Copy(fNamehex, 0, output, vBINFooter.Length, fNamehex.Length)

            Return output
        End Function
        Private Shared Function ConvertBEBytesToColorARGB(p1 As Byte, p2 As Byte) As Int32
            Dim e1 As String = p1.ToString("X02") & p2.ToString("X02")
            Return Convert.ToInt32("FF" & e1(1) & e1(1) & e1(2) & e1(2) & e1(3) & e1(3), 16)
        End Function
        Private Shared Function ConvertColorToBEBytes(argbval As Int32) As Byte()
            Dim conv As String = argbval.ToString("X8").Substring(2, 6)
            Return {Convert.ToByte(conv(2) & conv(4), 16), Convert.ToByte("F" & conv(0), 16)}
        End Function
        Private Shared Function CreateImageData(bm As Drawing.Bitmap) As Byte()
            Dim seq((bm.Width * bm.Height) * 2 - 1) As Byte
            Dim ibyt As Int32() = KIGIPUX.Bitmap.BitmapDrive.CreateIntegerPoolFromBitmap(bm)
            Dim r As New MemoryStream(seq)
            For i = 0 To ibyt.Length - 1 Step 1
                Dim kJ As Byte() = ConvertColorToBEBytes(ibyt(i))
                r.WriteByte(kJ(0))
                r.WriteByte(kJ(1))
            Next
            r.Flush()
            r.Close()
            Return seq
        End Function
        Public Shared Function CreateVestelImageBIN(bm As Drawing.Bitmap, fname As String) As Byte()
            Dim imageHSeq As Byte() = CreateImageHeader(bm.Width, bm.Height)
            Dim imageDSeq As Byte() = CreateImageData(bm)
            Dim imageFSeq As Byte() = CreateImageFooter(fname)

            Dim OSeq As Byte() = New Byte((imageHSeq.Length + imageDSeq.Length + imageFSeq.Length) - 1) {}
            Array.Copy(imageHSeq, 0, OSeq, 0, imageHSeq.Length)
            Array.Copy(imageDSeq, 0, OSeq, imageHSeq.Length, imageDSeq.Length)
            Array.Copy(imageFSeq, 0, OSeq, (imageHSeq.Length + imageDSeq.Length), imageFSeq.Length)

            Return OSeq
        End Function
        Private Shared Function ReadImageHeader(seq As Byte()) As VestelImageHeaderInfo
            '' seq is Byte Sequence
            If Not ((seq(0) = 0) And seq(1) = 4) Then Throw New InvalidFileHeaderException("Current file")
            Return New VestelImageHeaderInfo With {
            .ImageWidth = Convert.ToUInt32(seq(5).ToString("X02") & seq(4).ToString("X02"), 16),
            .ImageHeight = Convert.ToUInt32(seq(9).ToString("X02") & seq(8).ToString("X02"), 16)
        }
        End Function
        Private Shared Function ReadImageFooter(seq As Byte()) As VestelImageFooterInfo
            '' seq is Byte Sequence
            If Not (seq(0) = 13) Then Throw New InvalidFileFooterException("Current file")
            Return New VestelImageFooterInfo With {
            .Filename = System.Text.Encoding.ASCII.GetString(seq.Skip(VestelImageBINFooter.Length).ToArray())
        }
        End Function
        Private Shared Function ReadImageData(seq As Byte(), iW As Integer, iH As Integer) As Drawing.Bitmap
            '' seq is Image Sequence, iW is Image Width, iH is Image Height
            Dim nbits As Int32() = New Int32(iW * iH - 1) {}
            For kC As Integer = 0 To seq.Length - 1 Step 2
                nbits(kC / 2) = ConvertBEBytesToColorARGB(seq(kC + 1), seq(kC))
            Next
            Return BitmapDrive.CreateBitmapFromIntegerPool(iW, iH, nbits)
        End Function
        Public Shared Function ReadVestelImageBIN(seq As Byte()) As VestelImageInfo
            '' Define HeaderSequence and read data.
            Dim headerSeq(VestelImageBINHeader.Length - 1) As Byte
            Array.Copy(seq, 0, headerSeq, 0, headerSeq.Length)
            Dim headerStructure As VestelImageHeaderInfo = ReadImageHeader(headerSeq)

            '' Define ImageSequence and read data.
            Dim imageSeq(((headerStructure.ImageHeight) * (headerStructure.ImageWidth)) * 2 - 1) As Byte
            Array.Copy(seq, headerSeq.Length, imageSeq, 0, imageSeq.Length)
            Dim imageStructure As Drawing.Bitmap = ReadImageData(imageSeq, headerStructure.ImageWidth, headerStructure.ImageHeight)

            '' Define FooterSequence for later use.
            Dim footerSeq(seq.Length - (headerSeq.Length + imageSeq.Length) - 1) As Byte
            Array.Copy(seq, (headerSeq.Length + imageSeq.Length), footerSeq, 0, footerSeq.Length)
            Dim footerStructure As VestelImageFooterInfo = ReadImageFooter(footerSeq)

            Return New VestelImageInfo With {
            .Header = headerStructure,
            .Image = imageStructure,
            .Footer = footerStructure
        }
        End Function
#End Region
    End Class
End Namespace
