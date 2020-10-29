
Imports MySql.Data.MySqlClient
Public Class Form11
    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"


    Public Sub showdata_CB_select_enqiment()
        Dim dtb_list As DataTable
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        dtb_list = Nothing
        Dim list_data As New List(Of DictionaryEntry)
        dtb_list = Nothing
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With

        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM stock_pos"
        read_data = com.ExecuteReader()

        If read_data.HasRows Then
            dtb_list = New DataTable
            While read_data.Read
                list_data.Add(New DictionaryEntry(read_data.Item("Stock_name").ToString, read_data.Item("Stock_ID").ToString))

            End While
            CB_select_equipment.DataSource = list_data
            CB_select_equipment.DisplayMember = "key"
            CB_select_equipment.ValueMember = "value"

        End If



    End Sub


    Public Sub showdata_CB_select_cus()
        Dim dtb_list As DataTable
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        dtb_list = Nothing
        Dim list_data As New List(Of DictionaryEntry)
        dtb_list = Nothing
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With

        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM customers"
        read_data = com.ExecuteReader()

        If read_data.HasRows Then
            dtb_list = New DataTable
            While read_data.Read
                list_data.Add(New DictionaryEntry(read_data.Item("cus_name").ToString, read_data.Item("cus_id").ToString))

            End While
            CB_select_cus.DataSource = list_data
            CB_select_cus.DisplayMember = "key"
            CB_select_cus.ValueMember = "value"

        End If



    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata_CB_select_enqiment()
        showdata_CB_select_cus()

        autocomplite(CB_select_equipment)
        autocomplite_cus(CB_select_cus)
    End Sub

    Private Sub CB_select_equipment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_select_equipment.SelectedIndexChanged
        If CB_select_equipment.Focused Then

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
            com.CommandText = "SELECT * FROM stock_pos WHERE Stock_ID =  '" & CB_select_equipment.SelectedValue & "'"
            read_data = com.ExecuteReader
            read_data.Read()
            txt_stock_name.Text = read_data.Item("Stock_name")
            txt_stock_deteil.Text = read_data.Item("Stock_deteil")
            txt_stock_remark.Text = read_data.Item("Stock_remark")
            'CB_status.Text = read_data.Item("Stock_status")


        End If

    End Sub

    Function autocomplite(ByVal CB_select_equipment As ComboBox)
        Dim datasource As New AutoCompleteStringCollection
        Try
            datasource.AddRange(autocomplite_serch.ToArray)
            CB_select_equipment.AutoCompleteCustomSource = datasource
            CB_select_equipment.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            CB_select_equipment.AutoCompleteSource = AutoCompleteSource.CustomSource

        Catch ex As Exception
            CB_select_equipment.AutoCompleteSource = Nothing
        End Try
        datasource = Nothing

    End Function

    Function autocomplite_serch() As List(Of String)
        Dim datatable As DataTable
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        datatable = Nothing
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM stock_pos"
        read_data = com.ExecuteReader
        If read_data.HasRows Then
            datatable = New DataTable
            datatable.Load(read_data)

        End If
        autocomplite_serch = New List(Of String)
        For ii = 0 To datatable.Rows.Count - 1
            autocomplite_serch.Add(datatable.Rows(ii).Item("Stock_name").ToString)
        Next


    End Function



    Function autocomplite_cus(ByVal CB_select_cus As ComboBox)
        Dim datasource As New AutoCompleteStringCollection
        Try
            datasource.AddRange(autocomplite_serch_cus.ToArray)
            CB_select_cus.AutoCompleteCustomSource = datasource
            CB_select_cus.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            CB_select_cus.AutoCompleteSource = AutoCompleteSource.CustomSource

        Catch ex As Exception
            CB_select_equipment.AutoCompleteSource = Nothing
        End Try
        datasource = Nothing

    End Function

    Function autocomplite_serch_cus() As List(Of String)
        Dim datatable As DataTable
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        datatable = Nothing
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM `customers`"
        read_data = com.ExecuteReader
        If read_data.HasRows Then
            datatable = New DataTable
            datatable.Load(read_data)

        End If
        autocomplite_serch_cus = New List(Of String)
        For ii = 0 To datatable.Rows.Count - 1
            autocomplite_serch_cus.Add(datatable.Rows(ii).Item("cus_name").ToString)
        Next

    End Function

    Private Sub CB_select_cus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_select_cus.SelectedIndexChanged
        If CB_select_cus.Focused Then
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
            com.CommandText = "SELECT * From customers WHERE cus_id = '" & CB_select_cus.SelectedValue & "'"
            read_data = com.ExecuteReader()
            read_data.Read()
            txt_cus_name.Text = read_data.Item("cus_name")
            txt_cus_shop.Text = read_data.Item("cus_shop")
            txt_address.Text = read_data.Item("cus_address")
            txt_email.Text = read_data.Item("cus_email")
            txt_tell.Text = read_data.Item("cus_tell")
        End If

    End Sub

    Private Sub btn_insert_list_Click(sender As Object, e As EventArgs) Handles btn_insert_list.Click
        If txt_number.Text.Length = 0 Then
            MsgBox("กรุณากรอกจำนวนที่ต้องการเบิก")
        ElseIf txt_cus_name.Text.Length = 0 Then
            MsgBox("กรุณาเลือกลูกค้าที่ต้องการเบิก")
        ElseIf txt_stock_name.Text.Length = 0 Then
            MsgBox("กรุณาเลือกอุปกรณ์ที่ต้องการเบิก")
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
            com.CommandText = "SELECT * FROM stock_pos WHERE Stock_ID =  '" & CB_select_equipment.SelectedValue & "'"
            read_data = com.ExecuteReader
            read_data.Read()

            If txt_number.Text > read_data.Item("Number_devices") Then
                MsgBox("ไม่สามารถเบิกอุปกรณ์ได้ จำนวนในสต๊อกน้อยกว่าการเบิก")
            ElseIf txt_number.Text = 0 Then
                MsgBox("กรุณาไส่จำนวนการเบิก")
            ElseIf txt_number.Text < 0 Then
                MsgBox("ไม่สามารถเบิกจำนวนติดลบได้")
            Else
                read_data.Close()

                com.Connection = conn_db
                com.CommandType = CommandType.Text
                com.CommandText = "INSERT INTO `table_list` (`List_ID`, `List_date_send_customer`, `List_date_get_back`, `List_deteil`, `List_remark`, `List_status`, `List_total`, `cus_id`, `Stock_ID`) VALUES 
                        ('0', '" & DateTimePicker_send_cus.Value.ToString("u").Replace("Z", "") & "', '" & DateTimePicker_get_back.Value.ToString("u").Replace("Z", "") & "', '" & txt_stock_deteil.Text & "', '" & txt_stock_remark.Text & "', '" & CB_status.Text & "', '" & txt_number.Text & "', '" & CB_select_cus.SelectedValue & "', '" & CB_select_equipment.SelectedValue & "')"
                com.ExecuteNonQuery()

                com.CommandText = "UPDATE `stock_pos` SET `Number_devices`= `Number_devices`-'" & txt_number.Text & "' WHERE (`Stock_ID`='" & CB_select_equipment.SelectedValue & "')"
                com.ExecuteNonQuery()

                MsgBox("เบิกอุปกรณ์เรียบร้อย")
                Me.Close()
            End If

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
End Class