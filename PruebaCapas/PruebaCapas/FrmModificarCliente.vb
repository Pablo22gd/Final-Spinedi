Imports wflSistema
Public Class FrmModificarCliente
    Private Sub FrmModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaModCliente(dt)

        DGVGrillaModificarCliente.DataSource = dt
    End Sub
End Class