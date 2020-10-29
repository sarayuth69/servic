<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Panal_Login = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox_password_login = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBox_username_login = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_login = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panal_Register = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.TextBox_tell = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBox_card_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.ComBoBox_sex = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBox_Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_create_account = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panal_Login.SuspendLayout()
        Me.Panal_Register.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(839, 34)
        Me.Guna2Panel1.TabIndex = 9
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(731, 3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(782, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
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
        'Panal_Login
        '
        Me.Panal_Login.BackColor = System.Drawing.Color.DimGray
        Me.Panal_Login.Controls.Add(Me.Button1)
        Me.Panal_Login.Controls.Add(Me.Guna2Button1)
        Me.Panal_Login.Controls.Add(Me.TextBox_password_login)
        Me.Panal_Login.Controls.Add(Me.TextBox_username_login)
        Me.Panal_Login.Controls.Add(Me.Label3)
        Me.Panal_Login.Controls.Add(Me.Guna2ToggleSwitch1)
        Me.Panal_Login.Controls.Add(Me.Label1)
        Me.Panal_Login.Controls.Add(Me.Button_login)
        Me.Panal_Login.Controls.Add(Me.Label2)
        Me.Guna2Transition1.SetDecoration(Me.Panal_Login, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panal_Login.FillColor = System.Drawing.Color.Black
        Me.Panal_Login.ForeColor = System.Drawing.Color.White
        Me.Panal_Login.Location = New System.Drawing.Point(271, 40)
        Me.Panal_Login.Name = "Panal_Login"
        Me.Panal_Login.ShadowColor = System.Drawing.Color.Black
        Me.Panal_Login.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Panal_Login.Size = New System.Drawing.Size(303, 514)
        Me.Panal_Login.TabIndex = 22
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Black
        Me.Guna2Button1.BorderColor = System.Drawing.Color.White
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button1.FillColor = System.Drawing.Color.Black
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button1.Location = New System.Drawing.Point(28, 363)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(251, 45)
        Me.Guna2Button1.TabIndex = 7
        Me.Guna2Button1.Text = "Create Account"
        '
        'TextBox_password_login
        '
        Me.TextBox_password_login.Animated = True
        Me.TextBox_password_login.BackColor = System.Drawing.Color.Black
        Me.TextBox_password_login.BorderRadius = 8
        Me.TextBox_password_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TextBox_password_login, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox_password_login.DefaultText = ""
        Me.TextBox_password_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_password_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_password_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_password_login.DisabledState.Parent = Me.TextBox_password_login
        Me.TextBox_password_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_password_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_password_login.FocusedState.Parent = Me.TextBox_password_login
        Me.TextBox_password_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_password_login.ForeColor = System.Drawing.Color.Black
        Me.TextBox_password_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_password_login.HoverState.Parent = Me.TextBox_password_login
        Me.TextBox_password_login.IconLeft = CType(resources.GetObject("TextBox_password_login.IconLeft"), System.Drawing.Image)
        Me.TextBox_password_login.Location = New System.Drawing.Point(27, 143)
        Me.TextBox_password_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_password_login.Name = "TextBox_password_login"
        Me.TextBox_password_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_password_login.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TextBox_password_login.PlaceholderText = "Password"
        Me.TextBox_password_login.SelectedText = ""
        Me.TextBox_password_login.ShadowDecoration.Parent = Me.TextBox_password_login
        Me.TextBox_password_login.Size = New System.Drawing.Size(262, 36)
        Me.TextBox_password_login.TabIndex = 29
        Me.TextBox_password_login.UseSystemPasswordChar = True
        '
        'TextBox_username_login
        '
        Me.TextBox_username_login.BackColor = System.Drawing.Color.Black
        Me.TextBox_username_login.BorderRadius = 8
        Me.TextBox_username_login.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TextBox_username_login, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox_username_login.DefaultText = ""
        Me.TextBox_username_login.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_username_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_username_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_username_login.DisabledState.Parent = Me.TextBox_username_login
        Me.TextBox_username_login.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_username_login.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_username_login.FocusedState.Parent = Me.TextBox_username_login
        Me.TextBox_username_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_username_login.ForeColor = System.Drawing.Color.Black
        Me.TextBox_username_login.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_username_login.HoverState.Parent = Me.TextBox_username_login
        Me.TextBox_username_login.IconLeft = CType(resources.GetObject("TextBox_username_login.IconLeft"), System.Drawing.Image)
        Me.TextBox_username_login.Location = New System.Drawing.Point(27, 85)
        Me.TextBox_username_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_username_login.Name = "TextBox_username_login"
        Me.TextBox_username_login.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_username_login.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TextBox_username_login.PlaceholderText = "Username"
        Me.TextBox_username_login.SelectedText = ""
        Me.TextBox_username_login.ShadowDecoration.Parent = Me.TextBox_username_login
        Me.TextBox_username_login.Size = New System.Drawing.Size(262, 36)
        Me.TextBox_username_login.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 28)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "User Login"
        '
        'Guna2ToggleSwitch1
        '
        Me.Guna2ToggleSwitch1.BackColor = System.Drawing.Color.Black
        Me.Guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.CheckedState.Parent = Me.Guna2ToggleSwitch1
        Me.Guna2Transition1.SetDecoration(Me.Guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ToggleSwitch1.Location = New System.Drawing.Point(27, 197)
        Me.Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1"
        Me.Guna2ToggleSwitch1.ShadowDecoration.Parent = Me.Guna2ToggleSwitch1
        Me.Guna2ToggleSwitch1.Size = New System.Drawing.Size(35, 20)
        Me.Guna2ToggleSwitch1.TabIndex = 3
        Me.Guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.UncheckedState.Parent = Me.Guna2ToggleSwitch1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Show Password"
        '
        'Button_login
        '
        Me.Button_login.Animated = True
        Me.Button_login.AutoRoundedCorners = True
        Me.Button_login.BackColor = System.Drawing.Color.Black
        Me.Button_login.BorderRadius = 21
        Me.Button_login.CheckedState.Parent = Me.Button_login
        Me.Button_login.CustomImages.Parent = Me.Button_login
        Me.Guna2Transition1.SetDecoration(Me.Button_login, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Button_login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_login.ForeColor = System.Drawing.Color.White
        Me.Button_login.HoverState.Parent = Me.Button_login
        Me.Button_login.Location = New System.Drawing.Point(28, 235)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.ShadowDecoration.Parent = Me.Button_login
        Me.Button_login.Size = New System.Drawing.Size(252, 45)
        Me.Button_login.TabIndex = 5
        Me.Button_login.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Forgeot Username Password ?"
        '
        'Panal_Register
        '
        Me.Panal_Register.BackColor = System.Drawing.Color.DimGray
        Me.Panal_Register.Controls.Add(Me.TextBox_tell)
        Me.Panal_Register.Controls.Add(Me.TextBox_card_id)
        Me.Panal_Register.Controls.Add(Me.Guna2Button2)
        Me.Panal_Register.Controls.Add(Me.ComBoBox_sex)
        Me.Panal_Register.Controls.Add(Me.Label11)
        Me.Panal_Register.Controls.Add(Me.Label10)
        Me.Panal_Register.Controls.Add(Me.Label9)
        Me.Panal_Register.Controls.Add(Me.Label8)
        Me.Panal_Register.Controls.Add(Me.Label7)
        Me.Panal_Register.Controls.Add(Me.Label6)
        Me.Panal_Register.Controls.Add(Me.TextBox_password)
        Me.Panal_Register.Controls.Add(Me.TextBox_Username)
        Me.Panal_Register.Controls.Add(Me.Label4)
        Me.Panal_Register.Controls.Add(Me.TextBox_name)
        Me.Panal_Register.Controls.Add(Me.btn_create_account)
        Me.Guna2Transition1.SetDecoration(Me.Panal_Register, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panal_Register.FillColor = System.Drawing.Color.Black
        Me.Panal_Register.Location = New System.Drawing.Point(88, 59)
        Me.Panal_Register.Name = "Panal_Register"
        Me.Panal_Register.ShadowColor = System.Drawing.Color.Black
        Me.Panal_Register.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Panal_Register.Size = New System.Drawing.Size(652, 488)
        Me.Panal_Register.TabIndex = 24
        Me.Panal_Register.Visible = False
        '
        'TextBox_tell
        '
        Me.TextBox_tell.BackColor = System.Drawing.Color.Black
        Me.TextBox_tell.BorderRadius = 8
        Me.TextBox_tell.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TextBox_tell, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox_tell.DefaultText = ""
        Me.TextBox_tell.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_tell.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_tell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_tell.DisabledState.Parent = Me.TextBox_tell
        Me.TextBox_tell.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_tell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_tell.FocusedState.Parent = Me.TextBox_tell
        Me.TextBox_tell.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_tell.ForeColor = System.Drawing.Color.Black
        Me.TextBox_tell.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_tell.HoverState.Parent = Me.TextBox_tell
        Me.TextBox_tell.IconLeft = CType(resources.GetObject("TextBox_tell.IconLeft"), System.Drawing.Image)
        Me.TextBox_tell.Location = New System.Drawing.Point(364, 186)
        Me.TextBox_tell.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_tell.Name = "TextBox_tell"
        Me.TextBox_tell.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_tell.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TextBox_tell.PlaceholderText = "เบอร์โทร"
        Me.TextBox_tell.SelectedText = ""
        Me.TextBox_tell.ShadowDecoration.Parent = Me.TextBox_tell
        Me.TextBox_tell.Size = New System.Drawing.Size(262, 36)
        Me.TextBox_tell.TabIndex = 32
        '
        'TextBox_card_id
        '
        Me.TextBox_card_id.Animated = True
        Me.TextBox_card_id.BackColor = System.Drawing.Color.Black
        Me.TextBox_card_id.BorderRadius = 8
        Me.TextBox_card_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TextBox_card_id, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox_card_id.DefaultText = ""
        Me.TextBox_card_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_card_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_card_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_card_id.DisabledState.Parent = Me.TextBox_card_id
        Me.TextBox_card_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_card_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_card_id.FocusedState.Parent = Me.TextBox_card_id
        Me.TextBox_card_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_card_id.ForeColor = System.Drawing.Color.Black
        Me.TextBox_card_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_card_id.HoverState.Parent = Me.TextBox_card_id
        Me.TextBox_card_id.IconLeft = CType(resources.GetObject("TextBox_card_id.IconLeft"), System.Drawing.Image)
        Me.TextBox_card_id.Location = New System.Drawing.Point(362, 103)
        Me.TextBox_card_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_card_id.Name = "TextBox_card_id"
        Me.TextBox_card_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_card_id.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TextBox_card_id.PlaceholderText = "บัตรประชาชน"
        Me.TextBox_card_id.SelectedText = ""
        Me.TextBox_card_id.ShadowDecoration.Parent = Me.TextBox_card_id
        Me.TextBox_card_id.Size = New System.Drawing.Size(262, 36)
        Me.TextBox_card_id.TabIndex = 31
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Black
        Me.Guna2Button2.BorderColor = System.Drawing.Color.White
        Me.Guna2Button2.BorderRadius = 21
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Transition1.SetDecoration(Me.Guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Button2.FillColor = System.Drawing.Color.Black
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button2.Location = New System.Drawing.Point(509, 429)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(117, 45)
        Me.Guna2Button2.TabIndex = 30
        Me.Guna2Button2.Text = "LOGIN"
        '
        'ComBoBox_sex
        '
        Me.ComBoBox_sex.BackColor = System.Drawing.Color.Transparent
        Me.ComBoBox_sex.BorderRadius = 10
        Me.Guna2Transition1.SetDecoration(Me.ComBoBox_sex, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ComBoBox_sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComBoBox_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComBoBox_sex.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComBoBox_sex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComBoBox_sex.FocusedState.Parent = Me.ComBoBox_sex
        Me.ComBoBox_sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComBoBox_sex.ForeColor = System.Drawing.Color.Black
        Me.ComBoBox_sex.HoverState.Parent = Me.ComBoBox_sex
        Me.ComBoBox_sex.ItemHeight = 30
        Me.ComBoBox_sex.Items.AddRange(New Object() {"ชาย", "หญิง"})
        Me.ComBoBox_sex.ItemsAppearance.Parent = Me.ComBoBox_sex
        Me.ComBoBox_sex.Location = New System.Drawing.Point(22, 186)
        Me.ComBoBox_sex.Name = "ComBoBox_sex"
        Me.ComBoBox_sex.ShadowDecoration.Parent = Me.ComBoBox_sex
        Me.ComBoBox_sex.Size = New System.Drawing.Size(263, 36)
        Me.ComBoBox_sex.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label11, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(359, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 21)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label10, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(18, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 21)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label9, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(359, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 21)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "เบอร์โทร"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label8, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 21)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "เพศ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label7, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(359, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 21)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "บัตรประชาชน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "ชื่อ-นามสกุล"
        '
        'TextBox_password
        '
        Me.TextBox_password.Animated = True
        Me.TextBox_password.BackColor = System.Drawing.Color.Black
        Me.TextBox_password.BorderRadius = 8
        Me.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TextBox_password, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox_password.DefaultText = ""
        Me.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_password.DisabledState.Parent = Me.TextBox_password
        Me.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_password.FocusedState.Parent = Me.TextBox_password
        Me.TextBox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_password.ForeColor = System.Drawing.Color.Black
        Me.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_password.HoverState.Parent = Me.TextBox_password
        Me.TextBox_password.IconLeft = CType(resources.GetObject("TextBox_password.IconLeft"), System.Drawing.Image)
        Me.TextBox_password.Location = New System.Drawing.Point(362, 279)
        Me.TextBox_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_password.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TextBox_password.PlaceholderText = "Password"
        Me.TextBox_password.SelectedText = ""
        Me.TextBox_password.ShadowDecoration.Parent = Me.TextBox_password
        Me.TextBox_password.Size = New System.Drawing.Size(262, 36)
        Me.TextBox_password.TabIndex = 21
        Me.TextBox_password.UseSystemPasswordChar = True
        '
        'TextBox_Username
        '
        Me.TextBox_Username.Animated = True
        Me.TextBox_Username.BackColor = System.Drawing.Color.Black
        Me.TextBox_Username.BorderRadius = 8
        Me.TextBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TextBox_Username, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox_Username.DefaultText = ""
        Me.TextBox_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_Username.DisabledState.Parent = Me.TextBox_Username
        Me.TextBox_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_Username.FocusedState.Parent = Me.TextBox_Username
        Me.TextBox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_Username.ForeColor = System.Drawing.Color.Black
        Me.TextBox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_Username.HoverState.Parent = Me.TextBox_Username
        Me.TextBox_Username.IconLeft = CType(resources.GetObject("TextBox_Username.IconLeft"), System.Drawing.Image)
        Me.TextBox_Username.Location = New System.Drawing.Point(23, 279)
        Me.TextBox_Username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_Username.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TextBox_Username.PlaceholderText = "Username"
        Me.TextBox_Username.SelectedText = ""
        Me.TextBox_Username.ShadowDecoration.Parent = Me.TextBox_Username
        Me.TextBox_Username.Size = New System.Drawing.Size(262, 36)
        Me.TextBox_Username.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 28)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "สมัครสมาชิก"
        '
        'TextBox_name
        '
        Me.TextBox_name.Animated = True
        Me.TextBox_name.BackColor = System.Drawing.Color.Black
        Me.TextBox_name.BorderRadius = 8
        Me.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.TextBox_name, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox_name.DefaultText = ""
        Me.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_name.DisabledState.Parent = Me.TextBox_name
        Me.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_name.FocusedState.Parent = Me.TextBox_name
        Me.TextBox_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox_name.ForeColor = System.Drawing.Color.Black
        Me.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox_name.HoverState.Parent = Me.TextBox_name
        Me.TextBox_name.IconLeft = CType(resources.GetObject("TextBox_name.IconLeft"), System.Drawing.Image)
        Me.TextBox_name.Location = New System.Drawing.Point(23, 103)
        Me.TextBox_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_name.Name = "TextBox_name"
        Me.TextBox_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox_name.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TextBox_name.PlaceholderText = "ชื่อ-นามสกุล"
        Me.TextBox_name.SelectedText = ""
        Me.TextBox_name.ShadowDecoration.Parent = Me.TextBox_name
        Me.TextBox_name.Size = New System.Drawing.Size(262, 36)
        Me.TextBox_name.TabIndex = 10
        '
        'btn_create_account
        '
        Me.btn_create_account.Animated = True
        Me.btn_create_account.AutoRoundedCorners = True
        Me.btn_create_account.BackColor = System.Drawing.Color.Black
        Me.btn_create_account.BorderRadius = 21
        Me.btn_create_account.CheckedState.Parent = Me.btn_create_account
        Me.btn_create_account.CustomImages.Parent = Me.btn_create_account
        Me.Guna2Transition1.SetDecoration(Me.btn_create_account, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_create_account.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_account.ForeColor = System.Drawing.Color.White
        Me.btn_create_account.HoverState.Parent = Me.btn_create_account
        Me.btn_create_account.Image = CType(resources.GetObject("btn_create_account.Image"), System.Drawing.Image)
        Me.btn_create_account.Location = New System.Drawing.Point(362, 358)
        Me.btn_create_account.Name = "btn_create_account"
        Me.btn_create_account.ShadowDecoration.Parent = Me.btn_create_account
        Me.btn_create_account.Size = New System.Drawing.Size(262, 45)
        Me.btn_create_account.TabIndex = 14
        Me.btn_create_account.Text = "Create Account"
        '
        'Button1
        '
        Me.Guna2Transition1.SetDecoration(Me.Button1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Button1.Location = New System.Drawing.Point(219, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(839, 581)
        Me.Controls.Add(Me.Panal_Login)
        Me.Controls.Add(Me.Panal_Register)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Login"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panal_Login.ResumeLayout(False)
        Me.Panal_Login.PerformLayout()
        Me.Panal_Register.ResumeLayout(False)
        Me.Panal_Register.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Panal_Login As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_login As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panal_Register As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TextBox_Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_create_account As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TextBox_password_login As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox_username_login As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ComBoBox_sex As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox_tell As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox_card_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Button
End Class
