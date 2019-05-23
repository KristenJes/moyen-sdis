Public Class pf2

    Dim nIntervention As Integer
    Dim nDepart As Integer
    Private TypeVeh As String
    Dim caQuery As String
    Dim enginID As Integer
    Dim idIntervention As Integer
    Dim equQuery As String
    Dim condQuery As String
    Dim ce1Query As String
    Dim ce2Query As String
    Dim equ2Query As String

    Dim OracleUtils As Connexion
    Shared ncaserne As Caserne
    Shared nEngin As Engin
    Shared nPompier As List(Of Pompier)


    Public Sub First_Load(ByVal Caserne As Caserne, ByVal engin As Engin, ByVal pompiers As List(Of Pompier), ByVal depart As Integer)
        ncaserne = Caserne
        nEngin = engin
        nPompier = pompiers
        nDepart = depart
        OracleUtils = New Connexion("cnx_ORAD22", "SDIS29", "Iroise29")

        Demarrage()
    End Sub




    Private Sub Demarrage()




retour:

        TypeVeh = nEngin.Type.nom
        Label1.Text = ncaserne.Nom
        lblCaserne.Text = nEngin.Nom
        Me.Text = "Composition du " & lblCaserne.Text & ": Départ"

        
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
                Pompier1.Text = ""
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

                Dim fonctionEQU As Integer = 17
                Dim fonctionCOND As Integer = 12
                Dim fonctionCA As Integer = 5


                Dim equVSAV As DataTable
                equQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionEQU & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                equVSAV = OracleUtils.Table(equQuery)

                Dim caVSAV As DataTable
                caQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionCA & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                caVSAV = OracleUtils.Table(caQuery)

                Dim condVSAV As DataTable
                condQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionCOND & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                condVSAV = OracleUtils.Table(condQuery)


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
                Pompier1.Text = condVSAV.Rows(0)("SP_NOM") & " " & condVSAV.Rows(0)("SP_PRENOM")
                Pompier2.Text = caVSAV.Rows(0)("SP_NOM") & " " & caVSAV.Rows(0)("SP_PRENOM")
                Pompier3.Text = equVSAV.Rows(0)("SP_NOM") & " " & equVSAV.Rows(0)("SP_PRENOM")


                Button1.Location = New Point(27, 170)
                Button2.Location = New Point(184, 170)



            Case "VSAV"
                Dim fonctionEQU As Integer = 1
                Dim fonctionCOND As Integer = 10
                Dim fonctionCA As Integer = 4

                Dim equVSAV As DataTable
                equQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionEQU & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=3)"
                equVSAV = OracleUtils.Table(equQuery)

                Dim caVSAV As DataTable
                caQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionCA & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=3)"
                caVSAV = OracleUtils.Table(caQuery)

                Dim condVSAV As DataTable
                condQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionCOND & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=3)"
                condVSAV = OracleUtils.Table(condQuery)

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
                Pompier1.Text = condVSAV.Rows(0)("SP_NOM") & " " & condVSAV.Rows(0)("SP_PRENOM")
                Pompier2.Text = caVSAV.Rows(0)("SP_NOM") & " " & caVSAV.Rows(0)("SP_PRENOM")
                Pompier3.Text = equVSAV.Rows(0)("SP_NOM") & " " & equVSAV.Rows(0)("SP_PRENOM")


                Button1.Location = New Point(27, 170)
                Button2.Location = New Point(184, 170)
            Case "CCF"

                Dim caCCF As DataTable
                caQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=8 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=6 AND ENGIN_ID=6)"
                caCCF = OracleUtils.Table(caQuery)

                Dim condCCF As DataTable
                condQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=14 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=6 AND ENGIN_ID=6)"
                condCCF = OracleUtils.Table(condQuery)

                Dim ceCCF As DataTable
                ce1Query = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=18 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=6 AND ENGIN_ID=6)"
                ceCCF = OracleUtils.Table(ce1Query)

                Dim equCCF As DataTable
                equQuery = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=3 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=6 AND ENGIN_ID=6)"
                equCCF = OracleUtils.Table(equQuery)


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
                Pompier1.Text = caCCF.Rows(0)("SP_NOM") & " " & caCCF.Rows(0)("SP_PRENOM")
                Pompier2.Text = condCCF.Rows(0)("SP_NOM") & " " & condCCF.Rows(0)("SP_PRENOM")
                Pompier3.Text = ceCCF.Rows(0)("SP_NOM") & " " & ceCCF.Rows(0)("SP_PRENOM")
                Pompier4.Text = equCCF.Rows(0)("SP_NOM") & " " & equCCF.Rows(0)("SP_PRENOM")



                Button1.Location = New Point(27, 197)
                Button2.Location = New Point(184, 197)

            Case "FPT"

                Dim caFPT As DataTable
                caQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=7 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID= 3  AND ENGIN_ID=70 )"
                caFPT = OracleUtils.Table(caQuery)

                Dim condFPT As DataTable
                condQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=13 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=70)"
                condFPT = OracleUtils.Table(condQuery)

                Dim ce1FPT As DataTable
                ce1Query = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=19 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=70)"
                ce1FPT = OracleUtils.Table(ce1Query)

                Dim ce2FPT As DataTable
                ce2Query = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=2 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=70) AND ROWNUM=1 ORDER BY SP_NOM DESC"
                ce2FPT = OracleUtils.Table(ce2Query)

                Dim equ1FPT As DataTable
                equQuery = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=2 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=70) ORDER BY SP_NOM ASC"
                equ1FPT = OracleUtils.Table(equQuery)

                Dim equ2FPT As DataTable
                equ2Query = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=2 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=3 AND ENGIN_ID=70) AND ROWNUM=1 AND PARTICIPE.SP_MATRICULE <> " & ce2FPT.Rows(0)("SP_MATRICULE") & " AND PARTICIPE.SP_MATRICULE <> " & equ1FPT.Rows(0)("SP_MATRICULE")
                equ2FPT = OracleUtils.Table(equ2Query)

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
                Pompier1.Text = caFPT.Rows(0)("SP_NOM") & " " & caFPT.Rows(0)("SP_PRENOM")
                Pompier2.Text = condFPT.Rows(0)("SP_NOM") & " " & condFPT.Rows(0)("SP_PRENOM")
                Pompier3.Text = ce1FPT.Rows(0)("SP_NOM") & " " & ce1FPT.Rows(0)("SP_PRENOM")
                Pompier4.Text = ce2FPT.Rows(0)("SP_NOM") & " " & ce2FPT.Rows(0)("SP_PRENOM")
                Pompier5.Text = equ1FPT.Rows(0)("SP_NOM") & " " & equ1FPT.Rows(0)("SP_PRENOM")
                Pompier6.Text = equ2FPT.Rows(0)("SP_NOM") & " " & equ2FPT.Rows(0)("SP_PRENOM")

                    Case Else
                        GoTo retour
                End Select
    End Sub


    Private Sub lblCaserne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaserne.Click
        ' Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND CIS_NOM='" & Caserne & "';")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub pf2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class






