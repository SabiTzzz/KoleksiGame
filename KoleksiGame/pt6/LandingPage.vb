Public Class LandingPage
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Visible = False
        loadingPic.Visible = True
        loadingTimer.Start()
    End Sub

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStart.Visible = True
        loadingPic.Visible = False
    End Sub

    Private Sub loadingTimer_Tick(sender As Object, e As EventArgs) Handles loadingTimer.Tick
        loadingTimer.Stop()
        Login.Show()
        Me.Hide()

        loadingPic.Visible = False
        btnStart.Visible = True
    End Sub

    Private Sub LandingPage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            btnStart_Click(sender, e)
        End If
    End Sub
End Class