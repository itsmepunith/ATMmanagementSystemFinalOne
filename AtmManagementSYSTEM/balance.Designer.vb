<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class balance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(balance))
        Me.panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Balancebtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblAcc = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblcard = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtwelcome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblBal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblbalance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ExitBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.panel1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.ShadowDecoration.Parent = Me.panel1
        Me.panel1.Size = New System.Drawing.Size(503, 30)
        Me.panel1.TabIndex = 28
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(425, 0)
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
        Me.IconPictureBox4.Location = New System.Drawing.Point(391, -3)
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
        'Balancebtn
        '
        Me.Balancebtn.AutoRoundedCorners = True
        Me.Balancebtn.BorderRadius = 21
        Me.Balancebtn.CheckedState.Parent = Me.Balancebtn
        Me.Balancebtn.CustomImages.Parent = Me.Balancebtn
        Me.Balancebtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Balancebtn.ForeColor = System.Drawing.Color.Black
        Me.Balancebtn.HoverState.Parent = Me.Balancebtn
        Me.Balancebtn.Location = New System.Drawing.Point(24, 524)
        Me.Balancebtn.Name = "Balancebtn"
        Me.Balancebtn.ShadowDecoration.Parent = Me.Balancebtn
        Me.Balancebtn.Size = New System.Drawing.Size(180, 45)
        Me.Balancebtn.TabIndex = 35
        Me.Balancebtn.Text = "Check Balance"
        '
        'lblAcc
        '
        Me.lblAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblAcc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcc.ForeColor = System.Drawing.Color.White
        Me.lblAcc.Location = New System.Drawing.Point(163, 396)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(11, 30)
        Me.lblAcc.TabIndex = 33
        Me.lblAcc.Text = "1"
        '
        'lblcard
        '
        Me.lblcard.BackColor = System.Drawing.Color.Transparent
        Me.lblcard.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcard.ForeColor = System.Drawing.Color.White
        Me.lblcard.Location = New System.Drawing.Point(12, 396)
        Me.lblcard.Name = "lblcard"
        Me.lblcard.Size = New System.Drawing.Size(79, 30)
        Me.lblcard.TabIndex = 32
        Me.lblcard.Text = "Card no."
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(161, 349)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(13, 30)
        Me.lblName.TabIndex = 31
        Me.lblName.Text = "a"
        '
        'txtwelcome
        '
        Me.txtwelcome.BackColor = System.Drawing.Color.Transparent
        Me.txtwelcome.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwelcome.ForeColor = System.Drawing.Color.White
        Me.txtwelcome.Location = New System.Drawing.Point(12, 346)
        Me.txtwelcome.Name = "txtwelcome"
        Me.txtwelcome.Size = New System.Drawing.Size(106, 33)
        Me.txtwelcome.TabIndex = 30
        Me.txtwelcome.Text = "Welcome, "
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(469, 292)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 29
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblBal
        '
        Me.lblBal.BackColor = System.Drawing.Color.Transparent
        Me.lblBal.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBal.ForeColor = System.Drawing.Color.White
        Me.lblBal.Location = New System.Drawing.Point(309, 455)
        Me.lblBal.Name = "lblBal"
        Me.lblBal.Size = New System.Drawing.Size(13, 30)
        Me.lblBal.TabIndex = 38
        Me.lblBal.Text = "a"
        '
        'lblbalance
        '
        Me.lblbalance.BackColor = System.Drawing.Color.Transparent
        Me.lblbalance.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.ForeColor = System.Drawing.Color.White
        Me.lblbalance.Location = New System.Drawing.Point(12, 455)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(260, 27)
        Me.lblbalance.TabIndex = 37
        Me.lblbalance.Text = "Your account balance is rupees"
        '
        'ExitBtn
        '
        Me.ExitBtn.AutoRoundedCorners = True
        Me.ExitBtn.BorderRadius = 21
        Me.ExitBtn.CheckedState.Parent = Me.ExitBtn
        Me.ExitBtn.CustomImages.Parent = Me.ExitBtn
        Me.ExitBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ExitBtn.ForeColor = System.Drawing.Color.Black
        Me.ExitBtn.HoverState.Parent = Me.ExitBtn
        Me.ExitBtn.Location = New System.Drawing.Point(266, 524)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.ShadowDecoration.Parent = Me.ExitBtn
        Me.ExitBtn.Size = New System.Drawing.Size(161, 45)
        Me.ExitBtn.TabIndex = 36
        Me.ExitBtn.Text = "Back"
        '
        'balance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(455, 598)
        Me.Controls.Add(Me.lblBal)
        Me.Controls.Add(Me.lblbalance)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Balancebtn)
        Me.Controls.Add(Me.lblAcc)
        Me.Controls.Add(Me.lblcard)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtwelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "balance"
        Me.Text = "balance"
        Me.panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Balancebtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblAcc As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblcard As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtwelcome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblbalance As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ExitBtn As Guna.UI2.WinForms.Guna2GradientButton
End Class
