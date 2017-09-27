Public Class frmGuestList
    Dim fromOtherForm As Boolean = False
    Friend GetCustomer As Guest
    Dim frmOrig As formSwitch.FormName

    Private Sub frmSelectGuest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGuest()
    End Sub

    Private Sub LoadGuest(Optional ByVal str As String = "")
        Dim secured_str As String = str
        secured_str = DreadKnight(secured_str)
        Dim mySql As String, name As String
        Dim strWords As String() = secured_str.Split(New Char() {" "c})

        If str <> "" Then
            mySql = "Select C.ID, C.FirstName, C.MiddleName, C.Lastname, "
            mySql &= "A.City '| |' A.Province '| |' A.Barangay '| |' A.Subdivision '| |' A.Purok '| |' A.Street as Address "
            mySql &= "From tblCustomer C "
            mySql &= "Inner Join tblAddress A On A.ID = C.AddressID "

            For Each name In strWords

                mySql &= vbCr & " UPPER(FirstName '| |' LastName) LIKE UPPER('%" & name & "%') and "
                If name Is strWords.Last Then
                    mySql &= vbCr & " UPPER(LastName '| |' FirstName) LIKE UPPER('%" & name & "%') "
                    Exit For
                End If

            Next
        Else
            mySql = "Select First 10 C.ID, C.FirstName, C.MiddleName, C.LastName, "
            mySql &= "A.City '| |' A.Province '| |' A.Barangay '| |' A.Subdivision '| |' A.Purok '| |' A.Street as Address "
            mySql &= "From tblCustomer C "
            mySql &= "Inner Join tblAddress A On A.ID = C.AddressID "
        End If

        Dim ds As DataSet = LoadSQL(mySql, "tblCustomer")

        For Each dr In ds.Tables(0).Rows
            Additem(dr)
        Next
    End Sub

    Private Sub Additem(ByVal dr As DataRow)
        Dim lv As ListViewItem = lvGuest.Items.Add(dr.Item("ID"))
        With dr
            lv.SubItems.Add(.Item("FirstName") & " " & .Item("LastName"))
            lv.SubItems.Add(.Item("Address"))
        End With
    End Sub

    Private Sub lvGuest_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvGuest.DoubleClick
        If lvGuest.Items.Count = 0 Then Exit Sub


        Dim idx As Integer = CInt(lvGuest.FocusedItem.Text)
        GetCustomer = New Guest
        With GetCustomer
            .ID = idx
            .LoadGuest()
        End With

        formSwitch.ReloadFormGuest(frmOrig, GetCustomer)
        Me.Close()
    End Sub

    Friend Sub SearchSelect(ByVal src As String, ByVal frmOrigin As formSwitch.FormName)
        fromOtherForm = True
        txtSearch.Text = src
        frmOrig = frmOrigin
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        LoadGuest(txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        frmGuest.Show()
    End Sub
End Class