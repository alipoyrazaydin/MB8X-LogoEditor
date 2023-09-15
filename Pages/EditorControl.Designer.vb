<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditorControl
    Inherits System.Windows.Forms.UserControl

    'UserControl, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FilenameBox = New System.Windows.Forms.TextBox()
        Me.NUDHeight = New MB8X_LogoEditor.FlatNumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUDWidth = New MB8X_LogoEditor.FlatNumericUpDown()
        Me.ReplaceButton = New System.Windows.Forms.Button()
        Me.SaveImgButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveLogoButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SaveFileControl = New MB8X_LogoEditor.SaveControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.MB8X_LogoEditor.My.Resources.Resources.transparency
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(814, 469)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FilenameBox
        '
        Me.FilenameBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FilenameBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FilenameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilenameBox.Enabled = False
        Me.FilenameBox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FilenameBox.ForeColor = System.Drawing.Color.Gainsboro
        Me.FilenameBox.Location = New System.Drawing.Point(508, 478)
        Me.FilenameBox.Name = "FilenameBox"
        Me.FilenameBox.Size = New System.Drawing.Size(166, 22)
        Me.FilenameBox.TabIndex = 28
        Me.FilenameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NUDHeight
        '
        Me.NUDHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NUDHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.NUDHeight.BorderColor = System.Drawing.Color.DimGray
        Me.NUDHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUDHeight.ButtonHighlightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NUDHeight.ButtonSymbolColor = System.Drawing.Color.Gray
        Me.NUDHeight.Enabled = False
        Me.NUDHeight.ForeColor = System.Drawing.Color.Gainsboro
        Me.NUDHeight.Location = New System.Drawing.Point(440, 479)
        Me.NUDHeight.Maximum = New Decimal(New Integer() {5142, 0, 0, 0})
        Me.NUDHeight.Name = "NUDHeight"
        Me.NUDHeight.Size = New System.Drawing.Size(63, 20)
        Me.NUDHeight.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(431, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(9, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "x"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'NUDWidth
        '
        Me.NUDWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NUDWidth.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.NUDWidth.BorderColor = System.Drawing.Color.DimGray
        Me.NUDWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUDWidth.ButtonHighlightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NUDWidth.ButtonSymbolColor = System.Drawing.Color.Gray
        Me.NUDWidth.Enabled = False
        Me.NUDWidth.ForeColor = System.Drawing.Color.Gainsboro
        Me.NUDWidth.Location = New System.Drawing.Point(367, 479)
        Me.NUDWidth.Maximum = New Decimal(New Integer() {5142, 0, 0, 0})
        Me.NUDWidth.Name = "NUDWidth"
        Me.NUDWidth.Size = New System.Drawing.Size(63, 20)
        Me.NUDWidth.TabIndex = 25
        '
        'ReplaceButton
        '
        Me.ReplaceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ReplaceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReplaceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ReplaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ReplaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReplaceButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ReplaceButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.ReplaceButton.Location = New System.Drawing.Point(404, 450)
        Me.ReplaceButton.Name = "ReplaceButton"
        Me.ReplaceButton.Size = New System.Drawing.Size(89, 22)
        Me.ReplaceButton.TabIndex = 23
        Me.ReplaceButton.Text = "Replace Image"
        Me.ReplaceButton.UseCompatibleTextRendering = True
        Me.ReplaceButton.UseVisualStyleBackColor = False
        '
        'SaveImgButton
        '
        Me.SaveImgButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SaveImgButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveImgButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SaveImgButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SaveImgButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.SaveImgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveImgButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SaveImgButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.SaveImgButton.Location = New System.Drawing.Point(327, 450)
        Me.SaveImgButton.Name = "SaveImgButton"
        Me.SaveImgButton.Size = New System.Drawing.Size(74, 22)
        Me.SaveImgButton.TabIndex = 22
        Me.SaveImgButton.Text = "Save Image"
        Me.SaveImgButton.UseCompatibleTextRendering = True
        Me.SaveImgButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(304, 481)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Resolution:"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'SaveLogoButton
        '
        Me.SaveLogoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveLogoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SaveLogoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SaveLogoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.SaveLogoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.SaveLogoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveLogoButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SaveLogoButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.SaveLogoButton.Location = New System.Drawing.Point(725, 478)
        Me.SaveLogoButton.Name = "SaveLogoButton"
        Me.SaveLogoButton.Size = New System.Drawing.Size(87, 22)
        Me.SaveLogoButton.TabIndex = 23
        Me.SaveLogoButton.Text = "Save Logo File"
        Me.SaveLogoButton.UseCompatibleTextRendering = True
        Me.SaveLogoButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(6, 482)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Output Save Location:"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.ExitButton.Location = New System.Drawing.Point(680, 478)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(39, 22)
        Me.ExitButton.TabIndex = 28
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseCompatibleTextRendering = True
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SaveFileControl
        '
        Me.SaveFileControl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SaveFileControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SaveFileControl.FileLocation = ""
        Me.SaveFileControl.Filter = "All Files (*.*)|*.*"
        Me.SaveFileControl.Location = New System.Drawing.Point(123, 479)
        Me.SaveFileControl.Name = "SaveFileControl"
        Me.SaveFileControl.Size = New System.Drawing.Size(175, 22)
        Me.SaveFileControl.TabIndex = 26
        Me.SaveFileControl.Title = "Save File"
        '
        'EditorControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Controls.Add(Me.SaveImgButton)
        Me.Controls.Add(Me.ReplaceButton)
        Me.Controls.Add(Me.FilenameBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.NUDHeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveFileControl)
        Me.Controls.Add(Me.NUDWidth)
        Me.Controls.Add(Me.SaveLogoButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "EditorControl"
        Me.Size = New System.Drawing.Size(820, 510)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NUDHeight As FlatNumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NUDWidth As FlatNumericUpDown
    Friend WithEvents ReplaceButton As Button
    Friend WithEvents SaveImgButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveLogoButton As Button
    Friend WithEvents SaveFileControl As SaveControl
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents FilenameBox As TextBox
End Class
