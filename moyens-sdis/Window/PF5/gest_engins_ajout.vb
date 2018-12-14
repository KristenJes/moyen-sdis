Public Class gest_engins_ajout
    Dim unEngins As New CRUDENGINS

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

    End Sub

    Private Sub listBoxCaserne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'unEngins.AfficheCaserne(listBoxCaserne)
        unEngins.AffichTypeEngin(lstAffichTypeEngin)

    End Sub

    Private Sub txtBoxIdentifiant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoxIdentifiant.TextChanged

    End Sub
End Class