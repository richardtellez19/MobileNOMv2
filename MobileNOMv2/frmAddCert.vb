Imports System.Diagnostics
Imports System.Security.Cryptography.X509Certificates

Public Class frmAddCert
    Dim _SucursalId As Integer = 0
    Dim RutaCSD As String = ""
    Dim RutaKey As String = ""

    Public Sub New(ByVal SucursalId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _SucursalId = SucursalId
    End Sub

    Private Sub frmAddCert_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MainDBDataSet.Sucursales' Puede moverla o quitarla según sea necesario.
        Me.SucursalesTableAdapter.Fill(Me.MainDBDataSet.Sucursales)
        'TODO: This line of code loads data into the 'WebSAF_MOB100617FNADataSet.Sucursales' table. You can move, or remove it, as needed.
        Me.SucursalesTableAdapter.Fill(Me.MainDBDataSet.Sucursales)

        SucursalesBindingSource.Position = SucursalesBindingSource.Find("SucursalId", _SucursalId)

        Try
            Dim cert As X509Certificate2 = New X509Certificate2(Convert.FromBase64String(PFXTextBox.Text), PasswordTextBox.Text)
            LlenaTabla(cert)
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub SucursalesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDBDataSet)

    End Sub

    Private Sub ValidarButton_Click(sender As Object, e As EventArgs) Handles ValidarButton.Click
        Try
            If Not IO.Directory.Exists("temps") Then IO.Directory.CreateDirectory("temps")
            GeneraPFX()
            Dim cert As X509Certificate2 = New X509Certificate2("temps\archivo.pfx", PasswordTextBox.Text)
            PFXTextBox.Text = Convert.ToBase64String(IO.File.ReadAllBytes("temps\archivo.pfx"))
            LlenaTabla(cert)
            If IO.File.Exists("temps\archivo.pfx") Then IO.File.Delete("temps\archivo.pfx")
            If IO.File.Exists("temps\archivo.pfx") Then IO.File.Delete("temps\archivo.pfx")
            If CDate(cert.GetExpirationDateString) < Now Then
                MsgBox("El Certificado seleccionado expiró el día: " & cert.GetExpirationDateString, MsgBoxStyle.Information, "Advertencia")
            End If
        Catch ex As Exception
            'txtDesde.Text = ""
            'txtHasta.Text = ""
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LlenaTabla(ByRef Cert As X509Certificate2)
        Dim Atributo As New ListViewItem("Emisor")
        Atributo.SubItems.Add(Cert.Issuer)
        PFXListView.Items.Add(Atributo)
        Atributo = New ListViewItem("Creado el")
        Atributo.SubItems.Add(Cert.NotBefore)
        PFXListView.Items.Add(Atributo)
        If IO.File.Exists("temps\archivo.pfx") Then IO.File.Delete("temps\archivo.pfx")
        Atributo = New ListViewItem("Expira")
        Atributo.SubItems.Add(Cert.NotAfter)
        PFXListView.Items.Add(Atributo)
        Atributo = New ListViewItem("Receptor")
        Atributo.SubItems.Add(Cert.Subject)
        PFXListView.Items.Add(Atributo)
    End Sub

    Private Sub GeneraPFX()
        Dim A As Boolean = False

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
        proceso1.StartInfo.Arguments = "pkcs8 -inform DER -in """ & RutaKey & """ -passin pass:" & PasswordTextBox.Text & " -out ""temps\archivo.pem"""
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
                rd = New IO.StreamReader("temps\archivo.pem")
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
        proceso2.StartInfo.Arguments = "pkcs12 -export -out ""temps\archivo.pfx"" -inkey ""temps\archivo.pem"" -in ""temps\archivo.crt"" -passin pass:" & PasswordTextBox.Text & " -password pass:" & PasswordTextBox.Text
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
                rd = New IO.StreamReader("temps\archivo.pfx")
                rd.ReadLine()
                A = True
                rd.Close()
            Catch ex As Exception
                'rd.Close()
            End Try
        End While

        'borramos los archivos generados temporalmente
        If IO.File.Exists("temps\archivo.pem") Then IO.File.Delete("temps\archivo.pem")
        If IO.File.Exists("temps\archivo.crt") Then IO.File.Delete("temps\archivo.crt")
    End Sub

    Private Sub ExaminarCSDButton_Click(sender As Object, e As EventArgs) Handles ExaminarCSDButton.Click
        OpenFileDialog.Title = "Seleccione el archivo del CSD"
        OpenFileDialog.Filter = "Certificado (*.cer)|*.cer"

        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            CSDTextBox.Text = Convert.ToBase64String(IO.File.ReadAllBytes(OpenFileDialog.FileName))
            RutaCSD = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub ExaminarKEYButton_Click(sender As Object, e As EventArgs) Handles ExaminarKEYButton.Click
        OpenFileDialog.Title = "Seleccione el archivo de la Llave"
        OpenFileDialog.Filter = "Llave (*.key)|*.key"

        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            KeyTextBox.Text = Convert.ToBase64String(IO.File.ReadAllBytes(OpenFileDialog.FileName))
            RutaKey = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub AplicarButton_Click(sender As Object, e As EventArgs) Handles AplicarButton.Click
        Me.Validate()
        Me.SucursalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MainDBDataSet)
        Me.Close()
    End Sub

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
End Class