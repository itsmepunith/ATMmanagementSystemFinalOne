Imports MySql.Data.MySqlClient
Imports System.IO
Public Class login_frm


    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If txtPin.Text = “” Or txtAcc.Text = “” Then
            MsgBox(“One or more Fileds are empty!!”, MsgBoxStyle.Critical, "Alert")
        Else

            Dim conn As MySqlConnection

            Dim cmd As New MySqlCommand
            conn = New MySqlConnection
            conn.ConnectionString = “server=localhost;userid=root;password=punith123;database=atm”
            Dim Reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String
                query = "select * from atm.tblinfo where account_no= '" & txtAcc.Text & "' and Pin = '" & txtPin.Text & "' "
                cmd = New MySqlCommand(query, conn)
                Reader = cmd.ExecuteReader

                Dim count As Integer
                count = 0
                While Reader.Read
                    count = count + 1
                End While

                If count = 1 Then
                    Dim acctype = Reader.GetString("Status")
                    Dim useraccno = Reader.GetString("account_no")
                    Dim usertype = Reader.GetString(“type”)
                    Dim name = Reader.GetString("Firstname")
                    Dim approve = Reader.GetString(“approve”)
                    If approve = "No" Then
                        MsgBox("Your account has not been approved yet, please try again later", MsgBoxStyle.Critical, "Not Approved")
                    Else


                        If acctype = "Block" Then
                            MsgBox("This Card is Blocked ! Contact Administrator", MessageBoxIcon.Error, "Account Suspended")

                        Else

                            If usertype = "Admin" Then
                                MsgBox("Welcome " & name & " you are logged in as Administrator ", MsgBoxStyle.Information, "Success")
                                admin_frm.labelname.Text = name
                                admin_frm.labelacc.Text = useraccno
                                admin_frm.lblacc.Text = useraccno
                                Me.Hide()
                                admin_frm.Show()



                                Me.Hide()
                                conn.Close()
                                conn.Dispose()

                            Else



                                MsgBox("Welcome " & name & "", MsgBoxStyle.Information, "Success")
                                Me.Hide()
                                picloader()
                                Transaction.lblName.Text = name
                                Transaction.lblAcc.Text = useraccno
                                Transaction.lblaccount.Text = useraccno
                                Transaction.Show()
                            End If

                        End If

                    End If
                Else
                    MsgBox(“Wrong Username or Password!”, MsgBoxStyle.Critical, "Alert")
                    txtAcc.Text = ""
                    txtPin.Text = ""
                End If

                conn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
                txtAcc.Text = ""
                txtPin.Text = ""
            End Try
        End If

    End Sub

    Public Sub picloader()
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand

        con = New MySqlConnection("Server=localhost;user=root;password=punith123;database=atm")
        Dim query As String = "select * from atm.tblinfo where account_no=@account_no"
        con.Open()
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@account_no", txtAcc.Text)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        txtAcc.Text = dt.Rows(0)(1).ToString
        Dim img() As Byte
        img = dt.Rows(0)(11)
        Dim ms As New MemoryStream(img)
        Transaction.picbx1.Image = Image.FromStream(ms)
        con.Close()

    End Sub


    Private Sub newusr_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles newusr.LinkClicked
        Me.Close()
        Registerfrm.Show()
    End Sub

    Private Sub linkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgot.LinkClicked
        Me.Close()
        forgotpass.Show()
    End Sub

    Private Sub login_frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
    End Sub


    Private Sub txtAcc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAcc.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
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

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Guna2GradientPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Guna2GradientPanel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

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

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub GunaLinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Close()
        Registerfrm.Show()
    End Sub


End Class

