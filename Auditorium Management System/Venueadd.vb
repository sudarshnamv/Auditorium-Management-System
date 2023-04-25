Imports System.Data.SqlClient
Imports System.IO

Public Class Venueadd
    Dim con As SqlConnection = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
    Dim cmd As SqlCommand = New SqlCommand("INSERT INTO Venuedetails (VenueName, VenueId, VenueLocation, amenities, VenueImage, Capacity) VALUES (@VenueName, @VenueId, @VenueLocation, CONVERT(varbinary(MAX), @amenities), @VenueImage, @Capacity)", con)

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'Try
        OpenFileDialog1.Multiselect = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Display selected images in PictureBox
            For Each file As String In OpenFileDialog1.FileNames
                Dim img As Image = Image.FromFile(file)
                Dim picBox As New PictureBox
                picBox.SizeMode = PictureBoxSizeMode.StretchImage
                picBox.ClientSize = New Size(100, 100)
                picBox.Image = img
                flpImages.Controls.Add(picBox)
            Next
        End If


        Dim imageBytes() As Byte = Nothing
        If flpImages.Controls.Count > 0 Then
            Using stream As New MemoryStream()
                For Each picBox As PictureBox In flpImages.Controls
                    picBox.Image.Save(stream, picBox.Image.RawFormat)
                Next
                imageBytes = stream.ToArray()
            End Using
        End If



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO Venuedetails (Venue, VenueId, VenueLocation, amenities, VenueImage, Capacity) VALUES (@Venue, @VenueId, @VenueLocation, CONVERT(varbinary(MAX), @amenities), @VenueImage, @Capacity)", con)

        ' Convert the images to byte arrays
        Dim imageBytes() As Byte = Nothing
        If flpImages.Controls.Count > 0 Then
            Using stream As New MemoryStream()
                For Each picBox As PictureBox In flpImages.Controls
                    picBox.Image.Save(stream, picBox.Image.RawFormat)
                Next
                imageBytes = stream.ToArray()
            End Using
        End If

        cmd.Parameters.Add("@Venue", SqlDbType.VarChar).Value = txtVenueName.Text
        cmd.Parameters.Add("@VenueId", SqlDbType.VarChar).Value = txtVenueId.Text
        cmd.Parameters.Add("@VenueLocation", SqlDbType.VarChar).Value = txtVenueLocation.Text
        cmd.Parameters.Add("@amenities", SqlDbType.VarChar).Value = txtAmenities.Text
        cmd.Parameters.Add("@capacity", SqlDbType.VarChar).Value = txtCapacity.Text
        cmd.Parameters.Add("@VenueImage", SqlDbType.VarBinary).Value = imageBytes
        ' Open the connection to the database
        con.Open()

        ' Execute the SQL command
        cmd.ExecuteNonQuery()




        Dim da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Venuedetails", con)

        ' Create a DataTable to hold the data
        Dim dt As DataTable = New DataTable()

        ' Fill the DataTable with the data from the database
        da.Fill(dt)

        ' Set the DataSource of your DataGridView to the DataTable
        Venuedetails.DataGridView1.DataSource = dt

        ' Display a success message
        MessageBox.Show("Venue added successfully!")
        con.Close()
        Venuedetails.Show()
        Me.Hide()

        txtVenueName.Clear()
        txtVenueId.Clear()
        txtVenueLocation.Clear()
        txtAmenities.Clear()
        txtCapacity.Clear()

        ' Clear picturebox
        flpImages.Controls.Clear()

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Venuedetails.Show()
    End Sub
End Class