Public Class Service
    Private _serviceid As Integer
    Private _DispoID As Disponibilite
    Private _spMatricule As Pompier

    Public Property DispoID As Disponibilite
        Get
            Return _DispoID
        End Get
        Set(ByVal value As Disponibilite)
            _DispoID = value
        End Set
    End Property

    Public Property ServiceID As Integer
        Get
            Return _serviceid
        End Get
        Set(ByVal value As Integer)
            _serviceid = value
        End Set
    End Property

    Public Property SpMatricule As Pompier
        Get
            Return _spMatricule
        End Get
        Set(ByVal value As Pompier)
            _spMatricule = value
        End Set
    End Property
End Class
