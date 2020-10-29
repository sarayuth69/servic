Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D


Public Class show_date_cus
     
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata_customer()
    End Sub

    Dim data_table_cus As DataTable
    Public Sub showdata_customer()
        data_customers.Rows.Clear()
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_customer As MySqlDataReader

        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM customers"
        read_customer = com.ExecuteReader()
        If read_customer.HasRows = True Then
            data_table_cus = New DataTable
            data_table_cus.Columns.Add("cus_id")
            data_table_cus.Columns.Add("cus_name")
            data_table_cus.Columns.Add("cus_shop")
            data_table_cus.Columns.Add("cus_address")
            data_table_cus.Columns.Add("cus_tell")
            data_table_cus.Columns.Add("cus_email")
            data_table_cus.Columns.Add("cus_taxid")
            data_table_cus.Columns.Add("cus_details")
            While read_customer.Read
                data_table_cus.Rows.Add(read_customer("cus_id"), read_customer("cus_name"), read_customer("cus_shop"), read_customer("cus_address") _
                                     , read_customer("cus_tell"), read_customer("cus_email"), read_customer("cus_taxid"), read_customer("cus_details"))
            End While

        End If
        com = Nothing
        conn_db = Nothing

        If Not IsNothing(data_table_cus) Then
            For il = 0 To data_table_cus.Rows.Count - 1
                data_customers.Rows.Add(
                data_table_cus.Rows(il).Item("cus_id").ToString,
                data_table_cus.Rows(il).Item("cus_name").ToString,
                data_table_cus.Rows(il).Item("cus_shop").ToString,
                data_table_cus.Rows(il).Item("cus_address").ToString,
                data_table_cus.Rows(il).Item("cus_tell").ToString)
            Next

        End If
    End Sub

    Private Sub btn_insert_cus_Click(sender As Object, e As EventArgs) Handles btn_insert_cus.Click
        Dim frm_insert_cus As New manage_customer
        frm_insert_cus.btn_delete_cus.Visible = False
        frm_insert_cus.btn_edit_cus.Visible = False

        frm_insert_cus.ShowDialog()
        showdata_customer()
    End Sub


    Private Sub search_customer_Click(sender As Object, e As EventArgs) Handles search_customer.Click

        search_data_cus()

    End Sub
    Public Sub search_data_cus()
        data_customers.Rows.Clear()
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_customer As MySqlDataReader
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()


        End With

        com = New MySqlCommand
        With com
            .Connection = conn_db
            .CommandType = CommandType.Text

            .CommandText = "SELECT * FROM customers WHERE cus_name LIKE '%" & check_text(txt_search_cus.Text.Trim) & "%'  OR cus_shop LIKE '%" & check_text(txt_search_cus.Text.Trim) & "%'"

        End With
        read_customer = com.ExecuteReader
        If read_customer.HasRows = True Then
            data_table_cus = New DataTable
            data_table_cus.Columns.Add("cus_id")
            data_table_cus.Columns.Add("cus_name")
            data_table_cus.Columns.Add("cus_shop")
            data_table_cus.Columns.Add("cus_address")
            data_table_cus.Columns.Add("cus_tell")
            data_table_cus.Columns.Add("cus_email")
            data_table_cus.Columns.Add("cus_taxid")
            data_table_cus.Columns.Add("cus_details")
            While read_customer.Read
                data_table_cus.Rows.Add(read_customer("cus_id"), read_customer("cus_name"), read_customer("cus_shop"), read_customer("cus_address") _
                                     , read_customer("cus_tell"), read_customer("cus_email"), read_customer("cus_taxid"), read_customer("cus_details"))
            End While
        Else
            data_table_cus = Nothing
        End If
        com.Connection.Close()
        read_customer.Close()
        com.Dispose()
        conn_db.Close()


        com = Nothing
        conn_db = Nothing

        If Not IsNothing(data_table_cus) Then
            For il = 0 To data_table_cus.Rows.Count - 1
                data_customers.Rows.Add(
                data_table_cus.Rows(il).Item("cus_id").ToString,
                data_table_cus.Rows(il).Item("cus_name").ToString,
                data_table_cus.Rows(il).Item("cus_shop").ToString,
                data_table_cus.Rows(il).Item("cus_address").ToString,
                data_table_cus.Rows(il).Item("cus_tell").ToString)
            Next

        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    MsgBox(check_text(txt_search_cus.Text))
    'End Sub

    Private Sub txt_search_cus_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search_cus.KeyDown
        If e.KeyCode = Keys.Enter Then
            search_customer_Click(sender, e)

        End If
    End Sub

    Private Sub data_customers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_customers.CellDoubleClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Dim frm_manage_cus As New manage_customer
        frm_manage_cus.Data_customer_edit = data_table_cus
        frm_manage_cus.btn_insert_customer.Visible = False
        frm_manage_cus.showdata_customer(data_customers.Rows(e.RowIndex).Cells("Column1").Value.ToString())
        frm_manage_cus.ShowDialog()
        showdata_customer()
    End Sub
End Class