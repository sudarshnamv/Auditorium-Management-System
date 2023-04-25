Imports System.Data.SqlClient

Public Class Booking
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter(" SELECT * FROM bookingdetails", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black 'set font color to black
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Editbooking.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Deletebooking.Show()
    End Sub
End Class