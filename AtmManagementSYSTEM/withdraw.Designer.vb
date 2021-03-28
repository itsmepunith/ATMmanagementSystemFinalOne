<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class withdraw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(withdraw))
        Me.panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.exitBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.withdrawBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtAmt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcard = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtwelcome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAcc = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        Me.panel1.TabIndex = 11
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.Location = New System.Drawing.Point(437, 0)
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
        Me.IconPictureBox4.Location = New System.Drawing.Point(400, 0)
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
        'exitBtn
        '
        Me.exitBtn.AutoRoundedCorners = True
        Me.exitBtn.BorderRadius = 21
        Me.exitBtn.CheckedState.Parent = Me.exitBtn
        Me.exitBtn.CustomImages.Parent = Me.exitBtn
        Me.exitBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.exitBtn.ForeColor = System.Drawing.Color.Black
        Me.exitBtn.HoverState.Parent = Me.exitBtn
        Me.exitBtn.Location = New System.Drawing.Point(247, 585)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.ShadowDecoration.Parent = Me.exitBtn
        Me.exitBtn.Size = New System.Drawing.Size(180, 45)
        Me.exitBtn.TabIndex = 19
        Me.exitBtn.Text = "Back"
        '
        'withdrawBtn
        '
        Me.withdrawBtn.AutoRoundedCorners = True
        Me.withdrawBtn.BorderRadius = 21
        Me.withdrawBtn.CheckedState.Parent = Me.withdrawBtn
        Me.withdrawBtn.CustomImages.Parent = Me.withdrawBtn
        Me.withdrawBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.withdrawBtn.ForeColor = System.Drawing.Color.Black
        Me.withdrawBtn.HoverState.Parent = Me.withdrawBtn
        Me.withdrawBtn.Location = New System.Drawing.Point(34, 585)
        Me.withdrawBtn.Name = "withdrawBtn"
        Me.withdrawBtn.ShadowDecoration.Parent = Me.withdrawBtn
        Me.withdrawBtn.Size = New System.Drawing.Size(180, 45)
        Me.withdrawBtn.TabIndex = 18
        Me.withdrawBtn.Text = "Withdraw"
        '
        'txtAmt
        '
        Me.txtAmt.Animated = True
        Me.txtAmt.AutoRoundedCorners = True
        Me.txtAmt.BorderColor = System.Drawing.Color.Empty
        Me.txtAmt.BorderRadius = 27
        Me.txtAmt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmt.DefaultText = ""
        Me.txtAmt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmt.DisabledState.Parent = Me.txtAmt
        Me.txtAmt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmt.FocusedState.Parent = Me.txtAmt
        Me.txtAmt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAmt.ForeColor = System.Drawing.Color.Black
        Me.txtAmt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmt.HoverState.Parent = Me.txtAmt
        Me.txtAmt.Location = New System.Drawing.Point(12, 494)
        Me.txtAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAmt.PlaceholderText = "Enter Amount"
        Me.txtAmt.SelectedText = ""
        Me.txtAmt.ShadowDecoration.Parent = Me.txtAmt
        Me.txtAmt.Size = New System.Drawing.Size(442, 56)
        Me.txtAmt.TabIndex = 17
        '
        'txtcard
        '
        Me.txtcard.BackColor = System.Drawing.Color.Transparent
        Me.txtcard.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard.ForeColor = System.Drawing.Color.White
        Me.txtcard.Location = New System.Drawing.Point(12, 433)
        Me.txtcard.Name = "txtcard"
        Me.txtcard.Size = New System.Drawing.Size(79, 30)
        Me.txtcard.TabIndex = 15
        Me.txtcard.Text = "Card no."
        '
        'txtwelcome
        '
        Me.txtwelcome.BackColor = System.Drawing.Color.Transparent
        Me.txtwelcome.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwelcome.ForeColor = System.Drawing.Color.White
        Me.txtwelcome.Location = New System.Drawing.Point(12, 367)
        Me.txtwelcome.Name = "txtwelcome"
        Me.txtwelcome.Size = New System.Drawing.Size(106, 33)
        Me.txtwelcome.TabIndex = 13
        Me.txtwelcome.Text = "Welcome, "
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(503, 292)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 12
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(143, 367)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 33)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "name"
        '
        'lblAcc
        '
        Me.lblAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblAcc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcc.ForeColor = System.Drawing.Color.White
        Me.lblAcc.Location = New System.Drawing.Point(143, 433)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(12, 33)
        Me.lblAcc.TabIndex = 21
        Me.lblAcc.Text = "1"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(309, 367)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(52, 33)
        Me.lblDate.TabIndex = 22
        Me.lblDate.Text = "Date"
        '
        'withdraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(472, 663)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAcc)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.withdrawBtn)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.txtcard)
        Me.Controls.Add(Me.txtwelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "withdraw"
        Me.Text = "withdraw"
        Me.panel1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents exitBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents withdrawBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtAmt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcard As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtwelcome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAcc As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
