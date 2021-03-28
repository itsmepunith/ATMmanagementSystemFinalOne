Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail

Public Class Loan_approve
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim balance As Integer
    Dim updated_bal As Integer
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
        admin_frm.Show()
    End Sub

    Private Sub minimizeBtn_Click(sender As Object, e As EventArgs) Handles minimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub Loan_approve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pnlreject.Visible = False
        cmb_loader()
    End Sub


    Private Sub cmb_loader()
        cmbCard.Items.Clear()
        mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
        Try
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from atm.loan_db where approve='No'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                Dim accno As String = reader.GetString("account_no")
                cmbCard.Items.Add(accno)
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim reader As MySqlDataReader
            Dim query As String = "Update atm.loan_db set approve='Yes' where account_no='" & cmbCard.Text & "'"
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            details_loader()             'load balance
            balance_updater()                'update balance
            emailApprove()                      'send email
            cmbCard.Text = ""
            fieldsclear()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        mysqlconn.Close()
        cmb_loader()
    End Sub

    Private Sub fieldsclear()
        lblCard.Text = ""
        lblName.Text = ""
        lblAmt.Text = ""
        lblEmail.Text = ""
        lblmthAmt.Text = ""
        lblmth.Text = ""
    End Sub

    Private Sub loan_details()
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim reader As MySqlDataReader
            Dim query As String = "select * from atm.loan_db where account_no='" & cmbCard.Text & "'"
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                lblCard.Text = reader.GetString("account_no")
                lblName.Text = reader.GetString("name")
                lblAmt.Text = reader.GetString("total_amt")
                lblEmail.Text = reader.GetString("email")
                lblmthAmt.Text = reader.GetString("emi_amount")
                lblmth.Text = reader.GetString("total_months")
            End While
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub details_loader()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from atm.tblinfo where account_no='" & lblCard.Text & "'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                balance = reader.GetString("balance")
            End While

        Catch ex As MySqlException
            MsgBox(ex.Message)
            mysqlconn.Close()
        End Try
    End Sub
    Private Sub balance_updater()
        updated_bal = balance + lblAmt.Text
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "update atm.tblinfo set balance='" & updated_bal & "' where account_no='" & lblCard.Text & "'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            MsgBox("Loan sanctioned, amount has been transferred to your account linked to the Card no. '" & lblCard.Text & "'", MsgBoxStyle.Information, "Loan Sanctioned")

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbCard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCard.SelectedIndexChanged
        loan_details()
    End Sub


    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim reader As MySqlDataReader
            Dim query As String = "delete from atm.loan_db  where account_no='" & cmbCard.Text & "'"
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader

            MsgBox("Rejected", MsgBoxStyle.Information, "Rejected")
            emailreject()
            fieldsclear()
            cmbCard.Text = ""
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        mysqlconn.Close()
        cmb_loader()
    End Sub

    Private Sub rejectBtn_Click(sender As Object, e As EventArgs) Handles rejectBtn.Click
        Pnlreject.Visible = True
    End Sub

    Private Sub btnCls_Click(sender As Object, e As EventArgs) Handles btnCls.Click
        Pnlreject.Visible = False
    End Sub

    Private Sub emailApprove()
        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(lblEmail.Text)

            eMessage.Subject = "Loan Approval"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblName.Text & " Greetings from Global IMS Bank , Your loan request for card number.  " & cmbCard.Text & "  has been approved , and amount has been Credited to your account :)"


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

    Private Sub emailreject()
        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(lblEmail.Text)

            eMessage.Subject = "Loan rejected"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblName.Text & " We are sorry to inform you that your loan request Card number.  " & cmbCard.Text & "  has been Rejected  , Reason was '" & txtreason.Text & "' visit bank for more info  :)"


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