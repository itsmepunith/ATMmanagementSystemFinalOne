Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail

Public Class forgotpass
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim emailID As String
    Dim otp As String

    Private Sub forgotpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        txtOtp.Enabled = False
        txtPin.Enabled = False
        OkBtn.Enabled = False
        PinBtn.Enabled = False
    End Sub

    Public Sub otpgenerator()
        Dim randotp As New Random
        otp = randotp.Next(100000, 999999)
    End Sub

    Public Sub emailsender()

        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(emailID)

            eMessage.Subject = "OTP"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "One time password (OTP) to change pin number for your account number, " & txtacc.Text & " is " & otp & ""


            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential("globalimsbank@gmail.com", "punith123")
            SmtpServer.EnableSsl = True
            eMessage.IsBodyHtml = True
            SmtpServer.Send(eMessage)
            MsgBox("OTP sent via email!", MsgBoxStyle.Information, "OTP")
            txtOtp.Enabled = True
            OkBtn.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub postemailsender()

        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(emailID)

            eMessage.Subject = "New Pin Updated"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Pin number for your account number " & txtacc.Text & " was changed succesfully "


            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential("globalimsbank@gmail.com", "punith123")
            SmtpServer.EnableSsl = True
            eMessage.IsBodyHtml = True
            SmtpServer.Send(eMessage)
            txtOtp.Enabled = True
            OkBtn.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub getemail()
        Try
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select email from atm.tblinfo where account_no='" & txtacc.Text & "'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            Dim count As Integer
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                emailID = reader.GetString("email")

                mysqlconn.Close()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Public Sub otpvalidator()
        If txtOtp.Text = otp Then
            MsgBox("Otp validated successfully", MsgBoxStyle.Information, "Success")
            txtPin.Enabled = True
            PinBtn.Enabled = True

        Else
            MsgBox("Incorrect Otp, try again ", MsgBoxStyle.Critical, "Incorrect")
        End If
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        login_frm.Show()
    End Sub

    Private Sub IconPictureBox4_Click(sender As Object, e As EventArgs) Handles IconPictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cardnoBtn_Click(sender As Object, e As EventArgs) Handles cardnoBtn.Click
        otpgenerator()
        getemail()
        emailsender()
    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        otpvalidator()
    End Sub

    Private Sub PinBtn_Click(sender As Object, e As EventArgs) Handles PinBtn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Dim query As String
        Dim reader As MySqlDataReader
        mysqlconn.Open()
        query = "update  atm.tblinfo set pin='" & txtPin.Text & "' where account_no='" & txtacc.Text & "'"
        command = New MySqlCommand(query, mysqlconn)
        reader = command.ExecuteReader
        MsgBox("Success!! pin was changed succesfully, Confirmation sent via email", MsgBoxStyle.Information, "Success")
        postemailsender()
        mysqlconn.Close()
        Me.Close()
        login_frm.Show()
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

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles panel1.MouseMove
        If IsFormBeingDragged Then
            Dim newLocation As Point = New Point()

            newLocation.X = Me.Location.X + (e.X - MouseDownX)
            newLocation.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = newLocation
            newLocation = Nothing
        End If
    End Sub


End Class