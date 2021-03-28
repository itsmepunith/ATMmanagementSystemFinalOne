<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotpass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.txtacc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtOtp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cardnoBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.OkBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PinBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.IconPictureBox1)
        Me.panel1.Controls.Add(Me.IconPictureBox4)
        Me.panel1.Controls.Add(Me.IconPictureBox3)
        Me.panel1.Controls.Add(Me.IconPictureBox2)
        Me.panel1.FillColor = System.Drawing.Color.Magenta
        Me.panel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(-1, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.ShadowDecoration.Parent = Me.panel1
        Me.panel1.Size = New System.Drawing.Size(484, 30)
        Me.panel1.TabIndex = 29
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(421, 0)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 6
        Me.IconPictureBox1.TabStop = False
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconPictureBox4.IconColor = System.Drawing.Color.White
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 27
        Me.IconPictureBox4.Location = New System.Drawing.Point(385, -3)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(27, 30)
        Me.IconPictureBox4.TabIndex = 5
        Me.IconPictureBox4.TabStop = False
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox3.IconColor = System.Drawing.Color.White
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.Location = New System.Drawing.Point(1007, 3)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 4
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 27
        Me.IconPictureBox2.Location = New System.Drawing.Point(974, -1)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(27, 30)
        Me.IconPictureBox2.TabIndex = 3
        Me.IconPictureBox2.TabStop = False
        '
        'txtacc
        '
        Me.txtacc.AutoRoundedCorners = True
        Me.txtacc.BorderRadius = 17
        Me.txtacc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtacc.DefaultText = ""
        Me.txtacc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtacc.DisabledState.Parent = Me.txtacc
        Me.txtacc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtacc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtacc.FocusedState.Parent = Me.txtacc
        Me.txtacc.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.txtacc.ForeColor = System.Drawing.Color.Black
        Me.txtacc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtacc.HoverState.Parent = Me.txtacc
        Me.txtacc.Location = New System.Drawing.Point(85, 120)
        Me.txtacc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtacc.Name = "txtacc"
        Me.txtacc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtacc.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtacc.PlaceholderText = "Card Number"
        Me.txtacc.SelectedText = ""
        Me.txtacc.ShadowDecoration.Parent = Me.txtacc
        Me.txtacc.Size = New System.Drawing.Size(265, 36)
        Me.txtacc.TabIndex = 30
        '
        'txtOtp
        '
        Me.txtOtp.AutoRoundedCorners = True
        Me.txtOtp.BorderRadius = 17
        Me.txtOtp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOtp.DefaultText = ""
        Me.txtOtp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOtp.DisabledState.Parent = Me.txtOtp
        Me.txtOtp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOtp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOtp.FocusedState.Parent = Me.txtOtp
        Me.txtOtp.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.txtOtp.ForeColor = System.Drawing.Color.Black
        Me.txtOtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOtp.HoverState.Parent = Me.txtOtp
        Me.txtOtp.Location = New System.Drawing.Point(85, 280)
        Me.txtOtp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOtp.Name = "txtOtp"
        Me.txtOtp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOtp.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtOtp.PlaceholderText = "OTP"
        Me.txtOtp.SelectedText = ""
        Me.txtOtp.ShadowDecoration.Parent = Me.txtOtp
        Me.txtOtp.Size = New System.Drawing.Size(265, 36)
        Me.txtOtp.TabIndex = 31
        '
        'txtPin
        '
        Me.txtPin.AutoRoundedCorners = True
        Me.txtPin.BorderRadius = 17
        Me.txtPin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPin.DefaultText = ""
        Me.txtPin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPin.DisabledState.Parent = Me.txtPin
        Me.txtPin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPin.FocusedState.Parent = Me.txtPin
        Me.txtPin.Font = New System.Drawing.Font("Segoe UI", 11.5!)
        Me.txtPin.ForeColor = System.Drawing.Color.Black
        Me.txtPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPin.HoverState.Parent = Me.txtPin
        Me.txtPin.Location = New System.Drawing.Point(85, 405)
        Me.txtPin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPin.PlaceholderText = "New Pin"
        Me.txtPin.SelectedText = ""
        Me.txtPin.ShadowDecoration.Parent = Me.txtPin
        Me.txtPin.Size = New System.Drawing.Size(265, 36)
        Me.txtPin.TabIndex = 32
        '
        'cardnoBtn
        '
        Me.cardnoBtn.CheckedState.Parent = Me.cardnoBtn
        Me.cardnoBtn.CustomImages.Parent = Me.cardnoBtn
        Me.cardnoBtn.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!)
        Me.cardnoBtn.ForeColor = System.Drawing.Color.Black
        Me.cardnoBtn.HoverState.Parent = Me.cardnoBtn
        Me.cardnoBtn.Location = New System.Drawing.Point(123, 189)
        Me.cardnoBtn.Name = "cardnoBtn"
        Me.cardnoBtn.ShadowDecoration.Parent = Me.cardnoBtn
        Me.cardnoBtn.Size = New System.Drawing.Size(180, 45)
        Me.cardnoBtn.TabIndex = 33
        Me.cardnoBtn.Text = "Send OTP"
        '
        'OkBtn
        '
        Me.OkBtn.CheckedState.Parent = Me.OkBtn
        Me.OkBtn.CustomImages.Parent = Me.OkBtn
        Me.OkBtn.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!)
        Me.OkBtn.ForeColor = System.Drawing.Color.Black
        Me.OkBtn.HoverState.Parent = Me.OkBtn
        Me.OkBtn.Location = New System.Drawing.Point(161, 340)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.ShadowDecoration.Parent = Me.OkBtn
        Me.OkBtn.Size = New System.Drawing.Size(102, 45)
        Me.OkBtn.TabIndex = 34
        Me.OkBtn.Text = "Ok"
        '
        'PinBtn
        '
        Me.PinBtn.CheckedState.Parent = Me.PinBtn
        Me.PinBtn.CustomImages.Parent = Me.PinBtn
        Me.PinBtn.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!)
        Me.PinBtn.ForeColor = System.Drawing.Color.Black
        Me.PinBtn.HoverState.Parent = Me.PinBtn
        Me.PinBtn.Location = New System.Drawing.Point(123, 475)
        Me.PinBtn.Name = "PinBtn"
        Me.PinBtn.ShadowDecoration.Parent = Me.PinBtn
        Me.PinBtn.Size = New System.Drawing.Size(180, 45)
        Me.PinBtn.TabIndex = 35
        Me.PinBtn.Text = "Change pin"
        '
        'forgotpass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(450, 555)
        Me.Controls.Add(Me.PinBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.cardnoBtn)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.txtOtp)
        Me.Controls.Add(Me.txtacc)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "forgotpass"
        Me.Text = "forgotpass"
        Me.panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents txtacc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtOtp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cardnoBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents OkBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PinBtn As Guna.UI2.WinForms.Guna2GradientButton
End Class
