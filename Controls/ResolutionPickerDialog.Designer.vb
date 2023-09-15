<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResolutionPickerDialog
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NUDHeight = New MB8X_LogoEditor.FlatNumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUDWidth = New MB8X_LogoEditor.FlatNumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancellingButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.NUDHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NUDHeight
        '
        Me.NUDHeight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NUDHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.NUDHeight.BorderColor = System.Drawing.Color.DimGray
        Me.NUDHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUDHeight.ButtonHighlightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NUDHeight.ButtonSymbolColor = System.Drawing.Color.Gray
        Me.NUDHeight.ForeColor = System.Drawing.Color.Gainsboro
        Me.NUDHeight.Location = New System.Drawing.Point(162, 12)
        Me.NUDHeight.Maximum = New Decimal(New Integer() {5142, 0, 0, 0})
        Me.NUDHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDHeight.Name = "NUDHeight"
        Me.NUDHeight.Size = New System.Drawing.Size(71, 20)
        Me.NUDHeight.TabIndex = 31
        Me.NUDHeight.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(151, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(9, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "x"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'NUDWidth
        '
        Me.NUDWidth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NUDWidth.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.NUDWidth.BorderColor = System.Drawing.Color.DimGray
        Me.NUDWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUDWidth.ButtonHighlightColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NUDWidth.ButtonSymbolColor = System.Drawing.Color.Gray
        Me.NUDWidth.ForeColor = System.Drawing.Color.Gainsboro
        Me.NUDWidth.Location = New System.Drawing.Point(77, 12)
        Me.NUDWidth.Maximum = New Decimal(New Integer() {5142, 0, 0, 0})
        Me.NUDWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDWidth.Name = "NUDWidth"
        Me.NUDWidth.Size = New System.Drawing.Size(71, 20)
        Me.NUDWidth.TabIndex = 29
        Me.NUDWidth.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(11, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Resolution:"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OKButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OKButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.OKButton.Location = New System.Drawing.Point(94, 70)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(66, 23)
        Me.OKButton.TabIndex = 32
        Me.OKButton.Text = "OK"
        Me.OKButton.UseCompatibleTextRendering = True
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'CancellingButton
        '
        Me.CancellingButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancellingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancellingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancellingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CancellingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CancellingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CancellingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancellingButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CancellingButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.CancellingButton.Location = New System.Drawing.Point(166, 70)
        Me.CancellingButton.Name = "CancellingButton"
        Me.CancellingButton.Size = New System.Drawing.Size(66, 23)
        Me.CancellingButton.TabIndex = 33
        Me.CancellingButton.Text = "Cancel"
        Me.CancellingButton.UseCompatibleTextRendering = True
        Me.CancellingButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(12, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 20)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "FHD"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(55, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 20)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "WXGA"
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ResolutionPickerDialog
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CancelButton = Me.CancellingButton
        Me.ClientSize = New System.Drawing.Size(244, 105)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CancellingButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.NUDHeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NUDWidth)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ResolutionPickerDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pick a Resolution"
        CType(Me.NUDHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NUDHeight As FlatNumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NUDWidth As FlatNumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents CancellingButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
