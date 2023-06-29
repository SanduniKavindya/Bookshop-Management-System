<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.lblBookShop = New System.Windows.Forms.Label()
        Me.picBookShop = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoading = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        CType(Me.picBookShop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBookShop
        '
        Me.lblBookShop.AutoSize = True
        Me.lblBookShop.Font = New System.Drawing.Font("Lucida Fax", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookShop.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblBookShop.Location = New System.Drawing.Point(126, 9)
        Me.lblBookShop.Name = "lblBookShop"
        Me.lblBookShop.Size = New System.Drawing.Size(355, 38)
        Me.lblBookShop.TabIndex = 2
        Me.lblBookShop.Text = "BookShop Software"
        '
        'picBookShop
        '
        Me.picBookShop.Image = CType(resources.GetObject("picBookShop.Image"), System.Drawing.Image)
        Me.picBookShop.Location = New System.Drawing.Point(12, 62)
        Me.picBookShop.Name = "picBookShop"
        Me.picBookShop.Size = New System.Drawing.Size(576, 398)
        Me.picBookShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookShop.TabIndex = 5
        Me.picBookShop.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 466)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(576, 21)
        Me.ProgressBar1.TabIndex = 6
        '
        'Timer1
        '
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblLoading.Location = New System.Drawing.Point(179, 490)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(136, 29)
        Me.lblLoading.TabIndex = 7
        Me.lblLoading.Text = "Loading...."
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.ForeColor = System.Drawing.Color.Red
        Me.lblPercentage.Location = New System.Drawing.Point(321, 490)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(31, 29)
        Me.lblPercentage.TabIndex = 8
        Me.lblPercentage.Text = "%"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 528)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.picBookShop)
        Me.Controls.Add(Me.lblBookShop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        CType(Me.picBookShop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBookShop As Label
    Friend WithEvents picBookShop As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblLoading As Label
    Friend WithEvents lblPercentage As Label
End Class
