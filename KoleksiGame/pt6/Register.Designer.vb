<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        LinkLabel1 = New LinkLabel()
        Label3 = New Label()
        txtCPassword = New TextBox()
        title = New Label()
        eyeclosed1 = New Button()
        eye1 = New Button()
        eye2 = New Button()
        eyeclosed2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(79, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 34)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(79, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 34)
        Label2.TabIndex = 0
        Label2.Text = "PASSWORD"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Pixelify Sans", 13.7999992F)
        txtUsername.Location = New Point(79, 170)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(634, 35)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Pixelify Sans", 13.7999992F)
        txtPassword.Location = New Point(79, 255)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "o"c
        txtPassword.Size = New Size(634, 35)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.BackgroundImage = My.Resources.Resources.register2
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(229, 402)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(299, 65)
        btnLogin.TabIndex = 4
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Pixelify Sans", 13.7999992F)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(146), CByte(73), CByte(55))
        LinkLabel1.Location = New Point(340, 483)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(73, 28)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "LOGIN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(79, 309)
        Label3.Name = "Label3"
        Label3.Size = New Size(320, 34)
        Label3.TabIndex = 0
        Label3.Text = "CONFIRM PASSWORD"
        ' 
        ' txtCPassword
        ' 
        txtCPassword.Font = New Font("Pixelify Sans", 13.7999992F)
        txtCPassword.Location = New Point(79, 346)
        txtCPassword.Name = "txtCPassword"
        txtCPassword.PasswordChar = "o"c
        txtCPassword.Size = New Size(634, 35)
        txtCPassword.TabIndex = 3
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.BackColor = Color.Transparent
        title.Font = New Font("Karmatic Arcade", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.ForeColor = Color.FromArgb(CByte(221), CByte(64), CByte(17))
        title.Location = New Point(240, 49)
        title.Name = "title"
        title.Size = New Size(307, 49)
        title.TabIndex = 5
        title.Text = "REGISTER"
        ' 
        ' eyeclosed1
        ' 
        eyeclosed1.BackColor = Color.White
        eyeclosed1.BackgroundImage = My.Resources.Resources.eye_closed2
        eyeclosed1.BackgroundImageLayout = ImageLayout.Zoom
        eyeclosed1.FlatStyle = FlatStyle.Flat
        eyeclosed1.ForeColor = Color.Transparent
        eyeclosed1.Location = New Point(662, 255)
        eyeclosed1.Name = "eyeclosed1"
        eyeclosed1.Size = New Size(51, 35)
        eyeclosed1.TabIndex = 6
        eyeclosed1.UseVisualStyleBackColor = False
        ' 
        ' eye1
        ' 
        eye1.BackColor = Color.White
        eye1.BackgroundImage = My.Resources.Resources.eye2
        eye1.BackgroundImageLayout = ImageLayout.Zoom
        eye1.FlatStyle = FlatStyle.Flat
        eye1.ForeColor = Color.Transparent
        eye1.Location = New Point(662, 255)
        eye1.Name = "eye1"
        eye1.Size = New Size(51, 35)
        eye1.TabIndex = 7
        eye1.UseVisualStyleBackColor = False
        ' 
        ' eye2
        ' 
        eye2.BackColor = Color.White
        eye2.BackgroundImage = My.Resources.Resources.eye2
        eye2.BackgroundImageLayout = ImageLayout.Zoom
        eye2.FlatStyle = FlatStyle.Flat
        eye2.ForeColor = Color.Transparent
        eye2.Location = New Point(662, 346)
        eye2.Name = "eye2"
        eye2.Size = New Size(51, 35)
        eye2.TabIndex = 7
        eye2.UseVisualStyleBackColor = False
        ' 
        ' eyeclosed2
        ' 
        eyeclosed2.BackColor = Color.White
        eyeclosed2.BackgroundImage = My.Resources.Resources.eye_closed2
        eyeclosed2.BackgroundImageLayout = ImageLayout.Zoom
        eyeclosed2.FlatStyle = FlatStyle.Flat
        eyeclosed2.ForeColor = Color.Transparent
        eyeclosed2.Location = New Point(662, 346)
        eyeclosed2.Name = "eyeclosed2"
        eyeclosed2.Size = New Size(51, 35)
        eyeclosed2.TabIndex = 6
        eyeclosed2.UseVisualStyleBackColor = False
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(782, 553)
        Controls.Add(eye2)
        Controls.Add(eye1)
        Controls.Add(eyeclosed2)
        Controls.Add(eyeclosed1)
        Controls.Add(title)
        Controls.Add(LinkLabel1)
        Controls.Add(txtCPassword)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(146), CByte(73), CByte(55))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCPassword As TextBox
    Friend WithEvents title As Label
    Friend WithEvents eyeclosed1 As Button
    Friend WithEvents eye1 As Button
    Friend WithEvents eye2 As Button
    Friend WithEvents eyeclosed2 As Button
End Class
