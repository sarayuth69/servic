Imports MySql.Data.MySqlClient


Public Class Form12

    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"



    Public Sub showdata_equipment()
        DataGridView_equipment.Rows.Clear()

        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With

        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM equipment_insert INNER JOIN stock_pos ON stock_pos.Stock_ID = equipment_insert.Stock_ID"
        read_data = com.ExecuteReader
        If read_data.HasRows = True Then
            While read_data.Read
                DataGridView_equipment.Rows.Add(read_data("Number_insert"), read_data("Stock_ID"),
                                        read_data("equipment_name"), read_data("equipment_totall"), read_data("equipment_unit"), read_data("equipment_price"), read_data("equipment_date_insert"),
                                        read_data("equipment_Emp"), read_data("equipment_status"))
            End While
        End If
    End Sub



    Private Sub TextBox_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
        If TextBox_Search.Text.Length > 0 Then
            Button_cancel.Visible = True
        ElseIf TextBox_Search.Text.Length = 0 Then
            Button_cancel.Visible = False

        End If
    End Sub

    Private Sub Button_cancel_Click(sender As Object, e As EventArgs) Handles Button_cancel.Click
        TextBox_Search.Clear()
        showdata_equipment()
    End Sub



    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'show_select_equipment()
        showdata_equipment()


    End Sub

    Private Sub DataGridView_equipment_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
        manage_list_insert.ShowDialog()

        'TableLayoutPanel1.Visible = True
        'TextBox_equipment_ID.Text = DataGridView_equipment.Rows(e.RowIndex).Cells("Column1").Value
        'TextBox_total.Text = DataGridView_equipment.Rows(e.RowIndex).Cells("Column3").Value

        'TextBox_equipment_unit.Text = DataGridView_equipment.Rows(e.RowIndex).Cells("Column4").Value

        'TextBox_emp.Text = DataGridView_equipment.Rows(e.RowIndex).Cells("Column7").Value
        'ComboBox_status.Text = DataGridView_equipment.Rows(e.RowIndex).Cells("Column8").Value

    End Sub

    Private Sub TextBox_total_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        waitting_insert.ShowDialog()
        showdata_equipment()
    End Sub

    Private Sub Button_Serach_Click(sender As Object, e As EventArgs) Handles Button_Serach.Click
        DataGridView_equipment.Rows.Clear()

        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader

        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandText = CommandType.Text
        com.CommandText = "SELECT * FROM equipment_insert WHERE equipment_ID LIKE  '%" & TextBox_Search.Text.Trim & "%' OR Number_insert LIKE '%" & TextBox_Search.Text.Trim & "%' OR equipment_name LIKE '%" & TextBox_Search.Text.Trim & "%'"
        read_data = com.ExecuteReader
        If read_data.HasRows = True Then
            While read_data.Read
                DataGridView_equipment.Rows.Add(read_data("Number_insert"), read_data("Stock_ID"),
                                        read_data("equipment_name"), read_data("equipment_totall"), read_data("equipment_unit"), read_data("equipment_price"), read_data("equipment_date_insert"),
                                        read_data("equipment_Emp"), read_data("equipment_status"))
            End While
        End If
    End Sub

    Private Sub Date_search_ValueChanged(sender As Object, e As EventArgs) Handles Date_search.ValueChanged
        DataGridView_equipment.Rows.Clear()

        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader

        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandText = CommandType.Text
        com.CommandText = "SELECT * FROM equipment_insert WHERE equipment_date_insert = '" & Date_search.Value.ToString("u").Replace("Z", "") & "'"
        read_data = com.ExecuteReader
        If read_data.HasRows = True Then
            While read_data.Read
                DataGridView_equipment.Rows.Add(read_data("Number_insert"), read_data("Stock_ID"),
                                        read_data("equipment_name"), read_data("equipment_totall"), read_data("equipment_unit"), read_data("equipment_price"), read_data("equipment_date_insert"),
                                        read_data("equipment_Emp"), read_data("equipment_status"))
            End While
        End If


    End Sub
End Class
