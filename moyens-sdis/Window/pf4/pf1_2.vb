Public Class pf1_2

    Private nbpomp As Integer

    Private Sub pf1_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
retour:
        nbpomp = InputBox("combien de pompier")


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
                Button1.Location = New Point(27, 170)
                Button2.Location = New Point(184, 170)
            Case 4
                Grade5.Hide()
                Grade6.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 133
                GroupBox1.Width = 297
                Button1.Location = New Point(27, 197)
                Button2.Location = New Point(184, 197)
            Case 5
                Grade6.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 163
                GroupBox1.Width = 297
                Button1.Location = New Point(27, 244)
                Button2.Location = New Point(184, 244)
            Case 6
                GroupBox1.Height = 188
                GroupBox1.Width = 297
                Button1.Location = New Point(32, 259)
                Button2.Location = New Point(184, 259)

            Case Else
                GoTo retour
        End Select
    End Sub

    
    Private Sub lblCa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grade1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grade2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grade3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LineShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineShape2.Click, LineShape6.Click, LineShape5.Click, LineShape4.Click, LineShape3.Click, LineShape1.Click

    End Sub

    Private Sub ListBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pompier5.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pompier1.SelectedIndexChanged

    End Sub

    Private Sub lblCaserne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCaserne.Click
        Dim engin As DataTable = Connexion.ORA.Table("SELECT CIS_NOM, ENGIN_ETAT, ENGIN_IMMAT, ENGIN_NOM FROM CASERNE, ENGIN WHERE CASERNE.CIS_ID=ENGIN.CIS_ID AND CIS_NOM='" & Caserne & "';")
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
