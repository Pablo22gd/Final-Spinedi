Imports wflSistema
Public Class FrmBajaCliente


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.eliminarCliente(idCliente, strmensaje)
        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

    End Sub

    Private Sub FrmBajaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""

        x.buscarCliente(CBFiltro.Text, TxtBuscar.Text, dt)

    End Sub
End Class