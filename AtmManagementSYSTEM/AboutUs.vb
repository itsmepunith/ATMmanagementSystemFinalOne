Public Class AboutUs

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
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

    Private Sub AboutUs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ico As New System.Drawing.Icon("C:\Users\ADMIN\Documents\AtmManagementSYSTEM\AtmManagementSYSTEM\favicon.ico")
        Me.Icon = Ico
    End Sub
End Class