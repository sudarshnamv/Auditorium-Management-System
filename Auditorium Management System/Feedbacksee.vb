Imports System.Data.SqlClient

Public Class Feedbacksee
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")

    Private Sub Feedbacksee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter(" SELECT * FROM feedback", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adapter As New SqlDataAdapter("SELECT * FROM feedback", con)
        Dim builder As New SqlCommandBuilder(adapter)

        DataGridView1.EndEdit()
        adapter.Update(CType(DataGridView1.DataSource, DataTable))
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class