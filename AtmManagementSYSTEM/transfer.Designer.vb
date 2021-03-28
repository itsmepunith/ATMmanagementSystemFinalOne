<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transfer))
        Me.panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.exitBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtAmt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblAcc = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtcard = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtwelcome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtAcc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnTransfer = New Guna.UI2.WinForms.Guna2GradientButton()
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
        Me.panel1.Location = New System.Drawing.Point(1, 0)
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
        Me.IconPictureBox1.Location = New System.Drawing.Point(454, 0)
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
        Me.IconPictureBox4.Location = New System.Drawing.Point(418, -3)
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
        Me.exitBtn.Location = New System.Drawing.Point(254, 598)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.ShadowDecoration.Parent = Me.exitBtn
        Me.exitBtn.Size = New System.Drawing.Size(192, 45)
        Me.exitBtn.TabIndex = 36
        Me.exitBtn.Text = "Back"
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
        Me.txtAmt.Location = New System.Drawing.Point(92, 519)
        Me.txtAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAmt.PlaceholderText = "Enter amount"
        Me.txtAmt.SelectedText = ""
        Me.txtAmt.ShadowDecoration.Parent = Me.txtAmt
        Me.txtAmt.Size = New System.Drawing.Size(287, 56)
        Me.txtAmt.TabIndex = 34
        '
        'lblAcc
        '
        Me.lblAcc.BackColor = System.Drawing.Color.Transparent
        Me.lblAcc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcc.ForeColor = System.Drawing.Color.White
        Me.lblAcc.Location = New System.Drawing.Point(164, 395)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(11, 30)
        Me.lblAcc.TabIndex = 33
        Me.lblAcc.Text = "1"
        '
        'txtcard
        '
        Me.txtcard.BackColor = System.Drawing.Color.Transparent
        Me.txtcard.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcard.ForeColor = System.Drawing.Color.White
        Me.txtcard.Location = New System.Drawing.Point(13, 395)
        Me.txtcard.Name = "txtcard"
        Me.txtcard.Size = New System.Drawing.Size(79, 30)
        Me.txtcard.TabIndex = 32
        Me.txtcard.Text = "Card no."
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(162, 348)
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
        Me.txtwelcome.Location = New System.Drawing.Point(13, 345)
        Me.txtwelcome.Name = "txtwelcome"
        Me.txtwelcome.Size = New System.Drawing.Size(106, 33)
        Me.txtwelcome.TabIndex = 30
        Me.txtwelcome.Text = "Welcome, "
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(487, 312)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 29
        Me.Guna2PictureBox1.TabStop = False
        '
        'txtAcc
        '
        Me.txtAcc.Animated = True
        Me.txtAcc.AutoRoundedCorners = True
        Me.txtAcc.BorderColor = System.Drawing.Color.Empty
        Me.txtAcc.BorderRadius = 27
        Me.txtAcc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAcc.DefaultText = ""
        Me.txtAcc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAcc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAcc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAcc.DisabledState.Parent = Me.txtAcc
        Me.txtAcc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAcc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAcc.FocusedState.Parent = Me.txtAcc
        Me.txtAcc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAcc.ForeColor = System.Drawing.Color.Black
        Me.txtAcc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAcc.HoverState.Parent = Me.txtAcc
        Me.txtAcc.Location = New System.Drawing.Point(92, 453)
        Me.txtAcc.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAcc.Name = "txtAcc"
        Me.txtAcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAcc.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAcc.PlaceholderText = "Card Number"
        Me.txtAcc.SelectedText = ""
        Me.txtAcc.ShadowDecoration.Parent = Me.txtAcc
        Me.txtAcc.Size = New System.Drawing.Size(287, 56)
        Me.txtAcc.TabIndex = 37
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(350, 348)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(56, 37)
        Me.lblDate.TabIndex = 38
        Me.lblDate.Text = "Date"
        '
        'BtnTransfer
        '
        Me.BtnTransfer.BorderRadius = 21
        Me.BtnTransfer.CheckedState.Parent = Me.BtnTransfer
        Me.BtnTransfer.CustomImages.Parent = Me.BtnTransfer
        Me.BtnTransfer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnTransfer.ForeColor = System.Drawing.Color.Black
        Me.BtnTransfer.HoverState.Parent = Me.BtnTransfer
        Me.BtnTransfer.Location = New System.Drawing.Point(44, 598)
        Me.BtnTransfer.Name = "BtnTransfer"
        Me.BtnTransfer.ShadowDecoration.Parent = Me.BtnTransfer
        Me.BtnTransfer.Size = New System.Drawing.Size(180, 45)
        Me.BtnTransfer.TabIndex = 39
        Me.BtnTransfer.Text = "Transfer"
        '
        'transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(486, 687)
        Me.Controls.Add(Me.BtnTransfer)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtAcc)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.lblAcc)
        Me.Controls.Add(Me.txtcard)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtwelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transfer"
        Me.Text = "transfer"
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
    Friend WithEvents exitBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtAmt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAcc As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcard As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtwelcome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtAcc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BtnTransfer As Guna.UI2.WinForms.Guna2GradientButton
End Class
