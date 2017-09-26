Public Class frmTransaction
    Private HotelGuest As Guest
    Private HotelRoom As Room
    Private HotelTransaction As Transaction

    Private Sub btnCheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckIn.Click
        HotelTransaction = New Transaction
        With HotelTransaction
            .Customer = HotelGuest
            .Room = HotelRoom
            .ReserveDate = ""
            .CheckInDate = dtpCheckIn.Value
            .CheckOutDate = dtpCheckOut.Value
            .ChildCount = txtChildren.Text
            .AdultCount = txtAdults.Text
            .CashAdvance = txtAdvance.Text
            .Discount = cboDiscount.Text
            .Status = ""
            .TotalAmount = ""
            .SaveTransaction()
        End With

        MsgBox(HotelGuest.FirstName & " " & HotelGuest.LastName & " Check In", MsgBoxStyle.Information, "Hotel Management")
    End Sub

    Private Sub btnSubAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubAdult.Click
        txtAdults.Text = Val(txtAdults.Text) - 1
    End Sub

    Private Sub btnAddAdult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAdult.Click
        txtAdults.Text = Val(txtAdults.Text) + 1
    End Sub

    Private Sub btnSubChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubChildren.Click
        txtChildren.Text = Val(txtChildren.Text) - 1
    End Sub

    Private Sub btnAddChildren_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChildren.Click
        txtChildren.Text = Val(txtChildren.Text) + 1
    End Sub

    Private Sub LoadTransaction(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mySql As String, name As String
        Dim strWords As String() = secured_str.Split(New Char() {" "c})
        If str <> "" Then
            mySql = "Select T.CheckInDate, C.FIRSTNAME || ' ' || C.LASTNAME || ' ' || 	"
            mySql &= "CASE WHEN C.SUFFIX is Null THEN '' ELSE C.SUFFIX END AS FullName, "
            mySql &= "T.CheckOutDate, T.CashAdvance, T.Status "
            mySql &= "From tblTransaction T "
            mySql &= "Inner Join tblCustomer C On C.ID = T.CustomerID "
            mySql &= "Where "

            For Each name In strWords

                mySql &= vbCr & " UPPER(FullName) LIKE UPPER('%" & name & "%') and "
                If name Is strWords.Last Then
                    mySql &= vbCr & " UPPER(FullName) LIKE UPPER('%" & name & "%') "
                    Exit For
                End If

            Next
        Else
            mySql = ""
        End If
        Dim ds As DataSet = LoadSQL(mySql, "tblTransaction")

        For Each dr In ds.Tables(0).Rows
            AddItem(dr)
        Next
    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        Dim lv As ListViewItem = lvTransaction.Items.Add(dr.Item("ID"))
        With dr
            lv.SubItems.Add(.Item("CheckInDate"))
            lv.SubItems.Add(.Item("FullName"))
            lv.SubItems.Add(.Item("CheckOutDate"))
            lv.SubItems.Add(.Item("CashAdvance"))
            lv.SubItems.Add(.Item("Balance"))
            lv.SubItems.Add(.Item("Status"))

        End With
    End Sub

    Private Sub ClearTextCheckIn()
        txtGuestName.Clear()
        txtRoomNumber.Clear()
        txtRoomRate.Clear()
        txtRoomType.Clear()
        dtpCheckIn.Value = Now
        dtpCheckOut.Value = Now
        txtDaysCount.Text = 0
        txtChildren.Text = 0
        txtAdults.Text = 0
        txtSubTotal.Clear()
        txtAdvance.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub ClearListView()
        lvTransaction.Items.Clear()
        txtSearch.Clear()
    End Sub

    Private Sub btnBrowseGuest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseGuest.Click
        Dim secured_str As String = txtGuestName.Text
        secured_str = DreadKnight(secured_str)
        frmGuestList.SearchSelect(secured_str, FormName.Transaction)
        frmGuestList.Show()
    End Sub

    Friend Sub LoadCustomer(ByVal tmpGuest As Guest)
        txtGuestName.Text = String.Format("{0} {1}" & IIf(tmpGuest.Suffix <> "", "," & tmpGuest.Suffix, ""), tmpGuest.FirstName, tmpGuest.LastName)
        'txtAddress.Text = String.Format("{0} {1} " + vbCrLf + "{2}", tmpGuest.Address.City, tmpGuest.Address.Barangay, tmpGuest.Address.Purok)

        HotelGuest = New Guest
        HotelGuest = tmpGuest
    End Sub

    Friend Sub LoadRoom(ByVal tmpRoom As Room)
        txtRoomNumber.Text = tmpRoom.RoomNum
        txtRoomType.Text = tmpRoom.RoomType
        txtRoomRate.Text = tmpRoom.RoomRate

        HotelRoom = New Room
        HotelRoom = tmpRoom
    End Sub

    Private Sub btnSearchRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRoom.Click
        Dim secured_str As String = txtRoomNumber.Text
        secured_str = DreadKnight(secured_str)
        frmGuestList.SearchSelect(secured_str, FormName.Transaction)
        frmGuestList.Show()
    End Sub

    Private Sub frmTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearListView()
        ClearTextCheckIn()
    End Sub
End Class