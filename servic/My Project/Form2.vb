Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form2
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If MessageBox.Show("ต้องการลบรายการ ใช่หรือไม่?", "คำยืนยัน",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes Then

        End If
    End Sub
    Public Sub testconnecttion()
        Dim con_db As New MySqlConnection
        Dim com As New MySqlCommand

        com = con_db.CreateCommand()
        With con_db
            If .State = ConnectionState.Open Then
                .Close()
            End If
            .ConnectionString = "Server=127.0.0.1;User Id=root;Password=root1234; Database=module_service; Pooling=false;"
            .Open()
        End With
        MessageBox.Show("เชื่อมต่อสำเร็จ")
        showData()
    End Sub

    Dim dtb_equipment As DataTable
    Dim con_db As New MySqlConnection
    Dim com_A As New MySqlCommand
    Dim dr_A As MySqlDataReader
    Public Sub showData()
        DataGridView1.Rows.Clear()
        dtb_equipment = Nothing

        dtb_equipment = Nothing
        With con_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = "Server=127.0.0.1;User Id=root;Password=root1234; Database=module_service; Pooling=false;"
            .Open()
        End With

        com_A.Connection = con_db
        com_A.CommandType = CommandType.Text
        com_A.CommandText = "SELECT * FROM `customer-service` INNER JOIN product ON product.product_id = `customer-service`.product_id"
        dr_A = com_A.ExecuteReader()

        If dr_A.HasRows = True Then
            dtb_equipment = New DataTable
            dtb_equipment.Load(dr_A)

        End If

        dr_A.Close()
        dr_A.Dispose()
        com_A.Connection.Close()
        com_A.Dispose()
        con_db.Close()



        If Not IsNothing(dtb_equipment) Then
            For il = 0 To dtb_equipment.Rows.Count - 1
                DataGridView1.Rows.Add(
                dtb_equipment.Rows(il).Item("customer_id").ToString,
                dtb_equipment.Rows(il).Item("customer_name").ToString,
                dtb_equipment.Rows(il).Item("customer_address").ToString,
                dtb_equipment.Rows(il).Item("customer_status").ToString,
                dtb_equipment.Rows(il).Item("product_name").ToString)
            Next

        End If
    End Sub
End Class