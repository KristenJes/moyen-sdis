Public Class Intervention

    Private _id As Integer
    Private _date As Date
    Private _commentaire As String
    Private _sinistre As Sinistre


    Public Sub New(ByVal id, ByVal cur_date, ByVal commentaire, ByVal sinistre)
        _id = id
        _date = cur_date
        _commentaire = commentaire
        _sinistre = sinistre
    End Sub

    Public Property ID As Integer
        Get
            Return _id

        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Cur_Date As Date
        Get
            Return _date

        End Get
        Set(ByVal value As Date)
            _date = value
        End Set
    End Property

    Public Property Commentaire As String
        Get
            Return _commentaire
        End Get
        Set(ByVal value As String)

        End Set
    End Property


    Public Property Sinistre As Sinistre
        Get
            Return _sinistre
        End Get
        Set(ByVal value As Sinistre)
            _sinistre = value
        End Set
    End Property




End Class
