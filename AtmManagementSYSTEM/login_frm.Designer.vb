<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_frm))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.newusr = New Guna.UI.WinForms.GunaLinkLabel()
        Me.linkForgot = New Guna.UI.WinForms.GunaLinkLabel()
        Me.login = New Guna.UI2.WinForms.Guna2Button()
        Me.loginbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtPin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAcc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.IconPictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.IconPictureBox1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Magenta
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1047, 29)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 29
        Me.IconPictureBox2.Location = New System.Drawing.Point(977, -8)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(29, 37)
        Me.IconPictureBox2.TabIndex = 1
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 29
        Me.IconPictureBox1.Location = New System.Drawing.Point(1012, 0)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 29)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(1053, 780)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.newusr)
        Me.Guna2Panel1.Controls.Add(Me.linkForgot)
        Me.Guna2Panel1.Controls.Add(Me.login)
        Me.Guna2Panel1.Controls.Add(Me.loginbtn)
        Me.Guna2Panel1.Controls.Add(Me.txtPin)
        Me.Guna2Panel1.Controls.Add(Me.txtAcc)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(295, 114)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(438, 619)
        Me.Guna2Panel1.TabIndex = 2
        '
        'newusr
        '
        Me.newusr.AutoSize = True
        Me.newusr.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.newusr.LinkColor = System.Drawing.Color.White
        Me.newusr.Location = New System.Drawing.Point(13, 590)
        Me.newusr.Name = "newusr"
        Me.newusr.Size = New System.Drawing.Size(198, 20)
        Me.newusr.TabIndex = 3
        Me.newusr.TabStop = True
        Me.newusr.Text = "New User?? Register here!!"
        '
        'linkForgot
        '
        Me.linkForgot.AutoSize = True
        Me.linkForgot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.linkForgot.LinkColor = System.Drawing.Color.White
        Me.linkForgot.Location = New System.Drawing.Point(44, 484)
        Me.linkForgot.Name = "linkForgot"
        Me.linkForgot.Size = New System.Drawing.Size(172, 20)
        Me.linkForgot.TabIndex = 4
        Me.linkForgot.TabStop = True
        Me.linkForgot.Text = "Forgot Pin? ,  Click here"
        '
        'login
        '
        Me.login.AutoRoundedCorners = True
        Me.login.BorderRadius = 17
        Me.login.CheckedState.Parent = Me.login
        Me.login.CustomImages.Parent = Me.login
        Me.login.CustomizableEdges.BottomLeft = False
        Me.login.CustomizableEdges.TopRight = False
        Me.login.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.login.ForeColor = System.Drawing.Color.White
        Me.login.HoverState.Parent = Me.login
        Me.login.Location = New System.Drawing.Point(141, 295)
        Me.login.Name = "login"
        Me.login.ShadowDecoration.Parent = Me.login
        Me.login.Size = New System.Drawing.Size(153, 36)
        Me.login.TabIndex = 4
        Me.login.Text = "Login"
        '
        'loginbtn
        '
        Me.loginbtn.AutoRoundedCorners = True
        Me.loginbtn.BorderRadius = 19
        Me.loginbtn.CheckedState.Parent = Me.loginbtn
        Me.loginbtn.CustomImages.Parent = Me.loginbtn
        Me.loginbtn.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.loginbtn.HoverState.Parent = Me.loginbtn
        Me.loginbtn.Location = New System.Drawing.Point(141, 522)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.ShadowDecoration.Parent = Me.loginbtn
        Me.loginbtn.Size = New System.Drawing.Size(176, 41)
        Me.loginbtn.TabIndex = 3
        Me.loginbtn.Text = "Login"
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
        Me.txtPin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPin.ForeColor = System.Drawing.Color.Black
        Me.txtPin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPin.HoverState.Parent = Me.txtPin
        Me.txtPin.Location = New System.Drawing.Point(66, 427)
        Me.txtPin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPin.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPin.PlaceholderText = "Pin"
        Me.txtPin.SelectedText = ""
        Me.txtPin.ShadowDecoration.Parent = Me.txtPin
        Me.txtPin.Size = New System.Drawing.Size(287, 36)
        Me.txtPin.TabIndex = 2
        '
        'txtAcc
        '
        Me.txtAcc.AutoRoundedCorners = True
        Me.txtAcc.BorderRadius = 17
        Me.txtAcc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAcc.DefaultText = ""
        Me.txtAcc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAcc.DisabledState.Parent = Me.txtAcc
        Me.txtAcc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAcc.FillColor = System.Drawing.Color.AliceBlue
        Me.txtAcc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAcc.FocusedState.Parent = Me.txtAcc
        Me.txtAcc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAcc.ForeColor = System.Drawing.Color.Black
        Me.txtAcc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAcc.HoverState.Parent = Me.txtAcc
        Me.txtAcc.Location = New System.Drawing.Point(66, 359)
        Me.txtAcc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAcc.Name = "txtAcc"
        Me.txtAcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcc.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAcc.PlaceholderText = "Card no."
        Me.txtAcc.SelectedText = ""
        Me.txtAcc.ShadowDecoration.Parent = Me.txtAcc
        Me.txtAcc.Size = New System.Drawing.Size(287, 36)
        Me.txtAcc.TabIndex = 1
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(438, 279)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 0
        Me.Guna2PictureBox2.TabStop = False
        '
        'login_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1047, 807)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login_frm"
        Me.Text = "login_frm"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents loginbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtPin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAcc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents newusr As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents linkForgot As Guna.UI.WinForms.GunaLinkLabel
End Class
