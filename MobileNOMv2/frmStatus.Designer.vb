<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatus))
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstStatus
        '
        Me.lstStatus.FormattingEnabled = True
        Me.lstStatus.Location = New System.Drawing.Point(1, 12)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(281, 238)
        Me.lstStatus.TabIndex = 0
        '
        'frmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lstStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(12, 12)
        Me.Name = "frmStatus"
        Me.Text = "Emisión de CFDI"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstStatus As ListBox
End Class
