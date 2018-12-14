Public Class Commune

    Private _id As Integer
    Private _nom As String
    Private _latitude As Double
    Private _longitude As Double

    Public Sub New(ByVal id, ByVal nom, ByVal latitude, ByVal longitude)
        _id = id
        _nom = nom
        _latitude = latitude
        _longitude = longitude
    End Sub

    Public Sub New(ByVal str As DataRow)
        _id = str("CODE_COMMUNE")
        _nom = str("NOM_COMMUNE")
        _latitude = str("LAT_COMMUNE")
        _longitude = str("LONG_COMMUNE")
    End Sub


    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

End Class