Imports wflSistema

Public Class FmrBajaProveedor
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub FmrBajaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaProveedores(Cbfiltrar.Text, TxtIngresarDato.Text, dt)

        DGVBjaProveedor.DataSource = dt
    End Sub
End Class