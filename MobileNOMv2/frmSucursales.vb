Public Class frmSucursales

    Private Sub SucursalesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SucursalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SucursalesBindingSource.EndEdit()
        'Dim Pos As Integer = SucursalesBindingSource.Position
        Me.TableAdapterManager.UpdateAll(Me.MainDBDataSet)
        'SucursalesBindingSource.Position = Pos
        Me.SucursalesTableAdapter.FillBy(Me.MainDBDataSet.Sucursales)
        Me.SeriesTableAdapter.FillBy(Me.MainDBDataSet.Series)
    End Sub

    Private Sub frmSucursales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.TiposCfdi' Puede moverla o quitarla según sea necesario.
        Me.TiposCfdiTableAdapter.Fill(Me.MainDBDataSet.TiposCfdi)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Estados' Puede moverla o quitarla según sea necesario.
        Me.EstadosTableAdapter.Fill(Me.MainDBDataSet.Estados)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Series' Puede moverla o quitarla según sea necesario.
        Me.SeriesTableAdapter.Fill(Me.MainDBDataSet.Series)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.MainDBDataSet.Sucursales)

    End Sub

    Private Sub SucursalesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SucursalesDataGridView.CellClick
        If SucursalesDataGridView.IsCurrentRowDirty Then Exit Sub

        Select Case SucursalesDataGridView.Columns(e.ColumnIndex).Name
            Case "AddCert"
                Dim Sucursal As DataRowView = SucursalesBindingSource.Current
                Dim Pos As Integer = SucursalesBindingSource.Position
                Dim Formulario As New frmAddCert(Sucursal("SucursalId"))
                Formulario.ShowDialog()
                Me.SucursalesTableAdapter.FillBy(Me.MainDBDataSet.Sucursales)
                SucursalesBindingSource.Position = Pos
        End Select
    End Sub
End Class