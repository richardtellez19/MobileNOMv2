<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelacion
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
        Me.textFolioFiscal = New System.Windows.Forms.TextBox()
        Me.labelFolioFiscal = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.labelRelacion = New System.Windows.Forms.Label()
        Me.comboRelacion = New System.Windows.Forms.ComboBox()
        Me.labelMotivo = New System.Windows.Forms.Label()
        Me.labelTitulo = New System.Windows.Forms.Label()
        Me.comboMotivos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'textFolioFiscal
        '
        Me.textFolioFiscal.Location = New System.Drawing.Point(23, 182)
        Me.textFolioFiscal.Name = "textFolioFiscal"
        Me.textFolioFiscal.ReadOnly = True
        Me.textFolioFiscal.Size = New System.Drawing.Size(290, 20)
        Me.textFolioFiscal.TabIndex = 18
        Me.textFolioFiscal.Visible = False
        '
        'labelFolioFiscal
        '
        Me.labelFolioFiscal.AutoSize = True
        Me.labelFolioFiscal.Location = New System.Drawing.Point(23, 161)
        Me.labelFolioFiscal.Name = "labelFolioFiscal"
        Me.labelFolioFiscal.Size = New System.Drawing.Size(97, 13)
        Me.labelFolioFiscal.TabIndex = 17
        Me.labelFolioFiscal.Text = "UUID Relacionado"
        Me.labelFolioFiscal.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(210, 215)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(103, 38)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Regresar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(23, 215)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(103, 38)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'labelRelacion
        '
        Me.labelRelacion.AutoSize = True
        Me.labelRelacion.Location = New System.Drawing.Point(23, 111)
        Me.labelRelacion.Name = "labelRelacion"
        Me.labelRelacion.Size = New System.Drawing.Size(96, 13)
        Me.labelRelacion.TabIndex = 14
        Me.labelRelacion.Text = "CFDI que sustituye"
        Me.labelRelacion.Visible = False
        '
        'comboRelacion
        '
        Me.comboRelacion.DisplayMember = "NoFact"
        Me.comboRelacion.FormattingEnabled = True
        Me.comboRelacion.Location = New System.Drawing.Point(23, 132)
        Me.comboRelacion.Name = "comboRelacion"
        Me.comboRelacion.Size = New System.Drawing.Size(113, 21)
        Me.comboRelacion.TabIndex = 13
        Me.comboRelacion.ValueMember = "UUID"
        Me.comboRelacion.Visible = False
        '
        'labelMotivo
        '
        Me.labelMotivo.AutoSize = True
        Me.labelMotivo.Location = New System.Drawing.Point(23, 61)
        Me.labelMotivo.Name = "labelMotivo"
        Me.labelMotivo.Size = New System.Drawing.Size(116, 13)
        Me.labelMotivo.TabIndex = 12
        Me.labelMotivo.Text = "Motivo de Cancelación"
        '
        'labelTitulo
        '
        Me.labelTitulo.AutoSize = True
        Me.labelTitulo.Location = New System.Drawing.Point(23, 29)
        Me.labelTitulo.Name = "labelTitulo"
        Me.labelTitulo.Size = New System.Drawing.Size(125, 13)
        Me.labelTitulo.TabIndex = 11
        Me.labelTitulo.Text = "Cancelando Folio Fiscal: "
        '
        'comboMotivos
        '
        Me.comboMotivos.FormattingEnabled = True
        Me.comboMotivos.Items.AddRange(New Object() {"01 - Comprobantes emitidos con errores con relación.", "02 - Comprobantes emitidos con errores sin relación.", "03 - No se llevó a cabo la operación.", "04 - Operación nominativa relacionada en una factura global."})
        Me.comboMotivos.Location = New System.Drawing.Point(23, 82)
        Me.comboMotivos.Name = "comboMotivos"
        Me.comboMotivos.Size = New System.Drawing.Size(290, 21)
        Me.comboMotivos.TabIndex = 10
        '
        'frmCancelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 299)
        Me.Controls.Add(Me.textFolioFiscal)
        Me.Controls.Add(Me.labelFolioFiscal)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.labelRelacion)
        Me.Controls.Add(Me.comboRelacion)
        Me.Controls.Add(Me.labelMotivo)
        Me.Controls.Add(Me.labelTitulo)
        Me.Controls.Add(Me.comboMotivos)
        Me.Name = "frmCancelacion"
        Me.Text = "frmCancelacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textFolioFiscal As TextBox
    Friend WithEvents labelFolioFiscal As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents labelRelacion As Label
    Friend WithEvents comboRelacion As ComboBox
    Friend WithEvents labelMotivo As Label
    Friend WithEvents labelTitulo As Label
    Friend WithEvents comboMotivos As ComboBox
End Class
