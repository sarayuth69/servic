Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form6
    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"


    Private Sub btn_insert_customer_Click(sender As Object, e As EventArgs) Handles btn_insert_customer.Click
        insert_to_customer()

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

    Private Sub cancel_insert_Click(sender As Object, e As EventArgs) Handles cancel_insert.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class