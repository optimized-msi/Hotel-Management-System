<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearchRoom = New System.Windows.Forms.Button()
        Me.txtSearchRoom = New System.Windows.Forms.TextBox()
        Me.lvRoom = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.nudCapacity = New System.Windows.Forms.NumericUpDown()
        Me.btnSaveRoom = New System.Windows.Forms.Button()
        Me.cboRoomType = New System.Windows.Forms.ComboBox()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoomNum = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSearchAddress = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCity = New System.Windows.Forms.ComboBox()
        Me.cboProvince = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboBarangay = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboStreet = New System.Windows.Forms.ComboBox()
        Me.btnSaveAddress = New System.Windows.Forms.Button()
        Me.lvAddress = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(835, 395)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.lvRoom)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(827, 369)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ROOM"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchRoom)
        Me.GroupBox2.Controls.Add(Me.txtSearchRoom)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(814, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'btnSearchRoom
        '
        Me.btnSearchRoom.Location = New System.Drawing.Point(727, 14)
        Me.btnSearchRoom.Name = "btnSearchRoom"
        Me.btnSearchRoom.Size = New System.Drawing.Size(81, 29)
        Me.btnSearchRoom.TabIndex = 7
        Me.btnSearchRoom.Text = "S&earch"
        Me.btnSearchRoom.UseVisualStyleBackColor = True
        '
        'txtSearchRoom
        '
        Me.txtSearchRoom.Location = New System.Drawing.Point(10, 19)
        Me.txtSearchRoom.Name = "txtSearchRoom"
        Me.txtSearchRoom.Size = New System.Drawing.Size(711, 20)
        Me.txtSearchRoom.TabIndex = 0
        '
        'lvRoom
        '
        Me.lvRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvRoom.FullRowSelect = True
        Me.lvRoom.GridLines = True
        Me.lvRoom.Location = New System.Drawing.Point(270, 64)
        Me.lvRoom.Name = "lvRoom"
        Me.lvRoom.Size = New System.Drawing.Size(551, 299)
        Me.lvRoom.TabIndex = 1
        Me.lvRoom.UseCompatibleStateImageBehavior = False
        Me.lvRoom.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 42
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room Number"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room Type"
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Room Rate"
        Me.ColumnHeader4.Width = 75
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Capacity"
        Me.ColumnHeader5.Width = 128
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.nudCapacity)
        Me.GroupBox1.Controls.Add(Me.btnSaveRoom)
        Me.GroupBox1.Controls.Add(Me.cboRoomType)
        Me.GroupBox1.Controls.Add(Me.txtRoomRate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRoomNum)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 234)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.cboStatus.Location = New System.Drawing.Point(111, 152)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(141, 21)
        Me.cboStatus.TabIndex = 8
        Me.cboStatus.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(7, 155)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status"
        Me.lblStatus.Visible = False
        '
        'nudCapacity
        '
        Me.nudCapacity.Location = New System.Drawing.Point(111, 115)
        Me.nudCapacity.Name = "nudCapacity"
        Me.nudCapacity.Size = New System.Drawing.Size(141, 20)
        Me.nudCapacity.TabIndex = 1
        '
        'btnSaveRoom
        '
        Me.btnSaveRoom.Location = New System.Drawing.Point(171, 184)
        Me.btnSaveRoom.Name = "btnSaveRoom"
        Me.btnSaveRoom.Size = New System.Drawing.Size(81, 29)
        Me.btnSaveRoom.TabIndex = 1
        Me.btnSaveRoom.Text = "&Save"
        Me.btnSaveRoom.UseVisualStyleBackColor = True
        '
        'cboRoomType
        '
        Me.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Items.AddRange(New Object() {"Regular", "Semi Special", "Special", "Suite"})
        Me.cboRoomType.Location = New System.Drawing.Point(111, 47)
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(141, 21)
        Me.cboRoomType.TabIndex = 1
        '
        'txtRoomRate
        '
        Me.txtRoomRate.Location = New System.Drawing.Point(111, 80)
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.Size = New System.Drawing.Size(141, 20)
        Me.txtRoomRate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Capacity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Room Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room Number"
        '
        'txtRoomNum
        '
        Me.txtRoomNum.Location = New System.Drawing.Point(111, 19)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.Size = New System.Drawing.Size(141, 20)
        Me.txtRoomNum.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvAddress)
        Me.TabPage2.Controls.Add(Me.btnSaveAddress)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(827, 369)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ADDRESS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSearchAddress)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(814, 52)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'btnSearchAddress
        '
        Me.btnSearchAddress.Location = New System.Drawing.Point(727, 14)
        Me.btnSearchAddress.Name = "btnSearchAddress"
        Me.btnSearchAddress.Size = New System.Drawing.Size(81, 29)
        Me.btnSearchAddress.TabIndex = 7
        Me.btnSearchAddress.Text = "S&earch"
        Me.btnSearchAddress.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(711, 20)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cboStreet)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cboBarangay)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.cboProvince)
        Me.GroupBox4.Controls.Add(Me.cboCity)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(357, 254)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "City"
        '
        'cboCity
        '
        Me.cboCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCity.FormattingEnabled = True
        Me.cboCity.Location = New System.Drawing.Point(3, 19)
        Me.cboCity.Name = "cboCity"
        Me.cboCity.Size = New System.Drawing.Size(348, 26)
        Me.cboCity.TabIndex = 2
        Me.cboCity.Text = "General Santos City"
        '
        'cboProvince
        '
        Me.cboProvince.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(3, 80)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(348, 26)
        Me.cboProvince.TabIndex = 3
        Me.cboProvince.Text = "South Cotabato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(137, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Province"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Barangay"
        '
        'cboBarangay
        '
        Me.cboBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBarangay.FormattingEnabled = True
        Me.cboBarangay.Location = New System.Drawing.Point(3, 138)
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(348, 26)
        Me.cboBarangay.TabIndex = 5
        Me.cboBarangay.Text = "Lagao"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(137, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Street"
        '
        'cboStreet
        '
        Me.cboStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStreet.FormattingEnabled = True
        Me.cboStreet.Location = New System.Drawing.Point(3, 194)
        Me.cboStreet.Name = "cboStreet"
        Me.cboStreet.Size = New System.Drawing.Size(348, 26)
        Me.cboStreet.TabIndex = 7
        Me.cboStreet.Text = "Purok Atcheche"
        '
        'btnSaveAddress
        '
        Me.btnSaveAddress.Location = New System.Drawing.Point(259, 324)
        Me.btnSaveAddress.Name = "btnSaveAddress"
        Me.btnSaveAddress.Size = New System.Drawing.Size(95, 29)
        Me.btnSaveAddress.TabIndex = 8
        Me.btnSaveAddress.Text = "Save Address"
        Me.btnSaveAddress.UseVisualStyleBackColor = True
        '
        'lvAddress
        '
        Me.lvAddress.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvAddress.FullRowSelect = True
        Me.lvAddress.GridLines = True
        Me.lvAddress.Location = New System.Drawing.Point(366, 64)
        Me.lvAddress.Name = "lvAddress"
        Me.lvAddress.Size = New System.Drawing.Size(451, 299)
        Me.lvAddress.TabIndex = 9
        Me.lvAddress.UseCompatibleStateImageBehavior = False
        Me.lvAddress.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 36
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "City"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Province"
        Me.ColumnHeader9.Width = 105
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Barangay"
        Me.ColumnHeader10.Width = 105
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Street"
        Me.ColumnHeader11.Width = 104
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 402)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmSetup"
        Me.Text = "Setup Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveRoom As System.Windows.Forms.Button
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents txtRoomRate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNum As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvRoom As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents nudCapacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchRoom As System.Windows.Forms.Button
    Friend WithEvents txtSearchRoom As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents cboCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchAddress As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveAddress As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboStreet As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboBarangay As System.Windows.Forms.ComboBox
    Friend WithEvents lvAddress As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
End Class
