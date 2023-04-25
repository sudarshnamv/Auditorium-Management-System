Public Class BookingConf
    Public Sub New(ByVal eventName As String, ByVal dateofbooking As Date, ByVal venue As String)
        InitializeComponent()

        ' Set the values for the booking confirmation
        lblEventName.Text = eventName
        lblDate.Text = dateofbooking.ToShortDateString()
        lblLocation.Text = venue

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save the booking confirmation to a file or database
        ' Code to save the booking confirmation
        MessageBox.Show("Booking confirmation saved successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Print the booking confirmation
        ' Code to print the booking confirmation
        MessageBox.Show("Booking confirmation printed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Userlogin.Show()
    End Sub

    Private Sub BookingConf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentDate.Text = Date.Now.ToShortDateString()
    End Sub
End Class