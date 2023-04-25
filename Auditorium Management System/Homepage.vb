Imports System.Data.SqlClient
Imports System.Threading

Public Class Homepage
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Left -= 5

        ' If the label goes off the left edge of the form, reset its position to the right edge '
        If Label2.Left + Label2.Width < 0 Then
            Label2.Left = Me.ClientSize.Width
        End If

        ' Retrieve the events and dates of events available in the BookingDetails table '
        Dim connString As String = "Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True"
        Dim query As String = "SELECT Eventname, DateOfbooking FROM BookingDetails"
        Dim dt As New DataTable()

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        ' Build the scrolling text by concatenating the event names and dates of events '
        Dim scrollingText As String = ""

        For Each row As DataRow In dt.Rows
            scrollingText &= row("Eventname").ToString() & " (" & DateTime.Parse(row("DateOfbooking").ToString()).ToString("MMMM dd, yyyy") & ")" & " | "
        Next

        ' Update the label text with the scrolling text '
        Label2.Text = scrollingText

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        Allbookings.Show()
    End Sub
End Class