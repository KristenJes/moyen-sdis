Public Class PF1

    Dim intervention As Intervention
    Dim sinistre As New Sinistre(3, "Malaise")
    Dim caserneSelected As Caserne
    Dim neededVehicles As New List(Of TypeEngin)
    Dim selectedEngins As New Dictionary(Of Engin, Caserne)
    Dim selectedPompiers As New Dictionary(Of Engin, Pompier)
	Dim departs as New List(Of Integer)
    Dim caserneNom As String = "LANDERNEAU"

    Private Sub PF1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        intervention = New Intervention(3)
        Me.Text = "Liste de départ de l'intervention " & intervention.ID


        Dim departTypes As DataTable = Connexion.ORA.Table("SELECT te.TYPE_ENG_ID, te.TYPE_ENG_NOM FROM PREVU, TYPE_ENGIN te WHERE(PREVU.TYPE_ENG_ID = te.TYPE_ENG_ID) AND SIN_ID = " & sinistre.ID)


        For Each type_camion As DataRow In departTypes.Rows
            neededVehicles.Add(New TypeEngin(type_camion("TYPE_ENG_ID")))
        Next

        caserneSelected = New Caserne(Connexion.ORA.Champ("SELECT * FROM Caserne WHERE CIS_NOM = '" & caserneNom & "'"), False)

        Dim orderedCasernes As List(Of Caserne) = OrderCaserne(caserneSelected)
        Try
            For Each caserne As Caserne In orderedCasernes
                caserne.loadPompiers()
                caserne.loadEngins()

                If (neededVehicles.Count <> selectedEngins.Count) Then
                    For Each neededVehicule As TypeEngin In neededVehicles
                        If (caserne.Engins.Count <> 0) Then
                            For Each typeEng As Engin In caserne.getEnginsFromType(neededVehicule)
                                If (neededVehicles.Count = selectedEngins.Count) Then
                                    GoTo end_of_for
                                End If
                                If (InSelected(typeEng.Type)) Then
                                    GoTo next_of_for
                                End If

                                selectedEngins.Add(typeEng, caserne)

next_of_for:
                            Next
                        End If
                    Next
                Else
                    Exit Try
                End If
            Next
        Finally
        End Try

end_of_for:


        For Each engin In selectedEngins.Keys
            Panel1.Controls.Add(Engin_Display(engin))
        Next

        SendEnginsInDepart()

    End Sub

    Public Function OrderCaserne(ByVal caserne As Caserne)
        Dim orderedCasernes As New List(Of Caserne)()
        Dim casernes As DataTable = Connexion.ORA.Table("SELECT CIS_ID, CIS_NOM, CIS_LAT, CIS_LONG FROM CASERNE WHERE CIS_LAT IS NOT NULL AND CIS_LONG IS NOT NULL AND ROWNUM <= 15 ORDER BY DISTANCE_LOC(" & caserne.Latitude & ", " & caserne.Longitude & ", CIS_LAT, CIS_LONG)")

        For Each cas As DataRow In casernes.Rows
            orderedCasernes.Add(New Caserne(cas, False))
        Next

        Return orderedCasernes
    End Function

    Public Sub SendEnginsInDepart()
        Dim departID = Connexion.ORA.Champ("SELECT MAX(DEP_ID) FROM DEPART")(0) + 1
        For Each engin In selectedEngins.Keys
            Connexion.ORA.Execute("INSERT INTO DEPART (DEP_ID, DEP_DTE_DEPART, DEP_DTE_RETOUR, DEP_DTE_KILOMETRAGE, DEP_COMMENTAIRE, INTERV_ID, ENGIN_ID) VALUES ('" & departID & "', sysdate, null, 0, null, '" & intervention.ID & "', '" & engin.ID & "');")

            Dim pompiers As New List(Of Pompier)
            pompiers = selectedEngins(engin).GetPompierEnService()

            For counter = 0 To engin.Type.nbPlace
                If counter < pompiers.Count
					Dim pompier As Pompier

					pompier = pompiers(counter)
					Connexion.ORA.Execute("INSERT INTO participe (DEP_ID, SP_MATRICULE) VALUES (" & departID & ", '" & pompier.Matricule & "');")
					selectedPompiers.Add(engin, pompier)
				End If
            Next

            departID += 1
        Next
    End Sub

    Public Function InSelected(ByVal type As TypeEngin)
        Dim inList As Boolean = False
        For Each engin As Engin In selectedEngins.Keys
            If (engin.Type.Equals(type)) Then
                inList = True
                GoTo end_of_f
            End If
        Next
end_of_f:
        Return inList
    End Function

    Public Function Engin_Display(ByVal camion As Engin)
        Dim group As New GroupBox
        Dim typeEnginText As New Label
        Dim text2 As New Label
        Dim button As New Button

        typeEnginText.Text = camion.Type.nom
        typeEnginText.Dock = DockStyle.Left
        typeEnginText.Width = 125
        typeEnginText.AutoSize = False

        text2.Text = camion.Nom
        text2.Dock = DockStyle.Left
        text2.Width = 125
        text2.AutoSize = False

        button.Text = "Consulter"
        button.Dock = DockStyle.Right
        button.Height = 15
        AddHandler button.Click, Sub(sender, e) OnConsulterClick(camion)

        group.Controls.Add(typeEnginText)
        group.Controls.Add(text2)
        group.Controls.Add(button)
        group.Dock = DockStyle.Top
        group.Height = 60

        Return group
    End Function

    Private Sub OnConsulterClick(ByVal engin As Engin)
        Dim pompiers As New List(Of Pompier)
        For Each keyVal As KeyValuePair(Of Engin, Pompier) In selectedPompiers
            If (keyVal.Key.Equals(engin)) Then
                pompiers.Add(keyVal.Value)
            End If
        Next

        pf2.Show()
        pf2.First_Load(selectedEngins(engin), engin, pompiers)
    End Sub

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click
        SendEnginsInDepart()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class