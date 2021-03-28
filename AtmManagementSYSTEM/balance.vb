Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail
Public Class balance
    Dim mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim emailID As String



    Public Sub emailsender()
        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(emailID)

            eMessage.Subject = "Balance"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblName.Text & " balance for you Account number  " & lblAcc.Text & "  is  " & lblBal.Text & ", Thanks for visiting Global IMS Atm"


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

    Private Sub IconPictureBox4_Click(sender As Object, e As EventArgs) Handles IconPictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico

        lblName.Text = Transaction.lblName.Text
        lblAcc.Text = Transaction.lblAcc.Text
    End Sub

    Private Sub Balancebtn_Click(sender As Object, e As EventArgs) Handles Balancebtn.Click
        Dim cmd As New MySqlCommand
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;userid=root;password=punith123;database=atm"
        Dim Reader As MySqlDataReader
        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * from atm.tblinfo where account_no= '" & lblAcc.Text & "'"
            cmd = New MySqlCommand(query, mysqlconn)
            Reader = cmd.ExecuteReader
            Dim count As Integer
            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                Dim bal = Reader.GetString("balance")
                emailID = Reader.GetString("email")
                lblBal.Text = bal
                MsgBox("Balance has been sent to you via Email", MsgBoxStyle.Information, "Balance")
                emailsender()
                mysqlconn.Close()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        lblBal.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        Transaction.Show()
        lblBal.Text = ""
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        endtransaction.Show()
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