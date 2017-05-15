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
