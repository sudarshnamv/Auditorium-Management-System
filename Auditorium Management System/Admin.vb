Imports Microsoft.VisualBasic.ApplicationServices

Public Class Admin
    Private Sub btnUserInfo_MouseHover(sender As Object, e As EventArgs) Handles btnUserInfo.MouseHover
        btnUserInfo.BackColor = Color.Transparent
    End Sub

    Private Sub btnBookingHistory_MouseHover(sender As Object, e As EventArgs) Handles btnBookingHistory.MouseHover
        btnBookingHistory.BackColor = Color.Transparent
    End Sub



    Private Sub btnNewVenue_Click(sender As Object, e As EventArgs) Handles btnNewVenue.Click
        Dim venuedetailsForm As New Venuedetails()
        venuedetailsForm.Show()
        Me.Hide()
    End Sub



    'Private Sub btnNewVenue_Click(sender As Object, e As EventArgs) Handles btnNewVenue.Click
    '    Me.Hide()
    '    Venuedetails.Show()
    'End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub btnBookingHistory_Click(sender As Object, e As EventArgs) Handles btnBookingHistory.Click
        Me.Hide()
        Booking.Show()
    End Sub

    Private Sub btnUserInfo_Click(sender As Object, e As EventArgs) Handles btnUserInfo.Click
        Me.Hide()
        User.Show()
    End Sub



    Private Sub btnNewVenue_MouseHover(sender As Object, e As EventArgs) Handles btnNewVenue.MouseHover
        btnNewVenue.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Feedbacksee.Show()
    End Sub
End Class