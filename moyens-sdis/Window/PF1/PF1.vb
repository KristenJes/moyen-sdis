Public Class PF1

    Private sinistre As New Sinistre(1, "Malaise")
    Private communeSelected As New Commune(1, "Brest")


    Private Sub PF1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ContainerDepart.Controls.Clear()
        Dim departType As DataTable = Connexion.ORA.Table("SELECT te.TYPE_ENG_ID, TYPE_ENG_PLACES, TYPE_ENG_NOM FROM PREVU, TYPE_ENGIN te WHERE(PREVU.TYPE_ENG_ID = te.TYPE_ENG_ID) AND SIN_ID = " & sinistre.ID)


        For Each type_camion As DataRow In departType.Rows
            Panel1.Controls.Add(Engin_Display(type_camion))
        Next
    End Sub


    Public Function getNearCaserne(ByVal commune As Commune, Optional ByVal casernesChecked As List(Of Caserne) = Nothing)
        Dim casernes As DataTable = Connexion.ORA.Table("SELECT * FROM Caserne")
        Dim bestCaserne As Caserne = Nothing
        Dim dist As Integer = 0

        For Each caserneStr As DataRow In casernes.Rows
            Dim caserne As New Caserne(caserneStr)
            If ((bestCaserne Is Nothing Or Utils.getDistance(commune.Latitude, commune.Longitude, caserne.Latitude, caserne.Longitude) < dist) And casernesChecked.Contains(caserne) = False) Then
                bestCaserne = caserne
            End If
        Next

        Return bestCaserne
    End Function

    Public Function Engin_Display(ByVal camion)
        Dim group As New GroupBox
        Dim typeEnginText As New Label
        Dim text2 As New Label
        Dim button As New Button

        typeEnginText.Text = camion("TYPE_ENG_PLACES")
        typeEnginText.Dock = DockStyle.Left
        typeEnginText.Width = 125
        typeEnginText.AutoSize = False

        text2.Text = camion("TYPE_ENG_NOM")
        text2.Dock = DockStyle.Left
        text2.Width = 125
        text2.AutoSize = False

        button.Text = "Consulter"
        button.Dock = DockStyle.Right
        button.Height = 15

        group.Controls.Add(typeEnginText)
        group.Controls.Add(text2)
        group.Controls.Add(button)
        group.Dock = DockStyle.Top
        group.Height = 50

        Return group
    End Function


    Private Sub ContainerDepart_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContainerDepart.Enter

    End Sub

    Private Sub btnValider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValider.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class