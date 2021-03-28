Imports MySql.Data.MySqlClient


Public Class complaints
    Dim dbdataset As New DataTable
    Dim mysqlconn As New MySqlConnection
    Dim Command As New MySqlCommand
    Private Sub complaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbdataset.Clear()
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString =
           "server=localhost;userid=root;password=punith123;database=atm"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource


        Try
            mysqlconn.Open()
            Dim Query As String
            Query = "select id as 'No.' , Stars as 'Ratings', Suggestions as 'Complaints/Suggestions' from atm.ratingdb"

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

    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        Dim mysqlconn = New MySqlConnection
        Dim i As Integer
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"

        Try
            mysqlconn.Open()
            Dim query As String

            query = "select count(*)  from atm.ratingdb "
            Command = New MySqlCommand(query, mysqlconn)
            i = Command.ExecuteScalar

            txtTotal.Text = i * 5

            query = "select sum(Stars)  from atm.ratingdb "
            Command = New MySqlCommand(query, mysqlconn)
            Dim n As Integer = Command.ExecuteScalar

            txtCust.Text = n

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class