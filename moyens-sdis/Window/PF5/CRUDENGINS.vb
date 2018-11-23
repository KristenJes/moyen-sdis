
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

            info(0) = "Ouessant"
            info(1) = "VSAV02"
            info(2) = "XXX-123-YYY"
            info(3) = "OK"

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)


            info(0) = "Brest"
            info(1) = "FPT04"
            info(2) = "XXX-123-YYY"
            info(3) = "En intervention"


            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)

            info(0) = "Ouessant"
            info(1) = "VTU01"
            info(2) = "XXX-123-YYY"
            info(3) = "OK"

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)


        End Sub
        Public Sub ConfirmDelete()

            MessageBox.Show("Êtes-vous sur de vouloir supprimer cet engins ?", "Confirmation de suppression", _
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        End Sub
    End Class