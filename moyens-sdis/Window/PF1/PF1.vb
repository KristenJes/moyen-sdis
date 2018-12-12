Public Class PF1

    Dim sinistre As New Sinistre(1, "Malaise")
    Dim communeSelected As Commune
    Dim neededVehicles As New List(Of TypeEngin)
    Dim communeNom As String = "Brest"

    Private Sub PF1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ContainerDepart.Controls.Clear()
        Dim departTypes As DataTable = Connexion.ORA.Table("SELECT te.TYPE_ENG_ID FROM PREVU, TYPE_ENGIN te WHERE(PREVU.TYPE_ENG_ID = te.TYPE_ENG_ID) AND SIN_ID = " & sinistre.ID)
        For Each type_camion As DataRow In departTypes.Rows
            neededVehicles.Add(New TypeEngin(type_camion("TYPE_ENG_ID")))
        Next

        communeSelected = New Commune(Connexion.ORA.Champ("SELECT * FROM Commune WHERE "))

        Dim orderedCasernes As List(Of Caserne) = OrderCaserne(communeSelected)
        For Each caserne As Caserne In orderedCasernes
            caserne.loadPompiers()
        Next

        For Each type_camion As DataRow In departTypes.Rows
            Panel1.Controls.Add(Engin_Display(type_camion))
        Next
    End Sub

    Public Function OrderCaserne(ByVal commune As Commune)
        Dim orderedCasernes As New List(Of Caserne)()
        Dim casernes As DataTable = Connexion.ORA.Table("SELECT CIS_ID, CIS_NOM, CIS_LAT, CIS_LONG FROM CASERNE WHERE CIS_LAT IS NOT NULL AND CIS_LONG IS NOT NULL ORDER BY DISTANCE_LOC(" & commune.Latitude & ", " & commune.Longitude & ", CIS_LAT, CIS_LONG)")

        For Each caserne As DataRow In casernes.Rows
            orderedCasernes.Add(New Caserne(caserne, False))
        Next

        Return orderedCasernes
    End Function

    Public Function Engin_Display(ByVal camion)
        Dim group As New GroupBox
        Dim typeEnginText As New Label
        Dim text2 As New Label
        Dim button As New Button

        typeEnginText.Text = camion("TYPE_ENG_PLACES")
        typeEnginText.Dock = DockStyle.Left
        typeEnginText.Width = 125
        typeEnginText.AutoSize = False

        text2.Text = camion("TYPE_ENG_NOM")
        text2.Dock = DockStyle.Left
        text2.Width = 125
        text2.AutoSize = False

        button.Text = "Consulter"
        button.Dock = DockStyle.Right
        button.Height = 15

        group.Controls.Add(typeEnginText)
        group.Controls.Add(text2)
        group.Controls.Add(button)
        group.Dock = DockStyle.Top
        group.Height = 50

        Return group
    End Function

End Class