Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail
Public Class change_pin
    Dim mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim emailID As String

    Private Sub change_pin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        lblName.Text = Transaction.lblName.Text
        lblAcc.Text = Transaction.lblAcc.Text
        lblDate.Text = Transaction.label5.Text
    End Sub

    Private Sub changepinBtn_Click(sender As Object, e As EventArgs) Handles changepinBtn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=punith123;database=atm"
        Dim reader As MySqlDataReader

        Try

            mysqlconn.Open()
            Dim query As String
            query = "UPDATE atm.tblinfo SET pin='" & txtPin.Text & "'" & " Where account_no='" & lblAcc.Text & "'"
            Command = New MySqlCommand(query, mysqlconn)
            reader = Command.ExecuteReader

            MsgBox("Pin changed succesfully, Confirmation sent to you via Email", MsgBoxStyle.Information, "Change Pin")
            getemail()
            emailsender()
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            mysqlconn.Dispose()
        End Try
        Me.Close()
        endtransaction.Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
        Transaction.Show()
        txtPin.Text = ""
    End Sub

    Public Sub getemail()
        Try
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select email from atm.tblinfo where account_no='" & lblAcc.Text & "'"
            Command = New MySqlCommand(query, mysqlconn)
            reader = Command.ExecuteReader
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

    Public Sub emailsender()

        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(emailID)

            eMessage.Subject = "Pin Changed"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblName.Text & " Pin number for your account number  " & lblAcc.Text & "  was changed on " & lblDate.Text & " ! If it was not you , please contact your bank ASAP!"


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

    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub IconPictureBox4_Click(sender As Object, e As EventArgs) Handles IconPictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
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
