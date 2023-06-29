Imports System.Data.SqlClient
Public Class frmBill
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sandu\OneDrive\Documents\BookShop.mdf;Integrated Security=True;Connect Timeout=30")
    Public Property UserName As String

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
        dgvBookList.DataSource = ds.Tables(0)
        con.Close()

    End Sub
    Private Sub frmBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        lblUsername.Text = UserName


    End Sub
    Dim key = 0, Stock = 0, i = 0, GrdTotal = 0

    Private Sub lblCloseAdmin_Click(sender As Object, e As EventArgs) Handles lblCloseBill.Click
        Application.Exit()
    End Sub

    Private Sub UpdateStock()
        Dim NewQty = Stock - Convert.ToInt32(txtQty.Text)
        con.Open()
        Dim query As String
        query = " Update Book set Quantity='" & NewQty & "' where BId=" & key & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        MsgBox("Book Updated Successfully")
        con.Close()
        populate()
    End Sub

    Private Sub AddBill()
        Try
            con.Open()
            Dim query As String
            query = "insert into Bill values('" & lblUsername.Text & "','" & txtClient.Text & "'," & GrdTotal & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Reset()
        key = 0
        txtQty.Text = ""
        txtPrice.Text = ""
        txtClient.Text = ""
        txtBName.Text = ""
    End Sub
    Private Sub btnResetBill_Click(sender As Object, e As EventArgs) Handles btnResetBill.Click
        Reset()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("BOOKSHOP", New Font("Arial", 20, FontStyle.Bold), Brushes.Red, New Point(320, 20))
        e.Graphics.DrawString("----------------------------------------YOUR BILL----------------------------------------", New Font("Arial", 18, FontStyle.Bold), Brushes.MidnightBlue, 20, 70)
        e.Graphics.DrawString("Date:" + DateTime.Now, New Font("Arial", 14, FontStyle.Regular), Brushes.Black, New Point(20, 110))
        e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 14, FontStyle.Regular), Brushes.Black, New Point(20, 132))
        Dim bm As New Bitmap(Me.dgvBookBill.Width, Me.dgvBookBill.Height)
        dgvBookBill.DrawToBitmap(bm, New Rectangle(0, 0, Me.dgvBookBill.Width, Me.dgvBookBill.Height))
        e.Graphics.DrawImage(bm, 250, 170)
        e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 14, FontStyle.Regular), Brushes.Black, New Point(20, 478))
        e.Graphics.DrawString("TOTAL AMOUNT Rs" + GrdTotal.ToString, New Font("Century Gothic", 15, FontStyle.Bold), Brushes.Black, 20, 518)
        e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 14, FontStyle.Regular), Brushes.Black, New Point(20, 558))
        e.Graphics.DrawString("-----------------------------THANKS FOR BUYING IN OUR SHOP-----------------------------", New Font("Century Gothic", 15, FontStyle.Bold), Brushes.Navy, 20, 618)
    End Sub

    Private Sub dgvBookBill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookBill.CellContentClick

    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim obj = New frmLogin()
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddBill_MouseHover(sender As Object, e As EventArgs) Handles btnAddBill.MouseHover
        btnAddBill.BackColor = Color.Green
    End Sub

    Private Sub btnAddBill_MouseLeave(sender As Object, e As EventArgs) Handles btnAddBill.MouseLeave
        btnAddBill.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnResetBill_MouseHover(sender As Object, e As EventArgs) Handles btnResetBill.MouseHover
        btnResetBill.BackColor = Color.Green
    End Sub

    Private Sub btnResetBill_MouseLeave(sender As Object, e As EventArgs) Handles btnResetBill.MouseLeave
        btnResetBill.BackColor = Color.DarkBlue
    End Sub

    Private Sub btnPrint_MouseHover(sender As Object, e As EventArgs) Handles btnPrint.MouseHover
        btnPrint.BackColor = Color.Maroon
    End Sub

    Private Sub btnPrint_MouseLeave(sender As Object, e As EventArgs) Handles btnPrint.MouseLeave
        btnPrint.BackColor = Color.DarkBlue
    End Sub

    Private Sub lblCloseBill_MouseHover(sender As Object, e As EventArgs) Handles lblCloseBill.MouseHover
        lblCloseBill.BackColor = Color.Red
    End Sub

    Private Sub lblCloseAdmin_MouseLeave(sender As Object, e As EventArgs) Handles lblCloseBill.MouseLeave
        lblCloseBill.BackColor = Color.Silver
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog11.Show()
        AddBill()
    End Sub



    Private Sub btnAddBill_Click(sender As Object, e As EventArgs) Handles btnAddBill.Click

        If txtPrice.Text = "" Or txtQty.Text = "" Then
            MsgBox("Enter the Quantity")
        ElseIf txtBName.Text = "" Then
            MsgBox("Select the Book")
        ElseIf Convert.ToInt32(txtQty.Text) > Stock Then
            MsgBox("Not enough Stock")
        Else
            Dim Rnum As Integer = dgvBookBill.Rows.Add()
            i = i + 1
            Dim Total = Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text)
            dgvBookBill.Rows.Item(Rnum).Cells("Column1").Value = i
            dgvBookBill.Rows.Item(Rnum).Cells("Column2").Value = txtBName.Text
            dgvBookBill.Rows.Item(Rnum).Cells("Column3").Value = txtPrice.Text
            dgvBookBill.Rows.Item(Rnum).Cells("Column4").Value = txtQty.Text
            dgvBookBill.Rows.Item(Rnum).Cells("Column5").Value = Total
            GrdTotal = GrdTotal + Total
            Dim Tot As String
            Tot = "Rs" + Convert.ToString(GrdTotal)
            lblTotal.Text = Tot
            UpdateStock()

        End If
    End Sub



    Private Sub dgvBookList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookList.CellContentClick
        Dim row As DataGridViewRow = dgvBookList.Rows(e.RowIndex)
        txtBName.Text = row.Cells(1).Value.ToString
        txtPrice.Text = row.Cells(5).Value.ToString
        stock = Convert.ToInt32(row.Cells(4).Value.ToString)

        If txtBName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If
    End Sub
End Class