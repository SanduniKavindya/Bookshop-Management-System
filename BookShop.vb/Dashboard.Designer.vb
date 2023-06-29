<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picBooks = New System.Windows.Forms.PictureBox()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUsersNum = New System.Windows.Forms.Label()
        Me.lblAmountNum = New System.Windows.Forms.Label()
        Me.lblBookNum = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblAmountDash = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblUserDash = New System.Windows.Forms.Label()
        Me.lblBookDash = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.picUsericon = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.picBookicon = New System.Windows.Forms.PictureBox()
        Me.lblDash = New System.Windows.Forms.Label()
        Me.lblCloseDash = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
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
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.picUsericon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.picBookicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.Location = New System.Drawing.Point(13, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 59)
        Me.Panel3.TabIndex = 37
        '
        'picBooks
        '
        Me.picBooks.Image = CType(resources.GetObject("picBooks.Image"), System.Drawing.Image)
        Me.picBooks.Location = New System.Drawing.Point(12, -3)
        Me.picBooks.Name = "picBooks"
        Me.picBooks.Size = New System.Drawing.Size(57, 59)
        Me.picBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBooks.TabIndex = 32
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
        Me.Panel2.Controls.Add(Me.lblUsersNum)
        Me.Panel2.Controls.Add(Me.lblAmountNum)
        Me.Panel2.Controls.Add(Me.lblBookNum)
        Me.Panel2.Controls.Add(Me.Panel11)
        Me.Panel2.Controls.Add(Me.lblAmountDash)
        Me.Panel2.Controls.Add(Me.Panel12)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.lblUserDash)
        Me.Panel2.Controls.Add(Me.lblBookDash)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.lblDash)
        Me.Panel2.Controls.Add(Me.lblCloseDash)
        Me.Panel2.Controls.Add(Me.picBook)
        Me.Panel2.Controls.Add(Me.lblBookShop2)
        Me.Panel2.Location = New System.Drawing.Point(265, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1123, 775)
        Me.Panel2.TabIndex = 36
        '
        'lblUsersNum
        '
        Me.lblUsersNum.AutoSize = True
        Me.lblUsersNum.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsersNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUsersNum.Location = New System.Drawing.Point(857, 389)
        Me.lblUsersNum.Name = "lblUsersNum"
        Me.lblUsersNum.Size = New System.Drawing.Size(71, 27)
        Me.lblUsersNum.TabIndex = 43
        Me.lblUsersNum.Text = "Num"
        '
        'lblAmountNum
        '
        Me.lblAmountNum.AutoSize = True
        Me.lblAmountNum.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAmountNum.Location = New System.Drawing.Point(602, 637)
        Me.lblAmountNum.Name = "lblAmountNum"
        Me.lblAmountNum.Size = New System.Drawing.Size(71, 27)
        Me.lblAmountNum.TabIndex = 42
        Me.lblAmountNum.Text = "Num"
        '
        'lblBookNum
        '
        Me.lblBookNum.AutoSize = True
        Me.lblBookNum.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBookNum.Location = New System.Drawing.Point(279, 389)
        Me.lblBookNum.Name = "lblBookNum"
        Me.lblBookNum.Size = New System.Drawing.Size(71, 27)
        Me.lblBookNum.TabIndex = 41
        Me.lblBookNum.Text = "Num"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Teal
        Me.Panel11.Location = New System.Drawing.Point(556, 596)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(223, 15)
        Me.Panel11.TabIndex = 40
        '
        'lblAmountDash
        '
        Me.lblAmountDash.AutoSize = True
        Me.lblAmountDash.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDash.ForeColor = System.Drawing.Color.Black
        Me.lblAmountDash.Location = New System.Drawing.Point(570, 552)
        Me.lblAmountDash.Name = "lblAmountDash"
        Me.lblAmountDash.Size = New System.Drawing.Size(113, 27)
        Me.lblAmountDash.TabIndex = 39
        Me.lblAmountDash.Text = "Amount"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Teal
        Me.Panel12.Controls.Add(Me.PictureBox1)
        Me.Panel12.Location = New System.Drawing.Point(352, 513)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(200, 169)
        Me.Panel12.TabIndex = 38
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel9.Location = New System.Drawing.Point(833, 341)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(223, 15)
        Me.Panel9.TabIndex = 37
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Navy
        Me.Panel8.Location = New System.Drawing.Point(247, 341)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(223, 15)
        Me.Panel8.TabIndex = 34
        '
        'lblUserDash
        '
        Me.lblUserDash.AutoSize = True
        Me.lblUserDash.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserDash.ForeColor = System.Drawing.Color.Black
        Me.lblUserDash.Location = New System.Drawing.Point(847, 297)
        Me.lblUserDash.Name = "lblUserDash"
        Me.lblUserDash.Size = New System.Drawing.Size(81, 27)
        Me.lblUserDash.TabIndex = 36
        Me.lblUserDash.Text = "Users"
        '
        'lblBookDash
        '
        Me.lblBookDash.AutoSize = True
        Me.lblBookDash.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookDash.ForeColor = System.Drawing.Color.Black
        Me.lblBookDash.Location = New System.Drawing.Point(261, 297)
        Me.lblBookDash.Name = "lblBookDash"
        Me.lblBookDash.Size = New System.Drawing.Size(89, 27)
        Me.lblBookDash.TabIndex = 33
        Me.lblBookDash.Text = "Books"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel10.Controls.Add(Me.picUsericon)
        Me.Panel10.Location = New System.Drawing.Point(629, 258)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(200, 169)
        Me.Panel10.TabIndex = 35
        '
        'picUsericon
        '
        Me.picUsericon.Image = CType(resources.GetObject("picUsericon.Image"), System.Drawing.Image)
        Me.picUsericon.Location = New System.Drawing.Point(44, 28)
        Me.picUsericon.Name = "picUsericon"
        Me.picUsericon.Size = New System.Drawing.Size(118, 105)
        Me.picUsericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsericon.TabIndex = 34
        Me.picUsericon.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Navy
        Me.Panel7.Controls.Add(Me.picBookicon)
        Me.Panel7.Location = New System.Drawing.Point(43, 258)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 169)
        Me.Panel7.TabIndex = 26
        '
        'picBookicon
        '
        Me.picBookicon.Image = CType(resources.GetObject("picBookicon.Image"), System.Drawing.Image)
        Me.picBookicon.Location = New System.Drawing.Point(44, 28)
        Me.picBookicon.Name = "picBookicon"
        Me.picBookicon.Size = New System.Drawing.Size(108, 105)
        Me.picBookicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookicon.TabIndex = 33
        Me.picBookicon.TabStop = False
        '
        'lblDash
        '
        Me.lblDash.AutoSize = True
        Me.lblDash.Font = New System.Drawing.Font("Lucida Fax", 19.8!, System.Drawing.FontStyle.Bold)
        Me.lblDash.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblDash.Location = New System.Drawing.Point(476, 167)
        Me.lblDash.Name = "lblDash"
        Me.lblDash.Size = New System.Drawing.Size(206, 38)
        Me.lblDash.TabIndex = 25
        Me.lblDash.Text = "Dashboard"
        '
        'lblCloseDash
        '
        Me.lblCloseDash.AutoSize = True
        Me.lblCloseDash.BackColor = System.Drawing.SystemColors.Control
        Me.lblCloseDash.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseDash.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCloseDash.Location = New System.Drawing.Point(1087, 0)
        Me.lblCloseDash.Name = "lblCloseDash"
        Me.lblCloseDash.Size = New System.Drawing.Size(35, 38)
        Me.lblCloseDash.TabIndex = 24
        Me.lblCloseDash.Text = "x"
        '
        'picBook
        '
        Me.picBook.Image = CType(resources.GetObject("picBook.Image"), System.Drawing.Image)
        Me.picBook.Location = New System.Drawing.Point(530, 86)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(81, 59)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 9
        Me.picBook.TabStop = False
        '
        'lblBookShop2
        '
        Me.lblBookShop2.AutoSize = True
        Me.lblBookShop2.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookShop2.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookShop2.Location = New System.Drawing.Point(403, 24)
        Me.lblBookShop2.Name = "lblBookShop2"
        Me.lblBookShop2.Size = New System.Drawing.Size(322, 36)
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
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
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
        Me.Panel5.BackColor = System.Drawing.Color.Magenta
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
        Me.picDashboard.Location = New System.Drawing.Point(17, 6)
        Me.picDashboard.Name = "picDashboard"
        Me.picDashboard.Size = New System.Drawing.Size(47, 42)
        Me.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDashboard.TabIndex = 33
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
        Me.Panel4.BackColor = System.Drawing.Color.Black
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
        Me.picUsers.Location = New System.Drawing.Point(17, 0)
        Me.picUsers.Name = "picUsers"
        Me.picUsers.Size = New System.Drawing.Size(47, 42)
        Me.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsers.TabIndex = 33
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
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 799)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.picUsericon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.picBookicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents picBooks As PictureBox
    Friend WithEvents lblBooks As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCloseDash As Label
    Friend WithEvents lblBookShop2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblUsers As Label
    Friend WithEvents lblBookShopicon As Label
    Friend WithEvents picShop As PictureBox
    Friend WithEvents lblDash As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents picBookicon As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblUserDash As Label
    Friend WithEvents lblBookDash As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents picUsericon As PictureBox
    Friend WithEvents lblUsersNum As Label
    Friend WithEvents lblAmountNum As Label
    Friend WithEvents lblBookNum As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblAmountDash As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picUsers As PictureBox
    Friend WithEvents picDashboard As PictureBox
End Class
