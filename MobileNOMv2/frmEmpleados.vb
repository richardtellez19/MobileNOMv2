Imports System.Xml
Imports System.Security.Cryptography.X509Certificates
Imports System.Xml.XPath
Imports System.Xml.Xsl
Imports System.IO
Imports System.Security.Cryptography
Imports System.Xml.Schema
Imports System.Net.Mail
Imports System.Net
Imports SW.Services.Stamp

Public Class frmEmpleados
    Dim EmpleadoNominaId = 0
    Dim ErrorXML As String = ""
    Dim validSchema As Boolean = True
    Dim observaciones As String

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Dim PosEmpleado As Integer = EmpleadosBindingSource.Position

        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDBDataSet)

        Me.EmpleadosTableAdapter.FillBy(Me.MainDBDataSet.Empleados)
        Me.PercepcionEmpleadoTableAdapter.FillBy(Me.MainDBDataSet.PercepcionEmpleado)
        Me.DeduccionEmpleadoTableAdapter.FillBy(Me.MainDBDataSet.DeduccionEmpleado)
        Me.OtrosPagosTableAdapter.FillBy(Me.MainDBDataSet.OtrosPagos)
        Me.IncapacidadesTableAdapter.FillBy(Me.MainDBDataSet.Incapacidades)
        Me.HorasExtraPercepTableAdapter.FillBy(Me.MainDBDataSet.HorasExtraPercep)
        Me.AccionesOTitulosTableAdapter.FillBy(Me.MainDBDataSet.AccionesOTitulos)
        Me.JubilacionPensionRetiroTableAdapter.FillBy(Me.MainDBDataSet.JubilacionPensionRetiro)
        Me.SeparacionIndemnizacionTableAdapter.FillBy(Me.MainDBDataSet.SeparacionIndemnizacion)
        Me.SubsidioAlEmpleoTableAdapter.FillBy(Me.MainDBDataSet.SubsidioAlEmpleo)
        Me.CompensacionSaldosAFavorTableAdapter.FillBy(Me.MainDBDataSet.CompensacionSaldosAFavor)

        EmpleadosBindingSource.Position = PosEmpleado
    End Sub

    Private Sub frmEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.TipoNomina' Puede moverla o quitarla según sea necesario.
        Me.TipoNominaTableAdapter.Fill(Me.MainDBDataSet.TipoNomina)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.CompensacionSaldosAFavor' Puede moverla o quitarla según sea necesario.
        Me.CompensacionSaldosAFavorTableAdapter.Fill(Me.MainDBDataSet.CompensacionSaldosAFavor)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.SubsidioAlEmpleo' Puede moverla o quitarla según sea necesario.
        Me.SubsidioAlEmpleoTableAdapter.Fill(Me.MainDBDataSet.SubsidioAlEmpleo)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.SeparacionIndemnizacion' Puede moverla o quitarla según sea necesario.
        Me.SeparacionIndemnizacionTableAdapter.Fill(Me.MainDBDataSet.SeparacionIndemnizacion)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.JubilacionPensionRetiro' Puede moverla o quitarla según sea necesario.
        Me.JubilacionPensionRetiroTableAdapter.Fill(Me.MainDBDataSet.JubilacionPensionRetiro)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Percepciones' Puede moverla o quitarla según sea necesario.
        Me.PercepcionesTableAdapter.Fill(Me.MainDBDataSet.Percepciones)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Percepciones' Puede moverla o quitarla según sea necesario.
        Me.PercepcionesTableAdapter.Fill(Me.MainDBDataSet.Percepciones)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.HorasExtra' Puede moverla o quitarla según sea necesario.
        Me.HorasExtraTableAdapter.Fill(Me.MainDBDataSet.HorasExtra)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.HorasExtraPercep' Puede moverla o quitarla según sea necesario.
        Me.HorasExtraPercepTableAdapter.Fill(Me.MainDBDataSet.HorasExtraPercep)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.AccionesOTitulos' Puede moverla o quitarla según sea necesario.
        Me.AccionesOTitulosTableAdapter.Fill(Me.MainDBDataSet.AccionesOTitulos)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.TipoIncapacidad' Puede moverla o quitarla según sea necesario.
        Me.TipoIncapacidadTableAdapter.Fill(Me.MainDBDataSet.TipoIncapacidad)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Incapacidades' Puede moverla o quitarla según sea necesario.
        Me.IncapacidadesTableAdapter.Fill(Me.MainDBDataSet.Incapacidades)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.TipoOtroPago' Puede moverla o quitarla según sea necesario.
        Me.TipoOtroPagoTableAdapter.Fill(Me.MainDBDataSet.TipoOtroPago)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.OtrosPagos' Puede moverla o quitarla según sea necesario.
        Me.OtrosPagosTableAdapter.Fill(Me.MainDBDataSet.OtrosPagos)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Deducciones' Puede moverla o quitarla según sea necesario.
        Me.DeduccionesTableAdapter.Fill(Me.MainDBDataSet.Deducciones)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.DeduccionEmpleado' Puede moverla o quitarla según sea necesario.
        Me.DeduccionEmpleadoTableAdapter.Fill(Me.MainDBDataSet.DeduccionEmpleado)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Percepciones' Puede moverla o quitarla según sea necesario.
        Me.PercepcionesTableAdapter.Fill(Me.MainDBDataSet.Percepciones)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.PercepcionEmpleado' Puede moverla o quitarla según sea necesario.
        Me.PercepcionEmpleadoTableAdapter.Fill(Me.MainDBDataSet.PercepcionEmpleado)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Estados' Puede moverla o quitarla según sea necesario.
        Me.EstadosTableAdapter.Fill(Me.MainDBDataSet.Estados)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Bancos' Puede moverla o quitarla según sea necesario.
        Me.BancosTableAdapter.Fill(Me.MainDBDataSet.Bancos)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Periodicidades' Puede moverla o quitarla según sea necesario.
        Me.PeriodicidadesTableAdapter.Fill(Me.MainDBDataSet.Periodicidades)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.RiesgoPuesto' Puede moverla o quitarla según sea necesario.
        Me.RiesgoPuestoTableAdapter.Fill(Me.MainDBDataSet.RiesgoPuesto)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.TipoRegimenNomina' Puede moverla o quitarla según sea necesario.
        Me.TipoRegimenNominaTableAdapter.Fill(Me.MainDBDataSet.TipoRegimenNomina)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.TipoJornada' Puede moverla o quitarla según sea necesario.
        Me.TipoJornadaTableAdapter.Fill(Me.MainDBDataSet.TipoJornada)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.TipoContratos' Puede moverla o quitarla según sea necesario.
        Me.TipoContratosTableAdapter.Fill(Me.MainDBDataSet.TipoContratos)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.MainDBDataSet.Sucursales)
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.MainDBDataSet.Empleados)

    End Sub

    Private Sub PercepcionEmpleadoBindingSource1_PositionChanged(sender As System.Object, e As System.EventArgs) Handles PercepcionEmpleadoBindingSource1.PositionChanged
        Try
            If AccionesOTitulosBindingSource.Count > 0 Then
                AccionesBindingNavigatorAddNewItem.Enabled = False
                AccionesOTitulosDataGridView.AllowUserToAddRows = False
            Else
                AccionesBindingNavigatorAddNewItem.Enabled = True
                AccionesOTitulosDataGridView.AllowUserToAddRows = True
            End If
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub EmpleadosBindingSource_PositionChanged(sender As System.Object, e As System.EventArgs) Handles EmpleadosBindingSource.PositionChanged
        Try
            If JubilacionPensionRetiroBindingSource.Count > 0 Then
                JubilacionPensionRetiroBindingNavigatorAddNewItem.Enabled = False
                JubilacionPensionRetiroDataGridView.AllowUserToAddRows = False
            Else
                JubilacionPensionRetiroBindingNavigatorAddNewItem.Enabled = True
                JubilacionPensionRetiroDataGridView.AllowUserToAddRows = True
            End If
        Catch ex As Exception
            Exit Try
        End Try

        Try
            If SeparacionIndemnizacionBindingSource.Count > 0 Then
                SeparacionIndemnizacionBindingNavigatorAddNewItem.Enabled = False
                SeparacionIndemnizacionDataGridView.AllowUserToAddRows = False
            Else
                SeparacionIndemnizacionBindingNavigatorAddNewItem.Enabled = True
                SeparacionIndemnizacionDataGridView.AllowUserToAddRows = True
            End If
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub OtrosPagosBindingSource1_PositionChanged(sender As System.Object, e As System.EventArgs) Handles OtrosPagosBindingSource1.PositionChanged
        Try
            If SubsidioAlEmpleoBindingSource.Count > 0 Then
                SubsidioAlEmpleoBindingNavigatorAddNewItem.Enabled = False
                SubsidioAlEmpleoDataGridView.AllowUserToAddRows = False
            Else
                SubsidioAlEmpleoBindingNavigatorAddNewItem.Enabled = True
                SubsidioAlEmpleoDataGridView.AllowUserToAddRows = True
            End If
        Catch ex As Exception
            Exit Try
        End Try

        Try
            If CompensacionSaldosAFavorBindingSource.Count > 0 Then
                CompensacionSaldosAFavorBindingNavigatorAddNewItem.Enabled = False
                CompensacionSaldosAFavorDataGridView.AllowUserToAddRows = False
            Else
                CompensacionSaldosAFavorBindingNavigatorAddNewItem.Enabled = True
                CompensacionSaldosAFavorDataGridView.AllowUserToAddRows = True
            End If
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub CargarButton_Click(sender As System.Object, e As System.EventArgs) Handles CargarButton.Click
        EmpleadosListView.Items.Clear()

        For Each Empleado As DataRow In Me.MainDBDataSet.Empleados.Select("PeriodicidadPagoId=" & PeriodicidadesComboBox.SelectedValue & " AND Activo=1")
            Dim ItemEmpleado As New ListViewItem({Empleado("EmpleadoId"), Empleado("Nombre"), ""})
            ItemEmpleado.Checked = True
            EmpleadosListView.Items.Add(ItemEmpleado)
        Next
    End Sub

    Private Sub CalcularNominaButton_Click(sender As System.Object, e As System.EventArgs) Handles CalcularNominaButton.Click
        Dim TotalSueldos As Double = 0
        Dim TotalGravado As Double = 0
        Dim TotalExento As Double = 0
        Dim TotalSeparacionIndemnizacion As Double = 0
        Dim TotalJubilacionPensionRetiro As Double = 0
        Dim TotalOtrasDeducciones As Double = 0
        Dim TotalImpuestosRetenidos As Double = 0
        Dim TotalOtrosPagos As Double = 0
        Dim Subtotal As Double = 0
        Dim Total As Double = 0

        CalculaNomina(EmpleadosListView.CheckedItems, TotalSueldos, TotalGravado, TotalExento, TotalSeparacionIndemnizacion, TotalJubilacionPensionRetiro, TotalOtrasDeducciones, TotalImpuestosRetenidos, TotalOtrosPagos, Subtotal, Total)

        TotalSueldosMaskedTextBox.Text = String.Format("{0:C2}", TotalSueldos)
        TotalGravadoMaskedTextBox.Text = String.Format("{0:C2}", TotalGravado)
        TotalExentoMaskedTextBox.Text = String.Format("{0:C2}", TotalExento)
        TotalSeparacionIndemnizacionMaskedTextBox.Text = String.Format("{0:C2}", TotalSeparacionIndemnizacion)
        TotalJubilacionPensionRetiroMaskedTextBox.Text = String.Format("{0:C2}", TotalJubilacionPensionRetiro)
        TotalOtrasDeduccionesMaskedTextBox.Text = String.Format("{0:C2}", TotalOtrasDeducciones)
        TotalImpuestosRetenidosMaskedTextBox.Text = String.Format("{0:C2}", TotalImpuestosRetenidos)
        TotalOtrosPagosMaskedTextBox.Text = String.Format("{0:C2}", TotalOtrosPagos)
        SubtotalTextBox.Text = String.Format("{0:C2}", Subtotal)
        DescuentoTextBox.Text = String.Format("{0:C2}", TotalOtrasDeducciones)
        RetencionesTextBox.Text = String.Format("{0:C2}", TotalImpuestosRetenidos)
        TotalTextBox.Text = String.Format("{0:C2}", Total)
    End Sub

    Private Sub CalculaNomina(ByRef Listado As ListView.CheckedListViewItemCollection, ByRef TotalSueldos As Double, ByRef TotalGravado As Double, ByRef TotalExento As Double,
                                ByRef TotalSeparacionIndemnizacion As Double, ByRef TotalJubilacionPensionRetiro As Double,
                                ByRef TotalOtrasDeducciones As Double, ByRef TotalImpuestosRetenidos As Double, ByRef TotalOtrosPagos As Double,
                                ByRef Subtotal As Double, ByRef Total As Double)
        For Each EmpleadoId As ListViewItem In Listado
            Dim EmpTotalSueldos As Double = 0
            Dim EmpTotalGravado As Double = 0
            Dim EmpTotalExento As Double = 0
            Dim EmpTotalSeparacionIndemnizacion As Double = 0
            Dim EmpTotalJubilacionPensionRetiro As Double = 0
            Dim EmpTotalOtrasDeducciones As Double = 0
            Dim EmpTotalImpuestosRetenidos As Double = 0
            Dim EmpTotalOtrosPagos As Double = 0

            CalculaNominaEmpleado(CInt(EmpleadoId.Text), EmpTotalSueldos, EmpTotalGravado, EmpTotalExento, EmpTotalSeparacionIndemnizacion, EmpTotalJubilacionPensionRetiro, EmpTotalOtrasDeducciones, EmpTotalImpuestosRetenidos, EmpTotalOtrosPagos)

            TotalSueldos += EmpTotalSueldos
            TotalGravado += EmpTotalGravado
            TotalExento += EmpTotalExento
            TotalSeparacionIndemnizacion += EmpTotalSeparacionIndemnizacion
            TotalJubilacionPensionRetiro += EmpTotalJubilacionPensionRetiro
            TotalOtrasDeducciones += EmpTotalOtrasDeducciones
            TotalImpuestosRetenidos += EmpTotalImpuestosRetenidos
            TotalOtrosPagos += EmpTotalOtrosPagos
        Next

        Subtotal = TotalSueldos + TotalOtrosPagos + TotalSeparacionIndemnizacion + TotalJubilacionPensionRetiro
        Total = Subtotal - TotalOtrasDeducciones - TotalImpuestosRetenidos
    End Sub

    Private Sub CalculaNominaEmpleado(ByRef EmpleadoId As Integer, ByRef EmpTotalSueldos As Double, ByRef EmpTotalGravado As Double, ByRef EmpTotalExento As Double,
                                        ByRef EmpTotalSeparacionIndemnizacion As Double, ByRef EmpTotalJubilacionPensionRetiro As Double,
                                        ByRef EmpTotalOtrasDeducciones As Double, ByRef EmpTotalImpuestosRetenidos As Double,
                                        ByRef EmpTotalOtrosPagos As Double)
        'Percepciones
        'Calcula TotalSueldos, TotalGravado, TotalExento, TotalSeparacionIndemnizacion y TotalJubilacionPensionRetiro del empleado
        For Each Percepcion As DataRow In Me.MainDBDataSet.PercepcionEmpleado.Select("EmpleadoId=" & EmpleadoId)
            Select Case Percepcion("PercepcionId")
                Case 17, 18, 20
                    EmpTotalSeparacionIndemnizacion += Percepcion("ImporteGravado") + Percepcion("ImporteExento")
                    EmpTotalGravado += Percepcion("ImporteGravado")
                    EmpTotalExento += Percepcion("ImporteExento")
                Case 34, 35
                    EmpTotalJubilacionPensionRetiro += Percepcion("ImporteGravado") + Percepcion("ImporteExento")
                    EmpTotalGravado += Percepcion("ImporteGravado")
                    EmpTotalExento += Percepcion("ImporteExento")
                Case Else
                    EmpTotalSueldos += Percepcion("ImporteGravado") + Percepcion("ImporteExento")
                    EmpTotalGravado += Percepcion("ImporteGravado")
                    EmpTotalExento += Percepcion("ImporteExento")
            End Select
        Next

        'Deducciones
        'Calcula TotalOtrasDeducciones y TotalImpuestosRetenidos
        For Each Deduccion As DataRow In Me.MainDBDataSet.DeduccionEmpleado.Select("EmpleadoId=" & EmpleadoId)
            Select Case Deduccion("DeduccionId")
                Case 2
                    EmpTotalImpuestosRetenidos += Deduccion("Importe")
                Case Else
                    EmpTotalOtrasDeducciones += Deduccion("Importe")
            End Select
        Next

        'OtrosPago
        'Calcula TotalOtrosPagos
        For Each OtroPago As DataRow In Me.MainDBDataSet.OtrosPagos.Select("EmpleadoId=" & EmpleadoId)
            EmpTotalOtrosPagos += OtroPago("Importe")
        Next
    End Sub

    Private Sub GenerarNominaButton_Click(sender As System.Object, e As System.EventArgs) Handles GenerarNominaButton.Click
        If EmpleadosListView.CheckedItems.Count = 0 Then
            MsgBox("Debe haber por lo menos un empleado seleccionado para generar la nómina.", MsgBoxStyle.Exclamation, "Generar nómina")
            Exit Sub
        End If

        If MsgBox("¿Está seguro de generar los recibos de nómina?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Generar nómina") = MsgBoxResult.No Then Exit Sub

        observaciones = txtObservaciones.Text
        Dim EmpleadoIdList As New List(Of Integer)
        For Each EmpleadoId As ListViewItem In EmpleadosListView.CheckedItems
            EmpleadoIdList.Add(EmpleadoId.Text)
        Next

        Dim ParametrosList As New List(Of String)
        ParametrosList.Add(String.Format(FechaFinalDateTimePicker.Value, "yyyy/MM/dd"))
        ParametrosList.Add(String.Format(FechaInicialDateTimePicker.Value, "yyyy/MM/dd"))
        ParametrosList.Add(String.Format(FechaPagoDateTimePicker.Value, "yyyy/MM/dd"))
        ParametrosList.Add(TipoNominaDescComboBox.SelectedValue)

        NominaBackgroundWorker.RunWorkerAsync({EmpleadoIdList, ParametrosList})

        ParametrosPanel.Enabled = False
        CalculoNominaPanel.Enabled = False
    End Sub

    Public Sub AppendAttributeXML(ByRef Nodo As XmlNode, ByVal Atributo As XmlAttribute, ByVal Valor As String)
        If Valor <> "" Then
            Atributo.Value = Valor
            Nodo.Attributes.Append(Atributo)
        End If
    End Sub

    Public Sub GeneraCBB(ByRef CBB As System.IO.MemoryStream, ByVal datos As String)
        Dim bc As New BarcodeLib.Barcode.QRCode.QRCode

        'bc.Data = "?re=XAXX010101000&rr=XAXX010101000&tt=1234567890.123456&id=ad662d33-6934-459c-a128-BDf0393f0f44"
        'bc.Data = "?re=MOB100617FNA&rr=CAA970530UQ2&tt=1234567890.123456&id=ad662d33-6934-459c-a128-BDf0393f0f44"
        'bc.Data = "http://www.mobilemetriks.com"
        bc.Data = datos
        bc.ModuleSize = 7
        bc.LeftMargin = 0
        bc.RightMargin = 0
        bc.TopMargin = 0
        bc.BottomMargin = 0
        bc.Resolution = 400
        bc.Encoding = BarcodeLib.Barcode.QRCode.QRCodeEncoding.Auto
        bc.Version = BarcodeLib.Barcode.QRCode.QRCodeVersion.Auto
        bc.ECL = BarcodeLib.Barcode.QRCode.ErrorCorrectionLevel.L

        Dim imagen As New System.Drawing.Bitmap(283, 283)
        Dim graimagen As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(imagen)
        bc.drawBarcode(graimagen)

        For y As Integer = 0 To 199
            For x As Integer = 0 To 199
                If imagen.GetPixel(x, y).Name = "ffff9c48" Or imagen.GetPixel(x, y).Name = "ffff489c" Then
                    GeneraCBB(CBB, datos)
                    Exit Sub
                End If
            Next
        Next

        'picCBB.Image = imagen

        '
        'Dim ms As New System.IO.MemoryStream
        imagen.Save(CBB, System.Drawing.Imaging.ImageFormat.Png)
        'picCBB.Image = New System.Drawing.Bitmap(ms)
    End Sub

    Private Function ReemplazaCaracteres(ByVal cadena As String) As String
        cadena = Replace(cadena, "&amp;", "&")
        cadena = Replace(cadena, "&quot;", """")
        cadena = Replace(cadena, "&lt;", "<")
        cadena = Replace(cadena, "&gt;", ">")
        cadena = Replace(cadena, "&apos;", "'")

        Return cadena
    End Function

    Private Sub NominaBackgroundWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles NominaBackgroundWorker.DoWork
        'LlenaXMLv32(sender, e)
        LlenaXMLv33(sender, e)
    End Sub

    Private Sub LlenaXMLv32(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim ParametrosArray As Array = CType(e.Argument, Array)
        Dim EmpleadosArray As List(Of Integer) = ParametrosArray(0)
        Dim Parametros As List(Of String) = ParametrosArray(1)
        Dim WS As New Licencias.Service1
        Dim EmisorTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.EmisorTableAdapter
        EmisorTableAdapter.ClearBeforeFill = True
        EmisorTableAdapter.Fill(Me.MainDBDataSet.Emisor)
        Dim RegimenEmisorTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.RegimenEmisorTableAdapter
        RegimenEmisorTableAdapter.ClearBeforeFill = True
        RegimenEmisorTableAdapter.Fill(Me.MainDBDataSet.RegimenEmisor)
        Dim RegimenFiscalTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.RegimenFiscalTableAdapter
        RegimenFiscalTableAdapter.ClearBeforeFill = True
        RegimenFiscalTableAdapter.Fill(Me.MainDBDataSet.RegimenFiscal)
        Dim PaisesTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.PaisesTableAdapter
        PaisesTableAdapter.ClearBeforeFill = True
        PaisesTableAdapter.Fill(Me.MainDBDataSet.Paises)
        Dim SeriesTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.SeriesTableAdapter
        SeriesTableAdapter.ClearBeforeFill = True
        SeriesTableAdapter.Fill(Me.MainDBDataSet.Series)
        Dim ComprobantesTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.ComprobantesTableAdapter
        ComprobantesTableAdapter.ClearBeforeFill = True
        Dim CFDIsTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.CFDIsTableAdapter
        CFDIsTableAdapter.ClearBeforeFill = True

        For Each EmpleadoId As Integer In EmpleadosArray
            Dim TotalSueldos As Double = 0
            Dim TotalGravado As Double = 0
            Dim TotalExento As Double = 0
            Dim TotalSeparacionIndemnizacion As Double = 0
            Dim TotalJubilacionPensionRetiro As Double = 0
            Dim TotalOtrasDeducciones As Double = 0
            Dim TotalImpuestosRetenidos As Double = 0
            Dim TotalOtrosPagos As Double = 0
            Dim Subtotal As Double = 0
            Dim Total As Double = 0

            EmpleadoNominaId = EmpleadoId
            NominaBackgroundWorker.ReportProgress(1)
            CalculaNominaEmpleado(EmpleadoId, TotalSueldos, TotalGravado, TotalExento, TotalSeparacionIndemnizacion, TotalJubilacionPensionRetiro, TotalOtrasDeducciones, TotalImpuestosRetenidos, TotalOtrosPagos)

            Subtotal = TotalSueldos + TotalSeparacionIndemnizacion + TotalJubilacionPensionRetiro + TotalOtrosPagos
            Total = Subtotal - TotalOtrasDeducciones - TotalImpuestosRetenidos

            NominaBackgroundWorker.ReportProgress(2)
            Dim Certificado As New X509Certificate2(Convert.FromBase64String(Me.MainDBDataSet.Sucursales.Select("SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("PFX")), Me.MainDBDataSet.Sucursales.Select("SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("Password").ToString)
            Dim Doc As New XmlDocument
            Doc.LoadXml("<?xml version=""1.0"" encoding=""UTF-8""?>" &
                   "<cfdi:Comprobante xmlns:cfdi=""http://www.sat.gob.mx/cfd/3"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:nomina12=""http://www.sat.gob.mx/nomina12"" xmlns:tfd=""http://www.sat.gob.mx/TimbreFiscalDigital"" xsi:schemaLocation=""http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/TimbreFiscalDigital/TimbreFiscalDigital.xsd http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd"">" &
                   "</cfdi:Comprobante>")

            ' Crea nodo Comprobante y agrega sus atributos
            Dim Comprobante As XmlNode = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0)

            AppendAttributeXML(Comprobante, Doc.CreateAttribute("LugarExpedicion"), Me.MainDBDataSet.Emisor(0).Item("CodigoPostal"))
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("metodoDePago"), "NA")
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("tipoDeComprobante"), "egreso")
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("total"), String.Format("{0:N2}", Total).Replace(",", ""))
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("TipoCambio"), 1)
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("Moneda"), "MXN")
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("descuento"), String.Format("{0:N2}", TotalOtrasDeducciones + TotalImpuestosRetenidos).Replace(",", ""))
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("subTotal"), String.Format("{0:N2}", Subtotal).Replace(",", ""))
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("formaDePago"), "En una sola exhibición")
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("certificado"), Convert.ToBase64String(Certificado.Export(X509ContentType.Cert)))
            Dim NoCertificado As String = ""
            For i As Integer = 1 To Certificado.GetSerialNumberString.Length Step 2
                NoCertificado &= Certificado.GetSerialNumberString.Substring(i, 1)
            Next
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("noCertificado"), NoCertificado)
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("sello"), "Pendiente")
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("fecha"), Format(ObtieneFecha, "yyyy-MM-ddTHH:mm:ss"))
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("folio"), Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("FolioActual"))
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("serie"), Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("Serie"))
            AppendAttributeXML(Comprobante, Doc.CreateAttribute("version"), 3.2)

            'Crea nodo Emisor y agrega sus atributos
            Dim Emisor As XmlNode = Doc.CreateElement("cfdi", "Emisor", "http://www.sat.gob.mx/cfd/3")
            AppendAttributeXML(Emisor, Doc.CreateAttribute("nombre"), Me.MainDBDataSet.Emisor(0).Item("Nombre"))
            AppendAttributeXML(Emisor, Doc.CreateAttribute("rfc"), Me.MainDBDataSet.Emisor(0).Item("RFC"))

            'Crea nodo RegimenFiscal y agrega sus atributos
            Dim RegimenFiscal As XmlNode = Doc.CreateElement("cfdi", "RegimenFiscal", "http://www.sat.gob.mx/cfd/3")
            AppendAttributeXML(RegimenFiscal, Doc.CreateAttribute("Regimen"), Me.MainDBDataSet.RegimenFiscal.Select("RegimenId=" & Me.MainDBDataSet.RegimenEmisor(0).Item("RegimenFiscalId"))(0).Item("RegimenCode"))
            ' Agrega el nodo Emisor dentro del nodo Comprobante
            Emisor.AppendChild(RegimenFiscal)

            ' Agrega el nodo Emisor dentro del nodo Comprobante
            Comprobante.AppendChild(Emisor)

            'Crea nodo Emisor y agrega sus atributos
            Dim Receptor As XmlNode = Doc.CreateElement("cfdi", "Receptor", "http://www.sat.gob.mx/cfd/3")
            AppendAttributeXML(Receptor, Doc.CreateAttribute("nombre"), Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("Nombre"))
            AppendAttributeXML(Receptor, Doc.CreateAttribute("rfc"), Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("RFC"))
            ' Agrega el nodo Receptor dentro del nodo Comprobante
            Comprobante.AppendChild(Receptor)

            'Crea nodo Conceptos y agrega sus atributos
            Dim Conceptos As XmlNode = Doc.CreateElement("cfdi", "Conceptos", "http://www.sat.gob.mx/cfd/3")

            'Crea nodo Concepto y agrega sus atributos
            Dim Concepto As XmlNode = Doc.CreateElement("cfdi", "Concepto", "http://www.sat.gob.mx/cfd/3")
            AppendAttributeXML(Concepto, Doc.CreateAttribute("importe"), String.Format("{0:N2}", Subtotal).Replace(",", ""))
            AppendAttributeXML(Concepto, Doc.CreateAttribute("valorUnitario"), String.Format("{0:N2}", Subtotal).Replace(",", ""))
            AppendAttributeXML(Concepto, Doc.CreateAttribute("descripcion"), "Pago de nómina")
            AppendAttributeXML(Concepto, Doc.CreateAttribute("unidad"), "ACT")
            AppendAttributeXML(Concepto, Doc.CreateAttribute("cantidad"), 1)
            ' Agrega el nodo Concepto dentro del nodo Conceptos
            Conceptos.AppendChild(Concepto)
            ' Agrega el nodo Conceptos dentro del nodo Comprobante
            Comprobante.AppendChild(Conceptos)

            'Crea nodo Impuestos y agrega sus atributos
            Dim Impuestos As XmlNode = Doc.CreateElement("cfdi", "Impuestos", "http://www.sat.gob.mx/cfd/3")
            ' Agrega el nodo Impuestos dentro del nodo Comprobante
            Comprobante.AppendChild(Impuestos)

            'Crea nodo Complemento y agrega sus atributos
            Dim Complemento As XmlNode = Doc.CreateElement("cfdi", "Complemento", "http://www.sat.gob.mx/cfd/3")

            ' Se crea el nodo Nomina
            Dim Nomina As XmlNode = Doc.CreateElement("nomina12", "Nomina", "http://www.sat.gob.mx/nomina12")
            'If TotalOtrosPagos > 0 Then 
            AppendAttributeXML(Nomina, Doc.CreateAttribute("TotalOtrosPagos"), String.Format("{0:N2}", TotalOtrosPagos).Replace(",", ""))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("TotalDeducciones"), String.Format("{0:N2}", TotalOtrasDeducciones + TotalImpuestosRetenidos).Replace(",", ""))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("TotalPercepciones"), String.Format("{0:N2}", TotalSueldos + TotalSeparacionIndemnizacion + TotalJubilacionPensionRetiro).Replace(",", ""))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("NumDiasPagados"), Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("DiasPagados"))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("FechaFinalPago"), Format(CDate(Parametros.Item(0).Substring(0, 10)), "yyyy-MM-dd"))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("FechaInicialPago"), Format(CDate(Parametros.Item(1).Substring(0, 10)), "yyyy-MM-dd"))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("FechaPago"), Format(CDate(Parametros.Item(2).Substring(0, 10)), "yyyy-MM-dd"))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("TipoNomina"), Parametros.Item(3))
            AppendAttributeXML(Nomina, Doc.CreateAttribute("Version"), "1.2")

            Dim Empleado As DataRow = Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0)

            ' Se crea el nodo Emisor
            Dim EmisorNomina As XmlNode = Doc.CreateElement("nomina12", "Emisor", "http://www.sat.gob.mx/nomina12")
            Dim TipoRegimen As String = Me.MainDBDataSet.TipoRegimenNomina.Select("TipoRegimenNominaId=" & Empleado("TipoRegimenId"))(0).Item("TipoRegimenNominaCode")
            If TipoRegimen = "02" Or TipoRegimen = "03" Or TipoRegimen = "04" Then AppendAttributeXML(EmisorNomina, Doc.CreateAttribute("RegistroPatronal"), Me.MainDBDataSet.Emisor(0).Item("RegistroPatronal"))
            If Not Me.MainDBDataSet.Emisor(0).Item("CURP") Is System.DBNull.Value Then AppendAttributeXML(EmisorNomina, Doc.CreateAttribute("Curp"), Me.MainDBDataSet.Emisor(0).Item("CURP"))
            ' Agrega el nodo Emisor dentro del nodo Nomina
            Nomina.AppendChild(EmisorNomina)

            ' Se crea el nodo Receptor
            Dim ReceptorNomina As XmlNode = Doc.CreateElement("nomina12", "Receptor", "http://www.sat.gob.mx/nomina12")
            AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("ClaveEntFed"), Me.MainDBDataSet.Estados.Select("EstadoId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("EstadoId"))(0).Item("EstadoCode"))
            If Not Empleado("SalarioDiarioIntegrado") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("SalarioDiarioIntegrado"), String.Format("{0:N2}", Empleado("SalarioDiarioIntegrado")).Replace(",", ""))
            If Not Empleado("SalariaBaseCotApor") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("SalarioBaseCotApor"), String.Format("{0:N2}", Empleado("SalariaBaseCotApor")).Replace(",", ""))
            If Not Empleado("CuentaBancaria") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("CuentaBancaria"), Empleado("CuentaBancaria"))
            If Not Empleado("BancoId") Is System.DBNull.Value And Empleado("CuentaBancaria").ToString.Length < 18 Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Banco"), Me.MainDBDataSet.Bancos.Select("BancoId=" & Empleado("BancoId"))(0).Item("BancoCode"))
            AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("PeriodicidadPago"), Me.MainDBDataSet.Periodicidades.Select("PeriodicidadId=" & Empleado("PeriodicidadPagoId"))(0).Item("PeriodicidadCode"))
            If Not Empleado("RiesgoPuestoId") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("RiesgoPuesto"), Me.MainDBDataSet.RiesgoPuesto.Select("RiesgoPuestoId=" & Empleado("RiesgoPuestoId"))(0).Item("RiesgoPuestoCode"))
            If Not Empleado("Puesto") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Puesto"), Empleado("Puesto"))
            If Not Empleado("Departamento") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Departamento"), Empleado("Departamento"))
            AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("NumEmpleado"), Empleado("NumEmpleado"))
            AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("TipoRegimen"), Me.MainDBDataSet.TipoRegimenNomina.Select("TipoRegimenNominaId=" & Empleado("TipoRegimenId"))(0).Item("TipoRegimenNominaCode"))
            If Not Empleado("TipoJornadaId") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("TipoJornada"), Me.MainDBDataSet.TipoJornada.Select("TipoJornadaId=" & Empleado("TipoJornadaId"))(0).Item("TipoJornadaCode"))
            If Empleado("Sindicalizado") Is System.DBNull.Value Then Empleado("Sindicalizado") = 0
            If Not Empleado("Sindicalizado") = 0 Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Sindicalizado"), IIf(Empleado("Sindicalizado") = 1, "Sí", "No"))
            AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("TipoContrato"), Me.MainDBDataSet.TipoContratos.Select("TipoContratoId=" & Empleado("TipoContratoId"))(0).Item("ContratoCode"))
            If Not Empleado("FechaInicioRelLaboral") Is System.DBNull.Value And Not Empleado("FechaInicioRelLaboral") Is String.Empty And Not Empleado("FechaInicioRelLaboral").ToString.Trim = "" Then
                Dim Y As Long = DateDiff(DateInterval.Year, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                Dim M As Long = DateDiff(DateInterval.Month, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                Dim D As Long = DateDiff(DateInterval.Day, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                Dim W As Long = DateDiff(DateInterval.WeekOfYear, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                'AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Antigüedad"), String.Format("P{0}{1}{2}{3}{4}{5}", IIf(Y = 0, "", Y), IIf(Y = 0, "", "Y"), IIf(M = 0, "", M), IIf(M = 0, "", "M"), IIf(D = 0, "", D), IIf(D = 0, "", "D")))
                AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Antigüedad"), "P" & IIf(W <= CInt((D + 1) / 7 - 0.5), W, CInt((D + 1) / 7 - 0.5)) & "W")
            End If
            If Not Empleado("FechaInicioRelLaboral") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("FechaInicioRelLaboral"), Format(CDate(Empleado("FechaInicioRelLaboral")), "yyyy-MM-dd"))
            If Not Empleado("NumSeguridadSocial") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("NumSeguridadSocial"), Empleado("NumSeguridadSocial"))
            AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Curp"), Empleado("Curp"))
            ' Agrega el nodo Receptor dentro del nodo Nomina
            Nomina.AppendChild(ReceptorNomina)

            ' Se crea el nodo Percepciones
            If Me.MainDBDataSet.PercepcionEmpleado.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                Dim Percepciones As XmlNode = Doc.CreateElement("nomina12", "Percepciones", "http://www.sat.gob.mx/nomina12")
                AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalExento"), String.Format("{0:N2}", TotalExento).Replace(",", ""))
                AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalGravado"), String.Format("{0:N2}", TotalGravado).Replace(",", ""))
                If TotalJubilacionPensionRetiro > 0 Then AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalJubilacionPensionRetiro"), String.Format("{0:N2}", TotalJubilacionPensionRetiro).Replace(",", ""))
                If TotalSeparacionIndemnizacion > 0 Then AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalSeparacionIndemnizacion"), String.Format("{0:N2}", TotalSeparacionIndemnizacion).Replace(",", ""))
                If TotalSueldos > 0 Then AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalSueldos"), String.Format("{0:N2}", TotalSueldos).Replace(",", ""))

                ' Se crean los nodos Percepcion
                For Each PercepcionEmpleado As DataRow In Me.MainDBDataSet.PercepcionEmpleado.Select("EmpleadoId=" & EmpleadoId)
                    Dim Percepcion As XmlNode = Doc.CreateElement("nomina12", "Percepcion", "http://www.sat.gob.mx/nomina12")
                    AppendAttributeXML(Percepcion, Doc.CreateAttribute("ImporteExento"), String.Format("{0:N2}", PercepcionEmpleado("ImporteExento")).Replace(",", ""))
                    AppendAttributeXML(Percepcion, Doc.CreateAttribute("ImporteGravado"), String.Format("{0:N2}", PercepcionEmpleado("ImporteGravado")).Replace(",", ""))
                    AppendAttributeXML(Percepcion, Doc.CreateAttribute("Concepto"), Me.MainDBDataSet.Percepciones.Select("PercepcionId=" & PercepcionEmpleado("PercepcionId"))(0).Item("PercepcionDesc"))
                    AppendAttributeXML(Percepcion, Doc.CreateAttribute("Clave"), PercepcionEmpleado("Clave"))
                    AppendAttributeXML(Percepcion, Doc.CreateAttribute("TipoPercepcion"), Me.MainDBDataSet.Percepciones.Select("PercepcionId=" & PercepcionEmpleado("PercepcionId"))(0).Item("PercepcionCode"))

                    ' Se crean los nodos HorasExtra
                    For Each HoraExtra As DataRow In Me.MainDBDataSet.HorasExtraPercep.Select("PercepcionEmpleadoId=" & PercepcionEmpleado("PercepcionEmpleadoId"))
                        Dim HorasExtra As XmlNode = Doc.CreateElement("nomina12", "HorasExtra", "http://www.sat.gob.mx/nomina12")
                        AppendAttributeXML(HorasExtra, Doc.CreateAttribute("ImportePagado"), String.Format("{0:N2}", HoraExtra("ImportePagado")).Replace(",", ""))
                        AppendAttributeXML(HorasExtra, Doc.CreateAttribute("HorasExtra"), HoraExtra("HorasExtra"))
                        AppendAttributeXML(HorasExtra, Doc.CreateAttribute("TipoHoras"), Me.MainDBDataSet.HorasExtra.Select("HorasExtraId=" & HoraExtra("HorasExtraId"))(0).Item("HorasExtraCode"))
                        AppendAttributeXML(HorasExtra, Doc.CreateAttribute("Dias"), HoraExtra("Dias"))
                        ' Agrega el nodo HorasExtra dentro del nodo Percepcion
                        Percepcion.AppendChild(HorasExtra)
                    Next

                    ' Se crea el nodo AccionesOTitulos
                    If Me.MainDBDataSet.AccionesOTitulos.Select("PercepcionEmpleadoId=" & PercepcionEmpleado("PercepcionEmpleadoId")).Length > 0 Then
                        Dim AccionesOTitulos As XmlNode = Doc.CreateElement("nomina12", "AccionesOTitulos", "http://www.sat.gob.mx/nomina12")
                        Dim AccionOTitulo As DataRow = Me.MainDBDataSet.AccionesOTitulos.Select("PercepcionEmpleadoId=" & PercepcionEmpleado("PercepcionEmpleadoId"))(0)
                        AppendAttributeXML(AccionesOTitulos, Doc.CreateAttribute("PrecioAlOtorgarse"), AccionOTitulo("PrecioAlOtorgarse"))
                        AppendAttributeXML(AccionesOTitulos, Doc.CreateAttribute("ValorMercado"), AccionOTitulo("ValorMercado"))
                        ' Agrega el nodo AccionesOTitulos dentro del nodo Percepcion
                        Percepcion.AppendChild(AccionesOTitulos)
                    End If

                    ' Agrega el nodo Percepcion dentro del nodo Percepciones
                    Percepciones.AppendChild(Percepcion)
                Next

                ' Se crea el nodo JubilacionPensionRetiro
                If Me.MainDBDataSet.JubilacionPensionRetiro.Select("EmpleadoId=" & EmpleadoId).Length > 0 Then
                    Dim JubilacionPensionRetiro As XmlNode = Doc.CreateElement("nomina12", "JubilacionPensionRetiro", "http://www.sat.gob.mx/nomina12")
                    Dim JubilacionPensionRetiroEmpleado As DataRow = Me.MainDBDataSet.JubilacionPensionRetiro.Select("EmpleadoId=" & EmpleadoId)(0)
                    AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("IngresoNoAcumulable"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("IngresoNoAcumulable")).Replace(",", ""))
                    AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("IngresoAcumulable"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("IngresoAcumulable")).Replace(",", ""))
                    If Not JubilacionPensionRetiroEmpleado("MontoDiario") Is System.DBNull.Value Then AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("MontoDiario"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("MontoDiario")).Replace(",", ""))
                    If Not JubilacionPensionRetiroEmpleado("TotalParcialidad") Is System.DBNull.Value Then AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("TotalParcialidad"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("TotalParcialidad")).Replace(",", ""))
                    If Not JubilacionPensionRetiroEmpleado("TotalUnaExhibicion") Is System.DBNull.Value Then AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("TotalUnaExhibicion"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("TotalUnaExhibicion")).Replace(",", ""))
                    ' Agrega el nodo JubilacionPensionRetiro dentro del nodo Percepciones
                    Percepciones.AppendChild(JubilacionPensionRetiro)
                End If

                ' Se crea el nodo SeparacionIndemnizacion
                If Me.MainDBDataSet.SeparacionIndemnizacion.Select("EmpleadoId=" & EmpleadoId).Length > 0 Then
                    Dim SeparacionIndemnizacion As XmlNode = Doc.CreateElement("nomina12", "SeparacionIndemnizacion", "http://www.sat.gob.mx/nomina12")
                    Dim SeparacionIndemnizacionEmpleado As DataRow = Me.MainDBDataSet.SeparacionIndemnizacion.Select("EmpleadoId=" & EmpleadoId)(0)
                    AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("IngresoNoAcumulable"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("IngresoNoAcumulable")).Replace(",", ""))
                    AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("IngresoAcumulable"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("IngresoAcumulable")).Replace(",", ""))
                    AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("UltimoSueldoMensOrd"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("UltimoSueldoMensOrd")).Replace(",", ""))
                    AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("NumAñosServicio"), SeparacionIndemnizacionEmpleado("NumAniosServicio"))
                    AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("TotalPagado"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("TotalPagado")).Replace(",", ""))
                    ' Agrega el nodo SeparacionIndemnizacion dentro del nodo Percepciones
                    Percepciones.AppendChild(SeparacionIndemnizacion)
                End If

                ' Agrega el nodo Percepciones dentro del nodo Nomina
                Nomina.AppendChild(Percepciones)
            End If

            ' Se crea el nodo Deducciones
            If Me.MainDBDataSet.DeduccionEmpleado.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                Dim Deducciones As XmlNode = Doc.CreateElement("nomina12", "Deducciones", "http://www.sat.gob.mx/nomina12")
                If TotalImpuestosRetenidos > 0 Then AppendAttributeXML(Deducciones, Doc.CreateAttribute("TotalImpuestosRetenidos"), String.Format("{0:N2}", TotalImpuestosRetenidos).Replace(",", ""))
                If TotalOtrasDeducciones > 0 Then AppendAttributeXML(Deducciones, Doc.CreateAttribute("TotalOtrasDeducciones"), String.Format("{0:N2}", TotalOtrasDeducciones).Replace(",", ""))

                ' Se crean los nodos Deduccion
                For Each DeduccionEmpleado As DataRow In Me.MainDBDataSet.DeduccionEmpleado.Select("EmpleadoId=" & EmpleadoId)
                    Dim Deduccion As XmlNode = Doc.CreateElement("nomina12", "Deduccion", "http://www.sat.gob.mx/nomina12")
                    AppendAttributeXML(Deduccion, Doc.CreateAttribute("Importe"), String.Format("{0:N2}", DeduccionEmpleado("Importe")).Replace(",", ""))
                    AppendAttributeXML(Deduccion, Doc.CreateAttribute("Concepto"), Me.MainDBDataSet.Deducciones.Select("DeduccionId=" & DeduccionEmpleado("DeduccionId"))(0).Item("DeduccionDesc"))
                    AppendAttributeXML(Deduccion, Doc.CreateAttribute("Clave"), DeduccionEmpleado("Clave"))
                    AppendAttributeXML(Deduccion, Doc.CreateAttribute("TipoDeduccion"), Me.MainDBDataSet.Deducciones.Select("DeduccionId=" & DeduccionEmpleado("DeduccionId"))(0).Item("DeduccionCode"))
                    ' Agrega el nodo Deduccion dentro del nodo Deducciones
                    Deducciones.AppendChild(Deduccion)
                Next

                ' Agrega el nodo Deducciones dentro del nodo Nomina
                Nomina.AppendChild(Deducciones)
            End If

            ' Se crea el nodo OtrosPagos
            If Me.MainDBDataSet.OtrosPagos.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                Dim OtrosPagos As XmlNode = Doc.CreateElement("nomina12", "OtrosPagos", "http://www.sat.gob.mx/nomina12")

                ' Se crean los nodos OtroPago
                For Each OtroPagoEmpleado As DataRow In Me.MainDBDataSet.OtrosPagos.Select("EmpleadoId=" & EmpleadoId)
                    Dim OtroPago As XmlNode = Doc.CreateElement("nomina12", "OtroPago", "http://www.sat.gob.mx/nomina12")
                    AppendAttributeXML(OtroPago, Doc.CreateAttribute("Importe"), String.Format("{0:N2}", OtroPagoEmpleado("Importe")).Replace(",", ""))
                    AppendAttributeXML(OtroPago, Doc.CreateAttribute("Concepto"), Me.MainDBDataSet.TipoOtroPago.Select("TipoOtroPagoId=" & OtroPagoEmpleado("TipoOtroPagoId"))(0).Item("OtroPagoDesc"))
                    AppendAttributeXML(OtroPago, Doc.CreateAttribute("Clave"), OtroPagoEmpleado("Clave"))
                    AppendAttributeXML(OtroPago, Doc.CreateAttribute("TipoOtroPago"), Me.MainDBDataSet.TipoOtroPago.Select("TipoOtroPagoId=" & OtroPagoEmpleado("TipoOtroPagoId"))(0).Item("OtroPagoCode"))

                    ' Se crea el nodo SubsidioAlEmpleo
                    Dim subsidio As Boolean = False
                    If Me.MainDBDataSet.SubsidioAlEmpleo.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId")).Length > 0 Then
                        subsidio = True
                        Dim SubsidioAlEmpleo As XmlNode = Doc.CreateElement("nomina12", "SubsidioAlEmpleo", "http://www.sat.gob.mx/nomina12")
                        Dim SubsidioAlEmpleoEmpleado As DataRow = Me.MainDBDataSet.SubsidioAlEmpleo.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId"))(0)
                        AppendAttributeXML(SubsidioAlEmpleo, Doc.CreateAttribute("SubsidioCausado"), String.Format("{0:N2}", SubsidioAlEmpleoEmpleado("SubsidioCausado")).Replace(",", ""))
                        ' Agrega el nodo SeparacionIndemnizacion dentro del nodo OtroPago
                        OtroPago.AppendChild(SubsidioAlEmpleo)
                    End If

                    ' Se crea el nodo CompensacionSaldosAFavor
                    If Me.MainDBDataSet.CompensacionSaldosAFavor.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId")).Length > 0 Then
                        Dim CompensacionSaldosAFavor As XmlNode = Doc.CreateElement("nomina12", "CompensacionSaldosAFavor", "http://www.sat.gob.mx/nomina12")
                        Dim CompensacionSaldosAFavorEmpleado As DataRow = Me.MainDBDataSet.CompensacionSaldosAFavor.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId"))(0)
                        AppendAttributeXML(CompensacionSaldosAFavor, Doc.CreateAttribute("RemanenteSalFav"), String.Format("{0:N2}", CompensacionSaldosAFavorEmpleado("RemanenteSalFav")).Replace(",", ""))
                        AppendAttributeXML(CompensacionSaldosAFavor, Doc.CreateAttribute("Año"), CompensacionSaldosAFavorEmpleado("Anio"))
                        AppendAttributeXML(CompensacionSaldosAFavor, Doc.CreateAttribute("SaldoAFavor"), String.Format("{0:N2}", CompensacionSaldosAFavorEmpleado("SaldoAFavor")).Replace(",", ""))
                        ' Agrega el nodo CompensacionSaldosAFavor dentro del nodo OtroPago
                        OtroPago.AppendChild(CompensacionSaldosAFavor)
                    End If

                    ' Agrega el nodo OtroPago dentro del nodo OtrosPagos
                    OtrosPagos.AppendChild(OtroPago)
                Next

                ' Agrega el nodo OtrosPagos dentro del nodo Nomina
                Nomina.AppendChild(OtrosPagos)
            End If

            ' Se crea el nodo Incapacidades
            If Me.MainDBDataSet.Incapacidades.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                Dim Incapacidades As XmlNode = Doc.CreateElement("nomina12", "Incapacidades", "http://www.sat.gob.mx/nomina12")

                ' Se crean los nodos Incapacidad
                For Each IncapacidadEmpleado As DataRow In Me.MainDBDataSet.Incapacidades.Select("EmpleadoId=" & EmpleadoId)
                    Dim Incapacidad As XmlNode = Doc.CreateElement("nomina12", "Incapacidad", "http://www.sat.gob.mx/nomina12")
                    If IncapacidadEmpleado("ImporteMonetario") > 0 Then AppendAttributeXML(Incapacidad, Doc.CreateAttribute("ImporteMonetario"), String.Format("{0:N2}", IncapacidadEmpleado("ImporteMonetario")).Replace(",", ""))
                    AppendAttributeXML(Incapacidad, Doc.CreateAttribute("TipoIncapacidad"), Me.MainDBDataSet.TipoIncapacidad.Select("TipoIncapacidadId=" & IncapacidadEmpleado("TipoIncapacidadId"))(0).Item("TipoIncapCode"))
                    AppendAttributeXML(Incapacidad, Doc.CreateAttribute("DiasIncapacidad"), IncapacidadEmpleado("DiasIncapacidad"))
                    ' Agrega el nodo Incapacidad dentro del nodo Incapacidades
                    Incapacidades.AppendChild(Incapacidad)
                Next

                ' Agrega el nodo Incapacidades dentro del nodo Nomina
                Nomina.AppendChild(Incapacidades)
            End If

            ' Agrega el nodo Nomina dentro del nodo Complemento
            Complemento.AppendChild(Nomina)

            ' Agrega el nodo Complemento dentro del nodo Comprobante
            Comprobante.AppendChild(Complemento)

            NominaBackgroundWorker.ReportProgress(3)

            ' Convierte a memorystream
            Dim msXML As New MemoryStream
            Dim writer As New XmlTextWriter(msXML, UTF8WithoutBOM)
            Doc.Save(writer)

            ' Genera la cadena original
            Dim msChain As MemoryStream = New MemoryStream()
            Dim tw As XmlTextWriter = New XmlTextWriter(msChain, UTF8WithoutBOM)
            Dim xslt As XslCompiledTransform = New XslCompiledTransform()
            xslt.Load(Application.StartupPath & "\Esquemas\v32\cadenaoriginal_3_2.xslt")
            msXML.Position = 0
            Dim xp As XPathDocument = New XPathDocument(msXML)
            xslt.Transform(xp, tw)
            Dim CadOrig As String = ReemplazaCaracteres(UTF8WithoutBOM.GetString(msChain.ToArray()))

            ' Firma con la llave privada
            Dim sha1 As SHA1CryptoServiceProvider = New SHA1CryptoServiceProvider()
            msChain.Position = 0
            Dim rsa1 As RSACryptoServiceProvider = Certificado.PrivateKey
            Dim sello As String = Convert.ToBase64String(rsa1.SignData(UTF8WithoutBOM.GetBytes(CadOrig.ToCharArray), sha1))
            Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("sello").Value = sello

            NominaBackgroundWorker.ReportProgress(4)

            ' Valida
            validSchema = True
            Dim eventHandler As New ValidationEventHandler(AddressOf ValidationEventHandler)
            Doc.Schemas.Add("http://www.sat.gob.mx/cfd/3", Application.StartupPath & "\Esquemas\v32\cfdv32.xsd")
            Doc.Schemas.Add("http://www.sat.gob.mx/nomina12", Application.StartupPath & "\Esquemas\Complementos\nomina12.xsd")
            Doc.Validate(eventHandler)

            If validSchema = True Then
                NominaBackgroundWorker.ReportProgress(5)

                ' Timbra
                Try
                    File.Delete(Application.StartupPath & "\cfdi.xml")
                Catch ex As Exception
                    Exit Try
                End Try

                Try
                    File.Delete(Application.StartupPath & "\cfdi.zip")
                Catch ex As Exception
                    Exit Try
                End Try

                Doc.Save(Application.StartupPath & "\cfdi.xml")
                Dim wsEDICOM As New com.sedeb2b.cfdiws.CFDiService
                Dim zip As New Ionic.Zip.ZipFile(Application.StartupPath & "\cfdi.zip")
                Try
                    File.Copy(Application.StartupPath & "\cfdi.xml", "cfdi.xml", True)
                Catch ex As Exception
                    Exit Try
                End Try

                zip.AddFile("cfdi.xml")
                zip.Save()
                Dim arrzip As Byte()

                Try
                    If TestFlag Then
                        arrzip = wsEDICOM.getCfdiTest("MOB100617FNA", "ewyfndkpm", File.ReadAllBytes(Application.StartupPath & "\cfdi.zip"))
                    Else
                        arrzip = wsEDICOM.getCfdi("MOB100617FNA", "ewyfndkpm", File.ReadAllBytes(Application.StartupPath & "\cfdi.zip"))
                    End If

                    NominaBackgroundWorker.ReportProgress(6)
                    Try
                        WS.ActualizaSysInfo(Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"))
                    Catch ex As Exception
                        Exit Try
                    End Try

                    File.WriteAllBytes(Application.StartupPath & "\cfdit.zip", arrzip)

                    Dim xmlTimZIP As Ionic.Zip.ZipFile = Ionic.Zip.ZipFile.Read(Application.StartupPath & "\cfdit.zip")
                    xmlTimZIP.ExtractAll(Application.StartupPath & "\Timbre", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
                    xmlTimZIP.Dispose()
                    Doc = New XmlDocument
                    Doc.Load(Application.StartupPath & "\Timbre\SIGN_cfdi.xml")

                    msXML = New MemoryStream
                    writer = New XmlTextWriter(msXML, UTF8WithoutBOM)
                    Doc.Save(writer)
                    msXML.Position = 0
                    ComprobantesTableAdapter.Insert(2,
                     100,
                    vbNull,
                    Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("SerieId"),
                    Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("FolioActual"),
                    ObtieneFecha,
                    ObtieneFecha,
                    "3.2",
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("descuento").Value,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("subTotal").Value,
                    0.0,
                    TotalImpuestosRetenidos,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("total").Value,
                    EmpleadoId,
                     Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("UUID").Value,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("noCertificado").Value,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("TipoCambio").Value,
                    20)

                    Dim ComprobanteId As Integer = Convert.ToInt64(ComprobantesTableAdapter.GetComprobanteId)
                    CFDIsTableAdapter.Insert(ComprobanteId, msXML.ToArray, {vbNull}, {vbNull})

                    Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("FolioActual") += 1
                    SeriesTableAdapter.Update(Me.MainDBDataSet.Series)

                    NominaBackgroundWorker.ReportProgress(7)

                    ' Convierte a memorystream
                    Dim msXML_TFD As MemoryStream = New MemoryStream
                    Dim writer_TFD As XmlTextWriter = New XmlTextWriter(msXML_TFD, UTF8WithoutBOM)
                    Dim timbre As XmlNode = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0)
                    Dim docTimbre As New XmlDocument()
                    docTimbre.CreateXmlDeclaration("1.0", "UTF-8", "")
                    docTimbre.AppendChild(docTimbre.ImportNode(timbre, True))
                    docTimbre.Save(writer_TFD)

                    ' Genera la cadena original
                    Dim CadenaOriginal_TFD As String = ""
                    For i = 1 To 5
                        msChain = New MemoryStream()
                        Try
                            tw = New XmlTextWriter(msChain, UTF8WithoutBOM)
                            xslt = New XslCompiledTransform()
                            xslt.Load(Application.StartupPath & "\Esquemas\v32\cadenaoriginal_TFD_1_0.xslt")
                            msXML_TFD.Position = 0
                            xp = New XPathDocument(msXML_TFD)
                            xslt.Transform(xp, tw)
                            CadenaOriginal_TFD = System.Text.Encoding.ASCII.GetString(msChain.ToArray).Normalize
                            Exit For
                        Catch ex As Exception
                            Exit Try
                        End Try
                    Next

                    NominaBackgroundWorker.ReportProgress(8)

                    ' Genera archivo PDF
                    Dim imagenCBB As New System.IO.MemoryStream
                    GeneraCBB(imagenCBB, String.Format("?re={0}&rr={1}&tt={2:0000000000.000000}&id={3}", Doc.GetElementsByTagName("Emisor", "http://www.sat.gob.mx/cfd/3")(0).Attributes("rfc").Value, Doc.GetElementsByTagName("Receptor", "http://www.sat.gob.mx/cfd/3")(0).Attributes("rfc").Value, Total, Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("UUID").Value))
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
                    Try
                        Adicionales("TotalOtrosPagos") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TotalOtrosPagos").Value
                    Catch ex As Exception
                        Adicionales("TotalOtrosPagos") = 0
                    End Try
                    Adicionales("Total") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("total").Value
                    Adicionales("SelloCFDI") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("selloCFD").Value
                    Adicionales("SelloSAT") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("selloSAT").Value
                    Adicionales("CadenaOriginalTFD") = CadenaOriginal_TFD
                    Adicionales("CBB") = imagenCBB.ToArray
                    Me.MainDBDataSet.Adicionales.Rows.Add(Adicionales)

                    Dim filaEmpleado As DataRow = Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0)
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
                    Dim NombreEmpleado As String = Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("Nombre").ToString
                    rv.DataSources.Clear()
                    rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Emisor", Me.MainDBDataSet.Tables("Emisor")))
                    rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Empleados", {filaEmpleado})) 'Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)))
                    rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("PercepcionEmpleado", Me.MainDBDataSet.Tables("PercepcionEmpleado").Select("EmpleadoId=" & EmpleadoId)))
                    rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Percepciones", Me.MainDBDataSet.Tables("Percepciones")))
                    rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DeduccionEmpleado", Me.MainDBDataSet.Tables("DeduccionEmpleado").Select("EmpleadoId=" & EmpleadoId)))
                    rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Deducciones", Me.MainDBDataSet.Tables("Deducciones")))
                    rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Adicionales", Me.MainDBDataSet.Tables("Adicionales")))
                    rv.ReportPath = Application.StartupPath & "\Informes\CFDIv33-ReciboNomina.rdlc"

                    Dim PDFByteArray As Byte() = rv.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    NominaBackgroundWorker.ReportProgress(9)

                    ' Guarda registro en tabla Comprobantes
                    CFDIsTableAdapter.UpdatePDFOriginal(PDFByteArray, ComprobanteId)

                    NominaBackgroundWorker.ReportProgress(10)

                    ' Genera correo electrónico
                    Dim Correo As New MailMessage
                    Dim Cliente As New SmtpClient
                    msXML = New MemoryStream
                    writer = New XmlTextWriter(msXML, UTF8WithoutBOM)
                    Doc.Save(writer)
                    msXML.Position = 0

                    Correo.Attachments.Add(New Attachment(msXML, Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("CURP").ToString & ".xml"))
                    Correo.Attachments.Add(New Attachment(New MemoryStream(PDFByteArray), Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("CURP").ToString & ".pdf"))
                    Correo.From = New MailAddress(IIf(Me.MainDBDataSet.Emisor(0).Item("Correo").ToString = "", "comprobante-electronico@mobilemetriks.com", Me.MainDBDataSet.Emisor(0).Item("Correo").ToString))
                    Correo.To.Add(Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("Correos"))
                    Correo.Subject = "Recibo de nómina " & Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("CURP")
                    Correo.Body = String.Format("Estimado {1}{0}{0}Encuentra anexos a este correo los archivos correspondientes a tu recibo de nómina del {2} al {3}.", vbCrLf,
                                                Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("Nombre"),
                                                Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaInicialPago").Value,
                                                Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaFinalPago").Value)
                    Cliente.Host = "mail.mobilemetriks.com"
                    Cliente.Port = 587
                    Cliente.Credentials = New System.Net.NetworkCredential("comprobante-electronico@mobilemetriks.com", "cfdisaf2014")
                    Cliente.Send(Correo)

                    NominaBackgroundWorker.ReportProgress(11)

                Catch ex As Exception
                    ErrorXML = ex.Message
                    NominaBackgroundWorker.ReportProgress(0)
                End Try


                Try
                    File.Delete(Application.StartupPath & "\cfdit.zip")
                Catch ex As Exception
                    Exit Try
                End Try

                Try
                    Directory.Delete(Application.StartupPath & "\Timbre", True)
                Catch ex As Exception
                    Exit Try
                End Try

                Try
                    File.Delete(Application.StartupPath & "\cfdi.xml")
                Catch ex As Exception
                    Exit Try
                End Try

                Try
                    File.Delete(Application.StartupPath & "\cfdi.zip")
                Catch ex As Exception
                    Exit Try
                End Try

                Try
                    File.Delete(Application.StartupPath & "\cfdit.zip")
                Catch ex As Exception
                    Exit Try
                End Try

                Try
                    Directory.Delete(Application.StartupPath & "\Timbre")
                Catch ex As Exception
                    Exit Try
                End Try

            End If
            'Doc.Save("C:\SAF1\" & EmpleadoId & ".xml")
            'System.Threading.Thread.Sleep(2000)
        Next
    End Sub

    Private Sub LlenaXMLv33(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim ParametrosArray As Array = CType(e.Argument, Array)
        Dim EmpleadosArray As List(Of Integer) = ParametrosArray(0)
        Dim Parametros As List(Of String) = ParametrosArray(1)
        Dim WS As New Licencias.Service1
        Dim EmisorTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.EmisorTableAdapter
        EmisorTableAdapter.ClearBeforeFill = True
        EmisorTableAdapter.Fill(Me.MainDBDataSet.Emisor)
        Dim RegimenEmisorTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.RegimenEmisorTableAdapter
        RegimenEmisorTableAdapter.ClearBeforeFill = True
        RegimenEmisorTableAdapter.Fill(Me.MainDBDataSet.RegimenEmisor)
        Dim RegimenFiscalTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.RegimenFiscalTableAdapter
        RegimenFiscalTableAdapter.ClearBeforeFill = True
        RegimenFiscalTableAdapter.Fill(Me.MainDBDataSet.RegimenFiscal)
        Dim PaisesTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.PaisesTableAdapter
        PaisesTableAdapter.ClearBeforeFill = True
        PaisesTableAdapter.Fill(Me.MainDBDataSet.Paises)
        Dim SeriesTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.SeriesTableAdapter
        SeriesTableAdapter.ClearBeforeFill = True
        SeriesTableAdapter.Fill(Me.MainDBDataSet.Series)
        Dim ComprobantesTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.ComprobantesTableAdapter
        ComprobantesTableAdapter.ClearBeforeFill = True
        Dim CFDIsTableAdapter As New MobileNOMv2.MainDBDataSetTableAdapters.CFDIsTableAdapter
        CFDIsTableAdapter.ClearBeforeFill = True


        For Each EmpleadoId As Integer In EmpleadosArray
            If Not compruebaTimbresRestantes(Me.MainDBDataSet.Emisor(0).Item("RFC")) Then
                NominaBackgroundWorker.ReportProgress(12)
                MessageBox.Show("No cuentas con folios restantes, favor de solicitar un nuevo paquete de folios.")
                Exit Sub
            Else
                Dim TotalSueldos As Double = 0
                Dim TotalGravado As Double = 0
                Dim TotalExento As Double = 0
                Dim TotalSeparacionIndemnizacion As Double = 0
                Dim TotalJubilacionPensionRetiro As Double = 0
                Dim TotalOtrasDeducciones As Double = 0
                Dim TotalImpuestosRetenidos As Double = 0
                Dim TotalOtrosPagos As Double = 0
                Dim Subtotal As Double = 0
                Dim Total As Double = 0

                EmpleadoNominaId = EmpleadoId
                NominaBackgroundWorker.ReportProgress(1)
                CalculaNominaEmpleado(EmpleadoId, TotalSueldos, TotalGravado, TotalExento, TotalSeparacionIndemnizacion, TotalJubilacionPensionRetiro, TotalOtrasDeducciones, TotalImpuestosRetenidos, TotalOtrosPagos)

                Subtotal = TotalSueldos + TotalSeparacionIndemnizacion + TotalJubilacionPensionRetiro + TotalOtrosPagos
                Total = Subtotal - TotalOtrasDeducciones - TotalImpuestosRetenidos

                NominaBackgroundWorker.ReportProgress(2)
                Dim Certificado As New X509Certificate2(Convert.FromBase64String(Me.MainDBDataSet.Sucursales.Select("SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("PFX")), Me.MainDBDataSet.Sucursales.Select("SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("Password").ToString, X509KeyStorageFlags.Exportable)
                Dim Doc As New XmlDocument
                Doc.LoadXml("<?xml version=""1.0"" encoding=""UTF-8""?>" &
                       "<cfdi:Comprobante xmlns:cfdi=""http://www.sat.gob.mx/cfd/3"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:nomina12=""http://www.sat.gob.mx/nomina12"" xmlns:tfd=""http://www.sat.gob.mx/TimbreFiscalDigital"" xsi:schemaLocation=""http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv33.xsd http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/TimbreFiscalDigital/TimbreFiscalDigital.xsd http://www.sat.gob.mx/nomina12 http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd"">" &
                       "</cfdi:Comprobante>")

                ' Crea nodo Comprobante y agrega sus atributos
                Dim Comprobante As XmlNode = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0)

                AppendAttributeXML(Comprobante, Doc.CreateAttribute("LugarExpedicion"), Me.MainDBDataSet.Emisor(0).Item("CodigoPostal"))
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("MetodoPago"), "PUE")
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("TipoDeComprobante"), "N")
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Total"), String.Format("{0:N2}", Total).Replace(",", "").Replace(",", "").Replace(",", ""))
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("TipoCambio"), 1)
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Moneda"), "MXN")
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Descuento"), String.Format("{0:N2}", TotalOtrasDeducciones + TotalImpuestosRetenidos).Replace(",", ""))
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("SubTotal"), String.Format("{0:N2}", Subtotal).Replace(",", ""))
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("FormaPago"), 99)
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Certificado"), Convert.ToBase64String(Certificado.Export(X509ContentType.Cert)))
                Dim NoCertificado As String = ""
                For i As Integer = 1 To Certificado.GetSerialNumberString.Length Step 2
                    NoCertificado &= Certificado.GetSerialNumberString.Substring(i, 1)
                Next
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("NoCertificado"), NoCertificado)
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Sello"), "Pendiente")
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Fecha"), Format(ObtieneFecha, "yyyy-MM-ddTHH:mm:ss"))
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Folio"), Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("FolioActual"))
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Serie"), Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("Serie"))
                AppendAttributeXML(Comprobante, Doc.CreateAttribute("Version"), 3.3)

                'Crea nodo Emisor y agrega sus atributos
                Dim Emisor As XmlNode = Doc.CreateElement("cfdi", "Emisor", "http://www.sat.gob.mx/cfd/3")
                AppendAttributeXML(Emisor, Doc.CreateAttribute("RegimenFiscal"), Me.MainDBDataSet.RegimenFiscal.Select("RegimenId=" & Me.MainDBDataSet.RegimenEmisor(0).Item("RegimenFiscalId"))(0).Item("RegimenCode"))
                AppendAttributeXML(Emisor, Doc.CreateAttribute("Nombre"), Me.MainDBDataSet.Emisor(0).Item("Nombre"))
                AppendAttributeXML(Emisor, Doc.CreateAttribute("Rfc"), Me.MainDBDataSet.Emisor(0).Item("RFC"))
                ' Agrega el nodo Emisor dentro del nodo Comprobante
                Comprobante.AppendChild(Emisor)

                'Crea nodo Emisor y agrega sus atributos
                Dim Receptor As XmlNode = Doc.CreateElement("cfdi", "Receptor", "http://www.sat.gob.mx/cfd/3")
                AppendAttributeXML(Receptor, Doc.CreateAttribute("UsoCFDI"), "P01")
                AppendAttributeXML(Receptor, Doc.CreateAttribute("Nombre"), Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("Nombre"))
                AppendAttributeXML(Receptor, Doc.CreateAttribute("Rfc"), Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("RFC"))
                ' Agrega el nodo Receptor dentro del nodo Comprobante
                Comprobante.AppendChild(Receptor)

                'Crea nodo Conceptos y agrega sus atributos
                Dim Conceptos As XmlNode = Doc.CreateElement("cfdi", "Conceptos", "http://www.sat.gob.mx/cfd/3")

                'Crea nodo Concepto y agrega sus atributos
                Dim Concepto As XmlNode = Doc.CreateElement("cfdi", "Concepto", "http://www.sat.gob.mx/cfd/3")
                AppendAttributeXML(Concepto, Doc.CreateAttribute("Descuento"), String.Format("{0:N2}", TotalOtrasDeducciones + TotalImpuestosRetenidos).Replace(",", ""))
                AppendAttributeXML(Concepto, Doc.CreateAttribute("Importe"), String.Format("{0:N2}", Subtotal).Replace(",", ""))
                AppendAttributeXML(Concepto, Doc.CreateAttribute("ValorUnitario"), String.Format("{0:N2}", Subtotal).Replace(",", ""))
                AppendAttributeXML(Concepto, Doc.CreateAttribute("Descripcion"), "Pago de nómina")
                AppendAttributeXML(Concepto, Doc.CreateAttribute("ClaveUnidad"), "ACT")
                AppendAttributeXML(Concepto, Doc.CreateAttribute("Cantidad"), 1)
                AppendAttributeXML(Concepto, Doc.CreateAttribute("ClaveProdServ"), "84111505")
                ' Agrega el nodo Concepto dentro del nodo Conceptos
                Conceptos.AppendChild(Concepto)
                ' Agrega el nodo Conceptos dentro del nodo Comprobante
                Comprobante.AppendChild(Conceptos)

                'Crea nodo Complemento y agrega sus atributos
                Dim Complemento As XmlNode = Doc.CreateElement("cfdi", "Complemento", "http://www.sat.gob.mx/cfd/3")

                ' Se crea el nodo Nomina
                Dim Nomina As XmlNode = Doc.CreateElement("nomina12", "Nomina", "http://www.sat.gob.mx/nomina12")

                If Me.MainDBDataSet.OtrosPagos.Select("EmpleadoId=" & EmpleadoId).Count > 0 Or TotalOtrosPagos > 0 Then AppendAttributeXML(Nomina, Doc.CreateAttribute("TotalOtrosPagos"), String.Format("{0:N2}", TotalOtrosPagos).Replace(",", ""))
                If TotalOtrasDeducciones + TotalImpuestosRetenidos > 0 Then
                    AppendAttributeXML(Nomina, Doc.CreateAttribute("TotalDeducciones"), String.Format("{0:N2}", TotalOtrasDeducciones + TotalImpuestosRetenidos).Replace(",", ""))
                End If
                AppendAttributeXML(Nomina, Doc.CreateAttribute("TotalPercepciones"), String.Format("{0:N2}", TotalSueldos + TotalSeparacionIndemnizacion + TotalJubilacionPensionRetiro).Replace(",", ""))
                AppendAttributeXML(Nomina, Doc.CreateAttribute("NumDiasPagados"), Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("DiasPagados"))
                AppendAttributeXML(Nomina, Doc.CreateAttribute("FechaFinalPago"), Format(CDate(Parametros.Item(0).Substring(0, 10)), "yyyy-MM-dd"))
                AppendAttributeXML(Nomina, Doc.CreateAttribute("FechaInicialPago"), Format(CDate(Parametros.Item(1).Substring(0, 10)), "yyyy-MM-dd"))
                AppendAttributeXML(Nomina, Doc.CreateAttribute("FechaPago"), Format(CDate(Parametros.Item(2).Substring(0, 10)), "yyyy-MM-dd"))
                AppendAttributeXML(Nomina, Doc.CreateAttribute("TipoNomina"), Parametros.Item(3))
                AppendAttributeXML(Nomina, Doc.CreateAttribute("Version"), "1.2")

                Dim Empleado As DataRow = Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0)

                ' Se crea el nodo Emisor
                Dim EmisorNomina As XmlNode = Doc.CreateElement("nomina12", "Emisor", "http://www.sat.gob.mx/nomina12")
                Dim TipoRegimen As String = Me.MainDBDataSet.TipoRegimenNomina.Select("TipoRegimenNominaId=" & Empleado("TipoRegimenId"))(0).Item("TipoRegimenNominaCode")
                If TipoRegimen = "02" Or TipoRegimen = "03" Or TipoRegimen = "04" Then AppendAttributeXML(EmisorNomina, Doc.CreateAttribute("RegistroPatronal"), Me.MainDBDataSet.Emisor(0).Item("RegistroPatronal"))
                If Not Me.MainDBDataSet.Emisor(0).Item("CURP") Is System.DBNull.Value Then AppendAttributeXML(EmisorNomina, Doc.CreateAttribute("Curp"), Me.MainDBDataSet.Emisor(0).Item("CURP"))
                ' Agrega el nodo Emisor dentro del nodo Nomina
                Nomina.AppendChild(EmisorNomina)

                ' Se crea el nodo Receptor
                Dim ReceptorNomina As XmlNode = Doc.CreateElement("nomina12", "Receptor", "http://www.sat.gob.mx/nomina12")
                AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("ClaveEntFed"), Me.MainDBDataSet.Estados.Select("EstadoId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("EstadoId"))(0).Item("EstadoCode"))
                If Not Empleado("SalarioDiarioIntegrado") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("SalarioDiarioIntegrado"), String.Format("{0:N2}", Empleado("SalarioDiarioIntegrado")).Replace(",", ""))
                If Not Empleado("SalariaBaseCotApor") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("SalarioBaseCotApor"), String.Format("{0:N2}", Empleado("SalariaBaseCotApor")).Replace(",", ""))
                If Not Empleado("CuentaBancaria") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("CuentaBancaria"), Empleado("CuentaBancaria"))
                If Not Empleado("BancoId") Is System.DBNull.Value And Empleado("CuentaBancaria").ToString.Length < 18 Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Banco"), Me.MainDBDataSet.Bancos.Select("BancoId=" & Empleado("BancoId"))(0).Item("BancoCode"))
                AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("PeriodicidadPago"), Me.MainDBDataSet.Periodicidades.Select("PeriodicidadId=" & Empleado("PeriodicidadPagoId"))(0).Item("PeriodicidadCode"))
                If Me.MainDBDataSet.TipoRegimenNomina.Select("TipoRegimenNominaId=" & Empleado("TipoRegimenId"))(0).Item("TipoRegimenNominaCode") <> "09" Then
                    If Not Empleado("RiesgoPuestoId") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("RiesgoPuesto"), Me.MainDBDataSet.RiesgoPuesto.Select("RiesgoPuestoId=" & Empleado("RiesgoPuestoId"))(0).Item("RiesgoPuestoCode"))
                End If
                If Not Empleado("Puesto") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Puesto"), Empleado("Puesto"))
                If Not Empleado("Departamento") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Departamento"), Empleado("Departamento"))
                AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("NumEmpleado"), Empleado("NumEmpleado"))
                AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("TipoRegimen"), Me.MainDBDataSet.TipoRegimenNomina.Select("TipoRegimenNominaId=" & Empleado("TipoRegimenId"))(0).Item("TipoRegimenNominaCode"))
                If Not Empleado("TipoJornadaId") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("TipoJornada"), Me.MainDBDataSet.TipoJornada.Select("TipoJornadaId=" & Empleado("TipoJornadaId"))(0).Item("TipoJornadaCode"))
                If Empleado("Sindicalizado") Is System.DBNull.Value Then Empleado("Sindicalizado") = 0
                If Not Empleado("Sindicalizado") = 0 Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Sindicalizado"), IIf(Empleado("Sindicalizado") = 1, "Sí", "No"))
                AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("TipoContrato"), Me.MainDBDataSet.TipoContratos.Select("TipoContratoId=" & Empleado("TipoContratoId"))(0).Item("ContratoCode"))
                If Not Empleado("FechaInicioRelLaboral") Is System.DBNull.Value And Not Empleado("FechaInicioRelLaboral") Is String.Empty And Not Empleado("FechaInicioRelLaboral").ToString.Trim = "" Then
                    Dim Y As Long = DateDiff(DateInterval.Year, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                    Dim M As Long = DateDiff(DateInterval.Month, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                    Dim D As Long = DateDiff(DateInterval.Day, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                    Dim W As Long = DateDiff(DateInterval.WeekOfYear, CDate(Empleado("FechaInicioRelLaboral")), CDate(Parametros.Item(0).Substring(0, 10)))
                    'AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Antigüedad"), String.Format("P{0}{1}{2}{3}{4}{5}", IIf(Y = 0, "", Y), IIf(Y = 0, "", "Y"), IIf(M = 0, "", M), IIf(M = 0, "", "M"), IIf(D = 0, "", D), IIf(D = 0, "", "D")))
                    AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Antigüedad"), "P" & IIf(W <= CInt((D + 1) / 7 - 0.5), W, CInt((D + 1) / 7 - 0.5)) & "W")
                End If
                If Not Empleado("FechaInicioRelLaboral") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("FechaInicioRelLaboral"), Format(CDate(Empleado("FechaInicioRelLaboral")), "yyyy-MM-dd"))
                If Not Empleado("NumSeguridadSocial") Is System.DBNull.Value Then AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("NumSeguridadSocial"), Empleado("NumSeguridadSocial"))
                AppendAttributeXML(ReceptorNomina, Doc.CreateAttribute("Curp"), Empleado("Curp"))
                ' Agrega el nodo Receptor dentro del nodo Nomina
                Nomina.AppendChild(ReceptorNomina)

                ' Se crea el nodo Percepciones
                If Me.MainDBDataSet.PercepcionEmpleado.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                    Dim Percepciones As XmlNode = Doc.CreateElement("nomina12", "Percepciones", "http://www.sat.gob.mx/nomina12")
                    AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalExento"), String.Format("{0:N2}", TotalExento).Replace(",", ""))
                    AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalGravado"), String.Format("{0:N2}", TotalGravado).Replace(",", ""))
                    If TotalJubilacionPensionRetiro > 0 Then AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalJubilacionPensionRetiro"), String.Format("{0:N2}", TotalJubilacionPensionRetiro).Replace(",", ""))
                    If TotalSeparacionIndemnizacion > 0 Then AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalSeparacionIndemnizacion"), String.Format("{0:N2}", TotalSeparacionIndemnizacion).Replace(",", ""))
                    If TotalSueldos > 0 Then AppendAttributeXML(Percepciones, Doc.CreateAttribute("TotalSueldos"), String.Format("{0:N2}", TotalSueldos).Replace(",", ""))

                    ' Se crean los nodos Percepcion
                    For Each PercepcionEmpleado As DataRow In Me.MainDBDataSet.PercepcionEmpleado.Select("EmpleadoId=" & EmpleadoId)
                        Dim Percepcion As XmlNode = Doc.CreateElement("nomina12", "Percepcion", "http://www.sat.gob.mx/nomina12")
                        AppendAttributeXML(Percepcion, Doc.CreateAttribute("ImporteExento"), String.Format("{0:N2}", PercepcionEmpleado("ImporteExento")).Replace(",", ""))
                        AppendAttributeXML(Percepcion, Doc.CreateAttribute("ImporteGravado"), String.Format("{0:N2}", PercepcionEmpleado("ImporteGravado")).Replace(",", ""))
                        AppendAttributeXML(Percepcion, Doc.CreateAttribute("Concepto"), Me.MainDBDataSet.Percepciones.Select("PercepcionId=" & PercepcionEmpleado("PercepcionId"))(0).Item("PercepcionDesc"))
                        AppendAttributeXML(Percepcion, Doc.CreateAttribute("Clave"), PercepcionEmpleado("Clave"))
                        AppendAttributeXML(Percepcion, Doc.CreateAttribute("TipoPercepcion"), Me.MainDBDataSet.Percepciones.Select("PercepcionId=" & PercepcionEmpleado("PercepcionId"))(0).Item("PercepcionCode"))

                        ' Se crean los nodos HorasExtra
                        For Each HoraExtra As DataRow In Me.MainDBDataSet.HorasExtraPercep.Select("PercepcionEmpleadoId=" & PercepcionEmpleado("PercepcionEmpleadoId"))
                            Dim HorasExtra As XmlNode = Doc.CreateElement("nomina12", "HorasExtra", "http://www.sat.gob.mx/nomina12")
                            AppendAttributeXML(HorasExtra, Doc.CreateAttribute("ImportePagado"), String.Format("{0:N2}", HoraExtra("ImportePagado")).Replace(",", ""))
                            AppendAttributeXML(HorasExtra, Doc.CreateAttribute("HorasExtra"), HoraExtra("HorasExtra"))
                            AppendAttributeXML(HorasExtra, Doc.CreateAttribute("TipoHoras"), Me.MainDBDataSet.HorasExtra.Select("HorasExtraId=" & HoraExtra("HorasExtraId"))(0).Item("HorasExtraCode"))
                            AppendAttributeXML(HorasExtra, Doc.CreateAttribute("Dias"), HoraExtra("Dias"))
                            ' Agrega el nodo HorasExtra dentro del nodo Percepcion
                            Percepcion.AppendChild(HorasExtra)
                        Next

                        ' Se crea el nodo AccionesOTitulos
                        If Me.MainDBDataSet.AccionesOTitulos.Select("PercepcionEmpleadoId=" & PercepcionEmpleado("PercepcionEmpleadoId")).Length > 0 Then
                            Dim AccionesOTitulos As XmlNode = Doc.CreateElement("nomina12", "AccionesOTitulos", "http://www.sat.gob.mx/nomina12")
                            Dim AccionOTitulo As DataRow = Me.MainDBDataSet.AccionesOTitulos.Select("PercepcionEmpleadoId=" & PercepcionEmpleado("PercepcionEmpleadoId"))(0)
                            AppendAttributeXML(AccionesOTitulos, Doc.CreateAttribute("PrecioAlOtorgarse"), AccionOTitulo("PrecioAlOtorgarse"))
                            AppendAttributeXML(AccionesOTitulos, Doc.CreateAttribute("ValorMercado"), AccionOTitulo("ValorMercado"))
                            ' Agrega el nodo AccionesOTitulos dentro del nodo Percepcion
                            Percepcion.AppendChild(AccionesOTitulos)
                        End If

                        ' Agrega el nodo Percepcion dentro del nodo Percepciones
                        Percepciones.AppendChild(Percepcion)
                    Next

                    ' Se crea el nodo JubilacionPensionRetiro
                    If Me.MainDBDataSet.JubilacionPensionRetiro.Select("EmpleadoId=" & EmpleadoId).Length > 0 Then
                        Dim JubilacionPensionRetiro As XmlNode = Doc.CreateElement("nomina12", "JubilacionPensionRetiro", "http://www.sat.gob.mx/nomina12")
                        Dim JubilacionPensionRetiroEmpleado As DataRow = Me.MainDBDataSet.JubilacionPensionRetiro.Select("EmpleadoId=" & EmpleadoId)(0)
                        AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("IngresoNoAcumulable"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("IngresoNoAcumulable")).Replace(",", ""))
                        AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("IngresoAcumulable"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("IngresoAcumulable")).Replace(",", ""))
                        If Not JubilacionPensionRetiroEmpleado("MontoDiario") Is System.DBNull.Value Then AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("MontoDiario"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("MontoDiario")).Replace(",", ""))
                        If Not JubilacionPensionRetiroEmpleado("TotalParcialidad") Is System.DBNull.Value Then AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("TotalParcialidad"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("TotalParcialidad")).Replace(",", ""))
                        If Not JubilacionPensionRetiroEmpleado("TotalUnaExhibicion") Is System.DBNull.Value Then AppendAttributeXML(JubilacionPensionRetiro, Doc.CreateAttribute("TotalUnaExhibicion"), String.Format("{0:N2}", JubilacionPensionRetiroEmpleado("TotalUnaExhibicion")).Replace(",", ""))
                        ' Agrega el nodo JubilacionPensionRetiro dentro del nodo Percepciones
                        Percepciones.AppendChild(JubilacionPensionRetiro)
                    End If

                    ' Se crea el nodo SeparacionIndemnizacion
                    If Me.MainDBDataSet.SeparacionIndemnizacion.Select("EmpleadoId=" & EmpleadoId).Length > 0 Then
                        Dim SeparacionIndemnizacion As XmlNode = Doc.CreateElement("nomina12", "SeparacionIndemnizacion", "http://www.sat.gob.mx/nomina12")
                        Dim SeparacionIndemnizacionEmpleado As DataRow = Me.MainDBDataSet.SeparacionIndemnizacion.Select("EmpleadoId=" & EmpleadoId)(0)
                        AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("IngresoNoAcumulable"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("IngresoNoAcumulable")).Replace(",", ""))
                        AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("IngresoAcumulable"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("IngresoAcumulable")).Replace(",", ""))
                        AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("UltimoSueldoMensOrd"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("UltimoSueldoMensOrd")).Replace(",", ""))
                        AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("NumAñosServicio"), SeparacionIndemnizacionEmpleado("NumAniosServicio"))
                        AppendAttributeXML(SeparacionIndemnizacion, Doc.CreateAttribute("TotalPagado"), String.Format("{0:N2}", SeparacionIndemnizacionEmpleado("TotalPagado")).Replace(",", ""))
                        ' Agrega el nodo SeparacionIndemnizacion dentro del nodo Percepciones
                        Percepciones.AppendChild(SeparacionIndemnizacion)
                    End If

                    ' Agrega el nodo Percepciones dentro del nodo Nomina
                    Nomina.AppendChild(Percepciones)
                End If

                ' Se crea el nodo Deducciones
                If Me.MainDBDataSet.DeduccionEmpleado.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                    Dim Deducciones As XmlNode = Doc.CreateElement("nomina12", "Deducciones", "http://www.sat.gob.mx/nomina12")
                    If TotalImpuestosRetenidos > 0 Then AppendAttributeXML(Deducciones, Doc.CreateAttribute("TotalImpuestosRetenidos"), String.Format("{0:N2}", TotalImpuestosRetenidos).Replace(",", ""))
                    If TotalOtrasDeducciones > 0 Then AppendAttributeXML(Deducciones, Doc.CreateAttribute("TotalOtrasDeducciones"), String.Format("{0:N2}", TotalOtrasDeducciones).Replace(",", ""))

                    ' Se crean los nodos Deduccion
                    For Each DeduccionEmpleado As DataRow In Me.MainDBDataSet.DeduccionEmpleado.Select("EmpleadoId=" & EmpleadoId)
                        Dim Deduccion As XmlNode = Doc.CreateElement("nomina12", "Deduccion", "http://www.sat.gob.mx/nomina12")
                        AppendAttributeXML(Deduccion, Doc.CreateAttribute("Importe"), String.Format("{0:N2}", DeduccionEmpleado("Importe")).Replace(",", ""))
                        AppendAttributeXML(Deduccion, Doc.CreateAttribute("Concepto"), Me.MainDBDataSet.Deducciones.Select("DeduccionId=" & DeduccionEmpleado("DeduccionId"))(0).Item("DeduccionDesc"))
                        AppendAttributeXML(Deduccion, Doc.CreateAttribute("Clave"), DeduccionEmpleado("Clave"))
                        AppendAttributeXML(Deduccion, Doc.CreateAttribute("TipoDeduccion"), Me.MainDBDataSet.Deducciones.Select("DeduccionId=" & DeduccionEmpleado("DeduccionId"))(0).Item("DeduccionCode"))
                        ' Agrega el nodo Deduccion dentro del nodo Deducciones
                        Deducciones.AppendChild(Deduccion)
                    Next

                    ' Agrega el nodo Deducciones dentro del nodo Nomina
                    Nomina.AppendChild(Deducciones)
                End If

                ' Se crea el nodo OtrosPagos
                If Me.MainDBDataSet.OtrosPagos.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                    Dim OtrosPagos As XmlNode = Doc.CreateElement("nomina12", "OtrosPagos", "http://www.sat.gob.mx/nomina12")

                    ' Se crean los nodos OtroPago
                    For Each OtroPagoEmpleado As DataRow In Me.MainDBDataSet.OtrosPagos.Select("EmpleadoId=" & EmpleadoId)
                        Dim OtroPago As XmlNode = Doc.CreateElement("nomina12", "OtroPago", "http://www.sat.gob.mx/nomina12")
                        AppendAttributeXML(OtroPago, Doc.CreateAttribute("Importe"), String.Format("{0:N2}", OtroPagoEmpleado("Importe")).Replace(",", ""))
                        AppendAttributeXML(OtroPago, Doc.CreateAttribute("Concepto"), Me.MainDBDataSet.TipoOtroPago.Select("TipoOtroPagoId=" & OtroPagoEmpleado("TipoOtroPagoId"))(0).Item("OtroPagoDesc"))
                        AppendAttributeXML(OtroPago, Doc.CreateAttribute("Clave"), OtroPagoEmpleado("Clave"))
                        AppendAttributeXML(OtroPago, Doc.CreateAttribute("TipoOtroPago"), Me.MainDBDataSet.TipoOtroPago.Select("TipoOtroPagoId=" & OtroPagoEmpleado("TipoOtroPagoId"))(0).Item("OtroPagoCode"))

                        ' Se crea el nodo SubsidioAlEmpleo
                        'Dim subsidioBool As Boolean = False
                        If Me.MainDBDataSet.SubsidioAlEmpleo.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId")).Length > 0 Then
                            'subsidioBool = True
                            Dim SubsidioAlEmpleo As XmlNode = Doc.CreateElement("nomina12", "SubsidioAlEmpleo", "http://www.sat.gob.mx/nomina12")
                            Dim SubsidioAlEmpleoEmpleado As DataRow = Me.MainDBDataSet.SubsidioAlEmpleo.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId"))(0)
                            AppendAttributeXML(SubsidioAlEmpleo, Doc.CreateAttribute("SubsidioCausado"), String.Format("{0:N2}", SubsidioAlEmpleoEmpleado("SubsidioCausado")).Replace(",", ""))
                            ' Agrega el nodo SeparacionIndemnizacion dentro del nodo OtroPago
                            OtroPago.AppendChild(SubsidioAlEmpleo)
                        End If

                        ' Se crea el nodo CompensacionSaldosAFavor
                        If Me.MainDBDataSet.CompensacionSaldosAFavor.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId")).Length > 0 Then
                            Dim CompensacionSaldosAFavor As XmlNode = Doc.CreateElement("nomina12", "CompensacionSaldosAFavor", "http://www.sat.gob.mx/nomina12")
                            Dim CompensacionSaldosAFavorEmpleado As DataRow = Me.MainDBDataSet.CompensacionSaldosAFavor.Select("OtroPagoId=" & OtroPagoEmpleado("OtroPagoId"))(0)
                            AppendAttributeXML(CompensacionSaldosAFavor, Doc.CreateAttribute("RemanenteSalFav"), String.Format("{0:N2}", CompensacionSaldosAFavorEmpleado("RemanenteSalFav")).Replace(",", ""))
                            AppendAttributeXML(CompensacionSaldosAFavor, Doc.CreateAttribute("Año"), CompensacionSaldosAFavorEmpleado("Anio"))
                            AppendAttributeXML(CompensacionSaldosAFavor, Doc.CreateAttribute("SaldoAFavor"), String.Format("{0:N2}", CompensacionSaldosAFavorEmpleado("SaldoAFavor")).Replace(",", ""))
                            ' Agrega el nodo CompensacionSaldosAFavor dentro del nodo OtroPago
                            OtroPago.AppendChild(CompensacionSaldosAFavor)
                        End If

                        ' Agrega el nodo OtroPago dentro del nodo OtrosPagos
                        OtrosPagos.AppendChild(OtroPago)
                    Next

                    ' Agrega el nodo OtrosPagos dentro del nodo Nomina
                    Nomina.AppendChild(OtrosPagos)
                End If

                ' Se crea el nodo Incapacidades
                If Me.MainDBDataSet.Incapacidades.Select("EmpleadoId=" & EmpleadoId).Count > 0 Then
                    Dim Incapacidades As XmlNode = Doc.CreateElement("nomina12", "Incapacidades", "http://www.sat.gob.mx/nomina12")

                    ' Se crean los nodos Incapacidad
                    For Each IncapacidadEmpleado As DataRow In Me.MainDBDataSet.Incapacidades.Select("EmpleadoId=" & EmpleadoId)
                        Dim Incapacidad As XmlNode = Doc.CreateElement("nomina12", "Incapacidad", "http://www.sat.gob.mx/nomina12")
                        If IncapacidadEmpleado("ImporteMonetario") > 0 Then AppendAttributeXML(Incapacidad, Doc.CreateAttribute("ImporteMonetario"), String.Format("{0:N2}", IncapacidadEmpleado("ImporteMonetario")).Replace(",", ""))
                        AppendAttributeXML(Incapacidad, Doc.CreateAttribute("TipoIncapacidad"), Me.MainDBDataSet.TipoIncapacidad.Select("TipoIncapacidadId=" & IncapacidadEmpleado("TipoIncapacidadId"))(0).Item("TipoIncapCode"))
                        AppendAttributeXML(Incapacidad, Doc.CreateAttribute("DiasIncapacidad"), IncapacidadEmpleado("DiasIncapacidad"))
                        ' Agrega el nodo Incapacidad dentro del nodo Incapacidades
                        Incapacidades.AppendChild(Incapacidad)
                    Next

                    ' Agrega el nodo Incapacidades dentro del nodo Nomina
                    Nomina.AppendChild(Incapacidades)
                End If

                ' Agrega el nodo Nomina dentro del nodo Complemento
                Complemento.AppendChild(Nomina)

                ' Agrega el nodo Complemento dentro del nodo Comprobante
                Comprobante.AppendChild(Complemento)

                NominaBackgroundWorker.ReportProgress(3)

                ' Convierte a memorystream
                Dim msXML As New MemoryStream
                Dim writer As New XmlTextWriter(msXML, UTF8WithoutBOM)
                Doc.Save(writer)
                Try
                    Doc.Save("cfdiNom.xml")
                Catch ex As Exception
                    Exit Try
                End Try
                ' Genera la cadena original
                Dim msChain As MemoryStream = New MemoryStream()
                Dim tw As XmlTextWriter = New XmlTextWriter(msChain, UTF8WithoutBOM)
                Dim xslt As XslCompiledTransform = New XslCompiledTransform()
                xslt.Load(Application.StartupPath & "\Esquemas\cadenaoriginal_3_3.xslt")
                msXML.Position = 0
                Dim xp As XPathDocument = New XPathDocument(msXML)
                xslt.Transform(xp, tw)
                Dim CadOrig As String = ReemplazaCaracteres(UTF8WithoutBOM.GetString(msChain.ToArray()))

                ' Firma con la llave privada
                Dim privateKey As RSACryptoServiceProvider = Certificado.PrivateKey
                Dim privateKey1 As RSACryptoServiceProvider = New RSACryptoServiceProvider()
                privateKey1.ImportParameters(privateKey.ExportParameters(True))

                'Dim sha1 As SHA256CryptoServiceProvider = New SHA256CryptoServiceProvider()
                msChain.Position = 0
                'Dim rsa1 As RSACryptoServiceProvider = Certificado.PrivateKey
                Dim sello As String = Convert.ToBase64String(privateKey1.SignData(UTF8WithoutBOM.GetBytes(CadOrig.ToCharArray), "SHA256"))
                Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Sello").Value = sello

                NominaBackgroundWorker.ReportProgress(4)

                ' Valida
                validSchema = True
                Dim eventHandler As New ValidationEventHandler(AddressOf ValidationEventHandler)
                Doc.Schemas.Add("http://www.sat.gob.mx/cfd/3", Application.StartupPath & "\Esquemas\cfdv33.xsd")
                Doc.Schemas.Add("http://www.sat.gob.mx/nomina12", Application.StartupPath & "\Esquemas\Complementos\nomina12.xsd")
                'Doc.Validate(eventHandler)

                If validSchema = True Then
                    NominaBackgroundWorker.ReportProgress(5)
                    Dim url As String = "http://services.sw.com.mx"
                    Dim user As String = "timbradonom@mobilemetriks.com"
                    Dim pass As String = "moBile18#"
                    If TestFlag Then
                        url = "http://services.test.sw.com.mx"
                        user = "richard@mobilemetriks.com"
                        pass = "mobile18"
                    End If
                    Try
                        Dim stamp As New Stamp(url, user, pass)
                        Dim xml As String = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(Doc.OuterXml))
                        Dim response As StampResponseV3 = stamp.TimbrarV3(xml, True)
                        If Not response.data Is Nothing Then
                            Doc.LoadXml(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(response.data.cfdi)))
                            Try
                                WS.ActualizaSysInfo(Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"))
                            Catch ex As Exception
                                MsgBox("No se realizó el registro, favor de contactar a soporte técnico", , "Advertencia")
                            End Try
                            'Consola.AppendText("Ok - Timbrado")
                            'Return True
                        Else
                            MsgBox(response.message & " " & response.messageDetail, , "No se realizó el timbrado")
                            Exit Sub
                            'Return False
                            'MessageBox.Show("No se realizó el timbrado. " & response.message & " " & response.messageDetail)
                        End If
                        'Catch ex As Exception
                        '    MsgBox(ex.ToString, , "No se realizó el timbrado")
                        '    Exit Sub
                        'End Try
                        'Doc.Save(Application.StartupPath & "\cfdi.xml")
                        'Dim MensajeIncidencia As String = ""
                        'Dim CodigoIncidencia As String = ""

                        'ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType) Or SecurityProtocolType.Ssl3 Or CType(192, SecurityProtocolType) Or CType(768, SecurityProtocolType)
                        'Try
                        '    'Console.WriteLine("AQUI")
                        '    'Console.Read()
                        '    'Dim SelloSAT As String = ""
                        '    'Dim noCertificadoSAT As String = ""
                        '    'Dim FechaTimbrado As String = ""
                        '    'Dim uuid As String = ""
                        '    'Dim xmlTimbrado As String = ""
                        '    Dim xmlCfdi As New System.Xml.XmlDocument()
                        '    Dim timbrado
                        '    Dim timb
                        '    Dim ResponseTimbrar
                        '    If TestFlag Then
                        '        timbrado = New DemoFinkok.StampSOAP
                        '        timb = New DemoFinkok.stamp ' stamp
                        '        ResponseTimbrar = New DemoFinkok.stampResponse ' stampResponse
                        '        timb.password = "&2Bdk2yA"
                        '    Else
                        '        timbrado = New Finkok.StampSOAP ' cfdi2.com.finkok.demofacturacion.StampSOAP
                        '        timb = New Finkok.stamp ' stamp
                        '        ResponseTimbrar = New Finkok.stampResponse ' stampResponse
                        '        timb.password = "B9h/Ww8q"
                        '    End If

                        '    'xmlCfdi.Load(XML) 'Cargamos el archivo XML.
                        '    timb.xml = Convert.FromBase64String(Convert.ToBase64String(UTF8WithoutBOM.GetBytes(Doc.OuterXml))) ' stringToBase64ByteArray(Doc.OuterXml) 'El archivo XML se envia en Base64.
                        '    timb.username = "direccion@mobilemetriks.com"

                        '    'Las siguientes lineas de codigo son para obtener la petición soap REQUEST de timbrado
                        '    'Dim url As String
                        '    'Dim usuario As String
                        '    'usuario = Environment.UserName
                        '    'url = "C:\Users\" & usuario & "\Documents\"
                        '    'Dim XML = New StreamWriter(Application.StartupPath & "\SOAP_EnvelopTimbrado.xml")     'Dirección donde guardaremos el SOAP Envelope
                        '    Dim XML As New MemoryStream
                        '    Dim soap = New Serialization.XmlSerializer(timb.GetType())    'Obtenemos los datos del SOAP de la variable timb
                        '    soap.Serialize(XML, timb)            'Serializa el timbrado y escribe el documento XML con el archivo con Stream especificado.
                        '    XML.Close()
                        '    'Mandamos llamar al web services y se envían los parámetros en la variable timb
                        '    ResponseTimbrar = timbrado.stamp(timb)
                        '    If TestFlag Then
                        '        If DirectCast(ResponseTimbrar.stampResult, DemoFinkok.AcuseRecepcionCFDI).Incidencias.Length > 0 Then
                        '            CodigoIncidencia = DirectCast(ResponseTimbrar.stampResult, DemoFinkok.AcuseRecepcionCFDI).Incidencias(0).CodigoError
                        '            MensajeIncidencia = DirectCast(ResponseTimbrar.stampResult, DemoFinkok.AcuseRecepcionCFDI).Incidencias(0).MensajeIncidencia
                        '        Else
                        '            CodigoIncidencia = "000"
                        '            MensajeIncidencia = "Timbrado Satisfactorio"
                        '        End If
                        '        'Console.WriteLine("No se realizo el timbrado ")
                        '        If CodigoIncidencia = "000" Then
                        '            'uuid = ResponseTimbrar.stampResult.UUID
                        '            'xmlTimbrado = ResponseTimbrar.stampResult.xml
                        '            'FechaTimbrado = ResponseTimbrar.stampResult.Fecha
                        '            'SelloSAT = ResponseTimbrar.stampResult.SatSeal
                        '            'noCertificadoSAT = ResponseTimbrar.stampResult.NoCertificadoSAT
                        '            Doc.LoadXml(ResponseTimbrar.stampResult.xml) 'xmlCfdi.LoadXml(xmlTimbrado)
                        '            'Consola.AppendText(CodigoIncidencia)
                        '            Try
                        '                'Dim fila1 As DataRow = WebSAF_MOB100617FNADataSet.Tables("Emisores").Rows(0)
                        '                'Dim RFC As String = fila1("RFC")
                        '                WS.ActualizaSysInfo(Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"))
                        '            Catch ex As Exception

                        '            End Try
                        '            NominaBackgroundWorker.ReportProgress(6)

                        '            'xmlCfdi.Save(XML)
                        '            'txtUUID.Text = uuid
                        '        ElseIf CodigoIncidencia = "707" Then
                        '            Dim ResponseIsTimbrado As New DemoFinkok.stampedResponse
                        '            Dim isTimbrado As New DemoFinkok.stamped
                        '            isTimbrado.xml = Convert.FromBase64String(Convert.ToBase64String(UTF8WithoutBOM.GetBytes(xmlCfdi.OuterXml)))
                        '            isTimbrado.username = "direccion@mobilemetriks.com"
                        '            isTimbrado.password = "&2Bdk2yA"
                        '            ResponseIsTimbrado = timbrado.stamped(isTimbrado)
                        '            'uuid = ResponseIsTimbrado.stampedResult.UUID
                        '            'xmlTimbrado = ResponseIsTimbrado.stampedResult.xml
                        '            'FechaTimbrado = ResponseIsTimbrado.stampedResult.Fecha
                        '            'SelloSAT = ResponseIsTimbrado.stampedResult.SatSeal
                        '            'noCertificadoSAT = ResponseIsTimbrado.stampedResult.NoCertificadoSAT
                        '            Doc.LoadXml(ResponseIsTimbrado.stampedResult.xml) 'xmlCfdi.LoadXml(xmlTimbrado)
                        '            'Consola.AppendText(CodigoIncidencia)
                        '            NominaBackgroundWorker.ReportProgress(6)
                        '            Try
                        '                WS.ActualizaSysInfo(Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"))
                        '            Catch ex As Exception
                        '                Exit Try
                        '            End Try


                        '            'xmlCfdi.Save(XML)
                        '            'txtUUID.Text = uuid
                        '        Else
                        '            'MessageBox.Show(MensajeIncidencia)
                        '            'ErrorXML = MensajeIncidencia
                        '            'TimbreBackgroundWorker.ReportProgress(0)
                        '            'TimbreBackgroundWorker.CancelAsync()
                        '            NominaBackgroundWorker.ReportProgress(0)
                        '            ErrorXML = CodigoIncidencia & " - " & MensajeIncidencia
                        '            Exit Try
                        '            'MessageBox.Show(MensajeIncidencia)

                        '        End If
                        '    Else
                        '        If DirectCast(ResponseTimbrar.stampResult, Finkok.AcuseRecepcionCFDI).Incidencias.Length > 0 Then
                        '            CodigoIncidencia = DirectCast(ResponseTimbrar.stampResult, Finkok.AcuseRecepcionCFDI).Incidencias(0).CodigoError
                        '            MensajeIncidencia = DirectCast(ResponseTimbrar.stampResult, Finkok.AcuseRecepcionCFDI).Incidencias(0).MensajeIncidencia
                        '        Else
                        '            CodigoIncidencia = "000"
                        '            MensajeIncidencia = "Timbrado Satisfactorio"
                        '        End If
                        '        'Console.WriteLine("No se realizo el timbrado ")
                        '        If CodigoIncidencia = "000" Then
                        '            'uuid = ResponseTimbrar.stampResult.UUID
                        '            'xmlTimbrado = ResponseTimbrar.stampResult.xml
                        '            'FechaTimbrado = ResponseTimbrar.stampResult.Fecha
                        '            'SelloSAT = ResponseTimbrar.stampResult.SatSeal
                        '            'noCertificadoSAT = ResponseTimbrar.stampResult.NoCertificadoSAT
                        '            Doc.LoadXml(ResponseTimbrar.stampResult.xml) 'xmlCfdi.LoadXml(xmlTimbrado)
                        '            Try
                        '                WS.ActualizaSysInfo(Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"))
                        '            Catch ex As Exception

                        '            End Try
                        '            NominaBackgroundWorker.ReportProgress(6)
                        '            'xmlCfdi.Save(XML)
                        '            'txtUUID.Text = uuid
                        '        ElseIf CodigoIncidencia = "707" Then
                        '            Dim ResponseIsTimbrado As New Finkok.stampedResponse
                        '            Dim isTimbrado As New Finkok.stamped
                        '            isTimbrado.xml = Convert.FromBase64String(Convert.ToBase64String(UTF8WithoutBOM.GetBytes(xmlCfdi.OuterXml)))
                        '            isTimbrado.username = "direccion@mobilemetriks.com"
                        '            isTimbrado.password = "&2Bdk2yA"
                        '            ResponseIsTimbrado = timbrado.stamped(isTimbrado)
                        '            'uuid = ResponseIsTimbrado.stampedResult.UUID
                        '            'xmlTimbrado = ResponseIsTimbrado.stampedResult.xml
                        '            'FechaTimbrado = ResponseIsTimbrado.stampedResult.Fecha
                        '            'SelloSAT = ResponseIsTimbrado.stampedResult.SatSeal
                        '            'noCertificadoSAT = ResponseIsTimbrado.stampedResult.NoCertificadoSAT
                        '            Doc.LoadXml(ResponseIsTimbrado.stampedResult.xml) 'xmlCfdi.LoadXml(xmlTimbrado)
                        '            Try
                        '                WS.ActualizaSysInfo(Me.MainDBDataSet.Emisor.Rows(0).Item("RFC"))
                        '            Catch ex As Exception

                        '            End Try
                        '            NominaBackgroundWorker.ReportProgress(6)
                        '            'xmlCfdi.Save(XML)
                        '            'txtUUID.Text = uuid
                        '        Else
                        '            'MessageBox.Show(MensajeIncidencia)
                        '            'ErrorXML = MensajeIncidencia
                        '            'TimbreBackgroundWorker.ReportProgress(0)
                        '            'TimbreBackgroundWorker.CancelAsync()
                        '            NominaBackgroundWorker.ReportProgress(0)
                        '            ErrorXML = CodigoIncidencia & " - " & MensajeIncidencia
                        '            Exit Try
                        '        End If

                        '        'MessageBox.Show("Timbrado exitoso.")
                        '    End If


                        ComprobantesTableAdapter.Insert(2,
                     100,
                    vbNull,
                    Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("SerieId"),
                    Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("FolioActual"),
                    ObtieneFecha,
                    ObtieneFecha,
                    "3.3",
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Descuento").Value,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("SubTotal").Value,
                    0.0,
                    TotalImpuestosRetenidos,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Total").Value,
                    EmpleadoId,
                     Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("UUID").Value,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("NoCertificado").Value,
                    Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("TipoCambio").Value,
                    20)

                        Dim ComprobanteId As Integer = Convert.ToInt64(ComprobantesTableAdapter.GetComprobanteId)
                        CFDIsTableAdapter.Insert(ComprobanteId, msXML.ToArray, {vbNull}, {vbNull})

                        Me.MainDBDataSet.Series.Select("TipoCfdiId=4 AND SucursalId=" & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("SucursalId"))(0).Item("FolioActual") += 1
                        SeriesTableAdapter.Update(Me.MainDBDataSet.Series)

                        NominaBackgroundWorker.ReportProgress(7)

                        ' Convierte a memorystream
                        Dim msXML_TFD As MemoryStream = New MemoryStream
                        Dim writer_TFD As XmlTextWriter = New XmlTextWriter(msXML_TFD, UTF8WithoutBOM)
                        Dim timbre As XmlNode = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0)
                        Dim docTimbre As New XmlDocument()
                        docTimbre.CreateXmlDeclaration("1.0", "UTF-8", "")
                        docTimbre.AppendChild(docTimbre.ImportNode(timbre, True))
                        docTimbre.Save(writer_TFD)

                        ' Genera la cadena original
                        Dim CadenaOriginal_TFD As String = ""
                        For i = 1 To 5
                            msChain = New MemoryStream()
                            Try
                                tw = New XmlTextWriter(msChain, UTF8WithoutBOM)
                                xslt = New XslCompiledTransform()
                                xslt.Load(Application.StartupPath & "\Esquemas\cadenaoriginal_TFD_1_1.xslt")
                                msXML_TFD.Position = 0
                                xp = New XPathDocument(msXML_TFD)
                                xslt.Transform(xp, tw)
                                CadenaOriginal_TFD = System.Text.Encoding.ASCII.GetString(msChain.ToArray).Normalize
                                Exit For
                            Catch ex As Exception
                                Exit Try
                            End Try
                        Next

                        NominaBackgroundWorker.ReportProgress(8)

                        ' Genera archivo PDF
                        Dim imagenCBB As New System.IO.MemoryStream
                        GeneraCBB(imagenCBB, String.Format("?re={0}&rr={1}&tt={2:0000000000.000000}&id={3}", Doc.GetElementsByTagName("Emisor", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Rfc").Value, Doc.GetElementsByTagName("Receptor", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Rfc").Value, Total, Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("UUID").Value))
                        Me.MainDBDataSet.Adicionales.Rows.Clear()
                        Dim Adicionales As DataRow = Me.MainDBDataSet.Adicionales.NewRow
                        Adicionales("Serie") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Serie").Value
                        Adicionales("Folio") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Folio").Value
                        Adicionales("TipoNomina") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TipoNomina").Value
                        Adicionales("FechaPago") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaPago").Value
                        Adicionales("FechaInicialPago") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaInicialPago").Value
                        Adicionales("FechaFinalPago") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaFinalPago").Value
                        Adicionales("FechaEmision") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Fecha").Value
                        Adicionales("FechaTimbrado") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("FechaTimbrado").Value
                        Adicionales("FolioFiscal") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("UUID").Value
                        Adicionales("CertificadoEmisor") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("NoCertificado").Value
                        Adicionales("CertificadoSAT") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("NoCertificadoSAT").Value
                        Adicionales("TotalPercepciones") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TotalPercepciones").Value
                        Adicionales("Observacion") = observaciones
                        Try
                            Adicionales("TotalDeducciones") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TotalDeducciones").Value
                        Catch ex As Exception
                            Adicionales("TotalDeducciones") = 0
                        End Try
                        Try
                            Adicionales("TotalOtrosPagos") = Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("TotalOtrosPagos").Value
                        Catch ex As Exception
                            Adicionales("TotalOtrosPagos") = 0
                        End Try
                        Adicionales("Total") = Doc.GetElementsByTagName("Comprobante", "http://www.sat.gob.mx/cfd/3")(0).Attributes("Total").Value
                        Adicionales("SelloCFDI") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("SelloCFD").Value
                        Adicionales("SelloSAT") = Doc.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")(0).Attributes("SelloSAT").Value
                        Adicionales("CadenaOriginalTFD") = CadenaOriginal_TFD
                        Adicionales("CBB") = imagenCBB.ToArray
                        Me.MainDBDataSet.Adicionales.Rows.Add(Adicionales)

                        Dim filaEmpleado As DataRow = Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0)
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
                        Dim NombreEmpleado As String = Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoId)(0).Item("Nombre").ToString
                        rv.DataSources.Clear()
                        rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Emisor", Me.MainDBDataSet.Tables("Emisor")))
                        rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Empleados", {filaEmpleado})) 'Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)))
                        rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("PercepcionEmpleado", Me.MainDBDataSet.Tables("PercepcionEmpleado").Select("EmpleadoId=" & EmpleadoId)))
                        rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Percepciones", Me.MainDBDataSet.Tables("Percepciones")))
                        rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DeduccionEmpleado", Me.MainDBDataSet.Tables("DeduccionEmpleado").Select("EmpleadoId=" & EmpleadoId)))
                        rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Deducciones", Me.MainDBDataSet.Tables("Deducciones")))
                        rv.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Adicionales", Me.MainDBDataSet.Tables("Adicionales")))
                        rv.ReportPath = Application.StartupPath & "\Informes\CFDIv33-ReciboNomina.rdlc"

                        Dim PDFByteArray As Byte() = rv.Render("PDF", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                        NominaBackgroundWorker.ReportProgress(9)

                        ' Guarda registro en tabla Comprobantes
                        CFDIsTableAdapter.UpdatePDFOriginal(PDFByteArray, ComprobanteId)

                        NominaBackgroundWorker.ReportProgress(10)

                        ' Genera correo electrónico
                        Dim Correo As New MailMessage
                        Dim Cliente As New SmtpClient
                        msXML = New MemoryStream
                        writer = New XmlTextWriter(msXML, UTF8WithoutBOM)
                        Doc.Save(writer)
                        msXML.Position = 0

                        Correo.Attachments.Add(New Attachment(msXML, Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("CURP").ToString & ".xml"))
                        Correo.Attachments.Add(New Attachment(New MemoryStream(PDFByteArray), Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("CURP").ToString & ".pdf"))
                        Correo.From = New MailAddress(IIf(Me.MainDBDataSet.Emisor(0).Item("Correo").ToString = "", "comprobante-electronico@mobilemetriks.com", Me.MainDBDataSet.Emisor(0).Item("Correo").ToString))
                        Correo.To.Add(Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("Correos"))
                        Correo.Subject = "Recibo de nómina " & Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("CURP")
                        Correo.Body = String.Format("Estimado {1}{0}{0}Encuentra anexos a este correo los archivos correspondientes a tu recibo de nómina del {2} al {3}.", vbCrLf,
                                                Me.MainDBDataSet.Tables("Empleados").Select("EmpleadoId=" & EmpleadoId)(0).Item("Nombre"),
                                                Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaInicialPago").Value,
                                                Doc.GetElementsByTagName("Nomina", "http://www.sat.gob.mx/nomina12")(0).Attributes("FechaFinalPago").Value)
                        Cliente.Host = "mail.mobilemetriks.com"
                        Cliente.Port = 587
                        Cliente.Credentials = New System.Net.NetworkCredential("comprobante-electronico@mobilemetriks.com", "cfdisaf2014")
                        Cliente.Send(Correo)

                        NominaBackgroundWorker.ReportProgress(11)

                    Catch ex As Exception
                        ErrorXML = ex.Message
                        NominaBackgroundWorker.ReportProgress(0)
                    End Try


                    'Try
                    '    File.Delete(Application.StartupPath & "\cfdit.zip")
                    'Catch ex As Exception
                    '    Exit Try
                    'End Try

                    'Try
                    '    Directory.Delete(Application.StartupPath & "\Timbre", True)
                    'Catch ex As Exception
                    '    Exit Try
                    'End Try

                    'Try
                    '    File.Delete(Application.StartupPath & "\cfdi.xml")
                    'Catch ex As Exception
                    '    Exit Try
                    'End Try

                    'Try
                    '    File.Delete(Application.StartupPath & "\cfdi.zip")
                    'Catch ex As Exception
                    '    Exit Try
                    'End Try

                    'Try
                    '    File.Delete(Application.StartupPath & "\cfdit.zip")
                    'Catch ex As Exception
                    '    Exit Try
                    'End Try

                    'Try
                    '    Directory.Delete(Application.StartupPath & "\Timbre")
                    'Catch ex As Exception
                    '    Exit Try
                    'End Try

                End If
                Try
                    Doc.Save("cfdiNom.xml")
                Catch ex As Exception
                    Exit Try
                End Try

                'Process.Start("explorer.exe", "C:\SAF\" & EmpleadoId & ".xml")
                'System.Threading.Thread.Sleep(2000)
            End If
        Next
    End Sub

    Sub ValidationEventHandler(ByVal sender As Object, ByVal e As ValidationEventArgs)
        ErrorXML = e.Message
        NominaBackgroundWorker.ReportProgress(0)
        validSchema = False
    End Sub

    Private Sub NominaBackgroundWorker_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles NominaBackgroundWorker.ProgressChanged
        Dim EmpleadoItem As ListViewItem = EmpleadosListView.FindItemWithText(EmpleadoNominaId)

        Select Case e.ProgressPercentage
            Case 0
                EmpleadoItem.SubItems(2).Text = ErrorXML
            Case 1
                EmpleadoItem.SubItems(2).Text = "Calculando nómina del empleado"
            Case 2
                EmpleadoItem.SubItems(2).Text = "Generando XML"
            Case 3
                EmpleadoItem.SubItems(2).Text = "Firmando XML"
            Case 4
                EmpleadoItem.SubItems(2).Text = "Validando estructura del XML"
            Case 5
                EmpleadoItem.SubItems(2).Text = "Timbrando XML"
            Case 6
                EmpleadoItem.SubItems(2).Text = "Actualizando registro"
            Case 7
                EmpleadoItem.SubItems(2).Text = "Generando cadena original del TFD"
            Case 8
                EmpleadoItem.SubItems(2).Text = "Generando versión impresa PDF"
            Case 9
                EmpleadoItem.SubItems(2).Text = "Insertando datos"
            Case 10
                EmpleadoItem.SubItems(2).Text = "Enviando recibo a: " & Me.MainDBDataSet.Empleados.Select("EmpleadoId=" & EmpleadoNominaId)(0).Item("Correos")
            Case 11
                EmpleadoItem.SubItems(2).Text = "Recibo enviado exitosamente. Proceso concluido."
            Case 12
                EmpleadoItem.SubItems(2).Text = "No tienes folios restantes, favor de solicitar más."
        End Select
    End Sub

    Private Sub NominaBackgroundWorker_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles NominaBackgroundWorker.RunWorkerCompleted
        Dim EmpleadoItem As ListViewItem = EmpleadosListView.FindItemWithText(EmpleadoNominaId)
        ParametrosPanel.Enabled = True
        CalculoNominaPanel.Enabled = True
        MsgBox("Proceso concluido.", MsgBoxStyle.Information, "Generación de nómina")
    End Sub

    Private Sub EmpleadosDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles EmpleadosDataGridView.DataError
        Dim ErrorValidacion As String = ""
        Dim Empleado As DataGridViewRow = EmpleadosDataGridView.CurrentRow

        If Empleado.Cells("SucursalId").Value Is System.DBNull.Value Then
            ErrorValidacion &= "El campo ""Sucursal"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("Activo").Value Is System.DBNull.Value Then
            ErrorValidacion &= "El campo ""Activo"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("DiasPagados").Value Is System.DBNull.Value Or Not IsNumeric(Empleado.Cells("DiasPagados").Value) Then
            ErrorValidacion &= "El campo ""Núm. días pagados"" es obligatorio" & vbCrLf
        End If

        If Not IsNumeric(Empleado.Cells("DiasPagados").Value) Then
            ErrorValidacion &= "El campo ""Núm. días pagados"" debe ser numérico" & vbCrLf
        End If

        If Empleado.Cells("Nombre").Value Is System.DBNull.Value Or Empleado.Cells("Nombre").Value.ToString = "" Then
            ErrorValidacion &= "El campo ""Nombre"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("CURP").Value Is System.DBNull.Value Or Empleado.Cells("CURP").Value.ToString = "" Then
            ErrorValidacion &= "El campo ""CURP"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("TipoContratoId").Value Is System.DBNull.Value Then
            ErrorValidacion &= "El campo ""Tipo de contrato"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("TipoRegimenNominaId").Value Is System.DBNull.Value Then
            ErrorValidacion &= "El campo ""Tipo de régimen"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("NumEmpleado").Value Is System.DBNull.Value Or Empleado.Cells("NumEmpleado").Value.ToString = "" Then
            ErrorValidacion &= "El campo ""Núm. empleado"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("PeriodicidadId").Value Is System.DBNull.Value Then
            ErrorValidacion &= "El campo ""Periodicidad de pago"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("EstadoId").Value Is System.DBNull.Value Then
            ErrorValidacion &= "El campo ""Entidad"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("RFC").Value Is System.DBNull.Value Or Empleado.Cells("RFC").Value.ToString = "" Then
            ErrorValidacion &= "El campo ""RFC"" es obligatorio" & vbCrLf
        End If

        If Empleado.Cells("Correos").Value Is System.DBNull.Value Or Empleado.Cells("Correos").Value.ToString = "" Then
            ErrorValidacion &= "El campo ""Correos"" es obligatorio" & vbCrLf
        End If

        If ErrorValidacion <> "" Then
            Empleado.ErrorText = ErrorValidacion
            e.Cancel = True
        End If
    End Sub

    Private Sub EmpleadosDataGridView_RowValidating(sender As System.Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles EmpleadosDataGridView.RowValidating
        Dim ErrorValidacion As String = ""
        If EmpleadosDataGridView.IsCurrentRowDirty Then Exit Sub
        Dim Empleado As DataGridViewRow = EmpleadosDataGridView.CurrentRow
        If Empleado.IsNewRow Then Exit Sub

        Try
            If Empleado.Cells("TipoRegimenNominaId").Value = 4 Or Empleado.Cells("TipoRegimenNominaId").Value = 5 Or Empleado.Cells("TipoRegimenNominaId").Value = 6 Or Empleado.Cells("TipoRegimenNominaId").Value = 7 Or Empleado.Cells("TipoRegimenNominaId").Value = 8 Or Empleado.Cells("TipoRegimenNominaId").Value = 9 Then
                If Empleado.Cells("NumSeguridadSocial").Value.ToString <> "" Then
                    ErrorValidacion &= "El campo ""N.S.S."" no debe contener información" & vbCrLf
                End If
            Else
                If Empleado.Cells("NumSeguridadSocial").Value Is System.DBNull.Value Or Empleado.Cells("NumSeguridadSocial").Value.ToString = "" Then
                    ErrorValidacion &= "El campo ""N.S.S."" es obligatorio" & vbCrLf
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try


        If Empleado.Cells("TipoRegimenNominaId").Value = 4 Or Empleado.Cells("TipoRegimenNominaId").Value = 5 Or Empleado.Cells("TipoRegimenNominaId").Value = 6 Or Empleado.Cells("TipoRegimenNominaId").Value = 7 Or Empleado.Cells("TipoRegimenNominaId").Value = 8 Or Empleado.Cells("TipoRegimenNominaId").Value = 9 Then
            If Empleado.Cells("FechaInicioRelLaboral").Value.ToString <> "" Then
                ErrorValidacion &= "El campo ""Fecha inicio rel. laboral"" no debe contener información" & vbCrLf
            End If
        Else
            If Empleado.Cells("FechaInicioRelLaboral").Value Is System.DBNull.Value Or Empleado.Cells("FechaInicioRelLaboral").Value.ToString = "" Then
                ErrorValidacion &= "El campo ""Fecha inicio rel. laboral"" es obligatorio" & vbCrLf
            End If
        End If

        If Empleado.Cells("TipoRegimenNominaId").Value = 4 Or Empleado.Cells("TipoRegimenNominaId").Value = 5 Or Empleado.Cells("TipoRegimenNominaId").Value = 6 Or Empleado.Cells("TipoRegimenNominaId").Value = 7 Or Empleado.Cells("TipoRegimenNominaId").Value = 8 Or Empleado.Cells("TipoRegimenNominaId").Value = 9 Then
            If Empleado.Cells("Sindicalizado").Value = 1 Then
                ErrorValidacion &= "El campo ""Sindicalizado"" no debe estar activo" & vbCrLf
            End If
        End If

        If Empleado.Cells("TipoRegimenNominaId").Value = 4 Or Empleado.Cells("TipoRegimenNominaId").Value = 5 Or Empleado.Cells("TipoRegimenNominaId").Value = 6 Or Empleado.Cells("TipoRegimenNominaId").Value = 7 Or Empleado.Cells("TipoRegimenNominaId").Value = 8 Or Empleado.Cells("TipoRegimenNominaId").Value = 9 Then
            If Not Empleado.Cells("TipoJornadaId").Value Is System.DBNull.Value Then
                Empleado.Cells("TipoJornadaId").Value = vbNull ' System.DBNull.Value
            End If
        Else
            If Empleado.Cells("TipoJornadaId").Value Is System.DBNull.Value Then
                ErrorValidacion &= "El campo ""Tipo de jornada"" es obligatorio" & vbCrLf
            End If
        End If

        If Empleado.Cells("TipoContratoId").Value = 1 Or Empleado.Cells("TipoContratoId").Value = 2 Or Empleado.Cells("TipoContratoId").Value = 3 Or Empleado.Cells("TipoContratoId").Value = 4 Or Empleado.Cells("TipoContratoId").Value = 5 Or Empleado.Cells("TipoContratoId").Value = 6 Or Empleado.Cells("TipoContratoId").Value = 7 Or Empleado.Cells("TipoContratoId").Value = 8 Then
            If Empleado.Cells("TipoRegimenNominaId").Value <> 1 And Empleado.Cells("TipoRegimenNominaId").Value <> 2 And Empleado.Cells("TipoRegimenNominaId").Value <> 3 Then
                ErrorValidacion &= "El campo ""Tipo de régimen"" debe de ser ""Sueldos"", ""Jubilados"" o ""Pensionados""" & vbCrLf
            End If
        End If

        If Empleado.Cells("TipoContratoId").Value = 9 Or Empleado.Cells("TipoContratoId").Value = 10 Or Empleado.Cells("TipoContratoId").Value = 11 Then
            If Empleado.Cells("TipoRegimenNominaId").Value <> 4 And Empleado.Cells("TipoRegimenNominaId").Value <> 5 And Empleado.Cells("TipoRegimenNominaId").Value <> 6 And Empleado.Cells("TipoRegimenNominaId").Value <> 7 And Empleado.Cells("TipoRegimenNominaId").Value <> 8 And Empleado.Cells("TipoRegimenNominaId").Value <> 9 And Empleado.Cells("TipoRegimenNominaId").Value <> 10 And Empleado.Cells("TipoRegimenNominaId").Value <> 11 Then
                ErrorValidacion &= "El campo ""Tipo de régimen"" debe de ser cualquier rubro de ""Asimilados..."" o la opción ""Otro Régimen""" & vbCrLf
            End If
        End If

        If Empleado.Cells("TipoRegimenNominaId").Value = 4 Or Empleado.Cells("TipoRegimenNominaId").Value = 5 Or Empleado.Cells("TipoRegimenNominaId").Value = 6 Or Empleado.Cells("TipoRegimenNominaId").Value = 7 Or Empleado.Cells("TipoRegimenNominaId").Value = 8 Or Empleado.Cells("TipoRegimenNominaId").Value = 9 Then
            If Not Empleado.Cells("RiesgoPuestoId").Value Is System.DBNull.Value Then
                Empleado.Cells("RiesgoPuestoId").Value = vbNull ' System.DBNull.Value
            End If
        Else
            If Empleado.Cells("RiesgoPuestoId").Value Is System.DBNull.Value Then
                ErrorValidacion &= "El campo ""Riesgo puesto"" es obligatorio" & vbCrLf
            End If
        End If

        If IsNumeric(Empleado.Cells("CuentaBancaria").Value) Then
            If Empleado.Cells("CuentaBancaria").Value.ToString.Length > 18 Then
                If Not Empleado.Cells("BancoId").Value Is System.DBNull.Value Then
                    ErrorValidacion &= "El campo ""Cuenta bancaria"" no puede ser mayor a 18 dígitos" & vbCrLf
                End If
            End If

            If Empleado.Cells("CuentaBancaria").Value.ToString.Length = 18 Then
                If Not Empleado.Cells("BancoId").Value Is System.DBNull.Value Then
                    Empleado.Cells("BancoId").Value = vbNull ' System.DBNull.Value
                End If
            Else
                If Empleado.Cells("CuentaBancaria").Value Is System.DBNull.Value Or Empleado.Cells("CuentaBancaria").Value.ToString = "" Then
                    If Not Empleado.Cells("BancoId").Value Is System.DBNull.Value Then
                        ErrorValidacion &= "El campo ""Banco"" es obligatorio" & vbCrLf
                    End If
                End If
            End If
        Else
            If Empleado.Cells("CuentaBancaria").Value Is System.DBNull.Value And Empleado.Cells("CuentaBancaria").Value.ToString = "" Then
                If Not Empleado.Cells("BancoId").Value Is System.DBNull.Value Then
                    Empleado.Cells("BancoId").Value = vbNull ' System.DBNull.Value
                End If
            Else
                ErrorValidacion &= "El campo ""Cuenta bancaria"" debe ser numérico" & vbCrLf
            End If
        End If

        If Empleado.Cells("TipoRegimenNominaId").Value = 4 Or Empleado.Cells("TipoRegimenNominaId").Value = 5 Or Empleado.Cells("TipoRegimenNominaId").Value = 6 Or Empleado.Cells("TipoRegimenNominaId").Value = 7 Or Empleado.Cells("TipoRegimenNominaId").Value = 8 Or Empleado.Cells("TipoRegimenNominaId").Value = 9 Then
            If Empleado.Cells("SalariaBaseCotApor").Value.ToString <> "" Then
                ErrorValidacion &= "El campo ""Salario base"" no debe contener información" & vbCrLf
            End If
        Else
            If Not IsNumeric(Empleado.Cells("SalariaBaseCotApor").Value) Then
                ErrorValidacion &= "El campo ""Salario base"" debe contener un valor numérico" & vbCrLf
            End If
        End If

        If Empleado.Cells("TipoRegimenNominaId").Value = 4 Or Empleado.Cells("TipoRegimenNominaId").Value = 5 Or Empleado.Cells("TipoRegimenNominaId").Value = 6 Or Empleado.Cells("TipoRegimenNominaId").Value = 7 Or Empleado.Cells("TipoRegimenNominaId").Value = 8 Or Empleado.Cells("TipoRegimenNominaId").Value = 9 Then
            If Empleado.Cells("SalarioDiarioIntegrado").Value.ToString <> "" Then
                ErrorValidacion &= "El campo ""Salario diario integrado"" no debe contener información" & vbCrLf
            End If
        Else
            If Not IsNumeric(Empleado.Cells("SalarioDiarioIntegrado").Value) Then
                ErrorValidacion &= "El campo ""Salario diario integrado"" debe contener un valor numérico" & vbCrLf
            End If
        End If

        If ErrorValidacion <> "" Then
            Empleado.ErrorText = ErrorValidacion
            e.Cancel = True
        Else
            Empleado.ErrorText = ""
            e.Cancel = False
        End If
    End Sub

    Private Sub EmpleadosDataGridView_CellParsing(sender As System.Object, e As System.Windows.Forms.DataGridViewCellParsingEventArgs) Handles EmpleadosDataGridView.CellParsing
        DataGridView_CellParsing(sender, e)
    End Sub

    Private Sub EmpleadosDataGridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles EmpleadosDataGridView.KeyDown
        DataGridView_KeyDown(sender, e)
    End Sub

    Private Sub EmpleadosDataGridView_RowLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.RowLeave

    End Sub

    Private Sub EmpleadosDataGridView_Validated(sender As Object, e As System.EventArgs) Handles EmpleadosDataGridView.Validated
        Dim Empleado As DataGridViewRow = EmpleadosDataGridView.CurrentRow
        Empleado.ErrorText = ""
    End Sub

    Function compruebaTimbresRestantes(ByVal Emisor As String) As Boolean
        Dim wsLicencia As New Licencias.Service1
        Dim respuesta As Boolean = False
        Dim intentos As Integer = 0

        While intentos < 4
            Try
                respuesta = wsLicencia.compruebaTimbresRestantes(Emisor)
                Exit While
            Catch ex As Exception
                intentos += 1
                respuesta = False
                Exit Try
            End Try
        End While

        Return respuesta
    End Function

    Private Sub PercepcionEmpleadoDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles PercepcionEmpleadoDataGridView.RowValidating
        If PercepcionEmpleadoDataGridView.CurrentRow.IsNewRow Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = PercepcionEmpleadoDataGridView.CurrentRow
        Dim tipoRow As DataGridViewCell = row.Cells(PercepcionEmpleadoDataGridView.Columns("Tipo").Index)

        Try
            tipoRow.Value = UCase(tipoRow.Value)
        Catch ex As Exception
            Exit Try
        End Try
        Dim valido As Boolean
        valido = validaTipo(tipoRow, OtrosPagosDataGridView)
        e.Cancel = Not valido
        If valido Then
            row.ErrorText = ""
        End If

    End Sub

    Private Function validaTipo(ByRef cell As DataGridViewCell, ByRef dataGridView As DataGridView) As Boolean
        If Not IsDBNull(cell.Value) Then
            If Not String.IsNullOrEmpty(cell.Value) Then
                If Not cell.Value = "O" Then
                    If Not cell.Value = "E" Then
                        cell.ErrorText = "En la columna Tipo solo se permite O (Ordinario) ó E (Extraordinario)"
                        dataGridView.Rows(cell.RowIndex).ErrorText = "En la columna Tipo solo se permite O (Ordinario) ó E (Extraordinario)"
                        Return False
                    End If
                End If
            End If
        End If
        cell.ErrorText = ""
        Return True
    End Function

    Private Sub DeduccionEmpleadoDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DeduccionEmpleadoDataGridView.RowValidating
        If DeduccionEmpleadoDataGridView.CurrentRow.IsNewRow Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = DeduccionEmpleadoDataGridView.CurrentRow
        Dim tipoRow As DataGridViewCell = row.Cells(DeduccionEmpleadoDataGridView.Columns("TipoD").Index)

        Try
            tipoRow.Value = UCase(tipoRow.Value)
        Catch ex As Exception
            Exit Try
        End Try

        Dim valido As Boolean
        valido = validaTipo(tipoRow, DeduccionEmpleadoDataGridView)
        e.Cancel = Not valido
        If valido Then
            row.ErrorText = ""
        End If

    End Sub

    Private Sub OtrosPagosDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles OtrosPagosDataGridView.RowValidating

        If OtrosPagosDataGridView.CurrentRow.IsNewRow Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = OtrosPagosDataGridView.CurrentRow
        Dim tipoRow As DataGridViewCell = row.Cells(OtrosPagosDataGridView.Columns("TipoO").Index)

        Try
            tipoRow.Value = UCase(tipoRow.Value)
        Catch ex As Exception
            Exit Try
        End Try
        Dim valido As Boolean
        valido = validaTipo(tipoRow, OtrosPagosDataGridView)
        e.Cancel = Not valido
        If valido Then
            row.ErrorText = ""
        End If
    End Sub

    Private Sub IncapacidadesDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles IncapacidadesDataGridView.RowValidating
        If IncapacidadesDataGridView.CurrentRow.IsNewRow Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = IncapacidadesDataGridView.CurrentRow
        Dim tipoRow As DataGridViewCell = row.Cells(IncapacidadesDataGridView.Columns("TipoI").Index)

        Try
            tipoRow.Value = UCase(tipoRow.Value)
        Catch ex As Exception
            Exit Try
        End Try
        Dim valido As Boolean
        valido = validaTipo(tipoRow, IncapacidadesDataGridView)
        e.Cancel = Not valido
        If valido Then
            row.ErrorText = ""
        End If
    End Sub

    Private Sub JubilacionPensionRetiroDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles JubilacionPensionRetiroDataGridView.RowValidating
        If JubilacionPensionRetiroDataGridView.CurrentRow.IsNewRow Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = JubilacionPensionRetiroDataGridView.CurrentRow
        Dim tipoRow As DataGridViewCell = row.Cells(JubilacionPensionRetiroDataGridView.Columns("TipoJ").Index)

        Try
            tipoRow.Value = UCase(tipoRow.Value)
        Catch ex As Exception
            Exit Try
        End Try
        Dim valido As Boolean
        valido = validaTipo(tipoRow, JubilacionPensionRetiroDataGridView)
        e.Cancel = Not valido
        If valido Then
            row.ErrorText = ""
        End If
    End Sub

    Private Sub SeparacionIndemnizacionDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles SeparacionIndemnizacionDataGridView.RowValidating
        If SeparacionIndemnizacionDataGridView.CurrentRow.IsNewRow Then
            Exit Sub
        End If

        Dim row As DataGridViewRow = SeparacionIndemnizacionDataGridView.CurrentRow
        Dim tipoRow As DataGridViewCell = row.Cells(SeparacionIndemnizacionDataGridView.Columns("TipoS").Index)

        Try
            tipoRow.Value = UCase(tipoRow.Value)
        Catch ex As Exception
            Exit Try
        End Try
        Dim valido As Boolean
        valido = validaTipo(tipoRow, SeparacionIndemnizacionDataGridView)
        e.Cancel = Not valido
        If valido Then
            row.ErrorText = ""
        End If
    End Sub
End Class