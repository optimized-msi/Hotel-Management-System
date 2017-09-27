Public Class frmSetup
    Private HotelRoom As Room
    Private Sub txtRoomRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoomRate.KeyPress
        DigitOnly(e)
    End Sub

    Private Sub btnSaveRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRoom.Click
        If Not isRoomValid() Then Exit Sub

        HotelRoom = New Room
        With HotelRoom
            .RoomNum = txtRoomNum.Text
            .RoomType = cboRoomType.Text
            .RoomRate = txtRoomRate.Text
            .Capacity = nudCapacity.Text
            If cboStatus.Visible = False Then
                .Status = "Available"
            Else
                .Status = cboStatus.Text
            End If
            .SaveRoom()
        End With
        MsgBox("Room " & txtRoomNum.Text & " Added", MsgBoxStyle.Information, "Hotel Management")
        LoadRoom()
    End Sub

    Private Function isRoomValid() As Boolean
        If txtRoomNum.Text = "" Then Return False
        If cboRoomType.Text = "" Then Return False
        If txtRoomRate.Text = "" Then Return False
        If nudCapacity.Text = 0 Then Return False

        Return True
    End Function

    Private Sub ClearRoom()
        txtRoomNum.Clear()
        txtRoomRate.Clear()
        cboRoomType.Text = ""
        nudCapacity.Text = 0
    End Sub

    Private Sub LoadRoom(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mysql As String
        If str <> "" Then
            mysql = "Select * From tblRoom Where Upper(RoomNum) = Upper('" & secured_str & "')"
        Else
            mysql = "Select * From tblRoom"
        End If
        Dim ds As DataSet = LoadSQL(mysql, "tblRoom")

        lvRoom.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            AddRoomItem(dr)
        Next
    End Sub

    Private Sub AddRoomItem(ByVal dr As DataRow)
        Dim lv As ListViewItem = lvRoom.Items.Add(dr.Item("ID"))
        With dr
            lv.SubItems.Add(.Item("RoomNum"))
            lv.SubItems.Add(.Item("RoomType"))
            lv.SubItems.Add(.Item("RoomRate"))
            lv.SubItems.Add(.Item("Capacity"))
            lv.SubItems.Add(.Item("Status"))
        End With

    End Sub

    Private Sub frmSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRoom()
    End Sub

    Private Sub txtSearchRoom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearchRoom.KeyPress
        If isEnter(e) Then
            btnSearchRoom.PerformClick()
        End If
    End Sub

    Private Sub lvRoom_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRoom.DoubleClick
        If lvRoom.SelectedItems.Count = 0 Then Exit Sub

        Dim idx As Integer = lvRoom.FocusedItem.Text
        HotelRoom = New Room
        With HotelRoom
            .ID = idx
            .LoadRoom()
        End With
        LoadRoom(HotelRoom)
    End Sub

    Private Sub LoadRoom(ByVal tmpRoom As Room)
        With tmpRoom
            txtRoomNum.Text = .RoomNum
            cboRoomType.Text = .RoomType
            txtRoomRate.Text = .RoomRate
            nudCapacity.Value = .Capacity
            cboStatus.Text = .Status
        End With
        txtRoomNum.ReadOnly = True
        cboStatus.Visible = True
        lblStatus.Visible = True
    End Sub

    Private Sub btnSearchRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRoom.Click
        LoadRoom(txtSearchRoom.Text)
    End Sub
End Class