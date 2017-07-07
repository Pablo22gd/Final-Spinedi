
Imports wflSistema
Public Class FrmConsultaCliente


    Private Sub FrmConsultaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaCliente(dt)

        DGVGrillaCliente.DataSource = dt




    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaClienteFiltrada(txtBuscar.Text, dt)

        DGVGrillaCliente.DataSource = dt
    End Sub
End Class