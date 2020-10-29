Imports System.IO
Imports Microsoft.Office.Interop


Public Class print
    Private Sub print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        select_print.Items.Clear()
        For Each strPinterName As String In System.Drawing.Printing.PrinterSettings.InstalledPrinters

            Me.select_print.Items.Add(strPinterName)
        Next
        Me.select_print.DropDownStyle = select_print.DropDownStyle
        Me.select_print.SelectedIndex = 1 'selected default
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ReportExcel(1, select_print.Text)
        Me.Close()

    End Sub

    Private Sub ReportExcel(ByVal type As Integer, ByVal printer As String) '0=บันทึก 1=พิมพ์
        '-------------------------------------------------
        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range
        Dim report_name As String
        Dim Path_SaveFileExcel As String
        Dim myStream As Stream
        Dim Row_index As Integer
        Dim Row As Integer
        report_name = "ใบเบิกอุปกรณ์.xlsx" 'ชื่อไฟล์รายงาน
        SaveFileDialog1.FileName = "ใบเบิกอุปกรณ์" 'ชื่อไฟล์ที่จะเซฟ เช่น "รายละเอียดสินค้า"
        SaveFileDialog1.Filter = "Excel files (.xls)|.xls"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = False
        'datebegin1 = DatePre.Value.Day & "-" & DatePre.Value.Month & "-" & DatePre.Value.Year
        'datebAfter1 = DateAfter.Value.Day & "-" & DateAfter.Value.Month & "-" & DateAfter.Value.Year
        Try
            Dim proc As System.Diagnostics.Process
            For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
                proc.Kill()
            Next
        Catch w As System.ComponentModel.Win32Exception
            Console.WriteLine(w.Message)
            Console.WriteLine(w.ErrorCode.ToString())
            Console.WriteLine(w.NativeErrorCode.ToString())
            Console.WriteLine(w.StackTrace)
            Console.WriteLine(w.Source)
        End Try
        Me.Cursor = Cursors.WaitCursor ' ---- แสดงเมาส์เป็นรูปนาฬิกาทราบ
        appXL = CreateObject("Excel.Application")
        '-copy file-------------------------------
        Dim FileToCopy As String
        Dim NewCopy As String
        FileToCopy = My.Application.Info.DirectoryPath & "\Report\" & report_name
        NewCopy = My.Application.Info.DirectoryPath & "\" & report_name
        'ลบไฟล์ที่มีข้อมูลออกก่อน
        If System.IO.File.Exists(NewCopy) = True Then
            Try
                My.Computer.FileSystem.DeleteFile(NewCopy)
            Catch ex As Exception
                wbXl = appXL.Workbooks.Open(My.Application.Info.DirectoryPath & "\" & report_name)
                wbXl.Saved = True
                wbXl.Close()
                appXL.Quit()
            End Try
        End If
        'เช็คไฟล์รายงาน
        If System.IO.File.Exists(FileToCopy) = True Then
            Try
                System.IO.File.Copy(FileToCopy, NewCopy)
            Catch ex As Exception
                wbXl = appXL.Workbooks.Open(My.Application.Info.DirectoryPath & "\" & report_name)
                wbXl.Saved = True
                wbXl.Close()
                appXL.Quit()
            End Try
        Else
            MsgBox("ไม่พบไฟล์รายงาน " & report_name & " !!", MsgBoxStyle.Critical, "แจ้งเตือน")
            Me.Cursor = Cursors.Default ' ---- แสดงเมาส์ในรูปแบบปกติ
            appXL.Quit()
            appXL = Nothing
            wbXl = Nothing
            shXL = Nothing
            raXL = Nothing
            FileToCopy = Nothing
            NewCopy = Nothing
            myStream = Nothing
            Exit Sub
        End If
        '-copy file-------------------------------
        wbXl = appXL.Workbooks.Open(My.Application.Info.DirectoryPath & "\" & report_name)
        shXL = wbXl.ActiveSheet
        shXL.Range("F4").Value = take_out.DateTimePicker_send_cus.Value.ToString("d").Replace("Z", "")
        shXL.Range("H4").Value = take_out.DateTimePicker_get_back.Value.ToString("d").Replace("Z", "")
        shXL.Range("B4").Value = login_name
        shXL.Range("H3").Value = take_out.TextBox_ID.Text
        'If combo_status.Text = "Yes" Then
        '    shXL.Range("F7").Value = "เคลมเรียบร้อย"
        'ElseIf combo_status.Text = "No" Then
        '    shXL.Range("F7").Value = "รอเคลม"
        'Else
        '    shXL.Range("F7").Value = "ไม่สามารถเคลมได้"
        'End If
        shXL.Range("B5").Value = take_out.CB_select_cus.Text
        shXL.Range("F5").Value = take_out.txt_cus_shop.Text
        Row_index = 9
        Row = 0
        For i = 0 To take_out.datagridView_take_out.Rows.Count - 1

            shXL.Range("B" & Row_index + i).Value = take_out.datagridView_take_out.Rows(i).Cells("equipment_name").Value.ToString
            shXL.Range("F" & Row_index + i).Value = take_out.datagridView_take_out.Rows(i).Cells("total").Value.ToString
            shXL.Range("G" & Row_index + i).Value = take_out.datagridView_take_out.Rows(i).Cells("unit").Value.ToString
            shXL.Range("H" & Row_index + i).Value = take_out.datagridView_take_out.Rows(i).Cells("detel").Value.ToString
        Next
        For j = 0 To take_out.datagridView_take_out.Rows.Count - 1
            Row += 1
            shXL.Range("A" & Row_index + j).Value = Row

        Next

        'shXL.Range("D11").Value = txt_serial.Text
        'shXL.Range("D11").Value = txt_serial.Text
        'shXL.Range("E11").Value = dtp_timeExit.Text
        'shXL.Range("G11").Value = txt_remark.Text
        'shXL.Range("G18").Value = txt_userremark.Text
        Me.Cursor = Cursors.Default ' ---- แสดงเมาส์ในรูปแบบปกติ
        wbXl.Save() 'เซฟไฟล์
        If type = 0 Then 'บันทึก
            Try
                myStream = SaveFileDialog1.OpenFile()
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    Path_SaveFileExcel = IO.Path.GetFullPath(SaveFileDialog1.FileName)
                    wbXl.SaveAs(Path_SaveFileExcel)
                    myStream.Close()
                    wbXl.Close()
                    appXL.Quit()
                    appXL = Nothing
                    wbXl = Nothing
                    FileToCopy = Nothing
                    NewCopy = Nothing
                    myStream = Nothing
                    Path_SaveFileExcel = Nothing
                End If
            Catch ex As Exception
                wbXl.Close()
                appXL.Quit()
                appXL = Nothing
                wbXl = Nothing
                FileToCopy = Nothing
                NewCopy = Nothing
                myStream = Nothing
                Path_SaveFileExcel = Nothing
                Me.Cursor = Cursors.Default ' ---- แสดงเมาส์ในรูปแบบปกติ
                Exit Sub
            End Try
        ElseIf type = 1 Then 'พิมพ์
            Try
                wbXl.PrintOutEx(Copies:=1, ActivePrinter:=printer, Collate:=True)
                wbXl.Close()
                appXL.Quit()
                appXL = Nothing
                wbXl = Nothing
                FileToCopy = Nothing
                NewCopy = Nothing
                myStream = Nothing
            Catch ex As Exception
            End Try
        End If
        report_name = Nothing
    End Sub

End Class