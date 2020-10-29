
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D



Public Class Insert_repari
     
    'Public status_showdata_reload As String = "reload"
    Private Sub btn_insert_repair_Click(sender As Object, e As EventArgs) Handles btn_insert_repair.Click

        If price.Text.Length = 0 Then
            MsgBox("กรุณาใส่จำนวนเงิน")

        ElseIf remark.Text.Length = 0 Then
            remark.Text = "-"
        ElseIf emp.Text.Length = 0 Then
            MsgBox("กรุณาใส่ผู้รับผิดชอบงาน")
        ElseIf text_cus_name.Text.Length = 0 Then
            MsgBox("กรุณาใส่ชื่อลูกค้า")
        ElseIf text_address.Text.Length = 0 Then
            MsgBox("กรุณาใส่ที่อยู่")
        ElseIf text_mail.Text.Length = 0 Then
            MsgBox("กรุณาใส่เมลล์")
        ElseIf text_shop_name.Text.Length = 0 Then
            MsgBox("กรุณาใส่ร้านค้า")
        ElseIf text_tell.Text.Length = 0 Then
            MsgBox("กรุณาใส่เบอร์โทรติดต่อ")
        ElseIf topic.Text.Length = 0 Then
            MsgBox("กรุณาใส่หัวข้อ")
        ElseIf deteil_repari.Text.Length = 0 Then
            MsgBox("กรุณาใส่รายละเอียดการแจ้งซ่อม")
        ElseIf text_taxid.Text.Length = 0 Then
            MsgBox("กรุณาใส่รหัสผู้เสียภาษี")
        Else

            Dim Conn As New MySqlConnection
            Dim com As New MySqlCommand

            com = Conn.CreateCommand()
            With Conn
                If .State = ConnectionState.Open Then
                    .Close()
                End If
                .ConnectionString = connect_db
                .Open()
            End With

            com = New MySqlCommand()
            With com
                .Connection = Conn
                .CommandType = CommandType.Text


                .CommandText = "INSERT INTO cus_repair value (@repair_id, @cus_name, @shop_name, @address, @tell, @email, @tax_id, @topic, @price, 
