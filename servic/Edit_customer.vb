
Imports MySql.Data.MySqlClient


Public Class Edit_customer
    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"

    Private Sub btn_delect_cus_Click(sender As Object, e As EventArgs) Handles btn_delect_cus.Click

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
            conn_db.Close()
            com.Dispose()

        End If




    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
    Public Data_customer_edit As DataTable
    Public cus_id_edit As String
    Public Sub showdata_customer()
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
        customer_name_edit.Text = read_data_edit.Item("cus_name")
        cus_shop_edit.Text = read_data_edit.Item("cus_shop")
        cus_address_edit.Text = read_data_edit.Item("cus_address")
        cus_tell_edit.Text = read_data_edit.Item("cus_tell")
        cus_email_edit.Text = read_data_edit.Item("cus_email")
        cus_taxid_edit.Text = read_data_edit.Item("cus_taxid")
        cus_details_edit.Text = read_data_edit.Item("cus_details")
        cus_id.Text = read_data_edit.Item("cus_id")
        'cus_name.Text = read_data_edit.Item("cus_name")
        con_db = Nothing
        com = Nothing

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata_customer()
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
            com.CommandText = "select COUNT(*) from customers WHERE cus_shop = '" & cus_shop_edit.Text & "'
                AND cus_address ='" & cus_address_edit.Text & "' AND cus_taxid = '" & cus_taxid_edit.Text & "' AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update = com.ExecuteScalar()


            com_1.Connection = conn_db
            com_1.CommandType = CommandType.Text
            com_1.CommandText = "select COUNT(*) from customers WHERE cus_address ='" & cus_address_edit.Text & "'
                  AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update_1 = com_1.ExecuteScalar()


            com_2.Connection = conn_db
            com_2.CommandType = CommandType.Text
            com_2.CommandText = "select COUNT(*) from customers WHERE cus_taxid = '" & cus_taxid_edit.Text & "'
                  AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update_2 = com_2.ExecuteScalar()


            com_3.Connection = conn_db
            com_3.CommandType = CommandType.Text
            com_3.CommandText = "select COUNT(*) from customers WHERE cus_shop = '" & cus_shop_edit.Text & "'
                  AND cus_id <> '" & cus_id.Text & "' "
            chackdata_update_3 = com_3.ExecuteScalar()

            If chackdata_update > 0 Then
                MsgBox("ข้อมูลซ้ำกัน", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                customer_name_edit.Focus()
                cus_shop_edit.Focus()
                cus_address_edit.Focus()
                cus_taxid_edit.Focus()
            ElseIf chackdata_update_1 > 0 Then
                MsgBox("ที่อยู่ซ้ำกัน", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                cus_address_edit.Focus()
            ElseIf chackdata_update_2 > 0 Then
                MsgBox("เลขผู้เสียภาษีซ้ำกัน", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                cus_taxid_edit.Focus()
            ElseIf chackdata_update_3 > 0 Then
                MsgBox("มีร้านค้าในระบบแล้ว", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
                customer_name_edit.Focus()
            Else
                If MessageBox.Show("คุณต้องการแก้ไขข้อมูล ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    com.CommandText = "update customers set cus_name = '" & customer_name_edit.Text & "',cus_shop='" & cus_shop_edit.Text & "',cus_address='" & cus_address_edit.Text & "',
                                cus_tell = '" & cus_tell_edit.Text & "',cus_email = '" & cus_email_edit.Text & "',cus_taxid='" & cus_taxid_edit.Text & "',cus_details = '" & cus_details_edit.Text & "'
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
End Class