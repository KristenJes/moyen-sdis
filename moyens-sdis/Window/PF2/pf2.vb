﻿Public Class pf2

    Dim nIntervention As Integer
    Dim nDepart As Integer
    Private TypeVeh As String


    Shared ncaserne As Caserne
    Shared nEngin As Engin
    Shared nPompier As List(Of Pompier)


    Public Shared Sub First_Load(ByVal Caserne As Caserne, ByVal engin As Engin, ByVal Pompiers As List(Of Pompier))
        ncaserne = Caserne
        nEngin = engin
        nPompier = Pompiers
    End Sub




    Private Sub pf1_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



retour:

        TypeVeh = InputBox("combien de pompier")
        Label1.Text = "Nom de caserne"
        lblCaserne.Text = "Nom du véhicule"


        
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

                        Grade1.Text = "CA VLHR"
                        Grade2.Text = "COND VLHR"
                        Pompier1.Text = ""
                        Pompier2.Text = ""

                        Button1.Location = New Point(27, 137)
                        Button2.Location = New Point(184, 137)


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


    Private Sub lblCaserne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaserne.Click
        ' Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND CIS_NOM='" & Caserne & "';")
    End Sub


End Class






