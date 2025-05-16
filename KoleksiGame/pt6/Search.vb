Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Search
    Sub tampilGame()
        DA = New MySqlDataAdapter("select * from tbgame where idakun = '" & IDAKUNLOGIN & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "game")
        DataGridView1.DataSource = DS.Tables("game")
        DataGridView1.Refresh()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim searchText As String = txtCari.Text
        Dim query As String = "SELECT * FROM tbgame WHERE idakun = @idakun AND judul LIKE @searchText"
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@idakun", IDAKUNLOGIN)
        CMD.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet
        DA.Fill(DS, "game")
        DataGridView1.DataSource = DS.Tables("game")
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilGame()
    End Sub
End Class