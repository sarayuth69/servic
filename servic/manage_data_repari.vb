
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D



Public Class manage_data_repari

     
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

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fr_4 As New manage_data_repari
        showData()
        Text_emp_edit.Text = login_name

    End Sub
    Public data_edit As DataTable
    Public repari_ID As String
    Public Sub showData()



        Dim con_db As New MySqlConnection
        Dim com_A As New MySqlCommand
        Dim dr_A As MySqlDataReader
        With con_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With

        com_A.Connection = con_db
        com_A.CommandType = CommandType.Text
        com_A.CommandText = "SELECT * FROM `cus_repair` WHERE repair_id = '" & repari_ID & "'"
        dr_A = com_A.ExecuteReader()
        dr_A.Read()

        Text_repair_id.Text = dr_A.Item("repair_id")

        Text_cus.Text = dr_A.Item("cus_name")
        Text_shop.Text = dr_A.Item("shop_name")
        Text_address.Text = dr_A.Item("address")
        Text_tell.Text = dr_A.Item("tell")
        TextMail.Text = dr_A.Item("email")
        Text_tax.Text = dr_A.Item("tax_id")
        Text_topic.Text = dr_A.Item("topic")
        Text_price.Text = dr_A.Item("price")
        Text_detail.Text = dr_A.Item("repair_details")
        Text_remark.Text = dr_A.Item("remark")
        DateTimePicker_add.Text = dr_A.Item("date_add")
        Text_emp.Text = dr_A.Item("emp")
        Select Case dr_A.Item("repair_status")
            Case "0"
                ComboBox_status.SelectedIndex = 0
            Case "1"
                ComboBox_status.SelectedIndex = 1
            Case "2"
                ComboBox_status.SelectedIndex = 2
            Case "3"
                ComboBox_status.SelectedIndex = 3
            Case "4"
                ComboBox_status.SelectedIndex = 4
            Case "5"
                ComboBox_status.SelectedIndex = 5
        End Select

        Text_emp_edit.Text = dr_A.Item("emp_edit")
        DateTimePicker_send_cus_edit.Text = dr_A.Item("date_send_cus")
        dr_A.Close()
        dr_A.Dispose()
        com_A.Connection.Close()
        com_A.Dispose()
        con_db.Close()
        con_db = Nothing
        com_A = Nothing
        dr_A = Nothing
    End Sub


    Private Sub btn_edit_seva_Click(sender As Object, e As EventArgs) Handles btn_edit_seva.Click
        If MessageBox.Show("คุณต้องการแก้ไขข้อมูล ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Dim con_db As New MySqlConnection
            Dim com As New MySqlCommand
            Dim dr_A As MySqlDataReader

            com = con_db.CreateCommand()
            With con_db
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connect_db
                .Open()
            End With

            com = New MySqlCommand()
            With com
                .Connection = con_db
                .CommandType = CommandType.Text

                .CommandText = "UPDATE `cus_repair` SET `cus_name` = '" & Text_cus.Text & "', `shop_name` = '" & Text_shop.Text & "',
                                `address` = '" & Text_address.Text & "', `tell` = '" & Text_tell.Text & "', 
                                `email` = '" & TextMail.Text & "', `tax_id` = '" & Text_tax.Text & "', `topic` = '" & Text_topic.Text & "', `price` = '" & Text_price.Text & "', 
                                `repair_details` = '" & Text_detail.Text & "', `repair_status` = '" & ComboBox_status.SelectedIndex & "', `remark` = '" & Text_remark.Text & "', `emp` = '" & Text_emp.Text & "', 
                                `emp_edit` = '" & Text_emp_edit.Text & "',`date_add`='" & DateTimePicker_add.Value.ToString("u").Replace("Z", "") & "', `date_edit` = NOW(),`date_send_cus` = '" & DateTimePicker_send_cus_edit.Value.ToString("u").Replace("Z", "") & "'  WHERE `cus_repair`.`repair_id` = '" & Text_repair_id.Text & "';"

                .ExecuteNonQuery()


            End With

            com.Connection.Close()
            con_db.Close()
            dr_A = Nothing
            com = Nothing
            con_db = Nothing



            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน")
            Me.Close()
            showData()

        End If
    End Sub

    Private Sub btn_delete_item_Click(sender As Object, e As EventArgs) Handles btn_delete_item.Click
        If MessageBox.Show("คุณต้องการลบข้อมูล ใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


            Dim con_db As New MySqlConnection
            Dim com As New MySqlCommand

            com = con_db.CreateCommand()
            With con_db
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connect_db
                .Open()
            End With

            com = New MySqlCommand()
            With com
                .Connection = con_db
                .CommandType = CommandType.Text

                .CommandText = "delete from cus_repair  where  repair_id = '" & Text_repair_id.Text.Trim & "' "
                .ExecuteNonQuery()


            End With

            'com.Connection.Close()
            'Conn.Close()
            con_db = Nothing
            com = Nothing

            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการทำงาน")

            Me.Close()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        showData()
    End Sub

End Class