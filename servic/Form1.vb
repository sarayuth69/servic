
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Drawing.Drawing2D



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnmanagement_Click(sender, e)

    End Sub

    Private Sub btn_data_cus_Click(sender As Object, e As EventArgs) Handles btn_data_cus.Click
        Panel4.Height = btn_data_cus.Height
        Panel4.Top = btn_data_cus.Top
        openChildForm5(New Form5, panalbackground)

    End Sub

    Private currentForm As Form = Nothing
    Public Sub openChildForm1(ByVal form2 As Form, ByVal pal As Panel)
        currentForm = form2
        form2.TopLevel = False
        form2.FormBorderStyle = FormBorderStyle.None
        form2.Dock = DockStyle.Fill
        pal.Controls.Add(form2)
        pal.Tag = form2
        form2.BringToFront()
        form2.Show()
    End Sub
    Public Sub openChildForm5(ByVal form5 As Form, ByVal pal As Panel)
        currentForm = form5
        form5.TopLevel = False
        form5.FormBorderStyle = FormBorderStyle.None
        form5.Dock = DockStyle.Fill
        pal.Controls.Add(form5)
        pal.Tag = form5
        form5.BringToFront()
        form5.Show()
    End Sub
    Public Sub openChildForm8(ByVal form8 As Form, ByVal pal As Panel)
        currentForm = form8
        form8.TopLevel = False
        form8.FormBorderStyle = FormBorderStyle.None
        form8.Dock = DockStyle.Fill
        pal.Controls.Add(form8)
        pal.Tag = form8
        form8.BringToFront()
        form8.Show()
    End Sub

    Public Sub openChildForm9(ByVal form9 As Form, ByVal pal As Panel)
        currentForm = form9
        form9.TopLevel = False
        form9.FormBorderStyle = FormBorderStyle.None
        form9.Dock = DockStyle.Fill
        pal.Controls.Add(form9)
        pal.Tag = form9
        form9.BringToFront()
        form9.Show()
    End Sub
    Public Sub openChildForm12(ByVal form12 As Form, ByVal pal As Panel)
        currentForm = form12
        form12.TopLevel = False
        form12.FormBorderStyle = FormBorderStyle.None
        form12.Dock = DockStyle.Fill
        pal.Controls.Add(form12)
        pal.Tag = form12
        form12.BringToFront()
        form12.Show()
    End Sub


    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Panel4.Height = btnlogout.Height
        Panel4.Top = btnlogout.Top
        Me.Close()
        Login.Show()

    End Sub

    Private Sub btnmanagement_Click(sender As Object, e As EventArgs) Handles btnmanagement.Click
        Panel4.Height = btnmanagement.Height
        Panel4.Top = btnmanagement.Top
        openChildForm1(New repari, panalbackground)
    End Sub

    Private Sub btn_list_Click(sender As Object, e As EventArgs) Handles btn_list.Click
        Panel4.Height = btn_list.Height
        Panel4.Top = btn_list.Top
        openChildForm9(New Form9, panalbackground)
    End Sub

    Private Sub btn_Stock_Click(sender As Object, e As EventArgs) Handles btn_Stock.Click
        Panel4.Height = btn_Stock.Height
        Panel4.Top = btn_Stock.Top
        openChildForm8(New Form8, panalbackground)
    End Sub


    Private Sub btn_insert_equipment_Click(sender As Object, e As EventArgs) Handles btn_insert_equipment.Click
        Panel4.Height = btn_insert_equipment.Height
        Panel4.Top = btn_insert_equipment.Top
        openChildForm12(New Form12, panalbackground)
    End Sub
End Class
