Imports System.IO

Public Class BillForm
    Public Property TransactionID As String
    Public Property TransactionDate As DateTime
    Public Property TotalAmount As Decimal

    Public Sub New(transactionID As String, transactionDate As DateTime, totalAmount As Decimal)
        Me.TransactionID = transactionID
        Me.TransactionDate = transactionDate
        Me.TotalAmount = totalAmount
        InitializeComponent()
    End Sub

    Private Sub BillForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTransactionID.Text = TransactionID
        lblTransactionDate.Text = TransactionDate.ToString("dd/MM/yyyy hh:mm:ss tt")
        lblTotalAmount.Text = TotalAmount.ToString("0.00")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Create a new instance of the SaveFileDialog class
        Dim saveFileDialog As New SaveFileDialog()

        ' Set the default file name and extension
        saveFileDialog.FileName = $"{TransactionID}.txt"
        saveFileDialog.DefaultExt = ".txt"

        ' Show the SaveFileDialog and wait for the user to select a file
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Write the details to the selected file
            Using writer As New StreamWriter(saveFileDialog.FileName)
                writer.WriteLine($"Transaction ID: {TransactionID}")
                writer.WriteLine($"Transaction Date: {TransactionDate.ToString("dd/MM/yyyy hh:mm:ss tt")}")
                writer.WriteLine($"Total Amount: {TotalAmount.ToString("0.00")}")
            End Using

            MessageBox.Show("Details saved successfully.")
        End If
    End Sub
End Class