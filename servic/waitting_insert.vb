
Imports MySql.Data.MySqlClient
Public Class waitting_insert




    Public Sub show_select_equipment()
        Dim dtb_equipment As DataTable
        Dim con_db As New MySqlConnection
        Dim com_A As New MySqlCommand
        Dim read_data As MySqlDataReader
        dtb_equipment = Nothing
        Dim list_equipmemt As New List(Of DictionaryEntry)
        dtb_equipment = Nothing
        With con_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com_A.Connection = con_db
        com_A.CommandType = CommandType.Text
        com_A.CommandText = "SELECT * FROM `stock_pos`"
        read_data = com_A.ExecuteReader()
        If read_data.HasRows = True Then
            dtb_equipment = New DataTable
            While read_data.Read
                list_equipmemt.Add(New DictionaryEntry(read_data.Item("Stock_name").ToString, read_data.Item("Stock_ID").ToString))

            End While
            ComboBox_equipment.DataSource = list_equipmemt
            ComboBox_equipment.DisplayMember = "key"
            ComboBox_equipment.ValueMember = "Value"
            ComboBox_equipment.SelectedIndex = 0

            com_A = Nothing
            dtb_equipment = Nothing
            read_data = Nothing
            con_db = Nothing
            list_equipmemt = Nothing

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()

    End Sub

    Private Sub Button_save_Click(sender As Object, e As EventArgs) Handles Button_save.Click

        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        Dim num As Integer
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT COUNT(*) FROM equipment_insert WHERE equipment_insert.Number_insert = '" & TextBox_number.Text.Trim & "' "
        num = com.ExecuteScalar()
        If num > 0 Then
            MsgBox("เลขใบนำเข้าซ้ำกันในระบบ")
        Else
            If TextBox_number.Text.Length = 0 Then
                MsgBox("กรุณาใส่เลขใบนำเข้าอุปกรณ์")
            ElseIf TextBox_total.Text.Length = 0 Then
                MsgBox("กรุณาใส่จำนวนนำเข้า")
            Else
                Data_waitting.Rows.Add(TextBox_number.Text, ComboBox_equipment.SelectedValue, ComboBox_equipment.Text, TextBox_total.Text, TextBox_Stock_unit.Text, TextBox_price.Text, Date_insert.Value.ToString("u").Replace("Z", ""), TextBox_emp.Text)
                TextBox_total.Clear()
                TextBox_price.Clear()
                ComboBox_equipment.SelectedIndex = 0
                Button_save_all.Visible = True
            End If
        End If



    End Sub
    Dim text As String = ""
    Dim text_up As String = ""
    Private Sub Button_save_all_Click(sender As Object, e As EventArgs) Handles Button_save_all.Click

        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        Dim num As Integer
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        For i = 0 To Data_waitting.Rows.Count - 1
            text = "INSERT INTO `equipment_insert` (`equipment_ID`, `Number_insert`, `equipment_name`, `equipment_totall`, `equipment_unit`, `equipment_price`, `equipment_date_insert`, `equipment_date_update`, `equipment_Emp`, `equipment_status`, `Stock_ID`) 
                    VALUES ('0', '" & Data_waitting.Rows(i).Cells(0).Value.ToString() & "', '" & Data_waitting.Rows(i).Cells(2).Value.ToString & "', '" & Data_waitting.Rows(i).Cells(3).Value.ToString & "', '" & Data_waitting.Rows(i).Cells(4).Value.ToString & "', 
                    '" & Data_waitting.Rows(i).Cells(5).Value.ToString & "','" & Date_insert.Value.ToString("u").Replace("Z", "") & "' ,NOW() , '" & Data_waitting.Rows(i).Cells(7).Value.ToString & "', 'ใช้งาน', '" & Data_waitting.Rows(i).Cells(1).Value.ToString & "');"
            com.CommandText = text
            com.ExecuteNonQuery()
            text_up = "UPDATE `stock_pos` SET `Number_devices`=`Number_devices`+'" & Data_waitting.Rows(i).Cells(3).Value.ToString & "' WHERE (`Stock_ID`='" & Data_waitting.Rows(i).Cells(1).Value.ToString & "')"
            com.CommandText = text_up
            com.ExecuteNonQuery()
        Next
        MessageBox.Show("นำอุปกรณ์เข้าเรียบร้อย")
        conn_db = Nothing
        com = Nothing
        Data_waitting.Rows.Clear()
        TextBox_number.Clear()
        TextBox_emp.Clear()
        Button_save_all.Visible = False
        Close()
    End Sub
    Function autoid_equioment_insert() As String
        autoid_equioment_insert = ""

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
            .CommandText = "SELECT SUBSTR(equipment_insert.Number_insert,7)+1 as id FROM equipment_insert order by (SUBSTR(equipment_insert.Number_insert,7)+1)*1 DESC limit 0,1"
            dr_A = .ExecuteReader
            If dr_A.HasRows Then
                dr_A.Read()
                autoid_equioment_insert = "N-" & CDbl(dr_A.Item("id")).ToString("00000000")
            Else
                autoid_equioment_insert = "N-00000001"
            End If
        End With
        com.Connection.Close()
        Conn.Close()
        dr_A.Close()
        Conn = Nothing


        Return autoid_equioment_insert
    End Function
    Private Sub waitting_insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show_select_equipment()
        TextBox_emp.Text = login_name
        TextBox_emp.Tag = login_ID


    End Sub

    Private Sub Data_waitting_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_waitting.CellDoubleClick
        If MessageBox.Show("ลบรายการ?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Data_waitting.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
    Public dtb_Stock As DataTable
    Private Sub ComboBox_equipment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_equipment.SelectedIndexChanged
        If ComboBox_equipment.Focused Then
            Dim conn_db As New MySqlConnection
            Dim com As New MySqlCommand
            Dim read_data As MySqlDataReader
            dtb_Stock = Nothing
            With conn_db
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = connect_db
                .Open()
            End With
            com.Connection = conn_db
            com.CommandType = CommandType.Text
            com.CommandText = "SELECT * FROM `Stock_pos` where Stock_ID = '" & ComboBox_equipment.SelectedValue & "'"
            read_data = com.ExecuteReader()
            read_data.Read()
            TextBox_Stock_unit.Text = read_data.Item("Stock_unit")

            conn_db.Close()
            conn_db = Nothing
            com = Nothing

            read_data = Nothing

        End If
    End Sub

    Private Sub Check_number_Click(sender As Object, e As EventArgs) Handles Check_number.Click
        If Check_number.Checked = True Then
            TextBox_number.Clear()
            TextBox_number.Enabled = True

        Else
            TextBox_number.Text = autoid_equioment_insert()
            TextBox_number.Enabled = False


        End If
    End Sub
End Class