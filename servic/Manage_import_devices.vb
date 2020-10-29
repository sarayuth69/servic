
Imports MySql.Data.MySqlClient
Public Class Manage_import_devices

    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=service_test; Pooling=false;"

    Public Sub show(ByVal test As String)
        Dim conn As New MySqlConnection
        Dim com As New MySqlCommand
        Dim read As MySqlDataReader
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = connect_db
            .Open()

        End With
        com.Connection = conn
        com.CommandType = CommandType.Text
        com.CommandText = "SELECT * FROM `stock_pos` where Stock_ID = '" & test & "' "
        read = com.ExecuteReader()
        read.Read()
        TextBox1.Text = read.Item("Stock_name")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        manage_list_insert.ShowDialog()
        TextBox1.Text = manage_list_insert.name
    End Sub


End Class