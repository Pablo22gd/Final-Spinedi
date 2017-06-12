Imports dtlSistema
Public Class brlClientes

    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        x.obtenerRegistro(idcliente, clientes)

    End Sub

    Public Sub obtenerCliente(ByVal cbFiltro As String, ByVal txtbuscar As String, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        x.obtenerCliente(cbFiltro, txtbuscar, clientes)

    End Sub

    Public Sub insertarRegistro(ByVal idcliente As Integer, ByRef strrazonsocial As String)
        Dim x As New dtlClientes
        x.insertarRegistro(idcliente, strrazonsocial)
    End Sub

    Public Sub NuevoProveedor(ByVal TxtNombre,
                         ByVal TxtDomicilio,
                         ByVal CbLocalidad,
                         ByVal CbProvincia,
                         ByVal TxtTelefono,
                         ByVal TxtCuit,
                         ByVal CbEstado,
                         ByVal TxtObservaciones,
                         ByVal TxtRazonSocial)

        Dim x As New dtlClientes
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

    Public Sub NuevoCliente(ByVal TxtNombre,
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


        Dim x As New dtlClientes
        x.NuevoCliente(TxtNombre,
                         TxtApellido,
                         TxtDNI,
                         TxtDomicilio,
                         CbSexo,
                         DTPFechaDeNacimiento,
                         TxtTelefono,
                         TxtEmail,
                         CbProvincia,
                         CbLocalidad,
                         CbEstado)


    End Sub

    Public Function ExisteCliente(ByVal idcliente As Integer) As Boolean
        Dim x As New dtlClientes
        Dim clientes As New DataTable
        x.obtenerRegistro(idcliente, clientes)

        If clientes.Rows.Count > 0 Then
            ExisteCliente = True
        Else
            ExisteCliente = False
        End If
    End Function

    Public Sub eliminarRegistro(ByVal idcliente As Integer)
        Dim x As New dtlClientes
        x.eliminarRegistro(idcliente)
    End Sub

    Public Sub eliminarCliente(ByVal idcliente As Integer)
        Dim x As New dtlClientes
        x.eliminarCliente(idcliente)
    End Sub

End Class
