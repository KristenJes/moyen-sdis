Public Class TypeEngin

    Private _id As Integer
    Private _nom As String
    Private _nbPlace As Integer


    Public Sub New(ByVal id, ByVal nom, ByVal nbPlace)
        _id = id
        _nom = nom
        _nbPlace = nbPlace
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property nbPlace As Integer
        Get
            Return _nbPlace
        End Get
        Set(ByVal value As Integer)
            _nbPlace = value
        End Set
    End Property



End Class