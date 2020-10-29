<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class take_out
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(take_out))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tableLaout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_stock_deteil = New System.Windows.Forms.TextBox()
        Me.txt_stock_remark = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_select_equipment = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_take_out = New Guna.UI2.WinForms.Guna2Button()
        Me.CB_status = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_list_deteil = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_tell = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_select_cus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cus_shop = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_get_back = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimePicker_send_cus = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox_Number_devices = New System.Windows.Forms.TextBox()
        Me.text_price = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_unit = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_print = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_insert_list = New Guna.UI2.WinForms.Guna2Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.datagridView_take_out = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.List_ID_take_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shop_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipment_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipment_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.List_date_send_customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.List_date_get_back = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.tableLaout.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.datagridView_take_out, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLaout
        '
        Me.tableLaout.BackColor = System.Drawing.Color.White
        Me.tableLaout.ColumnCount = 6
        Me.tableLaout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.313553!))
        Me.tableLaout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.96472!))
        Me.tableLaout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.26331!))
        Me.tableLaout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.60916!))
        Me.tableLaout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.33361!))
        Me.tableLaout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.515638!))
        Me.tableLaout.Controls.Add(Me.Label3, 1, 2)
        Me.tableLaout.Controls.Add(Me.txt_stock_deteil, 2, 2)
        Me.tableLaout.Controls.Add(Me.txt_stock_remark, 4, 2)
        Me.tableLaout.Controls.Add(Me.Label4, 3, 2)
        Me.tableLaout.Controls.Add(Me.CB_select_equipment, 4, 1)
        Me.tableLaout.Controls.Add(Me.Label1, 3, 1)
        Me.tableLaout.Controls.Add(Me.TextBox_ID, 2, 1)
        Me.tableLaout.Controls.Add(Me.Label2, 1, 1)
        Me.tableLaout.Controls.Add(Me.btn_take_out, 3, 9)
        Me.tableLaout.Controls.Add(Me.CB_status, 2, 9)
        Me.tableLaout.Controls.Add(Me.Label5, 1, 9)
        Me.tableLaout.Controls.Add(Me.Label12, 1, 8)
        Me.tableLaout.Controls.Add(Me.txt_list_deteil, 2, 8)
        Me.tableLaout.Controls.Add(Me.Label7, 3, 8)
        Me.tableLaout.Controls.Add(Me.txt_address, 4, 8)
        Me.tableLaout.Controls.Add(Me.txt_email, 4, 7)
        Me.tableLaout.Controls.Add(Me.Label9, 3, 7)
        Me.tableLaout.Controls.Add(Me.txt_tell, 2, 7)
        Me.tableLaout.Controls.Add(Me.Label11, 1, 7)
        Me.tableLaout.Controls.Add(Me.Label6, 1, 6)
        Me.tableLaout.Controls.Add(Me.CB_select_cus, 2, 6)
        Me.tableLaout.Controls.Add(Me.Label10, 3, 6)
        Me.tableLaout.Controls.Add(Me.txt_cus_shop, 4, 6)
        Me.tableLaout.Controls.Add(Me.DateTimePicker_get_back, 4, 5)
        Me.tableLaout.Controls.Add(Me.Label15, 3, 5)
        Me.tableLaout.Controls.Add(Me.DateTimePicker_send_cus, 2, 5)
        Me.tableLaout.Controls.Add(Me.Label16, 1, 5)
        Me.tableLaout.Controls.Add(Me.txt_number, 4, 3)
        Me.tableLaout.Controls.Add(Me.Label13, 3, 3)
        Me.tableLaout.Controls.Add(Me.Label19, 1, 3)
        Me.tableLaout.Controls.Add(Me.TextBox_Number_devices, 2, 3)
        Me.tableLaout.Controls.Add(Me.text_price, 4, 4)
        Me.tableLaout.Controls.Add(Me.Label14, 3, 4)
        Me.tableLaout.Controls.Add(Me.TextBox_unit, 2, 4)
        Me.tableLaout.Controls.Add(Me.Label18, 1, 4)
        Me.tableLaout.Controls.Add(Me.TableLayoutPanel2, 4, 9)
        Me.tableLaout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLaout.Location = New System.Drawing.Point(0, 0)
        Me.tableLaout.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLaout.Name = "tableLaout"
        Me.tableLaout.RowCount = 10
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.310784!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.79834!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.51418!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50334!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.51418!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.79834!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.65085!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.79834!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.20175!))
        Me.tableLaout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.909908!))
        Me.tableLaout.Size = New System.Drawing.Size(1027, 323)
        Me.tableLaout.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "รายละเอียดอุปกรณ์ :"
        '
        'txt_stock_deteil
        '
        Me.txt_stock_deteil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_stock_deteil.Enabled = False
        Me.txt_stock_deteil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_stock_deteil.ForeColor = System.Drawing.Color.Black
        Me.txt_stock_deteil.Location = New System.Drawing.Point(179, 41)
        Me.txt_stock_deteil.Multiline = True
        Me.txt_stock_deteil.Name = "txt_stock_deteil"
        Me.txt_stock_deteil.Size = New System.Drawing.Size(325, 27)
        Me.txt_stock_deteil.TabIndex = 22
        '
        'txt_stock_remark
        '
        Me.txt_stock_remark.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_stock_remark.Enabled = False
        Me.txt_stock_remark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_stock_remark.ForeColor = System.Drawing.Color.Black
        Me.txt_stock_remark.Location = New System.Drawing.Point(680, 41)
        Me.txt_stock_remark.Multiline = True
        Me.txt_stock_remark.Name = "txt_stock_remark"
        Me.txt_stock_remark.Size = New System.Drawing.Size(326, 27)
        Me.txt_stock_remark.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(510, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "หมายเหตุ :"
        '
        'CB_select_equipment
        '
        Me.CB_select_equipment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_select_equipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CB_select_equipment.ForeColor = System.Drawing.Color.Black
        Me.CB_select_equipment.FormattingEnabled = True
        Me.CB_select_equipment.Location = New System.Drawing.Point(680, 7)
        Me.CB_select_equipment.Name = "CB_select_equipment"
        Me.CB_select_equipment.Size = New System.Drawing.Size(326, 28)
        Me.CB_select_equipment.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เลือกอุปกรณ์ :"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_ID.Enabled = False
        Me.TextBox_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_ID.ForeColor = System.Drawing.Color.Black
        Me.TextBox_ID.Location = New System.Drawing.Point(179, 8)
        Me.TextBox_ID.Multiline = True
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(325, 26)
        Me.TextBox_ID.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "เลขใบเบิก :"
        '
        'btn_take_out
        '
        Me.btn_take_out.CheckedState.Parent = Me.btn_take_out
        Me.btn_take_out.CustomImages.Parent = Me.btn_take_out
        Me.btn_take_out.FillColor = System.Drawing.Color.Salmon
        Me.btn_take_out.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_take_out.ForeColor = System.Drawing.Color.Black
        Me.btn_take_out.HoverState.Parent = Me.btn_take_out
        Me.btn_take_out.Image = CType(resources.GetObject("btn_take_out.Image"), System.Drawing.Image)
        Me.btn_take_out.Location = New System.Drawing.Point(510, 288)
        Me.btn_take_out.Name = "btn_take_out"
        Me.btn_take_out.ShadowDecoration.Parent = Me.btn_take_out
        Me.btn_take_out.Size = New System.Drawing.Size(146, 32)
        Me.btn_take_out.TabIndex = 36
        Me.btn_take_out.Text = "เบิก"
        '
        'CB_status
        '
        Me.CB_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CB_status.ForeColor = System.Drawing.Color.Black
        Me.CB_status.FormattingEnabled = True
        Me.CB_status.Items.AddRange(New Object() {"รอส่ง", "ส่งให้ลูกค้าเรียบร้อย", "ลูกค้าส่งกลับมาเรียบร้อย"})
        Me.CB_status.Location = New System.Drawing.Point(179, 290)
        Me.CB_status.Name = "CB_status"
        Me.CB_status.Size = New System.Drawing.Size(325, 28)
        Me.CB_status.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "สถานะ :"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 21)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "รายละเอียดรายการ :"
        '
        'txt_list_deteil
        '
        Me.txt_list_deteil.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_list_deteil.Enabled = False
        Me.txt_list_deteil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_list_deteil.ForeColor = System.Drawing.Color.Black
        Me.txt_list_deteil.Location = New System.Drawing.Point(179, 252)
        Me.txt_list_deteil.Multiline = True
        Me.txt_list_deteil.Name = "txt_list_deteil"
        Me.txt_list_deteil.Size = New System.Drawing.Size(325, 30)
        Me.txt_list_deteil.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(510, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "ที่อยู่ :"
        '
        'txt_address
        '
        Me.txt_address.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_address.Enabled = False
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_address.ForeColor = System.Drawing.Color.Black
        Me.txt_address.Location = New System.Drawing.Point(680, 252)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(326, 30)
        Me.txt_address.TabIndex = 17
        '
        'txt_email
        '
        Me.txt_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_email.Enabled = False
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.Location = New System.Drawing.Point(680, 218)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(326, 28)
        Me.txt_email.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(510, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "E-mail :"
        '
        'txt_tell
        '
        Me.txt_tell.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tell.Enabled = False
        Me.txt_tell.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_tell.ForeColor = System.Drawing.Color.Black
        Me.txt_tell.Location = New System.Drawing.Point(179, 218)
        Me.txt_tell.Multiline = True
        Me.txt_tell.Name = "txt_tell"
        Me.txt_tell.Size = New System.Drawing.Size(325, 28)
        Me.txt_tell.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 21)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "เบอร์โทร :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "เลือกลูกค้า :"
        '
        'CB_select_cus
        '
        Me.CB_select_cus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_select_cus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CB_select_cus.ForeColor = System.Drawing.Color.Black
        Me.CB_select_cus.FormattingEnabled = True
        Me.CB_select_cus.Location = New System.Drawing.Point(179, 182)
        Me.CB_select_cus.Name = "CB_select_cus"
        Me.CB_select_cus.Size = New System.Drawing.Size(325, 28)
        Me.CB_select_cus.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(510, 186)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "ชื่อร้านค้า :"
        '
        'txt_cus_shop
        '
        Me.txt_cus_shop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cus_shop.Enabled = False
        Me.txt_cus_shop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_cus_shop.ForeColor = System.Drawing.Color.Black
        Me.txt_cus_shop.Location = New System.Drawing.Point(680, 183)
        Me.txt_cus_shop.Multiline = True
        Me.txt_cus_shop.Name = "txt_cus_shop"
        Me.txt_cus_shop.Size = New System.Drawing.Size(326, 27)
        Me.txt_cus_shop.TabIndex = 19
        '
        'DateTimePicker_get_back
        '
        Me.DateTimePicker_get_back.CheckedState.Parent = Me.DateTimePicker_get_back
        Me.DateTimePicker_get_back.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker_get_back.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker_get_back.HoverState.Parent = Me.DateTimePicker_get_back
        Me.DateTimePicker_get_back.Location = New System.Drawing.Point(680, 147)
        Me.DateTimePicker_get_back.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker_get_back.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_get_back.Name = "DateTimePicker_get_back"
        Me.DateTimePicker_get_back.ShadowDecoration.Parent = Me.DateTimePicker_get_back
        Me.DateTimePicker_get_back.Size = New System.Drawing.Size(250, 28)
        Me.DateTimePicker_get_back.TabIndex = 32
        Me.DateTimePicker_get_back.Value = New Date(2020, 9, 10, 16, 17, 25, 864)
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(510, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 21)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "วันที่ได้รับกลับมา :"
        '
        'DateTimePicker_send_cus
        '
        Me.DateTimePicker_send_cus.CheckedState.Parent = Me.DateTimePicker_send_cus
        Me.DateTimePicker_send_cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker_send_cus.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker_send_cus.HoverState.Parent = Me.DateTimePicker_send_cus
        Me.DateTimePicker_send_cus.Location = New System.Drawing.Point(179, 147)
        Me.DateTimePicker_send_cus.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker_send_cus.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_send_cus.Name = "DateTimePicker_send_cus"
        Me.DateTimePicker_send_cus.ShadowDecoration.Parent = Me.DateTimePicker_send_cus
        Me.DateTimePicker_send_cus.Size = New System.Drawing.Size(250, 28)
        Me.DateTimePicker_send_cus.TabIndex = 33
        Me.DateTimePicker_send_cus.Value = New Date(2020, 9, 10, 16, 17, 25, 864)
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 21)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "วันที่ส่ง :"
        '
        'txt_number
        '
        Me.txt_number.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_number.ForeColor = System.Drawing.Color.Black
        Me.txt_number.Location = New System.Drawing.Point(680, 76)
        Me.txt_number.Multiline = True
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(326, 30)
        Me.txt_number.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(510, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 21)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "จำนวนเบิก :"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(157, 21)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "จำนวนคงเหลือ :"
        '
        'TextBox_Number_devices
        '
        Me.TextBox_Number_devices.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Number_devices.Enabled = False
        Me.TextBox_Number_devices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_Number_devices.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Number_devices.Location = New System.Drawing.Point(179, 76)
        Me.TextBox_Number_devices.Multiline = True
        Me.TextBox_Number_devices.Name = "TextBox_Number_devices"
        Me.TextBox_Number_devices.Size = New System.Drawing.Size(325, 30)
        Me.TextBox_Number_devices.TabIndex = 40
        '
        'text_price
        '
        Me.text_price.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.text_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.text_price.ForeColor = System.Drawing.Color.Black
        Me.text_price.Location = New System.Drawing.Point(680, 114)
        Me.text_price.Multiline = True
        Me.text_price.Name = "text_price"
        Me.text_price.Size = New System.Drawing.Size(326, 27)
        Me.text_price.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(510, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 21)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "ราคา :"
        '
        'TextBox_unit
        '
        Me.TextBox_unit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_unit.Enabled = False
        Me.TextBox_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_unit.ForeColor = System.Drawing.Color.Black
        Me.TextBox_unit.Location = New System.Drawing.Point(179, 114)
        Me.TextBox_unit.Multiline = True
        Me.TextBox_unit.Name = "TextBox_unit"
        Me.TextBox_unit.Size = New System.Drawing.Size(325, 27)
        Me.TextBox_unit.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 20)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "หน่วย :"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_print, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_insert_list, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(680, 288)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(326, 32)
        Me.TableLayoutPanel2.TabIndex = 46
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_print.CheckedState.Parent = Me.btn_print
        Me.btn_print.CustomImages.Parent = Me.btn_print
        Me.btn_print.FillColor = System.Drawing.Color.LightGreen
        Me.btn_print.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_print.ForeColor = System.Drawing.Color.Black
        Me.btn_print.HoverState.Parent = Me.btn_print
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.Location = New System.Drawing.Point(171, 3)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.ShadowDecoration.Parent = Me.btn_print
        Me.btn_print.Size = New System.Drawing.Size(146, 26)
        Me.btn_print.TabIndex = 30
        Me.btn_print.Text = "ออกรายงาน"
        '
        'btn_insert_list
        '
        Me.btn_insert_list.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.btn_insert_list.CheckedState.Parent = Me.btn_insert_list
        Me.btn_insert_list.CustomImages.Parent = Me.btn_insert_list
        Me.btn_insert_list.FillColor = System.Drawing.Color.LightGreen
        Me.btn_insert_list.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_insert_list.ForeColor = System.Drawing.Color.Black
        Me.btn_insert_list.HoverState.Parent = Me.btn_insert_list
        Me.btn_insert_list.Image = CType(resources.GetObject("btn_insert_list.Image"), System.Drawing.Image)
        Me.btn_insert_list.Location = New System.Drawing.Point(8, 3)
        Me.btn_insert_list.Name = "btn_insert_list"
        Me.btn_insert_list.ShadowDecoration.Parent = Me.btn_insert_list
        Me.btn_insert_list.Size = New System.Drawing.Size(146, 26)
        Me.btn_insert_list.TabIndex = 29
        Me.btn_insert_list.Text = "บันทึก"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.301919!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.39616!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.301919!))
        Me.TableLayoutPanel1.Controls.Add(Me.datagridView_take_out, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1027, 350)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'datagridView_take_out
        '
        Me.datagridView_take_out.AllowUserToAddRows = False
        Me.datagridView_take_out.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.datagridView_take_out.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridView_take_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridView_take_out.BackgroundColor = System.Drawing.Color.White
        Me.datagridView_take_out.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datagridView_take_out.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridView_take_out.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridView_take_out.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridView_take_out.ColumnHeadersHeight = 40
        Me.datagridView_take_out.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.List_ID_take_out, Me.cus_name, Me.Shop_name, Me.equipment_name, Me.total, Me.unit, Me.status, Me.detel, Me.equipment_ID, Me.cus_id, Me.List_date_send_customer, Me.List_date_get_back, Me.remark})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridView_take_out.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridView_take_out.EnableHeadersVisualStyles = False
        Me.datagridView_take_out.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridView_take_out.Location = New System.Drawing.Point(26, 3)
        Me.datagridView_take_out.Name = "datagridView_take_out"
        Me.datagridView_take_out.ReadOnly = True
        Me.datagridView_take_out.RowHeadersVisible = False
        Me.datagridView_take_out.RowTemplate.Height = 30
        Me.datagridView_take_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridView_take_out.Size = New System.Drawing.Size(973, 344)
        Me.datagridView_take_out.TabIndex = 5
        Me.datagridView_take_out.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.datagridView_take_out.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridView_take_out.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagridView_take_out.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagridView_take_out.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagridView_take_out.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagridView_take_out.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagridView_take_out.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridView_take_out.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridView_take_out.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridView_take_out.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datagridView_take_out.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagridView_take_out.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagridView_take_out.ThemeStyle.HeaderStyle.Height = 40
        Me.datagridView_take_out.ThemeStyle.ReadOnly = True
        Me.datagridView_take_out.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridView_take_out.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridView_take_out.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.datagridView_take_out.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridView_take_out.ThemeStyle.RowsStyle.Height = 30
        Me.datagridView_take_out.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridView_take_out.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'List_ID_take_out
        '
        Me.List_ID_take_out.HeaderText = "รหัส"
        Me.List_ID_take_out.Name = "List_ID_take_out"
        Me.List_ID_take_out.ReadOnly = True
        Me.List_ID_take_out.Visible = False
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "ชื่อลูกค้า"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.ReadOnly = True
        '
        'Shop_name
        '
        Me.Shop_name.HeaderText = "ร้านค้า"
        Me.Shop_name.Name = "Shop_name"
        Me.Shop_name.ReadOnly = True
        '
        'equipment_name
        '
        Me.equipment_name.HeaderText = "ชื่ออุปกรณ์"
        Me.equipment_name.Name = "equipment_name"
        Me.equipment_name.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "จำนวน"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'unit
        '
        Me.unit.HeaderText = "หน่วย"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'detel
        '
        Me.detel.HeaderText = "รายละเอียด"
        Me.detel.Name = "detel"
        Me.detel.ReadOnly = True
        '
        'equipment_ID
        '
        Me.equipment_ID.HeaderText = "รหัสอุปกรณ์"
        Me.equipment_ID.Name = "equipment_ID"
        Me.equipment_ID.ReadOnly = True
        Me.equipment_ID.Visible = False
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.ReadOnly = True
        Me.cus_id.Visible = False
        '
        'List_date_send_customer
        '
        Me.List_date_send_customer.HeaderText = "วันที่ส่ง"
        Me.List_date_send_customer.Name = "List_date_send_customer"
        Me.List_date_send_customer.ReadOnly = True
        '
        'List_date_get_back
        '
        Me.List_date_get_back.HeaderText = "วันที่รับกลับมา"
        Me.List_date_get_back.Name = "List_date_get_back"
        Me.List_date_get_back.ReadOnly = True
        '
        'remark
        '
        Me.remark.HeaderText = "หมายเหตุ"
        Me.remark.Name = "remark"
        Me.remark.ReadOnly = True
        Me.remark.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 713)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 40)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1027, 40)
        Me.Panel2.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Label8"
        Me.Label8.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(967, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(58, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 30)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "เบิกอุปกรณ์"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 363)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1027, 350)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tableLaout)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1027, 323)
        Me.Panel4.TabIndex = 12
        '
        'take_out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1027, 753)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "take_out"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form11"
        Me.tableLaout.ResumeLayout(False)
        Me.tableLaout.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.datagridView_take_out, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tableLaout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_select_equipment As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_stock_remark As TextBox
    Friend WithEvents txt_stock_deteil As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_tell As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents CB_select_cus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_list_deteil As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cus_shop As TextBox
    Friend WithEvents txt_number As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents text_price As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents DateTimePicker_get_back As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DateTimePicker_send_cus As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_status As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_take_out As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox_Number_devices As TextBox
    Friend WithEvents TextBox_unit As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_print As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_insert_list As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents datagridView_take_out As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents List_ID_take_out As DataGridViewTextBoxColumn
    Friend WithEvents cus_name As DataGridViewTextBoxColumn
    Friend WithEvents Shop_name As DataGridViewTextBoxColumn
    Friend WithEvents equipment_name As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents detel As DataGridViewTextBoxColumn
    Friend WithEvents equipment_ID As DataGridViewTextBoxColumn
    Friend WithEvents cus_id As DataGridViewTextBoxColumn
    Friend WithEvents List_date_send_customer As DataGridViewTextBoxColumn
    Friend WithEvents List_date_get_back As DataGridViewTextBoxColumn
    Friend WithEvents remark As DataGridViewTextBoxColumn
End Class
