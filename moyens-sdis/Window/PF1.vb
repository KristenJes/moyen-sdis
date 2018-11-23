Public Class PF1

    Private departs As List(Of Depart)


    Private Sub PF1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each depart As Depart In departs

        Next

    End Sub


    ' A METTRE DANS LA CLASSE DEPART
    'Public Function AfficheDepart(ByVal depart As Depart)
    '    depart()

    '    Return "";
    'End Function
End Class