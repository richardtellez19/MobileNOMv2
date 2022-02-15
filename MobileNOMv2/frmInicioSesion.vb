Imports System.Data.SqlServerCe
Imports System.IO

Public Class frmInicioSesion

    Private Sub frmInicioSesion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BaseDatos = "" Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub frmInicioSesion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        VerificaRutaDocs()
        CargaLista()
    End Sub

    Private Sub VerificaRutaDocs()
        If RutaDocs = "" Then
            FolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer
            FolderBrowserDialog.Description = "Ingrese la ruta en donde se guardarán todos sus documentos"
            FolderBrowserDialog.ShowDialog()

            If FolderBrowserDialog.SelectedPath = "" Then
                MsgBox("Debe seleccionar una ruta!", MsgBoxStyle.OkOnly)
                Exit Sub
            End If

            SaveSetting("MobileNOMv2", "Datos", "RutaDocs", FolderBrowserDialog.SelectedPath & "\")
            RutaDocs = FolderBrowserDialog.SelectedPath & "\"
        End If
    End Sub

    Private Sub CargaLista()
        Dim Empresas As String = GetSetting("MobileNOMv2", "Datos", "Empresas", "")

        If Empresas = "" Then Exit Sub

        Try
            Dim actEmpresas As String = ""
            Dim arrEmpresas As String() = Empresas.Split("|")

            EmpresasListBox.Items.Clear()
            For Each Empresa As String In arrEmpresas
                Dim arrDatosEmpresa As String() = Empresa.Split("\")
                If File.Exists(RutaDocs & arrDatosEmpresa(0) & ".sdf") Then
                    EmpresasListBox.Items.Add(arrDatosEmpresa(1))
                    actEmpresas &= arrDatosEmpresa(0) & "\" & arrDatosEmpresa(1) & "|"
                End If
            Next

            SaveSetting("MobileNOMv2", "Datos", "Empresas", actEmpresas.Substring(0, IIf(actEmpresas = "", 0, actEmpresas.Length - 1)))
        Catch ex As Exception
            MsgBox("Error al cargar la lista de empresas!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Try

        If EmpresasListBox.Items.Count = 0 Then
            IniciarButton.Enabled = False
            'expOpciones.IsExpanded = True
        Else
            EmpresasListBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub CrearEmpresaButton_Click(sender As System.Object, e As System.EventArgs) Handles CrearEmpresaButton.Click
        Dim RFC As String = InputBox("Ingrese el RFC:", "Datos de la nueva empresa").Trim.ToUpper
        Dim Nombre As String = InputBox("Ingrese el Nombre o Razón Social:", "Datos de la nueva empresa").Trim.ToUpper

        If RFC.Trim = "" Or Nombre.Trim = "" Then
            MsgBox("El RFC y/o el Nombre/Razón Social no son válidos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If File.Exists(RutaDocs & RFC & ".sdf") Then
            MsgBox("Ya existe una base de datos con el mismo RFC.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        Try
            File.Copy(Application.StartupPath & "\DB\MainDB.sdf", RutaDocs & RFC & ".sdf")
            Dim Empresas As String = GetSetting("MobileNOMv2", "Datos", "Empresas", "")
            If Empresas = "" Then
                SaveSetting("MobileNOMv2", "Datos", "Empresas", RFC & "\" & Nombre)
            Else
                SaveSetting("MobileNOMv2", "Datos", "Empresas", Empresas & "|" & RFC & "\" & Nombre)
            End If
        Catch ex As Exception
            MsgBox("Error al crear la nueva empresa!" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End Try

        CargaLista()
    End Sub

    Private Sub CargarExistenteButton_Click(sender As System.Object, e As System.EventArgs) Handles CargarExistenteButton.Click
        OpenFileDialog.InitialDirectory = RutaDocs
        OpenFileDialog.Multiselect = True
        OpenFileDialog.AddExtension = True
        OpenFileDialog.CheckFileExists = True
        OpenFileDialog.Filter = "Bases de datos SAF (*.sdf)|*.sdf"

        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        Dim Empresas As String = GetSetting("MobileNOMv2", "Datos", "Empresas", "")
        For Each Archivo As String In OpenFileDialog.SafeFileNames
            Dim RFC As String = Archivo.Replace(".sdf", "")

            If Empresas.IndexOf(RFC) > -1 Then
                MsgBox("La empresa con el RFC: " & RFC & " ya está en la lista.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If

            Dim Nombre As String = InputBox("Ingrese el nombre para la empresa cuyo RFC es: " & RFC, "Buscar empresas").Trim.ToUpper

            If Nombre = "" Then Exit Sub

            If Empresas = "" Then
                Empresas = RFC & "\" & Nombre
            Else
                Empresas &= "|" & RFC & "\" & Nombre
            End If
        Next

        SaveSetting("MobileNOMv2", "Datos", "Empresas", Empresas)
        CargaLista()
    End Sub

    Private Sub IniciarButton_Click(sender As System.Object, e As System.EventArgs) Handles IniciarButton.Click
        Dim Nombre As String = EmpresasListBox.SelectedItem.ToString
        Dim Empresas As String() = GetSetting("MobileNOMv2", "Datos", "Empresas", "").Split("|")

        For Each Empresa As String In Empresas
            Dim arrEmpresa As String() = Empresa.Split("\")
            If arrEmpresa(1) = Nombre Then
                My.Settings.Item("MainDBConnectionString") = "Data Source=" & RutaDocs & arrEmpresa(0) & ".sdf;Max Database Size = 2048;Password=mobilemetriks"
                BaseDatos = arrEmpresa(1)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(Application.StartupPath & "\TeamViewer\TeamViewerQS.exe")
    End Sub
End Class