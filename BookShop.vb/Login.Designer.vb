<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.picLogImage = New System.Windows.Forms.PictureBox()
        Me.lblBookShop2 = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.picPassword = New System.Windows.Forms.PictureBox()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        CType(Me.picLogImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogImage
        '
        Me.picLogImage.Image = CType(resources.GetObject("picLogImage.Image"), System.Drawing.Image)
        Me.picLogImage.Location = New System.Drawing.Point(-1, 0)
        Me.picLogImage.Name = "picLogImage"
        Me.picLogImage.Size = New System.Drawing.Size(651, 559)
        Me.picLogImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogImage.TabIndex = 1
        Me.picLogImage.TabStop = False
        '
        'lblBookShop2
        '
        Me.lblBookShop2.AutoSize = True
        Me.lblBookShop2.Font = New System.Drawing.Font("Lucida Fax", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookShop2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookShop2.Location = New System.Drawing.Point(785, 18)
        Me.lblBookShop2.Name = "lblBookShop2"
        Me.lblBookShop2.Size = New System.Drawing.Size(355, 38)
        Me.lblBookShop2.TabIndex = 3
        Me.lblBookShop2.Text = "BookShop Software"
        '
        'picBook
        '
        Me.picBook.Image = CType(resources.GetObject("picBook.Image"), System.Drawing.Image)
        Me.picBook.Location = New System.Drawing.Point(904, 75)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(128, 101)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 9
        Me.picBook.TabStop = False
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Arial", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblAdmin.Location = New System.Drawing.Point(937, 491)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(102, 33)
        Me.lblAdmin.TabIndex = 20
        Me.lblAdmin.Text = "Admin"
        '
        'picPassword
        '
        Me.picPassword.Image = CType(resources.GetObject("picPassword.Image"), System.Drawing.Image)
        Me.picPassword.Location = New System.Drawing.Point(1171, 318)
        Me.picPassword.Name = "picPassword"
        Me.picPassword.Size = New System.Drawing.Size(67, 56)
        Me.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPassword.TabIndex = 19
        Me.picPassword.TabStop = False
        '
        'picUser
        '
        Me.picUser.Image = CType(resources.GetObject("picUser.Image"), System.Drawing.Image)
        Me.picUser.Location = New System.Drawing.Point(1171, 221)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(67, 59)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 18
        Me.picUser.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(876, 422)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(212, 50)
        Me.btnLogin.TabIndex = 17
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(876, 352)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(264, 22)
        Me.txtPassword.TabIndex = 16
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Location = New System.Drawing.Point(876, 258)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(264, 22)
        Me.txtUsername.TabIndex = 15
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPassword.Location = New System.Drawing.Point(683, 341)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(147, 33)
        Me.lblPassword.TabIndex = 14
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblUsername.Location = New System.Drawing.Point(678, 247)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(152, 33)
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "Username"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.SystemColors.Control
        Me.lblClose.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblClose.Location = New System.Drawing.Point(1270, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(35, 38)
        Me.lblClose.TabIndex = 21
        Me.lblClose.Text = "x"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 561)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.picPassword)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.picBook)
        Me.Controls.Add(Me.lblBookShop2)
        Me.Controls.Add(Me.picLogImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.picLogImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogImage As PictureBox
    Friend WithEvents lblBookShop2 As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents lblAdmin As Label
    Friend WithEvents picPassword As PictureBox
    Friend WithEvents picUser As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblClose As Label
End Class
