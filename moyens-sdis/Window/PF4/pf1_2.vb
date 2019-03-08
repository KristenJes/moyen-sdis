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

                Button1.Location = New Point(22, 143)
                Button2.Location = New Point(22, 199)


            Case 3
                Grade4.Hide()
                Grade5.Hide()
                Grade6.Hide()
                Pompier4.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 100
                GroupBox1.Width = 297
                Button1.Location = New Point(22, 143)
                Button2.Location = New Point(22, 199)
            Case 4
                Grade5.Hide()
                Grade6.Hide()
                Pompier5.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 133
                GroupBox1.Width = 297
                Button1.Location = New Point(22, 143)
                Button2.Location = New Point(22, 199)
            Case 5
                Grade6.Hide()
                Pompier6.Hide()
                GroupBox1.Height = 163
                GroupBox1.Width = 297
                Button1.Location = New Point(22, 143)
                Button2.Location = New Point(22, 199)
            Case 6
                GroupBox1.Height = 188
                GroupBox1.Width = 297
                Button1.Location = New Point(22, 143)
                Button2.Location = New Point(22, 199)

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
End Class
