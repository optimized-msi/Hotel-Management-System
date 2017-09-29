Public Class frmAddressList
    Dim fromOtherForm As Boolean = False
    Friend GetAddress As Address
    Dim frmOrig As formSwitch.FormName

    Private Sub LoadAddress(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mysql As String
        If str <> "" Then
            mysql = "Select * From tblAddress Where Upper(City) Like Upper('%" & secured_str & "%') Or Upper(Province) Like Upper('%" & secured_str & "%') OR "
            mysql &= "Upper(Barangay) Like Upper('%" & secured_str & "%') OR Upper(Street) Like Upper('%" & secured_str & "%')"
        Else
            mysql = "Select First 10 * From tblAddress"
        End If
        Dim ds As DataSet = LoadSQL(mysql, "tblAddress")

        For Each dr In ds.Tables(0).Rows
            AddItem(dr)
        Next
    End Sub

    Private Sub AddItem(ByVal dr As DataRow)
        Dim lv As ListViewItem = lvAddress.Items.Add(dr.Item("ID"))
        With dr
            lv.SubItems.Add(.Item("Street").ToString)
            lv.SubItems.Add(.Item("Barangay").ToString)
            lv.SubItems.Add(.Item("Province").ToString)
            lv.SubItems.Add(.Item("City").ToString)
        End With

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadAddress(txtSearch.Text)
    End Sub

    Private Sub lvAddress_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAddress.DoubleClick
        If lvAddress.Items.Count = 0 Then Exit Sub

        Dim idx As Integer = CInt(lvAddress.FocusedItem.Text)
        GetAddress = New Address
        With GetAddress
            .ID = idx
            .LoadAddress()
        End With

        formSwitch.ReloadFormAddress(frmOrig, GetAddress)
        Me.Close()
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As formSwitch.FormName)
        fromOtherForm = True
        txtSearch.Text = src
        frmOrig = frmOrigin
    End Sub

    Private Sub frmAddressList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAddress()
    End Sub
End Class