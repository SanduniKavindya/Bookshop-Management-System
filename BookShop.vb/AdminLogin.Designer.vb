<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminLogin))
        Me.picLogInAdmin = New System.Windows.Forms.PictureBox()
        Me.lblAdminLogin = New System.Windows.Forms.Label()
        Me.lblCancel = New System.Windows.Forms.Label()
        Me.btnLogin2 = New System.Windows.Forms.Button()
        Me.picPassword2 = New System.Windows.Forms.PictureBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.picBook2 = New System.Windows.Forms.PictureBox()
        Me.lblCloseAdmin = New System.Windows.Forms.Label()
        CType(Me.picLogInAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPassword2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogInAdmin
        '
        Me.picLogInAdmin.Image = CType(resources.GetObject("picLogInAdmin.Image"), System.Drawing.Image)
        Me.picLogInAdmin.Location = New System.Drawing.Point(0, -1)
        Me.picLogInAdmin.Name = "picLogInAdmin"
        Me.picLogInAdmin.Size = New System.Drawing.Size(651, 559)
        Me.picLogInAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogInAdmin.TabIndex = 2
        Me.picLogInAdmin.TabStop = False
        '
        'lblAdminLogin
        '
        Me.lblAdminLogin.AutoSize = True
        Me.lblAdminLogin.Font = New System.Drawing.Font("Lucida Fax", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminLogin.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblAdminLogin.Location = New System.Drawing.Point(853, 25)
        Me.lblAdminLogin.Name = "lblAdminLogin"
        Me.lblAdminLogin.Size = New System.Drawing.Size(242, 38)
        Me.lblAdminLogin.TabIndex = 4
        Me.lblAdminLogin.Text = "Admin Login"
        '
        'lblCancel
        '
        Me.lblCancel.AutoSize = True
        Me.lblCancel.Font = New System.Drawing.Font("Arial", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCancel.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCancel.Location = New System.Drawing.Point(919, 445)
        Me.lblCancel.Name = "lblCancel"
        Me.lblCancel.Size = New System.Drawing.Size(108, 33)
        Me.lblCancel.TabIndex = 20
        Me.lblCancel.Text = "Cancel"
        '
        'btnLogin2
        '
        Me.btnLogin2.BackColor = System.Drawing.Color.DarkBlue
        Me.btnLogin2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin2.ForeColor = System.Drawing.Color.White
        Me.btnLogin2.Location = New System.Drawing.Point(868, 351)
        Me.btnLogin2.Name = "btnLogin2"
        Me.btnLogin2.Size = New System.Drawing.Size(212, 50)
        Me.btnLogin2.TabIndex = 19
        Me.btnLogin2.Text = "Login"
        Me.btnLogin2.UseVisualStyleBackColor = False
        '
        'picPassword2
        '
        Me.picPassword2.Image = CType(resources.GetObject("picPassword2.Image"), System.Drawing.Image)
        Me.picPassword2.Location = New System.Drawing.Point(1167, 246)
        Me.picPassword2.Name = "picPassword2"
        Me.picPassword2.Size = New System.Drawing.Size(67, 56)
        Me.picPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPassword2.TabIndex = 18
        Me.picPassword2.TabStop = False
        '
        'txtPassword2
        '
        Me.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword2.Location = New System.Drawing.Point(868, 280)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword2.Size = New System.Drawing.Size(264, 22)
        Me.txtPassword2.TabIndex = 17
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPassword2.Location = New System.Drawing.Point(676, 271)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(147, 33)
        Me.lblPassword2.TabIndex = 16
        Me.lblPassword2.Text = "Password"
        '
        'picBook2
        '
        Me.picBook2.Image = CType(resources.GetObject("picBook2.Image"), System.Drawing.Image)
        Me.picBook2.Location = New System.Drawing.Point(914, 110)
        Me.picBook2.Name = "picBook2"
        Me.picBook2.Size = New System.Drawing.Size(128, 101)
        Me.picBook2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook2.TabIndex = 15
        Me.picBook2.TabStop = False
        '
        'lblCloseAdmin
        '
        Me.lblCloseAdmin.AutoSize = True
        Me.lblCloseAdmin.BackColor = System.Drawing.SystemColors.Control
        Me.lblCloseAdmin.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseAdmin.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCloseAdmin.Location = New System.Drawing.Point(1273, -1)
        Me.lblCloseAdmin.Name = "lblCloseAdmin"
        Me.lblCloseAdmin.Size = New System.Drawing.Size(35, 38)
        Me.lblCloseAdmin.TabIndex = 21
        Me.lblCloseAdmin.Text = "x"
        '
        'frmAdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 561)
        Me.Controls.Add(Me.lblCloseAdmin)
        Me.Controls.Add(Me.lblCancel)
        Me.Controls.Add(Me.btnLogin2)
        Me.Controls.Add(Me.picPassword2)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.lblPassword2)
        Me.Controls.Add(Me.picBook2)
        Me.Controls.Add(Me.lblAdminLogin)
        Me.Controls.Add(Me.picLogInAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogin"
        CType(Me.picLogInAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPassword2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogInAdmin As PictureBox
    Friend WithEvents lblAdminLogin As Label
    Friend WithEvents lblCancel As Label
    Friend WithEvents btnLogin2 As Button
    Friend WithEvents picPassword2 As PictureBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents lblPassword2 As Label
    Friend WithEvents picBook2 As PictureBox
    Friend WithEvents lblCloseAdmin As Label
End Class
