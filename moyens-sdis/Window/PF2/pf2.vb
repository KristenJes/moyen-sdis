Public Class pf2

    Dim nIntervention As Integer
    Dim nDepart As Integer
    Private TypeVeh As String


    Shared ncaserne As Caserne
    Shared nEngin As Engin
    Shared nPompier As List(Of Pompier)


    Public Sub First_Load(ByVal Caserne As Caserne, ByVal engin As Engin, ByVal pompiers As List(Of Pompier))
        ncaserne = Caserne
        nEngin = engin
        nPompier = Pompiers

        Demarrage()
    End Sub




    Private Sub Demarrage()

        Debug.WriteLine(nPompier)


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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    

    Private Sub pf2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class






