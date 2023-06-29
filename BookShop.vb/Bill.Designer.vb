<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBill))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblBookShopicon = New System.Windows.Forms.Label()
        Me.picShop = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.lblBookShop2 = New System.Windows.Forms.Label()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.lblBookName = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.txtClient = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnAddBill = New System.Windows.Forms.Button()
        Me.btnResetBill = New System.Windows.Forms.Button()
        Me.lblCloseBill = New System.Windows.Forms.Label()
        Me.lblBookBill = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblBooksList = New System.Windows.Forms.Label()
        Me.dgvBookList = New System.Windows.Forms.DataGridView()
        Me.dgvBookBill = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog11 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.picShop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBookList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBookBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblBookShopicon)
        Me.Panel1.Controls.Add(Me.picShop)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 775)
        Me.Panel1.TabIndex = 35
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.picLogout)
        Me.Panel6.Controls.Add(Me.lblLogout)
        Me.Panel6.Location = New System.Drawing.Point(10, 691)
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
        'picBook
        '
        Me.picBook.Image = CType(resources.GetObject("picBook.Image"), System.Drawing.Image)
        Me.picBook.Location = New System.Drawing.Point(537, 76)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(81, 59)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 9
        Me.picBook.TabStop = False
        '
        'txtBName
        '
        Me.txtBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBName.Enabled = False
        Me.txtBName.Location = New System.Drawing.Point(48, 168)
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(220, 22)
        Me.txtBName.TabIndex = 10
        '
        'lblBookName
        '
        Me.lblBookName.AutoSize = True
        Me.lblBookName.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookName.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookName.Location = New System.Drawing.Point(43, 138)
        Me.lblBookName.Name = "lblBookName"
        Me.lblBookName.Size = New System.Drawing.Size(155, 27)
        Me.lblBookName.TabIndex = 11
        Me.lblBookName.Text = "Book Name"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblClient.Location = New System.Drawing.Point(43, 209)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(167, 27)
        Me.lblClient.TabIndex = 12
        Me.lblClient.Text = "Client Name"
        '
        'txtClient
        '
        Me.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClient.Location = New System.Drawing.Point(48, 248)
        Me.txtClient.Name = "txtClient"
        Me.txtClient.Size = New System.Drawing.Size(206, 22)
        Me.txtClient.TabIndex = 13
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblQuantity.Location = New System.Drawing.Point(299, 138)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(123, 27)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Location = New System.Drawing.Point(304, 168)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(107, 22)
        Me.txtQty.TabIndex = 17
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Lucida Fax", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPrice.Location = New System.Drawing.Point(299, 209)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(75, 27)
        Me.lblPrice.TabIndex = 18
        Me.lblPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(304, 248)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(96, 22)
        Me.txtPrice.TabIndex = 19
        '
        'btnAddBill
        '
        Me.btnAddBill.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAddBill.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBill.ForeColor = System.Drawing.Color.White
        Me.btnAddBill.Location = New System.Drawing.Point(41, 293)
        Me.btnAddBill.Name = "btnAddBill"
        Me.btnAddBill.Size = New System.Drawing.Size(183, 50)
        Me.btnAddBill.TabIndex = 20
        Me.btnAddBill.Text = "Add to Bill"
        Me.btnAddBill.UseVisualStyleBackColor = False
        '
        'btnResetBill
        '
        Me.btnResetBill.BackColor = System.Drawing.Color.DarkBlue
        Me.btnResetBill.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetBill.ForeColor = System.Drawing.Color.White
        Me.btnResetBill.Location = New System.Drawing.Point(278, 293)
        Me.btnResetBill.Name = "btnResetBill"
        Me.btnResetBill.Size = New System.Drawing.Size(183, 50)
        Me.btnResetBill.TabIndex = 23
        Me.btnResetBill.Text = "Reset"
        Me.btnResetBill.UseVisualStyleBackColor = False
        '
        'lblCloseBill
        '
        Me.lblCloseBill.AutoSize = True
        Me.lblCloseBill.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloseBill.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblCloseBill.Location = New System.Drawing.Point(1087, 0)
        Me.lblCloseBill.Name = "lblCloseBill"
        Me.lblCloseBill.Size = New System.Drawing.Size(35, 38)
        Me.lblCloseBill.TabIndex = 24
        Me.lblCloseBill.Text = "x"
        '
        'lblBookBill
        '
        Me.lblBookBill.AutoSize = True
        Me.lblBookBill.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookBill.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookBill.Location = New System.Drawing.Point(749, 120)
        Me.lblBookBill.Name = "lblBookBill"
        Me.lblBookBill.Size = New System.Drawing.Size(173, 36)
        Me.lblBookBill.TabIndex = 25
        Me.lblBookBill.Text = "Books Bill"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkBlue
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(755, 591)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(183, 50)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblBooksList)
        Me.Panel2.Controls.Add(Me.dgvBookList)
        Me.Panel2.Controls.Add(Me.dgvBookBill)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.lblBookBill)
        Me.Panel2.Controls.Add(Me.lblCloseBill)
        Me.Panel2.Controls.Add(Me.btnResetBill)
        Me.Panel2.Controls.Add(Me.btnAddBill)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.lblPrice)
        Me.Panel2.Controls.Add(Me.txtQty)
        Me.Panel2.Controls.Add(Me.lblQuantity)
        Me.Panel2.Controls.Add(Me.txtClient)
        Me.Panel2.Controls.Add(Me.lblClient)
        Me.Panel2.Controls.Add(Me.lblBookName)
        Me.Panel2.Controls.Add(Me.txtBName)
        Me.Panel2.Controls.Add(Me.picBook)
        Me.Panel2.Controls.Add(Me.lblBookShop2)
        Me.Panel2.Location = New System.Drawing.Point(265, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1123, 775)
        Me.Panel2.TabIndex = 36
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(55, 15)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(128, 36)
        Me.lblUsername.TabIndex = 34
        Me.lblUsername.Text = "UName"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblTotal.Location = New System.Drawing.Point(791, 533)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 36)
        Me.lblTotal.TabIndex = 32
        Me.lblTotal.Text = "Total"
        '
        'lblBooksList
        '
        Me.lblBooksList.AutoSize = True
        Me.lblBooksList.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooksList.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBooksList.Location = New System.Drawing.Point(183, 362)
        Me.lblBooksList.Name = "lblBooksList"
        Me.lblBooksList.Size = New System.Drawing.Size(180, 36)
        Me.lblBooksList.TabIndex = 31
        Me.lblBooksList.Text = "Books List"
        '
        'dgvBookList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvBookList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookList.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvBookList.Location = New System.Drawing.Point(3, 410)
        Me.dgvBookList.Name = "dgvBookList"
        Me.dgvBookList.RowHeadersWidth = 51
        Me.dgvBookList.RowTemplate.Height = 24
        Me.dgvBookList.Size = New System.Drawing.Size(528, 350)
        Me.dgvBookList.TabIndex = 30
        '
        'dgvBookBill
        '
        Me.dgvBookBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookBill.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Magenta
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBookBill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBookBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBookBill.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBookBill.Location = New System.Drawing.Point(549, 168)
        Me.dgvBookBill.Name = "dgvBookBill"
        Me.dgvBookBill.RowHeadersWidth = 51
        Me.dgvBookBill.RowTemplate.Height = 24
        Me.dgvBookBill.Size = New System.Drawing.Size(560, 337)
        Me.dgvBookBill.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "BOOK"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog11
        '
        Me.PrintPreviewDialog11.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog11.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog11.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog11.Document = Me.PrintDocument1
        Me.PrintPreviewDialog11.Enabled = True
        Me.PrintPreviewDialog11.Icon = CType(resources.GetObject("PrintPreviewDialog11.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog11.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog11.Visible = False
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 799)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bill"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picShop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBookList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBookBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents lblBookShopicon As Label
    Friend WithEvents picShop As PictureBox
    Friend WithEvents lblBookShop2 As Label
    Friend WithEvents picBook As PictureBox
    Friend WithEvents txtBName As TextBox
    Friend WithEvents lblBookName As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents txtClient As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAddBill As Button
    Friend WithEvents btnResetBill As Button
    Friend WithEvents lblCloseBill As Label
    Friend WithEvents lblBookBill As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblBooksList As Label
    Friend WithEvents dgvBookList As DataGridView
    Friend WithEvents dgvBookBill As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog11 As PrintPreviewDialog
    Friend WithEvents lblUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
