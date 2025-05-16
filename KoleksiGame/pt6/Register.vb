Imports MySql.Data.MySqlClient
Public Class Register
    ' Fungsi untuk menghapus isi textbox
    Sub Memuat()
        txtUsername.Clear()
        txtPassword.Clear()
        txtCPassword.Clear()
        txtUsername.Focus()
    End Sub

    ' Ketika btnLogin ditekan, maka akan memeriksa apakah username dan password sudah diisi
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtCPassword.Text = "" Then
            MessageBox.Show("Username atau Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        CMD = New MySqlCommand("SELECT * FROM akun WHERE username = @username", CONN)
        CMD.Parameters.AddWithValue("@username", txtUsername.Text)
        RD = CMD.ExecuteReader()
        Dim usernameExists As Boolean = RD.HasRows
        RD.Close()

        If usernameExists Then
            MessageBox.Show("Username sudah terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtPassword.Text <> txtCPassword.Text Then
            MessageBox.Show("Password tidak sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        CMD = New MySqlCommand("insert into akun (username,password) values (@username, @password)", CONN)
        CMD.Parameters.AddWithValue("@username", txtUsername.Text)
        CMD.Parameters.AddWithValue("@password", txtPassword.Text)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Akun berhasil dibuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Memuat()
        txtUsername.Focus()
        Me.Hide()
        Login.Show()
    End Sub

    ' Fungsi untuk mengload beberapa komponen ketika form ini dimuat
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtPassword.PasswordChar = "o"c
        txtCPassword.PasswordChar = "o"c
        eyeclosed1.Visible = False
        eyeclosed2.Visible = False
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCPassword.Focus()
        End If
    End Sub

    Private Sub txtCPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub eye1_Click(sender As Object, e As EventArgs) Handles eye1.Click
        txtPassword.PasswordChar = ControlChars.NullChar
        eyeclosed1.Visible = True
        eye1.Visible = False
    End Sub

    Private Sub eyeclosed1_Click(sender As Object, e As EventArgs) Handles eyeclosed1.Click
        txtPassword.PasswordChar = "o"c
        eyeclosed1.Visible = False
        eye1.Visible = True
    End Sub

    Private Sub eye2_Click(sender As Object, e As EventArgs) Handles eye2.Click
        txtCPassword.PasswordChar = ControlChars.NullChar
        eyeclosed2.Visible = True
        eye2.Visible = False
    End Sub

    Private Sub eyeclosed2_Click(sender As Object, e As EventArgs) Handles eyeclosed2.Click
        txtCPassword.PasswordChar = "o"c
        eyeclosed2.Visible = False
        eye2.Visible = True
    End Sub
End Class