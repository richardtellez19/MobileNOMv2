<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursales))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SucursalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDBDataSet = New MobileNOMv2.MainDBDataSet()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SucursalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SeriesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TiposCfdiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SucursalesTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.SucursalesTableAdapter()
        Me.TableAdapterManager = New MobileNOMv2.MainDBDataSetTableAdapters.TableAdapterManager()
        Me.SeriesTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.SeriesTableAdapter()
        Me.EstadosTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.EstadosTableAdapter()
        Me.TiposCfdiTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.TiposCfdiTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddCert = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SucursalesBindingNavigator.SuspendLayout()
        CType(Me.SeriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposCfdiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.SucursalesDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SucursalesBindingNavigator)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SeriesDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(651, 362)
        Me.SplitContainer1.SplitterDistance = 202
        Me.SplitContainer1.TabIndex = 0
        '
        'SucursalesDataGridView
        '
        Me.SucursalesDataGridView.AutoGenerateColumns = False
        Me.SucursalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SucursalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.AddCert})
        Me.SucursalesDataGridView.DataSource = Me.SucursalesBindingSource
        Me.SucursalesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SucursalesDataGridView.Location = New System.Drawing.Point(0, 52)
        Me.SucursalesDataGridView.Name = "SucursalesDataGridView"
        Me.SucursalesDataGridView.Size = New System.Drawing.Size(651, 150)
        Me.SucursalesDataGridView.TabIndex = 0
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "Estados"
        Me.EstadosBindingSource.DataSource = Me.MainDBDataSet
        '
        'MainDBDataSet
        '
        Me.MainDBDataSet.DataSetName = "MainDBDataSet"
        Me.MainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SucursalesBindingSource
        '
        Me.SucursalesBindingSource.DataMember = "Sucursales"
        Me.SucursalesBindingSource.DataSource = Me.MainDBDataSet
        '
        'SucursalesBindingNavigator
        '
        Me.SucursalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SucursalesBindingNavigator.BindingSource = Me.SucursalesBindingSource
        Me.SucursalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SucursalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SucursalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SucursalesBindingNavigatorSaveItem})
        Me.SucursalesBindingNavigator.Location = New System.Drawing.Point(0, 27)
        Me.SucursalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SucursalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SucursalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SucursalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SucursalesBindingNavigator.Name = "SucursalesBindingNavigator"
        Me.SucursalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SucursalesBindingNavigator.Size = New System.Drawing.Size(651, 25)
        Me.SucursalesBindingNavigator.TabIndex = 1
        Me.SucursalesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SucursalesBindingNavigatorSaveItem
        '
        Me.SucursalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SucursalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SucursalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SucursalesBindingNavigatorSaveItem.Name = "SucursalesBindingNavigatorSaveItem"
        Me.SucursalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SucursalesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(651, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SUCURSALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SeriesDataGridView
        '
        Me.SeriesDataGridView.AutoGenerateColumns = False
        Me.SeriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SeriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.SeriesDataGridView.DataSource = Me.SeriesBindingSource
        Me.SeriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeriesDataGridView.Location = New System.Drawing.Point(0, 49)
        Me.SeriesDataGridView.Name = "SeriesDataGridView"
        Me.SeriesDataGridView.Size = New System.Drawing.Size(651, 107)
        Me.SeriesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SerieId"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn19.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 60
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "SucursalId"
        Me.DataGridViewTextBoxColumn21.HeaderText = "SucursalId"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TipoCfdiId"
        Me.DataGridViewTextBoxColumn20.DataSource = Me.TiposCfdiBindingSource
        Me.DataGridViewTextBoxColumn20.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn20.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn20.ValueMember = "TipoCfdiId"
        '
        'TiposCfdiBindingSource
        '
        Me.TiposCfdiBindingSource.DataMember = "TiposCfdi"
        Me.TiposCfdiBindingSource.DataSource = Me.MainDBDataSet
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Serie"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "FolioActual"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn23.HeaderText = "Folio Actual"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'SeriesBindingSource
        '
        Me.SeriesBindingSource.DataMember = "Series_Sucursales"
        Me.SeriesBindingSource.DataSource = Me.SucursalesBindingSource
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.SeriesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 24)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(651, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(651, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SERIES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SucursalesTableAdapter
        '
        Me.SucursalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccionesOTitulosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BancosTableAdapter = Nothing
        Me.TableAdapterManager.CFDIsTableAdapter = Nothing
        Me.TableAdapterManager.CompensacionSaldosAFavorTableAdapter = Nothing
        Me.TableAdapterManager.ComprobantesTableAdapter = Nothing
        Me.TableAdapterManager.CondicionesDePagoTableAdapter = Nothing
        Me.TableAdapterManager.ContactosTableAdapter = Nothing
        Me.TableAdapterManager.CuentasPredialesTableAdapter = Nothing
        Me.TableAdapterManager.DeduccionEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.DeduccionesTableAdapter = Nothing
        Me.TableAdapterManager.EmisorTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EstadosTableAdapter = Nothing
        Me.TableAdapterManager.FormasDePagoTableAdapter = Nothing
        Me.TableAdapterManager.HorasExtraPercepTableAdapter = Nothing
        Me.TableAdapterManager.HorasExtraTableAdapter = Nothing
        Me.TableAdapterManager.ImpRetencionTableAdapter = Nothing
        Me.TableAdapterManager.ImpTrasladoTableAdapter = Nothing
        Me.TableAdapterManager.IncapacidadesTableAdapter = Nothing
        Me.TableAdapterManager.ItemsImpRetencionTableAdapter = Nothing
        Me.TableAdapterManager.ItemsImpTrasladoTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.JubilacionPensionRetiroTableAdapter = Nothing
        Me.TableAdapterManager.MetodosDePagoTableAdapter = Nothing
        Me.TableAdapterManager.MonedasTableAdapter = Nothing
        Me.TableAdapterManager.OrigenRecursosTableAdapter = Nothing
        Me.TableAdapterManager.OtrosPagosTableAdapter = Nothing
        Me.TableAdapterManager.PaisesTableAdapter = Nothing
        Me.TableAdapterManager.PercepcionEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.PercepcionesTableAdapter = Nothing
        Me.TableAdapterManager.PeriodicidadesTableAdapter = Nothing
        Me.TableAdapterManager.ReceptoresTableAdapter = Nothing
        Me.TableAdapterManager.RegimenEmisorTableAdapter = Nothing
        Me.TableAdapterManager.RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.RiesgoPuestoTableAdapter = Nothing
        Me.TableAdapterManager.SeparacionIndemnizacionTableAdapter = Nothing
        Me.TableAdapterManager.SeriesTableAdapter = Me.SeriesTableAdapter
        Me.TableAdapterManager.StatusCompTableAdapter = Nothing
        Me.TableAdapterManager.SubsidioAlEmpleoTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Me.SucursalesTableAdapter
        Me.TableAdapterManager.TipoContratosTableAdapter = Nothing
        Me.TableAdapterManager.TipoIncapacidadTableAdapter = Nothing
        Me.TableAdapterManager.TipoJornadaTableAdapter = Nothing
        Me.TableAdapterManager.TipoNominaTableAdapter = Nothing
        Me.TableAdapterManager.TipoOtroPagoTableAdapter = Nothing
        Me.TableAdapterManager.TipoRegimenNominaTableAdapter = Nothing
        Me.TableAdapterManager.TiposCfdiTableAdapter = Nothing
        Me.TableAdapterManager.UnidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MobileNOMv2.MainDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SeriesTableAdapter
        '
        Me.SeriesTableAdapter.ClearBeforeFill = True
        '
        'EstadosTableAdapter
        '
        Me.EstadosTableAdapter.ClearBeforeFill = True
        '
        'TiposCfdiTableAdapter
        '
        Me.TiposCfdiTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SucursalId"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ClaveSucursal"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código sucursal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreSucursal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre sucursal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Calle"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Calle"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "noExt"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Núm. Ext."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "noInt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Núm. Int."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Colonia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Colonia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Localidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Localidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Municipio"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Municipio"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CodigoPostal"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Código Postal"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "EstadoId"
        Me.DataGridViewTextBoxColumn18.DataSource = Me.EstadosBindingSource
        Me.DataGridViewTextBoxColumn18.DisplayMember = "EstadoDesc"
        Me.DataGridViewTextBoxColumn18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn18.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn18.ValueMember = "EstadoId"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Télefono"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CSD"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn13.HeaderText = "CSD"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "KEY"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn14.HeaderText = "KEY"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "PFX"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn15.HeaderText = "PFX"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "DiasAviso"
        Me.DataGridViewTextBoxColumn17.HeaderText = "DiasAviso"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'AddCert
        '
        Me.AddCert.HeaderText = "Cambiar CSD"
        Me.AddCert.Name = "AddCert"
        Me.AddCert.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddCert.Text = "Cambiar CSD"
        Me.AddCert.UseColumnTextForButtonValue = True
        '
        'frmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 362)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmSucursales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sucursales y Series de Folios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SucursalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SucursalesBindingNavigator.ResumeLayout(False)
        Me.SucursalesBindingNavigator.PerformLayout()
        CType(Me.SeriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposCfdiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MainDBDataSet As MobileNOMv2.MainDBDataSet
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.SucursalesTableAdapter
    Friend WithEvents TableAdapterManager As MobileNOMv2.MainDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SucursalesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SucursalesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SucursalesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SeriesTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.SeriesTableAdapter
    Friend WithEvents SeriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SeriesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EstadosTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.EstadosTableAdapter
    Friend WithEvents EstadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposCfdiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TiposCfdiTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.TiposCfdiTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddCert As System.Windows.Forms.DataGridViewButtonColumn
End Class
