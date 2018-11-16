Public Class Intervention

    Private _intervid As Integer
    Private _date As String
    Private _commentaire As String
    Private _sin As Sinistre

    Public Property commentaire As Integer
        Get
            Return _commentaire
        End Get
        Set(ByVal value As Integer)

        End Set
    End Property

    Public Property interid As Integer
        Get
            Return _intervid

        End Get
        Set(ByVal value As Integer)
            _intervid = value
        End Set
    End Property

    Public Property sin As Sinistre
        Get
            Return _sin
        End Get
        Set(ByVal value As Sinistre)
            _sin = value
        End Set
    End Property




End Class
