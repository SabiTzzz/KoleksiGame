<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        LinkLabel1 = New LinkLabel()
        title = New Label()
        eye = New Button()
        eyeclosed = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("ArcadeClassic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(79, 150)
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
        Label2.Location = New Point(79, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 34)
        Label2.TabIndex = 0
        Label2.Text = "PASSWORD"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Pixelify Sans", 13.7999992F)
        txtUsername.Location = New Point(79, 196)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(634, 35)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Pixelify Sans", 13.7999992F)
        txtPassword.Location = New Point(79, 308)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "o"c
        txtPassword.Size = New Size(634, 35)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Transparent
        btnLogin.BackgroundImage = My.Resources.Resources.login2
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(229, 402)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(299, 65)
        btnLogin.TabIndex = 3
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Pixelify Sans", 13.7999992F)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(146), CByte(73), CByte(55))
        LinkLabel1.Location = New Point(325, 483)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(111, 28)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "REGISTER"
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.BackColor = Color.Transparent
        title.Font = New Font("Karmatic Arcade", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        title.ForeColor = Color.FromArgb(CByte(221), CByte(64), CByte(17))
        title.Location = New Point(288, 48)
        title.Name = "title"
        title.Size = New Size(190, 49)
        title.TabIndex = 0
        title.Text = "LOGIN"
        ' 
        ' eye
        ' 
        eye.BackColor = Color.White
        eye.BackgroundImage = My.Resources.Resources.eye2
        eye.BackgroundImageLayout = ImageLayout.Zoom
        eye.FlatStyle = FlatStyle.Flat
        eye.ForeColor = Color.Transparent
        eye.Location = New Point(662, 308)
        eye.Name = "eye"
        eye.Size = New Size(51, 35)
        eye.TabIndex = 5
        eye.UseVisualStyleBackColor = False
        ' 
        ' eyeclosed
        ' 
        eyeclosed.BackColor = Color.White
        eyeclosed.BackgroundImage = My.Resources.Resources.eye_closed2
        eyeclosed.BackgroundImageLayout = ImageLayout.Zoom
        eyeclosed.FlatStyle = FlatStyle.Flat
        eyeclosed.ForeColor = Color.Transparent
        eyeclosed.Location = New Point(662, 308)
        eyeclosed.Name = "eyeclosed"
        eyeclosed.Size = New Size(51, 35)
        eyeclosed.TabIndex = 5
        eyeclosed.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(782, 553)
        Controls.Add(eyeclosed)
        Controls.Add(eye)
        Controls.Add(LinkLabel1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(title)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(146), CByte(73), CByte(55))
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Login"
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
    Friend WithEvents title As Label
    Friend WithEvents eye As Button
    Friend WithEvents eyeclosed As Button
End Class
