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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRoomNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRoomRate = New System.Windows.Forms.TextBox()
        Me.cboRoomType = New System.Windows.Forms.ComboBox()
        Me.btnSaveRoom = New System.Windows.Forms.Button()
        Me.lvRoom = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nudCapacity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearchRoom = New System.Windows.Forms.TextBox()
        Me.btnSearchRoom = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(827, 369)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DISCOUNT"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'txtRoomNum
        '
        Me.txtRoomNum.Location = New System.Drawing.Point(111, 19)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.Size = New System.Drawing.Size(141, 20)
        Me.txtRoomNum.TabIndex = 0
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room Type"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Capacity"
        '
        'txtRoomRate
        '
        Me.txtRoomRate.Location = New System.Drawing.Point(111, 80)
        Me.txtRoomRate.Name = "txtRoomRate"
        Me.txtRoomRate.Size = New System.Drawing.Size(141, 20)
        Me.txtRoomRate.TabIndex = 6
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
        'btnSaveRoom
        '
        Me.btnSaveRoom.Location = New System.Drawing.Point(171, 184)
        Me.btnSaveRoom.Name = "btnSaveRoom"
        Me.btnSaveRoom.Size = New System.Drawing.Size(81, 29)
        Me.btnSaveRoom.TabIndex = 1
        Me.btnSaveRoom.Text = "&Save"
        Me.btnSaveRoom.UseVisualStyleBackColor = True
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
        'nudCapacity
        '
        Me.nudCapacity.Location = New System.Drawing.Point(111, 115)
        Me.nudCapacity.Name = "nudCapacity"
        Me.nudCapacity.Size = New System.Drawing.Size(141, 20)
        Me.nudCapacity.TabIndex = 1
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
        'txtSearchRoom
        '
        Me.txtSearchRoom.Location = New System.Drawing.Point(10, 19)
        Me.txtSearchRoom.Name = "txtSearchRoom"
        Me.txtSearchRoom.Size = New System.Drawing.Size(711, 20)
        Me.txtSearchRoom.TabIndex = 0
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
End Class
