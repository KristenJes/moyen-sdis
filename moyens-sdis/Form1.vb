Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connexion.ORA.Execute("INSERT INTO PREVU VALUES(1, 3)")

        Dim table As DataTable = Connexion.ORA.Table("SELECT * FROM PREVU")
        SocGrid.DataSource = table

        'Label1.Text = ""
        'For Each row As DataRow In table.Rows
        '    ' Write value of first Integer.
        '    Label1.Text += row("SIN_NATURE") + ", "
        'Next

        'Dim s As String = table.Rows(1)("SP_NOM").ToString()
        'Label1.Text = s

    End Sub

    Private Sub SocGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SocGrid.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

End Class
