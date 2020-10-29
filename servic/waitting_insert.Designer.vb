<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class waitting_insert
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(waitting_insert))
        Me.Data_waitting = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox_equipment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Button_save_all = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Date_insert = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TextBox_Stock_unit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_number = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_emp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Check_number = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.Data_waitting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Data_waitting
        '
        Me.Data_waitting.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Data_waitting.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Data_waitting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data_waitting.BackgroundColor = System.Drawing.Color.White
        Me.Data_waitting.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Data_waitting.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Data_waitting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data_waitting.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Data_waitting.ColumnHeadersHeight = 35
        Me.Data_waitting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data_waitting.DefaultCellStyle = DataGridViewCellStyle3
        Me.Data_waitting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Data_waitting.EnableHeadersVisualStyles = False
        Me.Data_waitting.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data_waitting.Location = New System.Drawing.Point(11, 3)
        Me.Data_waitting.Name = "Data_waitting"
        Me.Data_waitting.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.Data_waitting.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Data_waitting.RowTemplate.Height = 35
        Me.Data_waitting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data_waitting.Size = New System.Drawing.Size(995, 322)
        Me.Data_waitting.TabIndex = 7
        Me.Data_waitting.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Data_waitting.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Data_waitting.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Data_waitting.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Data_waitting.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Data_waitting.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Data_waitting.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Data_waitting.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data_waitting.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data_waitting.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Data_waitting.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Data_waitting.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Data_waitting.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Data_waitting.ThemeStyle.HeaderStyle.Height = 35
        Me.Data_waitting.ThemeStyle.ReadOnly = False
        Me.Data_waitting.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Data_waitting.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Data_waitting.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Data_waitting.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Data_waitting.ThemeStyle.RowsStyle.Height = 35
        Me.Data_waitting.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data_waitting.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "เลขใบนำเข้า"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "รหัสสินค้า"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "รายการ"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวน"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "หน่วย"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "ราคา"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "เวลา"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "ผู้ทำรายการ"
        Me.Column8.Name = "Column8"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 47)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(965, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายการนำเข้า"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8780488!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.04878!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.170732!))
        Me.TableLayoutPanel2.Controls.Add(Me.Data_waitting, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1022, 336)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel3.ColumnCount = 9
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.064531!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.84149!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25245!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.13307!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.83953!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.17808!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25245!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35029!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.7804878!))
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBox_equipment, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox_total, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 4, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox_price, 4, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Button_save, 6, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Button_save_all, 7, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 5, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Date_insert, 5, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox_Stock_unit, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox_number, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox_emp, 5, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.4!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.08696!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.2!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1022, 161)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'ComboBox_equipment
        '
        Me.ComboBox_equipment.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox_equipment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox_equipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_equipment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox_equipment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox_equipment.FocusedState.Parent = Me.ComboBox_equipment
        Me.ComboBox_equipment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox_equipment.ForeColor = System.Drawing.Color.Black
        Me.ComboBox_equipment.HoverState.Parent = Me.ComboBox_equipment
        Me.ComboBox_equipment.ItemHeight = 30
        Me.ComboBox_equipment.Items.AddRange(New Object() {"--เลือกอุปกรณ์--"})
        Me.ComboBox_equipment.ItemsAppearance.Parent = Me.ComboBox_equipment
        Me.ComboBox_equipment.Location = New System.Drawing.Point(13, 124)
        Me.ComboBox_equipment.Name = "ComboBox_equipment"
        Me.ComboBox_equipment.ShadowDecoration.Parent = Me.ComboBox_equipment
        Me.ComboBox_equipment.Size = New System.Drawing.Size(207, 36)
        Me.ComboBox_equipment.StartIndex = 0
        Me.ComboBox_equipment.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เลือกรายการนำเข้า"
        '
        'TextBox_total
        '
        Me.TextBox_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_total.DefaultText = ""
        Me.TextBox_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_total.DisabledState.Parent = Me.TextBox_total
        Me.TextBox_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_total.FocusedState.Parent = Me.TextBox_total
        Me.TextBox_total.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox_total.ForeColor = System.Drawing.Color.Black
        Me.TextBox_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_total.HoverState.Parent = Me.TextBox_total
        Me.TextBox_total.Location = New System.Drawing.Point(226, 124)
        Me.TextBox_total.Name = "TextBox_total"
        Me.TextBox_total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_total.PlaceholderText = ""
        Me.TextBox_total.SelectedText = ""
        Me.TextBox_total.ShadowDecoration.Parent = Me.TextBox_total
        Me.TextBox_total.Size = New System.Drawing.Size(109, 34)
        Me.TextBox_total.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "จำนวนนำเข้า"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "หน่วย"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(465, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "ราคา/หน่วย"
        '
        'TextBox_price
        '
        Me.TextBox_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_price.DefaultText = ""
        Me.TextBox_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_price.DisabledState.Parent = Me.TextBox_price
        Me.TextBox_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_price.FocusedState.Parent = Me.TextBox_price
        Me.TextBox_price.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox_price.ForeColor = System.Drawing.Color.Black
        Me.TextBox_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_price.HoverState.Parent = Me.TextBox_price
        Me.TextBox_price.Location = New System.Drawing.Point(465, 124)
        Me.TextBox_price.Name = "TextBox_price"
        Me.TextBox_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_price.PlaceholderText = ""
        Me.TextBox_price.SelectedText = ""
        Me.TextBox_price.ShadowDecoration.Parent = Me.TextBox_price
        Me.TextBox_price.Size = New System.Drawing.Size(115, 34)
        Me.TextBox_price.TabIndex = 26
        '
        'Button_save
        '
        Me.Button_save.BorderRadius = 10
        Me.Button_save.CheckedState.Parent = Me.Button_save
        Me.Button_save.CustomImages.Parent = Me.Button_save
        Me.Button_save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button_save.ForeColor = System.Drawing.Color.White
        Me.Button_save.HoverState.Parent = Me.Button_save
        Me.Button_save.Location = New System.Drawing.Point(782, 124)
        Me.Button_save.Name = "Button_save"
        Me.Button_save.ShadowDecoration.Parent = Me.Button_save
        Me.Button_save.Size = New System.Drawing.Size(109, 34)
        Me.Button_save.TabIndex = 4
        Me.Button_save.Text = "นำเข้า"
        '
        'Button_save_all
        '
        Me.Button_save_all.BorderRadius = 10
        Me.Button_save_all.CheckedState.Parent = Me.Button_save_all
        Me.Button_save_all.CustomImages.Parent = Me.Button_save_all
        Me.Button_save_all.FillColor = System.Drawing.Color.LightCoral
        Me.Button_save_all.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Button_save_all.ForeColor = System.Drawing.Color.White
        Me.Button_save_all.HoverState.Parent = Me.Button_save_all
        Me.Button_save_all.Location = New System.Drawing.Point(897, 124)
        Me.Button_save_all.Name = "Button_save_all"
        Me.Button_save_all.ShadowDecoration.Parent = Me.Button_save_all
        Me.Button_save_all.Size = New System.Drawing.Size(110, 34)
        Me.Button_save_all.TabIndex = 20
        Me.Button_save_all.Text = "บันทึกการนำเข้า"
        Me.Button_save_all.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(586, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "เวลานำเข้า"
        '
        'Date_insert
        '
        Me.Date_insert.CheckedState.Parent = Me.Date_insert
        Me.Date_insert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Date_insert.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date_insert.HoverState.Parent = Me.Date_insert
        Me.Date_insert.Location = New System.Drawing.Point(586, 124)
        Me.Date_insert.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date_insert.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date_insert.Name = "Date_insert"
        Me.Date_insert.ShadowDecoration.Parent = Me.Date_insert
        Me.Date_insert.Size = New System.Drawing.Size(190, 34)
        Me.Date_insert.TabIndex = 32
        Me.Date_insert.Value = New Date(2020, 9, 16, 11, 52, 36, 707)
        '
        'TextBox_Stock_unit
        '
        Me.TextBox_Stock_unit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_Stock_unit.DefaultText = ""
        Me.TextBox_Stock_unit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_Stock_unit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_Stock_unit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_Stock_unit.DisabledState.Parent = Me.TextBox_Stock_unit
        Me.TextBox_Stock_unit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_Stock_unit.Enabled = False
        Me.TextBox_Stock_unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_Stock_unit.FocusedState.Parent = Me.TextBox_Stock_unit
        Me.TextBox_Stock_unit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox_Stock_unit.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Stock_unit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_Stock_unit.HoverState.Parent = Me.TextBox_Stock_unit
        Me.TextBox_Stock_unit.Location = New System.Drawing.Point(341, 124)
        Me.TextBox_Stock_unit.Name = "TextBox_Stock_unit"
        Me.TextBox_Stock_unit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_Stock_unit.PlaceholderText = ""
        Me.TextBox_Stock_unit.SelectedText = ""
        Me.TextBox_Stock_unit.ShadowDecoration.Parent = Me.TextBox_Stock_unit
        Me.TextBox_Stock_unit.Size = New System.Drawing.Size(109, 34)
        Me.TextBox_Stock_unit.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "เลขใบนำเข้า"
        '
        'TextBox_number
        '
        Me.TextBox_number.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_number.DefaultText = ""
        Me.TextBox_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_number.DisabledState.Parent = Me.TextBox_number
        Me.TextBox_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_number.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_number.FocusedState.Parent = Me.TextBox_number
        Me.TextBox_number.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_number.HoverState.Parent = Me.TextBox_number
        Me.TextBox_number.Location = New System.Drawing.Point(13, 36)
        Me.TextBox_number.Name = "TextBox_number"
        Me.TextBox_number.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_number.PlaceholderText = ""
        Me.TextBox_number.SelectedText = ""
        Me.TextBox_number.ShadowDecoration.Parent = Me.TextBox_number
        Me.TextBox_number.Size = New System.Drawing.Size(207, 36)
        Me.TextBox_number.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(509, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "ชื่อผู้นำเข้า"
        Me.Label7.Visible = False
        '
        'TextBox_emp
        '
        Me.TextBox_emp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox_emp.DefaultText = ""
        Me.TextBox_emp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_emp.DisabledState.Parent = Me.TextBox_emp
        Me.TextBox_emp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_emp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_emp.FocusedState.Parent = Me.TextBox_emp
        Me.TextBox_emp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox_emp.ForeColor = System.Drawing.Color.Black
        Me.TextBox_emp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_emp.HoverState.Parent = Me.TextBox_emp
        Me.TextBox_emp.Location = New System.Drawing.Point(586, 36)
        Me.TextBox_emp.Name = "TextBox_emp"
        Me.TextBox_emp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_emp.PlaceholderText = ""
        Me.TextBox_emp.SelectedText = ""
        Me.TextBox_emp.ShadowDecoration.Parent = Me.TextBox_emp
        Me.TextBox_emp.Size = New System.Drawing.Size(109, 31)
        Me.TextBox_emp.TabIndex = 29
        Me.TextBox_emp.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 577)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1022, 29)
        Me.Panel2.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Check_number)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1022, 33)
        Me.Panel3.TabIndex = 20
        '
        'Check_number
        '
        Me.Check_number.AutoSize = True
        Me.Check_number.Checked = True
        Me.Check_number.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check_number.Location = New System.Drawing.Point(12, 10)
        Me.Check_number.Name = "Check_number"
        Me.Check_number.Size = New System.Drawing.Size(127, 17)
        Me.Check_number.TabIndex = 1
        Me.Check_number.Text = "กรอกเลขใบนำเข้าเอง"
        Me.Check_number.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 80)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1022, 161)
        Me.Panel4.TabIndex = 21
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 241)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1022, 336)
        Me.Panel5.TabIndex = 22
        '
        'waitting_insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "waitting_insert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Data_waitting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Data_waitting As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox_equipment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button_save_all As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_number As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox_emp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Date_insert As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox_Stock_unit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Check_number As CheckBox
End Class
