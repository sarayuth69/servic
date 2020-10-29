
Imports MySql.Data.MySqlClient


Public Class Form9
    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata_list()
    End Sub
    Dim data_list As DataTable
    Dim status_show As String
    Public Sub showdata_list()
        datagridView_List.Rows.Clear()
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_stock As MySqlDataReader
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com = New MySqlCommand
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT
*
FROM
table_list
INNER JOIN stock_pos ON stock_pos.Stock_ID = table_list.Stock_ID
INNER JOIN customers ON customers.cus_id = table_list.cus_id
"
        read_stock = com.ExecuteReader

        If read_stock.HasRows = True Then
            data_list = New DataTable
            data_list.Load(read_stock)

        End If
        conn_db = Nothing
        com = Nothing
        If Not IsNothing(data_list) Then

            For ii = 0 To data_list.Rows.Count - 1
                'Select Case data_list.Rows(ii).Item("List_status").ToString
                '    Case "0"
                'status_show = "รอส่ง"
                'Case "1"
                '    status_show = "เช็คอาการ"
                'Case "2"
                '    status_show = "รออะไหล่"
                'Case "3"
                '    status_show = "กำลังซ่อม"
                'Case "4"
                '    status_show = "ซ่อมแล้ว"
                'Case "5"
                '    status_show = "รอส่ง"
                'Case "6"
                '    status_show = "ส่งคืนแล้ว"
                'End Select
                datagridView_List.Rows.Add(data_list.Rows(ii).Item("List_ID").ToString, data_list.Rows(ii).Item("cus_name").ToString,
                                            data_list.Rows(ii).Item("cus_shop").ToString, data_list.Rows(ii).Item("Stock_name").ToString,
                                            data_list.Rows(ii).Item("List_total").ToString, data_list.Rows(ii).Item("List_status").ToString,
                                            data_list.Rows(ii).Item("List_deteil").ToString)
            Next

        End If
    End Sub

    Public Sub datagridView_List_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridView_List.CellMouseUp
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Dim fr_10 As New Form10
        'fr_10.list_id_send = datagridView_List.Rows(e.RowIndex).Cells("Column1").Value.ToString()
        fr_10.showdata(datagridView_List.Rows(e.RowIndex).Cells("Column1").Value.ToString())
        fr_10.ShowDialog()
        showdata_list()

    End Sub

    Private Sub CheckBox_insert_stock_true_CheckedChanged(sender As Object, e As EventArgs)
        'If CheckBox_insert_stock_true.Checked = True Then
        '    TableLayoutPanel_insert.Enabled = True
        'Else
        '    TableLayoutPanel_insert.Enabled = False
        'End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim fr_11 As New Form11
        fr_11.ShowDialog()
        showdata_list()
    End Sub

    Private Sub Form9_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

    End Sub
End Class