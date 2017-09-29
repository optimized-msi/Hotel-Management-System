Public Class frmSetup
    Private HotelRoom As Room
    Private RegAddress As Address
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
            mysql = "Select * From tblRoom Order by ID Desc"
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
        ClearRoom()
        LoadRoom()

        ClearAddress()
        LoadAddress()
        LoadAddressCity()
        LoadAddressProvince()
        LoadAddressBarangay()
        LoadAddressStreet()

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
        LoadRoomData(HotelRoom)
    End Sub

    Private Sub LoadRoomData(ByVal tmpRoom As Room)
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

    Private Sub btnSaveAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAddress.Click
        If Not isAddressValid() Then Exit Sub

        If btnSaveAddress.Text = "Save Address" Then
            RegAddress = New Address
            With RegAddress
                .City = cboCity.Text
                .Province = cboProvince.Text
                .Barangay = cboBarangay.Text
                .Street = cboStreet.Text
                .SaveAddress()
            End With
        Else
            With RegAddress
                .City = cboCity.Text
                .Province = cboProvince.Text
                .Barangay = cboBarangay.Text
                .Street = cboStreet.Text
                .SaveAddress()
            End With
        End If
        MsgBox(IIf(btnSaveAddress.Text = "Save Address", "Added New Address", "Address Updated"), MsgBoxStyle.Information, "Hotel Management")
        LoadAddress()
    End Sub

    Private Sub LoadAddress(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mysql As String
        If str <> "" Then
            mysql = "Select * From tblAddress Where Upper(City) Like Upper('%" & secured_str & "%') Or Upper(Province) Like Upper('%" & secured_str & "%') "
            mysql &= "Or Upper(Barangay) Like Upper('%" & secured_str & "%') Or Upper(Street) Like Upper('%" & secured_str & "%')"
        Else
            mysql = "Select First 10 * From tblAddress Order By ID Desc"
        End If

        Dim ds As DataSet = LoadSQL(mysql, "tblAddress")

        For Each dr In ds.Tables(0).Rows
            AddItemAddress(dr)
        Next
    End Sub

    Private Sub AddItemAddress(ByVal dr As DataRow)
        Dim lv As ListViewItem = lvAddress.Items.Add(dr.Item("ID"))
        With dr
            lv.SubItems.Add(.Item("City"))
            lv.SubItems.Add(.Item("Province").ToString)
            lv.SubItems.Add(.Item("Barangay").ToString)
            lv.SubItems.Add(.Item("Street").ToString)
        End With

    End Sub

    Private Function isAddressValid() As Boolean
        If cboCity.Text = "" Then Return False
        If cboProvince.Text = "" Then Return False
        If cboBarangay.Text = "" Then Return False
        If cboStreet.Text = "" Then Return False

        Return True
    End Function

    Private Sub ClearAddress()
        cboCity.Text = ""
        cboProvince.Text = ""
        cboBarangay.Text = ""
        cboStreet.Text = ""

        lvAddress.Items.Clear()
    End Sub

    Private Sub lvAddress_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAddress.DoubleClick
        If lvAddress.SelectedItems.Count = 0 Then Exit Sub

        Dim idx As Integer = lvAddress.FocusedItem.Text
        RegAddress = New Address
        RegAddress.ID = idx
        RegAddress.LoadAddress()
        LoadAddressData(RegAddress)
    End Sub

    Private Sub LoadAddressData(ByVal AddressInfo As Address)
        With AddressInfo
            cboCity.Text = .City
            cboProvince.Text = .Province
            cboBarangay.Text = .Barangay
            cboStreet.Text = .Street
        End With
        RegAddress = AddressInfo
    End Sub

    Private Function DistinctAddress(ByVal str As String) As DataSet
        Dim mysql As String = "Select DISTINCT(" & str & ") From tblAddress"
        Dim ds As DataSet = LoadSQL(mysql, "tblAddress")

        Return ds
    End Function

    Private Sub LoadAddressCity()
        Dim ds As DataSet = DistinctAddress("City")
        cboBarangay.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            If Not IsDBNull(dr.item("City")) Then cboCity.Items.Add(dr.item("City").ToString)
        Next
    End Sub

    Private Sub LoadAddressProvince()
        Dim ds As DataSet = DistinctAddress("Province")
        cboProvince.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            If Not IsDBNull(dr.item("Province")) Then cboProvince.Items.Add(dr.item("Province").ToString)
        Next
    End Sub

    Private Sub LoadAddressBarangay()
        Dim ds As DataSet = DistinctAddress("Barangay")
        cboBarangay.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            If Not IsDBNull(dr.item("Barangay")) Then cboBarangay.Items.Add(dr.item("Barangay").ToString)
        Next
    End Sub

    Private Sub LoadAddressStreet()
        Dim ds As DataSet = DistinctAddress("Street")
        cboStreet.Items.Clear()

        For Each dr In ds.Tables(0).Rows
            If Not IsDBNull(dr.item("Street")) Then cboStreet.Items.Add(dr.item("Street").ToString)
        Next
    End Sub
End Class