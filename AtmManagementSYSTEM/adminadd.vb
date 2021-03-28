Imports MySql.Data.MySqlClient
Imports System.IO
Public Class adminadd
    Dim mysqlconn As New MySqlConnection
    Dim command As New MySqlCommand
    Dim gender As String
    Private Sub adminaddBtn_Click(sender As Object, e As EventArgs) Handles adminaddBtn.Click
        Try
            mysqlconn = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
            Dim query As String
            query = "insert into atm.tblinfo (account_no,FirstName,LastName,Address,Contact_no,Gender,Birthday,Pin,type,balance,custIMG,Status,email,pan_no,bank,branch,approve,accType,income) values (@account_no,@FirstName,@LastName,@Address,@Contact_no,@Gender,@Birthday,@Pin,@type,@balance,@custIMG,@Status,@email,@pan_no,@bank,@branch,@approve,@accType,@income)"
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            mysqlconn.Open()
            command = New MySqlCommand(query, mysqlconn)
            command.Parameters.AddWithValue("@account_no", txtAcc.Text)
            command.Parameters.AddWithValue("@FirstName", txtFname.Text)
            command.Parameters.AddWithValue("@LastName", txtLname.Text)
            command.Parameters.AddWithValue("@Address", txtAddr.Text)
            command.Parameters.AddWithValue("@Contact_no", txtContact.Text)
            command.Parameters.AddWithValue("@email", txtemail.Text)
            command.Parameters.AddWithValue("@Gender", gender)
            command.Parameters.AddWithValue("@Birthday", bdaydtp.Text)
            command.Parameters.AddWithValue("@Pin", txtPin.Text)
            command.Parameters.AddWithValue("@type", "Admin")
            command.Parameters.AddWithValue("@balance", "20000")
            command.Parameters.AddWithValue("@custIMG", ms.ToArray())
            command.Parameters.AddWithValue("@Status", "Active")
            command.Parameters.AddWithValue("@pan_no", txtPancard.Text)
            command.Parameters.AddWithValue("@bank", "Gims")
            command.Parameters.AddWithValue("@branch", "Bangalore")
            command.Parameters.AddWithValue("@approve", "Yes")
            command.Parameters.AddWithValue("@accType", "Current Account")
            command.Parameters.AddWithValue("@income", "200000")




            command.ExecuteNonQuery()
            mysqlconn.Close()
            MsgBox("Sucessfully Added ", MsgBoxStyle.Information, "New Admin")

        Catch ex As MySqlException
            MsgBox(ex.Message, "error", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub maleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles maleRadio.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub femaleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles femaleRadio.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub imgBrowse_Click(sender As Object, e As EventArgs) Handles imgBrowse.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "image file (*.jpg;*.bmp;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        admin_frm.Show()
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

    Private Sub adminadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
    End Sub
End Class