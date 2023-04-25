<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCart
        '
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Location = New System.Drawing.Point(42, 310)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersWidth = 51
        Me.dgvCart.RowTemplate.Height = 24
        Me.dgvCart.Size = New System.Drawing.Size(437, 204)
        Me.dgvCart.TabIndex = 0
        '
        'dgvInventory
        '
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(42, 82)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersWidth = 51
        Me.dgvInventory.RowTemplate.Height = 24
        Me.dgvInventory.Size = New System.Drawing.Size(602, 201)
        Me.dgvInventory.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(320, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 37)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "BOOK ITEMS"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddToCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddToCart.Location = New System.Drawing.Point(650, 192)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(132, 111)
        Me.btnAddToCart.TabIndex = 26
        Me.btnAddToCart.Text = "ADD TO CART"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCheckout.Location = New System.Drawing.Point(501, 412)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(132, 102)
        Me.btnCheckout.TabIndex = 27
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(721, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(730, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 33)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 544)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.dgvCart)
        Me.DoubleBuffered = True
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
