Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail
Public Class Deposit
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim initialbal As Integer
    Dim amt As Integer
    Dim total As Integer
    Dim dep_date As String
    Dim emailID As String


    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        lblName.Text = Transaction.lblName.Text
        lblAcc.Text = Transaction.lblAcc.Text
        lblDate.Text = Transaction.label5.Text
    End Sub

    Private Sub DepositBtn_Click(sender As Object, e As EventArgs) Handles DepositBtn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;userid=root;password=punith123;database=atm"
        If txtAmt.Text = "" Then
            MsgBox("Please Enter Amount!", MsgBoxStyle.Critical, "Amount")
        Else
            Dim reader As MySqlDataReader

            Try
                mysqlconn.Open()
                Dim query As String
                query = "select * from atm.tblinfo where account_no= '" & lblAcc.Text & "' "
                command = New MySqlCommand(query, mysqlconn)
                reader = command.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    Dim bal = reader.GetString("balance")
                    initialbal = bal
                    amt = txtAmt.Text

                    If amt > 20000 Then
                        MsgBox("You cant deposit more than 20000 rupees", MsgBoxStyle.Critical, "Alert")
                    ElseIf amt < 200 Then
                        MsgBox("You cant deposit less than 200 rupees", MsgBoxStyle.Critical, "Alert")
                    Else
                        total = initialbal + amt
                        updater()
                        dep_statement()
                    End If



                End If

                mysqlconn.Close()

            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                mysqlconn.Dispose()
            End Try
            reciept.Label9.Text = initialbal
            reciept.Label11.Text = amt
            reciept.Label12.Text = total
            reciept.label10.Hide()
            reciept.label13.Hide()
            reciept.label15.Hide()
        End If
    End Sub
    Public Sub dep_statement()
        dep_date = Transaction.label5.Text
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=punith123;database=atm"
        Dim reader As MySqlDataReader

        Try
            mysqlconn.Open()
            Dim query As String
            query = " insert into atm.deposit_statement (acc_no,dep_date,dep_amt) values ('" & lblAcc.Text & "','" & dep_date & "','" & amt & "')"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub
    Public Sub updater()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=punith123;database=atm"
        Dim reader As MySqlDataReader

        Try

            mysqlconn.Open()
            Dim query As String
            query = "UPDATE atm.tblinfo SET balance='" & total & "'" & " Where account_no='" & lblAcc.Text & "'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader

            MsgBox("Amount succesfully deposited, Confirmation sent via email ", MsgBoxStyle.Information, "Deposit")
            getemail()
            emailsender()
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            mysqlconn.Dispose()
        End Try
        Me.Hide()
        reciept.Show()

    End Sub

    Public Sub getemail()
        Try
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select email from atm.tblinfo where account_no='" & lblAcc.Text & "'"
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

    Public Sub emailsender()

        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(emailID)

            eMessage.Subject = "Deposit"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblName.Text & " you account number  " & lblAcc.Text & "  has been credited rs." & txtAmt.Text & " on " & lblDate.Text & " Available balance is " & total & ""


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
    Private Sub txtAmt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmt.KeyPress
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
    Private Sub IconPictureBox4_Click(sender As Object, e As EventArgs) Handles IconPictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        MainMenu.Show()
        txtAmt.Text = ""
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
        Transaction.Show()
        txtAmt.Text = ""
    End Sub
End Class