Public Class Caserne

    Private _id As Integer
    Private _nom As String
    Private _latitude As String
    Private _longitude As String
    Private _engins As List(Of Engin)

    Public Sub New(ByVal id, ByVal nom, ByVal latitude, ByVal longitude, ByVal engins)
        _id = id
        _nom = nom
        _latitude = latitude
        _longitude = longitude
        _engins = engins
    End Sub

    Public Sub New(ByVal id, ByVal nom)
        _id = id
        _nom = nom
    End Sub


    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Latitude As Integer
        Get
            Return _latitude
        End Get
        Set(ByVal value As Integer)
            _latitude = value
        End Set
    End Property

    Public Property Longitude As Integer
        Get
            Return _longitude
        End Get
        Set(ByVal value As Integer)
            _longitude = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)

            _nom = value
        End Set
    End Property

    Public Property Engins As List(Of Engin)
        Get
            Return _engins

        End Get
        Set(ByVal value As List(Of Engin))

            _engins = value
        End Set
    End Property


    'Functions
    Public Sub addEngins(ByVal engin As Engin)
        Engins.Add(engin)
    End Sub

End Class