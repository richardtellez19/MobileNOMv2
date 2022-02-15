Public Class frmActivacion
    Dim Cancel As Boolean = True

    Private Sub ActivarButton_Click(sender As System.Object, e As System.EventArgs) Handles ActivarButton.Click
        Dim inNoSerie As String = SerieMaskedTextBox.Text.ToUpper
        If inNoSerie = "" Then
            MsgBox("¡No se ingresó el Número de Serie!" & vbCrLf & "Sin este número no podrá autorizar la licencia del producto.", MsgBoxStyle.Information, "Autorización de Licencia")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
            Exit Sub
        End If

        Try
            Dim wsLicencia As New Licencias.Service1
            Dim ds As DataSet = wsLicencia.PermLicencia(inNoSerie, "")
            Dim fila As DataRow = ds.Tables(0).Rows(0)
            If Trim(fila("Mensaje")) = "AUTORIZADO" Then
                SaveSetting("MobileNOMv2", "Datos", "NoSerie", inNoSerie)
                SaveSetting("MobileNOMv2", "Datos", "NoLicencia", fila("LICENCIA").ToString)
                SaveSetting("MobileNOMv2", "Datos", "ModoTest", 0)
                TestFlag = False
            Else
                MsgBox(fila("MENSAJE"), MsgBoxStyle.Exclamation, "Autorización de Licencia")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("¡No se pudo conectar con el servidor!" & vbCrLf & "Sin esto no podrá autorizar la licencia del producto.", MsgBoxStyle.Exclamation, "Autorización de Licencia")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
            Exit Sub
        End Try

        Cancel = False
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmActivacion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Cancel Then Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmActivacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class