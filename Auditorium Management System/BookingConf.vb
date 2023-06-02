Imports System.IO

Public Class BookingConf
    Public Sub New(ByVal eventName As String, ByVal dateofbooking As Date, ByVal venue As String)
        InitializeComponent()

        ' Set the values for the booking confirmation
        lblEventName.Text = eventName
        lblDate.Text = dateofbooking.ToShortDateString()
        lblLocation.Text = venue

    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    ' Save the booking confirmation to a file or database
    '    ' Code to save the booking confirmation
    '    MessageBox.Show("Booking confirmation saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Open a SaveFileDialog to select the save location and filename
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text File (*.txt)|*.txt"
        saveFileDialog.Title = "Save Booking Confirmation"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Save the booking confirmation to a text file
            Try
                ' Create a new StreamWriter object to write to the text file
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    writer.WriteLine("Booking Confirmation")
                    writer.WriteLine()
                    writer.WriteLine("Event Name: " & lblEventName.Text)
                    writer.WriteLine("Date: " & lblDate.Text)
                    writer.WriteLine("Location: " & lblLocation.Text)
                    writer.WriteLine("Confirmation saved on: " & Date.Now.ToString())
                End Using

                ' Show a success message
                MessageBox.Show("Booking confirmation saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving the booking confirmation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub

    Private Sub BookingConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentDate.Text = Date.Now.ToShortDateString()
    End Sub
End Class