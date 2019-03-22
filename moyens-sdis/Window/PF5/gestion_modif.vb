Public Class gestion_modif

#Region "Bouton"
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        updates()
        MsgBox("Modification efffectue")
        Me.Close()
    End Sub
    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub
#End Region

#Region "IHM"
    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AfficheTypeEngin()
        AfficheCaserne()
        AfficheNom()
        AfficheImmat()
    End Sub
    Public Sub AfficheTypeEngin()
        '_________VARIABLE_________
        Dim info(2) As String
        Dim id As String = lblId.Text
        Dim type As DataTable = Connexion.ORA.Table("SELECT TYPE_ENG_ID, TYPE_ENG_NOM FROM TYPE_ENGIN")
        Dim comboSource As New Dictionary(Of String, String)()
        '__________________________

        For Each nom As DataRow In type.Rows
            info(0) = nom("TYPE_ENG_ID").ToString
            info(1) = nom("TYPE_ENG_NOM").ToString

            comboSource.Add(info(0), info(1))
            CbType.DataSource = New BindingSource(comboSource, Nothing)
        Next
        CbType.DisplayMember = "Value"
        CbType.ValueMember = "Key"

        Dim selected As DataRow = Connexion.ORA.Champ("SELECT TYPE_ENG_NOM FROM TYPE_ENGIN, ENGIN WHERE TYPE_ENGIN.TYPE_ENG_ID=ENGIN.TYPE_ENG_ID AND ENGIN_ID=" & id & "")
        CbType.Text = selected(0).ToString
    End Sub
    Public Sub AfficheCaserne()
        '_________VARIABLE_________
        Dim info(2) As String
        Dim id As String = lblId.Text
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
        Dim selected As DataRow = Connexion.ORA.Champ("SELECT CIS_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND ENGIN_ID=" & id & "")
        CbCaserne.Text = selected(0).ToString
    End Sub
    Public Sub AfficheNom()
        '_________VARIABLE_________
        Dim id As String = lblId.Text
        Dim nom As DataRow = Connexion.ORA.Champ("SELECT ENGIN_NOM FROM ENGIN WHERE ENGIN_ID=" & id & ";")
        '__________________________
        txtBoxNom.Text = nom(0).ToString
    End Sub
    Public Sub AfficheImmat()
        '_________VARIABLE_________
        Dim id As String = lblId.Text
        Dim immat As DataRow = Connexion.ORA.Champ("SELECT ENGIN_IMMAT FROM ENGIN WHERE ENGIN_ID=" & id & ";")
        '__________________________
        txtBoxImmatriculation.Text = immat(0).ToString
    End Sub

#End Region

    Public Sub updates()
        '_________VARIABLE_________
        Dim type_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim type_nom As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Value

        Dim caserne_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key

        Dim immat As String = txtBoxNom.Text.ToString

        Dim id As String = lblId.Text
        Dim cmdSql As String = ""

        '__________________________

        cmdSql = "UPDATE ENGIN SET ENGIN_ETAT= 'Disponible', ENGIN_NOM= '" & type_nom & "', CIS_ID= " & caserne_id & ", TYPE_ENG_ID = " & type_id & ", ENGIN_IMMAT = '" & immat & "' WHERE ENGIN_ID =" & id & "; "
        Connexion.ORA.Execute(cmdSql)
    End Sub
End Class