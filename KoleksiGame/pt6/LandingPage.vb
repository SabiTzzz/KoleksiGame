Public Class LandingPage
    'Ketika tombol start ditekan, maka tombol start akan disembunyikan dan loadingPic akan ditampilkan
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStart.Visible = False
        loadingPic.Visible = True
        loadingTimer.Start()
    End Sub

    'Ketika form ini dimuat, tombol start akan ditampilkan dan loadingPic akan disembunyikan
    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnStart.Visible = True
        loadingPic.Visible = False
    End Sub

    'Ketika timer loadingTimer berhenti, maka form Login akan ditampilkan dan form ini akan disembunyikan
    Private Sub loadingTimer_Tick(sender As Object, e As EventArgs) Handles loadingTimer.Tick
        loadingTimer.Stop()
        Login.Show()
        Me.Hide()

        loadingPic.Visible = False
        btnStart.Visible = True
    End Sub

    'Ketika tombol enter ditekan, maka akan memanggil btnStart_Click
    Private Sub LandingPage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            btnStart_Click(sender, e)
        End If
    End Sub
End Class