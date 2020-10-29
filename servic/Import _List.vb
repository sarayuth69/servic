Imports MySql.Data.MySqlClient
Imports System.Windows.Forms




Public Class Import_List

     

    Dim conn_db As New MySqlConnection
    Dim com As New MySqlCommand
    Dim read_data As MySqlDataReader

    Public Sub showdata_equipment()
        DataGridView_equipment.Rows.Clear()
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM equipment_insert INNER JOIN stock_pos ON stock_pos.Stock_ID = equipment_insert.Stock_ID WHERE equipment_status ='ใช้งาน'"
        read_data = com.ExecuteReader
        If read_data.HasRows = True Then
            While read_data.Read
                DataGridView_equipment.Rows.Add(read_data("equipment_ID"), read_data("Number_insert"), read_data("Stock_ID"),
                                        read_data("equipment_name"), read_data("equipment_totall"), read_data("equipment_unit"), read_data("equipment_price"), read_data("equipment_date_insert"),
                                        read_data("equipment_Emp"), read_data("equipment_status"))
            End While
        End If
    End Sub

    Public Sub showdata_equipment_cancel()
        DataGridView_cancel.Rows.Clear()
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM equipment_insert INNER JOIN stock_pos ON stock_pos.Stock_ID = equipment_insert.Stock_ID WHERE equipment_status ='ไม่ใช้งาน'"
        read_data = com.ExecuteReader
        If read_data.HasRows = True Then
            While read_data.Read
                DataGridView_cancel.Rows.Add(read_data("equipment_ID"), read_data("Number_insert"), read_data("Stock_ID"),
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
        showdata_equipment()
        TextBox_Search.Clear()
        showdata_equipment()
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata_equipment()
        showdata_equipment_cancel()
    End Sub

    Private Sub TextBox_total_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        waitting_insert.Data_waitting.Rows.Clear()
        waitting_insert.TextBox_number.Clear()
        waitting_insert.TextBox_total.Clear()

        waitting_insert.ShowDialog()
        showdata_equipment()
    End Sub

    Private Sub Button_Serach_Click(sender As Object, e As EventArgs) Handles Button_Serach.Click
        search_equipmant()
    End Sub
    Public Sub search_equipmant()
        DataGridView_equipment.Rows.Clear()
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandText = CommandType.Text
        com.CommandText = "SELECT * FROM equipment_insert WHERE equipment_ID LIKE  '%" & check_text(TextBox_Search.Text.Trim) & "%' OR Number_insert LIKE '%" & check_text(TextBox_Search.Text.Trim) & "%' OR equipment_name LIKE '%" & check_text(TextBox_Search.Text.Trim) & "%'"
        read_data = com.ExecuteReader
        If read_data.HasRows = True Then
            While read_data.Read
                DataGridView_equipment.Rows.Add(read_data("equipment_ID"), read_data("Number_insert"), read_data("Stock_ID"),
                                        read_data("equipment_name"), read_data("equipment_totall"),
                                        read_data("equipment_unit"), read_data("equipment_price"),
                                        read_data("equipment_date_insert"),
                                        read_data("equipment_Emp"), read_data("equipment_status"))
            End While
        End If
    End Sub


    Public Sub serch_date()

        DataGridView_equipment.Rows.Clear()
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandText = CommandType.Text
        com.CommandText = "SELECT * FROM equipment_insert WHERE DATE(equipment_date_insert) = '" & Format(Me.Date_search.Value, "yyyy-MM-dd") & "' AND equipment_status ='ใช้งาน' "
        read_data = com.ExecuteReader
        If read_data.HasRows = True Then
            While read_data.Read
                DataGridView_equipment.Rows.Add(read_data("equipment_ID"), read_data("Number_insert"), read_data("Stock_ID"),
                                        read_data("equipment_name"), read_data("equipment_totall"),
                                        read_data("equipment_unit"), read_data("equipment_price"),
                                        read_data("equipment_date_insert"),
                                        read_data("equipment_Emp"), read_data("equipment_status"))
            End While
        Else
            MsgBox("ไม่มีข้อมูลที่ค้นหา")
        End If

    End Sub

    Dim totall As String
    Dim equipment_id As String
    Dim text_up As String
    Dim stock_id As String
    Dim status_chack As String

    Dim menu As ToolStripItem
    Private Sub DataGridView_equipment_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_equipment.CellMouseUp

        totall = DataGridView_equipment.Rows(e.RowIndex).Cells("total").Value.ToString
        equipment_id = DataGridView_equipment.Rows(e.RowIndex).Cells("ID").Value.ToString
        stock_id = DataGridView_equipment.Rows(e.RowIndex).Cells("Stock_ID_1").Value.ToString
        status_chack = DataGridView_equipment.Rows(e.RowIndex).Cells("status").Value.ToString

        ContextMenuStrip1.Items.Clear()
        If DataGridView_equipment.Rows(e.RowIndex).Cells("status").Value.ToString = "ใช้งาน" Then

            'ไมใชงานToolStripMenuItem
            menu = New System.Windows.Forms.ToolStripMenuItem()
            menu.Name = "ไมใชงานToolStripMenuItem"
            menu.Size = New System.Drawing.Size(115, 22)
            menu.Text = "ไม่ใช้งาน"
            AddHandler menu.Click, AddressOf ไมใชงานToolStripMenuItem_Click
            ContextMenuStrip1.Items.Add(menu)
        Else
            'ใชงานToolStripMenuItem
            menu = New System.Windows.Forms.ToolStripMenuItem()

            menu.Name = "ใชงานToolStripMenuItem"
            menu.Size = New System.Drawing.Size(115, 22)
            menu.Text = "ใช้งาน"
            AddHandler menu.Click, AddressOf ใชงานToolStripMenuItem_Click
            ContextMenuStrip1.Items.Add(menu)
        End If

        ContextMenuStrip1.Show(Cursor.Position)


    End Sub


    Public Sub update_status(ByVal cancel_status As String)


        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        Dim num As Integer
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text


        com.CommandText = "UPDATE `equipment_insert` SET `equipment_status`='" & cancel_status & "' WHERE (`equipment_ID`='" & equipment_id & "')"
        com.ExecuteNonQuery()
        If cancel_status = "ใช้งาน" Then

            com.CommandText = "UPDATE `stock_pos` SET `Number_devices`=`Number_devices`+'" & totall & "' WHERE (`Stock_ID`='" & stock_id & "')"
            com.ExecuteNonQuery()
        ElseIf cancel_status = "ไม่ใช้งาน" Then
            com.CommandText = "UPDATE `stock_pos` SET `Number_devices`=`Number_devices`-'" & totall & "' WHERE (`Stock_ID`='" & stock_id & "')"
            com.ExecuteNonQuery()
        End If

        MessageBox.Show("เปลี่ยนสถานะเรียบร้อย")
        showdata_equipment()
        showdata_equipment_cancel()

        conn_db = Nothing
        com = Nothing

    End Sub

    Private Sub ใชงานToolStripMenuItem_Click(sender As Object, e As EventArgs)
        update_status("ใช้งาน")

    End Sub

    Private Sub ไมใชงานToolStripMenuItem_Click(sender As Object, e As EventArgs)
        update_status("ไม่ใช้งาน")
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            Date_search.Visible = True
            btn_search_date.Visible = True
        Else
            Date_search.Visible = False
            btn_search_date.Visible = False
        End If
    End Sub

    Private Sub btn_search_date_Click(sender As Object, e As EventArgs) Handles btn_search_date.Click
        serch_date()
    End Sub

    Private Sub DataGridView_cancel_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_cancel.CellMouseUp

        totall = DataGridView_cancel.Rows(e.RowIndex).Cells("cancel_totall").Value.ToString
        equipment_id = DataGridView_cancel.Rows(e.RowIndex).Cells("cancel_ID").Value.ToString
        stock_id = DataGridView_cancel.Rows(e.RowIndex).Cells("cancel_equipment_ID").Value.ToString
        status_chack = DataGridView_cancel.Rows(e.RowIndex).Cells("cancel_status").Value.ToString

        ContextMenuStrip1.Items.Clear()
        If DataGridView_cancel.Rows(e.RowIndex).Cells("cancel_status").Value.ToString = "ใช้งาน" Then

            'ไมใชงานToolStripMenuItem
            menu = New System.Windows.Forms.ToolStripMenuItem()
            menu.Name = "ไมใชงานToolStripMenuItem"
            menu.Size = New System.Drawing.Size(115, 22)
            menu.Text = "ไม่ใช้งาน"
            AddHandler menu.Click, AddressOf ไมใชงานToolStripMenuItem_Click
            ContextMenuStrip1.Items.Add(menu)
        Else
            'ใชงานToolStripMenuItem
            menu = New System.Windows.Forms.ToolStripMenuItem()

            menu.Name = "ใชงานToolStripMenuItem"
            menu.Size = New System.Drawing.Size(115, 22)
            menu.Text = "ใช้งาน"
            AddHandler menu.Click, AddressOf ใชงานToolStripMenuItem_Click
            ContextMenuStrip1.Items.Add(menu)
        End If
        ContextMenuStrip1.Show(Cursor.Position)
    End Sub
End Class
