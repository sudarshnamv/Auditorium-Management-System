<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venueadd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venueadd))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtVenueLocation = New System.Windows.Forms.TextBox()
        Me.txtVenueId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLoggedInUser = New System.Windows.Forms.Label()
        Me.txtVenueName = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtAmenities = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flpImages = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(726, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(735, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 33)
        Me.btnBack.TabIndex = 45
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 37)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "ADD VENUE"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(662, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(132, 37)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtCapacity
        '
        Me.txtCapacity.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.txtCapacity.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCapacity.Location = New System.Drawing.Point(573, 292)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(231, 30)
        Me.txtCapacity.TabIndex = 41
        '
        'txtVenueLocation
        '
        Me.txtVenueLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtVenueLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVenueLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.txtVenueLocation.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtVenueLocation.Location = New System.Drawing.Point(166, 235)
        Me.txtVenueLocation.Name = "txtVenueLocation"
        Me.txtVenueLocation.Size = New System.Drawing.Size(231, 30)
        Me.txtVenueLocation.TabIndex = 40
        '
        'txtVenueId
        '
        Me.txtVenueId.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtVenueId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVenueId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.txtVenueId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtVenueId.Location = New System.Drawing.Point(573, 151)
        Me.txtVenueId.Name = "txtVenueId"
        Me.txtVenueId.Size = New System.Drawing.Size(231, 30)
        Me.txtVenueId.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(472, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Capacity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Venue Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(467, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Venue ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Venue Image:"
        '
        'lblLoggedInUser
        '
        Me.lblLoggedInUser.AutoSize = True
        Me.lblLoggedInUser.BackColor = System.Drawing.Color.Transparent
        Me.lblLoggedInUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedInUser.Location = New System.Drawing.Point(27, 151)
        Me.lblLoggedInUser.Name = "lblLoggedInUser"
        Me.lblLoggedInUser.Size = New System.Drawing.Size(133, 25)
        Me.lblLoggedInUser.TabIndex = 29
        Me.lblLoggedInUser.Text = "Venue Name:"
        '
        'txtVenueName
        '
        Me.txtVenueName.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtVenueName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVenueName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.txtVenueName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtVenueName.Location = New System.Drawing.Point(166, 151)
        Me.txtVenueName.Name = "txtVenueName"
        Me.txtVenueName.Size = New System.Drawing.Size(231, 30)
        Me.txtVenueName.TabIndex = 28
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SteelBlue
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBrowse.Location = New System.Drawing.Point(60, 344)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(91, 26)
        Me.btnBrowse.TabIndex = 48
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtAmenities
        '
        Me.txtAmenities.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtAmenities.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmenities.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.8!)
        Me.txtAmenities.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAmenities.Location = New System.Drawing.Point(573, 230)
        Me.txtAmenities.Name = "txtAmenities"
        Me.txtAmenities.Size = New System.Drawing.Size(231, 30)
        Me.txtAmenities.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Amenities:"
        '
        'flpImages
        '
        Me.flpImages.Location = New System.Drawing.Point(166, 316)
        Me.flpImages.Name = "flpImages"
        Me.flpImages.Size = New System.Drawing.Size(274, 159)
        Me.flpImages.TabIndex = 51
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Venueadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 503)
        Me.Controls.Add(Me.flpImages)
        Me.Controls.Add(Me.txtAmenities)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.txtVenueLocation)
        Me.Controls.Add(Me.txtVenueId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLoggedInUser)
        Me.Controls.Add(Me.txtVenueName)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Venueadd"
        Me.Text = "Venue Add"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtVenueLocation As TextBox
    Friend WithEvents txtVenueId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLoggedInUser As Label
    Friend WithEvents txtVenueName As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtAmenities As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents flpImages As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
