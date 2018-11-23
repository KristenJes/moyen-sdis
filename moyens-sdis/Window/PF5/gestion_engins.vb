Imports System.Data.SqlClient

Public Class gestion_engins
    Dim unEngins As New CRUDENGINS

    Private Sub IHM()
        unEngins.afficheIHM(Me, lstAffichEngins)

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
        ListBoxCaserne.Items.Add("BREST")
        ListBoxCaserne.Items.Add("OUESSANT")
        ListBoxCaserne.Items.Add("SAINT RENAN")



        ''Dim con As IDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\Database1.accdb;")
        ''Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(facture.totale) as Total FROM facture WHERE facture.n_facture LIKE '%" + TextBox10.Text + "%' ", con)
        ''Try
        ''    con.Open()
        ''    Dim TotalFacture As Decimal = cmd.ExecuteScalar()
        ''    TextBox_totalFacture.Text = TotalFacture
        ''Catch ex As Exception
        ''    MessageBox.Show(ex.Message)
        ''Finally
        ''    con.Close()
        ''End Try
    End Sub

    Private Sub ListBoxCaserne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxCaserne.SelectedIndexChanged

    End Sub

End Class