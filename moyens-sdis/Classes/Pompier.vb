Public Class Pompier

    Private _matricule As String
    Private _nom As String
    Private _prenom As String
    Private _dateNaissance As Date
    Private _telFixe As String
    Private _telPortable As String
    Private _bip As String
    Private _statut As Statut
    Private _dateMaj As Date
    Private _datePromotion As Date
    Private _dateAffectation As Date
    Private _casernes As List(Of Caserne)

    Public Property Bip As Integer
        Get
            Return _bip
        End Get
        Set(ByVal value As Integer)
            _bip = value
        End Set
    End Property

    Public Property Casernes As List(Of Caserne)
        Get
            Return _casernes
        End Get
        Set(ByVal value As List(Of Caserne))
            _casernes = value
        End Set
    End Property

    Public Property DateAffectation As Date
        Get
            Return _dateAffectation
        End Get
        Set(ByVal value As Date)
            _dateAffectation = value
        End Set
    End Property

    Public Property DateMaj As Date
        Get
            Return _dateMaj
        End Get
        Set(ByVal value As Date)
            _dateMaj = value
        End Set
    End Property

    Public Property DateNaissance As Date
        Get
            Return _dateNaissance
        End Get
        Set(ByVal value As Date)
            _dateNaissance = value
        End Set
    End Property

    Public Property DatePromotion As Date
        Get
            Return _datePromotion
        End Get
        Set(ByVal value As Date)
            _datePromotion = value
        End Set
    End Property

    Public Property Matricule As Integer
        Get
            Return _matricule
        End Get
        Set(ByVal value As Integer)
            _matricule = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property Prenom As String
        Get
            Return _prenom
        End Get
        Set(ByVal value As String)
            _prenom = value
        End Set
    End Property

    Public Property Statut As String
        Get
            Return _statut
        End Get
        Set(ByVal value As String)
            _statut = value
        End Set
    End Property

    Public Property TelFixe As String
        Get
            Return _telFixe
        End Get
        Set(ByVal value As String)
            _telFixe = value
        End Set
    End Property

    Public Property TelPortable As String
        Get
            Return _telPortable
        End Get
        Set(ByVal value As String)
            _telPortable = value
        End Set
    End Property

End Class