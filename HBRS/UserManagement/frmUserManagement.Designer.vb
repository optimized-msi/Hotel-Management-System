﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserManagement))
        Me.tbControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvUserList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFemale = New System.Windows.Forms.RadioButton()
        Me.rbMale = New System.Windows.Forms.RadioButton()
        Me.txtBirthday = New System.Windows.Forms.DateTimePicker()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgRulePrivilege = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFailedAttemp = New System.Windows.Forms.CheckBox()
        Me.chkPasswrdAge = New System.Windows.Forms.CheckBox()
        Me.ChkInactivateUser = New System.Windows.Forms.CheckBox()
        Me.CHKISEXPIRED = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lvALL_USER_LIST = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCancell = New System.Windows.Forms.Button()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUserType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtContactnumber = New HBRS.watermark()
        Me.txtEmailaddress = New HBRS.watermark()
        Me.txtPasword1 = New HBRS.watermark()
        Me.txtPassword = New HBRS.watermark()
        Me.txtLastname = New HBRS.watermark()
        Me.txtMiddlename = New HBRS.watermark()
        Me.txtFirstname = New HBRS.watermark()
        Me.txtUsername = New HBRS.watermark()
        Me.txtFailedAttemp = New HBRS.watermark()
        Me.txtPasswordAge = New HBRS.watermark()
        Me.txtAddDays = New HBRS.watermark()
        Me.txtSearch = New HBRS.watermark()
        Me.tbControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgRulePrivilege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbControl
        '
        Me.tbControl.Controls.Add(Me.TabPage1)
        Me.tbControl.Controls.Add(Me.TabPage2)
        Me.tbControl.Controls.Add(Me.TabPage3)
        Me.tbControl.Controls.Add(Me.TabPage4)
        Me.tbControl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbControl.Location = New System.Drawing.Point(12, 12)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.Padding = New System.Drawing.Point(20, 10)
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(732, 444)
        Me.tbControl.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvUserList)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(724, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvUserList
        '
        Me.lvUserList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvUserList.FullRowSelect = True
        Me.lvUserList.GridLines = True
        Me.lvUserList.Location = New System.Drawing.Point(3, 18)
        Me.lvUserList.Name = "lvUserList"
        Me.lvUserList.Size = New System.Drawing.Size(275, 368)
        Me.lvUserList.TabIndex = 1
        Me.lvUserList.UseCompatibleStateImageBehavior = False
        Me.lvUserList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        Me.ColumnHeader1.Width = 29
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 241
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.rbFemale)
        Me.GroupBox1.Controls.Add(Me.rbMale)
        Me.GroupBox1.Controls.Add(Me.txtBirthday)
        Me.GroupBox1.Controls.Add(Me.txtContactnumber)
        Me.GroupBox1.Controls.Add(Me.txtEmailaddress)
        Me.GroupBox1.Controls.Add(Me.chkShowPassword)
        Me.GroupBox1.Controls.Add(Me.txtPasword1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(284, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 380)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign Up"
        '
        'rbFemale
        '
        Me.rbFemale.AutoSize = True
        Me.rbFemale.Location = New System.Drawing.Point(114, 320)
        Me.rbFemale.Name = "rbFemale"
        Me.rbFemale.Size = New System.Drawing.Size(92, 26)
        Me.rbFemale.TabIndex = 9
        Me.rbFemale.TabStop = True
        Me.rbFemale.Text = "Female"
        Me.rbFemale.UseVisualStyleBackColor = True
        '
        'rbMale
        '
        Me.rbMale.AutoSize = True
        Me.rbMale.Location = New System.Drawing.Point(255, 322)
        Me.rbMale.Name = "rbMale"
        Me.rbMale.Size = New System.Drawing.Size(68, 26)
        Me.rbMale.TabIndex = 10
        Me.rbMale.TabStop = True
        Me.rbMale.Text = "Male"
        Me.rbMale.UseVisualStyleBackColor = True
        '
        'txtBirthday
        '
        Me.txtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtBirthday.Location = New System.Drawing.Point(6, 276)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(422, 29)
        Me.txtBirthday.TabIndex = 8
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New System.Drawing.Point(255, 171)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(165, 26)
        Me.chkShowPassword.TabIndex = 9
        Me.chkShowPassword.Text = "Show Password"
        Me.chkShowPassword.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.dgRulePrivilege)
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(724, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Access"
        '
        'dgRulePrivilege
        '
        Me.dgRulePrivilege.AllowUserToAddRows = False
        Me.dgRulePrivilege.AllowUserToResizeRows = False
        Me.dgRulePrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRulePrivilege.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgRulePrivilege.Location = New System.Drawing.Point(169, 4)
        Me.dgRulePrivilege.Name = "dgRulePrivilege"
        Me.dgRulePrivilege.RowHeadersVisible = False
        Me.dgRulePrivilege.Size = New System.Drawing.Size(409, 389)
        Me.dgRulePrivilege.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRIVILEGE TYPE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 220
        '
        'Column3
        '
        Me.Column3.HeaderText = "ACCESS TYPE"
        Me.Column3.Items.AddRange(New Object() {"Full Access", "Read Only", "No Access"})
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 180
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 39)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(724, 401)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Validation"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.chkFailedAttemp)
        Me.GroupBox2.Controls.Add(Me.chkPasswrdAge)
        Me.GroupBox2.Controls.Add(Me.ChkInactivateUser)
        Me.GroupBox2.Controls.Add(Me.txtFailedAttemp)
        Me.GroupBox2.Controls.Add(Me.txtPasswordAge)
        Me.GroupBox2.Controls.Add(Me.CHKISEXPIRED)
        Me.GroupBox2.Controls.Add(Me.txtAddDays)
        Me.GroupBox2.Location = New System.Drawing.Point(175, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(390, 389)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'chkFailedAttemp
        '
        Me.chkFailedAttemp.AutoSize = True
        Me.chkFailedAttemp.Checked = True
        Me.chkFailedAttemp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFailedAttemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFailedAttemp.Location = New System.Drawing.Point(11, 174)
        Me.chkFailedAttemp.Name = "chkFailedAttemp"
        Me.chkFailedAttemp.Size = New System.Drawing.Size(135, 20)
        Me.chkFailedAttemp.TabIndex = 4
        Me.chkFailedAttemp.Text = "Has failed attemp?"
        Me.chkFailedAttemp.UseVisualStyleBackColor = True
        '
        'chkPasswrdAge
        '
        Me.chkPasswrdAge.AutoSize = True
        Me.chkPasswrdAge.Checked = True
        Me.chkPasswrdAge.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPasswrdAge.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPasswrdAge.Location = New System.Drawing.Point(9, 109)
        Me.chkPasswrdAge.Name = "chkPasswrdAge"
        Me.chkPasswrdAge.Size = New System.Drawing.Size(171, 20)
        Me.chkPasswrdAge.TabIndex = 2
        Me.chkPasswrdAge.Text = "Is password will expired?"
        Me.chkPasswrdAge.UseVisualStyleBackColor = True
        '
        'ChkInactivateUser
        '
        Me.ChkInactivateUser.AutoSize = True
        Me.ChkInactivateUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkInactivateUser.Location = New System.Drawing.Point(11, 232)
        Me.ChkInactivateUser.Name = "ChkInactivateUser"
        Me.ChkInactivateUser.Size = New System.Drawing.Size(112, 20)
        Me.ChkInactivateUser.TabIndex = 6
        Me.ChkInactivateUser.Text = "Inactivate User"
        Me.ChkInactivateUser.UseVisualStyleBackColor = True
        '
        'CHKISEXPIRED
        '
        Me.CHKISEXPIRED.AutoSize = True
        Me.CHKISEXPIRED.Checked = True
        Me.CHKISEXPIRED.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKISEXPIRED.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKISEXPIRED.Location = New System.Drawing.Point(6, 41)
        Me.CHKISEXPIRED.Name = "CHKISEXPIRED"
        Me.CHKISEXPIRED.Size = New System.Drawing.Size(162, 20)
        Me.CHKISEXPIRED.TabIndex = 0
        Me.CHKISEXPIRED.Text = "Is account will expired?"
        Me.CHKISEXPIRED.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtSearch)
        Me.TabPage4.Controls.Add(Me.lvALL_USER_LIST)
        Me.TabPage4.Location = New System.Drawing.Point(4, 39)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(724, 401)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Find User"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lvALL_USER_LIST
        '
        Me.lvALL_USER_LIST.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvALL_USER_LIST.FullRowSelect = True
        Me.lvALL_USER_LIST.Location = New System.Drawing.Point(6, 57)
        Me.lvALL_USER_LIST.Name = "lvALL_USER_LIST"
        Me.lvALL_USER_LIST.Size = New System.Drawing.Size(712, 338)
        Me.lvALL_USER_LIST.TabIndex = 1
        Me.lvALL_USER_LIST.UseCompatibleStateImageBehavior = False
        Me.lvALL_USER_LIST.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 30
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 299
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email Address"
        Me.ColumnHeader5.Width = 370
        '
        'btnCancell
        '
        Me.btnCancell.BackColor = System.Drawing.Color.White
        Me.btnCancell.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancell.Location = New System.Drawing.Point(542, 462)
        Me.btnCancell.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancell.Name = "btnCancell"
        Me.btnCancell.Size = New System.Drawing.Size(202, 37)
        Me.btnCancell.TabIndex = 9
        Me.btnCancell.Text = "&Cancel"
        Me.btnCancell.UseVisualStyleBackColor = False
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.BackColor = System.Drawing.Color.White
        Me.btnCreateAccount.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.Location = New System.Drawing.Point(336, 462)
        Me.btnCreateAccount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(202, 37)
        Me.btnCreateAccount.TabIndex = 8
        Me.btnCreateAccount.Text = "&Create Account"
        Me.btnCreateAccount.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus, Me.lblUserType})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(770, 22)
        Me.StatusStrip1.TabIndex = 23
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(65, 17)
        Me.lblStatus.Text = "User Status"
        '
        'lblUserType
        '
        Me.lblUserType.BackColor = System.Drawing.Color.IndianRed
        Me.lblUserType.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(59, 17)
        Me.lblUserType.Text = "User Type"
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CMS
        '
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(114, 26)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'txtContactnumber
        '
        Me.txtContactnumber.Location = New System.Drawing.Point(6, 241)
        Me.txtContactnumber.MaxLength = 13
        Me.txtContactnumber.Name = "txtContactnumber"
        Me.txtContactnumber.Size = New System.Drawing.Size(422, 29)
        Me.txtContactnumber.TabIndex = 7
        Me.txtContactnumber.WatermarkColor = System.Drawing.Color.Gray
        Me.txtContactnumber.WatermarkText = "Contact number"
        '
        'txtEmailaddress
        '
        Me.txtEmailaddress.Location = New System.Drawing.Point(6, 206)
        Me.txtEmailaddress.Name = "txtEmailaddress"
        Me.txtEmailaddress.Size = New System.Drawing.Size(422, 29)
        Me.txtEmailaddress.TabIndex = 6
        Me.txtEmailaddress.WatermarkColor = System.Drawing.Color.Gray
        Me.txtEmailaddress.WatermarkText = "Email Address : Ex. yourname@gmail.com"
        '
        'txtPasword1
        '
        Me.txtPasword1.Location = New System.Drawing.Point(6, 171)
        Me.txtPasword1.Name = "txtPasword1"
        Me.txtPasword1.Size = New System.Drawing.Size(243, 29)
        Me.txtPasword1.TabIndex = 5
        Me.txtPasword1.UseSystemPasswordChar = True
        Me.txtPasword1.WatermarkColor = System.Drawing.Color.Gray
        Me.txtPasword1.WatermarkText = "Re-enter password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(6, 136)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(422, 29)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.WatermarkColor = System.Drawing.Color.Gray
        Me.txtPassword.WatermarkText = "Password"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(6, 98)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(422, 29)
        Me.txtLastname.TabIndex = 3
        Me.txtLastname.WatermarkColor = System.Drawing.Color.Gray
        Me.txtLastname.WatermarkText = "Lastname"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Location = New System.Drawing.Point(224, 63)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(204, 29)
        Me.txtMiddlename.TabIndex = 2
        Me.txtMiddlename.WatermarkColor = System.Drawing.Color.Gray
        Me.txtMiddlename.WatermarkText = "Middlename"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(6, 63)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(212, 29)
        Me.txtFirstname.TabIndex = 1
        Me.txtFirstname.WatermarkColor = System.Drawing.Color.Gray
        Me.txtFirstname.WatermarkText = "Firstname"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(6, 28)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(422, 29)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.WatermarkColor = System.Drawing.Color.Gray
        Me.txtUsername.WatermarkText = "Username"
        '
        'txtFailedAttemp
        '
        Me.txtFailedAttemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFailedAttemp.Location = New System.Drawing.Point(9, 200)
        Me.txtFailedAttemp.Name = "txtFailedAttemp"
        Me.txtFailedAttemp.Size = New System.Drawing.Size(378, 26)
        Me.txtFailedAttemp.TabIndex = 5
        Me.txtFailedAttemp.WatermarkColor = System.Drawing.Color.Gray
        Me.txtFailedAttemp.WatermarkText = "Enter # of failed attemp"
        '
        'txtPasswordAge
        '
        Me.txtPasswordAge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordAge.Location = New System.Drawing.Point(6, 139)
        Me.txtPasswordAge.Name = "txtPasswordAge"
        Me.txtPasswordAge.Size = New System.Drawing.Size(378, 26)
        Me.txtPasswordAge.TabIndex = 3
        Me.txtPasswordAge.WatermarkColor = System.Drawing.Color.Gray
        Me.txtPasswordAge.WatermarkText = "Enter number of days account age expiration"
        '
        'txtAddDays
        '
        Me.txtAddDays.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddDays.Location = New System.Drawing.Point(6, 70)
        Me.txtAddDays.Name = "txtAddDays"
        Me.txtAddDays.Size = New System.Drawing.Size(378, 26)
        Me.txtAddDays.TabIndex = 1
        Me.txtAddDays.WatermarkColor = System.Drawing.Color.Gray
        Me.txtAddDays.WatermarkText = "Enter number of days to Inactive user"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(61, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(657, 22)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSearch.WatermarkText = "Search . . ."
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 526)
        Me.ContextMenuStrip = Me.CMS
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancell)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.tbControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        Me.tbControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgRulePrivilege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvUserList As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtBirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContactnumber As HBRS.watermark
    Friend WithEvents txtEmailaddress As HBRS.watermark
    Friend WithEvents chkShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents txtPasword1 As HBRS.watermark
    Friend WithEvents txtPassword As HBRS.watermark
    Friend WithEvents txtLastname As HBRS.watermark
    Friend WithEvents txtMiddlename As HBRS.watermark
    Friend WithEvents txtFirstname As HBRS.watermark
    Friend WithEvents txtUsername As HBRS.watermark
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgRulePrivilege As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFailedAttemp As System.Windows.Forms.CheckBox
    Friend WithEvents chkPasswrdAge As System.Windows.Forms.CheckBox
    Friend WithEvents ChkInactivateUser As System.Windows.Forms.CheckBox
    Friend WithEvents txtFailedAttemp As HBRS.watermark
    Friend WithEvents txtPasswordAge As HBRS.watermark
    Friend WithEvents CHKISEXPIRED As System.Windows.Forms.CheckBox
    Friend WithEvents txtAddDays As HBRS.watermark
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtSearch As HBRS.watermark
    Friend WithEvents lvALL_USER_LIST As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancell As System.Windows.Forms.Button
    Friend WithEvents btnCreateAccount As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lblUserType As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
