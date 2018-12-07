
Class CRUDENGINS

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

        'info(0) = "Ouessant"
        'info(1) = "VSAV02"
        'info(2) = "XXX-123-YYY"
        'info(3) = "OK"

        Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ID, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID")
        For Each nom As DataRow In engin.Rows
            info(0) = nom("CIS_NOM").ToString
            info(1) = nom("ENGIN_NOM").ToString
            info(2) = nom("ENGIN_IMMAT").ToString
            info(3) = nom("ENGIN_ETAT").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)
        Next

    End Sub

    Public Sub AfficheCaserne(ByVal uneListView As ListView)


        Dim info(2) As String
        Dim itm As ListViewItem


        Dim caserne As DataTable = Connexion.ORA.Table("SELECT CIS_NOM FROM CASERNE ORDER BY CIS_NOM ASC")
        For Each nom As DataRow In caserne.Rows
            info(0) = nom("CIS_NOM").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)

        Next
    End Sub

    Public Sub ConfirmDelete()

        MessageBox.Show("Êtes-vous sur de vouloir supprimer cet engins ?", "Confirmation de suppression", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If MessageBoxButtons = vbYes Then


        'End If


    End Sub

    Public Sub Delete(ByVal uneListView As ListView)
        Dim info(2) As String
        Dim itm As ListViewItem

        Dim dltCaserne As DataTable = Connexion.ORA.Table("DELETE FROM ENGIN WHERE ENGIN.CIS_ID =     ")
        For Each nom As DataRow In dltCaserne.Rows
            info(0) = nom("CIS_NOM").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Remove(itm)
        Next
    End Sub

    Public Sub Update(ByVal uneListView As ListView)
        Dim info(2) As String
        Dim itm As ListViewItem

        Dim dltCaserne As DataTable = Connexion.ORA.Table("UPDATE ENGIN SET WHERE ENGIN.CIS_ID = ")
        For Each nom As DataRow In dltCaserne.Rows
            info(0) = nom("CIS_NOM").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Remove(itm)
        Next

    End Sub
End Class