
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Public Class take_out

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
        TextBox_ID.Text = autoid_take_out()
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
            'CB_select_equipment.Text = read_data.Item("Stock_name")
            txt_stock_deteil.Text = read_data.Item("Stock_deteil")
            txt_stock_remark.Text = read_data.Item("Stock_remark")
            Label8.Text = read_data.Item("Stock_ID")
            TextBox_Number_devices.Text = read_data.Item("Number_devices")
            TextBox_unit.Text = read_data.Item("Stock_unit")
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
            CB_select_cus.Text = read_data.Item("cus_name")
            txt_cus_shop.Text = read_data.Item("cus_shop")
            txt_address.Text = read_data.Item("cus_address")
            txt_email.Text = read_data.Item("cus_email")
            txt_tell.Text = read_data.Item("cus_tell")

        End If

    End Sub
    Function autoid_take_out() As String
        autoid_take_out = ""

        Dim dr_A As MySqlDataReader

        Dim Conn As New MySqlConnection
        Dim com As New MySqlCommand
        com = Conn.CreateCommand()
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com = New MySqlCommand()
        With com
            .Connection = Conn
            .CommandType = CommandType.Text
            .CommandText = "SELECT SUBSTR(table_List.List_ID_take_out,7)+1 as id FROM table_List order by (SUBSTR(table_List.List_ID_take_out,7)+1)*1 DESC limit 0,1"
            dr_A = .ExecuteReader
            If dr_A.HasRows Then
                dr_A.Read()
                autoid_take_out = "B-" & CDbl(dr_A.Item("id")).ToString("00000000")
            Else
                autoid_take_out = "B-00000001"
            End If
        End With
        com.Connection.Close()
        Conn.Close()
        dr_A.Close()
        Conn = Nothing


        Return autoid_take_out
    End Function
    Dim text_sql As String = ""
    Dim text_sql_up As String = ""
    Private Sub btn_insert_list_Click(sender As Object, e As EventArgs) Handles btn_insert_list.Click
        If datagridView_take_out.Rows.Count > 0 Then
            save()
        Else
            MsgBox("ยังไม่มีการเบิกอุปกรณ์")

        End If



    End Sub
    Public Sub save()

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


        read_data.Close()
        read_data = Nothing
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        For i = 0 To datagridView_take_out.Rows.Count - 1
            text_sql = "INSERT INTO `table_list` (`List_ID`, `List_ID_take_out`, `List_date_send_customer`, `List_date_get_back`, `List_deteil`, `List_remark`, `List_status`, `List_total`, `cus_id`, `Stock_ID`) 
                    VALUES ('0', '" & datagridView_take_out.Rows(i).Cells(0).Value.ToString() & "', '" & datagridView_take_out.Rows(i).Cells(10).Value.ToString() & "',
                        '" & datagridView_take_out.Rows(i).Cells(11).Value.ToString() & "', '" & datagridView_take_out.Rows(i).Cells(7).Value.ToString() & "',
                        '" & datagridView_take_out.Rows(i).Cells(12).Value.ToString() & "', '" & datagridView_take_out.Rows(i).Cells(6).Value.ToString() & "',
                        '" & datagridView_take_out.Rows(i).Cells(4).Value.ToString() & "', '" & datagridView_take_out.Rows(i).Cells(9).Value.ToString() & "', 
                        '" & datagridView_take_out.Rows(i).Cells(8).Value.ToString() & "')"
            com.CommandText = text_sql

            com.ExecuteNonQuery()

            text_sql_up = "UPDATE `stock_pos` SET `Number_devices`= `Number_devices`-'" & datagridView_take_out.Rows(i).Cells(4).Value.ToString() & "' WHERE (`Stock_ID`='" & datagridView_take_out.Rows(i).Cells(7).Value.ToString() & "')"
            com.CommandText = text_sql_up
            com.ExecuteNonQuery()
        Next
        MsgBox("เบิกอุปกรณ์เรียบร้อย")
        datagridView_take_out.Rows.Clear()
        txt_number.Clear()
        TextBox_Number_devices.Clear()
        txt_stock_remark.Clear()
        txt_stock_deteil.Clear()
        TextBox_unit.Clear()
        text_price.Clear()

        txt_address.Clear()
        txt_list_deteil.Clear()
        txt_email.Clear()

        txt_tell.Clear()
        txt_cus_shop.Clear()

        Me.Close()

    End Sub

    Private Sub btn_take_out_Click(sender As Object, e As EventArgs) Handles btn_take_out.Click


        If txt_number.Text.Length = 0 Then
            MsgBox("กรุณากรอกจำนวนที่ต้องการเบิก")
        ElseIf CB_select_cus.Text.Length = 0 Then
            MsgBox("กรุณาเลือกลูกค้าที่ต้องการเบิก")
        ElseIf txt_cus_shop.Text.Length = 0 Then
            MsgBox("กรุณาเลือกร้านที่ต้องการ")

        ElseIf CB_select_equipment.Text.Length = 0 Then
            MsgBox("กรุณาเลือกอุปกรณ์ที่ต้องการเบิก")
        ElseIf CB_status.Text.Length = 0 Then
            MsgBox("กรุณาเลือกสถานะ")
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
            If (txt_number.Text + check_Num(Label8.Text)) > CDbl(TextBox_Number_devices.Text) Then

                MsgBox("ไม่สามารถเบิกได้ เนื่องจากจำนวนในสต็อกน้อยกว่าจำนวนการเบิก")
            ElseIf txt_number.Text < 0 Then
                MsgBox("ไม่สามารถเบิกจำนวนติดลบได้")
            ElseIf txt_number.Text = 0 Then
                MsgBox("กรุณากรอกจำนวนที่ต้องการเบิก")
            Else
                datagridView_take_out.Rows.Add(TextBox_ID.Text,
                                  CB_select_cus.Text,
                                  txt_cus_shop.Text,
                                  CB_select_equipment.Text,
                                  txt_number.Text,
                                  TextBox_unit.Text,
                                  CB_status.Text,
                                  txt_list_deteil.Text,
                                  CB_select_equipment.SelectedValue,
                                  CB_select_cus.SelectedValue,
                                  DateTimePicker_send_cus.Value.ToString("u").Replace("Z", ""),
                                  DateTimePicker_get_back.Value.ToString("u").Replace("Z", ""),
                                  txt_stock_remark)


            End If

        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        datagridView_take_out.Rows.Clear()
        txt_number.Clear()
        TextBox_Number_devices.Clear()
        txt_stock_remark.Clear()
        txt_stock_deteil.Clear()
        TextBox_unit.Clear()
        text_price.Clear()

        txt_address.Clear()
        txt_list_deteil.Clear()
        txt_email.Clear()

        txt_tell.Clear()
        txt_cus_shop.Clear()
        Me.Close()

    End Sub
    Function check_Num(ByVal id As String) As Double
        check_Num = 0
        For i = 0 To datagridView_take_out.Rows.Count - 1
            If id = datagridView_take_out.Rows(i).Cells("equipment_ID").Value.ToString Then
                check_Num += datagridView_take_out.Rows(i).Cells("total").Value.ToString


            End If
        Next
        Return check_Num
    End Function

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If datagridView_take_out.Rows.Count > 0 Then
            If MessageBox.Show("คุณต้องการปริ้นใบเบิก หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                print.ShowDialog()
            Else
                Reportsave(0, "")
            End If
        ElseIf datagridView_take_out.Rows.Count = 0 Then
            MsgBox("ยังไม่มีการเบิกอุปกรณ์")

        Else
            save()
        End If



    End Sub
    Private Sub Reportsave(ByVal type As Integer, ByVal printer As String) '0=บันทึก 1=พิมพ์
        '-------------------------------------------------
        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range
        Dim report_name As String
        Dim Path_SaveFileExcel As String
        Dim myStream As Stream
        Dim Row_index As Integer
        Dim Row As Integer
        report_name = "ใบเบิกอุปกรณ์.xlsx" 'ชื่อไฟล์รายงาน
        SaveFileDialog1.FileName = "ใบเบิกอุปกรณ์" 'ชื่อไฟล์ที่จะเซฟ เช่น "รายละเอียดสินค้า"
        SaveFileDialog1.Filter = "Excel files (.xls)|.xls"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = False


        'datebegin1 = DatePre.Value.Day & "-" & DatePre.Value.Month & "-" & DatePre.Value.Year
        'datebAfter1 = DateAfter.Value.Day & "-" & DateAfter.Value.Month & "-" & DateAfter.Value.Year
        Try
            Dim proc As System.Diagnostics.Process
            For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()
            Next
        Catch w As System.ComponentModel.Win32Exception
            Console.WriteLine(w.Message)
            Console.WriteLine(w.ErrorCode.ToString())
            Console.WriteLine(w.NativeErrorCode.ToString())
            Console.WriteLine(w.StackTrace)
            Console.WriteLine(w.Source)
        End Try
        Me.Cursor = Cursors.WaitCursor ' ---- แสดงเมาส์เป็นรูปนาฬิกาทราบ
        appXL = CreateObject("Excel.Application")
        '-copy file-------------------------------
        Dim FileToCopy As String
        Dim NewCopy As String
        FileToCopy = My.Application.Info.DirectoryPath & "\Report\" & report_name
        NewCopy = My.Application.Info.DirectoryPath & "\" & report_name
        'ลบไฟล์ที่มีข้อมูลออกก่อน
        If System.IO.File.Exists(NewCopy) = True Then
            Try
                My.Computer.FileSystem.DeleteFile(NewCopy)
            Catch ex As Exception
                wbXl = appXL.Workbooks.Open(My.Application.Info.DirectoryPath & "\" & report_name)
                wbXl.Saved = True
                wbXl.Close()
                appXL.Quit()
            End Try
        End If
        'เช็คไฟล์รายงาน
        If System.IO.File.Exists(FileToCopy) = True Then
            Try
                System.IO.File.Copy(FileToCopy, NewCopy)
            Catch ex As Exception
                wbXl = appXL.Workbooks.Open(My.Application.Info.DirectoryPath & "\" & report_name)
                wbXl.Saved = True
                wbXl.Close()
                appXL.Quit()
            End Try
        Else
            MsgBox("ไม่พบไฟล์รายงาน " & report_name & " !!", MsgBoxStyle.Critical, "แจ้งเตือน")
            Me.Cursor = Cursors.Default ' ---- แสดงเมาส์ในรูปแบบปกติ
            appXL.Quit()
            appXL = Nothing
            wbXl = Nothing
            shXL = Nothing
            raXL = Nothing
            FileToCopy = Nothing
            NewCopy = Nothing
            myStream = Nothing
            Exit Sub
        End If
        '-copy file-------------------------------
        wbXl = appXL.Workbooks.Open(My.Application.Info.DirectoryPath & "\" & report_name)
        shXL = wbXl.ActiveSheet
        shXL.Range("F4").Value = DateTimePicker_send_cus.Value.ToString("d").Replace("Z", "")
        shXL.Range("H4").Value = DateTimePicker_get_back.Value.ToString("d").Replace("Z", "")
        shXL.Range("B4").Value = login_name
        shXL.Range("H3").Value = TextBox_ID.Text
        'If combo_status.Text = "Yes" Then
        '    shXL.Range("F7").Value = "เคลมเรียบร้อย"
        'ElseIf combo_status.Text = "No" Then
        '    shXL.Range("F7").Value = "รอเคลม"
        'Else
        '    shXL.Range("F7").Value = "ไม่สามารถเคลมได้"
        'End If
        shXL.Range("B5").Value = CB_select_cus.Text
        shXL.Range("F5").Value = txt_cus_shop.Text
        Row_index = 9
        Row = 0
        For i = 0 To datagridView_take_out.Rows.Count - 1

            shXL.Range("B" & Row_index + i).Value = datagridView_take_out.Rows(i).Cells("equipment_name").Value.ToString
            shXL.Range("F" & Row_index + i).Value = datagridView_take_out.Rows(i).Cells("total").Value.ToString
            shXL.Range("G" & Row_index + i).Value = datagridView_take_out.Rows(i).Cells("unit").Value.ToString
            shXL.Range("H" & Row_index + i).Value = datagridView_take_out.Rows(i).Cells("detel").Value.ToString
        Next
        For j = 0 To datagridView_take_out.Rows.Count - 1
            Row += 1
            shXL.Range("A" & Row_index + j).Value = Row

        Next

        'shXL.Range("D11").Value = txt_serial.Text
        'shXL.Range("D11").Value = txt_serial.Text
        'shXL.Range("E11").Value = dtp_timeExit.Text
        'shXL.Range("G11").Value = txt_remark.Text
        'shXL.Range("G18").Value = txt_userremark.Text
        Me.Cursor = Cursors.Default ' ---- แสดงเมาส์ในรูปแบบปกติ
        wbXl.Save() 'เซฟไฟล์
        If type = 0 Then 'บันทึก
            Try
                myStream = SaveFileDialog1.OpenFile()
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    Path_SaveFileExcel = IO.Path.GetFullPath(SaveFileDialog1.FileName)
                    wbXl.SaveAs(Path_SaveFileExcel)
                    myStream.Close()
                    wbXl.Close()
                    appXL.Quit()
                    appXL = Nothing
                    wbXl = Nothing
                    FileToCopy = Nothing
                    NewCopy = Nothing
                    myStream = Nothing
                    Path_SaveFileExcel = Nothing
                End If
            Catch ex As Exception
                wbXl.Close()
                appXL.Quit()
                appXL = Nothing
                wbXl = Nothing
                FileToCopy = Nothing
                NewCopy = Nothing
                myStream = Nothing
                Path_SaveFileExcel = Nothing
                Me.Cursor = Cursors.Default ' ---- แสดงเมาส์ในรูปแบบปกติ
                Exit Sub
            End Try
        ElseIf type = 1 Then 'พิมพ์
            Try
                wbXl.PrintOutEx(Copies:=1, ActivePrinter:=printer, Collate:=True)
                wbXl.Close()
                appXL.Quit()
                appXL = Nothing
                wbXl = Nothing
                FileToCopy = Nothing
                NewCopy = Nothing
                myStream = Nothing
            Catch ex As Exception
            End Try
        End If
        report_name = Nothing
    End Sub

    Private Sub datagridView_take_out_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridView_take_out.CellMouseDown
        Select Case (MouseButtons)
            Case MouseButtons.Left
                MessageBox.Show("Left")
            Case MouseButtons.Right
                If MessageBox.Show("คุณจะลบรายการเบิกหรือไม่ หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    datagridView_take_out.Rows().Remove(datagridView_take_out.SelectedRows(0))
                End If

        End Select
    End Sub

End Class