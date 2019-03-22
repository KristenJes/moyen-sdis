Imports System.Data.SqlClient
Public Class gestion_engins
#Region "Bouton"
    Private Sub btnSupprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupprimer.Click
        Dim ask As MsgBoxResult = MessageBox.Show("Êtes-vous sur de vouloir supprimer cet engins ?", "Confirmation de suppression", _
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = 6 Then
            delete()
            MsgBox("Suppression effectue")
        End If
    End Sub
    Private Sub btnAjouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjouter.Click
        gestion_engins_ajout.ShowDialog()
    End Sub

    Private Sub btnModifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifier.Click
        '_________VARIABLE_________
        Dim id As Integer = 0
        Dim cmdSql As String = ""
        '__________________________

        If lstAffichEngins.SelectedItems.Count = 0 Then Return
        id = lstAffichEngins.SelectedItems(0).SubItems(0).Text


        gestion_modif.lblId.Text = id
        gestion_modif.ShowDialog()

    End Sub
#End Region
#Region "IHM"
    'LIAISON AVEC IHM
    Public Sub afficheIHM(ByVal uneFeuille As Form, ByVal uneListView As ListView)
        uneFeuille.Text = "ENGINS"

        uneListView.Clear()

        uneListView.Columns.Add("Caserne", 80, HorizontalAlignment.Left)
        uneListView.Columns.Add("Nom engin", 70, HorizontalAlignment.Left)
        uneListView.Columns.Add("Imatriculation", 90, HorizontalAlignment.Left)
        uneListView.Columns.Add("Etat", 120, HorizontalAlignment.Left)

        Dim info(5) As String
        Dim itm As ListViewItem

        Dim engin As DataTable = Connexion.ORA.Table("SELECT ENGIN_ID, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM ENGIN")
        For Each nom As DataRow In engin.Rows
            info(0) = nom("ENGIN_ID").ToString
            info(1) = nom("ENGIN_NOM").ToString
            info(2) = nom("ENGIN_IMMAT").ToString
            info(3) = nom("ENGIN_ETAT").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)
        Next
    End Sub
    Public Sub AfficheCaserne()
        '__________________VARIABLE__________________
        Dim info(2) As String
        Dim type As DataTable = Connexion.ORA.Table("SELECT CIS_ID, CIS_NOM FROM CASERNE")
        Dim comboSource As New Dictionary(Of String, String)()
        '____________________________________________


        For Each nom As DataRow In type.Rows
            info(0) = nom("CIS_ID").ToString
            info(1) = nom("CIS_NOM").ToString

            'Ajout des informations aux dictionnaires
            comboSource.Add(info(0), info(1))
            'Bind du comboBox
            CbCaserne.DataSource = New BindingSource(comboSource, Nothing)
        Next
        CbCaserne.DisplayMember = "Value"
        CbCaserne.ValueMember = "Key"
    End Sub
    'Chargement de la page avec les IHM
    Private Sub gestion_engins_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        afficheIHM(Me, lstAffichEngins)
        AfficheCaserne()
    End Sub


#End Region

    Public Sub delete()
        '__________________VARIABLE__________________
        Dim id As Integer = 0
        Dim cmdSql As String = ""
        '____________________________________________

        If lstAffichEngins.SelectedItems.Count = 0 Then Return
        id = lstAffichEngins.SelectedItems(0).SubItems(0).Text

        cmdSql = "DELETE FROM ENGIN WHERE ENGIN_ID=" & id & ";"

        Connexion.ORA.Execute(cmdSql)
    End Sub
End Class