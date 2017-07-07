Imports System.Data.SqlClient
Public Class dtlClientes

    Private Property oConn As SqlConnection



    Public Sub obtenerRegistro(ByRef idcliente As Integer, ByRef clientes As DataTable)
        oConn = New SqlConnection("Server=DIENAMOVIL\SQLEXPRESS;integrated security=true;database=Segpool")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "sp_obtenerRegistro"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        clientes = table


    End Sub

    Public Sub ObtenerProvincia(ByRef provincia As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenerProvincia_q_sp"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        provincia = table


    End Sub

    Public Sub ObtenerGrillaProductoFiltrado(ByVal txtIngresarDato As String, ByRef resultado As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        '

        Dim cmd As New SqlCommand("obtenerProductoFiltrado_q_sp", oConn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("valor", txtIngresarDato)

        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        resultado = dt


    End Sub

    Public Sub ObtenerLocalidad(ByVal valor As String, ByRef localidad As DataTable)


        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        '

        Dim cmd As New SqlCommand("obtenerLocalidadCorrespondiente_q_sp", oConn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("valor", valor)

        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        localidad = dt



































    End Sub


    Public Sub obtenerGrillaClienteFiltrada(ByVal buscar As String, ByRef cliente As DataTable)


        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        '

        Dim cmd As New SqlCommand("buscarClienteFiltrado_q_sp", oConn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("buscar", buscar)

        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        cliente = dt


    End Sub


    Public Sub obtenerGrillaModCliente(ByRef Clientes As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenercliente"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        Clientes = table


    End Sub

    Public Sub obtenerGrillaModProveedor(ByRef Clientes As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenerproveedor_q_sp"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        Clientes = table


    End Sub

    Public Sub obtenerGrillaModProducto(ByRef Clientes As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenerProducto_q_sp"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        Clientes = table


    End Sub
    Public Sub obtenerGrillaCliente(ByRef clientes As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenercliente"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        clientes = table


    End Sub

    Public Sub obtenerGrillaProductos(ByRef producto As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenerProducto_q_sp"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        producto = table


    End Sub
    Public Sub obtenerGrillaProveedores(ByRef proveedor As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()


        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenerProveedor_q_sp"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure

        Adp.Fill(table)
        proveedor = table


    End Sub

    Public Sub obtenerGrillaProveedoresFiltrada(ByVal buscar As String, ByRef proveedor As DataTable)


        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        '

        Dim cmd As New SqlCommand("obtenerProveedorFiltrado_q_sp", oConn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("buscar", buscar)

        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        proveedor = dt





    End Sub


    Public Sub logueo(ByVal usuario As String, ByVal password As String, ByRef resultado As DataTable)


        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        '

        Dim cmd As New SqlCommand("", oConn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("usuario", usuario)

        cmd.Parameters.AddWithValue("password", password)

        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)

        Dim dt As New DataTable()

        da.Fill(dt)

        resultado = dt





    End Sub

    Public Sub insertarRegistro(ByRef intidcliente As Integer, ByRef strrazonSocial As String)
        oConn = New SqlConnection("Server=DIENAMOVIL\SQLEXPRESS;integrated security=true;database=Segpool")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(1) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)
        param(1) = New SqlParameter("@razonsocial", strrazonSocial)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_insertarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



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
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(8) As SqlParameter

        param(0) = New SqlParameter("@nombre", TxtNombre)
        param(1) = New SqlParameter("@domicilio", TxtDomicilio)
        param(2) = New SqlParameter("@localidad", CbLocalidad)
        param(3) = New SqlParameter("@provincia", CbProvincia)
        param(4) = New SqlParameter("@telefono", TxtTelefono)
        param(5) = New SqlParameter("@cuit", TxtCuit)
        param(6) = New SqlParameter("@estado", CbEstado)
        param(7) = New SqlParameter("@observaciones", TxtObservaciones)
        param(8) = New SqlParameter("@razonsocial", TxtRazonSocial)



        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "insertarProveedor_i_sp"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



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
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(10) As SqlParameter

        param(0) = New SqlParameter("@nombre", TxtNombre)
        param(1) = New SqlParameter("@apellido", TxtApellido)
        param(2) = New SqlParameter("@dni", TxtDNI)
        param(3) = New SqlParameter("@domicilio", TxtDomicilio)
        param(4) = New SqlParameter("@sexo", CbSexo)
        param(5) = New SqlParameter("@fecha_de_nacimiento", DTPFechaDeNacimiento)
        param(6) = New SqlParameter("@telefono", TxtTelefono)
        param(7) = New SqlParameter("@email", TxtEmail)
        param(8) = New SqlParameter("@provincia", CbProvincia)
        param(9) = New SqlParameter("@localidad", CbLocalidad)
        param(10) = New SqlParameter("@estado", CbEstado)



        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Nuevo_Cliente_i_sp"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub NuevoProducto(ByVal TxtNombre,
                         ByVal TxtMarca,
                         ByVal TxtDetalle,
                         ByVal TxtCantidad,
                         ByVal CbEstado,
                         ByVal TxtProveedor,
                         ByVal TxtObservaciones)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(6) As SqlParameter

        param(0) = New SqlParameter("@nombre", TxtNombre)
        param(1) = New SqlParameter("@marca", TxtMarca)
        param(2) = New SqlParameter("@detalle", TxtDetalle)
        param(3) = New SqlParameter("@cantidad", TxtCantidad)
        param(4) = New SqlParameter("@estado", CbEstado)
        param(5) = New SqlParameter("@proveedor", TxtProveedor)
        param(6) = New SqlParameter("@observaciones", TxtObservaciones)




        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Nuevo_Producto_i_sp"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarRegistro(ByRef intidcliente As Integer)
        oConn = New SqlConnection("Server=DIENAMOVIL\SQLEXPRESS;integrated security=true;database=Segpool")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_eliminarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarProveedor(ByRef idProveedor As Integer)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@id_proveedor", idProveedor)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "eliminarProveedor_d_sp"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarProducto(ByRef idProducto As Integer)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@id_producto", idProducto)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "eliminarproducto_d_sp"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarCliente(ByRef idCliente As Integer)
        oConn = New SqlConnection("Data Source=192.168.5.82\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@idcliente", idCliente)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "eliminarCliente_d_sp"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub







End Class
