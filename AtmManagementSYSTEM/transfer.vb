Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail

Public Class transfer
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim transfererBal As Integer
    Dim transfererEmail As String
    Dim recieverBal As Integer
    Dim recieverEmail As String
    Dim finalbal2 As String
    Dim finalbal1 As String

    Private Sub balance_loader()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String = "select * from atm.tblinfo where account_no='" & lblAcc.Text & "'"
            Dim reader As MySqlDataReader
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                transfererBal = reader.GetString("balance")
                transfererEmail = reader.GetString("Email")
            End While
            mysqlconn.Close()
        Catch ex As MySqlException
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

    Private Sub IconPictureBox4_Click(sender As Object, e As EventArgs) Handles IconPictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        txtAcc.Text = ""
        txtAmt.Text = ""
        MainMenu.Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
        Transaction.Show()
        txtAcc.Text = ""
        txtAmt.Text = ""
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

    Private Sub transfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        lblName.Text = Transaction.lblName.Text
        lblAcc.Text = Transaction.lblAcc.Text
        lblDate.Text = Transaction.label5.Text
        balance_loader()
    End Sub

    Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click

        If txtAcc.Text = "" Or txtAmt.Text = "" Then
            MsgBox("One or more fields are empty", MsgBoxStyle.Critical, "Empty")
        Else
            mysqlconn = New MySqlConnection
            mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
            If txtAmt.Text > 500 Then
                Try
                    mysqlconn.Open()
                    Dim query As String = "select * from atm.tblinfo where account_no='" & txtAcc.Text & "'"
                    Dim reader As MySqlDataReader
                    Dim count As Integer = 0
                    command = New MySqlCommand(query, mysqlconn)
                    reader = command.ExecuteReader
                    While reader.Read
                        count = count + 1
                    End While
                    If count = 1 Then
                        recieverBal = reader.GetString("balance")
                        recieverEmail = reader.GetString("Email")
                        If transfererBal > txtAmt.Text Then
                            transferer_bal_update()
                            reciever_bal_update()
                            transfer_dB_updater()
                            MsgBox("Amount transferred succesfully", MsgBoxStyle.Information, "Amount transferred")
                            emailtoReciever()
                            emailsender()
                            reciept.label9.Text = transfererBal
                            reciept.label12.Text = finalbal1
                            reciept.label13.Text = txtAcc.Text
                            reciept.label15.Text = txtAmt.Text
                            reciept.label10.Hide()
                            reciept.label11.Hide()
                            Me.Close()
                            reciept.Show()

                        Else
                            MsgBox("Insufficient balance", MsgBoxStyle.Critical, "Low balance")
                        End If
                    Else
                        MsgBox("Account not found", MsgBoxStyle.Critical, "Account not found")
                    End If
                    mysqlconn.Close()


                Catch ex As MySqlException
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("You cant transfer less than 500", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub transferer_bal_update()
        finalbal1 = transfererBal - txtAmt.Text
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String = "update atm.tblinfo set balance='" & finalbal1 & "' where account_no='" & lblAcc.Text & "'"
            Dim reader As MySqlDataReader
            Dim count As Integer = 0
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub reciever_bal_update()
        finalbal2 = recieverBal + txtAmt.Text
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String = "update atm.tblinfo set balance='" & finalbal2 & "' where account_no='" & txtAcc.Text & "'"
            Dim reader As MySqlDataReader
            Dim count As Integer = 0
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub emailsender()
        Try

            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(transfererEmail)

            eMessage.Subject = "Transferred"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblName.Text & "   Rs." & txtAmt.Text & " has been transferred to Account number " & txtAcc.Text & " on " & lblDate.Text & " Available balance is  " & finalbal1 & ""


            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential("globalimsbank@gmail.com", "punith123")
            SmtpServer.EnableSsl = True
            eMessage.IsBodyHtml = True
            SmtpServer.Send(eMessage)
        Catch ex As Exception
            MsgBox("Check your internet connection, email wasnt sent")

        End Try

    End Sub

    Public Sub emailtoReciever()

        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(recieverEmail)

            eMessage.Subject = "Recieved"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey , rs." & txtAmt.Text & " has been recieved  from Account number " & lblAcc.Text & " on " & lblDate.Text & " available balance=" & finalbal2 & " "


            SmtpServer.UseDefaultCredentials = False
            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential("globalimsbank@gmail.com", "punith123")
            SmtpServer.EnableSsl = True
            eMessage.IsBodyHtml = True
            SmtpServer.Send(eMessage)
        Catch ex As Exception
            MsgBox("Check your internet connection , email wasnt sent")

        End Try

    End Sub

    Private Sub transfer_dB_updater()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String = "insert into transfer_statement (acc_no,t_date,to_account,amt_transferred) values ('" & lblAcc.Text & "','" & lblDate.Text & "','" & txtAcc.Text & "','" & txtAmt.Text & "')"
            Dim reader As MySqlDataReader
            Dim count As Integer = 0
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

End Class