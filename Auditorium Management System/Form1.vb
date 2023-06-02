Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Define the connection string to SQL Server
        Dim connString As String = "Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True"

        ' Create a new SqlConnection object
        Dim conn As New SqlConnection(connString)

        ' Define the SQL query to insert the feedback data into the database
        Dim sql As String = "INSERT INTO Feedback (Name, Email, Message) VALUES (@Name, @Email, @Message)"

        ' Create a new SqlCommand object
        Dim cmd As New SqlCommand(sql, conn)

        ' Set the parameter values for the SQL query
        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@Message", txtMessage.Text)

        Try
            ' Open the database connection
            conn.Open()

            ' Execute the SQL query
            cmd.ExecuteNonQuery()

            ' Display a message indicating that the feedback has been saved
            MessageBox.Show("Your feedback has been saved.", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the input fields
            txtName.Clear()
            txtEmail.Clear()
            txtMessage.Clear()
            Me.Close()
            Userlogin.Show()
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Userlogin.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class