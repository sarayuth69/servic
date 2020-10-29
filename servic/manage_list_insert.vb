
Imports MySql.Data.MySqlClient
Public Class manage_list_insert

    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"

    Public Sub show()
        Dim conn As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read As MySqlDataReader

        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With

        com.Connection = conn
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM `stock_pos`"

        read = com.ExecuteReader()

        If read.HasRows = True Then
            While read.Read
                Guna2DataGridView1.Rows.Add(read("Stock_ID"), read("Stock_name"))
            End While

        End If


    End Sub

    Private Sub manage_list_insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show()
    End Sub
    Public name As String
    Private Sub Guna2DataGridView1_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Guna2DataGridView1.CellMouseUp
        name = Guna2DataGridView1.Rows(e.RowIndex).Cells("Column2").Value.ToString()
        Me.Close()
    End Sub
End Class