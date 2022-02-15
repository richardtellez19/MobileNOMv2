<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmisor
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
        Dim RFCLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CURPLabel As System.Windows.Forms.Label
        Dim CalleLabel As System.Windows.Forms.Label
        Dim NoExtLabel As System.Windows.Forms.Label
        Dim NoIntLabel As System.Windows.Forms.Label
        Dim ColoniaLabel As System.Windows.Forms.Label
        Dim LocalidadLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim MunicipioLabel As System.Windows.Forms.Label
        Dim CodigoPostalLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim PaginaWebLabel As System.Windows.Forms.Label
        Dim EstadoIdLabel As System.Windows.Forms.Label
        Dim LogotipoLabel As System.Windows.Forms.Label
        Dim RegistroPatronalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmisor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EmisorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.EmisorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDBDataSet = New MobileNOMv2.MainDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmisorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.NombreComercialTextBox = New System.Windows.Forms.TextBox()
        Me.CURPTextBox = New System.Windows.Forms.TextBox()
        Me.CalleTextBox = New System.Windows.Forms.TextBox()
        Me.NoExtTextBox = New System.Windows.Forms.TextBox()
        Me.NoIntTextBox = New System.Windows.Forms.TextBox()
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox()
        Me.LocalidadTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.MunicipioTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoPostalTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.PaginaWebTextBox = New System.Windows.Forms.TextBox()
        Me.EmisorTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.EmisorTableAdapter()
        Me.TableAdapterManager = New MobileNOMv2.MainDBDataSetTableAdapters.TableAdapterManager()
        Me.RegimenEmisorTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.RegimenEmisorTableAdapter()
        Me.RegimenEmisorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegimenEmisorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RegimenFiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegimenFiscalTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.RegimenFiscalTableAdapter()
        Me.EstadoIdComboBox = New System.Windows.Forms.ComboBox()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogotipoPictureBox = New System.Windows.Forms.PictureBox()
        Me.EstadosTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.EstadosTableAdapter()
        Me.SetLogoButton = New System.Windows.Forms.Button()
        Me.ClearLogoButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.NombreComercialCheckBox = New System.Windows.Forms.CheckBox()
        Me.RegistroPatronalTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StatusFoliosDataGridView = New System.Windows.Forms.DataGridView()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solicitados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Restantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Licencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gratuitos = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TablaPreciosDataGridView = New System.Windows.Forms.DataGridView()
        Me.PrecioId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Folios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Solicitar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        RFCLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CURPLabel = New System.Windows.Forms.Label()
        CalleLabel = New System.Windows.Forms.Label()
        NoExtLabel = New System.Windows.Forms.Label()
        NoIntLabel = New System.Windows.Forms.Label()
        ColoniaLabel = New System.Windows.Forms.Label()
        LocalidadLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        MunicipioLabel = New System.Windows.Forms.Label()
        CodigoPostalLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        PaginaWebLabel = New System.Windows.Forms.Label()
        EstadoIdLabel = New System.Windows.Forms.Label()
        LogotipoLabel = New System.Windows.Forms.Label()
        RegistroPatronalLabel = New System.Windows.Forms.Label()
        CType(Me.EmisorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmisorBindingNavigator.SuspendLayout()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegimenEmisorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegimenEmisorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegimenFiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogotipoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.StatusFoliosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaPreciosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(27, 12)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(31, 13)
        RFCLabel.TabIndex = 3
        RFCLabel.Text = "RFC:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(27, 38)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'CURPLabel
        '
        CURPLabel.AutoSize = True
        CURPLabel.Location = New System.Drawing.Point(27, 90)
        CURPLabel.Name = "CURPLabel"
        CURPLabel.Size = New System.Drawing.Size(40, 13)
        CURPLabel.TabIndex = 9
        CURPLabel.Text = "CURP:"
        '
        'CalleLabel
        '
        CalleLabel.AutoSize = True
        CalleLabel.Location = New System.Drawing.Point(27, 146)
        CalleLabel.Name = "CalleLabel"
        CalleLabel.Size = New System.Drawing.Size(33, 13)
        CalleLabel.TabIndex = 11
        CalleLabel.Text = "Calle:"
        '
        'NoExtLabel
        '
        NoExtLabel.AutoSize = True
        NoExtLabel.Location = New System.Drawing.Point(27, 172)
        NoExtLabel.Name = "NoExtLabel"
        NoExtLabel.Size = New System.Drawing.Size(73, 13)
        NoExtLabel.TabIndex = 13
        NoExtLabel.Text = "Núm. Exterior:"
        '
        'NoIntLabel
        '
        NoIntLabel.AutoSize = True
        NoIntLabel.Location = New System.Drawing.Point(27, 198)
        NoIntLabel.Name = "NoIntLabel"
        NoIntLabel.Size = New System.Drawing.Size(70, 13)
        NoIntLabel.TabIndex = 15
        NoIntLabel.Text = "Núm. Interior:"
        '
        'ColoniaLabel
        '
        ColoniaLabel.AutoSize = True
        ColoniaLabel.Location = New System.Drawing.Point(27, 224)
        ColoniaLabel.Name = "ColoniaLabel"
        ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        ColoniaLabel.TabIndex = 17
        ColoniaLabel.Text = "Colonia:"
        '
        'LocalidadLabel
        '
        LocalidadLabel.AutoSize = True
        LocalidadLabel.Location = New System.Drawing.Point(27, 250)
        LocalidadLabel.Name = "LocalidadLabel"
        LocalidadLabel.Size = New System.Drawing.Size(56, 13)
        LocalidadLabel.TabIndex = 19
        LocalidadLabel.Text = "Localidad:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(27, 276)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 21
        ReferenciaLabel.Text = "Referencia:"
        '
        'MunicipioLabel
        '
        MunicipioLabel.AutoSize = True
        MunicipioLabel.Location = New System.Drawing.Point(27, 302)
        MunicipioLabel.Name = "MunicipioLabel"
        MunicipioLabel.Size = New System.Drawing.Size(55, 13)
        MunicipioLabel.TabIndex = 23
        MunicipioLabel.Text = "Municipio:"
        '
        'CodigoPostalLabel
        '
        CodigoPostalLabel.AutoSize = True
        CodigoPostalLabel.Location = New System.Drawing.Point(27, 328)
        CodigoPostalLabel.Name = "CodigoPostalLabel"
        CodigoPostalLabel.Size = New System.Drawing.Size(75, 13)
        CodigoPostalLabel.TabIndex = 25
        CodigoPostalLabel.Text = "Código Postal:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(27, 354)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 27
        TelefonoLabel.Text = "Teléfono:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(27, 380)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 29
        FaxLabel.Text = "Fax:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Location = New System.Drawing.Point(27, 406)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(41, 13)
        CorreoLabel.TabIndex = 31
        CorreoLabel.Text = "Correo:"
        '
        'PaginaWebLabel
        '
        PaginaWebLabel.AutoSize = True
        PaginaWebLabel.Location = New System.Drawing.Point(27, 432)
        PaginaWebLabel.Name = "PaginaWebLabel"
        PaginaWebLabel.Size = New System.Drawing.Size(69, 13)
        PaginaWebLabel.TabIndex = 33
        PaginaWebLabel.Text = "Página Web:"
        '
        'EstadoIdLabel
        '
        EstadoIdLabel.AutoSize = True
        EstadoIdLabel.Location = New System.Drawing.Point(27, 458)
        EstadoIdLabel.Name = "EstadoIdLabel"
        EstadoIdLabel.Size = New System.Drawing.Size(43, 13)
        EstadoIdLabel.TabIndex = 35
        EstadoIdLabel.Text = "Estado:"
        '
        'LogotipoLabel
        '
        LogotipoLabel.AutoSize = True
        LogotipoLabel.Location = New System.Drawing.Point(415, 10)
        LogotipoLabel.Name = "LogotipoLabel"
        LogotipoLabel.Size = New System.Drawing.Size(51, 13)
        LogotipoLabel.TabIndex = 40
        LogotipoLabel.Text = "Logotipo:"
        '
        'RegistroPatronalLabel
        '
        RegistroPatronalLabel.AutoSize = True
        RegistroPatronalLabel.Location = New System.Drawing.Point(27, 118)
        RegistroPatronalLabel.Name = "RegistroPatronalLabel"
        RegistroPatronalLabel.Size = New System.Drawing.Size(91, 13)
        RegistroPatronalLabel.TabIndex = 44
        RegistroPatronalLabel.Text = "Registro Patronal:"
        '
        'EmisorBindingNavigator
        '
        Me.EmisorBindingNavigator.AddNewItem = Nothing
        Me.EmisorBindingNavigator.BindingSource = Me.EmisorBindingSource
        Me.EmisorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmisorBindingNavigator.DeleteItem = Nothing
        Me.EmisorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.EmisorBindingNavigatorSaveItem})
        Me.EmisorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmisorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmisorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmisorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmisorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmisorBindingNavigator.Name = "EmisorBindingNavigator"
        Me.EmisorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmisorBindingNavigator.Size = New System.Drawing.Size(740, 25)
        Me.EmisorBindingNavigator.TabIndex = 0
        Me.EmisorBindingNavigator.Text = "BindingNavigator1"
        '
        'EmisorBindingSource
        '
        Me.EmisorBindingSource.DataMember = "Emisor"
        Me.EmisorBindingSource.DataSource = Me.MainDBDataSet
        '
        'MainDBDataSet
        '
        Me.MainDBDataSet.DataSetName = "MainDBDataSet"
        Me.MainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'EmisorBindingNavigatorSaveItem
        '
        Me.EmisorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmisorBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmisorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmisorBindingNavigatorSaveItem.Name = "EmisorBindingNavigatorSaveItem"
        Me.EmisorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmisorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'RFCTextBox
        '
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "RFC", True))
        Me.RFCTextBox.Location = New System.Drawing.Point(129, 9)
        Me.RFCTextBox.MaxLength = 13
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RFCTextBox.TabIndex = 1
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(129, 35)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(248, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'NombreComercialTextBox
        '
        Me.NombreComercialTextBox.BackColor = System.Drawing.Color.Silver
        Me.NombreComercialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "NombreComercial", True))
        Me.NombreComercialTextBox.Enabled = False
        Me.NombreComercialTextBox.Location = New System.Drawing.Point(129, 61)
        Me.NombreComercialTextBox.Name = "NombreComercialTextBox"
        Me.NombreComercialTextBox.Size = New System.Drawing.Size(248, 20)
        Me.NombreComercialTextBox.TabIndex = 4
        '
        'CURPTextBox
        '
        Me.CURPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "CURP", True))
        Me.CURPTextBox.Location = New System.Drawing.Point(129, 87)
        Me.CURPTextBox.Name = "CURPTextBox"
        Me.CURPTextBox.Size = New System.Drawing.Size(159, 20)
        Me.CURPTextBox.TabIndex = 5
        '
        'CalleTextBox
        '
        Me.CalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Calle", True))
        Me.CalleTextBox.Location = New System.Drawing.Point(129, 143)
        Me.CalleTextBox.Name = "CalleTextBox"
        Me.CalleTextBox.Size = New System.Drawing.Size(248, 20)
        Me.CalleTextBox.TabIndex = 7
        '
        'NoExtTextBox
        '
        Me.NoExtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "noExt", True))
        Me.NoExtTextBox.Location = New System.Drawing.Point(129, 169)
        Me.NoExtTextBox.Name = "NoExtTextBox"
        Me.NoExtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NoExtTextBox.TabIndex = 8
        '
        'NoIntTextBox
        '
        Me.NoIntTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "noInt", True))
        Me.NoIntTextBox.Location = New System.Drawing.Point(129, 195)
        Me.NoIntTextBox.Name = "NoIntTextBox"
        Me.NoIntTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NoIntTextBox.TabIndex = 9
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Colonia", True))
        Me.ColoniaTextBox.Location = New System.Drawing.Point(129, 221)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(248, 20)
        Me.ColoniaTextBox.TabIndex = 10
        '
        'LocalidadTextBox
        '
        Me.LocalidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Localidad", True))
        Me.LocalidadTextBox.Location = New System.Drawing.Point(129, 247)
        Me.LocalidadTextBox.Name = "LocalidadTextBox"
        Me.LocalidadTextBox.Size = New System.Drawing.Size(248, 20)
        Me.LocalidadTextBox.TabIndex = 11
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(129, 273)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(248, 20)
        Me.ReferenciaTextBox.TabIndex = 12
        '
        'MunicipioTextBox
        '
        Me.MunicipioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Municipio", True))
        Me.MunicipioTextBox.Location = New System.Drawing.Point(129, 299)
        Me.MunicipioTextBox.Name = "MunicipioTextBox"
        Me.MunicipioTextBox.Size = New System.Drawing.Size(248, 20)
        Me.MunicipioTextBox.TabIndex = 13
        '
        'CodigoPostalTextBox
        '
        Me.CodigoPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "CodigoPostal", True))
        Me.CodigoPostalTextBox.Location = New System.Drawing.Point(129, 325)
        Me.CodigoPostalTextBox.Name = "CodigoPostalTextBox"
        Me.CodigoPostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodigoPostalTextBox.TabIndex = 14
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(129, 351)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 15
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(129, 377)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FaxTextBox.TabIndex = 16
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "Correo", True))
        Me.CorreoTextBox.Location = New System.Drawing.Point(129, 403)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(248, 20)
        Me.CorreoTextBox.TabIndex = 17
        '
        'PaginaWebTextBox
        '
        Me.PaginaWebTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "PaginaWeb", True))
        Me.PaginaWebTextBox.Location = New System.Drawing.Point(129, 429)
        Me.PaginaWebTextBox.Name = "PaginaWebTextBox"
        Me.PaginaWebTextBox.Size = New System.Drawing.Size(248, 20)
        Me.PaginaWebTextBox.TabIndex = 18
        '
        'EmisorTableAdapter
        '
        Me.EmisorTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EmisorTableAdapter = Me.EmisorTableAdapter
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
        Me.TableAdapterManager.RegimenEmisorTableAdapter = Me.RegimenEmisorTableAdapter
        Me.TableAdapterManager.RegimenFiscalTableAdapter = Nothing
        Me.TableAdapterManager.RiesgoPuestoTableAdapter = Nothing
        Me.TableAdapterManager.SeparacionIndemnizacionTableAdapter = Nothing
        Me.TableAdapterManager.SeriesTableAdapter = Nothing
        Me.TableAdapterManager.StatusCompTableAdapter = Nothing
        Me.TableAdapterManager.SubsidioAlEmpleoTableAdapter = Nothing
        Me.TableAdapterManager.SucursalesTableAdapter = Nothing
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
        'RegimenEmisorTableAdapter
        '
        Me.RegimenEmisorTableAdapter.ClearBeforeFill = True
        '
        'RegimenEmisorBindingSource
        '
        Me.RegimenEmisorBindingSource.DataMember = "RegimenEmisor"
        Me.RegimenEmisorBindingSource.DataSource = Me.MainDBDataSet
        '
        'RegimenEmisorDataGridView
        '
        Me.RegimenEmisorDataGridView.AutoGenerateColumns = False
        Me.RegimenEmisorDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RegimenEmisorDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegimenEmisorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegimenEmisorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.RegimenEmisorDataGridView.DataSource = Me.RegimenEmisorBindingSource
        Me.RegimenEmisorDataGridView.Location = New System.Drawing.Point(415, 215)
        Me.RegimenEmisorDataGridView.Name = "RegimenEmisorDataGridView"
        Me.RegimenEmisorDataGridView.Size = New System.Drawing.Size(300, 261)
        Me.RegimenEmisorDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RegimenEmisorId"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RegimenFiscalId"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.RegimenFiscalBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Regimen"
        Me.DataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewTextBoxColumn2.HeaderText = "Régimen fiscal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "RegimenId"
        '
        'RegimenFiscalBindingSource
        '
        Me.RegimenFiscalBindingSource.DataMember = "RegimenFiscal"
        Me.RegimenFiscalBindingSource.DataSource = Me.MainDBDataSet
        '
        'RegimenFiscalTableAdapter
        '
        Me.RegimenFiscalTableAdapter.ClearBeforeFill = True
        '
        'EstadoIdComboBox
        '
        Me.EstadoIdComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmisorBindingSource, "EstadoId", True))
        Me.EstadoIdComboBox.DataSource = Me.EstadosBindingSource
        Me.EstadoIdComboBox.DisplayMember = "EstadoDesc"
        Me.EstadoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoIdComboBox.FormattingEnabled = True
        Me.EstadoIdComboBox.Location = New System.Drawing.Point(129, 455)
        Me.EstadoIdComboBox.Name = "EstadoIdComboBox"
        Me.EstadoIdComboBox.Size = New System.Drawing.Size(248, 21)
        Me.EstadoIdComboBox.TabIndex = 19
        Me.EstadoIdComboBox.ValueMember = "EstadoId"
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "Estados"
        Me.EstadosBindingSource.DataSource = Me.MainDBDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(412, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Régimen fiscal:"
        '
        'LogotipoPictureBox
        '
        Me.LogotipoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogotipoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmisorBindingSource, "Logotipo", True))
        Me.LogotipoPictureBox.Location = New System.Drawing.Point(415, 36)
        Me.LogotipoPictureBox.Name = "LogotipoPictureBox"
        Me.LogotipoPictureBox.Size = New System.Drawing.Size(305, 147)
        Me.LogotipoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogotipoPictureBox.TabIndex = 41
        Me.LogotipoPictureBox.TabStop = False
        '
        'EstadosTableAdapter
        '
        Me.EstadosTableAdapter.ClearBeforeFill = True
        '
        'SetLogoButton
        '
        Me.SetLogoButton.Image = CType(resources.GetObject("SetLogoButton.Image"), System.Drawing.Image)
        Me.SetLogoButton.Location = New System.Drawing.Point(473, 7)
        Me.SetLogoButton.Name = "SetLogoButton"
        Me.SetLogoButton.Size = New System.Drawing.Size(28, 23)
        Me.SetLogoButton.TabIndex = 42
        Me.SetLogoButton.UseVisualStyleBackColor = True
        '
        'ClearLogoButton
        '
        Me.ClearLogoButton.Image = CType(resources.GetObject("ClearLogoButton.Image"), System.Drawing.Image)
        Me.ClearLogoButton.Location = New System.Drawing.Point(507, 7)
        Me.ClearLogoButton.Name = "ClearLogoButton"
        Me.ClearLogoButton.Size = New System.Drawing.Size(30, 23)
        Me.ClearLogoButton.TabIndex = 43
        Me.ClearLogoButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "Archivos JPEG|*.jpg"
        Me.OpenFileDialog.RestoreDirectory = True
        Me.OpenFileDialog.Title = "Seleccione la imagen de su logotipo"
        '
        'NombreComercialCheckBox
        '
        Me.NombreComercialCheckBox.AutoSize = True
        Me.NombreComercialCheckBox.Location = New System.Drawing.Point(9, 63)
        Me.NombreComercialCheckBox.Name = "NombreComercialCheckBox"
        Me.NombreComercialCheckBox.Size = New System.Drawing.Size(114, 17)
        Me.NombreComercialCheckBox.TabIndex = 3
        Me.NombreComercialCheckBox.Text = "Nombre comercial:"
        Me.NombreComercialCheckBox.UseVisualStyleBackColor = True
        '
        'RegistroPatronalTextBox
        '
        Me.RegistroPatronalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmisorBindingSource, "RegistroPatronal", True))
        Me.RegistroPatronalTextBox.Location = New System.Drawing.Point(129, 115)
        Me.RegistroPatronalTextBox.MaxLength = 20
        Me.RegistroPatronalTextBox.Name = "RegistroPatronalTextBox"
        Me.RegistroPatronalTextBox.Size = New System.Drawing.Size(159, 20)
        Me.RegistroPatronalTextBox.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(740, 511)
        Me.TabControl1.TabIndex = 45
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(RFCLabel)
        Me.TabPage1.Controls.Add(RegistroPatronalLabel)
        Me.TabPage1.Controls.Add(EstadoIdLabel)
        Me.TabPage1.Controls.Add(Me.RegistroPatronalTextBox)
        Me.TabPage1.Controls.Add(Me.PaginaWebTextBox)
        Me.TabPage1.Controls.Add(Me.NombreComercialCheckBox)
        Me.TabPage1.Controls.Add(PaginaWebLabel)
        Me.TabPage1.Controls.Add(Me.ClearLogoButton)
        Me.TabPage1.Controls.Add(Me.CorreoTextBox)
        Me.TabPage1.Controls.Add(Me.SetLogoButton)
        Me.TabPage1.Controls.Add(CorreoLabel)
        Me.TabPage1.Controls.Add(LogotipoLabel)
        Me.TabPage1.Controls.Add(Me.FaxTextBox)
        Me.TabPage1.Controls.Add(Me.LogotipoPictureBox)
        Me.TabPage1.Controls.Add(FaxLabel)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TelefonoTextBox)
        Me.TabPage1.Controls.Add(Me.EstadoIdComboBox)
        Me.TabPage1.Controls.Add(TelefonoLabel)
        Me.TabPage1.Controls.Add(Me.RegimenEmisorDataGridView)
        Me.TabPage1.Controls.Add(Me.CodigoPostalTextBox)
        Me.TabPage1.Controls.Add(CodigoPostalLabel)
        Me.TabPage1.Controls.Add(Me.RFCTextBox)
        Me.TabPage1.Controls.Add(Me.MunicipioTextBox)
        Me.TabPage1.Controls.Add(NombreLabel)
        Me.TabPage1.Controls.Add(MunicipioLabel)
        Me.TabPage1.Controls.Add(Me.NombreTextBox)
        Me.TabPage1.Controls.Add(Me.ReferenciaTextBox)
        Me.TabPage1.Controls.Add(Me.NombreComercialTextBox)
        Me.TabPage1.Controls.Add(ReferenciaLabel)
        Me.TabPage1.Controls.Add(CURPLabel)
        Me.TabPage1.Controls.Add(Me.LocalidadTextBox)
        Me.TabPage1.Controls.Add(Me.CURPTextBox)
        Me.TabPage1.Controls.Add(LocalidadLabel)
        Me.TabPage1.Controls.Add(CalleLabel)
        Me.TabPage1.Controls.Add(Me.ColoniaTextBox)
        Me.TabPage1.Controls.Add(Me.CalleTextBox)
        Me.TabPage1.Controls.Add(ColoniaLabel)
        Me.TabPage1.Controls.Add(NoExtLabel)
        Me.TabPage1.Controls.Add(Me.NoIntTextBox)
        Me.TabPage1.Controls.Add(Me.NoExtTextBox)
        Me.TabPage1.Controls.Add(NoIntLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(732, 485)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del emisor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(732, 485)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Folios CFDI"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusFoliosDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TablaPreciosDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(726, 479)
        Me.SplitContainer1.SplitterDistance = 209
        Me.SplitContainer1.TabIndex = 6
        '
        'StatusFoliosDataGridView
        '
        Me.StatusFoliosDataGridView.AllowUserToAddRows = False
        Me.StatusFoliosDataGridView.AllowUserToDeleteRows = False
        Me.StatusFoliosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.StatusFoliosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StatusFoliosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Status, Me.Solicitados, Me.Restantes, Me.Desde, Me.Hasta, Me.Licencia, Me.Gratuitos})
        Me.StatusFoliosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusFoliosDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.StatusFoliosDataGridView.Location = New System.Drawing.Point(0, 27)
        Me.StatusFoliosDataGridView.Name = "StatusFoliosDataGridView"
        Me.StatusFoliosDataGridView.Size = New System.Drawing.Size(726, 182)
        Me.StatusFoliosDataGridView.TabIndex = 7
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'Solicitados
        '
        Me.Solicitados.DataPropertyName = "Solicitados"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Solicitados.DefaultCellStyle = DataGridViewCellStyle2
        Me.Solicitados.HeaderText = "Solicitados"
        Me.Solicitados.Name = "Solicitados"
        Me.Solicitados.Width = 70
        '
        'Restantes
        '
        Me.Restantes.DataPropertyName = "Restantes"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Restantes.DefaultCellStyle = DataGridViewCellStyle3
        Me.Restantes.HeaderText = "Restantes"
        Me.Restantes.Name = "Restantes"
        Me.Restantes.Width = 70
        '
        'Desde
        '
        Me.Desde.DataPropertyName = "Desde"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Desde.DefaultCellStyle = DataGridViewCellStyle4
        Me.Desde.HeaderText = "Desde"
        Me.Desde.Name = "Desde"
        Me.Desde.Width = 70
        '
        'Hasta
        '
        Me.Hasta.DataPropertyName = "Hasta"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Hasta.DefaultCellStyle = DataGridViewCellStyle5
        Me.Hasta.HeaderText = "Hasta"
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Width = 70
        '
        'Licencia
        '
        Me.Licencia.DataPropertyName = "LICENCIA"
        Me.Licencia.HeaderText = "Licencia"
        Me.Licencia.Name = "Licencia"
        Me.Licencia.Visible = False
        '
        'Gratuitos
        '
        Me.Gratuitos.DataPropertyName = "Gratuitos"
        Me.Gratuitos.HeaderText = "Gratuitos"
        Me.Gratuitos.Name = "Gratuitos"
        Me.Gratuitos.Width = 60
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(726, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "STATUS DE FOLIOS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TablaPreciosDataGridView
        '
        Me.TablaPreciosDataGridView.AllowUserToAddRows = False
        Me.TablaPreciosDataGridView.AllowUserToDeleteRows = False
        Me.TablaPreciosDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TablaPreciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaPreciosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrecioId, Me.Precio, Me.Folios, Me.Descripcion, Me.Solicitar})
        Me.TablaPreciosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaPreciosDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TablaPreciosDataGridView.Location = New System.Drawing.Point(0, 51)
        Me.TablaPreciosDataGridView.Name = "TablaPreciosDataGridView"
        Me.TablaPreciosDataGridView.RowTemplate.Height = 30
        Me.TablaPreciosDataGridView.Size = New System.Drawing.Size(726, 215)
        Me.TablaPreciosDataGridView.TabIndex = 0
        '
        'PrecioId
        '
        Me.PrecioId.DataPropertyName = "PrecioId"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.PrecioId.DefaultCellStyle = DataGridViewCellStyle6
        Me.PrecioId.HeaderText = "ID"
        Me.PrecioId.Name = "PrecioId"
        Me.PrecioId.ReadOnly = True
        Me.PrecioId.Width = 40
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle7
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 75
        '
        'Folios
        '
        Me.Folios.DataPropertyName = "Folios"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Folios.DefaultCellStyle = DataGridViewCellStyle8
        Me.Folios.HeaderText = "Folios"
        Me.Folios.Name = "Folios"
        Me.Folios.Width = 60
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle9
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        '
        'Solicitar
        '
        Me.Solicitar.HeaderText = "Solicitar"
        Me.Solicitar.Name = "Solicitar"
        Me.Solicitar.Text = "Solicitar"
        Me.Solicitar.UseColumnTextForButtonValue = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(0, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(726, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Seleccione un paquete de la lista y haga clic en ""Solicitar"""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Navy
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(726, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SOLICITAR MÁS FOLIOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmEmisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 536)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.EmisorBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEmisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos Generales"
        CType(Me.EmisorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmisorBindingNavigator.ResumeLayout(False)
        Me.EmisorBindingNavigator.PerformLayout()
        CType(Me.EmisorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegimenEmisorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegimenEmisorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegimenFiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogotipoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.StatusFoliosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaPreciosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainDBDataSet As MobileNOMv2.MainDBDataSet
    Friend WithEvents EmisorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmisorTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.EmisorTableAdapter
    Friend WithEvents TableAdapterManager As MobileNOMv2.MainDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmisorBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmisorBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RFCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreComercialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CURPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoExtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoIntTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColoniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocalidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MunicipioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoPostalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CorreoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaginaWebTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegimenEmisorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegimenEmisorTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.RegimenEmisorTableAdapter
    Friend WithEvents RegimenEmisorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RegimenFiscalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegimenFiscalTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.RegimenFiscalTableAdapter
    Friend WithEvents EstadoIdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LogotipoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents EstadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstadosTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.EstadosTableAdapter
    Friend WithEvents SetLogoButton As System.Windows.Forms.Button
    Friend WithEvents ClearLogoButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NombreComercialCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents RegistroPatronalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TablaPreciosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusFoliosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solicitados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Restantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Licencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gratuitos As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PrecioId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Folios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solicitar As System.Windows.Forms.DataGridViewButtonColumn
End Class
