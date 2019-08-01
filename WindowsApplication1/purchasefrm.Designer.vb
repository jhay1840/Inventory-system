<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchasefrm
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation6 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchasefrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JisdbDataSet = New WindowsApplication1.jisdbDataSet()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuTransition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ProductsTableAdapter = New WindowsApplication1.jisdbDataSetTableAdapters.productsTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.account = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JisdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton5)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton4)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton3)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 495)
        Me.Panel1.TabIndex = 5
        '
        'TextBox5
        '
        Me.BunifuTransition2.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox5.Location = New System.Drawing.Point(137, 57)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.Controls.Add(Me.account)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel10)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel9)
        Me.Panel2.Controls.Add(Me.BunifuImageButton3)
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(925, 32)
        Me.Panel2.TabIndex = 4
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(291, 7)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(37, 17)
        Me.BunifuCustomLabel10.TabIndex = 9
        Me.BunifuCustomLabel10.Text = "time"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(385, 7)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(39, 17)
        Me.BunifuCustomLabel9.TabIndex = 8
        Me.BunifuCustomLabel9.Text = "date"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(34, 7)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(230, 17)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "JIS School Supply and Merchandise"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        Me.ProductsBindingSource.DataSource = Me.JisdbDataSet
        '
        'JisdbDataSet
        '
        Me.JisdbDataSet.DataSetName = "jisdbDataSet"
        Me.JisdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel5.Controls.Add(Me.BunifuTextbox1)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuTransition1.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(243, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(682, 31)
        Me.Panel5.TabIndex = 6
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(274, 11)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(91, 17)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "Refresh Table"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuTransition2
        '
        Me.BunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.BunifuTransition2.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(30)
        Animation6.RotateCoeff = 0.5!
        Animation6.RotateLimit = 0.2!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0!
        Animation6.TransparencyCoeff = 0!
        Me.BunifuTransition2.DefaultAnimation = Animation6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuTransition1.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.DataGridView1, BunifuAnimatorNS.DecorationType.None)
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(243, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(682, 364)
        Me.DataGridView1.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BunifuThinButton26)
        Me.Panel3.Controls.Add(Me.BunifuThinButton25)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(243, 427)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(682, 100)
        Me.Panel3.TabIndex = 9
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.BunifuTransition1.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 1
        Animation5.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 2.0!
        Animation5.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation5
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.BunifuCustomLabel1
        Me.BunifuDragControl2.Vertical = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BunifuThinButton26
        '
        Me.BunifuThinButton26.ActiveBorderThickness = 1
        Me.BunifuThinButton26.ActiveCornerRadius = 20
        Me.BunifuThinButton26.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton26.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton26.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton26.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuThinButton26.BackgroundImage = CType(resources.GetObject("BunifuThinButton26.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton26.ButtonText = "New Stocks"
        Me.BunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton26, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuThinButton26, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton26.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton26.IdleBorderThickness = 1
        Me.BunifuThinButton26.IdleCornerRadius = 20
        Me.BunifuThinButton26.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton26.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton26.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton26.Location = New System.Drawing.Point(231, 21)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(134, 44)
        Me.BunifuThinButton26.TabIndex = 60
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton25.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Purchased"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton25, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuThinButton25, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton25.Location = New System.Drawing.Point(39, 21)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(134, 44)
        Me.BunifuThinButton25.TabIndex = 59
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.BunifuTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTextbox1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.Gray
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(6, 4)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(262, 25)
        Me.BunifuTextbox1.TabIndex = 9
        Me.BunifuTextbox1.text = "Purchased ID"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(192, 14)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(32, 27)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 1
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 20
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "            Logout"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Global.WindowsApplication1.My.Resources.Resources.Logout_Rounded_Up_100px
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 50.0R
        Me.BunifuFlatButton5.IsTab = True
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 350)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(243, 48)
        Me.BunifuFlatButton5.TabIndex = 6
        Me.BunifuFlatButton5.Text = "            Logout"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "            Sales"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = Global.WindowsApplication1.My.Resources.Resources.Land_Sales_100px
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 50.0R
        Me.BunifuFlatButton4.IsTab = True
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 236)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(243, 48)
        Me.BunifuFlatButton4.TabIndex = 5
        Me.BunifuFlatButton4.Text = "            Sales"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "            Update data"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Global.WindowsApplication1.My.Resources.Resources.Add_Shopping_Cart_100px
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 50.0R
        Me.BunifuFlatButton3.IsTab = True
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 182)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(242, 48)
        Me.BunifuFlatButton3.TabIndex = 4
        Me.BunifuFlatButton3.Text = "            Update data"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "            Purchased"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton2.Enabled = False
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Global.WindowsApplication1.My.Resources.Resources.Purchase_Order_104px
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 50.0R
        Me.BunifuFlatButton2.IsTab = True
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(0, 137)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(243, 48)
        Me.BunifuFlatButton2.TabIndex = 3
        Me.BunifuFlatButton2.Text = "            Purchased"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "            Items"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.WindowsApplication1.My.Resources.Resources.Shopping_Basket_96px
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 50.0R
        Me.BunifuFlatButton1.IsTab = True
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 83)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(243, 48)
        Me.BunifuFlatButton1.TabIndex = 2
        Me.BunifuFlatButton1.Text = "            Items"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.BunifuTransition2.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'account
        '
        Me.account.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.account, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.account, BunifuAnimatorNS.DecorationType.None)
        Me.account.Image = Global.WindowsApplication1.My.Resources.Resources.User_Account_50px
        Me.account.ImageActive = Global.WindowsApplication1.My.Resources.Resources.User_Account_50px
        Me.account.Location = New System.Drawing.Point(806, 1)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(34, 28)
        Me.account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.account.TabIndex = 10
        Me.account.TabStop = False
        Me.account.Zoom = 20
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = Global.WindowsApplication1.My.Resources.Resources.Minimize_Window_96px
        Me.BunifuImageButton3.ImageActive = Global.WindowsApplication1.My.Resources.Resources.Minimize_Window_9236px
        Me.BunifuImageButton3.Location = New System.Drawing.Point(845, 1)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(33, 31)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 3
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.WindowsApplication1.My.Resources.Resources.Close_Window_96px
        Me.BunifuImageButton2.ImageActive = Global.WindowsApplication1.My.Resources.Resources.Close_Window_926px
        Me.BunifuImageButton2.Location = New System.Drawing.Point(880, 1)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(33, 31)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox2
        '
        Me.BunifuTransition2.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Play_104px
        Me.PictureBox2.Location = New System.Drawing.Point(15, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'purchasefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 527)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.BunifuTransition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "purchasefrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "purchasefrm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JisdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuTransition2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents JisdbDataSet As jisdbDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As jisdbDataSetTableAdapters.productsTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents account As Bunifu.Framework.UI.BunifuImageButton
End Class
