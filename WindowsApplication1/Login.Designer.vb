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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 34)
        Me.Panel1.TabIndex = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.WindowsApplication1.My.Resources.Resources.Close_Window_96px
        Me.BunifuImageButton2.ImageActive = Global.WindowsApplication1.My.Resources.Resources.Close_Window_926px
        Me.BunifuImageButton2.Location = New System.Drawing.Point(297, 2)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(32, 30)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 11
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(34, 8)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(230, 17)
        Me.BunifuCustomLabel1.TabIndex = 9
        Me.BunifuCustomLabel1.Text = "JIS School Supply and Merchandise"
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Play_104px
        Me.PictureBox2.Location = New System.Drawing.Point(10, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.BunifuCustomLabel1
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.BunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.HintText = "Password"
        Me.BunifuMaterialTextbox1.isPassword = True
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(61, 228)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(214, 33)
        Me.BunifuMaterialTextbox1.TabIndex = 2
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox3
        '
        Me.BunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.BunifuMaterialTextbox3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextbox3.Enabled = False
        Me.BunifuMaterialTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox3.HintText = ""
        Me.BunifuMaterialTextbox3.isPassword = False
        Me.BunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox3.LineThickness = 2
        Me.BunifuMaterialTextbox3.Location = New System.Drawing.Point(12, 123)
        Me.BunifuMaterialTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox3.Name = "BunifuMaterialTextbox3"
        Me.BunifuMaterialTextbox3.Size = New System.Drawing.Size(304, 33)
        Me.BunifuMaterialTextbox3.TabIndex = 7
        Me.BunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(100, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.BunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.HintText = "Username"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(61, 180)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(214, 33)
        Me.BunifuMaterialTextbox2.TabIndex = 1
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "    Login"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.WindowsApplication1.My.Resources.Resources.Login_96px
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 40.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(100, 316)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(132, 48)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.Text = "    Login"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(112, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Forgot Password?"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BunifuThinButton21)
        Me.Panel4.Controls.Add(Me.TextBox5)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(330, 415)
        Me.Panel4.TabIndex = 64
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Reset Password"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(75, 245)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(176, 53)
        Me.BunifuThinButton21.TabIndex = 61
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox5.Location = New System.Drawing.Point(96, 189)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(140, 20)
        Me.TextBox5.TabIndex = 16
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(81, 157)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(170, 17)
        Me.BunifuCustomLabel6.TabIndex = 15
        Me.BunifuCustomLabel6.Text = "What is your pet's name?"
        '
        'TextBox4
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox4, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox4.Location = New System.Drawing.Point(96, 118)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(140, 20)
        Me.TextBox4.TabIndex = 14
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(64, 86)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(187, 17)
        Me.BunifuCustomLabel5.TabIndex = 13
        Me.BunifuCustomLabel5.Text = "What is your favorite team?"
        '
        'TextBox3
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox3, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox3.Location = New System.Drawing.Point(96, 58)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 20)
        Me.TextBox3.TabIndex = 12
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(34, 25)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(250, 17)
        Me.BunifuCustomLabel4.TabIndex = 11
        Me.BunifuCustomLabel4.Text = "What was your childhood nickname?"
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 449)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuMaterialTextbox3)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
