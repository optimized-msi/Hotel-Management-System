Public Class Transaction
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

    Private _customer As New Guest
    Public Property Customer() As Guest
        Get
            Return _customer
        End Get
        Set(ByVal value As Guest)
            _customer = value
        End Set
    End Property

    Private _hotelRoom As New Room
    Public Property Room() As Room
        Get
            Return _hotelRoom
        End Get
        Set(ByVal value As Room)
            _hotelRoom = value
        End Set
    End Property

    Private _reserveDate As Date
    Public Property ReserveDate() As Date
        Get
            Return _reserveDate
        End Get
        Set(ByVal value As Date)
            _reserveDate = value
        End Set
    End Property

    Private _checkInDate As Date
    Public Property CheckInDate() As Date
        Get
            Return _checkInDate
        End Get
        Set(ByVal value As Date)
            _checkInDate = value
        End Set
    End Property

    Private _checkOutDate As Date
    Public Property CheckOutDate() As Date
        Get
            Return _checkOutDate
        End Get
        Set(ByVal value As Date)
            _checkOutDate = value
        End Set
    End Property

    Private _childCount As Integer
    Public Property ChildCount() As Integer
        Get
            Return _childCount
        End Get
        Set(ByVal value As Integer)
            _childCount = value
        End Set
    End Property

    Private _adultCount As Integer
    Public Property AdultCount() As Integer
        Get
            Return _adultCount
        End Get
        Set(ByVal value As Integer)
            _adultCount = value
        End Set
    End Property

    Private _cashAdvance As Double
    Public Property CashAdvance() As Double
        Get
            Return _cashAdvance
        End Get
        Set(ByVal value As Double)
            _cashAdvance = value
        End Set
    End Property

    Private _discount As Double
    Public Property Discount() As Double
        Get
            Return _discount
        End Get
        Set(ByVal value As Double)
            _discount = value
        End Set
    End Property

    Private _status As String
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Private _totalAmount As Double
    Public Property TotalAmount() As Double
        Get
            Return _totalAmount
        End Get
        Set(ByVal value As Double)
            _totalAmount = value
        End Set
    End Property

#End Region

#Region "Procedures"
    Friend Sub SaveTransaction()
        Dim mysql As String = "Select * From tblTransaction Where ID = '" & _id & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblTransaction")
        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("RoomID") = _hotelRoom.ID
                .Item("ReserveDate") = _reserveDate
                .Item("CheckInDate") = _checkInDate
                .Item("CheckOutDate") = _checkOutDate
                .Item("ChildCount") = _childCount
                .Item("AdultCount") = _adultCount
                .Item("CashAdvance") = _cashAdvance
                .Item("Discount") = _discount
                .Item("Status") = _status
                .Item("TotalAmount") = _totalAmount
            End With
            SaveEntry(ds)
        Else

            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("tblTransaction").NewRow
            With dsNewRow
                .Item("CustomerID") = _customer.ID
                .Item("RoomID") = _hotelRoom.ID
                .Item("ReserveDate") = _reserveDate
                .Item("CheckInDate") = _checkInDate
                .Item("CheckOutDate") = _checkOutDate
                .Item("ChildCount") = _childCount
                .Item("AdultCount") = _adultCount
                .Item("CashAdvance") = _cashAdvance
                .Item("Discount") = _discount
                .Item("Status") = _status
                .Item("TotalAmount") = _totalAmount
            End With
            ds.Tables("tblTransaction").Rows.Add(dsNewRow)
            SaveEntry(ds, True)
        End If
    End Sub

    Friend Sub LoadTransaction()
        Dim mysql As String = "Select * From tblTransaction Where ID =" & _id
        Dim ds As DataSet = LoadSQL(mysql, "tblTransaction")

        For Each dr In ds.Tables(0).Rows
            LoadbyRows(dr)
        Next
    End Sub

    Private Sub LoadbyRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")

            Dim tmpCustomer As New Guest
            tmpCustomer.ID = .Item("CustomerID")
            tmpCustomer.LoadGuest()
            _customer = tmpCustomer

            Dim tmpRoom As New Room
            tmpRoom.ID = .Item("RoomID")
            tmpRoom.LoadRoom()
            _hotelRoom = tmpRoom

            _reserveDate = .Item("ReserveDate")
            _checkInDate = .Item("CheckInDate")
            _checkOutDate = .Item("CheckOutDate")
            _childCount = .Item("ChildCount")
            _adultCount = .Item("AdultCount")
            _cashAdvance = .Item("CashAdvance")
            _discount = .Item("Discount")
            _status = .Item("Status")
            _totalAmount = .Item("TotalAmount")
        End With
    End Sub
#End Region

End Class
