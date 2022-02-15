Public Class frmStatus
    Private Sub frmStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstStatus.Items.Clear()
    End Sub

    Public Sub AppendText(ByVal texto As String)
        lstStatus.Items.Add(texto)
        lstStatus.SelectedIndex = lstStatus.Items.Count - 1
        Me.Refresh()
    End Sub

    Public Sub Clear()
        lstStatus.Items.Clear()
    End Sub
End Class