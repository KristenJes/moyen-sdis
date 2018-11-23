Public Class PF1

    Private departs As List(Of Depart)


    Private Sub PF1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ContainerDepart.Controls.Clear()

        For Each depart As Depart In departs
            Dim group As New GroupBox
            Dim text As New TextBox()

            text.Text = depart.Engin.Nom
            group.Controls.Add(text)

            ContainerDepart.Controls.Add(group)
        Next

    End Sub


    ' A METTRE DANS LA CLASSE DEPART
    'Public Function AfficheDepart(ByVal depart As Depart)
    '    depart()

    '    Return "";
    'End Function
End Class