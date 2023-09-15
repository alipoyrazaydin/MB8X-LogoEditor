Public Class MouseLocationFilter
    Implements IMessageFilter
    Public Event MouseMove As EventHandler(Of MouseEventArgs)
    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = &H200 Then
            Dim j As Point = Cursor.Position
            Dim lX As Integer = j.X
            Dim lY As Integer = j.Y
            RaiseEvent MouseMove(Me, New MouseEventArgs(MouseButtons.None, 0, lX, lY, 0))
        End If
        Return False
    End Function
End Class
