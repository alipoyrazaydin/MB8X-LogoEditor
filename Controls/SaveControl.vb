'' KSL-Turnverse: SaveControl.NET.ksl -> SaveControl.vb
Public Class SaveControl
    Inherits UserControl
    Public Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.ContainerControl, True)
        InitializeControls()
    End Sub
    Private Sub InitializeControls()
        '' KSL-Turnverse: Current
        Me.Width = 150
        Me.Height = 28

        '' KSL-Turnverse: LocationString Control
        LocationString.AutoSize = False
        LocationString.AutoEllipsis = True
        LocationString.Dock = 5
        LocationString.Text = "Not Selected"
        LocationString.UseCompatibleTextRendering = True
        LocationString.TextAlign = 16
        LocationString.ForeColor = Color.Gainsboro
        LocationString.BackColor = Color.Transparent

        '' KSL-Turnverse: SaveButton Control
        SaveButton.BackColor = Color.FromArgb(15, 255, 255, 255)
        SaveButton.FlatStyle = 0
        SaveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 255, 255, 255)
        SaveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(5, 255, 255, 255)
        SaveButton.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30)
        SaveButton.Text = "Select"
        SaveButton.Dock = DockStyle.Right
        SaveButton.UseCompatibleTextRendering = True
        SaveButton.Width = 52
        SaveButton.ForeColor = Color.Gainsboro
        SaveButton.SendToBack()

        '' KSL-Turnverse: SaveDialog Control
        SaveDialog.Title = "Save File"
        SaveDialog.Filter = "All Files (*.*)|*.*"
        SaveDialog.CheckFileExists = False
        SaveDialog.CheckPathExists = True
        SaveDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop

        '' KSL-Turnverse: Add Controls to the Main Control
        Me.Controls.AddRange({
            LocationString,
            SaveButton
        })
    End Sub

    Public Property Title As String
        Get
            Return SaveDialog.Title
        End Get
        Set(value As String)
            SaveDialog.Title = value
        End Set
    End Property
    Public Property Filter As String
        Get
            Return SaveDialog.Filter
        End Get
        Set(value As String)
            SaveDialog.Filter = value
        End Set
    End Property
    Public Property FileLocation As String
        Get
            Return SaveDialog.FileName
        End Get
        Set(value As String)
            If value = Nothing Then Return
            SaveDialog.FileName = value
            LocationString.Text = SaveDialog.FileName.Split(IO.Path.PathSeparator).Last()
        End Set
    End Property

    '' KSL-Turnverse: SaveButton Click Event
    Private Protected Sub SaveClick(caller As Object, args As EventArgs) Handles SaveButton.Click
        If SaveDialog.ShowDialog() = DialogResult.OK Then
            LocationString.Text = SaveDialog.FileName.Split(IO.Path.PathSeparator).Last()
        End If
    End Sub

    Protected Friend WithEvents SaveDialog As New SaveFileDialog
    Protected Friend WithEvents SaveButton As New Button
    Protected Friend WithEvents LocationString As New Label
End Class
