

Imports MySql.Data.MySqlClient
Public Class Form10
    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"

    'Public list_id_send As String
    Public Sub showdata(ByVal list As String)

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
        com.CommandText = "SELECT * FROM table_list 
                            INNER JOIN stock_pos ON stock_pos.Stock_ID = table_list.Stock_ID
                            INNER JOIN customers ON customers.cus_id = table_list.cus_id
                            WHERE List_ID ='" & list & "'"
        read_data = com.ExecuteReader()
        read_data.Read()
        txt_List_ID.Text = read_data.Item("List_ID")
        txt_cus_name.Text = read_data.Item("cus_name")
        txt_cus_shop.Text = read_data.Item("cus_shop")
        txt_address.Text = read_data.Item("cus_address")
        'txt_address.Text = read_data.Item("cus_address")
        txt_tell.Text = read_data.Item("cus_tell")
        txt_mail.Text = read_data.Item("cus_email")
        txt_tax.Text = read_data.Item("cus_taxid")
        txt_stock_name.Text = read_data.Item("Stock_name")
        txt_stock_deteil.Text = read_data.Item("Stock_deteil")
        txt_stock_remark.Text = read_data.Item("Stock_remark")
        txt_number.Text = read_data.Item("List_total")
        txt_price.Text = read_data.Item("Stock_price")
        CB_status.Text = read_data.Item("list_status")
        Select Case read_data.Item("List_status")
            Case "ลูกค้าส่งคืนแล้ว"
                btn_Get_back.Visible = False

        End Select
        TextBox_stock_ID.Text = read_data.Item("Stock_ID")

        'Select Case read_data.Item("list_status")
        '    Case "0"
        '        CB_status.SelectedIndex = 0
        'End Select
        DateTimePicker1.Text = read_data.Item("List_date_send_customer")
        DateTimePicker2.Text = read_data.Item("List_date_get_back")



    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            'txt_cus_name.Enabled = True
            'txt_cus_shop.Enabled = True
            'txt_address.Enabled = True
            'txt_tell.Enabled = True
            'txt_mail.Enabled = True
            'txt_tax.Enabled = True
            'txt_stock_name.Enabled = True
            'txt_stock_deteil.Enabled = True
            'txt_stock_remark.Enabled = True
            'txt_number.Enabled = True
            'txt_price.Enabled = True
            CB_status.Enabled = True
            'calender2.Visible = True
            'calender1.Visible = True
            'txt_date_send_cus.Enabled = True
            'txt_date_get_back.Enabled = True
            'TimePicker_send_to_cus.Enabled = True
            'TimePicker_get_back.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

        Else
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            'txt_cus_name.Enabled = False
            'txt_cus_shop.Enabled = False
            'txt_address.Enabled = False
            'txt_tell.Enabled = False
            'txt_mail.Enabled = False
            'txt_tax.Enabled = False
            'txt_stock_name.Enabled = False
            'txt_stock_deteil.Enabled = False
            'txt_stock_remark.Enabled = False
            'txt_number.Enabled = False
            'txt_price.Enabled = False
            CB_status.Enabled = False
            'calender2.Visible = False
            'calender1.Visible = False
            'txt_date_send_cus.Enabled = False
            'txt_date_get_back.Enabled = False
            'TimePicker_send_to_cus.Enabled = False
            'TimePicker_get_back.Enabled = False
        End If

    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub


    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

        'txt_date_send_cus.Text = Format(Me.MonthCalendar1.SelectionStart, "dd/MM/yyyy u")


    End Sub


    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs)
        'txt_date_get_back.Text = Format(Me.MonthCalendar2.SelectionStart, "dd/MM/yyyy u")
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        'If MonthCalendar1.Visible = True Then
        '    MonthCalendar1.Visible = False
        'Else
        '    MonthCalendar1.Visible = True
        'End If
    End Sub
    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        'If MonthCalendar2.Visible = True Then
        '    MonthCalendar2.Visible = False
        'Else
        '    MonthCalendar2.Visible = True
        'End If
    End Sub



    Private Sub btn_edit_Click_1(sender As Object, e As EventArgs) Handles btn_edit.Click
        If MessageBox.Show("คุณต้องการแก้ไขข้อมูล ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim conn_db As New MySqlConnection
            Dim com As New MySqlCommand

            With conn_db
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connect_db
                .Open()

            End With
            com.Connection = conn_db
            com.CommandType = CommandType.Text
            com.CommandText = "UPDATE `table_list` SET `List_date_send_customer`='" & DateTimePicker1.Value.ToString("u").Replace("Z", "") & "', `List_date_get_back`='" & DateTimePicker2.Value.ToString("u").Replace("Z", "") & "', `List_status`='" & CB_status.Text & "' WHERE (`List_ID`='" & txt_List_ID.Text & "')"
            com.ExecuteNonQuery()
            conn_db.Close()
            com.Dispose()
            com = Nothing
            conn_db = Nothing
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน")
            Me.Close()

        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("คุณต้องการลบข้อมูล ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
            com.CommandText = "DELETE FROM `table_list` WHERE (`List_ID`='" & txt_List_ID.Text & "')"
            com.ExecuteNonQuery()
            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน")
            Me.Close()

        End If
    End Sub

    Private Sub btn_Get_back_Click(sender As Object, e As EventArgs) Handles btn_Get_back.Click



        If CB_status.Text <> "ลูกค้าส่งคืนแล้ว" Then
            MsgBox("กรุณาเปลี่ยนสถานะก่อนรับคืน ")

        Else
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
            com.CommandText = "UPDATE `stock_pos` SET `Number_devices`= `Number_devices`+'" & txt_number.Text & "' WHERE (`Stock_ID`='" & TextBox_stock_ID.Text & "')"
            com.ExecuteNonQuery()
            com.CommandText = "UPDATE `table_list` SET  `List_status`='" & CB_status.Text & "' WHERE (`List_ID`='" & txt_List_ID.Text & "')"
            com.ExecuteNonQuery()
            MsgBox("รับอุปกรณ์เรียบร้อย")
            Me.Close()

        End If

    End Sub
End Class