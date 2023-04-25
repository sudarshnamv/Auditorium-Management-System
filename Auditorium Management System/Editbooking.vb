Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient

Public Class Editbooking
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable()

    Private Sub Updateuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load all users into DataGridView
        adapter = New SqlDataAdapter("SELECT * FROM bookingdetails", con)
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Search for users whose eventname matches the search string
        adapter = New SqlDataAdapter("SELECT * FROM bookingdetails WHERE eventname LIKE '%" & txtSearch.Text & "%'", con)
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Fill in the selected user's details into the textboxes
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtUsername.Text = row.Cells("eventname").Value.ToString()
            txtPassword.Text = row.Cells("venue").Value.ToString()
            lbl1.Text = row.Cells("phoneno").Value.ToString()
            txtPhn.Text = row.Cells("dateofbooking").Value.ToString()
        End If
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Update the selected user's details in the database
        If txtUsername.Text = "" Or txtPassword.Text = "" Or lbl1.Text = "" Or txtPhn.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
        Else
            Dim cmd As New SqlCommand("UPDATE bookingdetails SET eventname=@eventname, phoneno=@phoneno, venue=@venue WHERE eventname=@oldEventName", con)
            cmd.Parameters.AddWithValue("@eventname", txtUsername.Text)
            cmd.Parameters.AddWithValue("@venue", txtPassword.Text)
            cmd.Parameters.AddWithValue("@phoneno", lbl1.Text)
            cmd.Parameters.AddWithValue("@oldEventName", DataGridView1.CurrentRow.Cells("eventname").Value.ToString())
            cmd.Parameters.AddWithValue("@dateofbooking", txtPhn.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("User details updated successfully.")
        End If
        ' Refresh the DataGridView with updated data from the database
        table.Clear()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub





    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    'Update the selected user's details in the database
    '    If txtUsername.Text = "" Or txtPassword.Text = "" Or lbl1.Text = "" Or txtPhn.Text = "" Then
    '        MessageBox.Show("Please fill in all fields.")
    '    Else
    '        Dim cmd As New SqlCommand("UPDATE bookingdetails SET eventname=@eventname, phoneno=@phoneno, venue=@venue WHERE eventname=@eventname", con)
    '        cmd.Parameters.AddWithValue("@eventname", DataGridView1.CurrentRow.Cells("eventname").Value.ToString())
    '        cmd.Parameters.AddWithValue("@eventname", txtUsername.Text)
    '        cmd.Parameters.AddWithValue("@venue", txtPassword.Text)
    '        cmd.Parameters.AddWithValue("@phoneno", lbl1.Text)
    '        cmd.Parameters.AddWithValue("@dateofbooking", txtPhn.Text)
    '        con.Open()
    '        cmd.ExecuteNonQuery()
    '        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM bookingdetails", con)
    '        ' Create a DataTable to hold the data
    '        Dim dt As DataTable = New DataTable()

    '        ' Fill the DataTable with the data from the database
    '        da.Fill(dt)
    '        con.Close()
    '        MessageBox.Show("User details updated successfully.")

    '    End If
    'End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        User.Show()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        User.Show()
    End Sub
End Class