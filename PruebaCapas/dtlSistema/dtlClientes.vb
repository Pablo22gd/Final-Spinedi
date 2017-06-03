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
        Adp.SelectCommand.Parameters.Add("@idcliente", SqlDbType.Int, 4)
        Adp.SelectCommand.Parameters("@idcliente").Value = idcliente
        Adp.Fill(table)
        clientes = table


    End Sub

    Public Sub obtenerCliente(ByRef cbFiltro As String, ByRef txtBuscar As String, ByRef clientes As DataTable)
        oConn = New SqlConnection("Data Source=192.168.5.82\\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()
        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "obtenerCliente_q_sp"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.Parameters("@filtro").Value = cbFiltro
        Adp.SelectCommand.Parameters("@buscar").Value = txtBuscar
        Adp.Fill(table)
        clientes = table


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


    Public Sub eliminarCliente(ByRef intidcliente As Integer)
        oConn = New SqlConnection("Data Source=192.168.5.82\\SQLEXPRESS;Initial Catalog=Stock;User ID=joel;Password=casa12;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "eliminarCliente_d_sp"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub
End Class
