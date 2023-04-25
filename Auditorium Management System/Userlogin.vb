Imports System.Windows

Public Class Userlogin
    Public loggedInUser As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(loggedInUser As String)
        InitializeComponent()
        loggedInUser = loggedInUser
        lblLoggedInUser.Text = "Logged in as: " & loggedInUser
    End Sub


    Private Sub btnBookingHistory_Click(sender As Object, e As EventArgs) Handles btnBookingHistory.Click
        Me.Hide()
        Bookvenue.Show()
    End Sub







    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub btnVenueDetails_Click(sender As Object, e As EventArgs) Handles btnVenueDetails.Click
        Me.Hide()
        Venuedetailsuser.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Allbookings.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Hide()
            Inventory.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class