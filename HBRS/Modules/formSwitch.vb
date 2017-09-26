Module formSwitch
    
    Friend Enum FormName As Integer
        Transaction = 0
        Room = 1

    End Enum

    Friend Sub ReloadFormGuest(ByVal gotoForm As FormName, ByVal tmpGuest As Guest)
        Select Case gotoForm
            Case FormName.Transaction
                frmTransaction.LoadCustomer(tmpGuest)
        End Select

    End Sub

    Friend Sub ReloadFormRoom(ByVal gotoForm As FormName, ByVal tmpRoom As Room)
        Select Case gotoForm
            Case FormName.Room
                frmTransaction.LoadRoom(tmpRoom)
        End Select
    End Sub
End Module