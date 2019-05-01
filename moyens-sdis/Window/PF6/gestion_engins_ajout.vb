Public Class gestion_engins_ajout
    Dim unEngins As New CRUDENGINS

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        insert()
    End Sub

    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AfficheTypeEngin()
        AfficheCaserne()
    End Sub
    Public Sub insert()
        '_________VARIABLE_________
        Dim type_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key

        Dim Nom As String = txtBoxNom.Text

        Dim caserne_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key

        Dim immat As String = txtBoxImmatriculation.Text.ToString
        Dim CdeSQL As String = ""
        '__________________________

        CdeSQL = "INSERT INTO ENGIN (ENGIN_ID, ENGIN_ETAT, ENGIN_NOM, CIS_ID, TYPE_ENG_ID, ENGIN_IMMAT) VALUES (s_inc_engin.nextval ,'OK', '" & Nom & "', " & caserne_id & ", " & type_id & ", '" & immat & "');"
        Connexion.ORA.Execute(CdeSQL)
        'Connexion.ORA.Execute("INSERT INTO ENGIN (ENGIN_ETAT, ENGIN_NOM, CIS_ID, TYPE_ENG_ID, ENGIN_IMMAT) VALUES ('OK', '" & type_nom & "', '" & caserne_id & "', '" & type_id & "', '" & immat & "';")
        'Connexion.ORA.Execute("UPDATE ENGIN SET ENGIN_ETAT= 'OK', ENGIN_NOM= '" & type_nom & "', CIS_ID= '" & caserne_id & "', TYPE_ENG_ID = '" & type_id & "', ENGIN_IMMAT = '" & immat & "' WHERE ENGIN_ID = ")
    End Sub
    Public Sub AfficheTypeEngin()
        '_________VARIABLE_________
        Dim info(2) As String
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

End Class