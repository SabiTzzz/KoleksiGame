Imports MySql.Data.MySqlClient
Public Class MenuGame
    Dim currentPage As Integer = 0
    Dim totalRows As Integer = 0
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Font
        Dim fontHeader As New Font("Karmatic Arcade", 16, FontStyle.Bold)
        Dim fontKolom As New Font("AvantGarde LT Book", 11, FontStyle.Bold)
        Dim fontIsi As New Font("AvantGarde LT Book", 10)
        Dim customBrush As New SolidBrush(Color.FromArgb(221, 64, 17)) ' untuk header dan kolom
        Dim whiteBrush As New SolidBrush(Color.White)
        Dim blackBrush As New SolidBrush(Color.Black)

        ' Margin dan layout
        Dim marginL As Integer = 7
        Dim marginT As Integer = 50
        Dim yPos As Integer = marginT

        Dim cellHeight As Integer = 30
        Dim noColW As Integer = 40
        Dim judulColW As Integer = 150
        Dim developerColW As Integer = 150
        Dim ratingColW As Integer = 60
        Dim genreColW As Integer = 115
        Dim platformColW As Integer = 100
        Dim deskripsiColW As Integer = 200

        ' Header judul
        Dim pageWidth As Integer = e.MarginBounds.Width
        Dim headerText As String = "KOLEKSI GAME"
        Dim headerSize As SizeF = e.Graphics.MeasureString(headerText, fontHeader)
        ' Centered horizontally
        e.Graphics.DrawString(headerText, fontHeader, customBrush, e.MarginBounds.Left + (pageWidth - headerSize.Width) / 2, yPos)
        yPos += headerSize.Height + 20

        ' Header kolom
        Dim xPos As Integer = marginL
        Dim formatCenter As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

        ' Warnai background kolom header dan tulis teks putih
        e.Graphics.FillRectangle(customBrush, xPos, yPos, noColW, cellHeight)
        e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, noColW, cellHeight)
        e.Graphics.DrawString("No", fontKolom, whiteBrush, New RectangleF(xPos, yPos, noColW, cellHeight), formatCenter)
        xPos += noColW

        e.Graphics.FillRectangle(customBrush, xPos, yPos, judulColW, cellHeight)
        e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, judulColW, cellHeight)
        e.Graphics.DrawString("Judul", fontKolom, whiteBrush, New RectangleF(xPos, yPos, judulColW, cellHeight), formatCenter)
        xPos += judulColW

        e.Graphics.FillRectangle(customBrush, xPos, yPos, developerColW, cellHeight)
        e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, developerColW, cellHeight)
        e.Graphics.DrawString("Developer", fontKolom, whiteBrush, New RectangleF(xPos, yPos, developerColW, cellHeight), formatCenter)
        xPos += developerColW

        e.Graphics.FillRectangle(customBrush, xPos, yPos, ratingColW, cellHeight)
        e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, ratingColW, cellHeight)
        e.Graphics.DrawString("Rating", fontKolom, whiteBrush, New RectangleF(xPos, yPos, ratingColW, cellHeight), formatCenter)
        xPos += ratingColW

        e.Graphics.FillRectangle(customBrush, xPos, yPos, genreColW, cellHeight)
        e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, genreColW, cellHeight)
        e.Graphics.DrawString("Genre", fontKolom, whiteBrush, New RectangleF(xPos, yPos, genreColW, cellHeight), formatCenter)
        xPos += genreColW

        e.Graphics.FillRectangle(customBrush, xPos, yPos, platformColW, cellHeight)
        e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, platformColW, cellHeight)
        e.Graphics.DrawString("Platform", fontKolom, whiteBrush, New RectangleF(xPos, yPos, platformColW, cellHeight), formatCenter)
        xPos += platformColW

        e.Graphics.FillRectangle(customBrush, xPos, yPos, deskripsiColW, cellHeight)
        e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, deskripsiColW, cellHeight)
        e.Graphics.DrawString("Deskripsi", fontKolom, whiteBrush, New RectangleF(xPos, yPos, deskripsiColW, cellHeight), formatCenter)

        yPos += cellHeight

        ' Data rows
        Dim i As Integer = currentPage
        Dim noUrut As Integer = i + 1

        While i < DataGridView1.Rows.Count
            If DataGridView1.Rows(i).IsNewRow Then Exit While

            xPos = marginL

            ' Ambil data
            Dim row = DataGridView1.Rows(i)
            Dim judul = row.Cells("judul").Value.ToString()
            Dim developer = row.Cells("developer").Value.ToString()
            Dim rating = row.Cells("rating").Value.ToString()
            Dim genre = row.Cells("genre").Value.ToString()
            Dim platform = row.Cells("platform").Value.ToString()
            Dim deskripsi = row.Cells("deskripsi").Value.ToString()

            ' Cek panjang data untuk menentukan tinggi baris
            Dim panjangList() As Integer = {judul.Length, developer.Length, genre.Length, platform.Length, deskripsi.Length}
            Dim rowHeight As Integer = cellHeight

            Dim maxKelipatan As Integer = 0

            For Each panjang In panjangList
                Dim kelipatan As Integer = Math.Ceiling(panjang / 17)
                If kelipatan > maxKelipatan Then
                    maxKelipatan = kelipatan
                End If
            Next

            ' Jika kelipatan 1 artinya <= 17 karakter, maka tidak tambah apa-apa
            If maxKelipatan > 1 Then
                rowHeight += (maxKelipatan - 1) * 20
            End If

            ' Baris data dengan latar putih dan teks hitam
            e.Graphics.FillRectangle(Brushes.White, xPos, yPos, noColW, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, noColW, rowHeight)
            e.Graphics.DrawString(noUrut.ToString(), fontIsi, blackBrush, New RectangleF(xPos, yPos, noColW, rowHeight), formatCenter)
            xPos += noColW

            e.Graphics.FillRectangle(Brushes.White, xPos, yPos, judulColW, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, judulColW, rowHeight)
            e.Graphics.DrawString(judul, fontIsi, blackBrush, New RectangleF(xPos, yPos, judulColW, rowHeight), formatCenter)
            xPos += judulColW

            e.Graphics.FillRectangle(Brushes.White, xPos, yPos, developerColW, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, developerColW, rowHeight)
            e.Graphics.DrawString(developer, fontIsi, blackBrush, New RectangleF(xPos, yPos, developerColW, rowHeight), formatCenter)
            xPos += developerColW

            e.Graphics.FillRectangle(Brushes.White, xPos, yPos, ratingColW, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, ratingColW, rowHeight)
            e.Graphics.DrawString(rating, fontIsi, blackBrush, New RectangleF(xPos, yPos, ratingColW, rowHeight), formatCenter)
            xPos += ratingColW

            e.Graphics.FillRectangle(Brushes.White, xPos, yPos, genreColW, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, genreColW, rowHeight)
            e.Graphics.DrawString(genre, fontIsi, blackBrush, New RectangleF(xPos, yPos, genreColW, rowHeight), formatCenter)
            xPos += genreColW

            e.Graphics.FillRectangle(Brushes.White, xPos, yPos, platformColW, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, platformColW, rowHeight)
            e.Graphics.DrawString(platform, fontIsi, blackBrush, New RectangleF(xPos, yPos, platformColW, rowHeight), formatCenter)
            xPos += platformColW

            e.Graphics.FillRectangle(Brushes.White, xPos, yPos, deskripsiColW, rowHeight)
            e.Graphics.DrawRectangle(Pens.Black, xPos, yPos, deskripsiColW, rowHeight)
            e.Graphics.DrawString(deskripsi, fontIsi, blackBrush, New RectangleF(xPos, yPos, deskripsiColW, rowHeight), formatCenter)

            yPos += rowHeight
            i += 1
            noUrut += 1

            If yPos + cellHeight > e.MarginBounds.Bottom Then
                currentPage = i
                e.HasMorePages = True
                Return
            End If
        End While

        currentPage = 0
        e.HasMorePages = False
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If DataGridView1.Rows.Count = 0 OrElse (DataGridView1.Rows.Count = 1 AndAlso DataGridView1.Rows(0).IsNewRow) Then
            MessageBox.Show("Silahkan tambahkan game terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If DataGridView1.Rows.Count = 0 OrElse (DataGridView1.Rows.Count = 1 AndAlso DataGridView1.Rows(0).IsNewRow) Then
            MessageBox.Show("Silahkan tambahkan game terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim printDialog As New PrintDialog
        printDialog.Document = PrintDocument1
        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.PrinterSettings = printDialog.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub


    Private Sub ClearRadioButtons(group As Panel)
        For Each ctrl As Control In group.Controls
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            End If
        Next
    End Sub

    Sub Memuat()
        txtJudul.Clear()
        txtDeveloper.Clear()
        txtGenre.SelectedIndex = -1
        txtPlatform.SelectedIndex = -1
        ClearRadioButtons(Panel1)
        txtDeskripsi.Clear()
        txtSearch.Clear()
    End Sub

    Sub tampilGame()
        Dim query As String = "
        SELECT 
            g.idgame, 
            g.judul,
            g.rating, 
            ge.genre, 
            pl.platform, 
            g.rilis, 
            g.developer, 
            g.deskripsi,
            a.username AS `uploaded by`
        FROM tbgame g
        JOIN tbgenre ge ON g.id_genre = ge.id_genre
        JOIN tbplatform pl ON g.id_platform = pl.id_platform
        JOIN akun a ON g.idakun = a.idakun
        "

        CMD = New MySqlCommand(query, CONN)

        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "game")
        DataGridView1.DataSource = DS.Tables("game")
        DataGridView1.Refresh()
    End Sub


    Sub generateID()
        CMD = New MySqlCommand("SELECT idgame FROM tbgame ORDER BY idgame", CONN)
        Dim reader As MySqlDataReader = CMD.ExecuteReader()

        Dim usedID As New List(Of Integer)

        While reader.Read()
            Dim id As String = reader("idgame").ToString()
            If id.StartsWith("G") Then
                Dim numPart As Integer
                If Integer.TryParse(id.Substring(1), numPart) Then
                    usedID.Add(numPart)
                End If
            End If
        End While
        reader.Close()

        ' Cari ID terkecil yang belum terpakai mulai dari 1
        Dim newNum As Integer = 1
        While usedID.Contains(newNum)
            newNum += 1
        End While

        Dim newID As String = "G" & Format(newNum, "000")
        txtID.Text = newID
    End Sub

    Sub ambilNama()
        CMD = New MySqlCommand("SELECT * FROM akun WHERE idakun = '" & IDAKUNLOGIN & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txtNama.AutoSize = True
            txtNama.TextAlign = ContentAlignment.MiddleLeft
            txtNama.Text = RD.Item("username").ToString()
        End If
        RD.Close()
    End Sub
    Sub atur_grid()
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Judul"
        DataGridView1.Columns(2).HeaderText = "Rating"
        DataGridView1.Columns(3).HeaderText = "Genre"
        DataGridView1.Columns(4).HeaderText = "Platform"
        DataGridView1.Columns(5).HeaderText = "Rilis"
        DataGridView1.Columns(6).HeaderText = "Developer"
        DataGridView1.Columns(7).HeaderText = "Deskripsi"
        DataGridView1.Columns(8).HeaderText = "Uploaded By"
    End Sub

    Function GetRating() As Integer
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                Return CInt(ctrl.Text)
            End If
        Next
        Return 0
    End Function

    Sub showGenre()
        CMD = New MySqlCommand("SELECT * FROM tbgenre", CONN)
        DA = New MySqlDataAdapter(CMD)
        Dim dt As New DataTable
        DA.Fill(dt)

        txtGenre.DataSource = dt
        txtGenre.DisplayMember = "genre"
        txtGenre.ValueMember = "id_genre"
    End Sub

    Sub showPlatform()
        CMD = New MySqlCommand("SELECT * FROM tbplatform", CONN)
        DA = New MySqlDataAdapter(CMD)
        Dim dt As New DataTable
        DA.Fill(dt)

        txtPlatform.DataSource = dt
        txtPlatform.DisplayMember = "platform"
        txtPlatform.ValueMember = "id_platform"
    End Sub

    Sub insertdata()
        koneksi()
        Dim rating As Integer = GetRating()
        Dim tglRilis As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        CMD = New MySqlCommand("INSERT INTO tbgame (idgame, judul, id_genre, id_platform, rating, rilis, developer, deskripsi, idakun) VALUES (@idgame, @judul, @id_genre, @id_platform, @rating, @rilis, @developer, @deskripsi, @idakun)", CONN)
        CMD.Parameters.AddWithValue("@idgame", txtID.Text)
        CMD.Parameters.AddWithValue("@judul", txtJudul.Text)
        CMD.Parameters.AddWithValue("@id_genre", txtGenre.SelectedValue)
        CMD.Parameters.AddWithValue("@id_platform", txtPlatform.SelectedValue)
        CMD.Parameters.AddWithValue("@rating", rating)
        CMD.Parameters.AddWithValue("@rilis", tglRilis)
        CMD.Parameters.AddWithValue("@developer", txtDeveloper.Text)
        CMD.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
        CMD.Parameters.AddWithValue("@idakun", IDAKUNLOGIN)
        CMD.ExecuteNonQuery()
    End Sub

    Sub updatedata()
        koneksi()
        Dim rating As Integer = GetRating()
        Dim tglRilis As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        CMD = New MySqlCommand("UPDATE tbgame SET judul = @judul, id_genre = @id_genre, id_platform = @id_platform, rating = @rating, rilis = @rilis, developer = @developer, deskripsi = @deskripsi WHERE idgame = @idgame AND idakun = @idakun", CONN)
        CMD.Parameters.AddWithValue("@judul", txtJudul.Text)
        CMD.Parameters.AddWithValue("@id_genre", txtGenre.SelectedValue)
        CMD.Parameters.AddWithValue("@id_platform", txtPlatform.SelectedValue)
        CMD.Parameters.AddWithValue("@rating", rating)
        CMD.Parameters.AddWithValue("@rilis", tglRilis)
        CMD.Parameters.AddWithValue("@developer", txtDeveloper.Text)
        CMD.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text)
        CMD.Parameters.AddWithValue("@idgame", txtID.Text)
        CMD.Parameters.AddWithValue("@idakun", IDAKUNLOGIN)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim rating As Integer = GetRating()
        If txtJudul.Text = "" Or txtGenre.SelectedIndex = -1 Or txtPlatform.SelectedIndex = -1 Or rating = 0 Or txtDeveloper.Text = "" Or txtDeskripsi.Text = "" Then
            MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf txtID.Text.Length < 3 Then
            MessageBox.Show("ID Game minimal 3 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            insertdata()
            MessageBox.Show("Data berhasil disimpan!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("ID Game sudah ada!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
        Memuat()
        tampilGame()
        generateID()
        txtJudul.Focus()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim rating As Integer = GetRating()
        If txtID.Text = "" Or txtJudul.Text = "" Or txtGenre.SelectedIndex = -1 Or txtPlatform.SelectedIndex = -1 Or rating = 0 Or txtDeveloper.Text = "" Or txtDeskripsi.Text = "" Then
            MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            updatedata()
            Dim result As Integer = CMD.ExecuteNonQuery()
            Dim isOwner As Boolean = False
            CMD = New MySqlCommand("SELECT idakun FROM tbgame WHERE idgame = @idgame", CONN)
            CMD.Parameters.AddWithValue("@idgame", txtID.Text)
            Dim ownerId As Object = CMD.ExecuteScalar()
            If ownerId IsNot Nothing AndAlso ownerId.ToString() = IDAKUNLOGIN.ToString() Then
                isOwner = True
            End If
            If result > 0 And isOwner Then
                MessageBox.Show("Data berhasil diubah!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Not isOwner Then
                    MessageBox.Show("Anda tidak memiliki izin untuk mengubah data ini karena bukan pengunggah.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Data tidak ditemukan atau tidak ada perubahan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As MySqlException
            MessageBox.Show("Terjadi error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Memuat()
        tampilGame()
        generateID()
        txtJudul.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim isOwner As Boolean = False
        CMD = New MySqlCommand("SELECT idakun FROM tbgame WHERE idgame = @idgame", CONN)
        CMD.Parameters.AddWithValue("@idgame", txtID.Text)
        Dim ownerId As Object = CMD.ExecuteScalar()
        If ownerId IsNot Nothing AndAlso ownerId.ToString() = IDAKUNLOGIN.ToString() Then
            isOwner = True
        End If

        If Not isOwner Then
            MessageBox.Show("Anda tidak memiliki izin untuk menghapus data ini karena bukan pengunggah.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            CMD = New MySqlCommand("DELETE FROM tbgame WHERE idgame = @idgame", CONN)
            CMD.Parameters.AddWithValue("@idgame", txtID.Text)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Memuat()
        tampilGame()
        generateID()
        txtJudul.Focus()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Memuat()
        tampilGame()
        generateID()
        txtJudul.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()
        Dim query As String = "
            SELECT 
                g.idgame, 
                g.judul,
                g.rating, 
                ge.genre, 
                pl.platform, 
                g.rilis, 
                g.developer, 
                g.deskripsi,
                a.username AS `uploaded by`
            FROM tbgame g
            JOIN tbgenre ge ON g.id_genre = ge.id_genre
            JOIN tbplatform pl ON g.id_platform = pl.id_platform
            JOIN akun a ON g.idakun = a.idakun
            WHERE 
                g.judul LIKE @searchText OR
                g.developer LIKE @searchText OR
                ge.genre LIKE @searchText OR
                pl.platform LIKE @searchText
        "
        CMD = New MySqlCommand(query, CONN)
        CMD.Parameters.AddWithValue("@idakun", IDAKUNLOGIN)
        CMD.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
        DA = New MySqlDataAdapter(CMD)
        DS = New DataSet
        DA.Fill(DS, "game")
        If DS.Tables("game").Rows.Count = 0 Then
            MessageBox.Show("Pencarian tidak relevan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Memuat()
            tampilGame()
            txtSearch.Clear()
        Else
            DataGridView1.DataSource = DS.Tables("game")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Error handling for empty or invalid cell click
        If DataGridView1.CurrentRow Is Nothing OrElse DataGridView1.CurrentRow.Index < 0 Then
            Return
        End If
        Dim i As Integer = DataGridView1.CurrentRow.Index

        ' Prevent error if row is new row or index out of range
        If i >= DataGridView1.Rows.Count OrElse DataGridView1.Rows(i).IsNewRow Then
            Return
        End If

        Try
            txtID.Text = If(DataGridView1.Item(0, i).Value IsNot Nothing, DataGridView1.Item(0, i).Value.ToString(), "")
            txtJudul.Text = If(DataGridView1.Item(1, i).Value IsNot Nothing, DataGridView1.Item(1, i).Value.ToString(), "")

            Dim ratingValue As Integer = 0
            If DataGridView1.Item(2, i).Value IsNot Nothing AndAlso Integer.TryParse(DataGridView1.Item(2, i).Value.ToString(), ratingValue) Then
                For Each ctrl As Control In Panel1.Controls
                    If TypeOf ctrl Is RadioButton AndAlso ctrl.Text = ratingValue.ToString() Then
                        CType(ctrl, RadioButton).Checked = True
                    End If
                Next
            End If

            Dim namaGenre As String = If(DataGridView1.Item(3, i).Value IsNot Nothing, DataGridView1.Item(3, i).Value.ToString(), "")
            Dim namaPlatform As String = If(DataGridView1.Item(4, i).Value IsNot Nothing, DataGridView1.Item(4, i).Value.ToString(), "")
            txtGenre.SelectedIndex = txtGenre.FindStringExact(namaGenre)
            txtPlatform.SelectedIndex = txtPlatform.FindStringExact(namaPlatform)

            Dim tgl As Date
            If DataGridView1.Item(5, i).Value IsNot Nothing AndAlso Date.TryParse(DataGridView1.Item(5, i).Value.ToString(), tgl) Then
                DateTimePicker1.Value = tgl
            Else
                DateTimePicker1.Value = DateTime.Now
            End If

            txtDeveloper.Text = If(DataGridView1.Item(6, i).Value IsNot Nothing, DataGridView1.Item(6, i).Value.ToString(), "")
            txtDeskripsi.Text = If(DataGridView1.Item(7, i).Value IsNot Nothing, DataGridView1.Item(7, i).Value.ToString(), "")
        Catch ex As Exception
            MessageBox.Show("Data tidak valid atau baris kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        IDAKUNLOGIN = Nothing
        LandingPage.Show()
        Hide()
    End Sub

    Private Sub MenuGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Memuat()
        tampilGame()
        ambilNama()
        atur_grid()
        generateID()
        showGenre()
        showPlatform()
        txtJudul.Focus()
        txtID.Enabled = False

        txtGenre.SelectedIndex = -1
        txtGenre.Text = ""
        txtPlatform.SelectedIndex = -1
        txtPlatform.Text = ""

        txtGenre.DropDownStyle = ComboBoxStyle.DropDownList
        txtPlatform.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class