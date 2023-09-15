Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Namespace Global.KIGIPUX.Bitmap
    Public Class BitmapDrive
        Public Shared Function CreateBitmapFromIntegerPool(width As Integer, height As Integer, ix As Int32()) As Drawing.Bitmap
            Dim bl As Int32() = ix
            Dim bp As GCHandle = GCHandle.Alloc(bl, GCHandleType.Pinned)
            Dim bw As New Drawing.Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, bp.AddrOfPinnedObject())
            Dim bx As Drawing.Bitmap = bw.Clone(New Rectangle(0, 0, width, height), PixelFormat.Format16bppRgb555)
            bw.Dispose()
            bp.Free()
            Return bx
        End Function
        Public Shared Function CreateIntegerPoolFromBitmap(bmp As Drawing.Bitmap) As Int32()
            Dim bl As Int32() = New Int32(bmp.Width * bmp.Height - 1) {}
            Dim bdata As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb)
            Marshal.Copy(bdata.Scan0, bl, 0, bl.Length)
            bmp.UnlockBits(bdata)
            Return bl
        End Function
    End Class
End Namespace