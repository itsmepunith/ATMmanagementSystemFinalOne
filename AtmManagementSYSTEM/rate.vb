Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Public Class rate
    Dim rating As Integer
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        IconPictureBox2.ForeColor = Color.White
        IconPictureBox3.ForeColor = Color.White
        IconPictureBox4.ForeColor = Color.White
        IconPictureBox5.ForeColor = Color.White
        rating = 0
        IconPictureBox1.ForeColor = Color.Gold
        rating = 1


    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        IconPictureBox1.ForeColor = Color.White
        IconPictureBox3.ForeColor = Color.White
        IconPictureBox4.ForeColor = Color.White
        IconPictureBox5.ForeColor = Color.White
        rating = 0
        IconPictureBox2.ForeColor = Color.Gold
        rating = 2
    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
        IconPictureBox2.ForeColor = Color.White
        IconPictureBox1.ForeColor = Color.White
        IconPictureBox4.ForeColor = Color.White
        IconPictureBox5.ForeColor = Color.White
        rating = 0
        IconPictureBox3.ForeColor = Color.Gold
        rating = 3
    End Sub

    Private Sub IconPictureBox4_Click(sender As Object, e As EventArgs) Handles IconPictureBox4.Click
        IconPictureBox2.ForeColor = Color.White
        IconPictureBox3.ForeColor = Color.White
        IconPictureBox1.ForeColor = Color.White
        IconPictureBox5.ForeColor = Color.White
        rating = 0
        IconPictureBox4.ForeColor = Color.Gold
        rating = 4
    End Sub

    Private Sub IconPictureBox5_Click(sender As Object, e As EventArgs) Handles IconPictureBox5.Click
        IconPictureBox2.ForeColor = Color.White
        IconPictureBox3.ForeColor = Color.White
        IconPictureBox4.ForeColor = Color.White
        IconPictureBox1.ForeColor = Color.White
        rating = 0
        IconPictureBox5.ForeColor = Color.Gold
        rating = 5
    End Sub





    Private Sub rateSubmit_Click(sender As Object, e As EventArgs) Handles rateSubmit.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;user=root;password=punith123;database=atm"
        Try
            mysqlconn.Open()
            Dim query As String
            query = "insert into atm.ratingdb  (Stars,Suggestions) values ('" & rating & "','" & suggestiontxt.Text & "')"
            command = New MySqlCommand(query, mysqlconn)
            reader = command.ExecuteReader


            MsgBox("Thanks for your rating and valuable suggestion ", MsgBoxStyle.Information, "Rating")
            mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class