Public Class OpenPictureDialog
    Public Shared Function CreateDialog() As OpenFileDialog
        Dim k As New OpenFileDialog
        k.Filter = "All Supported Images|*.png;*.jpg;*.jpeg;*.tif;*.tiff;*.bmp;*.gif;*.wmf|PNG Image (*.png)|*.png|JPEG Image (*.jpg *.jpeg)|*.jpg;*.jpeg|TIFF Image (*.tif *.tiff)|*.tif;*.tiff|Bitmap (.bmp)|*.bmp|GIF Image (*.gif)|*.gif|WMF Metafile (*.wmf)|*.wmf|All Files (*.*)|*.*"
        k.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        k.Title = "Please select a file"
        k.Multiselect = False
        k.CheckFileExists = True
        k.CheckPathExists = True
        Return k
    End Function
End Class
