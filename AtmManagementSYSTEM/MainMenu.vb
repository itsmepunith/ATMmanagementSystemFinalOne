Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports FontAwesome.Sharp

Public Class MainMenu

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private currentbtn As IconButton
    Private leftborderbtn As Panel


    Private Sub g_panel_MouseDown(sender As Object, e As MouseEventArgs) Handles g_panel.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub




    Public Sub progload()
        progbar.Value = 0
        progbar.Visible = True
        loadlbl.Visible = True
        proglbl.Visible = True
        waitlbl.Visible = True
        Timer1.Start()
    End Sub
    Public Sub belazy()
        For i = 1 To 30
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
    End Sub



    Public Sub New()
        InitializeComponent()
        leftborderbtn = New Panel()
        leftborderbtn.Size = New Size(7, 60)
        Panel1.Controls.Add(leftborderbtn)


    End Sub

    Private Sub activebutton(senderbtn As Object, customcolor As Color)
        disablebutton()
        If senderbtn IsNot Nothing Then

            currentbtn = CType(senderbtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(37, 36, 81)
            currentbtn.ForeColor = customcolor
            currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            leftborderbtn.BackColor = customcolor
            leftborderbtn.Location = New Point(0, currentbtn.Location.Y)
            leftborderbtn.Visible = True
            leftborderbtn.BringToFront()




        End If

    End Sub

    Private Sub disablebutton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(31, 30, 68)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        activebutton(sender, rgbcolors.color1)
        progload()
        belazy()
        Me.Hide()
        Registerfrm.Show()


    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        activebutton(sender, rgbcolors.color2)
        progload()
        belazy()
        Me.Hide()
        login_frm.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        activebutton(sender, rgbcolors.color3)
        progload()
        belazy()
        Me.Hide()
        services.Show()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        activebutton(sender, rgbcolors.color4)
        progload()
        belazy()
        Me.Hide()
        contact.Show()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        activebutton(sender, rgbcolors.color5)
        progload()
        belazy()
        Me.Hide()
        AboutUs.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        Dim day As Date
        day = Format(Now(), "short date")
        lbldate.Text = day
        lbltime.Text = TimeOfDay.ToString("h:mm tt")
        progbar.Hide()
        loadlbl.Hide()
        proglbl.Hide()
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        waitlbl.Hide()
        btnEnglish.Visible = False
        selectedenglish()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progbar.Increment(5)
        proglbl.Text = progbar.ProgressPercentText
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        rate.Show()
    End Sub

    Private Sub btnKannada_Click(sender As Object, e As EventArgs) Handles btnKannada.Click
        selectedkannada()
        MsgBox("ಕನ್ನಡ ಭಾಷೆಯನ್ನು ಆಯ್ಕೆ ಮಾಡಲಾಗಿದೆ", MsgBoxStyle.Information, "ಕನ್ನಡ")
    End Sub

    Private Sub hindiBtn_Click(sender As Object, e As EventArgs) Handles hindiBtn.Click
        selectedhindi()
        MsgBox("हिंदी भाषा का चयन किया गया है", MsgBoxStyle.Information, "हिंदी")

    End Sub

    Private Sub selectedkannada()
        IconButton1.Text = "ನೋಂದಣಿ"
        IconButton2.Text = "ಲಾಗಿನ್"
        IconButton3.Text = "ಸೇವೆಗಳು"
        IconButton4.Text = "ಸಂಪರ್ಕಿಸಿ"
        IconButton5.Text = "ನಮ್ಮ ಬಗ್ಗೆ"
        login_frm.txtAcc.PlaceholderText = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        login_frm.txtPin.PlaceholderText = "ಪಿನ್"
        login_frm.login.Text = "ಲಾಗಿನ್"
        login_frm.loginbtn.Text = "ಲಾಗಿನ್"
        login_frm.linkForgot.Text = "ಪಿನ್ ಮರೆತಿದ್ದೀರಾ?? ಇಲ್ಲಿ ಕ್ಲಿಕ್ ಮಾಡಿ"
        login_frm.newusr.Text = "ಹೊಸ ಗ್ರಾಹಕ? ಇಲ್ಲಿ ಕ್ಲಿಕ್ ಮಾಡಿ"
        forgotpass.txtacc.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        forgotpass.cardnoBtn.Text = "ಓಟಿಪಿ ಪಡೆಯಿರಿ"
        forgotpass.txtOtp.Text = "ಓಟಿಪಿಯನ್ನು ಹಾಕಿ"
        forgotpass.OkBtn.Text = "ಓಕೆ"
        forgotpass.txtPin.Text = "ಹೊಸ ಪಿನ್"
        forgotpass.PinBtn.Text = "ಪಿನ್ ಬದಲಾಯಿಸಿ"
        Registerfrm.btnRegist.Text = "ಗ್ರಾಹಕ ನೋಂದಣಿ"
        Registerfrm.txtAcc.PlaceholderText = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        Registerfrm.txtPin.PlaceholderText = "ಪಿನ್"
        Registerfrm.txtFname.PlaceholderText = "ಮೊದಲ ಹೆಸರು"
        Registerfrm.txtLname.PlaceholderText = "ಕೊನೆಯ ಹೆಸರು"
        Registerfrm.txtEmail.PlaceholderText = "ಇಮೇಲ್"
        Registerfrm.txtAddr.PlaceholderText = "ವಿಳಾಸ"
        Registerfrm.txtContact.PlaceholderText = "ದೂರವಾಣಿ ಸಂಖ್ಯೆ"
        Registerfrm.maleRadio.Text = "ಪುರುಷ"
        Registerfrm.femaleRadio.Text = "ಸ್ತ್ರೀ"
        Registerfrm.DOB.Text = "ಜನ್ಮ ದಿನ"
        Registerfrm.linklogin.Text = "ಖಾತೆ ಇದೆಯೇ? ಇಲ್ಲಿ ಕ್ಲಿಕ್ ಮಾಡಿ"
        Registerfrm.imgBrowse.Text = "ಚಿತ್ರವನ್ನು ಆರಿಸಿ"
        Transaction.lblwelcome.Text = "ಸ್ವಾಗತ"
        Transaction.lblcard.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        Transaction.btnLogout.Text = "ಲಾಗ್ ಔಟ್"
        Transaction.Depositbtn.Text = "ಠೇವಣಿ"
        Transaction.withdrawBtn.Text = "ಹಣ ಹಿಂಪಡೆಯುವಿಕೆ"
        Transaction.balanceBtn.Text = "ಉಳಿತಾಯ"
        Transaction.transferBtn.Text = "ಹಣ ವರ್ಗಾವಣೆ"
        Transaction.changepinBtn.Text = "ಪಿನ್ ಬದಲಾವಣೆ"
        Transaction.statementBtn.Text = "ಖಾತೆ ವಿವರಣೆ"
        Transaction.loanBtn.Text = "ಸಾಲ ಪಡೆಯಿರಿ / ಸಾಲವನ್ನು ಮರುಪಾವತಿಸಿ"
        balance.txtwelcome.Text = "ಸ್ವಾಗತ"
        balance.lblcard.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        balance.lblbalance.Text = "ಉಳಿತಾಯ ಮೊತ್ತ"
        balance.ExitBtn.Text = "ಹಿಂದೆ ಹೋಗಿ"
        balance.Balancebtn.Text = " ಉಳಿತಾಯ ಪರಿಶೀಲಿಸಿ"
        balance.Balancebtn.Width = 230
        balance.Balancebtn.Height = 45
        Deposit.lblwelcome.Text = "ಸ್ವಾಗತ"
        Deposit.lblcard.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        Deposit.txtAmt.PlaceholderText = "ಮೊತ್ತವನ್ನು ನಮೂದಿಸಿ"
        Deposit.DepositBtn.Text = "ಠೇವಣಿ"
        Deposit.exitBtn.Text = "ಹಿಂದೆ ಹೋಗಿ"
        withdraw.txtwelcome.Text = "ಸ್ವಾಗತ"
        withdraw.txtcard.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        withdraw.txtAmt.PlaceholderText = "ಮೊತ್ತವನ್ನು ನಮೂದಿಸಿ"
        withdraw.withdrawBtn.Text = "ಹಣ ಹಿಂಪಡೆಯಿರಿ"
        withdraw.exitBtn.Text = "ಹಿಂದೆ ಹೋಗಿ"
        transfer.txtwelcome.Text = "ಸ್ವಾಗತ"
        transfer.txtcard.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        transfer.txtAcc.PlaceholderText = "ಸ್ವೀಕರಿಸುವವರ ಕಾರ್ಡ್ ಸಂಖ್ಯೆಯನ್ನು ನಮೂದಿಸಿ"
        transfer.txtAmt.PlaceholderText = "ಮೊತ್ತವನ್ನು ನಮೂದಿಸಿ"
        transfer.BtnTransfer.Text = "ಹಣ ವರ್ಗಾಯಿಸಿ"
        transfer.exitBtn.Text = "ಹಿಂದೆ ಹೋಗಿ"
        change_pin.txtwelcome.Text = "ಸ್ವಾಗತ"
        change_pin.txtcard.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        change_pin.txtPin.PlaceholderText = "ಹೊಸ ಪಿನ್ ನಮೂದಿಸಿ"
        change_pin.changepinBtn.Text = "ಪಿನ್ ಬದಲಾಯಿಸಿ"
        change_pin.exitBtn.Text = "ಹಿಂದೆ ಹೋಗಿ"
        Statement.txtwelcome.Text = "ಸ್ವಾಗತ"
        Statement.txtcard.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        Statement.DstatementBtn.Text = "ಠೇವಣಿಯ ವಿವರಣೆ"
        Statement.DstatementBtn.Location = New Point(180, 250)
        Statement.WstatementBtn.Text = "ಹಣ ಹಿಂಪಡೆಯುವಿಕೆಯ ವಿವರಣೆ"
        Statement.WstatementBtn.Width = 300
        Statement.WstatementBtn.Location = New Point(180, 320)
        Statement.TstatementBtn.Text = "ವರ್ಗಾವಣೆಯ ವಿವರಣೆ"
        Statement.TstatementBtn.Width = 230
        Statement.TstatementBtn.Location = New Point(180, 180)
        Statement.backBtn.Text = "ಹಿಂದೆ ಹೋಗಿ"
        applyLoan.cardnum.Text = "ಕಾರ್ಡ್ ಸಂಖ್ಯೆ"
        applyLoan.welcum.Text = "ಸ್ವಾಗತ"
        applyLoan.lblamt.Text = "ಹಣ"
        applyLoan.periodlbl.Text = "ಅವಧಿ"
        applyLoan.lblinterest.Text = "ಬಡ್ಡಿ"
        applyLoan.lbldate.Text = "ದಿನಾಂಕ"
        applyLoan.calcBtn.Text = "ಒಟ್ಟು ಮೊತ್ತ"
        applyLoan.ttlamt.Text = "ಒಟ್ಟು ಮೊತ್ತ"
        applyLoan.lbldue.Text = "ಮುಂದಿನ ದಿನಾಂಕ "
        applyLoan.lblemi.Text = "ತಿಂಗಳಿಗೆ ಮೊತ್ತ"
        applyLoan.lblagree.Text = "ನಾನು ಎಲ್ಲಾ ನಿಯಮಗಳು ಮತ್ತು ಷರತ್ತುಗಳನ್ನು ಒಪ್ಪುತ್ತೇನೆ"
        applyLoan.getLoan.Text = "ಸಾಲ ಪಡೆಯಿರಿ"
        applyLoan.lblpaid.Text = "ಪಾವತಿಸಿದ ಒಟ್ಟು ತಿಂಗಳುಗಳು"
        applyLoan.lblduedate.Text = " ಪಾವತಿ ದಿನಾಂಕ"
        applyLoan.lblamtrepay.Text = "ಮೊತ್ತ"
        applyLoan.lblamtttl.Text = "ಒಟ್ಟು ಮೊತ್ತ"
        applyLoan.duelbl.Text = "ಮುಂದಿನ ಪಾವತಿ"
        applyLoan.calcemi.Text = "ಒಟ್ಟು ಇಎಂಐ"
        applyLoan.PayemiBtn.Text = "ಇಎಂಐ ಪಾವತಿಸಿ"
        btnEnglish.Visible = True
    End Sub

    Private Sub selectedhindi()
        IconButton1.Text = "रेगिस्टर्"
        IconButton2.Text = "लोगिन्"
        IconButton3.Text = "सेवाएं"
        IconButton4.Text = "संपर्क करें"
        IconButton5.Text = "अबोउत उस्"
        login_frm.txtAcc.PlaceholderText = "कार्ड संख्या"
        login_frm.txtPin.PlaceholderText = "पिन्"
        login_frm.login.Text = "लोगिन्"
        login_frm.loginbtn.Text = "लोगिन्"
        login_frm.linkForgot.Text = "पिन भूल गए? यहाँ क्लिक करें"
        login_frm.newusr.Text = "नए ग्राहक? यहाँ क्लिक करें"
        forgotpass.txtacc.Text = "कार्ड संख्या"
        forgotpass.cardnoBtn.Text = "ओटीपि प्राप्त करें"
        forgotpass.txtOtp.Text = " ओटीपि डालौ"
        forgotpass.OkBtn.Text = "ओके"
        forgotpass.txtPin.Text = "नया पिन"
        forgotpass.PinBtn.Text = "पिन बदलें"
        Registerfrm.btnRegist.Text = "ग्राहक रेगिस्टर्"
        Registerfrm.txtAcc.PlaceholderText = "कार्ड संख्या"
        Registerfrm.txtPin.PlaceholderText = "पिन"
        Registerfrm.txtFname.PlaceholderText = "पहला नाम"
        Registerfrm.txtLname.PlaceholderText = "उपनाम"
        Registerfrm.txtEmail.PlaceholderText = "ईमेल"
        Registerfrm.txtAddr.PlaceholderText = "पता"
        Registerfrm.txtContact.PlaceholderText = "मोबाइल नंबर"
        Registerfrm.maleRadio.Text = "पुरुष"
        Registerfrm.femaleRadio.Text = "महिला"
        Registerfrm.DOB.Text = "जन्मदिन"
        Registerfrm.linklogin.Text = "खाता है ? यहाँ क्लिक करें"
        Registerfrm.imgBrowse.Text = "तस्वीर चयन करें"
        Transaction.lblwelcome.Text = "स्वागत"
        Transaction.lblcard.Text = "कार्ड संख्या"
        Transaction.btnLogout.Text = "लॉग आउट"
        Transaction.Depositbtn.Text = "जमा"
        Transaction.withdrawBtn.Text = "नकद निकासी"
        Transaction.balanceBtn.Text = "बैलेंस"
        Transaction.transferBtn.Text = "नकद अंतरण"
        Transaction.changepinBtn.Text = "पिन बदलें"
        Transaction.statementBtn.Text = "खाते का विवरण"
        Transaction.loanBtn.Text = "उधार पाइए / वापस करें"
        balance.txtwelcome.Text = "स्वागत"
        balance.lblcard.Text = "कार्ड संख्या"
        balance.lblbalance.Text = "बैलेंस "
        balance.ExitBtn.Text = "वापस जाओ"
        balance.Balancebtn.Text = "बैलेंस चेक करें"
        balance.Balancebtn.Width = 230
        balance.Balancebtn.Height = 45
        Deposit.lblwelcome.Text = "स्वागत"
        Deposit.lblcard.Text = "कार्ड संख्या"
        Deposit.txtAmt.PlaceholderText = "नकद"
        Deposit.DepositBtn.Text = "जमा"
        Deposit.exitBtn.Text = "वापस जाओ"
        withdraw.txtwelcome.Text = "स्वागत"
        withdraw.txtcard.Text = "कार्ड संख्या"
        withdraw.txtAmt.PlaceholderText = "नकद"
        withdraw.withdrawBtn.Text = "नकद निकासी"
        withdraw.exitBtn.Text = "वापस जाओ"
        transfer.txtwelcome.Text = "स्वागत"
        transfer.txtcard.Text = "कार्ड संख्या"
        transfer.txtAcc.PlaceholderText = "प्राप्तकर्ता का कार्ड नंबर दर्ज करें"
        transfer.txtAmt.PlaceholderText = "नकद"
        transfer.BtnTransfer.Text = "नकद अंतरण"
        transfer.exitBtn.Text = "वापस जाओ"
        change_pin.txtwelcome.Text = "स्वागत"
        change_pin.txtcard.Text = "कार्ड संख्या"
        change_pin.txtPin.PlaceholderText = "नया पिन"
        change_pin.changepinBtn.Text = "पिन बदलें"
        change_pin.exitBtn.Text = "वापस जाओ"
        Statement.txtwelcome.Text = "स्वागत"
        Statement.txtcard.Text = "कार्ड संख्या"
        Statement.DstatementBtn.Text = "जमा विवरण"
        Statement.DstatementBtn.Location = New Point(180, 250)
        Statement.WstatementBtn.Text = "नकद विवरण"
        Statement.WstatementBtn.Width = 300
        Statement.WstatementBtn.Location = New Point(180, 320)
        Statement.TstatementBtn.Text = "अंतरण विवरण"
        Statement.TstatementBtn.Width = 230
        Statement.TstatementBtn.Location = New Point(180, 180)
        Statement.backBtn.Text = "वापस जाओ"
        btnEnglish.Visible = True
    End Sub

    Private Sub selectedenglish()
        IconButton1.Text = "Register"
        IconButton2.Text = "Login"
        IconButton3.Text = "Services"
        IconButton4.Text = "Contact us"
        IconButton5.Text = "About us"
        login_frm.txtAcc.PlaceholderText = "Card no."
        login_frm.txtPin.PlaceholderText = "Pin"
        login_frm.login.Text = "Login"
        login_frm.loginbtn.Text = "Login"
        login_frm.linkForgot.Text = "Forgot pin? , click here"
        login_frm.newusr.Text = "New user? , Click here"
        forgotpass.txtacc.Text = "Card no."
        forgotpass.cardnoBtn.Text = "Send OTP"
        forgotpass.txtOtp.Text = "Enter OTP"
        forgotpass.OkBtn.Text = "OK"
        forgotpass.txtPin.Text = "New Pin"
        forgotpass.PinBtn.Text = "Change Pin"
        Registerfrm.btnRegist.Text = "User Registration"
        Registerfrm.txtAcc.PlaceholderText = "Card no."
        Registerfrm.txtPin.PlaceholderText = "Pin"
        Registerfrm.txtFname.PlaceholderText = "First name"
        Registerfrm.txtLname.PlaceholderText = "Last name"
        Registerfrm.txtEmail.PlaceholderText = "Email"
        Registerfrm.txtAddr.PlaceholderText = "Address"
        Registerfrm.txtContact.PlaceholderText = "Contact no."
        Registerfrm.maleRadio.Text = "Male"
        Registerfrm.femaleRadio.Text = "Female"
        Registerfrm.DOB.Text = "D-O-B"
        Registerfrm.linklogin.Text = "Already have an account ?  click here"
        Registerfrm.imgBrowse.Text = "Select image"
        Transaction.lblwelcome.Text = "Welcome"
        Transaction.lblcard.Text = "Card no."
        Transaction.btnLogout.Text = "Logout"
        Transaction.Depositbtn.Text = "Deposit"
        Transaction.withdrawBtn.Text = "Withdraw"
        Transaction.balanceBtn.Text = "Balance"
        Transaction.transferBtn.Text = "Transfer"
        Transaction.changepinBtn.Text = "Change pin"
        Transaction.loanBtn.Text = "Get Loan/Return Loan"
        Transaction.statementBtn.Text = "Statement"
        balance.txtwelcome.Text = "Welcome"
        balance.lblcard.Text = "Card no."
        balance.lblbalance.Text = "Balance amount"
        balance.ExitBtn.Text = "Back"
        balance.Balancebtn.Text = " Check balance"
        Deposit.lblwelcome.Text = "Welcome"
        Deposit.lblcard.Text = "Card no."
        Deposit.txtAmt.PlaceholderText = "Enter amount"
        Deposit.DepositBtn.Text = "Deposit"
        Deposit.exitBtn.Text = "Back"
        withdraw.txtwelcome.Text = "Welcome"
        withdraw.txtcard.Text = "Card no."
        withdraw.txtAmt.PlaceholderText = "Enter amount"
        withdraw.withdrawBtn.Text = "Withdraw"
        withdraw.exitBtn.Text = "Back"
        transfer.txtwelcome.Text = "Welcome"
        transfer.txtcard.Text = "Card no."
        transfer.txtAcc.PlaceholderText = "Account No."
        transfer.txtAmt.PlaceholderText = "Enter amount"
        transfer.BtnTransfer.Text = "Transfer"
        transfer.exitBtn.Text = "Back"
        change_pin.txtwelcome.Text = "Welcome"
        change_pin.txtcard.Text = "Card no."
        change_pin.txtPin.PlaceholderText = "Enter new pin"
        change_pin.changepinBtn.Text = "Change pin"
        change_pin.exitBtn.Text = "Back"
        Statement.txtwelcome.Text = "Welcome"
        Statement.txtcard.Text = "Card no."
        Statement.DstatementBtn.Text = "Deposit Statement"
        Statement.DstatementBtn.Location = New Point(43, 290)
        Statement.WstatementBtn.Text = "Withdraw Statement"
        Statement.WstatementBtn.Location = New Point(259, 290)
        Statement.TstatementBtn.Text = "Transfer Statement"
        Statement.TstatementBtn.Location = New Point(476, 290)
        Statement.backBtn.Text = "Back"
    End Sub

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        selectedenglish()
    End Sub




    Private Sub g_panel_MouseUp(sender As Object, e As MouseEventArgs) Handles g_panel.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub g_panel_MouseMove(sender As Object, e As MouseEventArgs) Handles g_panel.MouseMove
        If IsFormBeingDragged Then
            Dim newLocation As Point = New Point()

            newLocation.X = Me.Location.X + (e.X - MouseDownX)
            newLocation.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = newLocation
            newLocation = Nothing
        End If
    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
        Me.Close()
    End Sub

    Private Sub IconPictureBox2_Click_1(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class




Public Structure rgbcolors
    Public Shared color1 As Color = Color.FromArgb(172, 126, 241)
    Public Shared color2 As Color = Color.FromArgb(249, 118, 176)
    Public Shared color3 As Color = Color.FromArgb(253, 138, 114)
    Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
    Public Shared color5 As Color = Color.FromArgb(249, 88, 155)


End Structure
