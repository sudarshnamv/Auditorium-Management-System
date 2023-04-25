Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Deletevenue
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")

    'Private Sub Deletevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Hide()
        Venuedetails.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM Venuedetails WHERE venueid=@venueid", con)
        cmd.Parameters.AddWithValue("@venueid", TextBox1.Text)
        con.Open()
        If cmd.ExecuteNonQuery() = 1 Then
            MessageBox.Show("venue Deleted")
            Venuedetails.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error. Check Details again!")
        End If
        con.Close()

        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Venuedetails", con)

        ' Create a DataTable to hold the data
        Dim dt As DataTable = New DataTable()

        ' Fill the DataTable with the data from the database
        da.Fill(dt)

        ' Set the DataSource of your DataGridView to the DataTable
        Venuedetails.DataGridView1.DataSource = dt

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Venuedetails.Show()
    End Sub
End Class