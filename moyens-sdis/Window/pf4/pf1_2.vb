Public Class pf1_2

    Shared nIntervention As Integer
    Shared nDepart As Integer
    Private TypeVeh As String

    Public Shared Sub First_Load(ByVal Intervention, ByVal Depart)
        nIntervention = Intervention
        nDepart = Depart


    End Sub



    Private Sub pf1_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



retour:
        TypeVeh = InputBox("Type de véhicule")
        Dim vehicule As Integer
        Select Case TypeVeh


            Case "VSAV"

                vehicule = 1


            Case "VTU"

                vehicule = 2

            Case "VL"

                vehicule = 3

            Case "CCF"

                vehicule = 4

            Case "FPT"

                vehicule = 5

            Case "VLHR"

                vehicule = 6

        End Select

        Dim engin As DataRow = Connexion.ORA.Champ("SELECT ENGIN_NOM FROM ENGIN WHERE TYPE_ENG_ID=" & vehicule & " AND CIS_ID='1';")
        lblCaserne.Text = engin(0).ToString

        Dim caserne As DataRow = Connexion.ORA.Champ("SELECT CIS_NOM FROM CASERNE WHERE CIS_ID=1;")
        Label1.Text = caserne(0).ToString



        Select Case TypeVeh

            Case "VL"
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
                Grade1.Text = "CA VL"
                Grade2.Text = "COND VL"
                Pompier1.Text = "SELECT SP_PRENOM || SP_NOM FROM POMPIER, DEPART, PARTICIPE WHERE PARTICIPE.DEP_ID=DEPART.DEP_ID AND POMPIER.SP_MATRICULE=DEPART.SP_MATRICULE AND DEPART.INTERV_ID=INTERVENTION.INTERV_ID AND DEP_ID="" AND INTERV_ID=""; "
                Pompier2.Text = ""
                Button1.Location = New Point(27, 137)
                Button2.Location = New Point(184, 137)

            Case "VLHR"
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
                Grade1.Text = "CA VLHR"
                Grade2.Text = "COND VLHR"
                Pompier1.Text = ""
                Pompier2.Text = ""

                Button1.Location = New Point(27, 137)
                Button2.Location = New Point(184, 137)


            Case "VTU"
                Grade4.Hide()
                Grade5.Hide()
                Grade6.Hide()
                Pompier4.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 100
                GroupBox1.Width = 297
                Grade1.Text = "CA VTU"
                Grade2.Text = "COND VTU"
                Grade3.Text = "EQU VTU"
                Pompier1.Text = ""
                Pompier2.Text = ""
                Pompier3.Text = ""


                Button1.Location = New Point(27, 170)
                Button2.Location = New Point(184, 170)



            Case "VSAV"
                Grade4.Hide()
                Grade5.Hide()
                Grade6.Hide()
                Pompier4.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 100
                GroupBox1.Width = 297
                Grade1.Text = "CA VSAV"
                Grade2.Text = "COND VSAV"
                Grade3.Text = "EQU VSAV"
                Pompier1.Text = ""
                Pompier2.Text = ""
                Pompier3.Text = ""


                Button1.Location = New Point(27, 170)
                Button2.Location = New Point(184, 170)
            Case "CCF"
                Grade5.Hide()
                Grade6.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 133
                GroupBox1.Width = 297
                Grade1.Text = "CA CCF"
                Grade2.Text = "COND CCF"
                Grade3.Text = "CE CCF"
                Grade4.Text = "EQU CCF"
                Pompier1.Text = ""
                Pompier2.Text = ""
                Pompier3.Text = ""
                Pompier4.Text = ""

                Button1.Location = New Point(27, 197)
                Button2.Location = New Point(184, 197)

            Case "FPT"
                GroupBox1.Height = 188
                GroupBox1.Width = 297
                Button1.Location = New Point(32, 259)
                Button2.Location = New Point(184, 259)
                Grade1.Text = "CA FPT"
                Grade2.Text = "COND FPT"
                Grade3.Text = "CE FPT"
                Grade4.Text = "CE FPT"
                Grade5.Text = "EQU FPT"
                Grade6.Text = "EQU FPT"
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




End Class
