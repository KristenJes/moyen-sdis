Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connexion.ORA.Execute("INSERT INTO PREVU VALUES(1, 3)")

        'Dim table As DataTable = Connexion.ORA.Table("SELECT * FROM PREVU")
        'SocGrid.DataSource = table

        'Label1.Text = ""
        'For Each row As DataRow In table.Rows
        '    ' Write value of first Integer.
        '    Label1.Text += row("SIN_NATURE") + ", "
        'Next

        'Dim s As String = table.Rows(1)("SP_NOM").ToString()
        Label1.Text = " kjdlkjsqlhsqkjh lkqsjhf skqjfh skqjfhqskjfh "
        Label1.Width = 125

        Dim caserne As New Caserne(Connexion.ORA.Champ("SELECT * FROM Caserne"), True)

    End Sub

    Private Sub SocGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SocGrid.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub SetLatLong()
        Dim casernes As DataTable = Connexion.ORA.Table("SELECT * FROM Caserne")

        For Each caserne As DataRow In casernes.Rows
            For Each ville As DataRow In villes.Rows
                If ville("ville_nom_reel") = caserne("CIS_NOM") Then
                    Connexion.ORA.Execute("UPDATE Caserne SET CIS_LAT = '" & ville("ville_latitude_deg") & "', CIS_LONG = '" & ville("ville_longitude_deg") & "' WHERE CIS_ID = '" & caserne("CIS_ID") & "'")
                    GoTo end_of_for
                End If
            Next
end_of_for:
        Next
    End Sub

    '    Private Sub SetLatLongCommune()
    '         A FAIIRE
    '        Dim communes As DataTable = Connexion.ORA.Table("SELECT * FROM Commune")
    '        Dim villes As DataTable = Connexion.MySQL.Table("SELECT * FROM villes_fr")

    '        For Each commune As DataRow In communes.Rows
    '            For Each ville As DataRow In villes.Rows
    '                If ville("ville_nom_reel") = Caserne("CIS_NOM") Then
    '                    Connexion.ORA.Execute("UPDATE Caserne SET CIS_LAT = '" & ville("ville_latitude_deg") & "', CIS_LONG = '" & ville("ville_longitude_deg") & "' WHERE CIS_ID = '" & Caserne("CIS_ID") & "'")
    '                    GoTo end_of_for
    '                End If
    '            Next
    'end_of_for:
    '        Next
    '    End Sub

End Class
