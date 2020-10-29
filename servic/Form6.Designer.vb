<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.customer_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_shop = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_tell = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_taxid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cus_details = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_insert_customer = New Guna.UI2.WinForms.Guna2Button()
        Me.cancel_insert = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 39)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(709, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 458)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 42)
        Me.Panel2.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.86667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.86667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.2!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.customer_name, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_address, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_shop, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_tell, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_taxid, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_email, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_details, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_insert_customer, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cancel_insert, 3, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 39)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02387!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.307876!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.546539!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.21718!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.785203!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.73986!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.785203!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.22912!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(750, 419)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "E-mail :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(296, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 32)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "เพิ่มข้อมูลลูกค้า"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 42)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เลขประจำตัวผู้เสียภาษี :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(107, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เบอร์โทร :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ที่อยู่ :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อร้านค้า :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อลูกค้า :"
        '
        'customer_name
        '
        Me.customer_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.customer_name.BorderColor = System.Drawing.Color.Gray
        Me.customer_name.BorderRadius = 5
        Me.customer_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customer_name.DefaultText = ""
        Me.customer_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.customer_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.customer_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_name.DisabledState.Parent = Me.customer_name
        Me.customer_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_name.FocusedState.Parent = Me.customer_name
        Me.customer_name.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.customer_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_name.HoverState.Parent = Me.customer_name
        Me.customer_name.Location = New System.Drawing.Point(241, 55)
        Me.customer_name.Name = "customer_name"
        Me.customer_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.customer_name.PlaceholderText = ""
        Me.customer_name.SelectedText = ""
        Me.customer_name.ShadowDecoration.Parent = Me.customer_name
        Me.customer_name.Size = New System.Drawing.Size(288, 30)
        Me.customer_name.TabIndex = 15
        '
        'cus_address
        '
        Me.cus_address.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cus_address.BorderColor = System.Drawing.Color.Gray
        Me.cus_address.BorderRadius = 5
        Me.cus_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_address.DefaultText = ""
        Me.cus_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_address.DisabledState.Parent = Me.cus_address
        Me.cus_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_address.FocusedState.Parent = Me.cus_address
        Me.cus_address.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_address.HoverState.Parent = Me.cus_address
        Me.cus_address.Location = New System.Drawing.Point(241, 142)
        Me.cus_address.Name = "cus_address"
        Me.cus_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_address.PlaceholderText = ""
        Me.cus_address.SelectedText = ""
        Me.cus_address.ShadowDecoration.Parent = Me.cus_address
        Me.cus_address.Size = New System.Drawing.Size(288, 48)
        Me.cus_address.TabIndex = 16
        '
        'cus_shop
        '
        Me.cus_shop.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cus_shop.BorderColor = System.Drawing.Color.Gray
        Me.cus_shop.BorderRadius = 5
        Me.cus_shop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_shop.DefaultText = ""
        Me.cus_shop.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_shop.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_shop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_shop.DisabledState.Parent = Me.cus_shop
        Me.cus_shop.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_shop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_shop.FocusedState.Parent = Me.cus_shop
        Me.cus_shop.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_shop.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_shop.HoverState.Parent = Me.cus_shop
        Me.cus_shop.Location = New System.Drawing.Point(241, 101)
        Me.cus_shop.Name = "cus_shop"
        Me.cus_shop.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_shop.PlaceholderText = ""
        Me.cus_shop.SelectedText = ""
        Me.cus_shop.ShadowDecoration.Parent = Me.cus_shop
        Me.cus_shop.Size = New System.Drawing.Size(288, 30)
        Me.cus_shop.TabIndex = 17
        '
        'cus_tell
        '
        Me.cus_tell.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cus_tell.BorderColor = System.Drawing.Color.Gray
        Me.cus_tell.BorderRadius = 5
        Me.cus_tell.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_tell.DefaultText = ""
        Me.cus_tell.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_tell.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_tell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_tell.DisabledState.Parent = Me.cus_tell
        Me.cus_tell.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_tell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_tell.FocusedState.Parent = Me.cus_tell
        Me.cus_tell.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_tell.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_tell.HoverState.Parent = Me.cus_tell
        Me.cus_tell.Location = New System.Drawing.Point(241, 201)
        Me.cus_tell.Name = "cus_tell"
        Me.cus_tell.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_tell.PlaceholderText = ""
        Me.cus_tell.SelectedText = ""
        Me.cus_tell.ShadowDecoration.Parent = Me.cus_tell
        Me.cus_tell.Size = New System.Drawing.Size(288, 30)
        Me.cus_tell.TabIndex = 18
        '
        'cus_taxid
        '
        Me.cus_taxid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cus_taxid.BorderColor = System.Drawing.Color.Gray
        Me.cus_taxid.BorderRadius = 5
        Me.cus_taxid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_taxid.DefaultText = ""
        Me.cus_taxid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_taxid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_taxid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_taxid.DisabledState.Parent = Me.cus_taxid
        Me.cus_taxid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_taxid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_taxid.FocusedState.Parent = Me.cus_taxid
        Me.cus_taxid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_taxid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_taxid.HoverState.Parent = Me.cus_taxid
        Me.cus_taxid.Location = New System.Drawing.Point(241, 250)
        Me.cus_taxid.Name = "cus_taxid"
        Me.cus_taxid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_taxid.PlaceholderText = ""
        Me.cus_taxid.SelectedText = ""
        Me.cus_taxid.ShadowDecoration.Parent = Me.cus_taxid
        Me.cus_taxid.Size = New System.Drawing.Size(288, 30)
        Me.cus_taxid.TabIndex = 19
        '
        'cus_email
        '
        Me.cus_email.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cus_email.BorderColor = System.Drawing.Color.Gray
        Me.cus_email.BorderRadius = 5
        Me.cus_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_email.DefaultText = ""
        Me.cus_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_email.DisabledState.Parent = Me.cus_email
        Me.cus_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_email.FocusedState.Parent = Me.cus_email
        Me.cus_email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_email.HoverState.Parent = Me.cus_email
        Me.cus_email.Location = New System.Drawing.Point(241, 299)
        Me.cus_email.Name = "cus_email"
        Me.cus_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_email.PlaceholderText = ""
        Me.cus_email.SelectedText = ""
        Me.cus_email.ShadowDecoration.Parent = Me.cus_email
        Me.cus_email.Size = New System.Drawing.Size(288, 30)
        Me.cus_email.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(107, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 21)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "รายละเอียด :"
        '
        'cus_details
        '
        Me.cus_details.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cus_details.BorderColor = System.Drawing.Color.Gray
        Me.cus_details.BorderRadius = 5
        Me.cus_details.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_details.DefaultText = ""
        Me.cus_details.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_details.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_details.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_details.DisabledState.Parent = Me.cus_details
        Me.cus_details.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_details.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_details.FocusedState.Parent = Me.cus_details
        Me.cus_details.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_details.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_details.HoverState.Parent = Me.cus_details
        Me.cus_details.Location = New System.Drawing.Point(241, 346)
        Me.cus_details.Name = "cus_details"
        Me.cus_details.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_details.PlaceholderText = ""
        Me.cus_details.SelectedText = ""
        Me.cus_details.ShadowDecoration.Parent = Me.cus_details
        Me.cus_details.Size = New System.Drawing.Size(288, 65)
        Me.cus_details.TabIndex = 23
        '
        'btn_insert_customer
        '
        Me.btn_insert_customer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_insert_customer.BorderRadius = 10
        Me.btn_insert_customer.CheckedState.Parent = Me.btn_insert_customer
        Me.btn_insert_customer.CustomImages.Parent = Me.btn_insert_customer
        Me.btn_insert_customer.FillColor = System.Drawing.Color.LimeGreen
        Me.btn_insert_customer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_insert_customer.ForeColor = System.Drawing.Color.Black
        Me.btn_insert_customer.HoverState.Parent = Me.btn_insert_customer
        Me.btn_insert_customer.Image = CType(resources.GetObject("btn_insert_customer.Image"), System.Drawing.Image)
        Me.btn_insert_customer.Location = New System.Drawing.Point(647, 371)
        Me.btn_insert_customer.Name = "btn_insert_customer"
        Me.btn_insert_customer.ShadowDecoration.Parent = Me.btn_insert_customer
        Me.btn_insert_customer.Size = New System.Drawing.Size(100, 45)
        Me.btn_insert_customer.TabIndex = 22
        Me.btn_insert_customer.Text = "บันทึก"
        '
        'cancel_insert
        '
        Me.cancel_insert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancel_insert.BorderRadius = 10
        Me.cancel_insert.CheckedState.Parent = Me.cancel_insert
        Me.cancel_insert.CustomImages.Parent = Me.cancel_insert
        Me.cancel_insert.FillColor = System.Drawing.Color.Crimson
        Me.cancel_insert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancel_insert.ForeColor = System.Drawing.Color.Black
        Me.cancel_insert.HoverState.Parent = Me.cancel_insert
        Me.cancel_insert.Image = CType(resources.GetObject("cancel_insert.Image"), System.Drawing.Image)
        Me.cancel_insert.Location = New System.Drawing.Point(540, 371)
        Me.cancel_insert.Name = "cancel_insert"
        Me.cancel_insert.ShadowDecoration.Parent = Me.cancel_insert
        Me.cancel_insert.Size = New System.Drawing.Size(100, 45)
        Me.cancel_insert.TabIndex = 21
        Me.cancel_insert.Text = "ยกเลิก"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.Text = "เพิ่มลูกค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents customer_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_shop As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_tell As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_taxid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_insert_customer As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancel_insert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cus_details As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
