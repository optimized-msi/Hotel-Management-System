Public Class Address
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

    Private _city As String
    Public Property City() As String
        Get
            Return _city
        End Get
        Set(ByVal value As String)
            _city = value
        End Set
    End Property

    Private _province As String
    Public Property Province() As String
        Get
            Return _province
        End Get
        Set(ByVal value As String)
            _province = value
        End Set
    End Property

    Private _municipal As String
    Public Property Municipal() As String
        Get
            Return _municipal
        End Get
        Set(ByVal value As String)
            _municipal = value
        End Set
    End Property

    Private _barangay As String
    Public Property Barangay() As String
        Get
            Return _barangay
        End Get
        Set(ByVal value As String)
            _barangay = value
        End Set
    End Property

    Private _subdivision As String
    Public Property Subdivision() As String
        Get
            Return _subdivision
        End Get
        Set(ByVal value As String)
            _subdivision = value
        End Set
    End Property

    Private _purok As String
    Public Property Purok() As String
        Get
            Return _purok
        End Get
        Set(ByVal value As String)
            _purok = value
        End Set
    End Property

    Private _street As String
    Public Property Street() As String
        Get
            Return _street
        End Get
        Set(ByVal value As String)
            _street = value
        End Set
    End Property

#End Region

#Region "Procedures"
    Friend Sub SaveAddress()
        Dim mysql As String = "Select * From tblAddress Where ID = " & _id
        Dim ds As DataSet = LoadSQL(mysql, "tblAddress")
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("tblAddress").NewRow
        With dsNewRow
            .Item("City") = _city
            .Item("Province") = _province
            .Item("Municipal") = _municipal
            .Item("Barangay") = _barangay
            .Item("Subdivision") = _subdivision
            .Item("Purok") = _purok
            .Item("Street") = _street
        End With
        ds.Tables("tblAddress").Rows.Add(dsNewRow)
        SaveEntry(ds, True)
    End Sub

    Friend Sub LoadAddress()
        Dim mysql As String = "Select * From tblAddress Where ID = " & _id
        Dim ds As DataSet = LoadSQL(mysql, "tblAddress")

        For Each dr In ds.Tables(0).Rows
            LoadbyRows(dr)
        Next
    End Sub

    Private Sub LoadbyRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _city = .Item("City")
            If Not IsDBNull(.Item("Province")) Then _province = .Item("Province")
            If Not IsDBNull(.Item("Municipal")) Then _municipal = .Item("Municipal")
            If Not IsDBNull(.Item("Barangay")) Then _barangay = .Item("Barangay")
            If Not IsDBNull(.Item("Subdivision")) Then _subdivision = .Item("Subdivision")
            If Not IsDBNull(.Item("Purok")) Then _purok = .Item("Purok")
            If Not IsDBNull(.Item("Street")) Then _street = .Item("Street")

        End With
    End Sub
#End Region
End Class
