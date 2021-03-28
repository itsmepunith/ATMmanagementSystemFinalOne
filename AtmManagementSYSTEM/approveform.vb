Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class approveform
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Private Sub clsBtn_Click(sender As Object, e As EventArgs) Handles clsBtn.Click
        Me.Close()
        admin_frm.Show()

    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub approveform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pnlreject.Visible = False
        approveBtn.Enabled = False
        rejectBtn.Enabled = False
        cmbloader()
    End Sub

    Private Sub cmbloader()
        cmbacc.Items.Clear()
        mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
        Try
            mysqlconn.Open()
            Dim query As String
            Dim reader As MySqlDataReader
            query = "select * from atm.tblinfo where approve='No'"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                Dim accno As String = reader.GetString("account_no")
                cmbacc.Items.Add(accno)
            End While
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbacc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbacc.SelectedIndexChanged
        accloader()
        picloader()
        approveBtn.Enabled = True
        rejectBtn.Enabled = True

    End Sub
    Public Sub picloader()
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim query As String = "select * from atm.tblinfo where account_no=@account_no"
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            command.Parameters.AddWithValue("@account_no", cmbacc.Text)
            Dim da As New MySqlDataAdapter(command)
            Dim dt As New DataTable
            da.Fill(dt)
            cmbacc.Text = dt.Rows(0)(1).ToString
            Dim img() As Byte
            img = dt.Rows(0)(11)
            Dim ms As New MemoryStream(img)
            picbx1.Image = Image.FromStream(ms)
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub accloader()
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim reader As MySqlDataReader
            Dim query As String = "select * from atm.tblinfo where account_no='" & cmbacc.Text & "'"
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            While reader.Read
                lblFname.Text = reader.GetString("Firstname")
                lblLname.Text = reader.GetString("Lastname")
                lblAddr.Text = reader.GetString("Address")
                lblContact.Text = reader.GetString("Contact_no")
                lblGender.Text = reader.GetString("Gender")
                lblEmail.Text = reader.GetString("email")
                lblDob.Text = reader.GetString("Birthday")
                lblPanno.Text = reader.GetString("pan_no")
                lblAcctype.Text = reader.GetString("accType")
            End While
            mysqlconn.Close()
        Catch ex As MySqlException
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

    Private Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim reader As MySqlDataReader
            Dim query As String = "Update atm.tblinfo set approve='Yes' where account_no='" & cmbacc.Text & "'"
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            MsgBox("Account request approved", MsgBoxStyle.Information, "Approve")
            emailApprove()
            cmbacc.Text = ""
            fieldsclear()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        mysqlconn.Close()
        cmbloader()
    End Sub

    Private Sub rejectBtn_Click(sender As Object, e As EventArgs) Handles rejectBtn.Click
        Pnlreject.Visible = True
    End Sub

    Private Sub fieldsclear()
        lblFname.Text = ""
        lblLname.Text = ""
        lblAddr.Text = ""
        lblContact.Text = ""
        lblGender.Text = ""
        lblEmail.Text = ""
        lblDob.Text = ""
        lblPanno.Text = ""
        lblAcctype.Text = ""
        txtreason.Text = ""
        picbx1.Image = Nothing
    End Sub

    Private Sub emailApprove()
        Try
            Dim eMessage As New MailMessage()
            Dim SmtpServer As New SmtpClient("smtp.gmail.com")
            eMessage.From = New MailAddress("globalimsbank@gmail.com")
            eMessage.To.Add(lblEmail.Text)

            eMessage.Subject = "Card Approval"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblFname.Text & " Greetings from Global IMS Bank , Your Card number.  " & cmbacc.Text & "  has been approved , You can now use your card number and 4 digit pin to do transactions"


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

            eMessage.Subject = "Card rejected"
            eMessage.Priority = MailPriority.High
            eMessage.Body = "Hey " & lblFname.Text & " We are sorry to inform you that your Card number.  " & cmbacc.Text & "  has been Rejected  , Reason was '" & txtreason.Text & "' plz rectify your mistakes and try again :)"


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

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Pnlreject.Visible = False
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim reader As MySqlDataReader
            Dim query As String = "delete from atm.tblinfo  where account_no='" & cmbacc.Text & "'"
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader
            MsgBox("Account request rejected", MsgBoxStyle.Information, "Rejected")
            emailreject()
            fieldsclear()
            cmbacc.Text = ""
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        mysqlconn.Close()
        cmbloader()
    End Sub
End Class