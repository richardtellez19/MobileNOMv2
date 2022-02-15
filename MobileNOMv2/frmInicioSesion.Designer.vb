<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSesion))
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.EmpresasListBox = New System.Windows.Forms.ListBox()
        Me.CrearEmpresaButton = New System.Windows.Forms.Button()
        Me.CargarExistenteButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.IniciarButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmpresasListBox
        '
        Me.EmpresasListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpresasListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresasListBox.FormattingEnabled = True
        Me.EmpresasListBox.ItemHeight = 16
        Me.EmpresasListBox.Location = New System.Drawing.Point(0, 169)
        Me.EmpresasListBox.Name = "EmpresasListBox"
        Me.EmpresasListBox.Size = New System.Drawing.Size(507, 118)
        Me.EmpresasListBox.TabIndex = 0
        '
        'CrearEmpresaButton
        '
        Me.CrearEmpresaButton.Image = CType(resources.GetObject("CrearEmpresaButton.Image"), System.Drawing.Image)
        Me.CrearEmpresaButton.Location = New System.Drawing.Point(3, 8)
        Me.CrearEmpresaButton.Name = "CrearEmpresaButton"
        Me.CrearEmpresaButton.Size = New System.Drawing.Size(114, 33)
        Me.CrearEmpresaButton.TabIndex = 1
        Me.CrearEmpresaButton.Text = "Crear empresa"
        Me.CrearEmpresaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CrearEmpresaButton.UseVisualStyleBackColor = True
        '
        'CargarExistenteButton
        '
        Me.CargarExistenteButton.Image = CType(resources.GetObject("CargarExistenteButton.Image"), System.Drawing.Image)
        Me.CargarExistenteButton.Location = New System.Drawing.Point(123, 8)
        Me.CargarExistenteButton.Name = "CargarExistenteButton"
        Me.CargarExistenteButton.Size = New System.Drawing.Size(123, 33)
        Me.CargarExistenteButton.TabIndex = 2
        Me.CargarExistenteButton.Text = "Cargar existente"
        Me.CargarExistenteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CargarExistenteButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'IniciarButton
        '
        Me.IniciarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IniciarButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IniciarButton.Image = CType(resources.GetObject("IniciarButton.Image"), System.Drawing.Image)
        Me.IniciarButton.Location = New System.Drawing.Point(391, 8)
        Me.IniciarButton.Name = "IniciarButton"
        Me.IniciarButton.Size = New System.Drawing.Size(102, 33)
        Me.IniciarButton.TabIndex = 3
        Me.IniciarButton.Text = "Iniciar"
        Me.IniciarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IniciarButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(507, 146)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CrearEmpresaButton)
        Me.Panel1.Controls.Add(Me.IniciarButton)
        Me.Panel1.Controls.Add(Me.CargarExistenteButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 287)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 53)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Seleccione la empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(284, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "TeamViewer"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmInicioSesion
        '
        Me.AcceptButton = Me.IniciarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 340)
        Me.Controls.Add(Me.EmpresasListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de empresa"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents EmpresasListBox As System.Windows.Forms.ListBox
    Friend WithEvents CrearEmpresaButton As System.Windows.Forms.Button
    Friend WithEvents CargarExistenteButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents IniciarButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
