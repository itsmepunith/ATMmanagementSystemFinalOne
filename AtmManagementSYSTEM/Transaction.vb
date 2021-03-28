Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Transaction
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim acc As String

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
        lblaccount.Visible = False
        acc = lblaccount.Text
        lblAcc.Text = acc
        Dim day As Date
        day = Format(Now(), "short date")
        label5.Text = day

    End Sub




    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
        Me.Close()
        MainMenu.Show()
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

    Private Sub Depositbtn_Click(sender As Object, e As EventArgs) Handles Depositbtn.Click
        Me.Hide()
        Deposit.Show()
    End Sub

    Private Sub withdrawBtn_Click(sender As Object, e As EventArgs) Handles withdrawBtn.Click
        Me.Hide()
        withdraw.Show()
    End Sub

    Private Sub balanceBtn_Click(sender As Object, e As EventArgs) Handles balanceBtn.Click
        Me.Hide()
        balance.Show()
    End Sub

    Private Sub transferBtn_Click(sender As Object, e As EventArgs) Handles transferBtn.Click
        Me.Hide()
        transfer.Show()
    End Sub

    Private Sub changepinBtn_Click(sender As Object, e As EventArgs) Handles changepinBtn.Click
        Me.Hide()
        change_pin.Show()
    End Sub

    Private Sub statementBtn_Click(sender As Object, e As EventArgs) Handles statementBtn.Click
        Me.Hide()
        Statement.Show()
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblAcc.Text = ""
        lblaccount.Text = ""
        lblName.Text = ""
        picbx1.Image = Nothing
        Me.Close()
        login_frm.Show()
    End Sub

    Private Sub loanBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        applyLoan.Show()
    End Sub

    Private Sub loanBtn_Click_1(sender As Object, e As EventArgs) Handles loanBtn.Click
        Me.Hide()
        applyLoan.Show()
    End Sub
End Class