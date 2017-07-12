Imports wflSistema
Public Class FrmModificarProducto
    Private Sub FrmModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaModProducto(dt)

        DGVModificarProducto.DataSource = dt
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub DGVModificarProducto_SelectionChanged(sender As Object, e As EventArgs) Handles DGVModificarProducto.SelectionChanged

        Dim x As New wflClientes
        Dim tabla As New DataTable





        If tabla.Rows.Count > -1 Then

            TxtNombre.Text = (DGVModificarProducto(1, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())
            TxtMarca.Text = (DGVModificarProducto(2, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())
            TxtDetalle.Text = (DGVModificarProducto(3, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())
            TxtCantidad.Text = (DGVModificarProducto(4, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())
            CBEstado.Text = (DGVModificarProducto(5, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())
            CbProveedor.Text = (DGVModificarProducto(6, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())
            TxtObservaciones.Text = (DGVModificarProducto(7, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())

        End If
    End Sub

    Private Sub DGVModificarProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVModificarProducto.CellContentClick

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim x As New wflClientes
        Dim tabla As New DataTable
        Dim modSeleccion As String
        Dim dt As New DataTable


        modSeleccion = (DGVModificarProducto(0, DGVModificarProducto.CurrentCell.RowIndex).Value.ToString())

        x.ModificarProductoSeleccionado(TxtNombre.Text,
                                        TxtMarca.Text,
                                        TxtDetalle.Text,
                                        TxtCantidad.Text,
                                        CBEstado.Text,
                                        CbProveedor.Text,
                                        TxtObservaciones.Text,
                                        modSeleccion)

        x.obtenerGrillaProductos(dt)

        DGVModificarProducto.DataSource = dt
    End Sub

    Private Sub CbProveedor_MouseClick(sender As Object, e As MouseEventArgs) Handles CbProveedor.MouseClick

        Dim x As New wflClientes
        Dim dt As New DataTable

        x.ObtenerProveedor(dt)

        CbProveedor.SelectedValue = ""
        CbProveedor.Text = ""
        CbProveedor.DataSource = dt

        CbProveedor.ValueMember = "nombre"

        CbProveedor.DisplayMember = "nombre"
    End Sub
End Class