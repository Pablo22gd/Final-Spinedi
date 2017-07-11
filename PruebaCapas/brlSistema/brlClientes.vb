Imports dtlSistema
Public Class brlClientes

    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        x.obtenerRegistro(idcliente, clientes)

    End Sub



    Public Sub obtenerGrillaProductoFiltrado(ByVal txtIngresarDato As String, ByRef resultado As DataTable)
        Dim x As New dtlClientes
        x.ObtenerGrillaProductoFiltrado(txtIngresarDato, resultado)

    End Sub

    Public Sub obtenerGrillaProveedorFiltrado(ByVal txtIngresarDato As String, ByRef resultado As DataTable)
        Dim x As New dtlClientes
        x.ObtenerGrillaProveedorFiltrado(txtIngresarDato, resultado)

    End Sub
    Public Sub obtenerGrillaClienteFiltrada(ByVal buscar As String, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaClienteFiltrada(buscar, clientes)

    End Sub

    Public Sub logueo(ByVal usuario As String, ByVal password As String, ByRef resultado As DataTable)
        Dim x As New dtlClientes
        x.logueo(usuario, password, resultado)

    End Sub

    Public Sub ObtenerProvincia(ByRef provincia As DataTable)
        Dim x As New dtlClientes
        x.ObtenerProvincia(provincia)

    End Sub

    Public Sub obtenerProveedor(ByRef proveedor As DataTable)
        Dim x As New dtlClientes
        x.obtenerProveedor(proveedor)

    End Sub

    Public Sub ObtenerLocalidad(ByVal valor As String, ByRef localidad As DataTable)
        Dim x As New dtlClientes
        x.ObtenerLocalidad(valor, localidad)

    End Sub

    Public Sub eliminarProveedor(ByVal idProveedor As Integer)
        Dim x As New dtlClientes
        x.eliminarProveedor(idProveedor)
        Dim strmensaje As String = "El proveedor se ELIMINÓ exitosamente"
        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

    End Sub



    Public Sub eliminarCliente(ByVal idCliente As Integer)
        Dim x As New dtlClientes
        x.eliminarCliente(idCliente)
        Dim strmensaje As String = "El cliente se ELIMINÓ exitosamente"
        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

    End Sub

    Public Sub eliminarProducto(ByVal idProducto As Integer)
        Dim x As New dtlClientes
        x.eliminarProducto(idProducto)
        Dim strmensaje As String = "El producto se ELIMINÓ exitosamente"
        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

    End Sub
    Public Sub obtenerGrillaCliente(ByRef cliente As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaCliente(cliente)

    End Sub
    Public Sub obtenerGrillaProductos(ByRef producto As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaProductos(producto)

    End Sub

    Public Sub obtenerGrillaModCliente(ByRef Cliente As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaModCliente(Cliente)

    End Sub

    Public Sub obtenerGrillaModProveedor(ByRef Cliente As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaModProveedor(Cliente)

    End Sub



    Public Sub obtenerGrillaModProducto(ByRef Cliente As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaModProducto(Cliente)

    End Sub
    Public Sub obtenerGrillaProveedores(ByRef proveedor As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaProveedores(proveedor)

    End Sub

    Public Sub obtenerGrillaProveedoresFiltrada(ByVal buscar As String, ByRef proveedor As DataTable)
        Dim x As New dtlClientes
        x.obtenerGrillaProveedoresFiltrada(buscar, proveedor)

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
        If (TxtNombre = "") Then

            MsgBox("Ingrese el nombre")

        Else


            If (TxtDomicilio = "") Then

                MsgBox("Ingrese el domicilio")

            Else

                If (CbLocalidad = "") Then

                    MsgBox("Ingrese la localidad")

                Else

                    If (CbProvincia = "") Then

                        MsgBox("Ingrese la provincia")

                    Else

                        If (TxtTelefono = "") Then

                            MsgBox("Ingrese el telefono")

                        Else


                            If (TxtCuit = "") Then

                                MsgBox("Ingrese el cuit")

                            Else

                                If (CbEstado = "") Then

                                    MsgBox("Ingrese el estado")

                                Else

                                    If (TxtRazonSocial = "") Then

                                        MsgBox("Ingrese la razon social")

                                    Else
                                        x.NuevoProveedor(TxtNombre,
                         TxtDomicilio,
                         CbLocalidad,
                         CbProvincia,
                         TxtTelefono,
                         TxtCuit,
                         CbEstado,
                         TxtObservaciones,
                         TxtRazonSocial)

                                        Dim strmensaje As String = "El Proveedor se agrego exitosamente"
                                        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")


                                    End If
                                End If
                            End If

                        End If
                    End If

                End If
            End If

        End If




    End Sub

    Public Sub modificarProveedorSeleccionado(ByVal TxtNombre,
                         ByVal TxtDomicilio,
                         ByVal CbLocalidad,
                         ByVal CbProvincia,
                         ByVal TxtTelefono,
                         ByVal TxtCuit,
                         ByVal CbEstado,
                         ByVal TxtObservaciones,
                         ByVal TxtRazonSocial,
                         ByVal modseleccion)


        Dim x As New dtlClientes

        'If (TxtNombre = "") Then

        '    MsgBox("Ingrese el nombre")

        'Else


        '    If (TxtDomicilio = "") Then

        '        MsgBox("Ingrese el domicilio")

        '    Else

        '        If (CbLocalidad = "") Then

        '            MsgBox("Ingrese la localidad")

        '        Else

        '            If (CbProvincia = "") Then

        '                MsgBox("Ingrese la provincia")

        '            Else

        '                If (TxtTelefono = "") Then

        '                    MsgBox("Ingrese el telefono")

        '                Else


        '                    If (TxtCuit = "") Then

        '                        MsgBox("Ingrese el cuit")

        '                    Else

        '                        If (CbEstado = "") Then

        '                            MsgBox("Ingrese el estado")

        '                        Else

        '                            If (TxtRazonSocial = "") Then

        '                                MsgBox("Ingrese la razon social")

        '                            Else
        x.modificarProveedorSeleccionado(TxtNombre,
                         TxtDomicilio,
                         CbLocalidad,
                         CbProvincia,
                         TxtTelefono,
                         TxtCuit,
                         CbEstado,
                         TxtObservaciones,
                         TxtRazonSocial,
                         modseleccion)

                                        Dim strmensaje As String = "El Proveedor se modificó exitosamente"
                                        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")


        '                            End If
        '                        End If
        '                    End If

        '                End If
        '            End If

        '        End If
        '    End If

        'End If




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
        If (TxtNombre = "") Then

            MsgBox("Ingrese el nombre")

        Else


            If (TxtApellido = "") Then

                MsgBox("Ingrese el apellido")

            Else

                If (TxtDNI = "") Then

                    MsgBox("Ingrese el dni")

                Else

                    If (TxtDomicilio = "") Then

                        MsgBox("Ingrese el domicilio")

                    Else

                        If (CbSexo = "") Then

                            MsgBox("Ingrese el sexo")


                        Else

                            If (TxtTelefono = "") Then

                                MsgBox("Ingrese el telefono")

                            Else

                                If (TxtEmail = "") Then

                                    MsgBox("Ingrese el email")

                                Else

                                    If (CbProvincia = "") Then

                                        MsgBox("Ingrese la provincia")

                                    Else

                                        If (CbLocalidad = "") Then

                                            MsgBox("Ingrese la localidad")

                                        Else

                                            If (CbEstado = "") Then

                                                MsgBox("Ingrese el estado")

                                            Else
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
                                                Dim strmensaje As String = "El cliente se agrego exitosamente"
                                                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")



                                            End If
                                        End If
                                    End If

                                End If
                            End If

                        End If
                    End If

                End If

            End If

        End If




    End Sub

    Public Sub modificarClienteSeleccionado(ByVal TxtNombre,
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


        Dim x As New dtlClientes
        If (TxtNombre = "") Then

            MsgBox("Ingrese el nombre")

        Else


            If (TxtApellido = "") Then

                MsgBox("Ingrese el apellido")

            Else

                If (TxtDNI = "") Then

                    MsgBox("Ingrese el dni")

                Else

                    If (TxtDomicilio = "") Then

                        MsgBox("Ingrese el domicilio")

                    Else

                        If (CbSexo = "") Then

                            MsgBox("Ingrese el sexo")


                        Else

                            If (TxtTelefono = "") Then

                                MsgBox("Ingrese el telefono")

                            Else

                                If (TxtEmail = "") Then

                                    MsgBox("Ingrese el email")

                                Else

                                    If (CbProvincia = "") Then

                                        MsgBox("Ingrese la provincia")

                                    Else

                                        If (CbLocalidad = "") Then

                                            MsgBox("Ingrese la localidad")

                                        Else

                                            If (CbEstado = "") Then

                                                MsgBox("Ingrese el estado")

                                            Else
                                                x.modificarClienteSeleccionado(TxtNombre,
                         TxtApellido,
                         TxtDNI,
                         TxtDomicilio,
                         CbSexo,
                         DTPFechaDeNacimiento,
                         TxtTelefono,
                         TxtEmail,
                         CbProvincia,
                         CbLocalidad,
                         CbEstado,
                         modSeleccion)
                                                Dim strmensaje As String = "El cliente se modificó exitosamente"
                                                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")



                                            End If
                                        End If
                                    End If

                                End If
                            End If

                        End If
                    End If

                End If

            End If

        End If




    End Sub

    Public Sub NuevoProducto(ByVal TxtNombre,
                            ByVal TxtMarca,
                            ByVal TxtDetalle,
                            ByVal TxtCantidad,
                            ByVal TxtEstado,
                            ByVal TxtProveedor,
                            ByVal TxtObservaciones)




        Dim x As New dtlClientes


        If (TxtNombre = "") Then

            MsgBox("Ingrese el nombre")

        Else


            If (TxtMarca = "") Then

                MsgBox("Ingrese la marca")

            Else

                If (TxtDetalle = "") Then

                    MsgBox("Ingrese detalle")

                Else

                    If (TxtCantidad = "") Then

                        MsgBox("Ingrese la cantidad")

                    Else

                        If (TxtEstado = "") Then

                            MsgBox("Ingrese estado")

                        Else


                            If (TxtProveedor = "") Then

                                MsgBox("Ingrese el proveedor")

                            Else




                                x.NuevoProducto(TxtNombre,
                         TxtMarca,
                         TxtDetalle,
                         TxtCantidad,
                         TxtEstado,
                         TxtProveedor,
                         TxtObservaciones)


                                Dim strmensaje As String = "El producto se agrego exitosamente"
                                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")


                            End If
                        End If
                    End If

                End If
            End If

        End If

    End Sub
    Public Sub ModificarProductoSeleccionado(ByVal TxtNombre,
                            ByVal TxtMarca,
                            ByVal TxtDetalle,
                            ByVal TxtCantidad,
                            ByVal TxtEstado,
                            ByVal TxtProveedor,
                            ByVal TxtObservaciones,
                            ByVal modseleccion)




        Dim x As New dtlClientes


        If (TxtNombre = "") Then

            MsgBox("Ingrese el nombre")

        Else


            If (TxtMarca = "") Then

                MsgBox("Ingrese la marca")

            Else

                If (TxtDetalle = "") Then

                    MsgBox("Ingrese detalle")

                Else

                    If (TxtCantidad = "") Then

                        MsgBox("Ingrese la cantidad")

                    Else

                        If (TxtEstado = "") Then

                            MsgBox("Ingrese estado")

                        Else


                            If (TxtProveedor = "") Then

                                MsgBox("Ingrese el proveedor")

                            Else




                                x.ModificarProductoSeleccionado(TxtNombre,
                         TxtMarca,
                         TxtDetalle,
                         TxtCantidad,
                         TxtEstado,
                         TxtProveedor,
                         TxtObservaciones,
                         modseleccion)


                                Dim strmensaje As String = "El producto se agrego exitosamente"
                                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")


                            End If
                        End If
                    End If

                End If
            End If

        End If

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


End Class
