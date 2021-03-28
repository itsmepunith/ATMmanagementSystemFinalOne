<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class applyLoan
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
        Me.Panel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.cardnum = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.welcum = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.crdlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.namelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlgetLoan = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.chckEligibility = New Guna.UI2.WinForms.Guna2Button()
        Me.duedtp = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbldue = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtemi = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblemi = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.interestCmb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loandtp = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbldate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.periodCmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.periodlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ttlamt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.amt = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblagree = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.checkbox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.calcBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblinterest = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblamt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.getLoan = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlmain = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnlInterestpay = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ttlemiamt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblamtttl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.amtemi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.calcemi = New Guna.UI2.WinForms.Guna2Button()
        Me.nextdue = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.duelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.paidlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblpaid = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.exitBtn = New FontAwesome.Sharp.IconPictureBox()
        Me.PayemiBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dueemi = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblduedate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblamtrepay = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlgetLoan.SuspendLayout()
        Me.pnlmain.SuspendLayout()
        Me.pnlInterestpay.SuspendLayout()
        CType(Me.exitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IconPictureBox3)
        Me.Panel1.Controls.Add(Me.IconPictureBox2)
        Me.Panel1.FillColor = System.Drawing.Color.Magenta
        Me.Panel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.ShadowDecoration.Parent = Me.Panel1
        Me.Panel1.Size = New System.Drawing.Size(926, 30)
        Me.Panel1.TabIndex = 1
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.IconPictureBox3.IconColor = System.Drawing.Color.White
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.Location = New System.Drawing.Point(891, 0)
        Me.IconPictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.IconPictureBox2.Location = New System.Drawing.Point(858, -2)
        Me.IconPictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(27, 30)
        Me.IconPictureBox2.TabIndex = 3
        Me.IconPictureBox2.TabStop = False
        '
        'cardnum
        '
        Me.cardnum.BackColor = System.Drawing.Color.Transparent
        Me.cardnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cardnum.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cardnum.Location = New System.Drawing.Point(12, 47)
        Me.cardnum.Name = "cardnum"
        Me.cardnum.Size = New System.Drawing.Size(81, 27)
        Me.cardnum.TabIndex = 5
        Me.cardnum.Text = "Card No."
        '
        'welcum
        '
        Me.welcum.BackColor = System.Drawing.Color.Transparent
        Me.welcum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcum.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.welcum.Location = New System.Drawing.Point(12, 80)
        Me.welcum.Name = "welcum"
        Me.welcum.Size = New System.Drawing.Size(86, 27)
        Me.welcum.TabIndex = 6
        Me.welcum.Text = "Welcome"
        '
        'crdlbl
        '
        Me.crdlbl.BackColor = System.Drawing.Color.Transparent
        Me.crdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crdlbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.crdlbl.Location = New System.Drawing.Point(118, 47)
        Me.crdlbl.Name = "crdlbl"
        Me.crdlbl.Size = New System.Drawing.Size(13, 27)
        Me.crdlbl.TabIndex = 7
        Me.crdlbl.Text = ".."
        '
        'namelbl
        '
        Me.namelbl.BackColor = System.Drawing.Color.Transparent
        Me.namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.namelbl.Location = New System.Drawing.Point(129, 80)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(13, 27)
        Me.namelbl.TabIndex = 8
        Me.namelbl.Text = ".."
        '
        'pnlgetLoan
        '
        Me.pnlgetLoan.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlgetLoan.Controls.Add(Me.chckEligibility)
        Me.pnlgetLoan.Controls.Add(Me.duedtp)
        Me.pnlgetLoan.Controls.Add(Me.lbldue)
        Me.pnlgetLoan.Controls.Add(Me.txtemi)
        Me.pnlgetLoan.Controls.Add(Me.lblemi)
        Me.pnlgetLoan.Controls.Add(Me.interestCmb)
        Me.pnlgetLoan.Controls.Add(Me.txttotal)
        Me.pnlgetLoan.Controls.Add(Me.loandtp)
        Me.pnlgetLoan.Controls.Add(Me.lbldate)
        Me.pnlgetLoan.Controls.Add(Me.periodCmb)
        Me.pnlgetLoan.Controls.Add(Me.periodlbl)
        Me.pnlgetLoan.Controls.Add(Me.ttlamt)
        Me.pnlgetLoan.Controls.Add(Me.amt)
        Me.pnlgetLoan.Controls.Add(Me.lblagree)
        Me.pnlgetLoan.Controls.Add(Me.checkbox)
        Me.pnlgetLoan.Controls.Add(Me.calcBtn)
        Me.pnlgetLoan.Controls.Add(Me.lblinterest)
        Me.pnlgetLoan.Controls.Add(Me.lblamt)
        Me.pnlgetLoan.Controls.Add(Me.getLoan)
        Me.pnlgetLoan.Location = New System.Drawing.Point(12, 128)
        Me.pnlgetLoan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlgetLoan.Name = "pnlgetLoan"
        Me.pnlgetLoan.ShadowDecoration.Parent = Me.pnlgetLoan
        Me.pnlgetLoan.Size = New System.Drawing.Size(395, 611)
        Me.pnlgetLoan.TabIndex = 5
        '
        'chckEligibility
        '
        Me.chckEligibility.CheckedState.Parent = Me.chckEligibility
        Me.chckEligibility.CustomImages.Parent = Me.chckEligibility
        Me.chckEligibility.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chckEligibility.ForeColor = System.Drawing.Color.Black
        Me.chckEligibility.HoverState.Parent = Me.chckEligibility
        Me.chckEligibility.Location = New System.Drawing.Point(133, 66)
        Me.chckEligibility.Name = "chckEligibility"
        Me.chckEligibility.ShadowDecoration.Parent = Me.chckEligibility
        Me.chckEligibility.Size = New System.Drawing.Size(96, 56)
        Me.chckEligibility.TabIndex = 35
        Me.chckEligibility.Text = "Check for eligibility"
        '
        'duedtp
        '
        Me.duedtp.BorderRadius = 5
        Me.duedtp.CheckedState.Parent = Me.duedtp
        Me.duedtp.Enabled = False
        Me.duedtp.FillColor = System.Drawing.Color.Cyan
        Me.duedtp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.duedtp.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.duedtp.HoverState.Parent = Me.duedtp
        Me.duedtp.Location = New System.Drawing.Point(184, 415)
        Me.duedtp.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.duedtp.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.duedtp.Name = "duedtp"
        Me.duedtp.ShadowDecoration.Parent = Me.duedtp
        Me.duedtp.Size = New System.Drawing.Size(182, 36)
        Me.duedtp.TabIndex = 34
        Me.duedtp.Value = New Date(2020, 12, 1, 15, 54, 21, 260)
        '
        'lbldue
        '
        Me.lbldue.BackColor = System.Drawing.Color.Transparent
        Me.lbldue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldue.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldue.Location = New System.Drawing.Point(22, 421)
        Me.lbldue.Name = "lbldue"
        Me.lbldue.Size = New System.Drawing.Size(111, 27)
        Me.lbldue.TabIndex = 33
        Me.lbldue.Text = "Next Due on"
        '
        'txtemi
        '
        Me.txtemi.BackColor = System.Drawing.Color.Transparent
        Me.txtemi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtemi.Location = New System.Drawing.Point(267, 474)
        Me.txtemi.Name = "txtemi"
        Me.txtemi.Size = New System.Drawing.Size(3, 2)
        Me.txtemi.TabIndex = 30
        Me.txtemi.Text = Nothing
        '
        'lblemi
        '
        Me.lblemi.BackColor = System.Drawing.Color.Transparent
        Me.lblemi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemi.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblemi.Location = New System.Drawing.Point(22, 465)
        Me.lblemi.Name = "lblemi"
        Me.lblemi.Size = New System.Drawing.Size(181, 27)
        Me.lblemi.TabIndex = 29
        Me.lblemi.Text = "Amount per month :-"
        '
        'interestCmb
        '
        Me.interestCmb.BorderRadius = 15
        Me.interestCmb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.interestCmb.DefaultText = ""
        Me.interestCmb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.interestCmb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.interestCmb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.interestCmb.DisabledState.Parent = Me.interestCmb
        Me.interestCmb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.interestCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.interestCmb.FocusedState.Parent = Me.interestCmb
        Me.interestCmb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.interestCmb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.interestCmb.HoverState.Parent = Me.interestCmb
        Me.interestCmb.Location = New System.Drawing.Point(216, 176)
        Me.interestCmb.Name = "interestCmb"
        Me.interestCmb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.interestCmb.PlaceholderText = ""
        Me.interestCmb.ReadOnly = True
        Me.interestCmb.SelectedText = ""
        Me.interestCmb.ShadowDecoration.Parent = Me.interestCmb
        Me.interestCmb.Size = New System.Drawing.Size(140, 36)
        Me.interestCmb.TabIndex = 28
        '
        'txttotal
        '
        Me.txttotal.BorderRadius = 15
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.DefaultText = ""
        Me.txttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.DisabledState.Parent = Me.txttotal
        Me.txttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.Enabled = False
        Me.txttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.FocusedState.Parent = Me.txttotal
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.HoverState.Parent = Me.txttotal
        Me.txttotal.Location = New System.Drawing.Point(226, 363)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.PlaceholderText = ""
        Me.txttotal.ReadOnly = True
        Me.txttotal.SelectedText = ""
        Me.txttotal.ShadowDecoration.Parent = Me.txttotal
        Me.txttotal.Size = New System.Drawing.Size(140, 36)
        Me.txttotal.TabIndex = 27
        '
        'loandtp
        '
        Me.loandtp.BorderRadius = 5
        Me.loandtp.CheckedState.Parent = Me.loandtp
        Me.loandtp.FillColor = System.Drawing.Color.Cyan
        Me.loandtp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.loandtp.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.loandtp.HoverState.Parent = Me.loandtp
        Me.loandtp.Location = New System.Drawing.Point(192, 228)
        Me.loandtp.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.loandtp.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.loandtp.Name = "loandtp"
        Me.loandtp.ShadowDecoration.Parent = Me.loandtp
        Me.loandtp.Size = New System.Drawing.Size(182, 36)
        Me.loandtp.TabIndex = 26
        Me.loandtp.Value = New Date(2020, 12, 1, 15, 54, 21, 260)
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbldate.Location = New System.Drawing.Point(30, 237)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(115, 27)
        Me.lbldate.TabIndex = 25
        Me.lbldate.Text = "Date taken :-"
        '
        'periodCmb
        '
        Me.periodCmb.BackColor = System.Drawing.Color.Transparent
        Me.periodCmb.BorderRadius = 15
        Me.periodCmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.periodCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.periodCmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.periodCmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.periodCmb.FocusedState.Parent = Me.periodCmb
        Me.periodCmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.periodCmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.periodCmb.HoverState.Parent = Me.periodCmb
        Me.periodCmb.ItemHeight = 30
        Me.periodCmb.Items.AddRange(New Object() {"6", "8", "10", "12"})
        Me.periodCmb.ItemsAppearance.Parent = Me.periodCmb
        Me.periodCmb.Location = New System.Drawing.Point(216, 128)
        Me.periodCmb.Name = "periodCmb"
        Me.periodCmb.ShadowDecoration.Parent = Me.periodCmb
        Me.periodCmb.Size = New System.Drawing.Size(140, 36)
        Me.periodCmb.TabIndex = 24
        '
        'periodlbl
        '
        Me.periodlbl.BackColor = System.Drawing.Color.Transparent
        Me.periodlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periodlbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.periodlbl.Location = New System.Drawing.Point(28, 137)
        Me.periodlbl.Name = "periodlbl"
        Me.periodlbl.Size = New System.Drawing.Size(176, 27)
        Me.periodlbl.TabIndex = 23
        Me.periodlbl.Text = "Period (In months):-"
        '
        'ttlamt
        '
        Me.ttlamt.BackColor = System.Drawing.Color.Transparent
        Me.ttlamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttlamt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ttlamt.Location = New System.Drawing.Point(25, 363)
        Me.ttlamt.Name = "ttlamt"
        Me.ttlamt.Size = New System.Drawing.Size(135, 27)
        Me.ttlamt.TabIndex = 21
        Me.ttlamt.Text = "Total amount :-"
        '
        'amt
        '
        Me.amt.BackColor = System.Drawing.Color.Transparent
        Me.amt.BorderRadius = 15
        Me.amt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.amt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.amt.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.amt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.amt.FocusedState.Parent = Me.amt
        Me.amt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.amt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.amt.HoverState.Parent = Me.amt
        Me.amt.ItemHeight = 30
        Me.amt.Items.AddRange(New Object() {"75000", "200000", "500000", "700000"})
        Me.amt.ItemsAppearance.Parent = Me.amt
        Me.amt.Location = New System.Drawing.Point(205, 16)
        Me.amt.Name = "amt"
        Me.amt.ShadowDecoration.Parent = Me.amt
        Me.amt.Size = New System.Drawing.Size(140, 36)
        Me.amt.TabIndex = 20
        '
        'lblagree
        '
        Me.lblagree.BackColor = System.Drawing.Color.Transparent
        Me.lblagree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblagree.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblagree.Location = New System.Drawing.Point(68, 511)
        Me.lblagree.Name = "lblagree"
        Me.lblagree.Size = New System.Drawing.Size(298, 27)
        Me.lblagree.TabIndex = 15
        Me.lblagree.Text = "I agree for all terms and conditions"
        '
        'checkbox
        '
        Me.checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkbox.CheckedState.BorderRadius = 2
        Me.checkbox.CheckedState.BorderThickness = 0
        Me.checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkbox.CheckedState.Parent = Me.checkbox
        Me.checkbox.Location = New System.Drawing.Point(42, 510)
        Me.checkbox.Name = "checkbox"
        Me.checkbox.ShadowDecoration.Parent = Me.checkbox
        Me.checkbox.Size = New System.Drawing.Size(20, 20)
        Me.checkbox.TabIndex = 14
        Me.checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkbox.UncheckedState.BorderRadius = 2
        Me.checkbox.UncheckedState.BorderThickness = 0
        Me.checkbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.checkbox.UncheckedState.Parent = Me.checkbox
        '
        'calcBtn
        '
        Me.calcBtn.CheckedState.Parent = Me.calcBtn
        Me.calcBtn.CustomImages.Parent = Me.calcBtn
        Me.calcBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.calcBtn.ForeColor = System.Drawing.Color.Black
        Me.calcBtn.HoverState.Parent = Me.calcBtn
        Me.calcBtn.Location = New System.Drawing.Point(123, 288)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.ShadowDecoration.Parent = Me.calcBtn
        Me.calcBtn.Size = New System.Drawing.Size(106, 59)
        Me.calcBtn.TabIndex = 12
        Me.calcBtn.Text = "Calculate Total Amount"
        '
        'lblinterest
        '
        Me.lblinterest.BackColor = System.Drawing.Color.Transparent
        Me.lblinterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinterest.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblinterest.Location = New System.Drawing.Point(28, 185)
        Me.lblinterest.Name = "lblinterest"
        Me.lblinterest.Size = New System.Drawing.Size(143, 27)
        Me.lblinterest.TabIndex = 11
        Me.lblinterest.Text = "Interest (In %) :-"
        '
        'lblamt
        '
        Me.lblamt.BackColor = System.Drawing.Color.Transparent
        Me.lblamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblamt.Location = New System.Drawing.Point(19, 25)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(89, 27)
        Me.lblamt.TabIndex = 9
        Me.lblamt.Text = "Amount :-"
        '
        'getLoan
        '
        Me.getLoan.CheckedState.Parent = Me.getLoan
        Me.getLoan.CustomImages.Parent = Me.getLoan
        Me.getLoan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.getLoan.ForeColor = System.Drawing.Color.Black
        Me.getLoan.HoverState.Parent = Me.getLoan
        Me.getLoan.Location = New System.Drawing.Point(133, 553)
        Me.getLoan.Name = "getLoan"
        Me.getLoan.ShadowDecoration.Parent = Me.getLoan
        Me.getLoan.Size = New System.Drawing.Size(80, 45)
        Me.getLoan.TabIndex = 4
        Me.getLoan.Text = "Get Loan"
        '
        'pnlmain
        '
        Me.pnlmain.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlmain.Controls.Add(Me.pnlInterestpay)
        Me.pnlmain.Location = New System.Drawing.Point(413, 191)
        Me.pnlmain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.ShadowDecoration.Parent = Me.pnlmain
        Me.pnlmain.Size = New System.Drawing.Size(430, 336)
        Me.pnlmain.TabIndex = 21
        '
        'pnlInterestpay
        '
        Me.pnlInterestpay.BackColor = System.Drawing.Color.Black
        Me.pnlInterestpay.Controls.Add(Me.Guna2HtmlLabel12)
        Me.pnlInterestpay.Controls.Add(Me.ttlemiamt)
        Me.pnlInterestpay.Controls.Add(Me.lblamtttl)
        Me.pnlInterestpay.Controls.Add(Me.amtemi)
        Me.pnlInterestpay.Controls.Add(Me.calcemi)
        Me.pnlInterestpay.Controls.Add(Me.nextdue)
        Me.pnlInterestpay.Controls.Add(Me.duelbl)
        Me.pnlInterestpay.Controls.Add(Me.paidlbl)
        Me.pnlInterestpay.Controls.Add(Me.lblpaid)
        Me.pnlInterestpay.Controls.Add(Me.exitBtn)
        Me.pnlInterestpay.Controls.Add(Me.PayemiBtn)
        Me.pnlInterestpay.Controls.Add(Me.dueemi)
        Me.pnlInterestpay.Controls.Add(Me.lblduedate)
        Me.pnlInterestpay.Controls.Add(Me.lblamtrepay)
        Me.pnlInterestpay.Location = New System.Drawing.Point(3, 3)
        Me.pnlInterestpay.Name = "pnlInterestpay"
        Me.pnlInterestpay.ShadowDecoration.Parent = Me.pnlInterestpay
        Me.pnlInterestpay.Size = New System.Drawing.Size(424, 330)
        Me.pnlInterestpay.TabIndex = 26
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(13, 182)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(135, 20)
        Me.Guna2HtmlLabel12.TabIndex = 40
        Me.Guna2HtmlLabel12.Text = "(with penalty , if any)                                                          " &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ttlemiamt
        '
        Me.ttlemiamt.BorderRadius = 15
        Me.ttlemiamt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ttlemiamt.DefaultText = ""
        Me.ttlemiamt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ttlemiamt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ttlemiamt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ttlemiamt.DisabledState.Parent = Me.ttlemiamt
        Me.ttlemiamt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ttlemiamt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.ttlemiamt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttlemiamt.FocusedState.Parent = Me.ttlemiamt
        Me.ttlemiamt.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ttlemiamt.ForeColor = System.Drawing.Color.Black
        Me.ttlemiamt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ttlemiamt.HoverState.Parent = Me.ttlemiamt
        Me.ttlemiamt.Location = New System.Drawing.Point(265, 155)
        Me.ttlemiamt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ttlemiamt.Name = "ttlemiamt"
        Me.ttlemiamt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ttlemiamt.PlaceholderText = ""
        Me.ttlemiamt.ReadOnly = True
        Me.ttlemiamt.SelectedText = ""
        Me.ttlemiamt.ShadowDecoration.Parent = Me.ttlemiamt
        Me.ttlemiamt.Size = New System.Drawing.Size(140, 36)
        Me.ttlemiamt.TabIndex = 39
        '
        'lblamtttl
        '
        Me.lblamtttl.BackColor = System.Drawing.Color.Transparent
        Me.lblamtttl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamtttl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblamtttl.Location = New System.Drawing.Point(14, 155)
        Me.lblamtttl.Name = "lblamtttl"
        Me.lblamtttl.Size = New System.Drawing.Size(120, 27)
        Me.lblamtttl.TabIndex = 38
        Me.lblamtttl.Text = "Total Amount                                                                " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'amtemi
        '
        Me.amtemi.BorderRadius = 15
        Me.amtemi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amtemi.DefaultText = ""
        Me.amtemi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.amtemi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.amtemi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amtemi.DisabledState.Parent = Me.amtemi
        Me.amtemi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amtemi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.amtemi.FocusedState.Parent = Me.amtemi
        Me.amtemi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.amtemi.ForeColor = System.Drawing.Color.Black
        Me.amtemi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.amtemi.HoverState.Parent = Me.amtemi
        Me.amtemi.Location = New System.Drawing.Point(265, 104)
        Me.amtemi.Margin = New System.Windows.Forms.Padding(4)
        Me.amtemi.Name = "amtemi"
        Me.amtemi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.amtemi.PlaceholderText = ""
        Me.amtemi.ReadOnly = True
        Me.amtemi.SelectedText = ""
        Me.amtemi.ShadowDecoration.Parent = Me.amtemi
        Me.amtemi.Size = New System.Drawing.Size(149, 36)
        Me.amtemi.TabIndex = 35
        '
        'calcemi
        '
        Me.calcemi.CheckedState.Parent = Me.calcemi
        Me.calcemi.CustomImages.Parent = Me.calcemi
        Me.calcemi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.calcemi.ForeColor = System.Drawing.Color.Black
        Me.calcemi.HoverState.Parent = Me.calcemi
        Me.calcemi.Location = New System.Drawing.Point(124, 279)
        Me.calcemi.Name = "calcemi"
        Me.calcemi.ShadowDecoration.Parent = Me.calcemi
        Me.calcemi.Size = New System.Drawing.Size(80, 45)
        Me.calcemi.TabIndex = 37
        Me.calcemi.Text = "Calculate Emi"
        '
        'nextdue
        '
        Me.nextdue.BorderRadius = 5
        Me.nextdue.CheckedState.Parent = Me.nextdue
        Me.nextdue.Enabled = False
        Me.nextdue.FillColor = System.Drawing.Color.Cyan
        Me.nextdue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nextdue.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.nextdue.HoverState.Parent = Me.nextdue
        Me.nextdue.Location = New System.Drawing.Point(204, 222)
        Me.nextdue.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.nextdue.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.nextdue.Name = "nextdue"
        Me.nextdue.ShadowDecoration.Parent = Me.nextdue
        Me.nextdue.Size = New System.Drawing.Size(182, 36)
        Me.nextdue.TabIndex = 36
        Me.nextdue.Value = New Date(2020, 12, 1, 15, 54, 21, 260)
        '
        'duelbl
        '
        Me.duelbl.BackColor = System.Drawing.Color.Transparent
        Me.duelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duelbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.duelbl.Location = New System.Drawing.Point(37, 222)
        Me.duelbl.Name = "duelbl"
        Me.duelbl.Size = New System.Drawing.Size(122, 27)
        Me.duelbl.TabIndex = 35
        Me.duelbl.Text = "Next Due on :"
        '
        'paidlbl
        '
        Me.paidlbl.BackColor = System.Drawing.Color.Transparent
        Me.paidlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paidlbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.paidlbl.Location = New System.Drawing.Point(192, 16)
        Me.paidlbl.Name = "paidlbl"
        Me.paidlbl.Size = New System.Drawing.Size(3, 2)
        Me.paidlbl.TabIndex = 34
        Me.paidlbl.Text = Nothing
        '
        'lblpaid
        '
        Me.lblpaid.BackColor = System.Drawing.Color.Transparent
        Me.lblpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaid.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblpaid.Location = New System.Drawing.Point(25, 16)
        Me.lblpaid.Name = "lblpaid"
        Me.lblpaid.Size = New System.Drawing.Size(123, 27)
        Me.lblpaid.TabIndex = 33
        Me.lblpaid.Text = "Months Paid :"
        '
        'exitBtn
        '
        Me.exitBtn.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.exitBtn.IconColor = System.Drawing.Color.BlanchedAlmond
        Me.exitBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.exitBtn.Location = New System.Drawing.Point(389, 0)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(32, 32)
        Me.exitBtn.TabIndex = 32
        Me.exitBtn.TabStop = False
        '
        'PayemiBtn
        '
        Me.PayemiBtn.CheckedState.Parent = Me.PayemiBtn
        Me.PayemiBtn.CustomImages.Parent = Me.PayemiBtn
        Me.PayemiBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PayemiBtn.ForeColor = System.Drawing.Color.Black
        Me.PayemiBtn.HoverState.Parent = Me.PayemiBtn
        Me.PayemiBtn.Location = New System.Drawing.Point(239, 279)
        Me.PayemiBtn.Name = "PayemiBtn"
        Me.PayemiBtn.ShadowDecoration.Parent = Me.PayemiBtn
        Me.PayemiBtn.Size = New System.Drawing.Size(80, 45)
        Me.PayemiBtn.TabIndex = 26
        Me.PayemiBtn.Text = "Pay Emi"
        '
        'dueemi
        '
        Me.dueemi.BorderRadius = 5
        Me.dueemi.CheckedState.Parent = Me.dueemi
        Me.dueemi.Enabled = False
        Me.dueemi.FillColor = System.Drawing.Color.Cyan
        Me.dueemi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dueemi.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dueemi.HoverState.Parent = Me.dueemi
        Me.dueemi.Location = New System.Drawing.Point(239, 53)
        Me.dueemi.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dueemi.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dueemi.Name = "dueemi"
        Me.dueemi.ShadowDecoration.Parent = Me.dueemi
        Me.dueemi.Size = New System.Drawing.Size(182, 36)
        Me.dueemi.TabIndex = 24
        Me.dueemi.Value = New Date(2020, 12, 1, 15, 54, 21, 260)
        '
        'lblduedate
        '
        Me.lblduedate.BackColor = System.Drawing.Color.Transparent
        Me.lblduedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduedate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblduedate.Location = New System.Drawing.Point(25, 62)
        Me.lblduedate.Name = "lblduedate"
        Me.lblduedate.Size = New System.Drawing.Size(100, 27)
        Me.lblduedate.TabIndex = 23
        Me.lblduedate.Text = "Due date :-"
        '
        'lblamtrepay
        '
        Me.lblamtrepay.BackColor = System.Drawing.Color.Transparent
        Me.lblamtrepay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamtrepay.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblamtrepay.Location = New System.Drawing.Point(25, 113)
        Me.lblamtrepay.Name = "lblamtrepay"
        Me.lblamtrepay.Size = New System.Drawing.Size(89, 27)
        Me.lblamtrepay.TabIndex = 22
        Me.lblamtrepay.Text = "Amount :-"
        '
        'applyLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(913, 750)
        Me.Controls.Add(Me.namelbl)
        Me.Controls.Add(Me.crdlbl)
        Me.Controls.Add(Me.welcum)
        Me.Controls.Add(Me.cardnum)
        Me.Controls.Add(Me.pnlgetLoan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlmain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "applyLoan"
        Me.Text = "applyLoan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlgetLoan.ResumeLayout(False)
        Me.pnlgetLoan.PerformLayout()
        Me.pnlmain.ResumeLayout(False)
        Me.pnlInterestpay.ResumeLayout(False)
        Me.pnlInterestpay.PerformLayout()
        CType(Me.exitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents cardnum As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents welcum As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents crdlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents namelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlgetLoan As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents amt As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblagree As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents checkbox As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents calcBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblinterest As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblamt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents getLoan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlmain As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnlInterestpay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PayemiBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dueemi As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblduedate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblamtrepay As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ttlamt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents periodCmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents periodlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents exitBtn As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents loandtp As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lbldate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblpaid As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents paidlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents nextdue As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents duelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents calcemi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txttotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents interestCmb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtemi As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblemi As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents duedtp As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lbldue As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents amtemi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ttlemiamt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblamtttl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chckEligibility As Guna.UI2.WinForms.Guna2Button
End Class
