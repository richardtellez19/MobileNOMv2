Imports System.Net.Mail

Public Class frmEmisor

    Private Sub EmisorBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmisorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmisorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDBDataSet)

        Me.EmisorTableAdapter.FillBy(Me.MainDBDataSet.Emisor)
        Me.RegimenEmisorTableAdapter.FillBy(Me.MainDBDataSet.RegimenEmisor)
    End Sub

    Private Sub frmEmisor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Estados' Puede moverla o quitarla según sea necesario.
        Me.EstadosTableAdapter.Fill(Me.MainDBDataSet.Estados)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.RegimenFiscal' Puede moverla o quitarla según sea necesario.
        Me.RegimenFiscalTableAdapter.Fill(Me.MainDBDataSet.RegimenFiscal)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.RegimenEmisor' Puede moverla o quitarla según sea necesario.
        Me.RegimenEmisorTableAdapter.Fill(Me.MainDBDataSet.RegimenEmisor)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Emisor' Puede moverla o quitarla según sea necesario.
        Me.EmisorTableAdapter.Fill(Me.MainDBDataSet.Emisor)

        If EmisorBindingSource.Count = 0 Then
            EmisorBindingSource.AddNew()
        Else
            If NombreTextBox.Text = NombreComercialTextBox.Text Then
                NombreComercialCheckBox.Checked = False
            Else
                NombreComercialCheckBox.Checked = True
            End If
        End If

        ObtieneTablaPrecios()
        ObtieneStatusFolios()
    End Sub

    Private Sub ObtieneTablaPrecios()
        Try
            Dim ws As New Licencias.Service1
            TablaPreciosDataGridView.DataSource = ws.TablaPrecios.Tables(0)
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub ObtieneStatusFolios()
        Try
            Dim ws As New Licencias.Service1
            Dim StatusFoliosBindigSource As New BindingSource
            StatusFoliosBindigSource.DataSource = ws.StatusFolios(RFCTextBox.Text).Tables(0)
            StatusFoliosDataGridView.DataSource = StatusFoliosBindigSource
            StatusFoliosBindigSource.Sort = "Hasta DESC"
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub SetLogoButton_Click(sender As System.Object, e As System.EventArgs) Handles SetLogoButton.Click
        OpenFileDialog.ShowDialog()

        LogotipoPictureBox.Load(OpenFileDialog.FileName)
    End Sub

    Private Sub NombreTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles NombreTextBox.TextChanged
        If Not NombreComercialCheckBox.Checked Then
            NombreComercialTextBox.Text = NombreTextBox.Text
        End If
    End Sub

    Private Sub NombreComercialCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles NombreComercialCheckBox.CheckedChanged
        If NombreComercialCheckBox.Checked Then
            NombreComercialTextBox.Enabled = True
            NombreComercialTextBox.BackColor = Color.White
        Else
            NombreComercialTextBox.Enabled = False
            NombreComercialTextBox.BackColor = Color.Silver
            NombreComercialTextBox.Text = NombreTextBox.Text
        End If
    End Sub

    Private Sub ClearLogoButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearLogoButton.Click
        LogotipoPictureBox.Image = Nothing
    End Sub

    Private Sub TablaPreciosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TablaPreciosDataGridView.CellClick
        Select Case TablaPreciosDataGridView.Columns(e.ColumnIndex).Name
            Case "Solicitar"
                If MsgBox("¿Está seguro de solicitar " & TablaPreciosDataGridView.Rows(e.RowIndex).Cells("Folios").Value & " folios?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If

                Try
                    Dim ws As New Licencias.Service1
                    ws.SolicitarFolios(TablaPreciosDataGridView.Rows(e.RowIndex).Cells("Folios").Value, NoLicencia, RFCTextBox.Text, False)
                    Dim StatusFoliosBindigSource As New BindingSource
                    StatusFoliosBindigSource.DataSource = ws.StatusFolios(RFCTextBox.Text).Tables(0)
                    StatusFoliosDataGridView.DataSource = StatusFoliosBindigSource
                    StatusFoliosBindigSource.Sort = "Hasta DESC"

                    Try
                        Dim Correo As New MailMessage
                        Dim Cliente As New SmtpClient

                        Correo.From = New MailAddress(IIf(CorreoTextBox.Text = "", "servicioaclientes@mobilemetriks.com", CorreoTextBox.Text))
                        Correo.To.Add("ventas@mobilemetriks.com")
                        Correo.Subject = "Solicitud de folios " & RFCTextBox.Text
                        Correo.Body = String.Format("Aplicación: {1}{0}Solicitante: {2}{0}RFC:{3}{0}Solicitud: {4}{0}Fecha: {5}", vbCrLf, "MobileNOMv2", NombreTextBox.Text, RFCTextBox.Text, TablaPreciosDataGridView.Rows(e.RowIndex).Cells("Descripcion").Value, Format(Now, "dd/MM/yyy"))
                        Cliente.Host = "mail.mobilemetriks.com"
                        Cliente.Port = 587
                        Cliente.Credentials = New System.Net.NetworkCredential("comprobante-electronico@mobilemetriks.com", "cfdisaf2014")
                        Cliente.Send(Correo)
                    Catch ex As Exception
                        Exit Try
                    End Try

                    MsgBox("Sus folios han sido solicitados. Favor de enviar su comprobante de pago a alguno de nuestros ejecutivos.", MsgBoxStyle.Information, "Solicitud exitosa")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al conectar con servidor")
                End Try
        End Select
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        ObtieneStatusFolios()
    End Sub
End Class