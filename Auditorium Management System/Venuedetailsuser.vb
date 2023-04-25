Imports System.Data.SqlClient

Public Class Venuedetailsuser
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")

    Private Sub Venuedetailsuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter(" SELECT * FROM venuedetails", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub DataGridView1_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.RoyalBlue
        End If
    End Sub
    Private Sub DataGridView1_CellMouseLeave(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex > -1 Then
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.DimGray
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Userlogin.Show()
    End Sub
End Class