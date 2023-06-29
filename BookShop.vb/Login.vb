Imports System.Data.SqlClient
Public Class frmLogin
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Documents\BookShop.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Enter Username and Password")
        Else
            con.Open()
            Dim query As String = "Select * from Users where Name='" & txtUsername.Text & "'and Password='" & txtPassword.Text & "'"
            cmd = New SqlCommand(query, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong Username or Password")
            Else
                Dim Bill = New frmBill
                Bill.UserName = txtUsername.Text
                Bill.Show()
                Me.Hide()
            End If
            con.Close()
        End If
    End Sub

    Private Sub lblAdmin_Click(sender As Object, e As EventArgs) Handles lblAdmin.Click
        Dim admin = New frmAdminLogin
        admin.Show()
        Me.Hide()


    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        btnLogin.BackColor = Color.Green
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.DarkBlue
    End Sub

    Private Sub lblAdmin_MouseHover(sender As Object, e As EventArgs) Handles lblAdmin.MouseHover
        lblAdmin.ForeColor = Color.Maroon

    End Sub

    Private Sub lblAdmin_MouseLeave(sender As Object, e As EventArgs) Handles lblAdmin.MouseLeave
        lblAdmin.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblClose_MouseHover(sender As Object, e As EventArgs) Handles lblClose.MouseHover
        lblClose.BackColor = Color.Red
    End Sub

    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        lblClose.BackColor = Color.Silver
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class