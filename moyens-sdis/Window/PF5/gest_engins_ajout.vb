Public Class gest_engins_ajout
<<<<<<< HEAD
    Dim unEngins As New CRUDENGINS
    Private Sub IHMAjout()
        unEngins.afficheIHMAjout(Me, lstAffichTypeEngin)
    End Sub
=======


>>>>>>> 8957753d90831ecc04b9dad3e17e8512267e1f41
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

    End Sub

    Private Sub listBoxCaserne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBoxCaserne.SelectedIndexChanged

    End Sub

    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
<<<<<<< HEAD
        IHMAjout()


    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Me.Close()
=======
        listBoxCaserne.Items.Add("BREST")
        listBoxCaserne.Items.Add("OUESSANT")
        listBoxCaserne.Items.Add("SAINT RENAN")

        ListBoxType.Items.Add("VSAV")
        ListBoxType.Items.Add("VTU")
        ListBoxType.Items.Add("VL")
        ListBoxType.Items.Add("FPT")
        ListBoxType.Items.Add("VL")
>>>>>>> 8957753d90831ecc04b9dad3e17e8512267e1f41
    End Sub
End Class