Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form2
    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"
    Public Sub testconnecttion()
        Dim con_db As New MySqlConnection
        Dim com As New MySqlCommand

        com = con_db.CreateCommand()
        With con_db
            If .State = ConnectionState.Open Then
                .Close()
            End If
            .ConnectionString = connect_db
            .Open()
        End With
        MessageBox.Show("เชื่อมต่อสำเร็จ")
        showData()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("ต้องการลบรายการ ใช่หรือไม่?", "คำยืนยัน",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes Then

        End If
    End Sub

    Public dtb_equipment As DataTable
    Public status_show As String
    Public Sub showData()

        data_table.Rows.Clear()

        Dim con_db As New MySqlConnection
        Dim com_A As New MySqlCommand
        Dim dr_A As MySqlDataReader
        dtb_equipment = Nothing
        With con_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With

        com_A.Connection = con_db
        com_A.CommandType = CommandType.Text
        com_A.CommandText = "SELECT * FROM `cus_repair`"
        dr_A = com_A.ExecuteReader()


        If dr_A.HasRows = True Then

            dtb_equipment = New DataTable
            'dtb_equipment.Load(dr_A)
            dtb_equipment.Columns.Add("id")
            dtb_equipment.Columns.Add("repair_id")
            dtb_equipment.Columns.Add("cus_name")
            dtb_equipment.Columns.Add("shop_name")
            dtb_equipment.Columns.Add("address")
            dtb_equipment.Columns.Add("tell")
            dtb_equipment.Columns.Add("email")
            dtb_equipment.Columns.Add("tax_id")
            dtb_equipment.Columns.Add("topic")
            dtb_equipment.Columns.Add("price")
            dtb_equipment.Columns.Add("repair_details")
            dtb_equipment.Columns.Add("repair_status")
            dtb_equipment.Columns.Add("remark")
            dtb_equipment.Columns.Add("emp")
            dtb_equipment.Columns.Add("emp_edit")
            dtb_equipment.Columns.Add("date_add")
            dtb_equipment.Columns.Add("date_edit")


            While dr_A.Read
                Select Case dr_A("repair_status")
                    Case "0"
                        status_show = "รอซ่อม"
                    Case "1"
                        status_show = "เช็คอาการ"
                    Case "2"
                        status_show = "รออะไหล่"
                    Case "3"
                        status_show = "กำลังซ่อม"
                    Case "4"
                        status_show = "ซ่อมแล้ว"
                    Case "5"
                        status_show = "รอส่ง"
                    Case "6"
                        status_show = "ส่งคืนแล้ว"
                End Select
                dtb_equipment.Rows.Add(dr_A("id"), dr_A("repair_id"), dr_A("cus_name"), dr_A("shop_name"), dr_A("address"), dr_A("tell"), dr_A("email") _
                    , dr_A("tax_id"), dr_A("topic"), dr_A("price"), dr_A("repair_details"), status_show, dr_A("remark") _
                    , dr_A("emp"), dr_A("emp_edit"), dr_A("date_add"))

            End While




        End If

        dr_A.Close()
        dr_A.Dispose()
        com_A.Connection.Close()
        com_A.Dispose()
        con_db.Close()

        dr_A = Nothing
        com_A = Nothing
        con_db = Nothing

        If Not IsNothing(dtb_equipment) Then
            For ii = 0 To dtb_equipment.Rows.Count - 1

                data_table.Rows.Add(
                dtb_equipment.Rows(ii).Item("repair_id").ToString,
                dtb_equipment.Rows(ii).Item("date_add").ToString,
                dtb_equipment.Rows(ii).Item("cus_name").ToString,
                dtb_equipment.Rows(ii).Item("shop_name").ToString,
                dtb_equipment.Rows(ii).Item("tell").ToString,
                dtb_equipment.Rows(ii).Item("topic").ToString,
                dtb_equipment.Rows(ii).Item("repair_status").ToString,
                dtb_equipment.Rows(ii).Item("emp").ToString,
                dtb_equipment.Rows(ii).Item("remark").ToString)
            Next

        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        showData()
    End Sub


    Public Sub search()
        data_table.Rows.Clear()

        Dim con_db As New MySqlConnection
        Dim com_A As New MySqlCommand
        Dim dr_A As MySqlDataReader
        dtb_equipment = Nothing
        With con_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With

        com_A.Connection = con_db
        com_A.CommandType = CommandType.Text
        com_A.CommandText = "SELECT * FROM `cus_repair` WHERE repair_id LIKE '%" & text_search.Text.Trim.Replace("'", "\'") & "%' OR cus_name LIKE '%" & text_search.Text.Trim.Replace("'", "\'") & "%' OR shop_name LIKE '%" & text_search.Text.Trim.Replace("'", "\'") & "%'
                                OR emp LIKE '%" & text_search.Text.Trim.Replace("'", "\'") & "%'"
        dr_A = com_A.ExecuteReader()


        If dr_A.HasRows = True Then

            dtb_equipment = New DataTable
            'dtb_equipment.Load(dr_A)
            dtb_equipment.Columns.Add("id")
            dtb_equipment.Columns.Add("repair_id")
            dtb_equipment.Columns.Add("cus_name")
            dtb_equipment.Columns.Add("shop_name")
            dtb_equipment.Columns.Add("address")
            dtb_equipment.Columns.Add("tell")
            dtb_equipment.Columns.Add("email")
            dtb_equipment.Columns.Add("tax_id")
            dtb_equipment.Columns.Add("topic")
            dtb_equipment.Columns.Add("price")
            dtb_equipment.Columns.Add("repair_details")
            dtb_equipment.Columns.Add("repair_status")
            dtb_equipment.Columns.Add("remark")
            dtb_equipment.Columns.Add("emp")
            dtb_equipment.Columns.Add("emp_edit")
            dtb_equipment.Columns.Add("date_add")
            dtb_equipment.Columns.Add("date_edit")
            While dr_A.Read
                Select Case dr_A("repair_status")
                    Case "0"
                        status_show = "รอซ่อม"
                    Case "1"
                        status_show = "เช็คอาการ"
                    Case "2"
                        status_show = "รออะไหล่"
                    Case "3"
                        status_show = "กำลังซ่อม"
                    Case "4"
                        status_show = "ซ่อมแล้ว"
                    Case "5"
                        status_show = "รอส่ง"
                    Case "6"
                        status_show = "ส่งคืนแล้ว"
                End Select
                dtb_equipment.Rows.Add(dr_A("id"), dr_A("repair_id"), dr_A("cus_name"), dr_A("shop_name"), dr_A("address"), dr_A("tell"), dr_A("email") _
                    , dr_A("tax_id"), dr_A("topic"), dr_A("price"), dr_A("repair_details"), status_show, dr_A("remark") _
                    , dr_A("emp"), dr_A("emp_edit"), dr_A("date_add"))

            End While

        End If

        dr_A.Close()
        dr_A.Dispose()
        com_A.Connection.Close()
        com_A.Dispose()
        con_db.Close()

        dr_A = Nothing
        com_A = Nothing
        con_db = Nothing

        If Not IsNothing(dtb_equipment) Then
            For ii = 0 To dtb_equipment.Rows.Count - 1
                data_table.Rows.Add(
                dtb_equipment.Rows(ii).Item("repair_id").ToString,
                dtb_equipment.Rows(ii).Item("date_add").ToString,
                dtb_equipment.Rows(ii).Item("cus_name").ToString,
                dtb_equipment.Rows(ii).Item("shop_name").ToString,
                dtb_equipment.Rows(ii).Item("tell").ToString,
                dtb_equipment.Rows(ii).Item("topic").ToString,
                dtb_equipment.Rows(ii).Item("repair_status").ToString,
                dtb_equipment.Rows(ii).Item("emp").ToString,
                dtb_equipment.Rows(ii).Item("remark").ToString)
            Next

        End If

    End Sub



    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim fr_3 As New Form3
        fr_3.ShowDialog()
        showData()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        search()
    End Sub



    Private Sub data_table_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_table.CellMouseUp
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Dim fr_4 As New Form4
        fr_4.data_edit = dtb_equipment
        fr_4.repari_ID = data_table.Rows(e.RowIndex).Cells("Column1").Value.ToString()
        fr_4.ShowDialog()
        showData()
    End Sub






    'Function datasort()
    '    Dim conn_db As New MySqlConnection
    '    Dim com As New MySqlCommand
    '    Dim readdatasort As MySqlDataReader
    '    With conn_db
    '        If .State = ConnectionState.Open Then .Close()
    '        .Open()
    '    End With
    '    With com
    '        com.Connection = conn_db
    '        com.CommandType = CommandType.Text
    '        com.CommandText = "select * form customers"
    '        readdatasort = com.ExecuteReader()



    '    End With
    'End Function

End Class