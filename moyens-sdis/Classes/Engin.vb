Public Class Engin

    Private _id As Integer
    Private _etat As Etat
    Private _nom As String
    Private _type As TypeEngin
    Private _cis As Caserne

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Public Property Etat As Etat
        Get
            Return _etat

        End Get
        Set(ByVal value As Etat)
            _etat = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property Type As TypeEngin
        Get
            Return _type
        End Get
        Set(ByVal value As TypeEngin)
            _type = value
        End Set
    End Property

    Public Property Caserne As Caserne
        Get
            Return _cis
        End Get
        Set(ByVal value As Caserne)
            _cis = value
        End Set
    End Property

End Class