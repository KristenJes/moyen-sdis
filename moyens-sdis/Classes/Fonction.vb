Public Class Fonction
    Private _fctid As Integer
    Private _libelle As String

    Public Property fctid As Integer
        Get
            Return _fctid
        End Get
        Set(ByVal value As Integer)
            _fctid = value
        End Set
    End Property

    Public Property libelle As String
        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            _libelle = value
        End Set
    End Property
End Class
