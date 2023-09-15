Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class FlatNumericUpDown
    Inherits NumericUpDown
    Private borderColorField As Color = Color.Gray
    <DefaultValue(GetType(Color), "Gray")>
    Public Property BorderColor As Color
        Get
            Return borderColorField
        End Get
        Set(ByVal value As Color)
            If borderColorField <> value Then
                borderColorField = value
                Invalidate()
            End If
        End Set
    End Property
    Private buttonColor As Color = Color.Gray
    <DefaultValue(GetType(Color), "LightGray")>
    Public Property ButtonSymbolColor As Color
        Get
            Return buttonColor
        End Get
        Set(value As Color)
            buttonColor = value
        End Set
    End Property

    Private buttonHighlightColorField As Color = Color.LightGray
    <DefaultValue(GetType(Color), "LightGray")>
    Public Property ButtonHighlightColor As Color
        Get
            Return buttonHighlightColorField
        End Get
        Set(ByVal value As Color)
            If buttonHighlightColorField <> value Then
                buttonHighlightColorField = value
                Invalidate()
            End If
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        Dim renderer = New UpDownButtonRenderer(Controls(0))
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000   ' WS_EX_COMPOSITED       
            Return cp
        End Get
    End Property
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        If BorderStyle = BorderStyle.FixedSingle Then
            Using pen = New Pen(BorderColor, 1)
                e.Graphics.DrawRectangle(pen, ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Width - 1, ClientRectangle.Height - 1)
            End Using
        End If
    End Sub
    Private Class UpDownButtonRenderer
        Inherits NativeWindow
        <DllImport("user32.dll", ExactSpelling:=True, EntryPoint:="BeginPaint", CharSet:=CharSet.Auto)>
        Private Shared Function IntBeginPaint(ByVal hWnd As IntPtr,
        <[In], Out> ByRef lpPaint As PAINTSTRUCT) As IntPtr
        End Function
        <StructLayout(LayoutKind.Sequential)>
        Public Structure PAINTSTRUCT
            Public hdc As IntPtr
            Public fErase As Boolean
            Public rcPaint_left As Integer
            Public rcPaint_top As Integer
            Public rcPaint_right As Integer
            Public rcPaint_bottom As Integer
            Public fRestore As Boolean
            Public fIncUpdate As Boolean
            Public reserved1 As Integer
            Public reserved2 As Integer
            Public reserved3 As Integer
            Public reserved4 As Integer
            Public reserved5 As Integer
            Public reserved6 As Integer
            Public reserved7 As Integer
            Public reserved8 As Integer
        End Structure
        <DllImport("user32.dll", ExactSpelling:=True, EntryPoint:="EndPaint", CharSet:=CharSet.Auto)>
        Private Shared Function IntEndPaint(ByVal hWnd As IntPtr, ByRef lpPaint As PAINTSTRUCT) As Boolean
        End Function

        Private updown As Control
        Public Sub New(ByVal c As Control)
            updown = c
            If updown.IsHandleCreated Then
                Me.AssignHandle(updown.Handle)
            Else
                AddHandler updown.HandleCreated, Sub(s, e) Me.AssignHandle(updown.Handle)
            End If
        End Sub
        Private Function GetDownArrow(ByVal r As Rectangle) As Point()
            Dim middle = New Point(r.Left + r.Width / 2, r.Top + r.Height / 2)
            Return New Point() {New Point(middle.X - 3, middle.Y - 2), New Point(middle.X + 4, middle.Y - 2), New Point(middle.X, middle.Y + 2)}
        End Function
        Private Function GetUpArrow(ByVal r As Rectangle) As Point()
            Dim middle = New Point(r.Left + r.Width / 2, r.Top + r.Height / 2)
            Return New Point() {New Point(middle.X - 4, middle.Y + 2), New Point(middle.X + 4, middle.Y + 2), New Point(middle.X, middle.Y - 3)}
        End Function
        Protected Overrides Sub WndProc(ByRef m As Message)
            If m.Msg = &HF AndAlso CType(updown.Parent, FlatNumericUpDown).BorderStyle = BorderStyle.FixedSingle Then
                Dim s = New PAINTSTRUCT()
                IntBeginPaint(updown.Handle, s)
                Using g = Graphics.FromHdc(s.hdc)
                    Dim enabled = updown.Enabled
                    Using backBrush = New SolidBrush(CType(updown.Parent, FlatNumericUpDown).BackColor)
                        g.FillRectangle(backBrush, updown.ClientRectangle)
                    End Using
                    Dim r1 = New Rectangle(0, 0, updown.Width, updown.Height / 2)
                    Dim r2 = New Rectangle(0, updown.Height / 2, updown.Width, updown.Height / 2 + 1)
                    Dim p = updown.PointToClient(MousePosition)
                    If updown.ClientRectangle.Contains(p) Then
                        Using b = New SolidBrush(CType(updown.Parent, FlatNumericUpDown).ButtonHighlightColor)
                            If r1.Contains(p) Then
                                g.FillRectangle(b, r1)
                            Else
                                g.FillRectangle(b, r2)
                            End If
                        End Using
                        Using pen = New Pen(CType(updown.Parent, FlatNumericUpDown).BorderColor)
                            g.DrawLines(pen, {New Point(0, 0), New Point(0, updown.Height), New Point(0, updown.Height / 2), New Point(updown.Width, updown.Height / 2)})
                        End Using
                    End If
                    g.FillPolygon(New SolidBrush(CType(updown.Parent, FlatNumericUpDown).ButtonSymbolColor), GetUpArrow(r1))
                    g.FillPolygon(New SolidBrush(CType(updown.Parent, FlatNumericUpDown).ButtonSymbolColor), GetDownArrow(r2))
                End Using
                m.Result = CType(1, IntPtr)
                MyBase.WndProc(m)
                IntEndPaint(updown.Handle, s)
            ElseIf m.Msg = &H14 Then
                Using g = Graphics.FromHdcInternal(m.WParam)
                    g.FillRectangle(Brushes.White, updown.ClientRectangle)
                End Using
                m.Result = CType(1, IntPtr)
            Else
                MyBase.WndProc(m)
            End If
        End Sub
    End Class
End Class
