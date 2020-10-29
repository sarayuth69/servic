<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.panalbackground = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Maximize = New System.Windows.Forms.PictureBox()
        Me.PB_Close = New System.Windows.Forms.PictureBox()
        Me.restore_Dow = New System.Windows.Forms.PictureBox()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_data_cus = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_list = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnmanagement = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Stock = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_insert_equipment = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panalbackground.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restore_Dow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'panalbackground
        '
        Me.panalbackground.Controls.Add(Me.Panel5)
        Me.panalbackground.Controls.Add(Me.Panel1)
        Me.Guna2Transition1.SetDecoration(Me.panalbackground, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.panalbackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panalbackground.Font = New System.Drawing.Font("Cordia New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.panalbackground.Location = New System.Drawing.Point(142, 51)
        Me.panalbackground.Name = "panalbackground"
        Me.panalbackground.Size = New System.Drawing.Size(1142, 610)
        Me.panalbackground.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Panel5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 575)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1142, 35)
        Me.Panel5.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1142, 40)
        Me.Panel1.TabIndex = 5
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        Me.Guna2Transition1.TimeStep = 1.0!
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(619, 36)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "โมดูลแจ้งซ่อมอุปกรณ์ของลูกค้าและโมดูลจัดการเครื่องสำรองให้ลูกค้า"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Maximize)
        Me.Panel3.Controls.Add(Me.PB_Close)
        Me.Panel3.Controls.Add(Me.restore_Dow)
        Me.Panel3.Controls.Add(Me.minimize)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Guna2Transition1.SetDecoration(Me.Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1284, 51)
        Me.Panel3.TabIndex = 8
        '
        'Maximize
        '
        Me.Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.Maximize, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Maximize.Image = CType(resources.GetObject("Maximize.Image"), System.Drawing.Image)
        Me.Maximize.Location = New System.Drawing.Point(1176, 8)
        Me.Maximize.Name = "Maximize"
        Me.Maximize.Size = New System.Drawing.Size(45, 40)
        Me.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Maximize.TabIndex = 16
        Me.Maximize.TabStop = False
        '
        'PB_Close
        '
        Me.PB_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.PB_Close, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PB_Close.Image = CType(resources.GetObject("PB_Close.Image"), System.Drawing.Image)
        Me.PB_Close.Location = New System.Drawing.Point(1227, 8)
        Me.PB_Close.Name = "PB_Close"
        Me.PB_Close.Size = New System.Drawing.Size(45, 40)
        Me.PB_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Close.TabIndex = 17
        Me.PB_Close.TabStop = False
        '
        'restore_Dow
        '
        Me.restore_Dow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.restore_Dow, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.restore_Dow.Image = CType(resources.GetObject("restore_Dow.Image"), System.Drawing.Image)
        Me.restore_Dow.Location = New System.Drawing.Point(1176, 8)
        Me.restore_Dow.Name = "restore_Dow"
        Me.restore_Dow.Size = New System.Drawing.Size(45, 40)
        Me.restore_Dow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.restore_Dow.TabIndex = 15
        Me.restore_Dow.TabStop = False
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.minimize, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.minimize.Image = CType(resources.GetObject("minimize.Image"), System.Drawing.Image)
        Me.minimize.Location = New System.Drawing.Point(1125, 8)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(45, 40)
        Me.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimize.TabIndex = 14
        Me.minimize.TabStop = False
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Transition1.SetDecoration(Me.Panel4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(0, 128)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(13, 40)
        Me.Panel4.TabIndex = 9
        '
        'btn_data_cus
        '
        Me.btn_data_cus.BackColor = System.Drawing.SystemColors.Control
        Me.btn_data_cus.BorderColor = System.Drawing.Color.White
        Me.btn_data_cus.CheckedState.Parent = Me.btn_data_cus
        Me.btn_data_cus.CustomImages.Parent = Me.btn_data_cus
        Me.Guna2Transition1.SetDecoration(Me.btn_data_cus, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_data_cus.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_data_cus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_data_cus.ForeColor = System.Drawing.Color.White
        Me.btn_data_cus.HoverState.Parent = Me.btn_data_cus
        Me.btn_data_cus.Image = CType(resources.GetObject("btn_data_cus.Image"), System.Drawing.Image)
        Me.btn_data_cus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_data_cus.Location = New System.Drawing.Point(12, 128)
        Me.btn_data_cus.Name = "btn_data_cus"
        Me.btn_data_cus.PressedColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_data_cus.ShadowDecoration.Parent = Me.btn_data_cus
        Me.btn_data_cus.Size = New System.Drawing.Size(130, 40)
        Me.btn_data_cus.TabIndex = 1
        Me.btn_data_cus.Text = "ข้อมูลลูกค้า"
        Me.btn_data_cus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_list
        '
        Me.btn_list.BackColor = System.Drawing.SystemColors.Control
        Me.btn_list.BorderColor = System.Drawing.Color.White
        Me.btn_list.CheckedState.Parent = Me.btn_list
        Me.btn_list.CustomImages.Parent = Me.btn_list
        Me.Guna2Transition1.SetDecoration(Me.btn_list, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_list.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_list.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_list.ForeColor = System.Drawing.Color.White
        Me.btn_list.HoverState.Parent = Me.btn_list
        Me.btn_list.Image = CType(resources.GetObject("btn_list.Image"), System.Drawing.Image)
        Me.btn_list.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_list.Location = New System.Drawing.Point(13, 266)
        Me.btn_list.Name = "btn_list"
        Me.btn_list.PressedColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_list.ShadowDecoration.Parent = Me.btn_list
        Me.btn_list.Size = New System.Drawing.Size(130, 40)
        Me.btn_list.TabIndex = 2
        Me.btn_list.Text = "รายการเบิก"
        Me.btn_list.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnlogout
        '
        Me.btnlogout.BackColor = System.Drawing.SystemColors.Control
        Me.btnlogout.BorderColor = System.Drawing.Color.White
        Me.btnlogout.CheckedState.Parent = Me.btnlogout
        Me.btnlogout.CustomImages.Parent = Me.btnlogout
        Me.Guna2Transition1.SetDecoration(Me.btnlogout, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnlogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.HoverState.Parent = Me.btnlogout
        Me.btnlogout.Image = CType(resources.GetObject("btnlogout.Image"), System.Drawing.Image)
        Me.btnlogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnlogout.Location = New System.Drawing.Point(12, 474)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.PressedColor = System.Drawing.Color.MediumSpringGreen
        Me.btnlogout.ShadowDecoration.Parent = Me.btnlogout
        Me.btnlogout.Size = New System.Drawing.Size(130, 40)
        Me.btnlogout.TabIndex = 10
        Me.btnlogout.Text = "ออกจากระบบ"
        Me.btnlogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnmanagement
        '
        Me.btnmanagement.BackColor = System.Drawing.SystemColors.Control
        Me.btnmanagement.BorderColor = System.Drawing.Color.White
        Me.btnmanagement.CheckedState.Parent = Me.btnmanagement
        Me.btnmanagement.CustomImages.Parent = Me.btnmanagement
        Me.Guna2Transition1.SetDecoration(Me.btnmanagement, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnmanagement.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btnmanagement.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnmanagement.ForeColor = System.Drawing.Color.White
        Me.btnmanagement.HoverState.Parent = Me.btnmanagement
        Me.btnmanagement.Image = CType(resources.GetObject("btnmanagement.Image"), System.Drawing.Image)
        Me.btnmanagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnmanagement.Location = New System.Drawing.Point(13, 175)
        Me.btnmanagement.Name = "btnmanagement"
        Me.btnmanagement.PressedColor = System.Drawing.Color.MediumSpringGreen
        Me.btnmanagement.ShadowDecoration.Parent = Me.btnmanagement
        Me.btnmanagement.Size = New System.Drawing.Size(130, 40)
        Me.btnmanagement.TabIndex = 12
        Me.btnmanagement.Text = "แจ้งซ่อม"
        Me.btnmanagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_Stock
        '
        Me.btn_Stock.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Stock.BorderColor = System.Drawing.Color.White
        Me.btn_Stock.CheckedState.Parent = Me.btn_Stock
        Me.btn_Stock.CustomImages.Parent = Me.btn_Stock
        Me.Guna2Transition1.SetDecoration(Me.btn_Stock, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_Stock.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_Stock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Stock.ForeColor = System.Drawing.Color.White
        Me.btn_Stock.HoverState.Parent = Me.btn_Stock
        Me.btn_Stock.Image = CType(resources.GetObject("btn_Stock.Image"), System.Drawing.Image)
        Me.btn_Stock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_Stock.Location = New System.Drawing.Point(13, 312)
        Me.btn_Stock.Name = "btn_Stock"
        Me.btn_Stock.PressedColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_Stock.ShadowDecoration.Parent = Me.btn_Stock
        Me.btn_Stock.Size = New System.Drawing.Size(130, 40)
        Me.btn_Stock.TabIndex = 13
        Me.btn_Stock.Text = "อุปกรณ์"
        Me.btn_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.FillColor = System.Drawing.Color.Silver
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(-2, 220)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(142, 40)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "สำรองเครื่อง"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button2.FillColor = System.Drawing.Color.Silver
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(-2, 82)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(142, 40)
        Me.Guna2Button2.TabIndex = 14
        Me.Guna2Button2.Text = "แจ้งซ่อม"
        '
        'btn_insert_equipment
        '
        Me.btn_insert_equipment.BackColor = System.Drawing.SystemColors.Control
        Me.btn_insert_equipment.BorderColor = System.Drawing.Color.White
        Me.btn_insert_equipment.CheckedState.Parent = Me.btn_insert_equipment
        Me.btn_insert_equipment.CustomImages.Parent = Me.btn_insert_equipment
        Me.Guna2Transition1.SetDecoration(Me.btn_insert_equipment, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_insert_equipment.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_insert_equipment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_insert_equipment.ForeColor = System.Drawing.Color.White
        Me.btn_insert_equipment.HoverState.Parent = Me.btn_insert_equipment
        Me.btn_insert_equipment.Image = CType(resources.GetObject("btn_insert_equipment.Image"), System.Drawing.Image)
        Me.btn_insert_equipment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_insert_equipment.Location = New System.Drawing.Point(13, 358)
        Me.btn_insert_equipment.Name = "btn_insert_equipment"
        Me.btn_insert_equipment.PressedColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_insert_equipment.ShadowDecoration.Parent = Me.btn_insert_equipment
        Me.btn_insert_equipment.Size = New System.Drawing.Size(130, 40)
        Me.btn_insert_equipment.TabIndex = 15
        Me.btn_insert_equipment.Text = "นำเข้าอุปกรณ์"
        Me.btn_insert_equipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Guna2Transition1.SetDecoration(Me.Panel6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(1, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(142, 75)
        Me.Panel6.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(6, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(5, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "เพศ :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(37, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ชื่อ :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(53, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เพศ :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.btn_insert_equipment)
        Me.Panel2.Controls.Add(Me.Guna2Button2)
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Controls.Add(Me.btn_Stock)
        Me.Panel2.Controls.Add(Me.btnmanagement)
        Me.Panel2.Controls.Add(Me.btnlogout)
        Me.Panel2.Controls.Add(Me.btn_list)
        Me.Panel2.Controls.Add(Me.btn_data_cus)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Guna2Transition1.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(142, 610)
        Me.Panel2.TabIndex = 7
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.panalbackground)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.panalbackground.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restore_Dow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panalbackground As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PB_Close As PictureBox
    Friend WithEvents Maximize As PictureBox
    Friend WithEvents restore_Dow As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_insert_equipment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Stock As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnmanagement As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_list As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_data_cus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
End Class
