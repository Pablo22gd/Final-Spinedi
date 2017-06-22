Imports wflSistema
Public Class FrmBajaProducto
    Private Sub FrmBajaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaProductos(dt)

        DGVBajaProducto.DataSource = dt





    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click



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

            x.obtenerGrillaProveedores(dt)

            DGVBajaProducto.DataSource = dt



        End If
    End Sub
End Class