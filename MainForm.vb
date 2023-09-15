Public Class MainForm
    Dim Editor As EditorControl
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowsImmersiveMode.SetImmersiveMode(Me, True)
        Dim l As New FirstLook
        l.Dock = 5
        Me.Controls.Add(l)
        AddHandler l.CreateInvoked, Sub(ByVal sz As Size)
                                        Editor = EditorControl.CreateEditor(sz)
                                        Editor.Dock = 5
                                        Me.Controls.Add(Editor)
                                        Editor.BringToFront()
                                    End Sub
        AddHandler l.OpenInvoked, Sub(ByVal ves As KIGIPUX.Binary.VESTEL.MB8X.LogoBinary.VestelImageInfo, fname As String)
                                      Editor = EditorControl.OpenEditor(ves, fname)
                                      Editor.Dock = 5
                                      Me.Controls.Add(Editor)
                                      Editor.BringToFront()
                                  End Sub
    End Sub
End Class
