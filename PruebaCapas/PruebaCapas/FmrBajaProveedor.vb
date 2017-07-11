Imports wflSistema

Public Class FmrBajaProveedor
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (DGVBjaProveedor.SelectedRows.Count <> 0) Then

            Dim modSeleccion As String = 0

            modSeleccion = (DGVBjaProveedor(0, DGVBjaProveedor.CurrentCell.RowIndex).Value.ToString())

            Dim x As New wflClientes

            Dim strmensaje As String = ""


            x.eliminarProveedor(modSeleccion)

            Dim dt As New DataTable

            x.obtenerGrillaProveedores(dt)

            DGVBjaProveedor.DataSource = dt



        End If



    End Sub

    Private Sub FmrBajaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaProveedores(dt)

        DGVBjaProveedor.DataSource = dt
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.ObtenerGrillaProveedorFiltrado(TxtIngresarDato.Text, dt)

        DGVBjaProveedor.DataSource = dt
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub DGVBjaProveedor_SelectionChanged(sender As Object, e As EventArgs) Handles DGVBjaProveedor.SelectionChanged



    End Sub
End Class