Imports wflSistema
Public Class FrmConsultaProducto
    Private Sub FrmConsultaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New wflClientes
        Dim dt As New DataTable



        x.obtenerGrillaProductos(dt)

        DGVConsultaProducto.DataSource = dt




    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.ObtenerGrillaProductoFiltrado(TxtBuscar.Text, dt)
        DGVConsultaProducto.DataSource = dt

    End Sub
End Class