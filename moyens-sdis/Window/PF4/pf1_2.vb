Public Class pf1_2
<<<<<<< HEAD

=======
    Dim nIntervention As Integer
    Dim nDepart As Integer
    Private TypeVeh As String

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
                Grade1.Text = "CA VL"
                Grade2.Text = "COND VL"
                Pompier1.Text = ""
                Pompier2.Text = ""
>>>>>>> 20395ec557354476edb9b15c27611f96d3115cab

                Button1.Location = New Point(27, 137)
                Button2.Location = New Point(184, 137)

<<<<<<< HEAD
    Private Sub pf1_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ListBox1.Items.Add("BREST")
        'ListBox1.Items.Add("OUESSANT")
        'ListBox1.Items.Add("SAINT RENAN")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
=======

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

>>>>>>> 20395ec557354476edb9b15c27611f96d3115cab

    End Sub

<<<<<<< HEAD
    Private Sub lblCa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCa.Click
=======
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
>>>>>>> 20395ec557354476edb9b15c27611f96d3115cab

    End Sub

<<<<<<< HEAD
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblNomCa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNomCa.Click

    End Sub

    Private Sub lblCaserne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaserne.Click

    End Sub
End Class
=======
    Private Sub lblCaserne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaserne.Click
        ' Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND CIS_NOM='" & Caserne & "';")
    End Sub

    
End Class
>>>>>>> 20395ec557354476edb9b15c27611f96d3115cab
