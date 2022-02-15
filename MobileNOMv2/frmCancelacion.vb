Public Class frmCancelacion
    Public idReceptor As Long
    Public motivo As String
    Private Sub comboMotivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboMotivos.SelectedIndexChanged
        motivo = comboMotivos.SelectedItem.ToString.Substring(0, 2)
        If motivo = "01" Then
            labelRelacion.Visible = True
            comboRelacion.Visible = True
            labelFolioFiscal.Visible = True
            textFolioFiscal.Visible = True
        Else
            labelFolioFiscal.Visible = False
            labelRelacion.Visible = False
            comboRelacion.Visible = False
            textFolioFiscal.Visible = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim frmMain As frmMain = CType(Owner, frmMain)
        frmMain.procedeCancelacion = False
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim frmMain As frmMain = CType(Owner, frmMain)
        frmMain.procedeCancelacion = True
        frmMain.motivoCancelacion = comboMotivos.SelectedItem.ToString.Substring(0, 2)
        If motivo = "01" Then
            If String.IsNullOrEmpty(textFolioFiscal.Text) Then
                MessageBox.Show("Se eligió relación 01, se debe relacionar un CFDI")
                Exit Sub
            Else
                frmMain.uuidRelacion = textFolioFiscal.Text
            End If
        End If
        Me.Dispose()
    End Sub
End Class