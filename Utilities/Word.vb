Public Class Word
    Public Shared Function HiWord(lValue As Long) As Integer
        If lValue And &H80000000 Then
            HiWord = (lValue \ 65535) - 1
        Else
            HiWord = lValue \ 65535
        End If
    End Function
    Public Shared Function LoWord(lValue As Long) As Integer
        If lValue And &H8000& Then
            LoWord = &H8000 Or (lValue And &H7FFF&)
        Else
            LoWord = lValue And &HFFFF&
        End If
    End Function
End Class
