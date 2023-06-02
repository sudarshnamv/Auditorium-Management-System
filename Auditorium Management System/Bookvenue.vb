Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
'Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Bookvenue
    Private connectionString As String = "Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True"



    Private Sub LoadAvailableAuditoriums(ByVal dateofbooking As Date)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim sql As String = "SELECT DISTINCT venue FROM venuedetails WHERE venue NOT IN (SELECT DISTINCT venue FROM bookingdetails WHERE dateofbooking = @dateofbooking)"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@dateofbooking", dateofbooking)

                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim availableVenues As New List(Of String)()

                    While reader.Read()
                        availableVenues.Add(reader.GetString(0))
                    End While

                    ComboBox1.DataSource = availableVenues
                End Using
            End Using
        End Using
    End Sub

    Private Sub Bookvenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.MinDate = DateTime.Today ' Set the minimum selectable date to the current date
        DateTimePicker1.Value = DateTime.Today ' Set the default date to the current date
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eventName As String = txtEventname.Text
        Dim dateofbooking As DateTime = DateTimePicker1.Value
        Dim venue As String = ""
        If ComboBox1.SelectedItem IsNot Nothing Then
            venue = ComboBox1.SelectedItem.ToString()
        End If
        Dim eventInCharge As String = txtIncharge.Text
        Dim phoneNo As String = txtPhone.Text
        Dim department As String = txtDepartment.Text

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Check if the selected venue and date are already booked
            Dim sql As String = "SELECT COUNT(*) FROM bookingdetails WHERE Venue = @Venue AND DateOfBooking = @dateofbooking"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Venue", venue)
                command.Parameters.AddWithValue("@dateofbooking", dateofbooking)
                Dim count As Integer = CInt(command.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Venue is already booked for the date chosen. Please choose a different venue or date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End Using

            ' Add the booking to the database
            sql = "INSERT INTO bookingdetails (EventName, DateOfBooking, Venue, EventInCharge, PhoneNo, Department) VALUES (@EventName, @dateofbooking, @Venue, @EventInCharge, @PhoneNo, @Department)"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@EventName", eventName)
                command.Parameters.AddWithValue("@dateofbooking", dateofbooking)
                command.Parameters.AddWithValue("@Venue", venue)
                command.Parameters.AddWithValue("@EventInCharge", eventInCharge)
                command.Parameters.AddWithValue("@PhoneNo", phoneNo)
                command.Parameters.AddWithValue("@Department", department)
                command.ExecuteNonQuery()
            End Using
        End Using

        If String.IsNullOrEmpty(eventName) OrElse String.IsNullOrEmpty(eventInCharge) OrElse String.IsNullOrEmpty(phoneNo) OrElse String.IsNullOrEmpty(department) OrElse String.IsNullOrEmpty(venue) Then
            MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        LoadAvailableAuditoriums(dateofbooking)

        Dim totalSeatsAvailable As Integer = GetTotalSeatsAvailable(dateofbooking, venue)
        Dim bookedSeats As Integer = Integer.Parse(TextBox1.Text)
        Dim availableSeats As Integer = totalSeatsAvailable - bookedSeats
        If availableSeats <= 0 Then
            MessageBox.Show("Not enough seats in the venue. Please try a different venue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Successfully booked!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim bookingConf As New BookingConf(eventName, dateofbooking, venue)
            bookingConf.Show()
        End If
        txtEventname.Clear()
        txtIncharge.Clear()
        txtPhone.Clear()
        txtDepartment.Clear()
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Userlogin.Show()
    End Sub

    Private Function GetTotalSeatsAvailable(ByVal dateofbooking As Date, ByVal venue As String) As Integer
        Dim totalSeats As Integer = 0
        Dim bookedSeats As Integer = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Get the capacity of the venue
            Dim sql As String = "SELECT capacity FROM venuedetails WHERE venue = @venue"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@venue", venue)
                totalSeats = Convert.ToInt32(command.ExecuteScalar())
            End Using

            ' Get the number of booked seats for the selected date
            sql = "SELECT SUM(capacity) 
FROM bookingdetails b 
INNER JOIN venuedetails v ON b.Venue = v.Venue 
WHERE b.dateofbooking = @dateofbooking AND v.Venue = @venue"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@dateofbooking", dateofbooking)
                command.Parameters.AddWithValue("@venue", venue)

                ' Assign the value in TextBox1 to bookedSeats if it's not empty or null
                If Not String.IsNullOrEmpty(TextBox1.Text) Then
                    bookedSeats = Convert.ToInt32(TextBox1.Text)
                End If
            End Using
        End Using

        Return totalSeats - bookedSeats
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.SelectedItem IsNot Nothing Then
            If String.IsNullOrEmpty(TextBox1.Text) Then
                MessageBox.Show("Please enter the number of booked seats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim totalSeatsAvailable As Integer = GetTotalSeatsAvailable(DateTimePicker1.Value, ComboBox1.SelectedItem.ToString())
                Dim bookedSeats As Integer = Integer.Parse(TextBox1.Text)
                Dim availableSeats As Integer = totalSeatsAvailable - bookedSeats
                If availableSeats >= 0 Then
                    MessageBox.Show("Total seats available: " & availableSeats.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf availableSeats < 0 Then
                    MessageBox.Show("Not enough seats. Try changing the Venue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Please select a venue first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub txtEventname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEventname.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker1.Focus()
        End If
    End Sub
    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub
    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub
    Private Sub Button2_KeyDown(sender As Object, e As KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtIncharge.Focus()
        End If
    End Sub

    Private Sub txtIncharge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIncharge.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
        End If
    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        ' Allow only numeric keys, Backspace, and Delete
        If Not (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) AndAlso
        e.KeyCode <> Keys.Back AndAlso
        e.KeyCode <> Keys.Delete Then
            e.SuppressKeyPress = True
            Return
        End If

        ' Limit the length of the phone number to 10 characters
        If txtPhone.Text.Length >= 10 AndAlso
        e.KeyCode <> Keys.Back AndAlso
        e.KeyCode <> Keys.Delete Then
            e.SuppressKeyPress = True
            Return
        End If

        If e.KeyCode = Keys.Enter Then
            txtDepartment.Focus()
        End If
    End Sub

    Private Sub txtDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepartment.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True ' prevent the "ding" sound
            Button1.Focus()
            Button1.PerformClick()
        End If

    End Sub

End Class