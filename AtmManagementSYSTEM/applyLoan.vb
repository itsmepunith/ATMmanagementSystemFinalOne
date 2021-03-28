Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class applyLoan
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim custname As String
    Dim email As String
    Dim balance As String
    Dim interest As Double
    Dim principle As Double
    Dim rate As Double
    Dim time As Double
    Dim updated_bal As Integer
    Dim penalty As Integer
    Dim months As Integer
    Dim totalmonths As Integer
    Dim income As Integer
    Private Sub getloan_Click(sender As Object, e As EventArgs) Handles getLoan.Click
        If checkbox.Checked = True Then
            data_saver()

        Else
            MsgBox("Read Terms and condition first", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub applyLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        crdlbl.Text = Transaction.lblAcc.Text
        namelbl.Text = Transaction.lblName.Text
        pageloader()
        details_loader()
        loandtp.Value = DateTime.Now.Date
        loandtp.Enabled = False
        interestCmb.Enabled = False
        calcBtn.Enabled = False
        getLoan.Enabled = False

    End Sub

    Private Sub pageloader()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String
            Dim status As String = "Active"
            Dim reader As MySqlDataReader
            query = "select * from atm.loan_db where account_no='" & crdlbl.Text & "' and status='" & status & "'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                months = reader.GetString("months_paid")
                paidlbl.Text = months                                      'assigning months value to txt box of months paid
                dueemi.Value = reader.GetString("due_date")
                amtemi.Text = reader.GetString("emi_amount")
                totalmonths = reader.GetString("total_months")
                pnlmain.Visible = True
                pnlgetLoan.Visible = False
                nextdue.Value = DateTime.Parse(dueemi.Value).AddDays(+31)
            Else
                pnlmain.Visible = False
                pnlgetLoan.Visible = True
            End If
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
            query = "select * from atm.tblinfo where account_no='" & crdlbl.Text & "'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                custname = reader.GetString("FirstName")
                email = reader.GetString("email")
                balance = reader.GetString("balance")
            End While

        Catch ex As MySqlException
            MsgBox(ex.Message)
            mysqlconn.Close()
        End Try
    End Sub
    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        principle = amt.Text
        time = periodCmb.Text / 12
        rate = interestCmb.Text
        interest = ((principle * time * rate) / 100)
        txttotal.Text = Math.Round(principle + interest, 0)
        txtemi.Text = Math.Round(txttotal.Text / periodCmb.Text, 0)
        updated_bal = balance + principle
        duedtp.Value = DateTime.Parse(loandtp.Value).AddDays(+31)
        getLoan.Enabled = True
    End Sub

    Private Sub data_saver()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()

            Dim query As String
            Dim reader As MySqlDataReader
            query = "insert into atm.loan_db (account_no,name,date_taken,total_amt,status,email,months_paid,emi_amount,total_months,due_date,approve) values ('" & crdlbl.Text & "','" & namelbl.Text & "','" & loandtp.Value & "','" & txttotal.Text & "','Active','" & email & "','0','" & txtemi.Text & "','" & periodCmb.Text & "','" & duedtp.Value & "','No')"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            MsgBox("Your loan request has been sent for approval, if approved amount will be debited to your account in 2-3 working days :)")
            emailNotify()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        pnlmain.Visible = False
    End Sub

    Private Sub calcemi_Click(sender As Object, e As EventArgs) Handles calcemi.Click
        difference()
    End Sub
    Private Sub difference()
        Dim dateone = dueemi.Value
        Dim datetwo = DateTime.Now.Date
        Dim diff As TimeSpan = datetwo.Subtract(dateone)
        If diff.Days > 0 Then
            Dim finaldate As Double
            finaldate = diff.Days
            penalty = finaldate * 5

        Else
            penalty = 0
            ttlemiamt.Text = amtemi.Text + penalty
        End If
    End Sub

    Private Sub PayemiBtn_Click(sender As Object, e As EventArgs) Handles PayemiBtn.Click
        Dim final_month As Integer = totalmonths - 1
        If months = final_month Then
            payemiLastMonth()
        Else
            payemi()
        End If

    End Sub

    Private Sub payemi()                                                                     ''update in database when months < 9
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim thismonthpaid = months + 1
            Dim query As String
            Dim reader As MySqlDataReader
            query = "update  atm.loan_db set months_paid='" & thismonthpaid & "',due_date='" & nextdue.Value & "' where account_no='" & crdlbl.Text & "' and status='Active'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            MsgBox("Emi paid , thanks for paying", MsgBoxStyle.Information, "Paid")
            Me.Close()
            mysqlconn.Close()
            Transaction.Show()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub payemiLastMonth()                                              '' update in database if its last month(change status of loan from active to paid)
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim thismonthpaid = months + 1
            Dim status As String = "Paid"
            Dim query As String
            Dim reader As MySqlDataReader
            query = "update  atm.loan_db set months_paid='" & thismonthpaid & "' , due_date='" & nextdue.Value & "' , status='" & status & "' where account_no='" & crdlbl.Text & "' and Status='Active' "
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            MsgBox("Emi paid , thanks for completing the loan", MsgBoxStyle.Information, "Paid")
            mysqlconn.Close()
            Me.Close()
            Transaction.Show()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub periodCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles periodCmb.SelectedIndexChanged
        If periodCmb.Text = 6 Then
            interestCmb.Text = 7.5
        ElseIf periodCmb.Text = 8 Then
            interestCmb.Text = 7.5
        ElseIf periodCmb.Text = 10 Then
            interestCmb.Text = 9.5
        Else
            interestCmb.Text = 9.5

        End If
    End Sub




    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
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
        Transaction.Show()
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub chckEligibility_Click(sender As Object, e As EventArgs) Handles chckEligibility.Click
        check_income()
        Select Case LCase(income)
            Case "200000"
                If amt.SelectedIndex = 0 Then
                    MsgBox("eligible")
                    calcBtn.Enabled = True
                Else
                    MsgBox("Not eligible")
                End If

            Case "500000"
                If amt.SelectedIndex = 0 Or amt.SelectedIndex = 1 Then
                    MsgBox("eligible")
                    calcBtn.Enabled = True
                Else
                    MsgBox("Not eligible")
                End If
            Case "1000000"
                If amt.SelectedIndex = 0 Or amt.SelectedIndex = 1 Or amt.SelectedIndex = 2 Then
                    MsgBox("eligible")
                    calcBtn.Enabled = True
                Else
                    MsgBox("Not eligible")
                End If
            Case "1500000"
                If amt.SelectedIndex = 0 Or amt.SelectedIndex = 1 Or amt.SelectedIndex = 2 Or amt.SelectedIndex = 3 Then
                    MsgBox("eligible")
                    calcBtn.Enabled = True
                Else
                    MsgBox("Not eligible")
                End If

        End Select


    End Sub

    Private Sub check_income()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from atm.tblinfo where account_no='" & crdlbl.Text & "' "
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read()
                income = reader.GetString("income")
            End While
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub emailNotify()
        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(email)

            eMessage.Subject = "Loan Request"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & namelbl.Text & " Greetings from Global IMS Bank , We have recieved your loan request! it will be approved within 2-3 days"


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


End Class