Imports MySql.Data.MySqlClient
Public Class Login
    Sub Memuat()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username atau Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        CMD = New MySqlCommand("select * from akun where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            Memuat()
            IDAKUNLOGIN = RD.Item("idakun").ToString
            Dim Menu As New MenuGame
            Menu.Show()
            Hide()
        Else
            MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Memuat()
        txtUsername.Focus()
        RD.Close()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtPassword.PasswordChar = "o"c
        eyeclosed.Visible = False
        txtUsername.Focus()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub eye_click(sender As Object, e As EventArgs) Handles eye.Click
        txtPassword.PasswordChar = ControlChars.NullChar
        eyeclosed.Visible = True
        eye.Visible = False
    End Sub

    Private Sub eyeclosed_Click(sender As Object, e As EventArgs) Handles eyeclosed.Click
        txtPassword.PasswordChar = "o"c
        eyeclosed.Visible = False
        eye.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Register.Show()
    End Sub
End Class