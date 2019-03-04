Public Class PF1

    Dim sinistre As New Sinistre(1, "Malaise")
    Dim communeSelected As Commune
    Dim neededVehicles As New List(Of TypeEngin)
    Dim selectedEngin As New List(Of Engin)
    Dim communeNom As String = "BREST"

    Private Sub PF1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ContainerDepart.Controls.Clear()

        Dim departTypes As DataTable = Connexion.ORA.Table("SELECT te.TYPE_ENG_ID, te.TYPE_ENG_NOM FROM PREVU, TYPE_ENGIN te WHERE(PREVU.TYPE_ENG_ID = te.TYPE_ENG_ID) AND SIN_ID = " & sinistre.ID)
        For Each type_camion As DataRow In departTypes.Rows
            neededVehicles.Add(New TypeEngin(type_camion("TYPE_ENG_ID")))
        Next

        communeSelected = New Commune(Connexion.ORA.Champ("SELECT * FROM Commune WHERE NOM_COMMUNE = '" & communeNom & "'"))

        Dim orderedCasernes As List(Of Caserne) = OrderCaserne(communeSelected)
        Try
            For Each caserne As Caserne In orderedCasernes
                caserne.loadPompiers()
                caserne.loadEngins()


                If (neededVehicles.Count <> selectedEngin.Count) Then
                    For Each neededVehicule As TypeEngin In neededVehicles
                        For Each typeEng As Engin In caserne.getEnginsFromType(neededVehicule)
                            ' VOIR AVEC MAEL
                            ' MERCI


                            'Select TRANCHEID
                            'from tranche
                            'where trancheid = 1
                            'and TO_DSINTERVAL(CONCAT('0 ', TO_CHAR(systimestamp,'hh24:mi:ss')))
                            '    BETWEEN HOR_DEBUT AND HOR_FIN;
                        Next
                    Next
                Else
                    Exit Try
                End If
            Next
        Finally
        End Try

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

        typeEnginText.Text = "test"
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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblEngins2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEngins2.Click

    End Sub

    Public Sub test(ByVal orderedCasernes)
        Try
            For Each caserne As Caserne In orderedCasernes
                caserne.loadPompiers()
                caserne.loadEngins()


                If (neededVehicles.Count <> selectedEngin.Count) Then
                    For Each neededVehicule As TypeEngin In neededVehicles
                        For Each typeEng As Engin In caserne.getEnginsFromType(neededVehicule)
                            ' VOIR AVEC MAEL
                            ' MERCI
                            ' FAIT


                            'Select TRANCHEID
                            'from tranche
                            'where trancheid = 1
                            'and TO_DSINTERVAL(CONCAT('0 ', TO_CHAR(systimestamp,'hh24:mi:ss')))
                            '    BETWEEN HOR_DEBUT AND HOR_FIN;



                            'SELECT MATRICULTE
                            'FROM PLANNING 
                            'INNER JOIN etat ON planning.ETATID = etat.ETATID
                            'WHERE ETATID = 1
                            'AND GetTrancheFromHeure(systimestamp) = TrancheID
                            'AND caserneID = caserne.ID
                        Next
                    Next
                Else
                    Exit Try
                End If
            Next
        Finally
        End Try
    End Sub
End Class