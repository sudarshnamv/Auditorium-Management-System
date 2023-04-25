Imports System.Data.SqlClient

Public Class User
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim adapter As New SqlDataAdapter("SELECT * FROM userregistration", con)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black 'set font color to black

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

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Me.Hide()
        Adduser.Show()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Me.Hide()
        Deleteuser.Show()
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Updateuser.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub
End Class