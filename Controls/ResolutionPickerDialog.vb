Public Class ResolutionPickerDialog
    Public Property Resolution As Size
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Resolution = New Size(NUDWidth.Value, NUDHeight.Value)
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub CancellingButton_Click(sender As Object, e As EventArgs) Handles CancellingButton.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NUDWidth.Value = 1920
        NUDHeight.Value = 1080
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NUDWidth.Value = 1366
        NUDHeight.Value = 768
    End Sub

    Private Sub ResolutionPickerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowsImmersiveMode.SetImmersiveMode(Me, True)
    End Sub
End Class