Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New Connexion("cnx_oraD22", "SDIS29", "Iroise29")
        Dim table As DataTable = conn.Table("SELECT * FROM POMPIER")


        SocGrid.DataSource = table

        For Each row As DataRow In table.Rows
            ' Write value of first Integer.
            Label1.Text = row("SP_NOM")
            GoTo end_of_for
        Next

end_of_for:

        Dim s As String = table.Rows(1)("SP_NOM").ToString()
        'Label1.Text = ss

    End Sub

    Private Sub SocGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SocGrid.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
