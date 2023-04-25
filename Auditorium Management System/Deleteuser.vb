Imports System.Data.SqlClient

Public Class Deleteuser
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")

    Private Sub Deleteuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim cmd As SqlCommand = New SqlCommand("DELETE FROM userregistration WHERE empid=@empid", con)
            cmd.Parameters.AddWithValue("@empid", TextBox1.Text)
            con.Open()
            If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("User Deleted")
                User.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error. Check Details again!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class