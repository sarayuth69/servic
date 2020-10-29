<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class show_date_cus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(show_date_cus))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_insert_cus = New Guna.UI2.WinForms.Guna2Button()
        Me.search_customer = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_search_cus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.data_customers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.data_customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_insert_cus
        '
        Me.btn_insert_cus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_insert_cus.BorderRadius = 10
        Me.btn_insert_cus.CheckedState.Parent = Me.btn_insert_cus
        Me.btn_insert_cus.CustomImages.Parent = Me.btn_insert_cus
        Me.btn_insert_cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_insert_cus.ForeColor = System.Drawing.Color.Black
        Me.btn_insert_cus.HoverState.Parent = Me.btn_insert_cus
        Me.btn_insert_cus.Image = CType(resources.GetObject("btn_insert_cus.Image"), System.Drawing.Image)
        Me.btn_insert_cus.Location = New System.Drawing.Point(3, 14)
        Me.btn_insert_cus.Name = "btn_insert_cus"
        Me.btn_insert_cus.ShadowDecoration.Parent = Me.btn_insert_cus
        Me.btn_insert_cus.Size = New System.Drawing.Size(132, 50)
        Me.btn_insert_cus.TabIndex = 4
        Me.btn_insert_cus.Text = "เพิ่มลูกค้า"
        '
        'search_customer
        '
        Me.search_customer.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_customer.BorderRadius = 10
        Me.search_customer.CheckedState.Parent = Me.search_customer
        Me.search_customer.CustomImages.Parent = Me.search_customer
        Me.search_customer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.search_customer.ForeColor = System.Drawing.Color.Black
        Me.search_customer.HoverState.Parent = Me.search_customer
        Me.search_customer.Image = CType(resources.GetObject("search_customer.Image"), System.Drawing.Image)
        Me.search_customer.Location = New System.Drawing.Point(1041, 14)
        Me.search_customer.Name = "search_customer"
        Me.search_customer.ShadowDecoration.Parent = Me.search_customer
        Me.search_customer.Size = New System.Drawing.Size(134, 50)
        Me.search_customer.TabIndex = 5
        Me.search_customer.Text = "ค้นหาลูกค้า"
        '
        'txt_search_cus
        '
        Me.txt_search_cus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_cus.BorderColor = System.Drawing.Color.Black
        Me.txt_search_cus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search_cus.DefaultText = ""
        Me.txt_search_cus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search_cus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search_cus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search_cus.DisabledState.Parent = Me.txt_search_cus
        Me.txt_search_cus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search_cus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search_cus.FocusedState.Parent = Me.txt_search_cus
        Me.txt_search_cus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_cus.ForeColor = System.Drawing.Color.Black
        Me.txt_search_cus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search_cus.HoverState.Parent = Me.txt_search_cus
        Me.txt_search_cus.Location = New System.Drawing.Point(667, 22)
        Me.txt_search_cus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_search_cus.Name = "txt_search_cus"
        Me.txt_search_cus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search_cus.PlaceholderText = ""
        Me.txt_search_cus.SelectedText = ""
        Me.txt_search_cus.ShadowDecoration.Parent = Me.txt_search_cus
        Me.txt_search_cus.Size = New System.Drawing.Size(367, 34)
        Me.txt_search_cus.TabIndex = 6
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.data_customers, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9505!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.81013!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.375527!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1184, 711)
        Me.TableLayoutPanel3.TabIndex = 21
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.73242!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.63208!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.90228!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.73321!))
        Me.TableLayoutPanel4.Controls.Add(Me.txt_search_cus, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_insert_cus, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.search_customer, 3, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1178, 78)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'data_customers
        '
        Me.data_customers.AllowUserToAddRows = False
        Me.data_customers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.data_customers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_customers.BackgroundColor = System.Drawing.Color.White
        Me.data_customers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.data_customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_customers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.data_customers.ColumnHeadersHeight = 40
        Me.data_customers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_customers.DefaultCellStyle = DataGridViewCellStyle3
        Me.data_customers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_customers.EnableHeadersVisualStyles = False
        Me.data_customers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_customers.Location = New System.Drawing.Point(3, 87)
        Me.data_customers.Name = "data_customers"
        Me.data_customers.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_customers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.data_customers.RowHeadersVisible = False
        Me.data_customers.RowTemplate.Height = 30
        Me.data_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_customers.Size = New System.Drawing.Size(1178, 596)
        Me.data_customers.TabIndex = 22
        Me.data_customers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.data_customers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.data_customers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.data_customers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.data_customers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.data_customers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.data_customers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.data_customers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_customers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_customers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.data_customers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.data_customers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.data_customers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.data_customers.ThemeStyle.HeaderStyle.Height = 40
        Me.data_customers.ThemeStyle.ReadOnly = True
        Me.data_customers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.data_customers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.data_customers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.data_customers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.data_customers.ThemeStyle.RowsStyle.Height = 30
        Me.data_customers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.data_customers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัส"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "ชื่อลูกค้า"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "ชื่อร้านค้า"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "ที่อยู่"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "เบอร์โทรติดต่อ"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'show_date_cus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "show_date_cus"
        Me.Text = "Form5"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.data_customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_insert_cus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents search_customer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_search_cus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents data_customers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
