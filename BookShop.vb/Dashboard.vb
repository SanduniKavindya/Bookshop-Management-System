Imports System.Data.SqlClient
Public Class frmDashboard
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Documents\BookShop.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub CountBooks()
        Dim BookNum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from Book"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        BookNum = cmd.ExecuteScalar
        lblBookNum.Text = BookNum
        con.Close()
    End Sub
    Private Sub CountUsers()
        Dim UsersNum As Integer
        con.Open()
        Dim sql = "select COUNT(*) from Users"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        UsersNum = cmd.ExecuteScalar
        lblUsersNum.Text = UsersNum
        con.Close()
    End Sub

    Private Sub SumAmount()
        Dim Amount As Integer
        con.Open()
        Dim sql = "select Sum(Amount)from Bill"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, con)
        Amount = cmd.ExecuteScalar
        lblAmountNum.Text = "Rs" + Convert.ToString(Amount)
        con.Close()

    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountBooks()
        CountUsers()
        SumAmount()
    End Sub

    Private Sub lblCloseAdmin_Click(sender As Object, e As EventArgs) Handles lblCloseDash.Click
        Application.Exit()
    End Sub

    Private Sub lblBooks_Click(sender As Object, e As EventArgs) Handles lblBooks.Click
        Dim obj = New frmBooks()
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub lblUsers_Click(sender As Object, e As EventArgs) Handles lblUsers.Click
        Dim obj = New frmUsers()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim obj = New frmLogin()
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub picUsers_Click(sender As Object, e As EventArgs) Handles picUsers.Click

    End Sub

    Private Sub picBooks_Click(sender As Object, e As EventArgs) Handles picBooks.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblCloseDash_MouseHover(sender As Object, e As EventArgs) Handles lblCloseDash.MouseHover
        lblCloseDash.BackColor = Color.Red
    End Sub

    Private Sub lblCloseDash_MouseLeave(sender As Object, e As EventArgs) Handles lblCloseDash.MouseLeave
        lblCloseDash.BackColor = Color.Silver
    End Sub

    Private Sub lblAmountNum_Click(sender As Object, e As EventArgs) Handles lblAmountNum.Click

    End Sub

    Private Sub lblUsersNum_Click(sender As Object, e As EventArgs) Handles lblUsersNum.Click

    End Sub
End Class