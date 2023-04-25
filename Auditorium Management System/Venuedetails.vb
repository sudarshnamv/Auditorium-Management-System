Imports System.Data.SqlClient

Public Class Venuedetails
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
    Private Sub Venuedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter(" SELECT * FROM venuedetails", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 150
        Next
        DataGridView1.Columns(4).Width = 500
        'DataGridView1.Columns(1).Width = 500
        'DataGridView1.Columns(2).Width = 500
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

    Private Sub btnAddVenue_Click(sender As Object, e As EventArgs) Handles btnAddVenue.Click
        Me.Hide()
        Venueadd.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Columns(0).Width = 500
        DataGridView1.Columns(1).Width = 500
        DataGridView1.Columns(2).Width = 500

        'DataGridView1.Rows(0).Height = 400
        'DataGridView1.Rows(1).Height = 400
        'DataGridView1.Rows(2).Height = 400
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Hide()
        Deletevenue.Show()
    End Sub
End Class