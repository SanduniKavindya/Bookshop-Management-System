Imports System.Data.SqlClient
Public Class frmAdminLogin
    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblCancel_Click(sender As Object, e As EventArgs) Handles lblCancel.Click
        Dim obj = New frmLogin()
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub lblCloseAdmin_Click(sender As Object, e As EventArgs) Handles lblCloseAdmin.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin2.Click
        If txtPassword2.Text = "Password" Then
            Dim obj = New frmBooks()
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Passwords")


        End If
    End Sub

    Private Sub btnLogin2_MouseHover(sender As Object, e As EventArgs) Handles btnLogin2.MouseHover
        btnLogin2.BackColor = Color.Green
    End Sub

    Private Sub btnLogin2_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin2.MouseLeave
        btnLogin2.BackColor = Color.DarkBlue
    End Sub

    Private Sub lblCancel_MouseHover(sender As Object, e As EventArgs) Handles lblCancel.MouseHover
        lblCancel.ForeColor = Color.Red
    End Sub

    Private Sub lblCancel_MouseLeave(sender As Object, e As EventArgs) Handles lblCancel.MouseLeave
        lblCancel.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblCloseAdmin_MouseHover(sender As Object, e As EventArgs) Handles lblCloseAdmin.MouseHover
        lblCloseAdmin.BackColor = Color.Red
    End Sub

    Private Sub lblCloseAdmin_MouseLeave(sender As Object, e As EventArgs) Handles lblCloseAdmin.MouseLeave
        lblCloseAdmin.BackColor = Color.Silver
    End Sub
End Class