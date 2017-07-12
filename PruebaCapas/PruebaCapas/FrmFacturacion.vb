
Imports wflSistema
Public Class FrmFacturacion
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New wflClientes
        Dim dt As New DataTable
        Dim clientes As New DataTable

        x.obtenerProductosEnStock(dt)

        DGVSeleccionarProducto.DataSource = dt

        x.obtenerGrillaCliente(clientes)

        DGVGrillaCliente.DataSource = clientes


    End Sub

    Private Sub DGVSeleccionarProducto_SelectionChanged(sender As Object, e As EventArgs) Handles DGVSeleccionarProducto.SelectionChanged
        Dim x As New wflClientes
        Dim tabla As New DataTable


        If tabla.Rows.Count > -1 Then

            TxtNombreProducto.Text = (DGVSeleccionarProducto(0, DGVSeleccionarProducto.CurrentCell.RowIndex).Value.ToString())


        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim id_cliente As String
        Dim id_producto As String


        If TxtCantidad.Text > (DGVSeleccionarProducto(1, DGVSeleccionarProducto.CurrentCell.RowIndex).Value.ToString()) Then

            MsgBox("Ingrese una cantidad valida")

        Else
            Dim x As New wflClientes
            Dim tabla As New DataTable

            id_producto = (DGVSeleccionarProducto(3, DGVSeleccionarProducto.CurrentCell.RowIndex).Value.ToString())

            id_cliente = (DGVGrillaCliente(0, DGVGrillaCliente.CurrentCell.RowIndex).Value.ToString())


            x.guardarPreFacturacion(id_cliente, id_producto, TxtCantidad.Text)




        End If





    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        x.buscarProductosEnStock(TxtBuscarProducto.Text, dt)
        DGVSeleccionarProducto.DataSource = dt



    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs)
        Dim x As New wflClientes
        Dim dt As New DataTable
        Dim tabla As New DataTable

        x.obtenerGrillaClienteFiltrada(btnBuscarClientes.Text, dt)
        DGVGrillaCliente.DataSource = dt

        'If tabla.Rows.Count > -1 Then

        '    txtNombreCliente.Text = (dgvCliente(0, dgvCliente.CurrentCell.RowIndex).Value.ToString())


        'End If


    End Sub

    Private Sub dgvCliente_SelectionChanged(sender As Object, e As EventArgs)
        'Dim x As New wflClientes
        'Dim dt As New DataTable
        'Dim tabla As New DataTable

        'x.obtenerGrillaClienteFiltrada(TxtBuscarClientes.Text, dt)
        'DGVGrillaCliente.DataSource = dt

        'If tabla.Rows.Count > -1 Then

        '    txtNombreCliente.Text = (dgvClientes(0, dgvClientes.CurrentCell.RowIndex).Value.ToString())


        'End If

    End Sub

    Private Sub btnBuscarClientes_Click(sender As Object, e As EventArgs) Handles btnBuscarClientes.Click
        Dim x As New wflClientes
        Dim dt As New DataTable
        Dim tabla As New DataTable

        x.obtenerGrillaClienteFiltrada(TxtBuscarClientes.Text, dt)
        DGVGrillaCliente.DataSource = dt

    End Sub

    Private Sub DGVGrillaCliente_SelectionChanged(sender As Object, e As EventArgs) Handles DGVGrillaCliente.SelectionChanged
        Dim x As New wflClientes
        Dim tabla As New DataTable


        If tabla.Rows.Count > -1 Then

            txtNombreCliente.Text = (DGVGrillaCliente(1, DGVGrillaCliente.CurrentCell.RowIndex).Value.ToString())


        End If






    End Sub
End Class