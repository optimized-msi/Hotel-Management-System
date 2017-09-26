Public Class Guest
#Region "Properties"
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Private _middleName As String
    Public Property MiddleName() As String
        Get
            Return _middleName
        End Get
        Set(ByVal value As String)
            _middleName = value
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Private _address As New Address
    Public Property Address() As Address
        Get
            Return _address
        End Get
        Set(ByVal value As Address)
            _address = value
        End Set
    End Property

#End Region

#Region "Procedures"
    Friend Sub SaveGuest()
        Dim mysql As String = "Select * From tblCustomer"
        Dim ds As DataSet = LoadSQL(mysql, "tblCustomer")
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("tblCustomer").NewRow
        With dsNewRow
            .Item("FirstName") = _firstName
            .Item("MiddleName") = _middleName
            .Item("LastName") = _lastName
            .Item("AddressID") = _address.ID
        End With
        ds.Tables("tblCustomer").Rows.Add(dsNewRow)
        database.SaveEntry(ds, True)
    End Sub

    Friend Sub LoadGuest()
        Dim mysql As String = "Select * From tblCustomer Where ID = " & _id
        Dim ds As DataSet = LoadSQL(mysql, "tblCustomer")

        For Each dr In ds.Tables(0).Rows
            LoadbyRows(dr)
        Next
    End Sub

    Private Sub LoadbyRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _firstName = .Item("FirstName")
            _middleName = .Item("MiddleName")
            _lastName = .Item("LastName")
            '_address = .Item("AddressID")

            Dim tmpAddress As New Address
            tmpAddress.ID = .Item("AddressID")
            tmpAddress.LoadAddress()
            _address = tmpAddress
        End With
    End Sub
#End Region
End Class
