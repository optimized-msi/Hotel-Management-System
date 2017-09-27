﻿Public Class Guest
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

    Private _suffix As String
    Public Property Suffix() As String
        Get
            Return _suffix
        End Get
        Set(ByVal value As String)
            _suffix = value
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

    Private _contactNum As String
    Public Property CantactNum() As String
        Get
            Return _contactNum
        End Get
        Set(ByVal value As String)
            _contactNum = value
        End Set
    End Property

#End Region

#Region "Procedures"
    Friend Sub SaveGuest()
        Dim mysql As String = "Select * From tblCustomer Where FirstName = '" & _firstName & "' And MiddleName = '" & _middleName & "' And LastName = '" & _lastName & "'"
        Dim ds As DataSet = LoadSQL(mysql, "tblCustomer")

        If ds.Tables(0).Rows.Count > 0 Then
            With ds.Tables(0).Rows(0)
                .Item("FirstName") = _firstName
                .Item("MiddleName") = _middleName
                .Item("LastName") = _lastName
                .Item("AddressID") = _address.ID
                .Item("ContactNum") = _contactNum
            End With
            SaveEntry(ds)
        Else

            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("tblCustomer").NewRow
            With dsNewRow
                .Item("FirstName") = _firstName
                .Item("MiddleName") = _middleName
                .Item("LastName") = _lastName
                .Item("AddressID") = _address.ID
                .Item("ContactNum") = _contactNum
            End With
            ds.Tables("tblCustomer").Rows.Add(dsNewRow)
            SaveEntry(ds, True)
        End If
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

            _contactNum = .Item("ContactNum")
        End With
    End Sub
#End Region
End Class
