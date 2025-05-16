<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGame))
        Label1 = New Label()
        txtID = New TextBox()
        txtJudul = New TextBox()
        txtDeveloper = New TextBox()
        btnTambah = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnExit = New Button()
        txtDeskripsi = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        rate1 = New RadioButton()
        rate2 = New RadioButton()
        rate3 = New RadioButton()
        rate4 = New RadioButton()
        rate5 = New RadioButton()
        btnSearch = New Button()
        DataGridView1 = New DataGridView()
        txtPlatform = New ComboBox()
        txtGenre = New ComboBox()
        title = New Label()
        Label7 = New Label()
        txtSearch = New TextBox()
        txtNama = New Label()
        Panel1 = New Panel()
        Label11 = New Label()
        Label12 = New Label()
        btnPreview = New Button()
        btnPrint = New Button()
        btnRefresh = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("ArcadeClassic", 13.8F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(604, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 23)
        Label1.TabIndex = 0
        Label1.Text = "Id Game"
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("ArcadeClassic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(752, 204)
        txtID.Name = "txtID"
        txtID.Size = New Size(89, 31)
        txtID.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Font = New Font("Pixelify Sans", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(750, 252)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(461, 35)
        txtJudul.TabIndex = 1
        ' 
        ' txtDeveloper
        ' 
        txtDeveloper.Font = New Font("Pixelify Sans", 13.7999992F)
        txtDeveloper.Location = New Point(750, 304)
        txtDeveloper.Name = "txtDeveloper"
        txtDeveloper.Size = New Size(461, 35)
        txtDeveloper.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Transparent
        btnTambah.BackgroundImage = My.Resources.Resources.tambah2
        btnTambah.BackgroundImageLayout = ImageLayout.Stretch
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Location = New Point(607, 575)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(181, 53)
        btnTambah.TabIndex = 8
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Transparent
        btnUbah.BackgroundImage = My.Resources.Resources.ubah2
        btnUbah.BackgroundImageLayout = ImageLayout.Stretch
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Location = New Point(819, 575)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(181, 53)
        btnUbah.TabIndex = 9
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Transparent
        btnHapus.BackgroundImage = CType(resources.GetObject("btnHapus.BackgroundImage"), Image)
        btnHapus.BackgroundImageLayout = ImageLayout.Stretch
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Location = New Point(1030, 575)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(181, 53)
        btnHapus.TabIndex = 10
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.BackgroundImage = My.Resources.Resources.exit2
        btnExit.BackgroundImageLayout = ImageLayout.Stretch
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Location = New Point(12, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(149, 53)
        btnExit.TabIndex = 5
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Font = New Font("Pixelify Sans", 13.7999992F)
        txtDeskripsi.Location = New Point(750, 517)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(461, 35)
        txtDeskripsi.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("ArcadeClassic", 13.8F)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(607, 261)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 23)
        Label9.TabIndex = 0
        Label9.Text = "Judul"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("ArcadeClassic", 13.8F)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(607, 312)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 23)
        Label10.TabIndex = 0
        Label10.Text = "Developer"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("ArcadeClassic", 13.8F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(884, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 23)
        Label2.TabIndex = 0
        Label2.Text = "Tanggal Rilis"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("ArcadeClassic", 13.8F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(607, 424)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 23)
        Label4.TabIndex = 0
        Label4.Text = "Genre"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("ArcadeClassic", 13.8F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(607, 524)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 23)
        Label5.TabIndex = 0
        Label5.Text = "Deskripsi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("ArcadeClassic", 13.8F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(607, 366)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 23)
        Label6.TabIndex = 0
        Label6.Text = "Platform"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("ArcadeClassic", 13.8F)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(1072, 203)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(139, 31)
        DateTimePicker1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("ArcadeClassic", 13.8F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(607, 475)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 23)
        Label3.TabIndex = 0
        Label3.Text = "Rating"
        ' 
        ' rate1
        ' 
        rate1.AutoSize = True
        rate1.Font = New Font("ArcadeClassic", 12F)
        rate1.ForeColor = Color.White
        rate1.Location = New Point(2, 4)
        rate1.Name = "rate1"
        rate1.Size = New Size(41, 24)
        rate1.TabIndex = 8
        rate1.TabStop = True
        rate1.Text = "1"
        rate1.UseVisualStyleBackColor = True
        ' 
        ' rate2
        ' 
        rate2.AutoSize = True
        rate2.Font = New Font("ArcadeClassic", 12F)
        rate2.ForeColor = Color.White
        rate2.Location = New Point(46, 4)
        rate2.Name = "rate2"
        rate2.Size = New Size(41, 24)
        rate2.TabIndex = 9
        rate2.TabStop = True
        rate2.Text = "2"
        rate2.UseVisualStyleBackColor = True
        ' 
        ' rate3
        ' 
        rate3.AutoSize = True
        rate3.Font = New Font("ArcadeClassic", 12F)
        rate3.ForeColor = Color.White
        rate3.Location = New Point(90, 4)
        rate3.Name = "rate3"
        rate3.Size = New Size(41, 24)
        rate3.TabIndex = 9
        rate3.TabStop = True
        rate3.Text = "3"
        rate3.UseVisualStyleBackColor = True
        ' 
        ' rate4
        ' 
        rate4.AutoSize = True
        rate4.Font = New Font("ArcadeClassic", 12F)
        rate4.ForeColor = Color.White
        rate4.Location = New Point(134, 4)
        rate4.Name = "rate4"
        rate4.Size = New Size(41, 24)
        rate4.TabIndex = 9
        rate4.TabStop = True
        rate4.Text = "4"
        rate4.UseVisualStyleBackColor = True
        ' 
        ' rate5
        ' 
        rate5.AutoSize = True
        rate5.Font = New Font("ArcadeClassic", 12F)
        rate5.ForeColor = Color.White
        rate5.Location = New Point(178, 4)
        rate5.Name = "rate5"
        rate5.Size = New Size(41, 24)
        rate5.TabIndex = 9
        rate5.TabStop = True
        rate5.Text = "5"
        rate5.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Transparent
        btnSearch.BackgroundImage = My.Resources.Resources.cari2
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(398, 135)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(149, 55)
        btnSearch.TabIndex = 12
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(57, 205)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(490, 347)
        DataGridView1.TabIndex = 16
        ' 
        ' txtPlatform
        ' 
        txtPlatform.Font = New Font("Pixelify Sans", 13.7999992F)
        txtPlatform.FormattingEnabled = True
        txtPlatform.Location = New Point(750, 357)
        txtPlatform.Name = "txtPlatform"
        txtPlatform.Size = New Size(461, 36)
        txtPlatform.TabIndex = 4
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Pixelify Sans", 13.7999992F)
        txtGenre.FormattingEnabled = True
        txtGenre.Location = New Point(750, 413)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(461, 36)
        txtGenre.TabIndex = 5
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.BackColor = Color.Transparent
        title.Font = New Font("Karmatic Arcade", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.ForeColor = Color.FromArgb(CByte(221), CByte(64), CByte(17))
        title.Location = New Point(280, 36)
        title.Name = "title"
        title.Size = New Size(746, 53)
        title.TabIndex = 13
        title.Text = "MENU MANAJEMEN GAME"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(604, 145)
        Label7.Name = "Label7"
        Label7.Size = New Size(274, 34)
        Label7.TabIndex = 0
        Label7.Text = "Selamat Datang,"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Pixelify Sans", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(57, 144)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "  Cari game..."
        txtSearch.Size = New Size(335, 35)
        txtSearch.TabIndex = 13
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Transparent
        txtNama.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(840, 144)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(129, 34)
        txtNama.TabIndex = 0
        txtNama.Text = "User"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(rate5)
        Panel1.Controls.Add(rate4)
        Panel1.Controls.Add(rate1)
        Panel1.Controls.Add(rate3)
        Panel1.Controls.Add(rate2)
        Panel1.Location = New Point(750, 469)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(229, 33)
        Panel1.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(57, 580)
        Label11.Name = "Label11"
        Label11.Size = New Size(148, 34)
        Label11.TabIndex = 0
        Label11.Text = "Preview"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(437, 580)
        Label12.Name = "Label12"
        Label12.Size = New Size(110, 34)
        Label12.TabIndex = 0
        Label12.Text = "Print"
        ' 
        ' btnPreview
        ' 
        btnPreview.BackColor = Color.Transparent
        btnPreview.BackgroundImage = My.Resources.Resources.preview
        btnPreview.BackgroundImageLayout = ImageLayout.Stretch
        btnPreview.FlatAppearance.BorderSize = 0
        btnPreview.FlatStyle = FlatStyle.Flat
        btnPreview.Location = New Point(57, 575)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(235, 53)
        btnPreview.TabIndex = 14
        btnPreview.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.Transparent
        btnPrint.BackgroundImage = My.Resources.Resources.print
        btnPrint.BackgroundImageLayout = ImageLayout.Stretch
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Location = New Point(312, 575)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(235, 53)
        btnPrint.TabIndex = 15
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Transparent
        btnRefresh.BackgroundImage = My.Resources.Resources.refresh
        btnRefresh.BackgroundImageLayout = ImageLayout.Stretch
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Location = New Point(1161, 135)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(50, 50)
        btnRefresh.TabIndex = 11
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' MenuGame
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel1)
        Controls.Add(title)
        Controls.Add(txtGenre)
        Controls.Add(txtPlatform)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtDeskripsi)
        Controls.Add(btnSearch)
        Controls.Add(btnExit)
        Controls.Add(btnRefresh)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnPrint)
        Controls.Add(btnPreview)
        Controls.Add(btnTambah)
        Controls.Add(txtDeveloper)
        Controls.Add(txtSearch)
        Controls.Add(txtJudul)
        Controls.Add(txtID)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(txtNama)
        Controls.Add(Label7)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "MenuGame"
        StartPosition = FormStartPosition.CenterScreen
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtDeveloper As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents rate1 As RadioButton
    Friend WithEvents rate2 As RadioButton
    Friend WithEvents rate3 As RadioButton
    Friend WithEvents rate4 As RadioButton
    Friend WithEvents rate5 As RadioButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtPlatform As ComboBox
    Friend WithEvents txtGenre As ComboBox
    Friend WithEvents title As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtNama As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument

End Class
