Public Class PF1

    Private sinistre As New Sinistre(1, "Malaise")
    Private caserne As New Caserne(1, "Brest")


    Private Sub PF1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ContainerDepart.Controls.Clear()
        Dim departType As DataTable = Connexion.ORA.Table("SELECT TYPE_ENG_PLACES, TYPE_ENG_NOM FROM PREVU, TYPE_ENGIN te WHERE(PREVU.TYPE_ENG_ID = te.TYPE_ENG_ID) AND SIN_ID = " & sinistre.ID)
        'Dim departType As DataTable = Connexion.ORA.Table("SELECT CIS_NOM as TYPE_ENG_NOM FROM CASERNE")

        Dim index As Integer = 0
        For Each camion As DataRow In departType.Rows
            Dim group As New GroupBox
            Dim text As New Label
            Dim text2 As New Label
            Dim button As New Button

            text.Text = camion("TYPE_ENG_PLACES")
            text.Dock = DockStyle.Left
            text2.Text = camion("TYPE_ENG_NOM")
            text2.Dock = DockStyle.Left
            button.Text = "Consulter"
            button.Dock = DockStyle.Right
            button.Height = 15

            group.Controls.Add(text)
            group.Controls.Add(text2)
            group.Controls.Add(button)
            group.Dock = DockStyle.Top
            group.Height = 50

            Panel1.Controls.Add(group)
        Next
    End Sub

    ' A METTRE DANS LA CLASSE DEPART
    'Public Function AfficheDepart(ByVal depart As Depart)
    '    depart()

    '    Return "";
    'End Function

    Private Sub ContainerDepart_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainerDepart.Enter

    End Sub

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class