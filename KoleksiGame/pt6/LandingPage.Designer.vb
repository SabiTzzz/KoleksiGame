<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LandingPage
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
        components = New ComponentModel.Container()
        btnStart = New Button()
        title = New Label()
        loadingPic = New PictureBox()
        loadingTimer = New Timer(components)
        CType(loadingPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = Color.Transparent
        btnStart.BackgroundImage = My.Resources.Resources.start
        btnStart.BackgroundImageLayout = ImageLayout.Zoom
        btnStart.FlatAppearance.BorderSize = 0
        btnStart.FlatStyle = FlatStyle.Flat
        btnStart.Font = New Font("Press Start 2P", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.ForeColor = Color.FromArgb(CByte(238), CByte(165), CByte(78))
        btnStart.Location = New Point(242, 333)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(280, 74)
        btnStart.TabIndex = 0
        btnStart.UseCompatibleTextRendering = True
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.BackColor = Color.Transparent
        title.Font = New Font("Karmatic Arcade", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.ForeColor = Color.FromArgb(CByte(221), CByte(64), CByte(17))
        title.Location = New Point(180, 170)
        title.Name = "title"
        title.Size = New Size(436, 98)
        title.TabIndex = 1
        title.Text = "MANAJEMEN" & vbCrLf & "KOLEKSI GAME" & vbCrLf
        title.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' loadingPic
        ' 
        loadingPic.BackColor = Color.Transparent
        loadingPic.BackgroundImageLayout = ImageLayout.Zoom
        loadingPic.ErrorImage = Nothing
        loadingPic.Image = My.Resources.Resources.loading
        loadingPic.Location = New Point(333, 318)
        loadingPic.Name = "loadingPic"
        loadingPic.Size = New Size(100, 100)
        loadingPic.SizeMode = PictureBoxSizeMode.Zoom
        loadingPic.TabIndex = 2
        loadingPic.TabStop = False
        loadingPic.Visible = False
        ' 
        ' loadingTimer
        ' 
        loadingTimer.Interval = 3000
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.loadingpage
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(782, 553)
        Controls.Add(loadingPic)
        Controls.Add(title)
        Controls.Add(btnStart)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        Name = "LandingPage"
        StartPosition = FormStartPosition.CenterScreen
        CType(loadingPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents title As Label
    Friend WithEvents loadingPic As PictureBox
    Friend WithEvents loadingTimer As Timer

End Class
