Imports System.Data.SqlClient

Public Class Inventory
    Private cart As New List(Of CartItem)
    Private total As Decimal = 0

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the inventory data from the database
        Dim connectionString As String = "Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True"
        Dim sql As String = "SELECT ItemID, ItemName, ItemPrice, ItemStock FROM Items"
        Dim adapter As New SqlDataAdapter(sql, connectionString)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        ' Create columns for the cart DataGridView contro

        Dim itemNameColumn As New DataGridViewTextBoxColumn()
        itemNameColumn.HeaderText = "Item Name"
        itemNameColumn.Name = "ItemName"


        Dim quantityColumn As New DataGridViewTextBoxColumn()
        quantityColumn.HeaderText = "Quantity"
        quantityColumn.Name = "Quantity"


        Dim itemPriceColumn As New DataGridViewTextBoxColumn()
        itemPriceColumn.HeaderText = "Item Price"
        itemPriceColumn.Name = "ItemPrice"





        ' Add the columns to the cart DataGridView control
        dgvCart.Columns.AddRange({itemNameColumn, quantityColumn, itemPriceColumn})




        ' Bind the inventory data to the DataGridView control
        dgvInventory.DataSource = dt
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        ' Check if an item is selected in the DataGridView control
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an item from the inventory.")
            Return
        End If

        ' Get the selected item from the DataGridView control
        Dim row As DataGridViewRow = dgvInventory.SelectedRows(0)
        Dim itemId As Integer = row.Cells("ItemID").Value
        Dim itemName As String = row.Cells("ItemName").Value
        Dim itemPrice As Decimal = row.Cells("ItemPrice").Value
        Dim itemStock As Integer = row.Cells("ItemStock").Value

        ' Check if the item is already in the cart
        Dim existingCartItem As CartItem = Nothing
        For Each item As CartItem In cart
            If item.ItemID = itemId Then
                existingCartItem = item
                Exit For
            End If
        Next

        ' If the item is not in the cart, add it
        If existingCartItem Is Nothing Then
            Dim newItem As New CartItem(itemId, itemName, itemPrice, 1)
            cart.Add(newItem)
        Else
            ' If the item is already in the cart, increment the quantity
            existingCartItem.Quantity += 1
        End If

        ' Update the cart display
        UpdateCartDisplay()
    End Sub



    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Generate a random transaction ID
        'Dim transactionID As String = Guid.NewGuid().ToString("N")
        Dim transactionID As String = New Random().Next(1000, 9999).ToString()
        ' Calculate the total cost of the items in the cart
        total = cart.Sum(Function(item) item.TotalPrice)

        ' Prompt the user to confirm the transaction
        Dim result As DialogResult = MessageBox.Show($"Total cost: ₹{total}. Proceed with transaction?", "Confirm Transaction", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Update the inventory stock levels and insert the transaction record
            Dim connectionString As String = "Data Source=SUDARSHNA;Initial Catalog=vbmultiuser;Integrated Security=True"
            Dim connection As New SqlConnection(connectionString)
            connection.Open()

            Dim transaction As SqlTransaction = connection.BeginTransaction()
            Try
                ' Update the inventory stock levels
                For Each item As CartItem In cart
                    Dim sql As String = $"UPDATE Items SET ItemStock = ItemStock - {item.Quantity} WHERE ItemID = {item.ItemID}"
                    Dim command As New SqlCommand(sql, connection, transaction)
                    command.ExecuteNonQuery()
                Next

                ' Insert the transaction record
                Dim now As DateTime = DateTime.Now
                Dim sqlInsert As String = $"INSERT INTO Transactions (TransactionID, TransactionDate, TotalAmount) VALUES ('{transactionID}', '{now.ToString("yyyy-MM-dd HH:mm:ss")}', {total})"
                Dim insertCommand As New SqlCommand(sqlInsert, connection, transaction)
                insertCommand.ExecuteNonQuery()

                ' Commit the transaction
                transaction.Commit()

                ' Clear the cart and update the display
                cart.Clear()
                UpdateCartDisplay()

                ' Show the bill form with the transaction details
                Dim billForm As New BillForm(transactionID, now, total)
                billForm.ShowDialog()

            Catch ex As Exception
                ' Roll back the transaction on error
                transaction.Rollback()
                MessageBox.Show($"Transaction failed: {ex.Message}")
            Finally
                ' Close the connection
                connection.Close()
            End Try
        End If
    End Sub



    Private Sub UpdateCartDisplay()
        ' Clear the cart display
        dgvCart.Rows.Clear()

        ' Add the cart items to the cart display
        For Each item As CartItem In cart
            dgvCart.Rows.Add(item.ItemName, item.Quantity, item.TotalPrice)
        Next

        ' Update the total cost display
        'lblTotal.Text = $"Total: ${total}"

    End Sub

    Public Class CartItem
        Public Property ItemID As Integer
        Public Property ItemName As String
        Public Property ItemPrice As Decimal
        Public Property Quantity As Integer

        Public ReadOnly Property TotalPrice As Decimal
            Get
                Return ItemPrice * Quantity
            End Get
        End Property

        Public Sub New(itemID As Integer, itemName As String, itemPrice As Decimal, quantity As Integer)
            Me.ItemID = itemID
            Me.ItemName = itemName
            Me.ItemPrice = itemPrice
            Me.Quantity = quantity
        End Sub
    End Class

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        'Userlogin.Show()

        Dim loginForm As New Userlogin()
        loginForm.Show()
    End Sub
End Class