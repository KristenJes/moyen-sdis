Public Class Depart
    Private _depID As Integer
    Private _engID As Engin
    Private _intervID As Intervention
    Private _dteDepart As Date
    Private _dteRetour As Date
    Private _kilometrage As Integer
    Private _commentaire As String

    Public Property Commentaire As Integer
        Get
            Return _commentaire
        End Get
        Set(ByVal value As Integer)

            _commentaire = value
        End Set
    End Property

    Public Property DepID As Integer
        Get
            Return _depID
        End Get
        Set(ByVal value As Integer)

            _depID = value
        End Set
    End Property

    Public Property DteDepart As Date
        Get
            Return _dteDepart
        End Get
        Set(ByVal value As Date)

            _dteDepart = value
        End Set
    End Property

    Public Property DteRetour As Date
        Get
            Return _dteRetour

        End Get
        Set(ByVal value As Date)
            _dteRetour = value
        End Set
    End Property

    Public Property EngID As Engin
        Get
            Return _engID
        End Get
        Set(ByVal value As Engin)
            _engID = value
        End Set
    End Property

    Public Property IntervID As Intervention
        Get
            Return _intervID
        End Get
        Set(ByVal value As Intervention)

            _intervID = value
        End Set
    End Property

    Public Property Kilometrage As Integer
        Get
            Return _kilometrage
        End Get
        Set(ByVal value As Integer)

            _kilometrage = value
        End Set
    End Property

End Class
