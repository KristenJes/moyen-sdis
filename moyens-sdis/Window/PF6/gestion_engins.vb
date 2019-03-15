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
        gestion_engins_ajout.ShowDialog()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        gestion_modif.ShowDialog()
    End Sub

    Private Sub gestion_engins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IHM()
        AfficheCaserne()

        'lstAffichEngins.

    End Sub
    Public Sub AfficheCaserne()
        '_________VARIABLE_________
        Dim info(2) As String
        Dim type As DataTable = Connexion.ORA.Table("SELECT CIS_ID, CIS_NOM FROM CASERNE")
        Dim comboSource As New Dictionary(Of String, String)()
        '__________________________


        For Each nom As DataRow In type.Rows
            info(0) = nom("CIS_ID").ToString
            info(1) = nom("CIS_NOM").ToString

            comboSource.Add(info(0), info(1))
            CbCaserne.DataSource = New BindingSource(comboSource, Nothing)
        Next
        CbCaserne.DisplayMember = "Value"
        CbCaserne.ValueMember = "Key"
    End Sub

    Private Sub lstAffichEngins_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstAffichEngins.ItemCheck

    End Sub

    Private Sub lstAffichEngins_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAffichEngins.SelectedIndexChanged
        ' lvw = listview
        ' Création d'une variable pour une manipulation plus aisée
        ' SelectedItems est la collection des item sélectionnée ici en l'occurence 
        ' il n 'y en aura que jamais qu'une.
        '' -------------------------------------
        'Vérification qu'il y a bien une ligne sélectionner
        'Indispensable sinon une erreur apparait car il y a une déselection puis une sélection qui arrive
        If lstAffichEngins.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = lstAffichEngins.SelectedItems(0)
            'récupération de l'index de l'item dans la listview
            Dim index As Integer = lstAffichEngins.Items.IndexOf(item)
            ' Récupération des valeurs avec l'utilisation de l'énumération
            Dim valueColum1 As String = item.SubItems(columnIndex.column1).Text
            Dim valueColum2 As String = item.SubItems(columnIndex.column2).Text

        End If
    End Sub
End Class