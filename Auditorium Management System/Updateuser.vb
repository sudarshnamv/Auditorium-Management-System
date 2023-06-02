Imports System.Data.SqlClient

Public Class Updateuser
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable()
    Dim command As New SqlCommandBuilder()

    Private Sub Updateuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load all users into DataGridView
        adapter = New SqlDataAdapter("SELECT * FROM userregistration", con)
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Search for users whose username matches the search string
        adapter = New SqlDataAdapter("SELECT * FROM userregistration WHERE username LIKE '%" & txtSearch.Text & "%'", con)
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            e.CellStyle.BackColor = Color.SteelBlue
        Else
            e.CellStyle.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Fill in the selected user's details into the textboxes
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtUsername.Text = row.Cells("username").Value.ToString()
            txtPassword.Text = row.Cells("password").Value.ToString()
            lbl1.Text = row.Cells("email").Value.ToString()
            txtPhn.Text = row.Cells("phone").Value.ToString()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Update the selected user's details in the database
        If txtUsername.Text = "" Or txtPassword.Text = "" Or lbl1.Text = "" Or txtPhn.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
        Else
            con.Open()
            Dim cmd As New SqlCommand("UPDATE userregistration SET password=@password, email=@email, phone=@phone WHERE username=@username", con)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@email", lbl1.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhn.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("User details updated successfully.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        User.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        User.Show()
    End Sub
End Class