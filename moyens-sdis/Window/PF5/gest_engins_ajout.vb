Public Class gest_engins_ajout


    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

    End Sub

    Private Sub listBoxCaserne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBoxCaserne.SelectedIndexChanged

    End Sub

    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listBoxCaserne.Items.Add("BREST")
        listBoxCaserne.Items.Add("OUESSANT")
        listBoxCaserne.Items.Add("SAINT RENAN")

        ListBoxType.Items.Add("VSAV")
        ListBoxType.Items.Add("VTU")
        ListBoxType.Items.Add("VL")
        ListBoxType.Items.Add("FPT")
        ListBoxType.Items.Add("VL")
    End Sub
End Class