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
End Class
