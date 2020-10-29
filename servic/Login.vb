

Imports MySql.Data.MySqlClient

Imports System.ServiceProcess




Public Class Login
     

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Panal_Register.Visible = True
        Panal_Login.Visible = False
        Guna2Transition1.ShowSync(Panal_Register)
    End Sub

    Private Sub btn_create_account_Click(sender As Object, e As EventArgs) Handles btn_create_account.Click
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        Dim count_user As Integer

        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT COUNT(*) FROM employee WHERE employee.Username = '" & TextBox_Username.Text.Trim & "' AND employee.`Password` = '" & TextBox_password.Text.Trim & "'"
        count_user = com.ExecuteNonQuery()
        If count_user > 0 Then
            MsgBox("Username มีผู้ใช้แล้ว")
            TextBox_Username.Focus()


        Else
            com.CommandText = "INSERT INTO `employee` VALUES ('0', '" & TextBox_name.Text.Trim & "', '" & TextBox_card_id.Text.Trim & "', '" & ComBoBox_sex.Text & "', '" & TextBox_tell.Text.Trim & "', NOW(), '" & TextBox_Username.Text.Trim & "', '" & TextBox_password.Text.Trim & "')"
            com.ExecuteNonQuery()

            MessageBox.Show("สมัครสมาชิกเรียบร้อย")
            Panal_Register.Visible = False
            Panal_Login.Visible = True

        End If




    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Panal_Register.Visible = False
        Panal_Login.Visible = True
        Guna2Transition1.HideSync(Panal_Register)

    End Sub

    Private Sub Button_login_Click(sender As Object, e As EventArgs) Handles Button_login.Click
        Dim conn_db As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read_data As MySqlDataReader
        Dim count_login As Integer
        With conn_db
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()
        End With
        com.Connection = conn_db
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM employee WHERE employee.Username = '" & check_text(TextBox_username_login.Text.Trim) & "' AND employee.`Password` = '" & check_text(TextBox_password_login.Text.Trim) & "'"
        read_data = com.ExecuteReader()

        If read_data.HasRows = True Then
            read_data.Read()
            login_ID = read_data.Item("Emp_ID")
            login_name = read_data.Item("Emp_name")
            sex_name = read_data.Item("Emp_sex")
            Me.Hide()
            TextBox_password_login.Clear()
            TextBox_username_login.Clear()
            TextBox_username_login.Focus()
            Home.ShowDialog()

        Else
            MsgBox("ไม่มี User ในระบบ", MsgBoxStyle.Critical, "แจ้งเตือน" & "!!")
            TextBox_username_login.Focus()
            TextBox_password_login.Focus()

        End If
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        TextBox_password_login.UseSystemPasswordChar = Not Guna2ToggleSwitch1.Checked
    End Sub

    Private Sub TextBox_password_login_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_password_login.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_login_Click(sender, e)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If check_service("mysql") = True Then
            MsgBox("มีservic")
            If check_parth("C:\AppServ\MySQL\data") = True Then
                If check_parth("C:\AppServ\MySQL\data\service_test") = True Then
                    MsgBox("ทุกอย่างสมบรูณ์")
                Else
                    My.Computer.FileSystem.CopyDirectory(Application.StartupPath & "\data_install\service_test", "C:\AppServ\MySQL\data\", True)
                End If
            End If
        Else
            Process.Start(Application.StartupPath & "\data_install\appserv-x64-9.3.0.exe")
        End If
    End Sub

    Function check_service(str As String)
        Dim servicesButNotDevices As ServiceController() = ServiceController.GetServices()

        For Each service As ServiceController In servicesButNotDevices
            If service.ServiceName.ToLower.Contains(str) Then 'May also use DispalyName property depending on your use case
                'Put in list box

                Return True
                Exit For

            End If
        Next
        Return False
    End Function

    Function check_parth(str As String)
        If My.Computer.FileSystem.DirectoryExists(str) Then
            Return True
        End If
        Return False
    End Function
End Class