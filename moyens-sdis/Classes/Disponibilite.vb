Public Class Disponibilite
    Private _dispoId As Integer
    Private _dispoLib As String

    Public Property DispoID As Integer
        Get
            Return _dispoId
        End Get
        Set(ByVal value As Integer)
            _dispoIdd = value
        End Set
    End Property

    Public Property DispoLib As String
        Get
            Return _dispoLib
        End Get
        Set(ByVal value As String)
            _dispoLib = value
        End Set
    End Property
End Class
