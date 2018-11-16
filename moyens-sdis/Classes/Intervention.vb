Public Class Intervention

    Private _intervid As Integer
    Private _date As Date
    Private _commentaire As String
    Private _sin As Sinistre



    Public Property interid As Integer
        Get
            Return _intervid

        End Get
        Set(ByVal value As Integer)
            _intervid = value
        End Set
    End Property

    Public Property dateInter As Date
        Get
            Return _date

        End Get
        Set(ByVal value As Date)
            _date = value
        End Set
    End Property

    Public Property commentaire As String
        Get
            Return _commentaire
        End Get
        Set(ByVal value As String)

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
