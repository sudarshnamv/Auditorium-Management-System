Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Adduser




    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtEmpid.Focus()
        End If
    End Sub

    Private Sub txtEmpid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpid.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            cmbGender.Focus()
        End If
    End Sub

    Private Sub cmbGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbGender.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            cmbUsertype.Focus()
        End If
    End Sub

    Private Sub cmbusertype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUsertype.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtUser.Focus()
        End If
    End Sub

    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            Button1.PerformClick()
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[userregistration]
        ([name]
        ,[empid]
        ,[gender]
        ,[phone]
        ,[email]
        ,[usertype]
        ,[username]
        ,[password])
        VALUES
        ('" + txtName.Text + "','" + txtEmpid.Text + "','" + cmbGender.SelectedItem.ToString() + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + cmbUsertype.SelectedItem.ToString() + "','" + txtUser.Text + "','" + txtPass.Text + "')", con)

        con.Open()
        cmd.ExecuteNonQuery()


        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM userregistration", con)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)

        ' Add new row to the DataTable
        Dim newRow As DataRow = dt.NewRow()
        newRow("name") = txtName.Text
        newRow("empid") = txtEmpid.Text
        newRow("gender") = cmbGender.SelectedItem.ToString()
        newRow("phone") = txtPhone.Text
        newRow("email") = txtEmail.Text
        newRow("usertype") = cmbUsertype.SelectedItem.ToString()
        newRow("username") = txtUser.Text
        newRow("password") = txtPass.Text
        dt.Rows.Add(newRow)

        ' Update the database
        da.Update(dt)

        MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

        User.Show()
        Me.Hide()
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        txtUser.Text = txtEmail.Text
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        User.Show()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.DarkOrange
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.RoyalBlue
    End Sub


End Class