@repair_details, @repair_status, @remark, @emp,@emp_edit,NOW(),NOW(),@date_send_cus)"

                .Parameters.Clear()

                .Parameters.Add("@repair_id", MySqlDbType.VarChar).Value = Autoid()
                .Parameters.Add("@cus_name", MySqlDbType.VarChar).Value = text_cus_name.Text.Trim
                .Parameters.Add("@shop_name", MySqlDbType.VarChar).Value = text_shop_name.Text.Trim
                .Parameters.Add("@address", MySqlDbType.VarChar).Value = text_address.Text.Trim
                .Parameters.Add("@tell", MySqlDbType.VarChar).Value = text_tell.Text.Trim
                .Parameters.Add("@email", MySqlDbType.VarChar).Value = text_mail.Text.Trim
                .Parameters.Add("@tax_id", MySqlDbType.VarChar).Value = text_taxid.Text.Trim
                .Parameters.Add("@topic", MySqlDbType.VarChar).Value = topic.Text.Trim
                .Parameters.Add("@price", MySqlDbType.VarChar).Value = price.Text.Trim
                .Parameters.Add("@repair_details", MySqlDbType.VarChar).Value = deteil_repari.Text.Trim
                .Parameters.Add("@repair_status", MySqlDbType.VarChar).Value = "0"
                .Parameters.Add("@remark", MySqlDbType.VarChar).Value = remark.Text.Trim
                .Parameters.Add("@emp", MySqlDbType.VarChar).Value = emp.Text.Trim
                .Parameters.Add("@emp_edit", MySqlDbType.VarChar).Value = ""
                .Parameters.Add("@date_add", MySqlDbType.VarChar).Value = ""
                .Parameters.Add("@date_edit", MySqlDbType.VarChar).Value = ""
                .Parameters.Add("@date_send_cus", MySqlDbType.VarChar).Value = DateTimePicker_send_cus.Value.ToString("u").Replace("Z", "")
                .ExecuteNonQuery()

            End With
            '======LOG====================================================================================================
            'AddLog("เพิ่มข้อมูลพนักงาน", Me.Name, login_name, "เพิ่ม : " & txt_flname.Text) 'DataLog action,frm,emp,remark
            '==========================================================================================================

            MessageBox.Show("เพิ่มข้อมูลการแจ้งซ่อม เรียบร้อย", "ผลการทำงาน")

            Me.Close()
            com.Dispose()
            com = Nothing
            Conn.Dispose()
            Conn = Nothing
        End If




    End Sub

    Function Autoid() As String
        Autoid = ""

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
            .CommandText = "SELECT SUBSTR(cus_repair.repair_id,4)+1 as id FROM cus_repair order by (SUBSTR(cus_repair.repair_id,4)+1)*1 DESC limit 0,1"
            dr_A = .ExecuteReader

            If dr_A.HasRows Then
                dr_A.Read()
                Autoid = "REP" & CDbl(dr_A.Item("id")).ToString("00000")
            Else
                Autoid = "REP00001"
            End If

        End With
        com.Connection.Close()
        Conn.Close()
        dr_A.Close()
        com = Nothing
        Conn = Nothing
        dr_A = Nothing

        Return Autoid
    End Function


    Public Sub showdata_to_combobox()
        Dim dtb_equipment As DataTable
        Dim con_db As New MySqlConnection
        Dim com_A As New MySqlCommand
        Dim dr_A As MySqlDataReader
        dtb_equipment = Nothing
        Dim list1 As New List(Of DictionaryEntry)
        dtb_equipment = Nothing
        With con_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com_A.Connection = con_db
        com_A.CommandType = CommandType.Text
        com_A.CommandText = "SELECT * FROM `customers`"
        dr_A = com_A.ExecuteReader()
        If dr_A.HasRows = True Then
            dtb_equipment = New DataTable
            While dr_A.Read

                list1.Add(New DictionaryEntry(dr_A.Item("cus_name").ToString, dr_A.Item("cus_id").ToString))

            End While
            select_customer.DataSource = list1
            select_customer.DisplayMember = "key"
            select_customer.ValueMember = "Value"
            'select_customer.SelectedIndex = 0
            com_A = Nothing
            dtb_equipment = Nothing
            dr_A = Nothing
            con_db = Nothing
            list1 = Nothing

        End If
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata_to_combobox()
        AutoCompliteTextbox(select_customer)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        price.Text = " "
        remark.Text = " "
        emp.Text = " "
        text_cus_name.Text = " "
        text_address.Text = " "
        text_mail.Text = " "
        text_shop_name.Text = " "
        text_tell.Text = " "
        topic.Text = " "
        deteil_repari.Text = " "
        text_taxid.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Select Case text_shop_name.Text
            Case "0"
                select_customer.SelectedIndex = 0
            Case "1"
                select_customer.SelectedIndex = 1
            Case "2"
                select_customer.SelectedIndex = 2
            Case "3"
                select_customer.SelectedIndex = 3
            Case Else
                select_customer.SelectedIndex = 4

        End Select
    End Sub

    Public dtb_equipment As DataTable


    Private Sub select_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles select_customer.SelectedIndexChanged
        'select_customer.AutoCompleteMode = AutoCompleteMode.Suggest
        'select_customer.AutoCompleteSource = AutoCompleteSource.ListItems
        If select_customer.Focused Then
            Dim conn_db As New MySqlConnection
            Dim com As New MySqlCommand
            Dim read_data As MySqlDataReader
            dtb_equipment = Nothing
            With conn_db
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connect_db
                .Open()
            End With
            com.Connection = conn_db
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT * FROM `customers` where cus_id = '" & select_customer.SelectedValue & "'"
            read_data = com.ExecuteReader()
            read_data.Read()
            text_cus_name.Text = read_data.Item("cus_name")
            text_shop_name.Text = read_data.Item("cus_shop")
            text_address.Text = read_data.Item("cus_address")
            text_tell.Text = read_data.Item("cus_tell")
            text_mail.Text = read_data.Item("cus_email")
            text_taxid.Text = read_data.Item("cus_taxid")
            conn_db.Close()
            conn_db = Nothing
            com = Nothing

            read_data = Nothing

        End If



    End Sub
    Dim data_cus As DataTable
#Region "AutoCompliteTextbox"
    Private Sub AutoCompliteTextbox(ByVal select_customer As ComboBox)
        Dim MySource As New AutoCompleteStringCollection()
        Try
            MySource.AddRange(autoc.ToArray)
            select_customer.AutoCompleteCustomSource = MySource
            select_customer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            select_customer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Catch ex As Exception
            select_customer.AutoCompleteCustomSource = Nothing
        End Try
        MySource = Nothing
    End Sub
    Function autoc() As List(Of String)
        data_cus = Nothing
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand

        Dim read_c As MySqlDataReader
        com = conn_db.CreateCommand
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With
        com = New MySqlCommand
        With com
            com.Connection = conn_db
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT * FROM `customers`"
            read_c = com.ExecuteReader
            If read_c.HasRows Then
                data_cus = New DataTable
                data_cus.Load(read_c)
            End If
        End With
        autoc = New List(Of String)
        For ii = 0 To data_cus.Rows.Count - 1
            autoc.Add(data_cus.Rows(ii).Item("cus_name").ToString)
        Next



    End Function
#End Region



    Private Sub text_taxid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_taxid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
End Class