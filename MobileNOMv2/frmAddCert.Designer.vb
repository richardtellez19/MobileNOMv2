<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCert
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
        Me.MainDBDataSet = New MobileNOMv2.MainDBDataSet()
        Me.SucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SucursalesTableAdapter = New MobileNOMv2.MainDBDataSetTableAdapters.SucursalesTableAdapter()
        Me.TableAdapterManager = New MobileNOMv2.MainDBDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CSDTextBox = New System.Windows.Forms.TextBox()
        Me.KeyTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExaminarCSDButton = New System.Windows.Forms.Button()
        Me.ExaminarKEYButton = New System.Windows.Forms.Button()
        Me.ValidarButton = New System.Windows.Forms.Button()
        Me.PFXTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PFXListView = New System.Windows.Forms.ListView()
        Me.AtributoColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ValorColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AplicarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.SeriesTableAdapter = Nothing
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Certificado de Sello Digital (*.cer)"
        '
        'CSDTextBox
        '
        Me.CSDTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CSDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SucursalesBindingSource, "CSD", True))
        Me.CSDTextBox.Enabled = False
        Me.CSDTextBox.Location = New System.Drawing.Point(13, 30)
        Me.CSDTextBox.Name = "CSDTextBox"
        Me.CSDTextBox.Size = New System.Drawing.Size(415, 20)
        Me.CSDTextBox.TabIndex = 1
        '
        'KeyTextBox
        '
        Me.KeyTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SucursalesBindingSource, "KEY", True))
        Me.KeyTextBox.Enabled = False
        Me.KeyTextBox.Location = New System.Drawing.Point(13, 84)
        Me.KeyTextBox.Name = "KeyTextBox"
        Me.KeyTextBox.Size = New System.Drawing.Size(415, 20)
        Me.KeyTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Llave pública (*.key)"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SucursalesBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(12, 140)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(416, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña de la llave"
        '
        'ExaminarCSDButton
        '
        Me.ExaminarCSDButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExaminarCSDButton.Location = New System.Drawing.Point(434, 30)
        Me.ExaminarCSDButton.Name = "ExaminarCSDButton"
        Me.ExaminarCSDButton.Size = New System.Drawing.Size(89, 20)
        Me.ExaminarCSDButton.TabIndex = 1
        Me.ExaminarCSDButton.Text = "Examinar"
        Me.ExaminarCSDButton.UseVisualStyleBackColor = True
        '
        'ExaminarKEYButton
        '
        Me.ExaminarKEYButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExaminarKEYButton.Location = New System.Drawing.Point(434, 84)
        Me.ExaminarKEYButton.Name = "ExaminarKEYButton"
        Me.ExaminarKEYButton.Size = New System.Drawing.Size(89, 20)
        Me.ExaminarKEYButton.TabIndex = 2
        Me.ExaminarKEYButton.Text = "Examinar"
        Me.ExaminarKEYButton.UseVisualStyleBackColor = True
        '
        'ValidarButton
        '
        Me.ValidarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ValidarButton.Location = New System.Drawing.Point(434, 140)
        Me.ValidarButton.Name = "ValidarButton"
        Me.ValidarButton.Size = New System.Drawing.Size(89, 20)
        Me.ValidarButton.TabIndex = 4
        Me.ValidarButton.Text = "Validar"
        Me.ValidarButton.UseVisualStyleBackColor = True
        '
        'PFXTextBox
        '
        Me.PFXTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PFXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SucursalesBindingSource, "PFX", True))
        Me.PFXTextBox.Enabled = False
        Me.PFXTextBox.Location = New System.Drawing.Point(13, 206)
        Me.PFXTextBox.Name = "PFXTextBox"
        Me.PFXTextBox.Size = New System.Drawing.Size(416, 20)
        Me.PFXTextBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Archivo PFX"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Información del certificado"
        '
        'PFXListView
        '
        Me.PFXListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PFXListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AtributoColumnHeader, Me.ValorColumnHeader})
        Me.PFXListView.Location = New System.Drawing.Point(13, 261)
        Me.PFXListView.Name = "PFXListView"
        Me.PFXListView.Size = New System.Drawing.Size(415, 164)
        Me.PFXListView.TabIndex = 12
        Me.PFXListView.UseCompatibleStateImageBehavior = False
        Me.PFXListView.View = System.Windows.Forms.View.Details
        '
        'AtributoColumnHeader
        '
        Me.AtributoColumnHeader.Text = "Atributo"
        Me.AtributoColumnHeader.Width = 150
        '
        'ValorColumnHeader
        '
        Me.ValorColumnHeader.Text = "Valor"
        Me.ValorColumnHeader.Width = 200
        '
        'AplicarButton
        '
        Me.AplicarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AplicarButton.Location = New System.Drawing.Point(434, 363)
        Me.AplicarButton.Name = "AplicarButton"
        Me.AplicarButton.Size = New System.Drawing.Size(89, 36)
        Me.AplicarButton.TabIndex = 5
        Me.AplicarButton.Text = "Aplicar"
        Me.AplicarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelarButton.Location = New System.Drawing.Point(434, 405)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(89, 20)
        Me.CancelarButton.TabIndex = 6
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'frmAddCert
        '
        Me.AcceptButton = Me.AplicarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelarButton
        Me.ClientSize = New System.Drawing.Size(531, 437)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AplicarButton)
        Me.Controls.Add(Me.PFXListView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PFXTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ValidarButton)
        Me.Controls.Add(Me.ExaminarKEYButton)
        Me.Controls.Add(Me.ExaminarCSDButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.KeyTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CSDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddCert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Información del Certificado de Sello Digital"
        CType(Me.MainDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainDBDataSet As MobileNOMv2.MainDBDataSet
    Friend WithEvents SucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SucursalesTableAdapter As MobileNOMv2.MainDBDataSetTableAdapters.SucursalesTableAdapter
    Friend WithEvents TableAdapterManager As MobileNOMv2.MainDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CSDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExaminarCSDButton As System.Windows.Forms.Button
    Friend WithEvents ExaminarKEYButton As System.Windows.Forms.Button
    Friend WithEvents ValidarButton As System.Windows.Forms.Button
    Friend WithEvents PFXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PFXListView As System.Windows.Forms.ListView
    Friend WithEvents AtributoColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents ValorColumnHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents AplicarButton As System.Windows.Forms.Button
    Friend WithEvents CancelarButton As System.Windows.Forms.Button
End Class
