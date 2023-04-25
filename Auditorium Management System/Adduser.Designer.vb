<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adduser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adduser))
        Me.lblLoggedInUser = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmpid = New System.Windows.Forms.TextBox()
        Me.cmbUsertype = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLoggedInUser
        '
        Me.lblLoggedInUser.AutoSize = True
        Me.lblLoggedInUser.BackColor = System.Drawing.Color.Transparent
        Me.lblLoggedInUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblLoggedInUser.Location = New System.Drawing.Point(83, 175)
        Me.lblLoggedInUser.Name = "lblLoggedInUser"
        Me.lblLoggedInUser.Size = New System.Drawing.Size(58, 20)
        Me.lblLoggedInUser.TabIndex = 52
        Me.lblLoggedInUser.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtName.Location = New System.Drawing.Point(147, 174)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 21)
        Me.txtName.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(72, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Gender:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(85, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmail.Location = New System.Drawing.Point(147, 309)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(231, 21)
        Me.txtEmail.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(50, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Username:"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtUser.Location = New System.Drawing.Point(147, 377)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(231, 21)
        Me.txtUser.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(444, 375)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Password:"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPass.Location = New System.Drawing.Point(541, 375)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(231, 21)
        Me.txtPass.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(444, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "User Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(474, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPhone.Location = New System.Drawing.Point(541, 238)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(231, 21)
        Me.txtPhone.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(461, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Emp_ID:"
        '
        'txtEmpid
        '
        Me.txtEmpid.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtEmpid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtEmpid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtEmpid.Location = New System.Drawing.Point(541, 172)
        Me.txtEmpid.Name = "txtEmpid"
        Me.txtEmpid.Size = New System.Drawing.Size(231, 21)
        Me.txtEmpid.TabIndex = 59
        '
        'cmbUsertype
        '
        Me.cmbUsertype.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.cmbUsertype.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbUsertype.FormattingEnabled = True
        Me.cmbUsertype.Items.AddRange(New Object() {"user", "admin"})
        Me.cmbUsertype.Location = New System.Drawing.Point(541, 307)
        Me.cmbUsertype.Name = "cmbUsertype"
        Me.cmbUsertype.Size = New System.Drawing.Size(231, 24)
        Me.cmbUsertype.TabIndex = 67
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.cmbGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"male", "female", "other"})
        Me.cmbGender.Location = New System.Drawing.Point(147, 237)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(231, 24)
        Me.cmbGender.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(329, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 37)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "ADD USER"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(358, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 37)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(737, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(746, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 33)
        Me.btnBack.TabIndex = 71
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Adduser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 552)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.cmbUsertype)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmpid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLoggedInUser)
        Me.Controls.Add(Me.txtName)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Adduser"
        Me.Text = "Add User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoggedInUser As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmpid As TextBox
    Friend WithEvents cmbUsertype As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
