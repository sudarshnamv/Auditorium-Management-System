Imports System.Data.SqlClient

Public Class Login
    Public Property LoggedInUser As String
    Public Property UserType As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from userregistration where username='" & txtUser.Text & "' and password='" & txtPass.Text & "' and usertype='" & cmbUserType.SelectedItem & "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You Are Logged In As " + dt.Rows(0)(5))
            Dim loggedInUser As String = dt.Rows(0)(7).ToString() ' assuming the username is in the first column of the query result
            If (cmbUserType.SelectedItem.ToString() = "admin") Then
                Admin.Show()
                Me.Hide()
            Else
                Dim u As New Userlogin(loggedInUser)
                u.Show()
                Me.Hide()
            End If
            ' Clear out the login form
            txtUser.Text = ""
            txtPass.Text = ""
            cmbUserType.SelectedIndex = -1
        Else
            MessageBox.Show("Incorrect Details")
        End If
    End Sub


    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True ' prevent the "ding" sound
            txtPass.Focus()
        End If
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True ' prevent the "ding" sound
            cmbUserType.Focus()
        End If
    End Sub

    Private Sub cmbUserType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUserType.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True ' prevent the "ding" sound
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedIndexChanged
        btnLogin.PerformClick()
    End Sub


    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs)
        btnLogin.BackColor = Color.DarkOrange
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs)
        btnLogin.BackColor = Color.SteelBlue
    End Sub
End Class
