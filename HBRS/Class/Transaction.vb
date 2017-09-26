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

    Private _customerID As Integer
    Public Property CustomerID() As Integer
        Get
            Return _customerID
        End Get
        Set(ByVal value As Integer)
            _customerID = value
        End Set
    End Property

#End Region
End Class
