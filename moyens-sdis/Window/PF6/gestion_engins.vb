Imports System.Data.SqlClient

Public Class gestion_engins
    Dim unEngins As New CRUDENGINS

    Private Sub IHM()
        unEngins.afficheIHMEngins(Me, lstAffichEngins)

    End Sub

    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click

        unEngins.ConfirmDelete()

    End Sub
    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        gest_engins_ajout.ShowDialog()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        gest_engins_ajout.ShowDialog()
    End Sub

    Private Sub gestion_engins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IHM()
        unEngins.AfficheCaserne(lstAffichCaserne)


        lstAffichCaserne.Items.Add("BREST")
        lstAffichCaserne.Items.Add("OUESSANT")
        lstAffichCaserne.Items.Add("SAINT RENAN")

    End Sub

End Class