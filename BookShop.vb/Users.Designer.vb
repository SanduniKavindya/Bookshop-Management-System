<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsers))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picBooks = New System.Windows.Forms.PictureBox()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.lblUserList = New System.Windows.Forms.Label()
        Me.lblCloseUsers = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtUPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtUName = New System.Windows.Forms.TextBox()
        Me.lblBookShop2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.picDashboard = New System.Windows.Forms.PictureBox()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.picUsers = New System.Windows.Forms.PictureBox()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lblBookShopicon = New System.Windows.Forms.Label()
        Me.picShop = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.picBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.picDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.picUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.picBooks)
        Me.Panel3.Controls.Add(Me.lblBooks)
        Me.Panel3.Location = New System.Drawing.Point(13, 193)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 59)
        Me.Panel3.TabIndex = 37
        '
        'picBooks
        '
        Me.picBooks.Image = CType(resources.GetObject("picBooks.Image"), System.Drawing.Image)
        Me.picBooks.Location = New System.Drawing.Point(10, -3)
        Me.picBooks.Name = "picBooks"
        Me.picBooks.Size = New System.Drawing.Size(57, 59)
        Me.picBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBooks.TabIndex = 33
        Me.picBooks.TabStop = False
        '
        'lblBooks
        '
        Me.lblBooks.AutoSize = True
        Me.lblBooks.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBooks.Location = New System.Drawing.Point(101, 11)
        Me.lblBooks.Name = "lblBooks"
        Me.lblBooks.Size = New System.Drawing.Size(89, 27)
        Me.lblBooks.TabIndex = 32
        Me.lblBooks.Text = "Books"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.picBook)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.dgvUser)
        Me.Panel2.Controls.Add(Me.lblUserList)
        Me.Panel2.Controls.Add(Me.lblCloseUsers)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.txtUPassword)
        Me.Panel2.Controls.Add(Me.lblPassword)
        Me.Panel2.Controls.Add(Me.lblAddress)
        Me.Panel2.Controls.Add(Me.txtPhone)
        Me.Panel2.Controls.Add(Me.lblPhone)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.txtUName)
        Me.Panel2.Controls.Add(Me.lblBookShop2)
        Me.Panel2.Location = New System.Drawing.Point(265, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1123, 775)
        Me.Panel2.TabIndex = 36
        '
        'picBook
        '
        Me.picBook.Image = CType(resources.GetObject("picBook.Image"), System.Drawing.Image)
        Me.picBook.Location = New System.Drawing.Point(554, 80)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(78, 55)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 31
        Me.picBook.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(649, 194)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(206, 91)
        Me.txtAddress.TabIndex = 30
        '
        'dgvUser
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        Me.dgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUser.Location = New System.Drawing.Point(3, 404)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.RowTemplate.Height = 24
        Me.dgvUser.Size = New System.Drawing.Size(1099, 349)
        Me.dgvUser.TabIndex = 29
        '
        'lblUserList
        '
        Me.lblUserList.AutoSize = True
        Me.lblUserList.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserList.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblUserList.Location = New System.Drawing.Point(486, 365)
        Me.lblUserList.Name = "lblUserList"
        Me.lblUserList.Size = New System.Drawing.Size(174, 36)
        Me.lblUserList.TabIndex = 25
        Me.lblUserList.Text = "Users List"
        '
        'lblCloseUsers
        '
        Me.lblCloseUsers.AutoSize = True
        Me.lblCloseUsers.BackColor = System.Drawing.SystemColors.Control
        Me.lblCloseUsers.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseUsers.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCloseUsers.Location = New System.Drawing.Point(1087, 0)
        Me.lblCloseUsers.Name = "lblCloseUsers"
        Me.lblCloseUsers.Size = New System.Drawing.Size(35, 38)
        Me.lblCloseUsers.TabIndex = 24
        Me.lblCloseUsers.Text = "x"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DarkBlue
        Me.btnReset.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(813, 304)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(183, 50)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkBlue
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(575, 304)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(183, 50)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkBlue
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(341, 304)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(183, 50)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSave.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(104, 304)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(183, 50)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtUPassword
        '
        Me.txtUPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUPassword.Location = New System.Drawing.Point(890, 194)
        Me.txtUPassword.Name = "txtUPassword"
        Me.txtUPassword.Size = New System.Drawing.Size(180, 22)
        Me.txtUPassword.TabIndex = 17
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPassword.Location = New System.Drawing.Point(885, 151)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(131, 27)
        Me.lblPassword.TabIndex = 16
        Me.lblPassword.Text = "Password"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblAddress.Location = New System.Drawing.Point(644, 151)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(114, 27)
        Me.lblAddress.TabIndex = 14
        Me.lblAddress.Text = "Address"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(382, 194)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(195, 22)
        Me.txtPhone.TabIndex = 13
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPhone.Location = New System.Drawing.Point(377, 151)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(91, 27)
        Me.lblPhone.TabIndex = 12
        Me.lblPhone.Text = "Phone"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblName.Location = New System.Drawing.Point(66, 151)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 27)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name"
        '
        'txtUName
        '
        Me.txtUName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUName.Location = New System.Drawing.Point(71, 194)
        Me.txtUName.Name = "txtUName"
        Me.txtUName.Size = New System.Drawing.Size(215, 22)
        Me.txtUName.TabIndex = 10
        '
        'lblBookShop2
        '
        Me.lblBookShop2.AutoSize = True
        Me.lblBookShop2.Font = New System.Drawing.Font("Lucida Fax", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookShop2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookShop2.Location = New System.Drawing.Point(403, 24)
        Me.lblBookShop2.Name = "lblBookShop2"
        Me.lblBookShop2.Size = New System.Drawing.Size(355, 38)
        Me.lblBookShop2.TabIndex = 3
        Me.lblBookShop2.Text = "BookShop Software"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblBookShopicon)
        Me.Panel1.Controls.Add(Me.picShop)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 775)
        Me.Panel1.TabIndex = 35
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.picLogout)
        Me.Panel6.Controls.Add(Me.lblLogout)
        Me.Panel6.Location = New System.Drawing.Point(0, 462)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(246, 59)
        Me.Panel6.TabIndex = 35
        '
        'picLogout
        '
        Me.picLogout.Image = CType(resources.GetObject("picLogout.Image"), System.Drawing.Image)
        Me.picLogout.Location = New System.Drawing.Point(20, 6)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(47, 42)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogout.TabIndex = 32
        Me.picLogout.TabStop = False
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLogout.Location = New System.Drawing.Point(101, 21)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(100, 27)
        Me.lblLogout.TabIndex = 32
        Me.lblLogout.Text = "Logout"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.picDashboard)
        Me.Panel5.Controls.Add(Me.lblDashboard)
        Me.Panel5.Location = New System.Drawing.Point(3, 368)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(246, 59)
        Me.Panel5.TabIndex = 34
        '
        'picDashboard
        '
        Me.picDashboard.Image = CType(resources.GetObject("picDashboard.Image"), System.Drawing.Image)
        Me.picDashboard.Location = New System.Drawing.Point(20, 6)
        Me.picDashboard.Name = "picDashboard"
        Me.picDashboard.Size = New System.Drawing.Size(47, 42)
        Me.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDashboard.TabIndex = 32
        Me.picDashboard.TabStop = False
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDashboard.Location = New System.Drawing.Point(94, 6)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(149, 27)
        Me.lblDashboard.TabIndex = 32
        Me.lblDashboard.Text = "Dashboard"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Magenta
        Me.Panel4.Controls.Add(Me.picUsers)
        Me.Panel4.Controls.Add(Me.lblUsers)
        Me.Panel4.Location = New System.Drawing.Point(3, 276)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 59)
        Me.Panel4.TabIndex = 33
        '
        'picUsers
        '
        Me.picUsers.Image = CType(resources.GetObject("picUsers.Image"), System.Drawing.Image)
        Me.picUsers.Location = New System.Drawing.Point(20, 6)
        Me.picUsers.Name = "picUsers"
        Me.picUsers.Size = New System.Drawing.Size(47, 42)
        Me.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsers.TabIndex = 32
        Me.picUsers.TabStop = False
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUsers.Location = New System.Drawing.Point(94, 6)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(81, 27)
        Me.lblUsers.TabIndex = 32
        Me.lblUsers.Text = "Users"
        '
        'lblBookShopicon
        '
        Me.lblBookShopicon.AutoSize = True
        Me.lblBookShopicon.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookShopicon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBookShopicon.Location = New System.Drawing.Point(83, 24)
        Me.lblBookShopicon.Name = "lblBookShopicon"
        Me.lblBookShopicon.Size = New System.Drawing.Size(146, 27)
        Me.lblBookShopicon.TabIndex = 30
        Me.lblBookShopicon.Text = "BookShop "
        '
        'picShop
        '
        Me.picShop.Image = CType(resources.GetObject("picShop.Image"), System.Drawing.Image)
        Me.picShop.Location = New System.Drawing.Point(12, 3)
        Me.picShop.Name = "picShop"
        Me.picShop.Size = New System.Drawing.Size(65, 62)
        Me.picShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShop.TabIndex = 30
        Me.picShop.TabStop = False
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 799)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.picDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.picUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblBooks As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents lblUserList As Label
    Friend WithEvents lblCloseUsers As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtUPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtUName As TextBox
    Friend WithEvents lblBookShop2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents picDashboard As PictureBox
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents picUsers As PictureBox
    Friend WithEvents lblUsers As Label
    Friend WithEvents lblBookShopicon As Label
    Friend WithEvents picShop As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents picBook As PictureBox
    Friend WithEvents picBooks As PictureBox
End Class
