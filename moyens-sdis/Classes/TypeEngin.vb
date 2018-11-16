Public Class TypeEngin

    Private _typeEngId As Integer
    Private _nom As String
    Private _nbPlace As Integer



    Public Property typeEngId As Integer
        Get
            Return _typeEngId
        End Get
        Set(ByVal value As Integer)
            _typeEngId = value
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

    Public Property nom As Integer
        Get
            Return _nom
        End Get
        Set(ByVal value As Integer)
            _nom = value
        End Set
    End Property

End Class