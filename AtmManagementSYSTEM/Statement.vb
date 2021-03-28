Imports MySql.Data.MySqlClient
Public Class Statement
    Dim mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim dbdataset As New DataTable
    Dim dbdataset1 As New DataTable

    Private Sub Statement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        lblName.Text = Transaction.lblName.Text
        lblAcc.Text = Transaction.lblAcc.Text
        Datagridview2.Visible = False
        lblstatement.Visible = False
    End Sub

    Private Sub DstatementBtn_Click(sender As Object, e As EventArgs) Handles DstatementBtn.Click
        lblstatement.Text = "Deposit"
        lblstatement.Visible = True
        Datagridview2.Visible = False
        DataGridView1.Visible = True
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource


        Try
            mysqlconn.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select acc_no as 'Card Number',dep_date as 'Date' ,dep_amt as 'Amount' from atm.deposit_statement where acc_no='" & lblAcc.Text & "' and dep_date between '" & FromDtp.Text & "' and '" & TODtp.Text & "' "

            Command = New MySqlCommand(Query, mysqlconn)
            SDA.SelectCommand = Command

            SDA.Fill(dbdataset)
                bSource.DataSource = dbdataset
                DataGridView1.DataSource = bSource
                SDA.Update(dbdataset)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

    Private Sub WstatementBtn_Click(sender As Object, e As EventArgs) Handles WstatementBtn.Click
        lblstatement.Text = "Withdraw"
        lblstatement.Visible = True
        Datagridview2.Visible = False
        DataGridView1.Visible = True
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource


        Try

            mysqlconn.Open()
            dbdataset.Clear()
            Dim Query As String
            Query = "select acc_no as 'Card Number',w_date as 'Date' ,w_amt as 'Amount' from atm.withdraw_statement where acc_no='" & lblAcc.Text & "' and w_date between '" & FromDtp.Text & "' and '" & TODtp.Text & "'"

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

    Private Sub TstatementBtn_Click(sender As Object, e As EventArgs) Handles TstatementBtn.Click
        lblstatement.Text = "Transfer"
        lblstatement.Visible = True
        Datagridview2.Visible = False
        DataGridView1.Visible = True
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource


        Try
            mysqlconn.Open()
            dbdataset1.Clear()
            Dim Query As String
            Query = "select acc_no as 'Card Number',t_date as 'Date' ,amt_transferred as 'Amount', to_account as 'transferred to' from atm.transfer_statement where acc_no='" & lblAcc.Text & "' and t_date between '" & FromDtp.Text & "' and '" & TODtp.Text & "' "

            Command = New MySqlCommand(Query, mysqlconn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset1)
            bSource.DataSource = dbdataset1
            DataGridView1.DataSource = bSource
            SDA.Update(dbdataset1)


            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try


    End Sub

    Private Sub IconPictureBox4_Click(sender As Object, e As EventArgs) Handles IconPictureBox4.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        MainMenu.Show()
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

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Me.Close()
        Transaction.Show()
    End Sub
End Class


