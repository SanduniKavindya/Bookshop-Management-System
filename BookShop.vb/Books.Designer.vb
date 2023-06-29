<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBooks))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picBooks = New System.Windows.Forms.PictureBox()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.btnRefreshBook = New System.Windows.Forms.Button()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.lblBookList = New System.Windows.Forms.Label()
        Me.lblCloseBook = New System.Windows.Forms.Label()
        Me.btnResetBook = New System.Windows.Forms.Button()
        Me.btnDeleteBook = New System.Windows.Forms.Button()
        Me.btnEditBook = New System.Windows.Forms.Button()
        Me.btnSaveBook = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lblBookShopicon = New System.Windows.Forms.Label()
        Me.picShop = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.picBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.picDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Magenta
        Me.Panel3.Controls.Add(Me.picBooks)
        Me.Panel3.Controls.Add(Me.lblBooks)
        Me.Panel3.Location = New System.Drawing.Point(12, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 59)
        Me.Panel3.TabIndex = 34
        '
        'picBooks
        '
        Me.picBooks.Image = CType(resources.GetObject("picBooks.Image"), System.Drawing.Image)
        Me.picBooks.Location = New System.Drawing.Point(12, -3)
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
        Me.Panel2.Controls.Add(Me.dgvBooks)
        Me.Panel2.Controls.Add(Me.btnRefreshBook)
        Me.Panel2.Controls.Add(Me.cboFilter)
        Me.Panel2.Controls.Add(Me.lblBookList)
        Me.Panel2.Controls.Add(Me.lblCloseBook)
        Me.Panel2.Controls.Add(Me.btnResetBook)
        Me.Panel2.Controls.Add(Me.btnDeleteBook)
        Me.Panel2.Controls.Add(Me.btnEditBook)
        Me.Panel2.Controls.Add(Me.btnSaveBook)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.lblQuantity)
        Me.Panel2.Controls.Add(Me.cboCategory)
        Me.Panel2.Controls.Add(Me.lblCategory)
        Me.Panel2.Controls.Add(Me.txtAuthor)
        Me.Panel2.Controls.Add(Me.lblAuthor)
        Me.Panel2.Controls.Add(Me.lblBookTitle)
        Me.Panel2.Controls.Add(Me.txtBookName)
        Me.Panel2.Controls.Add(Me.picBook)
        Me.Panel2.Controls.Add(Me.lblBookShop2)
        Me.Panel2.Location = New System.Drawing.Point(264, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1123, 775)
        Me.Panel2.TabIndex = 33
        '
        'dgvBooks
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.dgvBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBooks.ColumnHeadersHeight = 29
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvBooks.Location = New System.Drawing.Point(11, 397)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersWidth = 51
        Me.dgvBooks.RowTemplate.Height = 24
        Me.dgvBooks.Size = New System.Drawing.Size(1099, 365)
        Me.dgvBooks.TabIndex = 29
        '
        'btnRefreshBook
        '
        Me.btnRefreshBook.BackColor = System.Drawing.Color.DarkBlue
        Me.btnRefreshBook.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshBook.ForeColor = System.Drawing.Color.White
        Me.btnRefreshBook.Location = New System.Drawing.Point(709, 341)
        Me.btnRefreshBook.Name = "btnRefreshBook"
        Me.btnRefreshBook.Size = New System.Drawing.Size(183, 50)
        Me.btnRefreshBook.TabIndex = 28
        Me.btnRefreshBook.Text = "Refresh"
        Me.btnRefreshBook.UseVisualStyleBackColor = False
        '
        'cboFilter
        '
        Me.cboFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Items.AddRange(New Object() {"English", "Mathematics", "Science", "Novels", "Programming", "Physics", "Statistics", "Electronics", "Networking", "Biography"})
        Me.cboFilter.Location = New System.Drawing.Point(463, 349)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(215, 37)
        Me.cboFilter.TabIndex = 27
        Me.cboFilter.Text = "Filter by Category"
        '
        'lblBookList
        '
        Me.lblBookList.AutoSize = True
        Me.lblBookList.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookList.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookList.Location = New System.Drawing.Point(486, 299)
        Me.lblBookList.Name = "lblBookList"
        Me.lblBookList.Size = New System.Drawing.Size(180, 36)
        Me.lblBookList.TabIndex = 25
        Me.lblBookList.Text = "Books List"
        '
        'lblCloseBook
        '
        Me.lblCloseBook.AutoSize = True
        Me.lblCloseBook.BackColor = System.Drawing.SystemColors.Control
        Me.lblCloseBook.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseBook.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCloseBook.Location = New System.Drawing.Point(1087, 0)
        Me.lblCloseBook.Name = "lblCloseBook"
        Me.lblCloseBook.Size = New System.Drawing.Size(35, 38)
        Me.lblCloseBook.TabIndex = 24
        Me.lblCloseBook.Text = "x"
        '
        'btnResetBook
        '
        Me.btnResetBook.BackColor = System.Drawing.Color.DarkBlue
        Me.btnResetBook.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetBook.ForeColor = System.Drawing.Color.White
        Me.btnResetBook.Location = New System.Drawing.Point(842, 236)
        Me.btnResetBook.Name = "btnResetBook"
        Me.btnResetBook.Size = New System.Drawing.Size(183, 50)
        Me.btnResetBook.TabIndex = 23
        Me.btnResetBook.Text = "Reset"
        Me.btnResetBook.UseVisualStyleBackColor = False
        '
        'btnDeleteBook
        '
        Me.btnDeleteBook.BackColor = System.Drawing.Color.DarkBlue
        Me.btnDeleteBook.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteBook.ForeColor = System.Drawing.Color.White
        Me.btnDeleteBook.Location = New System.Drawing.Point(604, 236)
        Me.btnDeleteBook.Name = "btnDeleteBook"
        Me.btnDeleteBook.Size = New System.Drawing.Size(183, 50)
        Me.btnDeleteBook.TabIndex = 22
        Me.btnDeleteBook.Text = "Delete"
        Me.btnDeleteBook.UseVisualStyleBackColor = False
        '
        'btnEditBook
        '
        Me.btnEditBook.BackColor = System.Drawing.Color.DarkBlue
        Me.btnEditBook.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBook.ForeColor = System.Drawing.Color.White
        Me.btnEditBook.Location = New System.Drawing.Point(370, 236)
        Me.btnEditBook.Name = "btnEditBook"
        Me.btnEditBook.Size = New System.Drawing.Size(183, 50)
        Me.btnEditBook.TabIndex = 21
        Me.btnEditBook.Text = "Update"
        Me.btnEditBook.UseVisualStyleBackColor = False
        '
        'btnSaveBook
        '
        Me.btnSaveBook.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSaveBook.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBook.ForeColor = System.Drawing.Color.White
        Me.btnSaveBook.Location = New System.Drawing.Point(133, 236)
        Me.btnSaveBook.Name = "btnSaveBook"
        Me.btnSaveBook.Size = New System.Drawing.Size(183, 50)
        Me.btnSaveBook.TabIndex = 20
        Me.btnSaveBook.Text = "Save"
        Me.btnSaveBook.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(960, 195)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(106, 22)
        Me.txtPrice.TabIndex = 19
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPrice.Location = New System.Drawing.Point(955, 156)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(75, 27)
        Me.lblPrice.TabIndex = 18
        Me.lblPrice.Text = "Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Location = New System.Drawing.Point(828, 195)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(107, 22)
        Me.txtQuantity.TabIndex = 17
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblQuantity.Location = New System.Drawing.Point(823, 156)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(123, 27)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Quantity"
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"English", "Mathematics", "Science", "Novels", "Programming", "Physics", "Statistics", "Electronics", "Networking", "Biography"})
        Me.cboCategory.Location = New System.Drawing.Point(636, 195)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(167, 24)
        Me.cboCategory.TabIndex = 15
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCategory.Location = New System.Drawing.Point(631, 156)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(146, 27)
        Me.lblCategory.TabIndex = 14
        Me.lblCategory.Text = "Categories"
        '
        'txtAuthor
        '
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthor.Location = New System.Drawing.Point(310, 198)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(206, 22)
        Me.txtAuthor.TabIndex = 13
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblAuthor.Location = New System.Drawing.Point(305, 168)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(101, 27)
        Me.lblAuthor.TabIndex = 12
        Me.lblAuthor.Text = "Author"
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookTitle.Location = New System.Drawing.Point(52, 168)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(143, 27)
        Me.lblBookTitle.TabIndex = 11
        Me.lblBookTitle.Text = "Book Title"
        '
        'txtBookName
        '
        Me.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBookName.Location = New System.Drawing.Point(57, 196)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(220, 22)
        Me.txtBookName.TabIndex = 10
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
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 775)
        Me.Panel1.TabIndex = 32
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
        Me.picDashboard.Location = New System.Drawing.Point(17, 0)
        Me.picDashboard.Name = "picDashboard"
        Me.picDashboard.Size = New System.Drawing.Size(47, 42)
        Me.picDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDashboard.TabIndex = 34
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
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.lblUsers)
        Me.Panel4.Location = New System.Drawing.Point(3, 276)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 59)
        Me.Panel4.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
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
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 799)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblBooks As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents btnRefreshBook As Button
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents lblBookList As Label
    Friend WithEvents lblCloseBook As Label
    Friend WithEvents btnResetBook As Button
    Friend WithEvents btnDeleteBook As Button
    Friend WithEvents btnEditBook As Button
    Friend WithEvents btnSaveBook As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents picBook As PictureBox
    Friend WithEvents lblBookShop2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblUsers As Label
    Friend WithEvents lblBookShopicon As Label
    Friend WithEvents picShop As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picDashboard As PictureBox
    Friend WithEvents picBooks As PictureBox
End Class
