Public Class FirstLook
    Public Event OpenInvoked As Action(Of KIGIPUX.Binary.VESTEL.MB8X.LogoBinary.VestelImageInfo, String)
    Public Event CreateInvoked As Action(Of Size)
    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        Dim k As New OpenFileDialog
        k.Filter = "VESTEL Binary (*.ves)|*.ves|BIN Image (*.bin)|*.bin|All Files (*.*)|*.*"
        k.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        k.Title = "Please select a file"
        k.Multiselect = False
        k.CheckFileExists = True
        k.CheckPathExists = True
        If k.ShowDialog() = DialogResult.OK Then
            RaiseEvent OpenInvoked(KIGIPUX.Binary.VESTEL.MB8X.LogoBinary.ReadVestelImageBIN(IO.File.ReadAllBytes(k.FileName)), k.FileName)
        End If
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Dim k As New ResolutionPickerDialog
        If k.ShowDialog() = DialogResult.OK Then
            RaiseEvent CreateInvoked(k.Resolution)
        End If
    End Sub
End Class
