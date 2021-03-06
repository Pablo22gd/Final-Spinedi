﻿Imports brlSistema
Public Class wflClientes
    Public Sub ObtenerProvincia(ByRef provincia As DataTable)
        Dim x As New brlClientes
        x.ObtenerProvincia(provincia)
    End Sub

    Public Sub obtenerProductosEnStock(ByRef stock As DataTable)
        Dim x As New brlClientes
        x.obtenerProductosEnStock(stock)
    End Sub

    Public Sub ObtenerProveedor(ByRef proveedor As DataTable)
        Dim x As New brlClientes
        x.obtenerProveedor(proveedor)
    End Sub

    Public Sub ObtenerGrillaProductoFiltrado(ByVal txtIngresarDato As String, ByRef resultado As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaProductoFiltrado(txtIngresarDato, resultado)
    End Sub

    Public Sub guardarPreFacturacion(ByVal id_cliente As String, ByVal id_producto As String, ByVal cantidad As String)
        Dim x As New brlClientes
        x.guardarPreFacturacion(id_cliente, id_producto, cantidad)
    End Sub

    Public Sub buscarProductosEnStock(ByVal txtbuscar As String, ByRef stock As DataTable)
        Dim x As New brlClientes
        x.buscarProductosEnStock(txtbuscar, stock)
    End Sub

    Public Sub ObtenerGrillaProveedorFiltrado(ByVal txtIngresarDato As String, ByRef resultado As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaProveedorFiltrado(txtIngresarDato, resultado)
    End Sub

    Public Sub obtenerGrillaClienteFiltrada(ByVal buscar As String, ByRef cliente As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaClienteFiltrada(buscar, cliente)
    End Sub

    Public Sub ProductosParaFacturar(ByVal id_cliente As String,
                                     ByVal id_producto As String,
                                     ByVal TxtCantidad As String
                                     )


        Dim x As New brlClientes
        x.ProductosParaFacturar(id_cliente, id_producto, TxtCantidad)
    End Sub

    Public Sub ConfirmarFacturacion(ByVal cantidadTotal As String,
                                     ByVal tipoFactura As String,
                                     ByVal RazonSocial As String
                                     )


        Dim x As New brlClientes
        x.ConfirmarFacturacion(cantidadTotal, tipoFactura, RazonSocial)
    End Sub

    Public Sub ProductosParaFacturar2(
                                     ByVal cantidadTotal As String,
                                     ByRef tabla As DataTable
                                   )


        Dim x As New brlClientes
        x.ProductosParaFacturar2(cantidadTotal, tabla)
    End Sub
    Public Sub logueo(ByVal usuario As String, ByVal password As String, ByRef resultado As DataTable)
        Dim x As New brlClientes
        x.logueo(usuario, password, resultado)
    End Sub

    Public Sub ObtenerLocalidad(ByVal valor As String, ByRef localidad As DataTable)
        Dim x As New brlClientes
        x.ObtenerLocalidad(valor, localidad)
    End Sub

    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)
        Dim x As New brlClientes
        x.obtenerRegistro(idcliente, clientes)
    End Sub

    Public Sub obtenerGrillaCliente(ByRef clientes As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaCliente(clientes)

    End Sub

    Public Sub obtenerGrillaProductos(ByRef producto As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaProductos(producto)

    End Sub
    Public Sub obtenerGrillaProveedores(ByRef proveedor As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaProveedores(proveedor)

    End Sub

    Public Sub modificarProveedorSeleccionado(
                         ByVal TxtNombre,
                         ByVal TxtDomicilio,
                         ByVal CbLocalidad,
                         ByVal CbProvincia,
                         ByVal TxtTelefono,
                         ByVal TxtCuit,
                         ByVal CbEstado,
                         ByVal TxtObservaciones,
                         ByVal TxtRazonSocial,
                         ByVal modSeleccion)
        Dim x As New brlClientes

        x.modificarProveedorSeleccionado(TxtNombre,
                         TxtDomicilio,
                         CbLocalidad,
                         CbProvincia,
                         TxtTelefono,
                         TxtCuit,
                         CbEstado,
                         TxtObservaciones,
                         TxtRazonSocial,
                         modSeleccion)

    End Sub

    Public Sub obtenerGrillaModCliente(ByRef Cliente As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaModCliente(Cliente)

    End Sub

    Public Sub obtenerGrillaModProveedor(ByRef Cliente As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaModProveedor(Cliente)

    End Sub

    Public Sub obtenerGrillaModProducto(ByRef Cliente As DataTable)
        Dim x As New brlClientes
        x.obtenerGrillaModProducto(Cliente)

    End Sub
    Public Sub insertarRegistro(ByVal idcliente As Integer, ByRef strrazonsocial As String, ByRef strmensaje As String)
        Dim x As New brlClientes

        If Not x.ExisteCliente(idcliente) Then
            x.insertarRegistro(idcliente, strrazonsocial)
            strmensaje = "El cliente se agrego con exito"
        Else
            strmensaje = "El cliente ya existe en la base"
        End If

    End Sub

    Public Sub NuevoProveedor(
                         ByVal TxtNombre,
                         ByVal TxtDomicilio,
                         ByVal CbLocalidad,
                         ByVal CbProvincia,
                         ByVal TxtTelefono,
                         ByVal TxtCuit,
                         ByVal CbEstado,
                         ByVal TxtObservaciones,
                         ByVal TxtRazonSocial)
        Dim x As New brlClientes

        x.NuevoProveedor(TxtNombre,
                         TxtDomicilio,
                         CbLocalidad,
                         CbProvincia,
                         TxtTelefono,
                         TxtCuit,
                         CbEstado,
                         TxtObservaciones,
                         TxtRazonSocial)

    End Sub

    Public Sub NuevoCliente(
                         ByVal TxtNombre,
                         ByVal TxtApellido,
                         ByVal TxtDNI,
                         ByVal TxtDomicilio,
                         ByVal CbSexo,
                         ByVal DTPFechaDeNacimiento,
                         ByVal TxtTelefono,
                         ByVal TxtEmail,
                         ByVal CbProvincia,
                         ByVal CbLocalidad,
                         ByVal CbEstado)

        Dim x As New brlClientes

        x.NuevoCliente(TxtNombre,
                         TxtApellido,
                         TxtDNI,
                         TxtDomicilio,
                         CbSexo,
                         Convert.ToDateTime(DTPFechaDeNacimiento),
                         TxtTelefono,
                         TxtEmail,
                         CbProvincia,
                         CbLocalidad,
                         CbEstado)

    End Sub

    Public Sub modificarClienteSeleccionado(
                         ByVal TxtNombre,
                         ByVal TxtApellido,
                         ByVal TxtDNI,
                         ByVal TxtDomicilio,
                         ByVal CbSexo,
                         ByVal DTPFechaDeNacimiento,
                         ByVal TxtTelefono,
                         ByVal TxtEmail,
                         ByVal CbProvincia,
                         ByVal CbLocalidad,
                         ByVal CbEstado,
                         ByVal modSeleccion)

        Dim x As New brlClientes

        x.modificarClienteSeleccionado(TxtNombre,
                         TxtApellido,
                         TxtDNI,
                         TxtDomicilio,
                         CbSexo,
                         Convert.ToDateTime(DTPFechaDeNacimiento),
                         TxtTelefono,
                         TxtEmail,
                         CbProvincia,
                         CbLocalidad,
                         CbEstado,
                         modSeleccion)

    End Sub
    Public Sub NuevoProducto(
                         ByVal TxtNombre,
                         ByVal TxtMarca,
                         ByVal TxtDetalle,
                         ByVal TxtCantidad,
                         ByVal CbEstado,
                         ByVal TxtProveedor,
                         ByVal TxtObservaciones)
        Dim x As New brlClientes

        x.NuevoProducto(TxtNombre,
                         TxtMarca,
                         TxtDetalle,
                         TxtCantidad,
                         CbEstado,
                         TxtProveedor,
                         TxtObservaciones)

    End Sub
    Public Sub ModificarProductoSeleccionado(
                         ByVal TxtNombre,
                         ByVal TxtMarca,
                         ByVal TxtDetalle,
                         ByVal TxtCantidad,
                         ByVal CbEstado,
                         ByVal TxtProveedor,
                         ByVal TxtObservaciones,
                         ByVal modSeleccion)
        Dim x As New brlClientes

        x.ModificarProductoSeleccionado(TxtNombre,
                         TxtMarca,
                         TxtDetalle,
                         TxtCantidad,
                         CbEstado,
                         TxtProveedor,
                         TxtObservaciones,
                         modSeleccion)

    End Sub


    Public Sub eliminarProveedor(ByVal idProveedor As Integer)
        Dim x As New brlClientes
        x.eliminarProveedor(idProveedor)
    End Sub

    Public Sub eliminarProducto(ByVal idProducto As Integer)
        Dim x As New brlClientes
        x.eliminarProducto(idProducto)
    End Sub

    Public Sub eliminarCliente(ByVal idCliente As Integer)
        Dim x As New brlClientes
        x.eliminarCliente(idCliente)


    End Sub

    Public Sub eliminarRegistro(ByVal idcliente As Integer, ByRef strmensaje As String)
        Dim x As New brlClientes
        If x.ExisteCliente(idcliente) Then
            x.eliminarRegistro(idcliente)
            strmensaje = "El cliente se eliminó con exito"
        Else
            strmensaje = "El cliente no existe en la base"
        End If
    End Sub





    End Class
