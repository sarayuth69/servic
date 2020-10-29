
Imports MySql.Data.MySqlClient



Public Class Form8

    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"

    Dim data_Stock As DataTable
    Public Sub showdata_Stock()
        datagridview_Stock.Rows.Clear()
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_stock As MySqlDataReader
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM stock_pos"
        read_stock = com.ExecuteReader

        If read_stock.HasRows = True Then
            While read_stock.Read
                datagridview_Stock.Rows.Add(read_stock("Stock_ID"), read_stock("Stock_name"),
                                        read_stock("Stock_deteil"), read_stock("Stock_remark"),
                                         read_stock("Stock_status"), read_stock("Stock_price"),
                                         read_stock("Number_devices"))
            End While
        End If

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata_Stock()

    End Sub

    Function cleartxt()
        txt_Stock_deteil.Clear()
        txt_Stock_name.Clear()
        txt_stock_ID.Clear()
        txt_Stock_remark.Clear()
        ComboBox_Stock_status.SelectedIndex = 0
        txt_Stock_price.Clear()
        txt_Number_devices.Clear()


    End Function


    Dim temp_check_Stock As Boolean
    Function chackdata(ByVal Stock_name As String, ByVal Stock_ID As String, insert_Stock_c As String)
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_stock As Integer
        com = conn_db.CreateCommand
        With conn_db
            If .State = ConnectionState.Open Then
                .Close()
            End If
            .ConnectionString = connect_db
            .Open()
        End With

        With com
            .Connection = conn_db
            .CommandType = CommandType.Text
            If insert_Stock_c = "insert" Then
                .CommandText = "SELECT COUNT(*) FROM stock_pos WHERE Stock_name = '" & Stock_name & "'"
            Else
                .CommandText = "SELECT COUNT(*) FROM stock_pos WHERE Stock_name = '" & txt_Stock_name.Text & "' AND List_ID ='" & txt_stock_ID.Text & "' "
            End If

            read_stock = com.ExecuteScalar()

            If read_stock > 0 Then
                read_stock = False
            Else
                read_stock = True
            End If
        End With
        Return read_stock
        conn_db = Nothing
        com = Nothing


    End Function


    Private Sub btn_insert_Stock_Click(sender As Object, e As EventArgs) Handles btn_insert_Stock.Click
        'If chackdata(txt_Stock_name.Text, txt_stock_ID.Text, "insert") = False Then
        '    MsgBox("มีข้อมูลอยู่แล้ว")
        '    txt_Stock_name.Focus()

        'Else
        If txt_Stock_name.Text.Length = 0 Then
            MsgBox("กรุณกรอกชื่ออุปกรณ์")
        ElseIf txt_Stock_deteil.Text.Length = 0 Then

            MsgBox("กรุณากรอกรายละเอียด")

        Else

            Dim conn_db As New MySqlConnection
            Dim com As New MySqlCommand
            Dim read_List As MySqlDataReader
            com = conn_db.CreateCommand
            With conn_db
                If .State = ConnectionState.Open Then
                    .Close()
                End If
                .ConnectionString = connect_db
                .Open()
            End With
            com = New MySqlCommand
            With com
                .Connection = conn_db
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO stock_pos VALUE ('0','" & txt_Stock_name.Text & "','" & txt_Stock_deteil.Text & "',
                                '" & txt_Stock_remark.Text & "','" & ComboBox_Stock_status.Text & "','" & txt_Stock_price.Text & "','" & txt_Number_devices.Text & "',NOW(),NOW())"

                .ExecuteNonQuery()
                MessageBox.Show("เพิ่มข้อมูลรายการ เรียบร้อย", "ผลการทำงาน")
                showdata_Stock()
                cleartxt()
            End With
            conn_db = Nothing
            com = Nothing
            read_List = Nothing
        End If
        'End If
    End Sub

    Private Sub btn_delete_Stock_Click(sender As Object, e As EventArgs) Handles btn_delete_Stock.Click
        If MessageBox.Show("คุณต้องการลบข้อมูล ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim conn_db As New MySqlConnection
            Dim com As New MySqlCommand
            com = conn_db.CreateCommand
            With conn_db
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connect_db
                .Open()
            End With
            com = New MySqlCommand()
            com.Connection = conn_db
            com.CommandType = CommandType.Text
            com.CommandText = "DELETE FROM `stock_pos` WHERE (stock_pos.Stock_ID ='" & txt_stock_ID.Text & "')"
            com.ExecuteNonQuery()
            showdata_Stock()
            cleartxt()
            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน")
            txt_Number_devices.Visible = False
            'txt_Stock_price.Visible = False

            conn_db = Nothing
            com = Nothing

        End If
    End Sub

    Private Sub btn_edit_Stock_Click(sender As Object, e As EventArgs) Handles btn_edit_Stock.Click
        'If chackdata(txt_Stock_name.Text, txt_stock_ID.Text, "update") = False Then
        '    MsgBox("มีข้อมูลอยู่แล้ว")
        'Else
        Dim conn_db As New MySqlConnection
            Dim com As New MySqlCommand
            Dim read_List As MySqlDataReader
            com = conn_db.CreateCommand
        With conn_db
            If .State = ConnectionState.Open Then
                .Close()
            End If
            .ConnectionString = connect_db
            .Open()
        End With
        com = New MySqlCommand
        With com
            .Connection = conn_db
            .CommandType = CommandType.Text
            .CommandText = "UPDATE `stock_pos` SET `Stock_name`='" & txt_Stock_name.Text & "', `Stock_deteil`='" & txt_Stock_deteil.Text & "', 
                                    `Stock_remark`='" & txt_Stock_remark.Text & "', `Stock_status`='" & ComboBox_Stock_status.Text & "', `Stock_price`='" & txt_Stock_price.Text & "',
                                    `Number_devices`='" & txt_Number_devices.Text & "',`Stock_date_edit`=NOW()
                                                            WHERE (stock_pos.Stock_ID ='" & txt_stock_ID.Text & "')"

            .ExecuteNonQuery()
            MessageBox.Show("แก้ไขรายการ เรียบร้อย", "ผลการทำงาน")
            showdata_Stock()
            cleartxt()
        End With
        'End If
        txt_Number_devices.Visible = False

        conn_db = Nothing
        com = Nothing
        read_List = Nothing

    End Sub

    Private Sub datagridview_Stock_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridview_Stock.CellMouseUp
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        txt_Number_devices.Visible = True
        txt_Stock_price.Visible = True
        txt_stock_ID.Text = datagridview_Stock.Rows(e.RowIndex).Cells("Column1").Value
        txt_Stock_name.Text = datagridview_Stock.Rows(e.RowIndex).Cells("Column2").Value
        txt_Stock_deteil.Text = datagridview_Stock.Rows(e.RowIndex).Cells("Column3").Value
        txt_Stock_remark.Text = datagridview_Stock.Rows(e.RowIndex).Cells("Column4").Value
        ComboBox_Stock_status.Text = datagridview_Stock.Rows(e.RowIndex).Cells("Column5").Value
        txt_Stock_price.Text = datagridview_Stock.Rows(e.RowIndex).Cells("Column6").Value
        txt_Number_devices.Text = datagridview_Stock.Rows(e.RowIndex).Cells("Column7").Value
    End Sub
End Class
