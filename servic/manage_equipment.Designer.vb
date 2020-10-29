<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manage_equipment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage_equipment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_stock_ID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Stock_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Stock_remark = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Stock_deteil = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ComboBox_Stock_status = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Stock_price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.text_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox_unit = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTN_search_equipment = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete_Stock = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_insert_Stock = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit_Stock = New Guna.UI2.WinForms.Guna2Button()
        Me.datagridview_Stock = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.datagridview_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.442759!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.06116!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.87032!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.50528!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.56484!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.379443!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_stock_ID, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Stock_name, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Stock_remark, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Stock_deteil, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox_Stock_status, 4, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_Stock_price, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox_unit, 4, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 3, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.83223!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.54822!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.45575!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.45575!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1041, 202)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(357, 32)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "เพิ่มอุปกรณ์"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(518, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "รหัสรายการ :"
        Me.Label6.Visible = False
        '
        'txt_stock_ID
        '
        Me.txt_stock_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_stock_ID.BackColor = System.Drawing.Color.White
        Me.txt_stock_ID.BorderColor = System.Drawing.Color.Black
        Me.txt_stock_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_stock_ID.DefaultText = ""
        Me.txt_stock_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_stock_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_stock_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_stock_ID.DisabledState.Parent = Me.txt_stock_ID
        Me.txt_stock_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_stock_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_stock_ID.FocusedState.Parent = Me.txt_stock_ID
        Me.txt_stock_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock_ID.ForeColor = System.Drawing.Color.Black
        Me.txt_stock_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_stock_ID.HoverState.Parent = Me.txt_stock_ID
        Me.txt_stock_ID.Location = New System.Drawing.Point(648, 8)
        Me.txt_stock_ID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_stock_ID.Name = "txt_stock_ID"
        Me.txt_stock_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_stock_ID.PlaceholderText = ""
        Me.txt_stock_ID.SelectedText = ""
        Me.txt_stock_ID.ShadowDecoration.Parent = Me.txt_stock_ID
        Me.txt_stock_ID.Size = New System.Drawing.Size(331, 22)
        Me.txt_stock_ID.TabIndex = 16
        Me.txt_stock_ID.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ชื่ออุปกรณ์ :"
        '
        'txt_Stock_name
        '
        Me.txt_Stock_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Stock_name.BorderColor = System.Drawing.Color.Black
        Me.txt_Stock_name.BorderRadius = 10
        Me.txt_Stock_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Stock_name.DefaultText = ""
        Me.txt_Stock_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Stock_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Stock_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_name.DisabledState.Parent = Me.txt_Stock_name
        Me.txt_Stock_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_name.FocusedState.Parent = Me.txt_Stock_name
        Me.txt_Stock_name.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Stock_name.ForeColor = System.Drawing.Color.Black
        Me.txt_Stock_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_name.HoverState.Parent = Me.txt_Stock_name
        Me.txt_Stock_name.Location = New System.Drawing.Point(134, 43)
        Me.txt_Stock_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Stock_name.Name = "txt_Stock_name"
        Me.txt_Stock_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Stock_name.PlaceholderText = ""
        Me.txt_Stock_name.SelectedText = ""
        Me.txt_Stock_name.ShadowDecoration.Parent = Me.txt_Stock_name
        Me.txt_Stock_name.Size = New System.Drawing.Size(355, 39)
        Me.txt_Stock_name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "หมายเหตุ :"
        '
        'txt_Stock_remark
        '
        Me.txt_Stock_remark.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Stock_remark.BackColor = System.Drawing.Color.White
        Me.txt_Stock_remark.BorderColor = System.Drawing.Color.Black
        Me.txt_Stock_remark.BorderRadius = 10
        Me.txt_Stock_remark.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Stock_remark.DefaultText = ""
        Me.txt_Stock_remark.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Stock_remark.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Stock_remark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_remark.DisabledState.Parent = Me.txt_Stock_remark
        Me.txt_Stock_remark.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_remark.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_remark.FocusedState.Parent = Me.txt_Stock_remark
        Me.txt_Stock_remark.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Stock_remark.ForeColor = System.Drawing.Color.Black
        Me.txt_Stock_remark.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_remark.HoverState.Parent = Me.txt_Stock_remark
        Me.txt_Stock_remark.Location = New System.Drawing.Point(648, 44)
        Me.txt_Stock_remark.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Stock_remark.Name = "txt_Stock_remark"
        Me.txt_Stock_remark.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Stock_remark.PlaceholderText = ""
        Me.txt_Stock_remark.SelectedText = ""
        Me.txt_Stock_remark.ShadowDecoration.Parent = Me.txt_Stock_remark
        Me.txt_Stock_remark.Size = New System.Drawing.Size(331, 36)
        Me.txt_Stock_remark.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "รายละเอียด :"
        '
        'txt_Stock_deteil
        '
        Me.txt_Stock_deteil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Stock_deteil.BackColor = System.Drawing.Color.White
        Me.txt_Stock_deteil.BorderColor = System.Drawing.Color.Black
        Me.txt_Stock_deteil.BorderRadius = 10
        Me.txt_Stock_deteil.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.txt_Stock_deteil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Stock_deteil.DefaultText = ""
        Me.txt_Stock_deteil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Stock_deteil.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Stock_deteil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_deteil.DisabledState.Parent = Me.txt_Stock_deteil
        Me.txt_Stock_deteil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_deteil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_deteil.FocusedState.Parent = Me.txt_Stock_deteil
        Me.txt_Stock_deteil.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Stock_deteil.ForeColor = System.Drawing.Color.Black
        Me.txt_Stock_deteil.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_deteil.HoverState.Parent = Me.txt_Stock_deteil
        Me.txt_Stock_deteil.Location = New System.Drawing.Point(134, 94)
        Me.txt_Stock_deteil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Stock_deteil.Name = "txt_Stock_deteil"
        Me.txt_Stock_deteil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Stock_deteil.PlaceholderText = ""
        Me.txt_Stock_deteil.SelectedText = ""
        Me.txt_Stock_deteil.ShadowDecoration.Parent = Me.txt_Stock_deteil
        Me.txt_Stock_deteil.Size = New System.Drawing.Size(355, 42)
        Me.txt_Stock_deteil.TabIndex = 12
        '
        'ComboBox_Stock_status
        '
        Me.ComboBox_Stock_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_Stock_status.BackColor = System.Drawing.Color.White
        Me.ComboBox_Stock_status.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Stock_status.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_Stock_status.FormattingEnabled = True
        Me.ComboBox_Stock_status.Items.AddRange(New Object() {"ใช้งาน", "ไม่ใช้งาน"})
        Me.ComboBox_Stock_status.Location = New System.Drawing.Point(647, 100)
        Me.ComboBox_Stock_status.Name = "ComboBox_Stock_status"
        Me.ComboBox_Stock_status.Size = New System.Drawing.Size(333, 29)
        Me.ComboBox_Stock_status.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(577, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "สถานะ :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "ราคาอุปกรณ์ :"
        '
        'txt_Stock_price
        '
        Me.txt_Stock_price.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Stock_price.BackColor = System.Drawing.Color.White
        Me.txt_Stock_price.BorderColor = System.Drawing.Color.Black
        Me.txt_Stock_price.BorderRadius = 10
        Me.txt_Stock_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Stock_price.DefaultText = ""
        Me.txt_Stock_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_Stock_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_Stock_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_price.DisabledState.Parent = Me.txt_Stock_price
        Me.txt_Stock_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_Stock_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_price.FocusedState.Parent = Me.txt_Stock_price
        Me.txt_Stock_price.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txt_Stock_price.ForeColor = System.Drawing.Color.Black
        Me.txt_Stock_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Stock_price.HoverState.Parent = Me.txt_Stock_price
        Me.txt_Stock_price.Location = New System.Drawing.Point(134, 156)
        Me.txt_Stock_price.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Stock_price.Name = "txt_Stock_price"
        Me.txt_Stock_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_Stock_price.PlaceholderText = ""
        Me.txt_Stock_price.SelectedText = ""
        Me.txt_Stock_price.ShadowDecoration.Parent = Me.txt_Stock_price
        Me.txt_Stock_price.Size = New System.Drawing.Size(355, 33)
        Me.txt_Stock_price.TabIndex = 21
        '
        'text_search
        '
        Me.text_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_search.BackColor = System.Drawing.Color.White
        Me.text_search.BorderColor = System.Drawing.Color.Black
        Me.text_search.BorderRadius = 10
        Me.text_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_search.DefaultText = ""
        Me.text_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.text_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.text_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.text_search.DisabledState.Parent = Me.text_search
        Me.text_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.text_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.text_search.FocusedState.Parent = Me.text_search
        Me.text_search.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.text_search.ForeColor = System.Drawing.Color.Black
        Me.text_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.text_search.HoverState.Parent = Me.text_search
        Me.text_search.Location = New System.Drawing.Point(469, 15)
        Me.text_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.text_search.Name = "text_search"
        Me.text_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.text_search.PlaceholderText = ""
        Me.text_search.SelectedText = ""
        Me.text_search.ShadowDecoration.Parent = Me.text_search
        Me.text_search.Size = New System.Drawing.Size(359, 33)
        Me.text_search.TabIndex = 22
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.datagridview_Stock, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1041, 425)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1041, 202)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 202)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1041, 63)
        Me.Panel2.TabIndex = 9
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.40922!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.92891!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33045!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.25456!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BTN_search_equipment, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_delete_Stock, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_insert_Stock, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_edit_Stock, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.text_search, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1041, 63)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 265)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1041, 425)
        Me.Panel3.TabIndex = 10
        '
        'ComboBox_unit
        '
        Me.ComboBox_unit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_unit.BackColor = System.Drawing.Color.White
        Me.ComboBox_unit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_unit.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_unit.FormattingEnabled = True
        Me.ComboBox_unit.Items.AddRange(New Object() {"เครื่อง", "ตัว", "อัน", "ชิ้น"})
        Me.ComboBox_unit.Location = New System.Drawing.Point(647, 158)
        Me.ComboBox_unit.Name = "ComboBox_unit"
        Me.ComboBox_unit.Size = New System.Drawing.Size(333, 29)
        Me.ComboBox_unit.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(583, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 21)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "หน่วย :"
        '
        'BTN_search_equipment
        '
        Me.BTN_search_equipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_search_equipment.BorderRadius = 10
        Me.BTN_search_equipment.CheckedState.Parent = Me.BTN_search_equipment
        Me.BTN_search_equipment.CustomImages.Parent = Me.BTN_search_equipment
        Me.BTN_search_equipment.FillColor = System.Drawing.Color.Teal
        Me.BTN_search_equipment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_search_equipment.ForeColor = System.Drawing.Color.White
        Me.BTN_search_equipment.HoverState.Parent = Me.BTN_search_equipment
        Me.BTN_search_equipment.Image = CType(resources.GetObject("BTN_search_equipment.Image"), System.Drawing.Image)
        Me.BTN_search_equipment.Location = New System.Drawing.Point(835, 11)
        Me.BTN_search_equipment.Name = "BTN_search_equipment"
        Me.BTN_search_equipment.ShadowDecoration.Parent = Me.BTN_search_equipment
        Me.BTN_search_equipment.Size = New System.Drawing.Size(203, 41)
        Me.BTN_search_equipment.TabIndex = 23
        Me.BTN_search_equipment.Text = "ค้นหา"
        '
        'btn_delete_Stock
        '
        Me.btn_delete_Stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete_Stock.BorderRadius = 10
        Me.btn_delete_Stock.CheckedState.Parent = Me.btn_delete_Stock
        Me.btn_delete_Stock.CustomImages.Parent = Me.btn_delete_Stock
        Me.btn_delete_Stock.FillColor = System.Drawing.Color.Crimson
        Me.btn_delete_Stock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_delete_Stock.ForeColor = System.Drawing.Color.Black
        Me.btn_delete_Stock.HoverState.Parent = Me.btn_delete_Stock
        Me.btn_delete_Stock.Image = CType(resources.GetObject("btn_delete_Stock.Image"), System.Drawing.Image)
        Me.btn_delete_Stock.Location = New System.Drawing.Point(298, 9)
        Me.btn_delete_Stock.Name = "btn_delete_Stock"
        Me.btn_delete_Stock.ShadowDecoration.Parent = Me.btn_delete_Stock
        Me.btn_delete_Stock.Size = New System.Drawing.Size(164, 44)
        Me.btn_delete_Stock.TabIndex = 10
        Me.btn_delete_Stock.Text = "ลบอุปกรณ์"
        '
        'btn_insert_Stock
        '
        Me.btn_insert_Stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_insert_Stock.BorderRadius = 10
        Me.btn_insert_Stock.CheckedState.Parent = Me.btn_insert_Stock
        Me.btn_insert_Stock.CustomImages.Parent = Me.btn_insert_Stock
        Me.btn_insert_Stock.FillColor = System.Drawing.Color.LimeGreen
        Me.btn_insert_Stock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_insert_Stock.ForeColor = System.Drawing.Color.Black
        Me.btn_insert_Stock.HoverState.Parent = Me.btn_insert_Stock
        Me.btn_insert_Stock.Image = CType(resources.GetObject("btn_insert_Stock.Image"), System.Drawing.Image)
        Me.btn_insert_Stock.Location = New System.Drawing.Point(3, 10)
        Me.btn_insert_Stock.Name = "btn_insert_Stock"
        Me.btn_insert_Stock.ShadowDecoration.Parent = Me.btn_insert_Stock
        Me.btn_insert_Stock.Size = New System.Drawing.Size(144, 43)
        Me.btn_insert_Stock.TabIndex = 9
        Me.btn_insert_Stock.Text = "เพิ่มอุปกรณ์"
        '
        'btn_edit_Stock
        '
        Me.btn_edit_Stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit_Stock.BorderRadius = 10
        Me.btn_edit_Stock.CheckedState.Parent = Me.btn_edit_Stock
        Me.btn_edit_Stock.CustomImages.Parent = Me.btn_edit_Stock
        Me.btn_edit_Stock.FillColor = System.Drawing.Color.Orange
        Me.btn_edit_Stock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_edit_Stock.ForeColor = System.Drawing.Color.Black
        Me.btn_edit_Stock.HoverState.Parent = Me.btn_edit_Stock
        Me.btn_edit_Stock.Image = CType(resources.GetObject("btn_edit_Stock.Image"), System.Drawing.Image)
        Me.btn_edit_Stock.Location = New System.Drawing.Point(153, 9)
        Me.btn_edit_Stock.Name = "btn_edit_Stock"
        Me.btn_edit_Stock.ShadowDecoration.Parent = Me.btn_edit_Stock
        Me.btn_edit_Stock.Size = New System.Drawing.Size(139, 44)
        Me.btn_edit_Stock.TabIndex = 11
        Me.btn_edit_Stock.Text = "แก้ไขอุปกรณ์"
        '
        'datagridview_Stock
        '
        Me.datagridview_Stock.AllowUserToAddRows = False
        Me.datagridview_Stock.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.datagridview_Stock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridview_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridview_Stock.BackgroundColor = System.Drawing.Color.White
        Me.datagridview_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridview_Stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridview_Stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_Stock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridview_Stock.ColumnHeadersHeight = 41
        Me.datagridview_Stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridview_Stock.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridview_Stock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridview_Stock.EnableHeadersVisualStyles = False
        Me.datagridview_Stock.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridview_Stock.Location = New System.Drawing.Point(23, 3)
        Me.datagridview_Stock.Name = "datagridview_Stock"
        Me.datagridview_Stock.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridview_Stock.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridview_Stock.RowHeadersVisible = False
        Me.datagridview_Stock.RowTemplate.Height = 35
        Me.datagridview_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridview_Stock.Size = New System.Drawing.Size(993, 404)
        Me.datagridview_Stock.TabIndex = 5
        Me.datagridview_Stock.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.datagridview_Stock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridview_Stock.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagridview_Stock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagridview_Stock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagridview_Stock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagridview_Stock.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagridview_Stock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridview_Stock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridview_Stock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridview_Stock.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datagridview_Stock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagridview_Stock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagridview_Stock.ThemeStyle.HeaderStyle.Height = 41
        Me.datagridview_Stock.ThemeStyle.ReadOnly = True
        Me.datagridview_Stock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridview_Stock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridview_Stock.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datagridview_Stock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridview_Stock.ThemeStyle.RowsStyle.Height = 35
        Me.datagridview_Stock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridview_Stock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัส"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่ออุปกรณ์"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "รายละเอียด"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "หมายเหตุ"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "สถานะ"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "ราคา/อุปกรณ์"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "จำนวนคงเหลือ"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "หน่วย"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'manage_equipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1041, 690)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "manage_equipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.datagridview_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txt_Stock_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_insert_Stock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete_Stock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit_Stock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Stock_deteil As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_Stock_remark As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_stock_ID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_Stock_status As ComboBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Stock_price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents text_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_search_equipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ComboBox_unit As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents datagridview_Stock As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
