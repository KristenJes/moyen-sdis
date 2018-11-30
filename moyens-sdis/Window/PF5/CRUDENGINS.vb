
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






        Dim engin_id As DataTable = Connexion.ORA.Table("SELECT * FROM ENGIN")
        For Each nom As DataRow In engin_id.Rows
            info(0) = nom("ENGIN_ID").ToString
            info(1) = nom("ENGIN_NOM").ToString
            info(2) = nom("ENGIN_IMMAT").ToString
            info(3) = nom("ENGIN_ETAT").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)
        Next




    End Sub
        Public Sub ConfirmDelete()

            MessageBox.Show("Êtes-vous sur de vouloir supprimer cet engins ?", "Confirmation de suppression", _
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        End Sub
    End Class