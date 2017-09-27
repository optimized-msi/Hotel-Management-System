Public Class frmGuest
    Private GuestAddress As Address
    Private GuestInfo As Guest

    Private Sub btnBrowseAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseAddress.Click
        Dim secured_str As String = txtCity.Text
        secured_str = DreadKnight(secured_str)
        frmGuestList.SearchSelect(secured_str, FormName.Transaction)
        frmGuestList.Show()
    End Sub

    Private Sub frmGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearText()
    End Sub

    Friend Sub LoadAddress(ByVal tmpAddress As Address)
        With tmpAddress
            txtCity.Text = .City
            txtProvince.Text = .Province
            txtBarangay.Text = .Barangay
            txtSreet.Text = .Street
        End With

        GuestAddress = New Address
        GuestAddress = tmpAddress
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not isGuestValid() Then Exit Sub

        GuestInfo = New Guest
        With GuestInfo
            .FirstName = txtFirstName.Text
            .MiddleName = txtMiddleName.Text
            .LastName = txtLastName.Text
            .CantactNum = mtbContactNum.Text
            .Address = GuestAddress
            .SaveGuest()
        End With

        MsgBox("Guest Added", MsgBoxStyle.Information, "Hotel Management")
        Me.Close()
    End Sub

    Private Function isGuestValid() As Boolean
        If txtFirstName.Text = "" Then Return False
        If txtLastName.Text = "" Then Return False
        If GuestAddress Is Nothing Then Return False

        Return True
    End Function

    Private Sub ClearText()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        mtbContactNum.Clear()
        txtCity.Clear()
        txtBarangay.Clear()
        txtProvince.Clear()
        txtSreet.Clear()
    End Sub
End Class