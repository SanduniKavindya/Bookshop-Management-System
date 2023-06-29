Imports System.Data.SqlClient
Public Class frmBooks
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Documents\BookShop.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub populate()
        con.Open()
        Dim query = "select * from Book"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvBooks.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Private Sub Filter()
        con.Open()
        Dim query = "select * from Book where Category='" & cboFilter.SelectedItem.ToString & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvBooks.DataSource = ds.Tables(0)
        con.Close()

    End Sub



    Private Sub Reset()
        txtBookName.Text = ""
        txtAuthor.Text = ""
        txtQuantity.Text = ""
        txtPrice.Text = ""
        cboCategory.SelectedIndex = -1
        key = 0
    End Sub
    Private Sub btnSaveBook_Click(sender As Object, e As EventArgs) Handles btnSaveBook.Click
        If txtBookName.Text = "" Or txtAuthor.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cboCategory.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query As String
            query = "insert into Book values('" & txtBookName.Text & "','" & txtAuthor.Text & "','" & cboCategory.SelectedItem.ToString & "','" & txtQuantity.Text & "','" & txtPrice.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved Successfully")

            con.Close()
            populate()
            Reset()
        End If
    End Sub
    Dim key = 0
    Private Sub dgvBooks_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBooks.CellMouseClick
        Dim row As DataGridViewRow = dgvBooks.Rows(e.RowIndex)
        txtBookName.Text = row.Cells(1).Value.ToString
        txtAuthor.Text = row.Cells(2).Value.ToString
        cboCategory.SelectedItem = row.Cells(3).Value.ToString
        txtQuantity.Text = row.Cells(4).Value.ToString
        txtPrice.Text = row.Cells(5).Value.ToString
        If txtBookName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If
        dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua

    End Sub

    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub btnResetBook_Click(sender As Object, e As EventArgs) Handles btnResetBook.Click
        Reset()
    End Sub





    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        If key = 0 Then
            MsgBox("Select The Book To Be Deleted")
        Else
            con.Open()
            Dim query As String
            query = "Delete from Book where BId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted Successfully")

            con.Close()
            populate()
            Reset()

        End If
    End Sub

    Private Sub lblCloseAdmin_Click(sender As Object, e As EventArgs) Handles lblCloseBook.Click
        Application.Exit()
    End Sub

    Private Sub btnEditBook_Click(sender As Object, e As EventArgs) Handles btnEditBook.Click
        If txtBookName.Text = "" Or txtAuthor.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Or cboCategory.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query As String
            query = " Update Book set Title='" & txtBookName.Text & "' , Author='" & txtAuthor.Text & "',Category='" & cboCategory.SelectedItem.ToString & "',Quantity='" & txtQuantity.Text & "', Price='" & txtPrice.Text & "' where BId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Updated Successfully")

            con.Close()
            populate()
            Reset()
        End If
    End Sub

    Private Sub cboFilter_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboFilter.SelectionChangeCommitted
        Filter()
    End Sub

    Private Sub btnRefreshBook_Click(sender As Object, e As EventArgs) Handles btnRefreshBook.Click
        populate()
    End Sub

    Private Sub lblUsers_Click(sender As Object, e As EventArgs) Handles lblUsers.Click
        Dim obj = New frmUsers()
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

    Private Sub btnSaveBook_MouseHover(sender As Object, e As EventArgs) Handles btnSaveBook.MouseHover
        btnSaveBook.BackColor = Color.Green
    End Sub

    Private Sub btnSaveBook_MouseLeave(sender As Object, e As EventArgs) Handles btnSaveBook.MouseLeave
        btnSaveBook.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnEditBook_MouseHover(sender As Object, e As EventArgs) Handles btnEditBook.MouseHover
        btnEditBook.BackColor = Color.Green
    End Sub

    Private Sub btnEditBook_MouseLeave(sender As Object, e As EventArgs) Handles btnEditBook.MouseLeave
        btnEditBook.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnDeleteBook_MouseHover(sender As Object, e As EventArgs) Handles btnDeleteBook.MouseHover
        btnDeleteBook.BackColor = Color.Red
    End Sub

    Private Sub btnDeleteBook_MouseLeave(sender As Object, e As EventArgs) Handles btnDeleteBook.MouseLeave
        btnDeleteBook.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnResetBook_MouseHover(sender As Object, e As EventArgs) Handles btnResetBook.MouseHover
        btnResetBook.BackColor = Color.Green
    End Sub

    Private Sub btnResetBook_MouseLeave(sender As Object, e As EventArgs) Handles btnResetBook.MouseLeave
        btnResetBook.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnRefreshBook_MouseHover(sender As Object, e As EventArgs) Handles btnRefreshBook.MouseHover
        btnRefreshBook.BackColor = Color.Maroon
    End Sub

    Private Sub btnRefreshBook_MouseLeave(sender As Object, e As EventArgs) Handles btnRefreshBook.MouseLeave
        btnRefreshBook.BackColor = Color.DarkBlue
    End Sub

    Private Sub lblCloseBook_MouseHover(sender As Object, e As EventArgs) Handles lblCloseBook.MouseHover
        lblCloseBook.BackColor = Color.Red
    End Sub

    Private Sub lblCloseBook_MouseLeave(sender As Object, e As EventArgs) Handles lblCloseBook.MouseLeave
        lblCloseBook.BackColor = Color.Silver
    End Sub


End Class