﻿Public Class Caserne

    Private _id As Integer
    Private _nom As String
    Private _latitude As Double
    Private _longitude As Double
    Private _engins As List(Of Engin)
    Private _pompiers As List(Of Pompier)

    Public Sub New(ByVal id, ByVal nom, ByVal latitude, ByVal longitude)
        _id = id
        _nom = nom
        _latitude = latitude
        _longitude = longitude
        _pompiers = loadPompiers()
    End Sub

    Public Sub New(ByVal str As DataRow, ByVal loadPompier As Boolean)
        _id = str("CIS_ID")
        _nom = str("CIS_NOM")
        _latitude = str("CIS_LAT")
        _longitude = str("CIS_LONG")
        If (loadPompier) Then
            _pompiers = loadPompiers()
        End If
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Latitude As Integer
        Get
            Return _latitude
        End Get
        Set(ByVal value As Integer)
            _latitude = value
        End Set
    End Property

    Public Property Longitude As Integer
        Get
            Return _longitude
        End Get
        Set(ByVal value As Integer)
            _longitude = value
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

    Public Property Engins As List(Of Engin)
        Get
            Return _engins

        End Get
        Set(ByVal value As List(Of Engin))

            _engins = value
        End Set
    End Property

    Public Property Pompiers As List(Of Pompier)
        Get
            Return _pompiers

        End Get
        Set(ByVal value As List(Of Pompier))

            _pompiers = value
        End Set
    End Property


    'Functions
    Public Sub addEngins(ByVal engin As Engin)
        Engins.Add(engin)
    End Sub

    Public Function loadPompiers()
        Dim pompiers As New List(Of Pompier)
        Dim pompiersStr As DataTable = Connexion.ORA.Table("SELECT * FROM Pompier WHERE CIS_ID = " & ID)
        For Each pompierStr As DataRow In pompiersStr.Rows
            Dim pompier As Pompier = New Pompier(pompierStr)
            pompiers.Add(pompier)
        Next

        Return pompiers
    End Function

    Public Function loadEngins()
        Dim engins As New List(Of Engin)
        Dim enginsStr As DataTable = Connexion.ORA.Table("SELECT ENGIN_ID, ENGIN_NOM, ENGIN_ETAT, TYPE_ENG_ID FROM Engin WHERE CIS_ID = " & ID)
        For Each enginStr As DataRow In enginsStr.Rows
            Dim engin As Engin = New Engin(enginStr)
            engins.Add(engin)
        Next

        Return engins
    End Function

    Public Function getEnginsFromType(ByVal type As TypeEngin)
        If (Engins.Count = 0) Then
            Return Nothing
        End If

        Dim enginsWithType As New List(Of Engin)

        For Each engin As Engin In Engins
            If (engin.Type.Equals(type)) Then
                enginsWithType.Add(engin)
            End If
        Next

        Return enginsWithType
    End Function

End Class