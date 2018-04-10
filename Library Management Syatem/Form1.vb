Public Class Form1


    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Form2.Show()
            Timer1.Stop()
        End If

    End Sub
End Class
