Imports System.Net.Mail
Imports System.Xml
Imports System.Net
Imports SW.Services.Status
Imports SW.Services.Cancelation
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports System.Deployment.Application

Public Class frmMain
    Public procedeCancelacion As Boolean = False
    Public uuidRelacion As String
    Public motivoCancelacion As String
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim nVersion As String
        Try
            nVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Catch ex As Exception
            nVersion = "1.0"
        End Try

        Dim Activacion As New frmActivacion
        Dim novedad As String = "- Nuevo esquema de Cancelación"

        If NoLicencia = "" Then
            If Activacion.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Me.Close()
                Exit Sub
            End If
        End If

        If Not nVersion = Version Then
            NovedadActualizacion(nVersion, novedad)
            actualizaBD()
        End If


        Dim InicioSesion As New frmInicioSesion

        If InicioSesion.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Me.Close()
            Exit Sub
        End If

        InicioSesion.Dispose()
        Activacion.Dispose()
        Me.Text = "MobileNOMv2 - " & BaseDatos

        If TestFlag Then
            StatusStrip1.BackColor = Color.Red
        Else
            StatusStrip1.BackColor = Color.SteelBlue
        End If



        'My.Settings.Item("MainDBConnectionString") = "Data Source=|DataDirectory|\DB\MainDB-Copy.sdf;Password=mobilemetriks"

        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Empleados1' Puede moverla o quitarla según sea necesario.
        Me.Empleados1TableAdapter.Fill(Me.MainDBDataSet.Empleados1)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Emisor' Puede moverla o quitarla según sea necesario.
        Me.EmisorTableAdapter.Fill(Me.MainDBDataSet.Emisor)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Monedas' Puede moverla o quitarla según sea necesario.
        Me.MonedasTableAdapter.Fill(Me.MainDBDataSet.Monedas)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.MainDBDataSet.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Series' Puede moverla o quitarla según sea necesario.
        Me.SeriesTableAdapter.Fill(Me.MainDBDataSet.Series)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.StatusComp' Puede moverla o quitarla según sea necesario.
        Me.StatusCompTableAdapter.Fill(Me.MainDBDataSet.StatusComp)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Comprobantes' Puede moverla o quitarla según sea necesario.
        Me.ComprobantesTableAdapter.Fill(Me.MainDBDataSet.Comprobantes)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.MainDBDataSet.Sucursales)
        ObtieneStatusFolios()

    End Sub

    Private Sub ObtieneStatusFolios()
        Try
            Dim ws As New Licencias.Service1
            FoliosToolStripStatusLabel.Text = ws.ObtieneSysInfo(Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"))
        Catch ex As Exception
            FoliosToolStripStatusLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub ComprobantesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ComprobantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDBDataSet)

    End Sub

    Private Sub EmpleadosToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles EmpleadosToolStripButton.Click
        Dim Formulario As New frmEmpleados
        Formulario.ShowDialog()
        Me.ComprobantesTableAdapter.FillBy(Me.MainDBDataSet.Comprobantes)
        Me.Empleados1TableAdapter.Fill(Me.MainDBDataSet.Empleados1)
        Me.EmpleadosTableAdapter.Fill(Me.MainDBDataSet.Empleados)
        ObtieneStatusFolios()
    End Sub

    Private Sub GeneralesToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles GeneralesToolStripButton.Click
        Dim Formulario As New frmEmisor
        Formulario.ShowDialog()

        Me.EmisorTableAdapter.Fill(Me.MainDBDataSet.Emisor)
        ObtieneStatusFolios()
    End Sub

    Private Sub SucursalesToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles SucursalesToolStripButton.Click
        Dim Formulario As New frmSucursales
        Formulario.Show()
    End Sub

    Private Sub ComprobantesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ComprobantesDataGridView.CellClick
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        sender = CType(sender, DataGridView)

        Dim Comprobante As DataRowView = ComprobantesBindingSource.Current
        Dim CFDIsTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.CFDIsTableAdapter
        CFDIsTableAdapter.ClearBeforeFill = True
        CFDIsTableAdapter.FillBy(Me.MainDBDataSet.CFDIs, Comprobante("ComprobanteId"))

        Select Case sender.Columns(e.ColumnIndex).Name
            Case "VerPDF"
                ' Genera archivo PDF
                Dim Doc As New Xml.XmlDocument
                Doc.Load(New IO.MemoryStream(CType(Me.MainDBDataSet.CFDIs(0).Item("XML"), Byte())))
                Dim imagenCBB As New System.IO.MemoryStream
                GeneraCBB_1(imagenCBB, String.Format("?re={0}&rr={1}&tt={2:0000000000.000000}&id={3}", Doc.GetElementsByTagName("Emisor", "http://www.sat.gob.mx/cfd/3")(0).Attributes("rfc").Value, Doc.GetElementsByTagName("Receptor", "http://www.sat.gob.mx/cfd/3")(0).Attributes("rfc").Value, Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("total").Value, Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("UUID").Value))
                Me.MainDBDataSet.Adicionales.Rows.Clear()
                Dim Adicionales As DataRow = Me.MainDBDataSet.Adicionales.NewRow
                Adicionales("Serie") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("serie").Value
                Adicionales("Folio") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("folio").Value
                Adicionales("TipoNomina") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TipoNomina").Value
                Adicionales("FechaPago") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaPago").Value
                Adicionales("FechaInicialPago") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaInicialPago").Value
                Adicionales("FechaFinalPago") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaFinalPago").Value
                Adicionales("FechaEmision") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("fecha").Value
                Adicionales("FechaTimbrado") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("FechaTimbrado").Value
                Adicionales("FolioFiscal") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("UUID").Value
                Adicionales("CertificadoEmisor") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("noCertificado").Value
                Adicionales("CertificadoSAT") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("noCertificadoSAT").Value
                Adicionales("TotalPercepciones") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TotalPercepciones").Value
                Adicionales("TotalDeducciones") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TotalDeducciones").Value
                Adicionales("TotalOtrosPagos") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TotalOtrosPagos").Value
                Adicionales("Total") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("total").Value
                Adicionales("SelloCFDI") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("selloCFD").Value
                Adicionales("SelloSAT") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("selloSAT").Value
                Adicionales("CadenaOriginalTFD") = GeneraCadenaOriginalTFD(Doc)
                Adicionales("CBB") = imagenCBB.ToArray
                Me.MainDBDataSet.Adicionales.Rows.Add(Adicionales)

                Dim filaEmpleado As DataRow = Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0)
                For Each Columna As DataColumn In Me.MainDBDataSet.Tables("Empleados").Columns
                    If filaEmpleado(Columna) Is System.DBNull.Value Then
                        Select Case Columna.DataType
                            Case System.Type.GetType("System.String")
                                filaEmpleado(Columna) = ""
                            Case System.Type.GetType("System.Int64")
                                filaEmpleado(Columna) = 0
                            Case System.Type.GetType("System.Decimal")
                                filaEmpleado(Columna) = 0.0
                            Case System.Type.GetType("System.DateTime")
                                filaEmpleado(Columna) = Now
                        End Select

                    End If
                Next

                Dim rv As New Microsoft.Reporting.WinForms.LocalReport
                Dim NombreEmpleado As String = Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("Nombre").ToString
                rv.DataSources.Clear()
                rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Emisor", Me.MainDBDataSet.Tables("Emisor")))
                rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Empleados", {filaEmpleado})) 'Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)))
                rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("PercepcionEmpleado", Me.MainDBDataSet.Tables("PercepcionEmpleado").Select("EmpleadoId=" & Comprobante("EmpleadoId"))))
                rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Percepciones", Me.MainDBDataSet.Tables("Percepciones")))
                rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DeduccionEmpleado", Me.MainDBDataSet.Tables("DeduccionEmpleado").Select("EmpleadoId=" & Comprobante("EmpleadoId"))))
                rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Deducciones", Me.MainDBDataSet.Tables("Deducciones")))
                rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Adicionales", Me.MainDBDataSet.Tables("Adicionales")))
                rv.ReportPath = Application.StartupPath & "\Informes\CFDIv33-ReciboNomina.rdlc"

                Dim PDFByteArray As Byte() = rv.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "PDF"
                SaveFileDialog.DefaultExt = ".pdf"
                SaveFileDialog.Filter = "Documentos PDF|*.pdf"
                If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Select Case Comprobante("StatusCompId")
                        Case 2
                            IO.File.WriteAllBytes(SaveFileDialog.FileName, Me.MainDBDataSet.CFDIs(0).Item("PDFOriginal"))
                        Case 3
                            IO.File.WriteAllBytes(SaveFileDialog.FileName, Me.MainDBDataSet.CFDIs(0).Item("PDFCancelado"))
                    End Select
                End If
            Case "XML"
                SaveFileDialog.DefaultExt = ".xml"
                SaveFileDialog.Filter = "Documentos XML|*.xml"
                If SaveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Dim Doc As New Xml.XmlDocument
                    Doc.Load(New IO.MemoryStream(CType(Me.MainDBDataSet.CFDIs(0).Item("XML"), Byte())))
                    Doc.Save(SaveFileDialog.FileName)
                End If
            Case "Cancelar"
                ServicePointManager.Expect100Continue = True
                ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType)
                If MsgBox("¿Seguro que desea cancelar el comprobante: " & Me.MainDBDataSet.Series.Select("SerieId=" & Comprobante("SerieId"))(0).Item("Serie") & Comprobante("Folio"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cancelar CFDi") = MsgBoxResult.No Then Exit Sub
                If Comprobante("StatusCompId") = 2 Then
                    Dim WS

                    Dim Passkey = Me.MainDBDataSet.Sucursales.Rows(0)("Password")
                    Dim Cer = Me.MainDBDataSet.Sucursales.Rows(0)("CSD")
                    Dim Key = Me.MainDBDataSet.Sucursales.Rows(0)("KEY")
                    Dim idReceptor As String = Comprobante("EmpleadoId")
                    Dim uuid = Comprobante("FolioFiscal").ToString
                    Dim url As String = "http://services.sw.com.mx"
                    Dim user As String = "timbrado@mobilemetriks.com"
                    Dim pass As String = "moBile18$"
                    Dim urlSAT As String = "https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc"
                    'Si está en modo de pruebas cambiamos URL y clave
                    If TestFlag Then
                        url = "http://services.test.sw.com.mx"
                        user = "richard@mobilemetriks.com"
                        pass = "mobile18"
                        urlSAT = "https://pruebacfdiconsultaqr.cloudapp.net/ConsultaCFDIService.svc"
                    End If

                    'Abrimos Form Cancelacion
                    Dim frmCancelacion As New frmCancelacion
                    frmCancelacion.labelTitulo.Text = "Solicitud de Cancelación del Folio Fiscal " & vbCrLf & uuid
                    frmCancelacion.idReceptor = idReceptor

                    AddOwnedForm(frmCancelacion)
                    frmCancelacion.ShowDialog()
                    If Not procedeCancelacion Then
                        Exit Sub
                    End If

                    'Dim idReceptor As String = Comprobante("ReceptorId")
                    Dim total As String = Comprobante("Total")
                    Dim rfcReceptor As String = Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("RFC").ToString
                    Dim rfcEmisor As String = Me.MainDBDataSet.Emisor.Rows(0).Item("RFC")
                    Dim status As New Status(urlSAT)
                    Try
                        Dim cancelation = New Cancelation(url, user, pass)
                        Dim response As CancelationResponse
                        If motivoCancelacion = "01" Then
                            response = cancelation.CancelarByCSD(Cer, Key, rfcEmisor, Passkey, uuid, motivoCancelacion, uuidRelacion)
                        Else
                            response = cancelation.CancelarByCSD(Cer, Key, rfcEmisor, Passkey, uuid, motivoCancelacion)
                        End If

                        If response.status = "success" And Not response.data Is Nothing Then
                            Try
                                Dim responseStatus = status.GetStatusCFDI(rfcEmisor, rfcReceptor, total, uuid)
                                If responseStatus.Estado = "Cancelado" Then
                                    Try
                                        Comprobante("StatusCompId") = 3
                                        Me.ComprobantesTableAdapter.SetStatusCompId(3, Comprobante("ComprobanteId"))
                                        Me.ComprobantesTableAdapter.FillBy(Me.MainDBDataSet.Comprobantes)
                                        MsgBox("El comprobante ha sido cancelado.", MsgBoxStyle.Information, "Cancelar CFDi")
                                    Catch ex As Exception
                                        MessageBox.Show(ex.ToString)
                                    End Try
                                    MsgBox("El comprobante ha sido cancelado.", MsgBoxStyle.Information, "Cancelar CFDi")
                                Else
                                    MsgBox(responseStatus.Estado, MsgBoxStyle.Information, "Cancelar CFDi")
                                End If
                            Catch ex As Exception
                                MsgBox(ex.ToString, MsgBoxStyle.Information, "Cancelar CFDi")
                            End Try
                        Else
                            MsgBox(response.message & " " & response.messageDetail, MsgBoxStyle.Information, "Cancelar CFDi")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Information, "Cancelar CFDi")
                    End Try




                    ''Dim WS As New com.sedeb2b.cfdiws.CFDiService
                    ''Dim SucursalTableAdapter As New WebSAF_MOB100617FNADataSetTableAdapters.SucursalesTableAdapter
                    'Dim PFX = Me.MainDBDataSet.Sucursales.Rows(0)("PFX")
                    'Dim Password = Me.MainDBDataSet.Sucursales.Rows(0)("Password")
                    'Dim CER = Me.MainDBDataSet.Sucursales.Rows(0)("CSD")
                    'Dim KEY = Me.MainDBDataSet.Sucursales.Rows(0)("KEY")
                    'IO.File.WriteAllBytes(Application.StartupPath & "\temps\archivoCer.cer", Convert.FromBase64String(Cer))
                    'IO.File.WriteAllBytes(Application.StartupPath & "\temps\archivoKey.key", Convert.FromBase64String(Key))
                    'GeneraPFX(Password)
                    'Dim archivoCER = IO.File.ReadAllBytes(Application.StartupPath & "\temps\archivoCer.pem")
                    'Dim archivoKEY = IO.File.ReadAllBytes(Application.StartupPath & "\temps\archivoKey.enc")

                    'Dim cancel
                    'Dim UUIDS
                    'Dim cancelResponse
                    'If TestFlag Then
                    '    WS = New CancelacionDemoFinkok.CancelSOAP
                    '    cancel = New CancelacionDemoFinkok.cancel
                    '    UUIDS = New CancelacionDemoFinkok.UUIDS
                    '    cancelResponse = New CancelacionDemoFinkok.cancelResponse
                    '    cancel.password = "&2Bdk2yA"
                    'Else
                    '    WS = New CancelacionFinkok.CancelSOAP
                    '    cancel = New CancelacionFinkok.cancel
                    '    UUIDS = New CancelacionFinkok.UUIDS
                    '    cancelResponse = New CancelacionFinkok.cancelResponse
                    '    cancel.password = "B9h/Ww8q"
                    'End If

                    'UUIDS.uuids = {Comprobante("FolioFiscal").ToString}
                    'cancel.username = "direccion@mobilemetriks.com"
                    'cancel.taxpayer_id = Me.MainDBDataSet.Emisor.Rows(0).Item("RFC")
                    'cancel.cer = archivoCER

                    'cancel.key = archivoKEY
                    'cancel.store_pending = False
                    'cancel.UUIDS = UUIDS

                    'Try
                    '    'WS.cancelaCFDi("MOB100617FNA", "ewyfndkpm", WebSAF_MOB100617FNADataSet.Emisores.Rows(0).Item("RFC"), {comprobante("UUID").ToString}, Convert.FromBase64String(PFX), Password)
                    '    cancelResponse = WS.cancel(cancel)
                    '    If cancelResponse.cancelResult.CodEstatus = Nothing Then
                    '        Dim estatusUUID
                    '        Dim EstatusCancelacion
                    '        Try
                    '            estatusUUID = cancelResponse.cancelResult.Folios(0).EstatusUUID
                    '        Catch ex As Exception
                    '            estatusUUID = ""
                    '        End Try
                    '        Try
                    '            EstatusCancelacion = cancelResponse.cancelResult.Folios(0).EstatusCancelacion
                    '        Catch ex As Exception
                    '            EstatusCancelacion = ""
                    '        End Try

                    '        If estatusUUID = 201 Or estatusUUID = 202 Then
                    '            MessageBox.Show(estatusUUID & " - " & EstatusCancelacion)
                    '        Else
                    '            MessageBox.Show(estatusUUID & " - " & EstatusCancelacion & "Favor de intentar más tarde, sí el problema persiste deberá comunicarse a soporte técnico")
                    '            Exit Sub
                    '        End If
                    '    Else
                    '        MessageBox.Show(cancelResponse.cancelResult.CodEstatus & vbCrLf & "Favor de intentar más tarde, sí el problema persiste deberá comunicarse a soporte técnico")
                    '        Exit Sub
                    '    End If
                    'Catch ex As Exception
                    '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Cancelar CFDi")
                    '    Exit Sub
                    'End Try
                    ''If Comprobante("StatusCompId") = 2 Then
                    ''    Dim WS As New com.sedeb2b.cfdiws.CFDiService
                    ''    Dim SucursalTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.SucursalesTableAdapter
                    ''    Dim PFX = SucursalTableAdapter.GetPFX(Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("SucursalId"))
                    ''    Dim Password = SucursalTableAdapter.GetPassword(Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("SucursalId"))

                    ''    Try
                    ''        WS.cancelaCFDi("MOB100617FNA", "ewyfndkpm", Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"), {Comprobante("FolioFiscal")}, Convert.FromBase64String(PFX), Password)
                    ''    Catch ex As Exception
                    ''        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Cancelar CFDi")
                    ''        Exit Sub
                    ''    End Try
                    ''End If
                End If

            Case "Reenviar"
                If Comprobante("StatusCompId") = 1 Then
                    MsgBox("No se puede enviar un comprobante que no esté timbrado.", MsgBoxStyle.Exclamation, "Reenviar CFDi")
                    Exit Sub
                End If

                Try
                    Dim Correo As New MailMessage
                    Dim Cliente As New SmtpClient
                    Dim XMLMemoryStream As New System.IO.MemoryStream()
                    Dim PDFMemoryStream As New System.IO.MemoryStream(CType(IIf(Comprobante("StatusCompId") = 2, Me.MainDBDataSet.CFDIs.Rows(0).Item("PDFOriginal"), Me.MainDBDataSet.CFDIs.Rows(0).Item("PDFCancelado")), Byte()))
                    Dim Doc As New XmlDocument
                    Doc.Load(New System.IO.MemoryStream(CType(Me.MainDBDataSet.CFDIs.Rows(0).Item("XML"), Byte())))
                    Doc.Save(New XmlTextWriter(XMLMemoryStream, UTF8WithoutBOM))
                    XMLMemoryStream.Position = 0

                    Correo.Attachments.Add(New Attachment(XMLMemoryStream, Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("CURP").ToString & ".xml"))
                    Correo.Attachments.Add(New Attachment(PDFMemoryStream, Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("CURP").ToString & ".pdf"))
                    Correo.From = New MailAddress("comprobante-electronico@mobilemetriks.com") 'IIf(Me.MainDBDataSet.Emisor(0).Item("Correo").ToString = "", "comprobante-electronico@mobilemetriks.com", Me.MainDBDataSet.Emisor(0).Item("Correo").ToString))
                    Correo.To.Add(Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("Correos"))
                    Correo.Subject = "Recibo de nómina " & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("CURP")
                    Correo.Body = String.Format("Estimado {1}{0}{0}Encuentra anexos a este correo los archivos correspondientes a tu recibo de nómina del {2} al {3}.", vbCrLf,
                                                Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & Comprobante("EmpleadoId"))(0).Item("Nombre"),
                                                Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaInicialPago").Value,
                                                Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaFinalPago").Value)
                    Cliente.Host = "mail.mobilemetriks.com"
                    Cliente.Port = 587
                    Cliente.Credentials = New System.Net.NetworkCredential("comprobante-electronico@mobilemetriks.com", "cfdisaf2014")
                    Cliente.Send(Correo)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Reenviar CFDi")
                End Try
        End Select

    End Sub

    Private Sub FiltroEmpleadoCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FiltroEmpleadoCheckBox.CheckedChanged
        FiltroEmpleadoDataGridView.Enabled = sender.Checked
    End Sub

    Private Sub FiltroStatusCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FiltroStatusCheckBox.CheckedChanged
        FiltroStatusDataGridView.Enabled = sender.Checked
    End Sub

    Private Sub FiltrarButton_Click(sender As System.Object, e As System.EventArgs) Handles FiltrarButton.Click
        Dim EmpleadosString As String = ""
        If FiltroEmpleadoCheckBox.Checked Then
            For Each Empleado As DataGridViewRow In FiltroEmpleadoDataGridView.Rows
                If Empleado.Cells("EmpleadoCheckBox").Value = True Then
                    EmpleadosString &= Empleado.Cells("EmpleadoIdDataGridViewTextBoxColumn").Value & ", "
                End If
            Next
        End If

        Dim StatusString As String = ""
        If FiltroStatusCheckBox.Checked Then
            For Each Status As DataGridViewRow In FiltroStatusDataGridView.Rows
                If Status.Cells("StatusCheck").Value = True Then
                    StatusString &= Status.Cells("StatusCompIdDataGridViewTextBoxColumn").Value & ", "
                End If
            Next
        End If

        If EmpleadosString.EndsWith(", ") Then EmpleadosString = EmpleadosString.Substring(0, EmpleadosString.Length - 2)
        If StatusString.EndsWith(", ") Then StatusString = StatusString.Substring(0, StatusString.Length - 2)

        Dim FiltroString As String = IIf(EmpleadosString = "", "", "EmpleadoId IN (" & EmpleadosString & ")" & " AND ") &
                                    IIf(StatusString = "", "", "StatusCompId IN (" & StatusString & ")" & " AND ") &
                                    IIf(FiltroFechaCheckBox.Checked, "FechaCaptura >= '" & Format(FiltroFechaIniDateTimePicker.Value, "yyyy-MM-dd") & "' AND FechaCaptura <= '" & Format(FiltroFechaFinDateTimePicker.Value, "yyyy-MM-dd") & "' AND ", "")

        If FiltroString.EndsWith(" AND ") Then FiltroString = FiltroString.Substring(0, FiltroString.Length - 5)

        If FiltroString <> "" Then
            ComprobantesBindingSource.Filter = FiltroString
        Else
            ComprobantesBindingSource.RemoveFilter()
        End If

    End Sub

    Private Sub FiltroFechaCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FiltroFechaCheckBox.CheckedChanged
        FiltroFechaPanel.Enabled = sender.Checked
    End Sub

    Private Sub GeneraPFX(password As String)
        Dim A As Boolean = False
        Dim RutaCSD = Application.StartupPath & "\temps\archivoCer.cer"
        Dim RutaKey = Application.StartupPath & "\temps\archivoKey.key"
        'PASO -1-
        'se crea un proceso que gerenra un archivo .crt a partir del archivo .cer
        'esto es debido a que el .cer está en formato binario (DER) y hay que convertirlo a base64 PEM (para que tenga los encabezados)
        Dim proceso0 As New Process()
        proceso0.StartInfo.FileName = "SSL\openssl.exe"
        proceso0.StartInfo.Arguments = "x509 -inform der -in """ & RutaCSD & """ -out ""temps\archivo.crt"""
        proceso0.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proceso0.StartInfo.CreateNoWindow = True
        proceso0.Start()
        proceso0.WaitForExit(100)
        While Not proceso0.HasExited
        End While
        proceso0.Close()
        proceso0 = Nothing

        'esperamos a que termine el proceso
        While Not A
            Dim rd As IO.StreamReader
            Try
                rd = New IO.StreamReader("temps\archivo.crt")
                rd.ReadLine()
                A = True
                rd.Close()
            Catch ex As Exception
                'rd.Close()
            End Try
        End While

        'PASO -2-
        'se crea un proceso que gerenra un archivo .pem a partir del archivo .key
        'esto es debido a que el .key está en formato binario (DER) y hay que convertirlo a base64 PEM (para que tenga los encabezados)
        A = False
        Dim proceso1 As New Process()
        proceso1.StartInfo.FileName = "SSL\openssl.exe"
        proceso1.StartInfo.Arguments = "pkcs8 -inform DER -in """ & RutaKey & """ -passin pass:" & password & " -out ""temps\archivo.pem"""
        proceso1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proceso1.StartInfo.CreateNoWindow = True
        proceso1.Start()
        proceso1.WaitForExit(100)
        While Not proceso1.HasExited
        End While
        Dim y As Integer = proceso1.ExitCode
        proceso1.Close()
        proceso1 = Nothing

        'esperamos a que termine el proceso
        While Not A
            Dim rd As IO.StreamReader
            Try
                rd = New IO.StreamReader(Application.StartupPath & "\temps\archivo.pem")
                rd.ReadLine()
                A = True
                rd.Close()
            Catch ex As Exception
                'rd.Close()
            End Try
        End While

        'PASO -3-
        'se crea un proceso que gerenra un archivo .pfx a partir del archivo .pem y del archivo .crt los cuales están convertidos a base 64
        A = False
        Dim proceso2 As New Process()
        proceso2.StartInfo.FileName = "SSL\openssl.exe"
        proceso2.StartInfo.Arguments = "pkcs12 -export -out ""temps\archivo.pfx"" -inkey ""temps\archivo.pem"" -in ""temps\archivo.crt"" -passin pass:" & password & " -password pass:" & password
        'proceso2.StartInfo.Arguments = "pkcs12 -export -out 00001000000201351912.pfx -inkey archivo.pem -in archivo.crt -passin pass:MOB10061 -password pass:MOB10061"
        proceso2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proceso2.StartInfo.CreateNoWindow = True
        proceso2.Start()
        proceso2.WaitForExit(2000)
        While Not proceso2.HasExited
        End While
        Dim x As Integer = proceso2.ExitCode
        proceso2.Close()
        proceso2 = Nothing

        'esperamos a que termine el proceso
        While Not A
            Dim rd As IO.StreamReader
            Try
                rd = New IO.StreamReader(Application.StartupPath & "\temps\archivo.pfx")
                rd.ReadLine()
                A = True
                rd.Close()
            Catch ex As Exception
                'rd.Close()
            End Try
        End While

        'borramos los archivos generados temporalmente
        'If IO.File.Exists(Application.StartupPath & "\tmp\archivo.pem") Then IO.File.Delete(Application.StartupPath & "\tmp\archivo.pem")
        'If IO.File.Exists(Application.StartupPath & "\tmp\archivo.crt") Then IO.File.Delete(Application.StartupPath & "\tmp\archivo.crt")

        '----FINKOK-----
        'PASO -4-
        'se crea un proceso que gerenra un archivo .crt a partir del archivo .cer
        'esto es debido a que el .cer está en formato binario (DER) y hay que convertirlo a base64 PEM (para que tenga los encabezados)
        Dim proceso4 As New Process()
        proceso4.StartInfo.FileName = "SSL\openssl.exe"
        'proceso4.StartInfo.Arguments = "x509 -inform der -in """ & RutaCSD & """ -out ""temps\archivo.crt"""
        proceso4.StartInfo.Arguments = "x509 -inform DER -outform PEM -in """ & RutaCSD & """ -pubkey -out """ & Application.StartupPath & "\temps\archivoCer.pem"""
        proceso4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proceso4.StartInfo.CreateNoWindow = True
        proceso4.Start()
        proceso4.WaitForExit(100)
        While Not proceso4.HasExited
        End While
        proceso4.Close()
        proceso4 = Nothing

        'esperamos a que termine el proceso
        While Not A
            Dim rd As IO.StreamReader
            Try
                rd = New IO.StreamReader(Application.StartupPath & "\temps\archivoCer.crt")
                rd.ReadLine()
                A = True
                rd.Close()
            Catch ex As Exception
                'rd.Close()
            End Try
        End While

        'PASO -5-
        'se crea un proceso que gerenra un archivo .pem a partir del archivo .key
        'esto es debido a que el .key está en formato binario (DER) y hay que convertirlo a base64 PEM (para que tenga los encabezados)
        A = False
        Dim proceso5 As New Process()
        proceso5.StartInfo.FileName = "SSL\openssl.exe"
        proceso5.StartInfo.Arguments = "pkcs8 -inform DER -in """ & RutaKey & """ -passin pass:" & password & " -out """ & Application.StartupPath & "\temps\archivoKey.pem"""
        proceso5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proceso5.StartInfo.CreateNoWindow = True
        proceso5.Start()
        proceso5.WaitForExit(100)
        While Not proceso5.HasExited
        End While
        'Dim y As Integer = proceso1.ExitCode
        proceso5.Close()
        proceso5 = Nothing

        'esperamos a que termine el proceso
        While Not A
            Dim rd As IO.StreamReader
            Try
                rd = New IO.StreamReader(Application.StartupPath & "\temps\archivoKey.pem")
                rd.ReadLine()
                A = True
                rd.Close()
            Catch ex As Exception
                'rd.Close()
            End Try
        End While

        'PASO -6-
        'se crea un proceso que gerenra un archivo .pfx a partir del archivo .pem y del archivo .crt los cuales están convertidos a base 64
        Dim passwordFinkok As String
        A = False
        If TestFlag Then
            passwordFinkok = "&2Bdk2yA"
        Else
            passwordFinkok = "B9h/Ww8q"
        End If
        Dim proceso6 As New Process()
        proceso6.StartInfo.FileName = "SSL\openssl.exe"
        'proceso6.StartInfo.Arguments = "pkcs12 -export -out ""temps\archivo.pfx"" -inkey ""temps\archivo.pem"" -in ""temps\archivo.crt"" -passin pass:" & PasswordTextBox.Text & " -password pass:" & PasswordTextBox.Text
        proceso6.StartInfo.Arguments = "rsa -in ""temps\archivoKey.pem"" -des3 -out ""temps\archivoKey.enc"" -passout pass:" & passwordFinkok
        proceso6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        proceso6.StartInfo.CreateNoWindow = True
        proceso6.Start()
        proceso6.WaitForExit(2000)
        While Not proceso6.HasExited
        End While
        'Dim x As Integer = proceso2.ExitCode
        proceso6.Close()
        proceso6 = Nothing

        'esperamos a que termine el proceso
        While Not A
            Dim rd As IO.StreamReader
            Try
                rd = New IO.StreamReader(Application.StartupPath & "\temps\archivoKey.enc")
                rd.ReadLine()
                A = True
                rd.Close()
            Catch ex As Exception
                'rd.Close()
            End Try
        End While
    End Sub

    Private Sub actualizaBD()
        Dim Empresas As String = GetSetting("MobileNOMv2", "Datos", "Empresas", "")
        Dim Consola As frmStatus
        Consola = New frmStatus
        Consola.Show()
        Consola.Text = "Actualizando Base de Datos"
        Consola.AppendText("Se está realizando una actualización a la base de datos.")
        Consola.AppendText("Favor de esperar.")
        Consola.AppendText("El proceso puede tardar varios minutos...")

        Try
            Dim actEmpresas As String = ""
            Dim arrEmpresas As String() = Empresas.Split("|")

            For Each Empresa As String In arrEmpresas
                Dim arrDatosEmpresa As String() = Empresa.Split("\")

                Dim filePath As String = Application.StartupPath & "\DB\actualizacion.txt"
                Dim conString As String = "Data Source=" & RutaDocs & arrDatosEmpresa(0) & ".sdf;Max Database Size = 2048;Password=mobilemetriks"
                Using conn As SqlCeConnection = New SqlCeConnection(conString)

                    Dim command As SqlCeCommand = New SqlCeCommand()
                    command.Connection = conn
                    command.Connection.Open()
                    For Each Line As String In File.ReadLines(filePath)
                        Try
                            command.CommandText = Line
                            command.ExecuteNonQuery()
                        Catch ex As Exception
                            Exit Try
                        End Try
                    Next
                    'command.CommandText = "ALTER TABLE DeduccionEmpleado ADD Tipo nvarchar(1)"
                    'command.ExecuteNonQuery()
                    'command.CommandText = "ALTER TABLE PercepcionEmpleado ADD Tipo nvarchar(1)"
                    'command.ExecuteNonQuery()
                End Using
            Next
            Consola.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al actualizar la base de datos, favor de ponerse en contacto con servicio técnico " & vbCrLf & ex.ToString)
            Consola.Close()
            Exit Try
        End Try


    End Sub

    Private Sub NovedadActualizacion(ByVal nVersion As String, ByVal novedad As String)
        MessageBox.Show("Novedades de la versión " & nVersion & vbLf & novedad)
        SaveSetting("MobileNOMv2", "Datos", "Version", nVersion)
    End Sub

End Class
