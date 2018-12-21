Public Class gest_engins_ajout
    Dim unEngin As New CRUDENGINS


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        unEngin.ConfirmInsert()
    End Sub

    Private Sub listBoxCaserne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        unEngin.AfficheCaserne(lstAffichCaserne)

        unEngin.AffichTypeEngin(lstAffichTypeEngin)

    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

End Class