Public Class frmRoomList
    Friend GetRoom As Room
    Dim fromOtherForm As Boolean = False
    Dim frmOrig As formSwitch.FormName

    Private Sub frmRoomListMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadRoom()
    End Sub

    Private Sub LoadRoom(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mysql As String
        If str <> "" Then
            mysql = "Select * From tblRoom Where RoomNum = '" & secured_str & "' OR Upper(RoomType) like Upper('%" & secured_str & "%')"
        Else
            mysql = "Select * From tblRoom"
        End If
        Dim ds As DataSet = LoadSQL(mysql, "tblRoom")

        For Each dr In ds.Tables(0).Rows
            Additem(dr)
        Next
    End Sub

    Private Sub Additem(ByVal dr As DataRow)
        Dim lv As ListViewItem = lvRoom.Items.Add(dr.Item("ID"))
        With dr
            lv.SubItems.Add(.Item("RoomNum"))
            lv.SubItems.Add(.Item("RoomType"))
            lv.SubItems.Add(.Item("RoomRate"))
            lv.SubItems.Add(.Item("Capacity"))
            lv.SubItems.Add(.Item("Status"))
        End With
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadRoom(txtSearch.Text)
    End Sub

    Private Sub lvRoom_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRoom.DoubleClick
        If lvRoom.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = CInt(lvRoom.FocusedItem.Text)
        GetRoom = New Room
        With GetRoom
            .ID = idx
            .LoadRoom()
        End With

        formSwitch.ReloadFormRoom(frmOrig, GetRoom)
        Me.Close()
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If isEnter(e) Then
            btnSearch.PerformClick()
        End If
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As formSwitch.FormName)
        fromOtherForm = True
        txtSearch.Text = src
        frmOrig = frmOrigin
    End Sub
End Class