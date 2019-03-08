Public Class pf1_2

    Private nbpomp As Integer

    Private Sub pf1_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
retour:
        nbpomp = InputBox("combien de pompier")
        Label1.Text = "Nom de caserne"
        lblCaserne.Text = "Nom du véhicule"


        Select Case nbpomp

            Case 2
                Grade3.Hide()
                Grade4.Hide()
                Grade5.Hide()
                Grade6.Hide()
                Pompier3.Hide()
                Pompier4.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 70
                GroupBox1.Width = 297
                Grade1.Text = ""
                Grade2.Text = ""
                Pompier1.Text = ""
                Pompier2.Text = ""

                Button1.Location = New Point(27, 137)
                Button2.Location = New Point(184, 137)



            Case 3
                Grade4.Hide()
                Grade5.Hide()
                Grade6.Hide()
                Pompier4.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 100
                GroupBox1.Width = 297
                Grade1.Text = ""
                Grade2.Text = ""
                Grade3.Text = ""
                Pompier1.Text = ""
                Pompier2.Text = ""
                Pompier3.Text = ""


                Button1.Location = New Point(27, 170)
                Button2.Location = New Point(184, 170)



            Case 4
                Grade5.Hide()
                Grade6.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 133
                GroupBox1.Width = 297
                Grade1.Text = ""
                Grade2.Text = ""
                Grade3.Text = ""
                Grade4.Text = ""
                Pompier1.Text = ""
                Pompier2.Text = ""
                Pompier3.Text = ""
                Pompier4.Text = ""

                Button1.Location = New Point(27, 197)
                Button2.Location = New Point(184, 197)
            Case 5
                Grade6.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 163
                GroupBox1.Width = 297
                Grade1.Text = ""
                Grade2.Text = ""
                Grade3.Text = ""
                Grade4.Text = ""
                Grade5.Text = ""
                Pompier1.Text = ""
                Pompier2.Text = ""
                Pompier3.Text = ""
                Pompier4.Text = ""
                Pompier5.Text = ""
                Button1.Location = New Point(27, 244)
                Button2.Location = New Point(184, 244)
            Case 6
                GroupBox1.Height = 188
                GroupBox1.Width = 297
                Button1.Location = New Point(32, 259)
                Button2.Location = New Point(184, 259)
                Grade1.Text = ""
                Grade2.Text = ""
                Grade3.Text = ""
                Grade4.Text = ""
                Grade5.Text = ""
                Grade6.Text = ""
                Pompier1.Text = ""
                Pompier2.Text = ""
                Pompier3.Text = ""
                Pompier4.Text = ""
                Pompier5.Text = ""
                Pompier6.Text = ""

            Case Else
                GoTo retour
        End Select
    End Sub

    Private Sub lblCaserne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaserne.Click
        ' Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND CIS_NOM='" & Caserne & "';")
    End Sub

    
End Class