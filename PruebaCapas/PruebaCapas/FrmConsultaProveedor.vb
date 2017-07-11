Imports wflSistema
Public Class FrmConsultaProveedor
    Private Sub FrmConsultaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaProveedores(dt)

        DGVConsultaProveedor.DataSource = dt
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        x.ObtenerGrillaProveedorFiltrado(TxtBuscar.Text, dt)
        DGVConsultaProveedor.DataSource = dt
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class