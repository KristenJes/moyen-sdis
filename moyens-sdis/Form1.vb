Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As New Connexion("cnx_oraD22", "SDIS29", "Iroise29")
        Dim table As DataTable = conn.Table("SELECT * FROM POMPIER")
<<<<<<< HEAD
        'Dim table As DataTable = conn.Table("SELECT * FROM ENGIN")
=======
        Dim table2 As DataTable = conn.Table("SELECT * FROM ENGIN")
>>>>>>> 484991188d0b294eac644c80ecb5ccd11c84b346

        SocGrid.DataSource = table

    End Sub

    Private Sub SocGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SocGrid.CellContentClick

    End Sub
End Class
