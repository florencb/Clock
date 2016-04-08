Public Class frmClock

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimeDisplay.Text = TimeOfDay.ToLongTimeString()
    End Sub

    Private Sub lblTimeDisplay_Click(sender As Object, e As EventArgs) Handles lblTimeDisplay.Click

    End Sub

    Private Sub frmClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "My Clock"
    End Sub
End Class
