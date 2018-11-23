Public Class Sinistre

    Private _sinid As Integer
    Private _nature As String
    Private _observation As String

    Public Property sinid As Integer
        Get
            Return _sinid
        End Get
        Set(ByVal value As Integer)
            _sinid = value
        End Set
    End Property

    Public Property nature As String
        Get
            Return _nature
        End Get
        Set(ByVal value As String)
            _nature = value
        End Set
    End Property

    Public Property observation As String
        Get
            Return _observation
        End Get
        Set(ByVal value As String)
            _observation = value
        End Set
    End Property



End Class
