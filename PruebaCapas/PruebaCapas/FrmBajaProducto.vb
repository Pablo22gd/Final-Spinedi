Imports wflSistema
Public Class FrmBajaProducto
    Private Sub FrmBajaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaProductos(CBFiltrar.Text, TxtIngresarDato.Text, dt)

        DGVBajaProducto.DataSource = dt

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class