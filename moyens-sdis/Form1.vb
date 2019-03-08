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

        'Panel1.Controls.Add(Engin_Display(New Engin(14, "VSAV01", "Assigné", New TypeEngin(15, "VSAV", 4))))

        'MessageBox.Show(oui(3, 3))





    End Sub







    Public Sub generateEngin()
        Dim casernes As DataTable = Connexion.ORA.Table("Select * from caserne")
        Dim types As DataTable = Connexion.ORA.Table("Select * from type_engin")

        Dim num As Integer = 158

        For Each row As DataRow In casernes.Rows
            Dim random As New Random()
            Dim rndnbr As Integer = random.Next(1, types.Rows.Count)


            For index = 1 To rndnbr
                Dim type_engin As DataRow = Connexion.ORA.Champ("Select * from type_engin WHERE TYPE_ENG_ID = " & index)
                Dim immat As String = oui(3, 3)
                Connexion.ORA.Execute("INSERT INTO Engin (ENGIN_ID, ENGIN_ETAT, ENGIN_NOM, CIS_ID, TYPE_ENG_ID, ENGIN_IMMAT) VALUES(" & num & ", 'OK', '" & type_engin("TYPE_ENG_NOM") & "', " & row("CIS_ID") & ", " & type_engin("TYPE_ENG_ID") & ", '" & immat & "')")

                num += 1
            Next

        Next
    End Sub



    Public Function oui(ByVal taille, ByVal nb)
        Dim validchars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim sb As String = ""
        Dim rand As New Random()

        For index = 1 To nb
            For i As Integer = 1 To taille
                Dim idx As Integer = rand.Next(0, validchars.Length)
                Dim randomChar As Char = validchars(idx)
                sb &= (randomChar)
            Next i

            If (nb <> index) Then
                sb &= "-"
            End If
        Next


        Return sb
    End Function




    Public Function Engin_Display(ByVal camion As Engin)
        Dim group As New GroupBox
        Dim typeEnginText As New Label
        Dim text2 As New Label
        Dim text3 As New Label
        Dim button As New Button

        typeEnginText.Text = camion.Type.nom
        typeEnginText.Dock = DockStyle.Left
        typeEnginText.Width = 125
        typeEnginText.AutoSize = False

        text2.Text = camion.Nom
        text2.Dock = DockStyle.Left
        text2.Width = 125
        text2.AutoSize = False

        text3.Text = camion.Etat
        text3.Dock = DockStyle.Left
        text3.Width = 125
        text3.AutoSize = False

        button.Text = "Consulter"
        button.Dock = DockStyle.Right
        button.Height = 15
        button.Width = 50

        group.Controls.Add(typeEnginText)
        group.Controls.Add(text2)
        group.Controls.Add(text3)
        group.Controls.Add(button)
        group.Dock = DockStyle.Top
        group.Height = 50
        button.Width = 100%

        Return group
    End Function














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
