<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivacion))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SerieMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ActivarButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Por favor ingrese su número de activación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'SerieMaskedTextBox
        '
        Me.SerieMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerieMaskedTextBox.Location = New System.Drawing.Point(76, 56)
        Me.SerieMaskedTextBox.Mask = "0000-000000-0000"
        Me.SerieMaskedTextBox.Name = "SerieMaskedTextBox"
        Me.SerieMaskedTextBox.Size = New System.Drawing.Size(166, 29)
        Me.SerieMaskedTextBox.TabIndex = 7
        '
        'ActivarButton
        '
        Me.ActivarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivarButton.Image = CType(resources.GetObject("ActivarButton.Image"), System.Drawing.Image)
        Me.ActivarButton.Location = New System.Drawing.Point(251, 55)
        Me.ActivarButton.Name = "ActivarButton"
        Me.ActivarButton.Size = New System.Drawing.Size(100, 36)
        Me.ActivarButton.TabIndex = 8
        Me.ActivarButton.Text = "Activar"
        Me.ActivarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ActivarButton.UseVisualStyleBackColor = True
        '
        'frmActivacion
        '
        Me.AcceptButton = Me.ActivarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 118)
        Me.Controls.Add(Me.ActivarButton)
        Me.Controls.Add(Me.SerieMaskedTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmActivacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Activación de producto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SerieMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ActivarButton As System.Windows.Forms.Button
End Class
