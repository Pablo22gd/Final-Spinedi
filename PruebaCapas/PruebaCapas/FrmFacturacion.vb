
Imports wflSistema
Public Class FrmFacturacion
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Dim cantidad As New Integer
    Dim cantidadTotal As New Integer

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
        Dim valor As String

        valor = DGVSeleccionarProducto(1, DGVSeleccionarProducto.CurrentCell.RowIndex).Value.ToString()

        If TxtCantidad.Text = "" Then
            MsgBox("Ingrese una cantidad")
        Else


            If (Convert.ToInt32(TxtCantidad.Text) > Convert.ToInt32(valor)) Then

                MsgBox("Ingrese una cantidad valida")

            Else
                Dim x As New wflClientes

                Dim pasarProductosAGrilla As New DataTable


                id_producto = (DGVSeleccionarProducto(3, DGVSeleccionarProducto.CurrentCell.RowIndex).Value.ToString())

                id_cliente = (DGVGrillaCliente(0, DGVGrillaCliente.CurrentCell.RowIndex).Value.ToString())

                If cantidad > -1 Then

                    cantidad = cantidad + 1



                End If

                cantidadTotal = cantidad

                x.ProductosParaFacturar(
                                        id_cliente,
                                        id_producto,
                                        TxtCantidad.Text)

                x.ProductosParaFacturar2(cantidadTotal, pasarProductosAGrilla)

                DgvGrillaFacturacion.DataSource = pasarProductosAGrilla

                BtnFacturar.Visible = True


            End If
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

        '  DGVGrillaCliente.Enabled = False




    End Sub

    Private Sub BtnFacturar_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable
        Dim tabla As New DataTable

        If (CBTipoDeFactura.SelectedItem = "") Then
            MsgBox("Ingrese el tipo de factura")
        Else
            If (txtRazonSocial.Text = "") Then
                MsgBox("Ingrese la razon social")
            Else

                Dim strmensaje As String = "Esta seguro que desea realizar la operacion"
                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")


                x.ConfirmarFacturacion(
            cantidadTotal,
            CBTipoDeFactura.Text,
            txtRazonSocial.Text)

                MsgBox("La facturacion se realizo con exito")


            End If

        End If





    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Class