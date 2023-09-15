Imports System.Drawing.Imaging
Imports Microsoft.VisualBasic.Logging

Public Class EditorControl
    Public Shared Function OpenEditor(vs As KIGIPUX.Binary.VESTEL.MB8X.LogoBinary.VestelImageInfo, Optional savelocation As String = Nothing) As EditorControl
        Dim Instance As New EditorControl
        Instance.NUDWidth.Value = vs.Header.ImageWidth
        Instance.NUDHeight.Value = vs.Header.ImageHeight
        Instance.FilenameBox.Text = vs.Footer.Filename
        Instance.PictureBox1.Image = vs.Image
        Instance.NUDHeight.Enabled = False
        Instance.NUDWidth.Enabled = False
        Instance.FilenameBox.Enabled = True
        If savelocation IsNot Nothing Then
            Instance.SaveFileControl.FileLocation = savelocation
        End If
        Return Instance
    End Function
    Public Shared Function CreateEditor(sz As Size) As EditorControl
        Dim Instance As New EditorControl
        Instance.NUDWidth.Value = sz.Width
        Instance.NUDHeight.Value = sz.Height
        Instance.FilenameBox.Text = "MB8X_" & Date.Now.ToShortDateString() & "_" & Date.Now.ToShortTimeString() & ".BIN"
        Instance.PictureBox1.Image = New Bitmap(sz.Width, sz.Height)
        Instance.NUDHeight.Enabled = False
        Instance.NUDWidth.Enabled = False
        Instance.FilenameBox.Enabled = True
        Return Instance
    End Function

    Private _Unsaved As Boolean = False
    Private Sub ReplaceButton_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
        Dim OPD As OpenFileDialog = OpenPictureDialog.CreateDialog()
        If OPD.ShowDialog() = DialogResult.OK Then
            ReplaceImage(Bitmap.FromFile(OPD.FileName))
        End If
    End Sub
    Private Sub ReplaceImage(img As Bitmap)
        If Not (img.Size = PictureBox1.Image.Size) Then
            Dim dres As DialogResult = MessageBox.Show("The image you opened has a different size than the canvas. Would you like to resize the canvas? (If 'no' is pressed, image will be stretched to the canvas)", "Warning!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If dres = DialogResult.Yes Then
                PictureBox1.Image = img
                NUDWidth.Value = img.Width
                NUDHeight.Value = img.Height
                _Unsaved = True
            ElseIf dres = DialogResult.No Then
                Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
                g.DrawImage(img, 0, 0, PictureBox1.Image.Width, PictureBox1.Image.Height)
                g.Flush()
                g.Dispose()
                _Unsaved = True
            End If
        Else
            PictureBox1.Image = img
            _Unsaved = True
        End If
        PictureBox1.Invalidate()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If _Unsaved AndAlso Not (MessageBox.Show("You have unsaved changes, Are you sure you want to exit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then Return
        Me.Dispose()
    End Sub

    Private Sub SaveImgButton_Click(sender As Object, e As EventArgs) Handles SaveImgButton.Click
        Dim SVD As New SaveFileDialog
        SVD.Filter = "Bitmap (*.bmp)|*.bmp|All Files (*.*)|*.*"
        SVD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SVD.Title = "Please pick a location"
        SVD.CheckPathExists = True
        If SVD.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image.Save(SVD.FileName, ImageFormat.Bmp)
        End If
    End Sub

    Private Sub SaveLogoButton_Click(sender As Object, e As EventArgs) Handles SaveLogoButton.Click
        If Not SaveFileControl.FileLocation = Nothing Then
            IO.File.WriteAllBytes(SaveFileControl.FileLocation, KIGIPUX.Binary.VESTEL.MB8X.LogoBinary.CreateVestelImageBIN(PictureBox1.Image.Clone(), FilenameBox.Text))
            MessageBox.Show("Saved Successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _Unsaved = False
        Else
            MessageBox.Show("You haven't picked a save location. Aborting Save Operation.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Dim mfilter As New MouseLocationFilter
    Private Sub EditorControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler mfilter.MouseMove, Sub(caller As Object, ev As MouseEventArgs)
                                          Dim XR As Point = Me.PointToClient(ev.Location)
                                          Dim OffsetX As Integer = XR.X - PictureBox1.Left
                                          Dim OffsetY As Integer = XR.Y - PictureBox1.Top
                                          If (OffsetX > 0) And (OffsetY > 0) And (OffsetY < PictureBox1.Height) And (OffsetX < PictureBox1.Width) Then
                                              SaveImgButton.Visible = True
                                              ReplaceButton.Visible = True
                                          Else
                                              SaveImgButton.Visible = False
                                              ReplaceButton.Visible = False
                                          End If
                                      End Sub
        Application.AddMessageFilter(mfilter)
    End Sub

    Private Sub EditorControl_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Application.RemoveMessageFilter(mfilter)
    End Sub
End Class
