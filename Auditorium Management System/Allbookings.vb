Imports System.Data.SqlClient

Public Class Allbookings
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable



    Private Sub LoadData()
        Dim query As String = "SELECT EventName, dateofbooking, Department,eventincharge, venue FROM BookingDetails WHERE dateofbooking >= @TodayDate ORDER BY dateofbooking ASC"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@TodayDate", DateTime.Now.Date)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "BookingDetails")
        dt = ds.Tables("BookingDetails")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs)
        Dim query As String = "SELECT EventName, dateofbooking, Department,eventincharge, venue FROM BookingDetails WHERE dateofbooking = @SearchDate ORDER BY dateofbooking ASC"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@SearchDate", DateTimePicker1.Value.Date)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "BookingDetails")
        dt = ds.Tables("BookingDetails")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Userlogin.Show()
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub Allbookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True")
        con.Open()
        LoadData()
    End Sub
End Class