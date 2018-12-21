
Class CRUDENGINS
    'Getteur et Setteur

    Private _caserne As Integer
    Private _id As Integer
    Private _etat As String
    Private _nom As String
    Private _type As TypeEngin

    Public Property caserne() As Integer
        Get
            Return _caserne
        End Get
        Set(ByVal value As Integer)
            _caserne = value
        End Set
    End Property


    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Public Property Etat As String
        Get
            Return _etat

        End Get
        Set(ByVal value As String)
            _etat = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property Type As TypeEngin
        Get
            Return _type
        End Get
        Set(ByVal value As TypeEngin)
            _type = value
        End Set
    End Property




    'LIAISON AVEC IHM
    Public Sub afficheIHMEngins(ByVal uneFeuille As Form, ByVal uneListView As ListView)
        uneFeuille.Text = "ENGINS"

        uneListView.Clear()

        uneListView.Columns.Add("Caserne", 150, HorizontalAlignment.Left)
        uneListView.Columns.Add("Nom engin", 70, HorizontalAlignment.Left)
        uneListView.Columns.Add("Imatriculation", 90, HorizontalAlignment.Left)
        uneListView.Columns.Add("Etat", 120, HorizontalAlignment.Left)

        Dim info(5) As String
        Dim itm As ListViewItem

        Dim caserne = "BREST"
        Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND CIS_NOM='" & caserne & "';")

        'Dim engin As DataTable = Connexion.ORA.Table("SELECT ENGIN_ID, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM ENGIN")
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


        Dim caserne As DataTable = Connexion.ORA.Table("SELECT CIS_NOM FROM CASERNE ORDER BY CIS_NOM;")
        For Each nom As DataRow In caserne.Rows
            info(0) = nom("CIS_NOM").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)

        Next
    End Sub

    '' Confirmation
    Public Sub ConfirmDelete()

        MessageBox.Show("Êtes-vous sur de vouloir supprimer cet engins ?", "Confirmation de suppression", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Sub

    Public Sub ConfirmInsert()

        MessageBox.Show("Êtes-vous sur de vouloir ajouter cet engins ?", "Confirmation d'ajout", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Sub

    Public Sub ConfirmUpdate()

        MessageBox.Show("Êtes-vous sur de vouloir modifier cet engins ?", "Confirmation de modification", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Sub

    'Public Sub AfficheModif()
    '    Dim info(2) As String
    '    Dim itm As ListViewItem


    '    Dim infoModif As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ID, ENGIN_IMMAT FROM CASERNE, ENGIN, TYPE_ENGIN ORDER BY CIS_NOM WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND ENGIN.TYPE_ENG_ID=TYPE_ENGIN.TYPE_ENG_ID;")
    '    For Each nom As DataRow In infoModif.Rows
    '        info(0) = nom("CIS_NOM").ToString

    '        itm = New ListViewItem(info)
    '        'uneListView.Items.Add(itm)

    '    Next


    'End Sub

    'Public Sub ajout()
    '    Dim caserne As DataTable = Connexion.ORA.Table("INSERT INTO ENGIN () VALUES ();")
    'End Sub


    Public Sub AffichTypeEngin(ByVal uneListView As ListView)
        Dim info(2) As String
        Dim itm As ListViewItem


        Dim typeEngin As DataTable = Connexion.ORA.Table("SELECT TYPE_ENG_NOM FROM TYPE_ENGIN ORDER BY TYPE_ENG_NOM;")
        For Each nom As DataRow In typeEngin.Rows
            info(0) = nom("TYPE_ENG_NOM").ToString

            itm = New ListViewItem(info)
            uneListView.Items.Add(itm)

        Next
    End Sub


    Public Sub AjoutEngin(ByVal uneListView As ListView, ByVal unId As Integer, ByVal unEtat As String, ByVal unNom As String, ByVal unIdCis As Integer, ByVal unIdType As Integer, ByVal uneImmat As String)
        unId = ID
        unEtat = Etat
        unNom = Nom

        Dim typeEngin As DataTable = Connexion.ORA.Table("INSERT INTO ENGIN (ENGIN_ID, ENGIN_ETAT, ENGIN_NOM, CIS_ID, TYPE_ENG_ID, ENGIN_IMMAT) VALUES ();")

    End Sub
End Class