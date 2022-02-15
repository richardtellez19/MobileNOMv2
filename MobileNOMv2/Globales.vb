Imports System.Data.SqlServerCe
Imports System.IO
Imports System.Xml
Imports System.Xml.Xsl
Imports System.Xml.XPath

Module Globales
    Public TestFlag As Boolean = GetSetting("MobileNOMv2", "Datos", "ModoTest", 1)
    Public UsuarioId As Integer
    Public TipoUsuarioId As Integer
    Public UTF8WithoutBOM As New System.Text.UTF8Encoding(False)
    Public RutaDocs As String = GetSetting("MobileNOMv2", "Datos", "RutaDocs", "")
    Public BaseDatos As String = ""
    Public NoSerie As String = GetSetting("MobileNOMv2", "Datos", "NoSerie", String.Empty)
    Public NoLicencia As String = GetSetting("MobileNOMv2", "Datos", "NoLicencia", String.Empty)
    Public Version As String = GetSetting("MobileNOMv2", "Datos", "Version", String.Empty)

    Public Function GetDataReader(ByVal queryString As String) As SqlCeDataReader
        Using connection As New SqlCeConnection(My.Settings.MainDBConnectionString)
            Dim command As New SqlCeCommand(queryString, connection)
            connection.Open()

            Try
                Dim reader As SqlCeDataReader = command.ExecuteReader()
                Return reader
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                connection.Close()
            End Try
        End Using
    End Function

    Public Function UpdDataBase(ByVal Comandos As SqlCeCommand()) As Boolean
        Dim connection As New SqlCeConnection(My.Settings.MainDBConnectionString)

        Try
            connection.Open()
        Catch ex As Exception
            Return False
            Exit Try
        End Try

        Dim Tans As SqlCeTransaction = connection.BeginTransaction

        Try
            For Each cmd As SqlCeCommand In Comandos
                cmd.Transaction = Tans
                cmd.Connection = connection
                cmd.ExecuteNonQuery()
            Next

            Tans.Commit()
            Return True
        Catch ex As Exception
            Tans.Rollback()
            MsgBox(ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub DataGridView_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs)
        Select Case e.DesiredType.ToString
            Case "System.DateTime"
                Try
                    Dim strFecha As String = ""
                    Select Case e.Value.ToString.Length
                        Case 6
                            strFecha = e.Value.ToString.Substring(0, 2) & "/" & e.Value.ToString.Substring(2, 2) & "/" & e.Value.ToString.Substring(4, 2)
                        Case 8
                            strFecha = e.Value.ToString.Substring(0, 2) & "/" & e.Value.ToString.Substring(2, 2) & "/" & e.Value.ToString.Substring(4, 4)
                    End Select

                    Dim fecha As Date = CDate(strFecha)

                    'If sender.Columns(e.ColumnIndex).DataPropertyName = "FechaRegistro" Then
                    '    If Not VerificaPeriodo(fecha) Then
                    '        MsgBox("La fecha introducida no corresponde al periodo activo." & vbCrLf & "La fecha por defecto se estableció a: " & Format(Now, "dd/MM/yyyy"), MsgBoxStyle.Exclamation, "Error")
                    '        e.Value = Now
                    '        e.ParsingApplied = True
                    '        Exit Sub
                    '    End If
                    'End If

                    e.Value = fecha
                    e.ParsingApplied = True
                Catch ex As Exception
                    e.Value = Now
                    e.ParsingApplied = False
                End Try
            Case "System.Integer"

        End Select
    End Sub

    Public Sub DataGridView_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyData
            Case Keys.F8
                Try
                    sender.CurrentCell.Value = sender.Rows(sender.CurrentCell.RowIndex - 1).Cells(sender.CurrentCell.ColumnIndex).Value
                Catch ex As Exception
                    Exit Try
                End Try
        End Select
    End Sub

    Public Function ObtieneFecha() As Date
        Try
            Dim WS As New Licencias.Service1

            Return WS.obtieneFecha + TimeZone.CurrentTimeZone.GetUtcOffset(Now)
        Catch ex As Exception
            Return Now
        End Try
    End Function

    Public Function GeneraCadenaOriginalTFD(ByRef Doc As XmlDocument) As String
        Dim msChain As MemoryStream = New MemoryStream()
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
                Dim tw As XmlTextWriter = New XmlTextWriter(msChain, UTF8WithoutBOM)
                Dim xslt As XslCompiledTransform = New XslCompiledTransform()
                xslt.Load(Application.StartupPath & "\Esquemas\v32\cadenaoriginal_TFD_1_0.xslt")
                msXML_TFD.Position = 0
                Dim xp As XPathDocument = New XPathDocument(msXML_TFD)
                xslt.Transform(xp, tw)
                CadenaOriginal_TFD = System.Text.Encoding.ASCII.GetString(msChain.ToArray).Normalize
                Exit For
            Catch ex As Exception
                Exit Try
            End Try
        Next

        Return CadenaOriginal_TFD
    End Function

    Public Sub GeneraCBB_1(ByRef CBB As System.IO.MemoryStream, ByVal datos As String)
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
                    GeneraCBB_1(CBB, datos)
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
End Module
