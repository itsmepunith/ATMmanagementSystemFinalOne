<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan_approve
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
        Me.closeBtn = New FontAwesome.Sharp.IconPictureBox()
        Me.minimizeBtn = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCard = New System.Windows.Forms.ComboBox()
        Me.Pnlreject = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnCls = New FontAwesome.Sharp.IconPictureBox()
        Me.btnReject = New Guna.UI2.WinForms.Guna2Button()
        Me.txtreason = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.approveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.rejectBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblmthAmt = New System.Windows.Forms.Label()
        Me.lblmth = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnlreject.SuspendLayout()
        CType(Me.btnCls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.closeBtn)
        Me.panel1.Controls.Add(Me.minimizeBtn)
        Me.panel1.Controls.Add(Me.IconPictureBox5)
        Me.panel1.Controls.Add(Me.IconPictureBox6)
        Me.panel1.FillColor = System.Drawing.Color.Magenta
        Me.panel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(-1, -1)
        Me.panel1.Name = "panel1"
        Me.panel1.ShadowDecoration.Parent = Me.panel1
        Me.panel1.Size = New System.Drawing.Size(721, 30)
        Me.panel1.TabIndex = 29
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.closeBtn.IconColor = System.Drawing.Color.White
        Me.closeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closeBtn.Location = New System.Drawing.Point(574, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(32, 32)
        Me.closeBtn.TabIndex = 6
        Me.closeBtn.TabStop = False
        '
        'minimizeBtn
        '
        Me.minimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.minimizeBtn.IconColor = System.Drawing.Color.White
        Me.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.minimizeBtn.IconSize = 27
        Me.minimizeBtn.Location = New System.Drawing.Point(541, 3)
        Me.minimizeBtn.Name = "minimizeBtn"
        Me.minimizeBtn.Size = New System.Drawing.Size(27, 30)
        Me.minimizeBtn.TabIndex = 5
        Me.minimizeBtn.TabStop = False
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox5.IconColor = System.Drawing.Color.White
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.Location = New System.Drawing.Point(1007, 3)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox5.TabIndex = 4
        Me.IconPictureBox5.TabStop = False
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconPictureBox6.IconColor = System.Drawing.Color.White
        Me.IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox6.IconSize = 27
        Me.IconPictureBox6.Location = New System.Drawing.Point(974, -1)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(27, 30)
        Me.IconPictureBox6.TabIndex = 3
        Me.IconPictureBox6.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(26, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 25)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Total months :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(26, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 25)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Amount (per month) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(28, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Email :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(26, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Total amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(28, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(28, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Card no. :"
        '
        'cmbCard
        '
        Me.cmbCard.FormattingEnabled = True
        Me.cmbCard.Location = New System.Drawing.Point(31, 62)
        Me.cmbCard.Name = "cmbCard"
        Me.cmbCard.Size = New System.Drawing.Size(213, 24)
        Me.cmbCard.TabIndex = 40
        '
        'Pnlreject
        '
        Me.Pnlreject.Controls.Add(Me.btnCls)
        Me.Pnlreject.Controls.Add(Me.btnReject)
        Me.Pnlreject.Controls.Add(Me.txtreason)
        Me.Pnlreject.Controls.Add(Me.Label12)
        Me.Pnlreject.FillColor = System.Drawing.Color.Gold
        Me.Pnlreject.FillColor2 = System.Drawing.Color.Red
        Me.Pnlreject.Location = New System.Drawing.Point(383, 472)
        Me.Pnlreject.Name = "Pnlreject"
        Me.Pnlreject.ShadowDecoration.Parent = Me.Pnlreject
        Me.Pnlreject.Size = New System.Drawing.Size(214, 237)
        Me.Pnlreject.TabIndex = 60
        '
        'btnCls
        '
        Me.btnCls.BackColor = System.Drawing.Color.Transparent
        Me.btnCls.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCls.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCls.IconColor = System.Drawing.SystemColors.ControlText
        Me.btnCls.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCls.Location = New System.Drawing.Point(182, 0)
        Me.btnCls.Name = "btnCls"
        Me.btnCls.Size = New System.Drawing.Size(32, 32)
        Me.btnCls.TabIndex = 61
        Me.btnCls.TabStop = False
        '
        'btnReject
        '
        Me.btnReject.CheckedState.Parent = Me.btnReject
        Me.btnReject.CustomImages.Parent = Me.btnReject
        Me.btnReject.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnReject.ForeColor = System.Drawing.Color.Black
        Me.btnReject.HoverState.Parent = Me.btnReject
        Me.btnReject.Location = New System.Drawing.Point(24, 179)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.ShadowDecoration.Parent = Me.btnReject
        Me.btnReject.Size = New System.Drawing.Size(156, 45)
        Me.btnReject.TabIndex = 59
        Me.btnReject.Text = "Reject"
        '
        'txtreason
        '
        Me.txtreason.Location = New System.Drawing.Point(9, 71)
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(191, 96)
        Me.txtreason.TabIndex = 60
        Me.txtreason.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label12.Location = New System.Drawing.Point(4, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 25)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Reason"
        '
        'approveBtn
        '
        Me.approveBtn.CheckedState.Parent = Me.approveBtn
        Me.approveBtn.CustomImages.Parent = Me.approveBtn
        Me.approveBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.approveBtn.ForeColor = System.Drawing.Color.Black
        Me.approveBtn.HoverState.Parent = Me.approveBtn
        Me.approveBtn.Location = New System.Drawing.Point(114, 660)
        Me.approveBtn.Name = "approveBtn"
        Me.approveBtn.ShadowDecoration.Parent = Me.approveBtn
        Me.approveBtn.Size = New System.Drawing.Size(180, 45)
        Me.approveBtn.TabIndex = 59
        Me.approveBtn.Text = "Approve"
        '
        'rejectBtn
        '
        Me.rejectBtn.CheckedState.Parent = Me.rejectBtn
        Me.rejectBtn.CustomImages.Parent = Me.rejectBtn
        Me.rejectBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.rejectBtn.ForeColor = System.Drawing.Color.Black
        Me.rejectBtn.HoverState.Parent = Me.rejectBtn
        Me.rejectBtn.Location = New System.Drawing.Point(387, 660)
        Me.rejectBtn.Name = "rejectBtn"
        Me.rejectBtn.ShadowDecoration.Parent = Me.rejectBtn
        Me.rejectBtn.Size = New System.Drawing.Size(180, 45)
        Me.rejectBtn.TabIndex = 61
        Me.rejectBtn.Text = "Reject"
        '
        'lblCard
        '
        Me.lblCard.AutoSize = True
        Me.lblCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblCard.Location = New System.Drawing.Point(243, 167)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(0, 25)
        Me.lblCard.TabIndex = 62
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblName.Location = New System.Drawing.Point(243, 231)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 25)
        Me.lblName.TabIndex = 63
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmt.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAmt.Location = New System.Drawing.Point(243, 289)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(0, 25)
        Me.lblAmt.TabIndex = 64
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblEmail.Location = New System.Drawing.Point(243, 337)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(0, 25)
        Me.lblEmail.TabIndex = 65
        '
        'lblmthAmt
        '
        Me.lblmthAmt.AutoSize = True
        Me.lblmthAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmthAmt.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblmthAmt.Location = New System.Drawing.Point(249, 411)
        Me.lblmthAmt.Name = "lblmthAmt"
        Me.lblmthAmt.Size = New System.Drawing.Size(0, 25)
        Me.lblmthAmt.TabIndex = 66
        '
        'lblmth
        '
        Me.lblmth.AutoSize = True
        Me.lblmth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmth.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblmth.Location = New System.Drawing.Point(243, 472)
        Me.lblmth.Name = "lblmth"
        Me.lblmth.Size = New System.Drawing.Size(0, 25)
        Me.lblmth.TabIndex = 67
        '
        'Loan_approve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 717)
        Me.Controls.Add(Me.lblmth)
        Me.Controls.Add(Me.lblmthAmt)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCard)
        Me.Controls.Add(Me.Pnlreject)
        Me.Controls.Add(Me.rejectBtn)
        Me.Controls.Add(Me.approveBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCard)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loan_approve"
        Me.Text = "Loan_approve"
        Me.panel1.ResumeLayout(False)
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnlreject.ResumeLayout(False)
        Me.Pnlreject.PerformLayout()
        CType(Me.btnCls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents closeBtn As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents minimizeBtn As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCard As ComboBox
    Friend WithEvents Pnlreject As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnCls As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnReject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtreason As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents approveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents rejectBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCard As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAmt As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblmthAmt As Label
    Friend WithEvents lblmth As Label
End Class
