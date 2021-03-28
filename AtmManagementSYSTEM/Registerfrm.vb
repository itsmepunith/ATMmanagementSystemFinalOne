Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Net.Mail

Public Class Registerfrm
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim gender As String
    Dim income As String


    Private Sub Signup_Click(sender As Object, e As EventArgs) Handles Signup.Click

        If txtAcc.Text = "" Or txtPin.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtEmail.Text = "" Or txtAddr.Text = "" Or txtContact.Text = "" Or txtPancard.Text = "" Or gender = "" Or cmbTypeacc.Text = "Account type" Or cmbIncome.Text = "Select yearly income" Then
            MsgBox("One or more fileds are empty", MsgBoxStyle.Critical, "Empty fields")
        Else
            Dim regex As Regex = New Regex("([A-Z]){5}([0-9]){4}([A-Z]){1}$")
            If Not regex.IsMatch(txtPancard.Text.Trim()) Then
                MsgBox("Incorrect Pan number", MsgBoxStyle.Information, "Pan number error")

            Else
                Try
                    mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
                    Dim query As String
                    query = "insert into atm.tblinfo (account_no,FirstName,LastName,Address,Contact_no,Gender,Birthday,Pin,type,balance,custIMG,Status,email,pan_no,approve,accType,income) values (@account_no,@FirstName,@LastName,@Address,@Contact_no,@Gender,@Birthday,@Pin,@type,@balance,@custIMG,@Status,@email,@pan_no,@approve,@accType,@income)"
                    Dim ms As New MemoryStream
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    mysqlconn.Open()
                    command = New MySqlCommand(query, mysqlconn)
                    command.Parameters.AddWithValue("@account_no", txtAcc.Text)
                    command.Parameters.AddWithValue("@FirstName", txtFname.Text)
                    command.Parameters.AddWithValue("@LastName", txtLname.Text)
                    command.Parameters.AddWithValue("@Address", txtAddr.Text)
                    command.Parameters.AddWithValue("@Contact_no", txtContact.Text)
                    command.Parameters.AddWithValue("@email", txtEmail.Text)
                    command.Parameters.AddWithValue("@Gender", gender)
                    command.Parameters.AddWithValue("@Birthday", bdaydtp.Text)
                    command.Parameters.AddWithValue("@Pin", txtPin.Text)
                    command.Parameters.AddWithValue("@type", "User")
                    command.Parameters.AddWithValue("@balance", "1000")
                    command.Parameters.AddWithValue("@custIMG", ms.ToArray())
                    command.Parameters.AddWithValue("@Status", "Active")
                    command.Parameters.AddWithValue("@pan_no", txtPancard.Text)
                    command.Parameters.AddWithValue("@approve", "No")
                    command.Parameters.AddWithValue("@accType", cmbTypeacc.Text)
                    command.Parameters.AddWithValue("@income", income)
                    command.ExecuteNonQuery()
                    mysqlconn.Close()
                    MsgBox("Your Details have been sent for approval, plz wait for 2-3 days", MsgBoxStyle.Information, "Saved")
                    send_email()
                    field_clear()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub maleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles maleRadio.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub femaleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles femaleRadio.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub imgBrowse_Click(sender As Object, e As EventArgs) Handles imgBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image file (*.jpg;*.bmp;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

        If txtContact.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub linklogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklogin.LinkClicked
        Me.Close()
        login_frm.Show()
    End Sub

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If IsFormBeingDragged Then
            Dim newLocation As Point = New Point()

            newLocation.X = Me.Location.X + (e.X - MouseDownX)
            newLocation.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = newLocation
            newLocation = Nothing
        End If
    End Sub

    Private Sub Registerfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        autonum_generator()
    End Sub


    Private Sub autonum_generator()                                                       'to generate auto card number
        mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
        Try
            mysqlconn.Open()
            Dim query As String
            Dim lastvalue As Integer
            Dim reader As MySqlDataReader
            query = "select * from atm.tblinfo order by account_no desc limit 1 "
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                lastvalue = reader.GetString("account_no")
            End While
            txtAcc.Text = lastvalue + 1
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPancard_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPancard.KeyUp
        Dim regex As Regex = New Regex("([A-Z]){5}([0-9]){4}([A-Z]){1}$")
        If Not regex.IsMatch(txtPancard.Text.Trim()) Then
            txtPancard.FillColor = Color.IndianRed
        Else
            txtPancard.FillColor = Color.Cyan
        End If
    End Sub

    Private Sub field_clear()
        txtAcc.Text = ""
        txtAddr.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtFname.Text = ""
        txtLname.Text = ""
        txtPancard.Text = ""
        txtPin.Text = ""
        cmbTypeacc.Text = "Account type"
        txtPancard.FillColor = Color.White
        bdaydtp.Value = "04-07-2002"
        PictureBox1.Image = Nothing
    End Sub

    Private Sub send_email()
        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(txtEmail.Text)

            eMessage.Subject = "Card Approval"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & txtFname.Text & " Greetings from Global IMS Bank , Your Card number.  " & txtAcc.Text & "  has been sent for approval  , try loging in after 2-3 working days "


            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential("globalimsbank@gmail.com", "punith123")
            SmtpServer.EnableSsl = True
            eMessage.IsBodyHtml = True
            SmtpServer.Send(eMessage)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cmbIncome_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIncome.SelectedIndexChanged
        If cmbIncome.SelectedIndex = 0 Then
            income = 200000
        ElseIf cmbIncome.SelectedIndex = 1 Then
            income = 500000
        ElseIf cmbIncome.SelectedIndex = 2 Then
            income = 1000000
        Else
            income = 1500000
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtLname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class