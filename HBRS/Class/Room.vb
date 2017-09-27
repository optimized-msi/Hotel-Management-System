Public Class Room
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

    Private _roomNum As String
    Public Property RoomNum() As String
        Get
            Return _roomNum
        End Get
        Set(ByVal value As String)
            _roomNum = value
        End Set
    End Property

    Private _roomType As String
    Public Property RoomType() As String
        Get
            Return _roomType
        End Get
        Set(ByVal value As String)
            _roomType = value
        End Set
    End Property

    Private _RoomRate As Double
    Public Property RoomRate() As Double
        Get
            Return _RoomRate
        End Get
        Set(ByVal value As Double)
            _RoomRate = value
        End Set
    End Property

    Private _capacity As Integer
    Public Property Capacity() As Integer
        Get
            Return _capacity
        End Get
        Set(ByVal value As Integer)
            _capacity = value
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

#End Region

#Region "Procedures"

    Friend Sub SaveRoom()
        Dim mysql As String = "Select * From tblRoom Where RoomNum = '" & _roomNum & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblRoom")

        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("RoomType") = _roomType
                .Item("RoomRate") = _RoomRate
                .Item("Capacity") = _capacity
                .Item("Status") = _status
            End With
            SaveEntry(ds)
        Else
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("tblRoom").NewRow
            With dsNewRow
                .Item("RoomNum") = _roomNum
                .Item("RoomType") = _roomType
                .Item("RoomRate") = _RoomRate
                .Item("Capacity") = _capacity
                .Item("Status") = _status
            End With
            ds.Tables("tblRoom").Rows.Add(dsNewRow)
            SaveEntry(ds, True)
        End If
    End Sub
    Friend Sub LoadRoom()
        Dim mysql As String = "Select * From tblRoom Where ID =" & _id
        Dim ds As DataSet = LoadSQL(mysql, "tblRoom")

        For Each dr In ds.Tables(0).Rows
            LoadbyRows(dr)
        Next
    End Sub

    Private Sub LoadbyRows(ByVal dr As DataRow)
        With dr
            _id = .Item("ID")
            _roomNum = .Item("RoomNum")
            _roomType = .Item("RoomType")
            _RoomRate = .Item("RoomRate")
            _capacity = .Item("Capacity")
            _status = .Item("Status")
        End With
    End Sub
#End Region
End Class
