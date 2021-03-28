<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class approveform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(approveform))
        Me.panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.clsBtn = New FontAwesome.Sharp.IconPictureBox()
        Me.minBtn = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.picbx1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.cmbacc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.approveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblFname = New System.Windows.Forms.Label()
        Me.lblLname = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPanno = New System.Windows.Forms.Label()
        Me.lblAcctype = New System.Windows.Forms.Label()
        Me.rejectBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAddr = New System.Windows.Forms.Label()
        Me.Pnlreject = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.closebtn = New FontAwesome.Sharp.IconPictureBox()
        Me.btnReject = New Guna.UI2.WinForms.Guna2Button()
        Me.txtreason = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        CType(Me.clsBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnlreject.SuspendLayout()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.clsBtn)
        Me.panel1.Controls.Add(Me.minBtn)
        Me.panel1.Controls.Add(Me.IconPictureBox3)
        Me.panel1.Controls.Add(Me.IconPictureBox2)
        Me.panel1.FillColor = System.Drawing.Color.Magenta
        Me.panel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(-1, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.ShadowDecoration.Parent = Me.panel1
        Me.panel1.Size = New System.Drawing.Size(509, 30)
        Me.panel1.TabIndex = 31
        '
        'clsBtn
        '
        Me.clsBtn.BackColor = System.Drawing.Color.Transparent
        Me.clsBtn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.clsBtn.IconColor = System.Drawing.Color.White
        Me.clsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clsBtn.Location = New System.Drawing.Point(474, 0)
        Me.clsBtn.Name = "clsBtn"
        Me.clsBtn.Size = New System.Drawing.Size(32, 32)
        Me.clsBtn.TabIndex = 6
        Me.clsBtn.TabStop = False
        '
        'minBtn
        '
        Me.minBtn.BackColor = System.Drawing.Color.Transparent
        Me.minBtn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.minBtn.IconColor = System.Drawing.Color.White
        Me.minBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.minBtn.IconSize = 27
        Me.minBtn.Location = New System.Drawing.Point(450, -3)
        Me.minBtn.Name = "minBtn"
        Me.minBtn.Size = New System.Drawing.Size(27, 30)
        Me.minBtn.TabIndex = 5
        Me.minBtn.TabStop = False
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
        'picbx1
        '
        Me.picbx1.Image = CType(resources.GetObject("picbx1.Image"), System.Drawing.Image)
        Me.picbx1.Location = New System.Drawing.Point(331, 78)
        Me.picbx1.Name = "picbx1"
        Me.picbx1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picbx1.ShadowDecoration.Parent = Me.picbx1
        Me.picbx1.Size = New System.Drawing.Size(145, 150)
        Me.picbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbx1.TabIndex = 32
        Me.picbx1.TabStop = False
        '
        'cmbacc
        '
        Me.cmbacc.FormattingEnabled = True
        Me.cmbacc.Location = New System.Drawing.Point(25, 98)
        Me.cmbacc.Name = "cmbacc"
        Me.cmbacc.Size = New System.Drawing.Size(213, 24)
        Me.cmbacc.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(22, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "First name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(22, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Last name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(20, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Address :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(22, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 25)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Contact no. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(20, 447)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Gender :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(20, 508)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "DOB :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(22, 566)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 25)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Email :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(20, 620)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 25)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Pan no. :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(20, 682)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 25)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Account type :"
        '
        'approveBtn
        '
        Me.approveBtn.CheckedState.Parent = Me.approveBtn
        Me.approveBtn.CustomImages.Parent = Me.approveBtn
        Me.approveBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.approveBtn.ForeColor = System.Drawing.Color.Black
        Me.approveBtn.HoverState.Parent = Me.approveBtn
        Me.approveBtn.Location = New System.Drawing.Point(27, 759)
        Me.approveBtn.Name = "approveBtn"
        Me.approveBtn.ShadowDecoration.Parent = Me.approveBtn
        Me.approveBtn.Size = New System.Drawing.Size(180, 45)
        Me.approveBtn.TabIndex = 44
        Me.approveBtn.Text = "Approve"
        '
        'lblFname
        '
        Me.lblFname.AutoSize = True
        Me.lblFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFname.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFname.Location = New System.Drawing.Point(202, 203)
        Me.lblFname.Name = "lblFname"
        Me.lblFname.Size = New System.Drawing.Size(0, 25)
        Me.lblFname.TabIndex = 45
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLname.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblLname.Location = New System.Drawing.Point(202, 267)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(0, 25)
        Me.lblLname.TabIndex = 46
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblContact.Location = New System.Drawing.Point(202, 386)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(0, 25)
        Me.lblContact.TabIndex = 47
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblGender.Location = New System.Drawing.Point(202, 447)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(0, 25)
        Me.lblGender.TabIndex = 48
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblDob.Location = New System.Drawing.Point(202, 508)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(0, 25)
        Me.lblDob.TabIndex = 49
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblEmail.Location = New System.Drawing.Point(202, 566)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(0, 25)
        Me.lblEmail.TabIndex = 50
        '
        'lblPanno
        '
        Me.lblPanno.AutoSize = True
        Me.lblPanno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanno.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPanno.Location = New System.Drawing.Point(202, 620)
        Me.lblPanno.Name = "lblPanno"
        Me.lblPanno.Size = New System.Drawing.Size(0, 25)
        Me.lblPanno.TabIndex = 51
        '
        'lblAcctype
        '
        Me.lblAcctype.AutoSize = True
        Me.lblAcctype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcctype.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAcctype.Location = New System.Drawing.Point(202, 682)
        Me.lblAcctype.Name = "lblAcctype"
        Me.lblAcctype.Size = New System.Drawing.Size(0, 25)
        Me.lblAcctype.TabIndex = 55
        '
        'rejectBtn
        '
        Me.rejectBtn.CheckedState.Parent = Me.rejectBtn
        Me.rejectBtn.CustomImages.Parent = Me.rejectBtn
        Me.rejectBtn.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.rejectBtn.ForeColor = System.Drawing.Color.Black
        Me.rejectBtn.HoverState.Parent = Me.rejectBtn
        Me.rejectBtn.Location = New System.Drawing.Point(300, 759)
        Me.rejectBtn.Name = "rejectBtn"
        Me.rejectBtn.ShadowDecoration.Parent = Me.rejectBtn
        Me.rejectBtn.Size = New System.Drawing.Size(180, 45)
        Me.rejectBtn.TabIndex = 56
        Me.rejectBtn.Text = "Reject"
        '
        'lblAddr
        '
        Me.lblAddr.AutoSize = True
        Me.lblAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddr.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAddr.Location = New System.Drawing.Point(202, 325)
        Me.lblAddr.Name = "lblAddr"
        Me.lblAddr.Size = New System.Drawing.Size(0, 25)
        Me.lblAddr.TabIndex = 57
        '
        'Pnlreject
        '
        Me.Pnlreject.Controls.Add(Me.closebtn)
        Me.Pnlreject.Controls.Add(Me.btnReject)
        Me.Pnlreject.Controls.Add(Me.txtreason)
        Me.Pnlreject.Controls.Add(Me.Label12)
        Me.Pnlreject.FillColor = System.Drawing.Color.Gold
        Me.Pnlreject.FillColor2 = System.Drawing.Color.Red
        Me.Pnlreject.Location = New System.Drawing.Point(291, 567)
        Me.Pnlreject.Name = "Pnlreject"
        Me.Pnlreject.ShadowDecoration.Parent = Me.Pnlreject
        Me.Pnlreject.Size = New System.Drawing.Size(214, 237)
        Me.Pnlreject.TabIndex = 58
        '
        'closebtn
        '
        Me.closebtn.BackColor = System.Drawing.Color.Transparent
        Me.closebtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.closebtn.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.closebtn.IconColor = System.Drawing.SystemColors.ControlText
        Me.closebtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.closebtn.Location = New System.Drawing.Point(182, 0)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(32, 32)
        Me.closebtn.TabIndex = 61
        Me.closebtn.TabStop = False
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
        'approveform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(504, 828)
        Me.Controls.Add(Me.Pnlreject)
        Me.Controls.Add(Me.lblAddr)
        Me.Controls.Add(Me.rejectBtn)
        Me.Controls.Add(Me.lblAcctype)
        Me.Controls.Add(Me.lblPanno)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblLname)
        Me.Controls.Add(Me.lblFname)
        Me.Controls.Add(Me.approveBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbacc)
        Me.Controls.Add(Me.picbx1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "approveform"
        Me.Text = "approveform"
        Me.panel1.ResumeLayout(False)
        CType(Me.clsBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnlreject.ResumeLayout(False)
        Me.Pnlreject.PerformLayout()
        CType(Me.closebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents clsBtn As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents minBtn As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents picbx1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents cmbacc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents approveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblFname As Label
    Friend WithEvents lblLname As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDob As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPanno As Label
    Friend WithEvents lblAcctype As Label
    Friend WithEvents rejectBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblAddr As Label
    Friend WithEvents Pnlreject As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnReject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtreason As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents closebtn As FontAwesome.Sharp.IconPictureBox
End Class
