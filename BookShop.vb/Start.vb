Public Class frmStart
    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        Dim percentage As String
        percentage = Convert.ToString(ProgressBar1.Value)
        lblPercentage.Text = percentage + "%"
        If ProgressBar1.Value = 100 Then
            frmLogin.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub
End Class
