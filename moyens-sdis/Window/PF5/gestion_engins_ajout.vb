Public Class gestion_engins_ajout
#Region "Bouton"
    'Execute le sub Insert + Affiche une notification + ferme la fenetre
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        insert()
        MsgBox("Ajout efffectue")
        Me.Close()
    End Sub
    'Ferme la fenetre
    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub
#End Region
#Region "IHM"
    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AfficheTypeEngin()
        AfficheCaserne()
    End Sub
    'Affichage des informations sur les types d'engins
    Public Sub AfficheTypeEngin()
        '_________VARIABLE_________
        Dim info(2) As String
        Dim type As DataTable = Connexion.ORA.Table("SELECT TYPE_ENG_ID, TYPE_ENG_NOM FROM TYPE_ENGIN")
        Dim comboSource As New Dictionary(Of String, String)()
        '__________________________

        For Each nom As DataRow In type.Rows
            info(0) = nom("TYPE_ENG_ID").ToString
            info(1) = nom("TYPE_ENG_NOM").ToString

            'Ajout des informations aux dictionnaires
            comboSource.Add(info(0), info(1))
            'Bind du comboBox
            CbType.DataSource = New BindingSource(comboSource, Nothing)
        Next
        CbType.DisplayMember = "Value"
        CbType.ValueMember = "Key"
    End Sub
    'Affichage des informations sur les casernes
    Public Sub AfficheCaserne()
        '_________VARIABLE_________
        Dim info(2) As String
        Dim type As DataTable = Connexion.ORA.Table("SELECT CIS_ID, CIS_NOM FROM CASERNE")
        Dim comboSource As New Dictionary(Of String, String)()
        '__________________________


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
#End Region
    'Recupere les informations dans les variables puis les ajoute a la requete
    Public Sub insert()
        '_________VARIABLE_________
        Dim type_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim type_nom As String = txtBoxNom.Text

        Dim caserne_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key

        Dim immat As String = txtBoxImmatriculation.Text.ToString
        Dim cmdSql As String = ""
        '__________________________
        cmdSql = "INSERT INTO ENGIN (ENGIN_ID, ENGIN_ETAT, ENGIN_NOM, CIS_ID, TYPE_ENG_ID, ENGIN_IMMAT) VALUES (S_INC_ENGIN.nextval, 'Disponible', '" & type_nom & "', " & caserne_id & ", " & type_id & ", '" & immat & "');"

        Connexion.ORA.Execute(cmdSql)
    End Sub
End Class