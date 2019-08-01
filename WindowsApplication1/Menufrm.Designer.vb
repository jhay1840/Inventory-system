<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menufrm
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menufrm))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JisdbDataSet = New WindowsApplication1.jisdbDataSet()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CategoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.BunifuTransition2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ProductsTableAdapter = New WindowsApplication1.jisdbDataSetTableAdapters.productsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.jisdbDataSetTableAdapters.TableAdapterManager()
        Me.CategoriesTableAdapter = New WindowsApplication1.jisdbDataSetTableAdapters.categoriesTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuTextbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.account = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JisdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.account, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BunifuTransition2.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 495)
        Me.Panel1.TabIndex = 0
        '
        'TextBox5
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox5.Location = New System.Drawing.Point(143, 57)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.AutoCompleteCustomSource.AddRange(New String() {"ew", "we"})
        Me.TextBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.BunifuTransition1.SetDecoration(Me.TextBox6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.TextBox6, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox6.Location = New System.Drawing.Point(112, 60)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(143, 20)
        Me.TextBox6.TabIndex = 8
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
        Me.BunifuTransition2.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(925, 32)
        Me.Panel2.TabIndex = 1
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(275, 7)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(37, 17)
        Me.BunifuCustomLabel10.TabIndex = 7
        Me.BunifuCustomLabel10.Text = "time"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(369, 7)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(39, 17)
        Me.BunifuCustomLabel9.TabIndex = 6
        Me.BunifuCustomLabel9.Text = "date"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(34, 7)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(230, 17)
        Me.BunifuCustomLabel1.TabIndex = 4
        Me.BunifuCustomLabel1.Text = "JIS School Supply and Merchandise"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel2
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProductsDataGridView)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.BunifuTransition2.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(243, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(682, 495)
        Me.Panel3.TabIndex = 2
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.AllowUserToAddRows = False
        Me.ProductsDataGridView.AllowUserToDeleteRows = False
        Me.ProductsDataGridView.AllowUserToResizeRows = False
        Me.ProductsDataGridView.AutoGenerateColumns = False
        Me.ProductsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProductsDataGridView.DataSource = Me.ProductsBindingSource
        Me.BunifuTransition2.SetDecoration(Me.ProductsDataGridView, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.ProductsDataGridView, BunifuAnimatorNS.DecorationType.None)
        Me.ProductsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProductsDataGridView.Location = New System.Drawing.Point(0, 31)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.ReadOnly = True
        Me.ProductsDataGridView.Size = New System.Drawing.Size(425, 364)
        Me.ProductsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CategoryID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CategoryID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Stocks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Stocks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "OriginalPrice"
        Me.DataGridViewTextBoxColumn5.HeaderText = "OriginalPrice"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RetailPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RetailPrice"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TextBox6)
        Me.Panel6.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel6.Controls.Add(Me.BunifuThinButton23)
        Me.Panel6.Controls.Add(Me.BunifuThinButton21)
        Me.Panel6.Controls.Add(Me.BunifuThinButton22)
        Me.Panel6.Controls.Add(Me.TextBox4)
        Me.Panel6.Controls.Add(Me.TextBox3)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Controls.Add(Me.BunifuCustomLabel6)
        Me.Panel6.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel6.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel6.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel6.Controls.Add(Me.BunifuCustomLabel7)
        Me.BunifuTransition2.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(421, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(261, 364)
        Me.Panel6.TabIndex = 4
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(10, 60)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(94, 17)
        Me.BunifuCustomLabel8.TabIndex = 54
        Me.BunifuCustomLabel8.Text = "Product Name"
        '
        'TextBox4
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.TextBox4, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(112, 232)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 20)
        Me.TextBox4.TabIndex = 49
        '
        'TextBox3
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.TextBox3, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(112, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 20)
        Me.TextBox3.TabIndex = 48
        '
        'TextBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.TextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(112, 166)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 47
        '
        'TextBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(112, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 46
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.BunifuTransition2.SetDecoration(Me.ComboBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.ComboBox1, BunifuAnimatorNS.DecorationType.None)
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 127)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 25)
        Me.ComboBox1.TabIndex = 45
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(10, 232)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(75, 17)
        Me.BunifuCustomLabel6.TabIndex = 44
        Me.BunifuCustomLabel6.Text = "Retail Price"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(10, 199)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(87, 17)
        Me.BunifuCustomLabel5.TabIndex = 43
        Me.BunifuCustomLabel5.Text = "Original Price"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(10, 166)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(47, 17)
        Me.BunifuCustomLabel4.TabIndex = 42
        Me.BunifuCustomLabel4.Text = "Stocks"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(10, 128)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(64, 17)
        Me.BunifuCustomLabel3.TabIndex = 41
        Me.BunifuCustomLabel3.Text = "Category"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(10, 95)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(94, 17)
        Me.BunifuCustomLabel7.TabIndex = 40
        Me.BunifuCustomLabel7.Text = "Product Name"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BunifuTextbox1)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuTransition2.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(682, 31)
        Me.Panel5.TabIndex = 3
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(274, 11)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(91, 17)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "Refresh Table"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel4.Controls.Add(Me.BunifuImageButton7)
        Me.Panel4.Controls.Add(Me.BunifuImageButton4)
        Me.Panel4.Controls.Add(Me.BunifuImageButton6)
        Me.Panel4.Controls.Add(Me.BunifuImageButton5)
        Me.BunifuTransition2.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 395)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(682, 100)
        Me.Panel4.TabIndex = 2
        '
        'CategoriesBindingSource1
        '
        Me.CategoriesBindingSource1.DataMember = "categories"
        Me.CategoriesBindingSource1.DataSource = Me.JisdbDataSet
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "categories"
        Me.CategoriesBindingSource.DataSource = Me.JisdbDataSet
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'BunifuTransition2
        '
        Me.BunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.BunifuTransition2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0.5!
        Animation2.RotateLimit = 0.2!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BunifuTransition2.DefaultAnimation = Animation2
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.ordersTableAdapter = Nothing
        Me.TableAdapterManager.productsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.purchasedTableAdapter = Nothing
        Me.TableAdapterManager.salesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.jisdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Delete Record"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton23, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton23.Location = New System.Drawing.Point(136, 269)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(117, 59)
        Me.BunifuThinButton23.TabIndex = 52
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuThinButton23.Visible = False
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
        Me.BunifuThinButton21.ButtonText = "Save"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(13, 269)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(115, 59)
        Me.BunifuThinButton21.TabIndex = 51
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuThinButton21.Visible = False
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Edit Data"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(56, 8)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton22.TabIndex = 50
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition2.SetDecoration(Me.BunifuTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuTextbox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTextbox1.Font = New System.Drawing.Font("Century Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.Gray
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(6, 4)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(262, 25)
        Me.BunifuTextbox1.TabIndex = 9
        Me.BunifuTextbox1.text = "Product Name"
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton7.Image = Global.WindowsApplication1.My.Resources.Resources.School_96px
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(35, 25)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(69, 53)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 4
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 20
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = Global.WindowsApplication1.My.Resources.Resources.House_96px
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(153, 25)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(82, 53)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 3
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 20
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton6.Image = Global.WindowsApplication1.My.Resources.Resources.Kitchen_96px
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(293, 25)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(82, 53)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 2
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 20
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton5.Image = Global.WindowsApplication1.My.Resources.Resources.Personal_Trainer_100px
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(433, 25)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(82, 53)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 1
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 20
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
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
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "            Items"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition2.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuFlatButton1, BunifuAnimatorNS.DecorationType.None)
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
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = Global.WindowsApplication1.My.Resources.Resources.Minimize_Window_96px
        Me.BunifuImageButton3.ImageActive = Global.WindowsApplication1.My.Resources.Resources.Minimize_Window_9236px
        Me.BunifuImageButton3.Location = New System.Drawing.Point(845, 0)
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
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = Global.WindowsApplication1.My.Resources.Resources.Close_Window_96px
        Me.BunifuImageButton2.ImageActive = Global.WindowsApplication1.My.Resources.Resources.Close_Window_926px
        Me.BunifuImageButton2.Location = New System.Drawing.Point(880, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(33, 31)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Play_104px
        Me.PictureBox2.Location = New System.Drawing.Point(15, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 21)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'account
        '
        Me.account.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition2.SetDecoration(Me.account, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.account, BunifuAnimatorNS.DecorationType.None)
        Me.account.Image = Global.WindowsApplication1.My.Resources.Resources.User_Account_50px
        Me.account.ImageActive = Global.WindowsApplication1.My.Resources.Resources.User_Account_50px
        Me.account.Location = New System.Drawing.Point(808, 1)
        Me.account.Name = "account"
        Me.account.Size = New System.Drawing.Size(34, 28)
        Me.account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.account.TabIndex = 11
        Me.account.TabStop = False
        Me.account.Zoom = 20
        '
        'Menufrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 527)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menufrm"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JisdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.account, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents BunifuTransition2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents JisdbDataSet As jisdbDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As jisdbDataSetTableAdapters.productsTableAdapter
    Friend WithEvents TableAdapterManager As jisdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuTextbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As jisdbDataSetTableAdapters.categoriesTableAdapter
    Friend WithEvents ProductsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CategoriesBindingSource1 As BindingSource
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents account As Bunifu.Framework.UI.BunifuImageButton
End Class
