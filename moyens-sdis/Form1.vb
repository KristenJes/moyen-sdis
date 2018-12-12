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

        'Dim caserne As New Caserne(Connexion.ORA.Champ("SELECT * FROM Caserne"), True)



    End Sub

    Private Sub SocGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SocGrid.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub





















    Public Shared Function connecter()
        Dim Connexion As String = "Server=localhost;Database=test;Uid=root;Pwd=;"
        Dim conn As MySqlConnection = New MySqlConnection

        conn.ConnectionString = Connexion
        conn.Open()
        Return conn
    End Function






    Private Sub SetLatLong()
        Dim casernes As DataTable = Connexion.ORA.Table("SELECT * FROM Caserne")
        Dim villes As New DataTable()


        Dim lecteur As MySqlDataReader
        Dim Requete As String
        connecter.Close()
        connecter()
        Requete = "SELECT ville_nom, ville_latitude_deg, ville_longitude_deg FROM villes_fr"
        Dim Commande As New MySqlCommand(Requete, connecter)
        lecteur = Commande.ExecuteReader

        Dim count As Integer

        Do While lecteur.Read
            For Each caserne As DataRow In casernes.Rows

                Dim nomVille As String = lecteur.GetString("ville_nom")

                If (lecteur.GetString("ville_nom").StartsWith("SAINT")) Then
                    nomVille = lecteur.GetString("ville_nom").Replace("-", " ")
                End If


                If nomVille = caserne("CIS_NOM") Then
                    Connexion.ORA.Execute("UPDATE Caserne SET CIS_LAT = '" & lecteur.GetString("ville_latitude_deg") & "', CIS_LONG = '" & lecteur.GetString("ville_longitude_deg") & "' WHERE CIS_ID = '" & caserne("CIS_ID") & "'")
                    count += 1
                    GoTo end_of_for
                End If

            Next

end_of_for:
        Loop

        connecter.Close()

        MessageBox.Show("Count : " & count.ToString())
    End Sub

    Private Sub SetLatLong2()
        Dim casernes As DataTable = Connexion.ORA.Table("SELECT * FROM Commune")
        Dim villes As New DataTable()


        Dim lecteur As MySqlDataReader
        Dim Requete As String
        connecter.Close()
        connecter()
        Requete = "SELECT ville_nom, ville_latitude_deg, ville_longitude_deg FROM villes_fr"
        Dim Commande As New MySqlCommand(Requete, connecter)
        lecteur = Commande.ExecuteReader

        Dim count As Integer

        Do While lecteur.Read
            For Each caserne As DataRow In casernes.Rows

                Dim nomVille As String = lecteur.GetString("ville_nom")

                If (lecteur.GetString("ville_nom").StartsWith("SAINT")) Then
                    nomVille = lecteur.GetString("ville_nom").Replace("-", " ")
                End If


                If nomVille = caserne("NOM_COMMUNE") Then
                    Connexion.ORA.Execute("UPDATE COMMUNE SET LAT_COMMUNE = '" & lecteur.GetString("ville_latitude_deg") & "', LONG_COMMUNE = '" & lecteur.GetString("ville_longitude_deg") & "' WHERE CODE_COMMUNE = '" & caserne("CODE_COMMUNE") & "'")
                    count += 1
                    GoTo end_of_for
                End If

            Next

end_of_for:
        Loop

        connecter.Close()

        MessageBox.Show("Count : " & count.ToString())
    End Sub

End Class
