<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.customer_name_edit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_address_edit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_shop_edit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_tell_edit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_taxid_edit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_email_edit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cus_details_edit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_delect_cus = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit_cus = New Guna.UI2.WinForms.Guna2Button()
        Me.cus_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 313)
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
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label7.Location = New System.Drawing.Point(299, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 32)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "แก้ไขข้อมูลลูกค้า"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "เลขประจำตัวผู้เสียภาษี :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 211)
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
        Me.Label3.Location = New System.Drawing.Point(24, 160)
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
        Me.Label2.Location = New System.Drawing.Point(24, 109)
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
        Me.Label1.Location = New System.Drawing.Point(24, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อลูกค้า :"
        '
        'customer_name_edit
        '
        Me.customer_name_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.customer_name_edit.BackColor = System.Drawing.Color.White
        Me.customer_name_edit.BorderColor = System.Drawing.Color.Gray
        Me.customer_name_edit.BorderRadius = 5
        Me.customer_name_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.customer_name_edit.DefaultText = ""
        Me.customer_name_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.customer_name_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.customer_name_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_name_edit.DisabledState.Parent = Me.customer_name_edit
        Me.customer_name_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.customer_name_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_name_edit.FocusedState.Parent = Me.customer_name_edit
        Me.customer_name_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.customer_name_edit.ForeColor = System.Drawing.Color.Black
        Me.customer_name_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.customer_name_edit.HoverState.Parent = Me.customer_name_edit
        Me.customer_name_edit.Location = New System.Drawing.Point(224, 61)
        Me.customer_name_edit.Name = "customer_name_edit"
        Me.customer_name_edit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.customer_name_edit.PlaceholderText = ""
        Me.customer_name_edit.SelectedText = ""
        Me.customer_name_edit.ShadowDecoration.Parent = Me.customer_name_edit
        Me.customer_name_edit.Size = New System.Drawing.Size(300, 30)
        Me.customer_name_edit.TabIndex = 15
        '
        'cus_address_edit
        '
        Me.cus_address_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cus_address_edit.BackColor = System.Drawing.Color.White
        Me.cus_address_edit.BorderColor = System.Drawing.Color.Gray
        Me.cus_address_edit.BorderRadius = 5
        Me.cus_address_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_address_edit.DefaultText = ""
        Me.cus_address_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_address_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_address_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_address_edit.DisabledState.Parent = Me.cus_address_edit
        Me.cus_address_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_address_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_address_edit.FocusedState.Parent = Me.cus_address_edit
        Me.cus_address_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_address_edit.ForeColor = System.Drawing.Color.Black
        Me.cus_address_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_address_edit.HoverState.Parent = Me.cus_address_edit
        Me.cus_address_edit.Location = New System.Drawing.Point(224, 163)
        Me.cus_address_edit.Name = "cus_address_edit"
        Me.cus_address_edit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_address_edit.PlaceholderText = ""
        Me.cus_address_edit.SelectedText = ""
        Me.cus_address_edit.ShadowDecoration.Parent = Me.cus_address_edit
        Me.cus_address_edit.Size = New System.Drawing.Size(300, 30)
        Me.cus_address_edit.TabIndex = 16
        '
        'cus_shop_edit
        '
        Me.cus_shop_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cus_shop_edit.BackColor = System.Drawing.Color.White
        Me.cus_shop_edit.BorderColor = System.Drawing.Color.Gray
        Me.cus_shop_edit.BorderRadius = 5
        Me.cus_shop_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_shop_edit.DefaultText = ""
        Me.cus_shop_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_shop_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_shop_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_shop_edit.DisabledState.Parent = Me.cus_shop_edit
        Me.cus_shop_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_shop_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_shop_edit.FocusedState.Parent = Me.cus_shop_edit
        Me.cus_shop_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_shop_edit.ForeColor = System.Drawing.Color.Black
        Me.cus_shop_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_shop_edit.HoverState.Parent = Me.cus_shop_edit
        Me.cus_shop_edit.Location = New System.Drawing.Point(224, 112)
        Me.cus_shop_edit.Name = "cus_shop_edit"
        Me.cus_shop_edit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_shop_edit.PlaceholderText = ""
        Me.cus_shop_edit.SelectedText = ""
        Me.cus_shop_edit.ShadowDecoration.Parent = Me.cus_shop_edit
        Me.cus_shop_edit.Size = New System.Drawing.Size(300, 30)
        Me.cus_shop_edit.TabIndex = 17
        '
        'cus_tell_edit
        '
        Me.cus_tell_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cus_tell_edit.BackColor = System.Drawing.Color.White
        Me.cus_tell_edit.BorderColor = System.Drawing.Color.Gray
        Me.cus_tell_edit.BorderRadius = 5
        Me.cus_tell_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_tell_edit.DefaultText = ""
        Me.cus_tell_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_tell_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_tell_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_tell_edit.DisabledState.Parent = Me.cus_tell_edit
        Me.cus_tell_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_tell_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_tell_edit.FocusedState.Parent = Me.cus_tell_edit
        Me.cus_tell_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_tell_edit.ForeColor = System.Drawing.Color.Black
        Me.cus_tell_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_tell_edit.HoverState.Parent = Me.cus_tell_edit
        Me.cus_tell_edit.Location = New System.Drawing.Point(224, 214)
        Me.cus_tell_edit.Name = "cus_tell_edit"
        Me.cus_tell_edit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_tell_edit.PlaceholderText = ""
        Me.cus_tell_edit.SelectedText = ""
        Me.cus_tell_edit.ShadowDecoration.Parent = Me.cus_tell_edit
        Me.cus_tell_edit.Size = New System.Drawing.Size(300, 30)
        Me.cus_tell_edit.TabIndex = 18
        '
        'cus_taxid_edit
        '
        Me.cus_taxid_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cus_taxid_edit.BackColor = System.Drawing.Color.White
        Me.cus_taxid_edit.BorderColor = System.Drawing.Color.Gray
        Me.cus_taxid_edit.BorderRadius = 5
        Me.cus_taxid_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_taxid_edit.DefaultText = ""
        Me.cus_taxid_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_taxid_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_taxid_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_taxid_edit.DisabledState.Parent = Me.cus_taxid_edit
        Me.cus_taxid_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_taxid_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_taxid_edit.FocusedState.Parent = Me.cus_taxid_edit
        Me.cus_taxid_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_taxid_edit.ForeColor = System.Drawing.Color.Black
        Me.cus_taxid_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_taxid_edit.HoverState.Parent = Me.cus_taxid_edit
        Me.cus_taxid_edit.Location = New System.Drawing.Point(224, 265)
        Me.cus_taxid_edit.Name = "cus_taxid_edit"
        Me.cus_taxid_edit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_taxid_edit.PlaceholderText = ""
        Me.cus_taxid_edit.SelectedText = ""
        Me.cus_taxid_edit.ShadowDecoration.Parent = Me.cus_taxid_edit
        Me.cus_taxid_edit.Size = New System.Drawing.Size(300, 30)
        Me.cus_taxid_edit.TabIndex = 19
        '
        'cus_email_edit
        '
        Me.cus_email_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cus_email_edit.BackColor = System.Drawing.Color.White
        Me.cus_email_edit.BorderColor = System.Drawing.Color.Gray
        Me.cus_email_edit.BorderRadius = 5
        Me.cus_email_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_email_edit.DefaultText = ""
        Me.cus_email_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_email_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_email_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_email_edit.DisabledState.Parent = Me.cus_email_edit
        Me.cus_email_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_email_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_email_edit.FocusedState.Parent = Me.cus_email_edit
        Me.cus_email_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_email_edit.ForeColor = System.Drawing.Color.Black
        Me.cus_email_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_email_edit.HoverState.Parent = Me.cus_email_edit
        Me.cus_email_edit.Location = New System.Drawing.Point(224, 316)
        Me.cus_email_edit.Name = "cus_email_edit"
        Me.cus_email_edit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_email_edit.PlaceholderText = ""
        Me.cus_email_edit.SelectedText = ""
        Me.cus_email_edit.ShadowDecoration.Parent = Me.cus_email_edit
        Me.cus_email_edit.Size = New System.Drawing.Size(300, 30)
        Me.cus_email_edit.TabIndex = 20
        '
        'cus_details_edit
        '
        Me.cus_details_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cus_details_edit.BackColor = System.Drawing.Color.White
        Me.cus_details_edit.BorderColor = System.Drawing.Color.Gray
        Me.cus_details_edit.BorderRadius = 5
        Me.cus_details_edit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_details_edit.DefaultText = ""
        Me.cus_details_edit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_details_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_details_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_details_edit.DisabledState.Parent = Me.cus_details_edit
        Me.cus_details_edit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_details_edit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_details_edit.FocusedState.Parent = Me.cus_details_edit
        Me.cus_details_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_details_edit.ForeColor = System.Drawing.Color.Black
        Me.cus_details_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_details_edit.HoverState.Parent = Me.cus_details_edit
        Me.cus_details_edit.Location = New System.Drawing.Point(224, 374)
        Me.cus_details_edit.Name = "cus_details_edit"
        Me.cus_details_edit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_details_edit.PlaceholderText = ""
        Me.cus_details_edit.SelectedText = ""
        Me.cus_details_edit.ShadowDecoration.Parent = Me.cus_details_edit
        Me.cus_details_edit.Size = New System.Drawing.Size(300, 30)
        Me.cus_details_edit.TabIndex = 23
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.803738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.70227!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.72897!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.53333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.333333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.customer_name_edit, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_address_edit, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_shop_edit, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_tell_edit, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_taxid_edit, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_email_edit, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_details_edit, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cus_id, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delect_cus, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_edit_cus, 3, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.74852!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.75021!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(750, 407)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 21)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "รายละเอียด :"
        '
        'btn_delect_cus
        '
        Me.btn_delect_cus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delect_cus.BorderRadius = 10
        Me.btn_delect_cus.CheckedState.Parent = Me.btn_delect_cus
        Me.btn_delect_cus.CustomImages.Parent = Me.btn_delect_cus
        Me.btn_delect_cus.FillColor = System.Drawing.Color.Crimson
        Me.btn_delect_cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_delect_cus.ForeColor = System.Drawing.Color.Black
        Me.btn_delect_cus.HoverState.Parent = Me.btn_delect_cus
        Me.btn_delect_cus.Image = CType(resources.GetObject("btn_delect_cus.Image"), System.Drawing.Image)
        Me.btn_delect_cus.Location = New System.Drawing.Point(576, 361)
        Me.btn_delect_cus.Name = "btn_delect_cus"
        Me.btn_delect_cus.ShadowDecoration.Parent = Me.btn_delect_cus
        Me.btn_delect_cus.Size = New System.Drawing.Size(100, 43)
        Me.btn_delect_cus.TabIndex = 21
        Me.btn_delect_cus.Text = "ลบ"
        '
        'btn_edit_cus
        '
        Me.btn_edit_cus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit_cus.BorderRadius = 10
        Me.btn_edit_cus.CheckedState.Parent = Me.btn_edit_cus
        Me.btn_edit_cus.CustomImages.Parent = Me.btn_edit_cus
        Me.btn_edit_cus.FillColor = System.Drawing.Color.LimeGreen
        Me.btn_edit_cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_edit_cus.ForeColor = System.Drawing.Color.Black
        Me.btn_edit_cus.HoverState.Parent = Me.btn_edit_cus
        Me.btn_edit_cus.Image = CType(resources.GetObject("btn_edit_cus.Image"), System.Drawing.Image)
        Me.btn_edit_cus.Location = New System.Drawing.Point(576, 301)
        Me.btn_edit_cus.Name = "btn_edit_cus"
        Me.btn_edit_cus.ShadowDecoration.Parent = Me.btn_edit_cus
        Me.btn_edit_cus.Size = New System.Drawing.Size(100, 45)
        Me.btn_edit_cus.TabIndex = 22
        Me.btn_edit_cus.Text = "บันทึก"
        '
        'cus_id
        '
        Me.cus_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cus_id.BorderRadius = 5
        Me.cus_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cus_id.DefaultText = ""
        Me.cus_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cus_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cus_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_id.DisabledState.Parent = Me.cus_id
        Me.cus_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cus_id.Enabled = False
        Me.cus_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_id.FocusedState.Parent = Me.cus_id
        Me.cus_id.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cus_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cus_id.HoverState.Parent = Me.cus_id
        Me.cus_id.Location = New System.Drawing.Point(682, 61)
        Me.cus_id.Name = "cus_id"
        Me.cus_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cus_id.PlaceholderText = ""
        Me.cus_id.SelectedText = ""
        Me.cus_id.ShadowDecoration.Parent = Me.cus_id
        Me.cus_id.Size = New System.Drawing.Size(65, 30)
        Me.cus_id.TabIndex = 26
        Me.cus_id.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(590, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "รหัสลูกค้า :"
        Me.Label9.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 452)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 48)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 45)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(706, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents customer_name_edit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_address_edit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_shop_edit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_tell_edit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_taxid_edit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cus_email_edit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_delect_cus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit_cus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cus_details_edit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cus_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
