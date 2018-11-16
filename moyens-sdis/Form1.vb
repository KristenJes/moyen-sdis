Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New Connexion("cnx_oraD22", "SDIS29", "Iroise29")
        Dim table As DataTable = conn.Table("SELECT * FROM POMPIER")
        Dim table2 As DataTable = conn.Table("SELECT * FROM ENGIN")

        SocGrid.DataSource = table

    End Sub

End Class
