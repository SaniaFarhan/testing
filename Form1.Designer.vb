<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSubmit = New Button()
        lblFName = New Label()
        txtFName = New TextBox()
        txtLName = New TextBox()
        lblLName = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        lblGender = New Label()
        rdbtnMale = New RadioButton()
        rdbtnFemale = New RadioButton()
        date_birth = New DateTimePicker()
        lblDoB = New Label()
        txtPass = New TextBox()
        lblPass = New Label()
        txtUser = New TextBox()
        lblUser = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        txtImage = New TextBox()
        Label2 = New Label()
        chkShowPass = New CheckBox()
        btnImage = New Button()
        cmbUser = New ComboBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnReset = New Button()
        DataGrid1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        CType(DataGrid1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(3, 3)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "Insert"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblFName
        ' 
        lblFName.Font = New Font("Tahoma", 9.75F)
        lblFName.Location = New Point(37, 167)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(150, 23)
        lblFName.TabIndex = 1
        lblFName.Text = "First Name*"
        lblFName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' txtFName
        ' 
        txtFName.Font = New Font("Tahoma", 9.75F)
        txtFName.Location = New Point(191, 167)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(285, 23)
        txtFName.TabIndex = 2
        ' 
        ' txtLName
        ' 
        txtLName.Font = New Font("Tahoma", 9.75F)
        txtLName.Location = New Point(191, 196)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(285, 23)
        txtLName.TabIndex = 4
        ' 
        ' lblLName
        ' 
        lblLName.Font = New Font("Tahoma", 9.75F)
        lblLName.Location = New Point(37, 193)
        lblLName.Name = "lblLName"
        lblLName.Size = New Size(150, 23)
        lblLName.TabIndex = 3
        lblLName.Text = "Last Name*"
        lblLName.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Tahoma", 9.75F)
        txtAddress.Location = New Point(191, 225)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(285, 23)
        txtAddress.TabIndex = 6
        ' 
        ' lblAddress
        ' 
        lblAddress.Font = New Font("Tahoma", 9.75F)
        lblAddress.Location = New Point(37, 222)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(150, 23)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Address"
        lblAddress.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' lblGender
        ' 
        lblGender.Font = New Font("Tahoma", 9.75F)
        lblGender.Location = New Point(37, 255)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(150, 23)
        lblGender.TabIndex = 7
        lblGender.Text = "Gender*"
        lblGender.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' rdbtnMale
        ' 
        rdbtnMale.AutoSize = True
        rdbtnMale.Font = New Font("Tahoma", 9.75F)
        rdbtnMale.Location = New Point(208, 259)
        rdbtnMale.Name = "rdbtnMale"
        rdbtnMale.Size = New Size(52, 20)
        rdbtnMale.TabIndex = 8
        rdbtnMale.Text = "Male"
        rdbtnMale.UseVisualStyleBackColor = True
        ' 
        ' rdbtnFemale
        ' 
        rdbtnFemale.AutoSize = True
        rdbtnFemale.Font = New Font("Tahoma", 9.75F)
        rdbtnFemale.Location = New Point(331, 258)
        rdbtnFemale.Name = "rdbtnFemale"
        rdbtnFemale.Size = New Size(67, 20)
        rdbtnFemale.TabIndex = 9
        rdbtnFemale.Text = "Female"
        rdbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' date_birth
        ' 
        date_birth.CalendarFont = New Font("Tahoma", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        date_birth.CustomFormat = "yyyy-MM-dd"
        date_birth.Format = DateTimePickerFormat.Custom
        date_birth.Location = New Point(191, 288)
        date_birth.Name = "date_birth"
        date_birth.Size = New Size(285, 23)
        date_birth.TabIndex = 10
        ' 
        ' lblDoB
        ' 
        lblDoB.Font = New Font("Tahoma", 9.75F)
        lblDoB.Location = New Point(37, 287)
        lblDoB.Name = "lblDoB"
        lblDoB.Size = New Size(150, 23)
        lblDoB.TabIndex = 11
        lblDoB.Text = "Date of Birth"
        lblDoB.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Tahoma", 9.75F)
        txtPass.Location = New Point(191, 106)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(285, 23)
        txtPass.TabIndex = 15
        txtPass.UseSystemPasswordChar = True
        ' 
        ' lblPass
        ' 
        lblPass.Font = New Font("Tahoma", 9.75F)
        lblPass.Location = New Point(37, 106)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(150, 23)
        lblPass.TabIndex = 14
        lblPass.Text = "Password*"
        lblPass.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Tahoma", 9.75F)
        txtUser.Location = New Point(191, 77)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(285, 23)
        txtUser.TabIndex = 13
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Tahoma", 9.75F)
        lblUser.Location = New Point(37, 77)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(150, 23)
        lblUser.TabIndex = 12
        lblUser.Text = "Username*"
        lblUser.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(530, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(98, 104)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 24.0F)
        Label1.Location = New Point(255, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 39)
        Label1.TabIndex = 17
        Label1.Text = "Login Form"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
        ' 
        ' txtImage
        ' 
        txtImage.Font = New Font("Tahoma", 9.75F)
        txtImage.Location = New Point(191, 316)
        txtImage.Name = "txtImage"
        txtImage.Size = New Size(285, 23)
        txtImage.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Tahoma", 9.75F)
        Label2.Location = New Point(39, 316)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 23)
        Label2.TabIndex = 18
        Label2.Text = "Photo"
        Label2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' chkShowPass
        ' 
        chkShowPass.AutoSize = True
        chkShowPass.Location = New Point(195, 140)
        chkShowPass.Name = "chkShowPass"
        chkShowPass.Size = New Size(108, 19)
        chkShowPass.TabIndex = 20
        chkShowPass.Text = "Show Password"
        chkShowPass.UseVisualStyleBackColor = True
        ' 
        ' btnImage
        ' 
        btnImage.AutoSize = True
        btnImage.Location = New Point(195, 345)
        btnImage.Name = "btnImage"
        btnImage.Size = New Size(105, 25)
        btnImage.TabIndex = 21
        btnImage.Text = "Select Image File"
        btnImage.UseVisualStyleBackColor = True
        ' 
        ' cmbUser
        ' 
        cmbUser.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbUser.FormattingEnabled = True
        cmbUser.Location = New Point(191, 52)
        cmbUser.Name = "cmbUser"
        cmbUser.Size = New Size(285, 22)
        cmbUser.TabIndex = 28
        cmbUser.Text = "Select username"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnSubmit)
        FlowLayoutPanel1.Controls.Add(btnUpdate)
        FlowLayoutPanel1.Controls.Add(btnDelete)
        FlowLayoutPanel1.Controls.Add(btnReset)
        FlowLayoutPanel1.Location = New Point(153, 393)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(359, 37)
        FlowLayoutPanel1.TabIndex = 33
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(84, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 2
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(165, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.AutoSize = True
        btnReset.Location = New Point(246, 3)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(109, 25)
        btnReset.TabIndex = 0
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' DataGrid1
        ' 
        DataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGrid1.Location = New Point(39, 447)
        DataGrid1.Name = "DataGrid1"
        DataGrid1.Size = New Size(601, 209)
        DataGrid1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 749)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(cmbUser)
        Controls.Add(DataGrid1)
        Controls.Add(btnImage)
        Controls.Add(chkShowPass)
        Controls.Add(txtImage)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(txtPass)
        Controls.Add(lblPass)
        Controls.Add(txtUser)
        Controls.Add(lblUser)
        Controls.Add(lblDoB)
        Controls.Add(date_birth)
        Controls.Add(rdbtnFemale)
        Controls.Add(rdbtnMale)
        Controls.Add(lblGender)
        Controls.Add(txtAddress)
        Controls.Add(lblAddress)
        Controls.Add(txtLName)
        Controls.Add(lblLName)
        Controls.Add(txtFName)
        Controls.Add(lblFName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(DataGrid1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblFName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblLName As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents rdbtnMale As RadioButton
    Friend WithEvents rdbtnFemale As RadioButton
    Friend WithEvents date_birth As DateTimePicker
    Friend WithEvents lblDoB As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtImage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents btnImage As Button
    Friend WithEvents cmbUser As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents DataGrid1 As DataGridView

End Class
