Public Class gesstion_modif
    Dim unEngins As New CRUDENGINS

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        insert()
    End Sub

    Private Sub listBoxCaserne_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub gest_engins_ajout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AfficheTypeEngin()
        AfficheCaserne()
    End Sub
    Public Sub insert()
        '_________VARIABLE_________
        Dim type_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim type_nom As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Value

        Dim caserne_id As String = DirectCast(CbType.SelectedItem, KeyValuePair(Of String, String)).Key

        Dim immat As String = txtBoxImmatriculation.Text.ToString

        '__________________________

        Connexion.ORA.Execute("INSERT INTO ENGIN (ENGIN_ETAT, ENGIN_NOM, CIS_ID, TYPE_ENG_ID, ENGIN_IMMAT) VALUES ('OK', '" & type_nom & "', '" & caserne_id & "', '" & type_id & "', '" & immat & "'   ")
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged, CbCaserne.SelectedIndexChanged

    End Sub
End Class