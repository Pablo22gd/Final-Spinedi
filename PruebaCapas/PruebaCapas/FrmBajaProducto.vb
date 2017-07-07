Imports wflSistema
Public Class FrmBajaProducto
    Private Sub FrmBajaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As New wflClientes
        Dim dt As New DataTable



        x.obtenerGrillaProductos(dt)

        DGVBajaProducto.DataSource = dt





    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.ObtenerGrillaProductoFiltrado(TxtIngresarDato.Text, dt)
        DGVBajaProducto.DataSource = dt



    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click


        If (DGVBajaProducto.SelectedRows.Count <> 0) Then

            Dim modSeleccion As String = 0

            modSeleccion = (DGVBajaProducto(0, DGVBajaProducto.CurrentCell.RowIndex).Value.ToString())

            Dim x As New wflClientes

            Dim strmensaje As String = ""


            x.eliminarProducto(modSeleccion)

            Dim dt As New DataTable

            x.obtenerGrillaProductos(dt)

            DGVBajaProducto.DataSource = dt



        End If
    End Sub

    Private Sub DGVBajaProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBajaProducto.CellContentClick

    End Sub
End Class