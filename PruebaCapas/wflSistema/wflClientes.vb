Imports brlSistema
Public Class wflClientes
    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)
        Dim x As New brlClientes
        x.obtenerRegistro(idcliente, clientes)
    End Sub
    'Public Sub buscarCliente(ByVal cbFiltro As String, ByVal txtBuscar As String, ByRef clientes As DataTable)
    '    Dim x As New brlClientes
    '    x.obtenerCliente(cbFiltro, txtBuscar, clientes)

    'End Sub

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

    Public Sub eliminarRegistro(ByVal idcliente As Integer, ByRef strmensaje As String)
        Dim x As New brlClientes
        If x.ExisteCliente(idcliente) Then
            x.eliminarRegistro(idcliente)
            strmensaje = "El cliente se eliminó con exito"
        Else
            strmensaje = "El cliente no existe en la base"
        End If
    End Sub
    'En las wFL generalmente van procesos complejos que invlucran
    ' llamados a las otras capas. 
    ' Ejemplo Procesar Consumos Cliente
    ' En ese caso debere tener en la dtl un una dtl de facturas
    ' Una brl de facturas
    ' y aca traerlas y trabajarlas.


    Public Sub eliminarCliente(ByVal idcliente As Integer, ByRef strmensaje As String)
        Dim x As New brlClientes
        If x.ExisteCliente(idcliente) Then
            x.eliminarCliente(idcliente)
            strmensaje = "El cliente se eliminó con exito"
        Else
            strmensaje = "El cliente no existe en la base"
        End If
    End Sub

End Class
