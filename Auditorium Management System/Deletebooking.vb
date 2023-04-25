Imports System.Data.SqlClient

Public Class Deletebooking
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim eventname As String = TextBox1.Text.Trim()
        Dim cmd As SqlCommand = New SqlCommand("DELETE FROM bookingdetails WHERE eventname=@eventname", con)
        cmd.Parameters.AddWithValue("@eventname", eventname)

        If String.IsNullOrEmpty(eventname) Then
            MessageBox.Show("Please enter a valid event name.")
            Return
        End If

        con.Open()

        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Booking has been Deleted")
            Booking.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error. Check Details again!")
        End If
        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM bookingdetails", con)




        ' Create a DataTable to hold the data
        Dim dt As DataTable = New DataTable()

        ' Fill the DataTable with the data from the database
        da.Fill(dt)

        ' Set the DataSource of your DataGridView to the DataTable
        Booking.DataGridView1.DataSource = dt




        con.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Booking.Show()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class