Imports System.Runtime.InteropServices

Public Class WindowsImmersiveMode
    <DllImport("dwmapi.dll")>
    Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrvalue As Boolean, attrsize As Integer) As Boolean
    End Function
    Public Shared Function SetImmersiveMode(frm As Form, enable As Boolean)
        Try
            Return DwmSetWindowAttribute(frm.Handle, 20, enable, Marshal.SizeOf(True))
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class