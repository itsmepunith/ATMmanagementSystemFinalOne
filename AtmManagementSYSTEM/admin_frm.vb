Imports MySql.Data.MySqlClient
Imports System.IO
Public Class admin_frm
    Dim mysqlconn As New MySqlConnection
    Dim Command As New MySqlCommand
    Dim dbdataset As New DataTable
    Dim GENDER As String
    Dim accno As String

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim reader As MySqlDataReader

        Try
            mysqlconn.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select * from atm.tblinfo where account_no='" & txtAcc.Text & "'"
            Command = New MySqlCommand(Query, mysqlconn)
            reader = Command.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                okBTnLoader()
            Else
                MsgBox("Account linked to entered card number not found", MsgBoxStyle.Critical, "Alert")
                txtAcc.Text = ""
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub okBTnLoader()
        dbdataset.Clear()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource


        Try
            mysqlconn.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select account_no as 'Card Number',Firstname,Lastname,Address,Contact_no as 'Phone Number',Gender from atm.tblinfo where account_no='" & txtAcc.Text & "' "

            Command = New MySqlCommand(Query, mysqlconn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbdataset)


            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

    Private Sub AccStatus_Click(sender As Object, e As EventArgs) Handles AccStatus.Click
        Dim conn As MySqlConnection

        Dim cmd As New MySqlCommand
        conn = New MySqlConnection
        conn.ConnectionString = “server=localhost;userid=root;password=punith123;database=atm”
        Dim Reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select status from atm.tblinfo where account_no='" & txtAcc.Text & "' "
            cmd = New MySqlCommand(query, conn)
            Reader = cmd.ExecuteReader
            Dim count As Integer
            count = 0

            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                Dim accStatus = Reader.GetString(“status”)

                If accStatus = "Active" Then
                    txtStatus.Text = "Active"
                Else
                    txtStatus.Text = "Blocked"

                End If
            End If


            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub loadBtn_Click(sender As Object, e As EventArgs) Handles loadBtn.Click
        dbdataset.Clear()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource


        Try
            mysqlconn.Open()
            Dim Query As String
            Query = "select account_no as 'Card Number',Firstname,Lastname,Address,Contact_no as 'Phone Number',Gender from atm.tblinfo "

            Command = New MySqlCommand(Query, mysqlconn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbdataset)
            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim reader As MySqlDataReader
        Try
            mysqlconn.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select * from atm.tblinfo where account_no='" & txtAcc.Text & "'"
            Command = New MySqlCommand(Query, mysqlconn)
            reader = Command.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                updater()
            Else
                MsgBox("Account linked to entered card number not found", MsgBoxStyle.Critical, "Alert")
                txtAcc.Text = ""
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub updater()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource



        Dim reader As MySqlDataReader
        Try

            mysqlconn.Open()
            Dim query As String
            query = "update atm.tblinfo set Firstname='" & txtFname.Text & "',Lastname='" & txtLname.Text & "',Address='" & txtAddr.Text & "',Contact_no='" & txtContact.Text & "',pin='" & txtPin.Text & "',Gender='" & GENDER & "',Birthday='" & bdayDtp.Text & "',account_no='" & txtAcc.Text & "'where account_no='" & txtAcc.Text & "'"
            Command = New MySqlCommand(query, mysqlconn)
            reader = Command.ExecuteReader

            MsgBox("Account Data Updated ", MsgBoxStyle.Information, "Updated")
            refresh_db()
            mysqlconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub maleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles maleRadio.CheckedChanged
        GENDER = "Male"
    End Sub

    Private Sub femaleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles femaleRadio.CheckedChanged
        GENDER = "Female"
    End Sub



    Private Sub blockBtn_Click(sender As Object, e As EventArgs) Handles blockBtn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim READER As MySqlDataReader


        Try
            mysqlconn.Open()
            Dim Query As String
            Query = " UPDATE atm.tblinfo SET Status = 'Block'  WHERE account_no = '" & txtAcc.Text & "'"
            Command = New MySqlCommand(Query, mysqlconn)
            READER = Command.ExecuteReader
            MsgBox("Account linked to entered card No. was not found", MsgBoxStyle.Information, "Blocked")
            refresh_db()


            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try
    End Sub

    Private Sub unblockBtn_Click(sender As Object, e As EventArgs) Handles unblockBtn.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim READER As MySqlDataReader

        Try
            mysqlconn.Open()
            Dim Query As String
            Query = " UPDATE atm.tblinfo SET Status = 'Active'  WHERE account_no = '" & txtAcc.Text & "'"
            Command = New MySqlCommand(Query, mysqlconn)
            READER = Command.ExecuteReader
            MsgBox("Account linked to entered card No. was Unblocked", MsgBoxStyle.Information, "Unblock")
            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()

        End Try
    End Sub



    Private Sub Admin_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        lblacc.Visible = False
        mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
        Dim query As String = "select * from atm.tblinfo where account_no=@account_no"
        mysqlconn.Open()
        Command = New MySqlCommand(query, mysqlconn)
        Command.Parameters.AddWithValue("@account_no", lblacc.Text)
        Dim da As New MySqlDataAdapter(Command)
        Dim dt As New DataTable
        da.Fill(dt)
        lblacc.Text = dt.Rows(0)(1).ToString
        Dim img() As Byte
        img = dt.Rows(0)(11)
        Dim ms As New MemoryStream(img)
        Picbx1.Image = Image.FromStream(ms)
        mysqlconn.Close()

    End Sub

    Private Sub refresh_db()
        dbdataset.Clear()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource


        Try
            mysqlconn.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select account_no as 'Card number',Firstname,Lastname,Address,Contact_no as 'Phone number',Gender from atm.tblinfo where account_no='" & txtAcc.Text & "' "

            Command = New MySqlCommand(Query, mysqlconn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bSource.DataSource = dbdataset
            DataGridView1.DataSource = bSource
            SDA.Update(dbdataset)


            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
        MainMenu.Show()
    End Sub
    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.Close()
        MainMenu.Show()
    End Sub




    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
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
    End Sub

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Guna2GradientPanel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub


    Private Sub Guna2GradientPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel1.MouseMove
        If IsFormBeingDragged Then
            Dim newLocation As Point = New Point()

            newLocation.X = Me.Location.X + (e.X - MouseDownX)
            newLocation.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = newLocation
            newLocation = Nothing
        End If
    End Sub

    Private Sub Guna2GradientPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub



    Private Sub complaintBtn_Click(sender As Object, e As EventArgs) Handles complaintBtn.Click
        Me.Hide()
        complaints.Show()
    End Sub



    Private Sub loan_acc_approve_Click(sender As Object, e As EventArgs) Handles loan_acc_approve.Click
        Me.Hide()
        approveform.Show()
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        Me.Hide()
        Loan_approve.Show()
    End Sub

    Private Sub adminaddBtn_Click(sender As Object, e As EventArgs) Handles adminaddBtn.Click
        Me.Hide()
        adminadd.Show()
    End Sub
End Class