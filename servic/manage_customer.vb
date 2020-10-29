Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class manage_customer


    Public Data_customer_edit As DataTable
    Public cus_id_edit As String
    Private Sub btn_insert_customer_Click(sender As Object, e As EventArgs) Handles btn_insert_customer.Click
        insert_to_customer()

    End Sub

    Public Sub showdata_customer(ByVal cus_id_edit As String)
        Dim con_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data_edit As MySqlDataReader
        With con_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = con_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM customers WHERE cus_id = '" & cus_id_edit & "'"
        read_data_edit = com.ExecuteReader()
        read_data_edit.Read()
        customer_name.Text = read_data_edit.Item("cus_name")
        cus_shop.Text = read_data_edit.Item("cus_shop")
        cus_address.Text = read_data_edit.Item("cus_address")
        cus_tell.Text = read_data_edit.Item("cus_tell")
        cus_email.Text = read_data_edit.Item("cus_email")
        cus_taxid.Text = read_data_edit.Item("cus_taxid")
        cus_details.Text = read_data_edit.Item("cus_details")
        cus_id.Text = read_data_edit.Item("cus_id")
        'cus_name.Text = read_data_edit.Item("cus_name")
        con_db = Nothing
        com = Nothing

    End Sub
    Public Sub insert_to_customer()
        If customer_name.Text.Length = 0 Then
            MsgBox("กรุณาใส่ชื่อลูกค้า")
        ElseIf cus_shop.Text.Length = 0 Then
            MsgBox("กรุณาใส่ชื่อร้านค้า")
        ElseIf cus_address.Text.Length = 0 Then
            MsgBox("กรุณาใส่ที่อยู่")
        ElseIf cus_tell.Text.Length = 0 Then
            MsgBox("กรุณาใส่เบอร์โทร")
        ElseIf cus_taxid.Text.Length = 0 Then
            MsgBox("กรุณาใส่รหัสประจำตัวผู้เสียภาษี")
        ElseIf cus_email.Text.Length = 0 Then
            MsgBox("กรุณาใส่ อีเมลล์")
        ElseIf cus_details.Text.Length = 0 Then
            cus_details.Text = "-"

        Else
            If CheckState.Checked Then

            End If


            Dim conn_db As New MySqlConnection
            Dim com As New MySqlCommand
            com = conn_db.CreateCommand


            With conn_db
                If .State = ConnectionState.Open Then
                    .Close()
                End If
                .ConnectionString = connect_db
                .Open()

            End With
            com = New MySqlCommand()
            With com
                .Connection = conn_db
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO `customers` (`cus_id`, `cus_name`, `cus_shop`, 
                            `cus_address`, `cus_tell`, `cus_email`, `cus_taxid`, `cus_details`) VALUES (
                                    '" & autoid_customer() & "', '" & customer_name.Text & "','" & cus_shop.Text & "',
                                   '" & cus_address.Text & "', '" & cus_tell.Text & "', '" & cus_email.Text & "', '" & cus_taxid.Text & "', '" & cus_details.Text & "'
                                          );"
                .ExecuteNonQuery()
            End With
            MessageBox.Show("เพิ่มข้อมูลลูกค้า เรียบร้อย", "ผลการทำงาน")

            Me.Close()
            conn_db = Nothing
            com = Nothing


        End If



    End Sub

    Function autoid_customer() As String
        autoid_customer = ""

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
            .CommandText = "SELECT SUBSTR(customers.cus_id,4)+1 as id FROM customers order by (SUBSTR(customers.cus_id,4)+1)*1 DESC limit 0,1"
            dr_A = .ExecuteReader

            If dr_A.HasRows Then
                dr_A.Read()
                autoid_customer = "CUS" & CDbl(dr_A.Item("id")).ToString("00000")
            Else
                autoid_customer = "CUS00001"
            End If

        End With
        com.Connection.Close()
        Conn.Close()
        dr_A.Close()
        Conn = Nothing


        Return autoid_customer
    End Function



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btn_edit_cus_Click(sender As Object, e As EventArgs) Handles btn_edit_cus.Click
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim com_1 As New MySqlCommand
        Dim com_2 As New MySqlCommand
        Dim com_3 As New MySqlCommand
        Dim read_chack As MySqlDataReader
        Dim chackdata_update As Integer
        Dim chackdata_update_1 As Integer
        Dim chackdata_update_2 As Integer
        Dim chackdata_update_3 As Integer
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        With com
            com.Connection = conn_db
            com.CommandType = CommandType.Text
            com.CommandText = "select COUNT(*) from customers WHERE cus_shop = '" & cus_shop.Text & "'
                AND cus_address ='" & cus_address.Text & "' AND cus_taxid = '" & cus_taxid.Text & "' AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update = com.ExecuteScalar()


            com_1.Connection = conn_db
            com_1.CommandType = CommandType.Text
            com_1.CommandText = "select COUNT(*) from customers WHERE cus_address ='" & cus_address.Text & "'
                  AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update_1 = com_1.ExecuteScalar()


            com_2.Connection = conn_db
            com_2.CommandType = CommandType.Text
            com_2.CommandText = "select COUNT(*) from customers WHERE cus_taxid = '" & cus_taxid.Text & "'
                  AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update_2 = com_2.ExecuteScalar()


            com_3.Connection = conn_db
            com_3.CommandType = CommandType.Text
            com_3.CommandText = "select COUNT(*) from customers WHERE cus_shop = '" & cus_shop.Text & "'
                  AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update_3 = com_3.ExecuteScalar()

            If chackdata_update > 0 Then
                MsgBox("ข้อมูลซ้ำกัน", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                customer_name.Focus()
                cus_shop.Focus()
                cus_address.Focus()
                cus_taxid.Focus()
            ElseIf chackdata_update_1 > 0 Then
                MsgBox("ที่อยู่ซ้ำกัน", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                cus_address.Focus()
            ElseIf chackdata_update_2 > 0 Then
                MsgBox("เลขผู้เสียภาษีซ้ำกัน", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                cus_taxid.Focus()
            ElseIf chackdata_update_3 > 0 Then
                MsgBox("มีร้านค้าในระบบแล้ว", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                customer_name.Focus()
            Else
                If MessageBox.Show("คุณต้องการแก้ไขข้อมูล ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    com.CommandText = "update customers set cus_name = '" & customer_name.Text & "',cus_shop='" & cus_shop.Text & "',cus_address='" & cus_address.Text & "',
                                cus_tell = '" & cus_tell.Text & "',cus_email = '" & cus_email.Text & "',cus_taxid='" & cus_taxid.Text & "',cus_details = '" & cus_details.Text & "'
                                where cus_id = '" & cus_id.Text & "'"
                    .ExecuteNonQuery()
                    com.Connection.Close()
                    conn_db.Close()
                    com = Nothing
                    conn_db = Nothing
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน")
                    Me.Close()
                End If
            End If
        End With
        com = Nothing
        com_1 = Nothing
        com_2 = Nothing
        com_3 = Nothing
        chackdata_update = Nothing
        chackdata_update_1 = Nothing
        chackdata_update_2 = Nothing
        chackdata_update_3 = Nothing
        conn_db = Nothing
    End Sub

    Private Sub btn_delete_cus_Click(sender As Object, e As EventArgs) Handles btn_delete_cus.Click
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
            With com
                .Connection = conn_db
                .CommandType = CommandType.Text
                .CommandText = "DELETE FROM `customers` WHERE `customers`.`cus_id` = '" & cus_id.Text & "'"
                .ExecuteNonQuery()
            End With
            'read_data.Close()
            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน")
            Me.Close()
            'showdata_customer()
            conn_db = Nothing
            com = Nothing
        End If
    End Sub

    Private Sub manage_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class