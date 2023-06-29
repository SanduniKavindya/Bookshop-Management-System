Imports System.Data.SqlClient
Public Class frmUsers

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Documents\BookShop.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub populate()
        con.Open()
        Dim query = "select * from Users"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvUser.DataSource = ds.Tables(0)
        con.Close()

    End Sub
    Private Sub Reset()
        txtUName.Text = ""
        txtPhone.Text = ""
        txtAddress.Text = ""
        txtUPassword.Text = ""
        key = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUName.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or txtUPassword.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query As String
            query = "insert into Users values('" & txtUName.Text & "','" & txtPhone.Text & "','" & txtAddress.Text & "','" & txtUPassword.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Saved Successfully")

            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Dim key = 0
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Select The User To Be Deleted")
        Else
            con.Open()
            Dim query As String
            query = "Delete from Users where Id=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Successfully")

            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub dgvUser_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUser.CellMouseClick
        Dim row As DataGridViewRow = dgvUser.Rows(e.RowIndex)
        txtUName.Text = row.Cells(1).Value.ToString
        txtPhone.Text = row.Cells(2).Value.ToString
        txtAddress.Text = row.Cells(3).Value.ToString
        txtUPassword.Text = row.Cells(4).Value.ToString
        If txtUName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtUName.Text = "" Or txtPhone.Text = "" Or txtAddress.Text = "" Or txtUPassword.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query As String
            query = " Update Users set Name='" & txtUName.Text & "' , phone='" & txtPhone.Text & "',Address='" & txtAddress.Text & "',Password='" & txtUPassword.Text & "' where Id=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Updated Successfully")

            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub lblBooks_Click(sender As Object, e As EventArgs) Handles lblBooks.Click
        Dim obj = New frmBooks()
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub lblDashboard_Click(sender As Object, e As EventArgs) Handles lblDashboard.Click
        Dim obj = New frmDashboard()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim obj = New frmLogin()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub dgvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellContentClick

    End Sub

    Private Sub lblCloseAdmin_Click(sender As Object, e As EventArgs) Handles lblCloseUsers.Click
        Application.Exit()
    End Sub

    Private Sub picUsers_Click(sender As Object, e As EventArgs) Handles picUsers.Click

    End Sub

    Private Sub picDashboard_Click(sender As Object, e As EventArgs) Handles picDashboard.Click

    End Sub

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        btnSave.BackColor = Color.Green
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnEdit_MouseHover(sender As Object, e As EventArgs) Handles btnEdit.MouseHover
        btnEdit.BackColor = Color.Green
    End Sub

    Private Sub btnEdit_MouseLeave(sender As Object, e As EventArgs) Handles btnEdit.MouseLeave
        btnEdit.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnDelete_MouseHover(sender As Object, e As EventArgs) Handles btnDelete.MouseHover
        btnDelete.BackColor = Color.Red
    End Sub
    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnReset_MouseHover(sender As Object, e As EventArgs) Handles btnReset.MouseHover
        btnReset.BackColor = Color.Green
    End Sub

    Private Sub btnReset_MouseLeave(sender As Object, e As EventArgs) Handles btnReset.MouseLeave
        btnReset.BackColor = Color.DarkBlue
    End Sub

    Private Sub lblCloseUsers_MouseHover(sender As Object, e As EventArgs) Handles lblCloseUsers.MouseHover
        lblCloseUsers.BackColor = Color.Red
    End Sub

    Private Sub lblCloseUsers_MouseLeave(sender As Object, e As EventArgs) Handles lblCloseUsers.MouseLeave
        lblCloseUsers.BackColor = Color.Silver
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class