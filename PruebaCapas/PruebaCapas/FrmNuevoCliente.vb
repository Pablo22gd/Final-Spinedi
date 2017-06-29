Imports wflSistema
Public Class FrmIngresarNuevoCliente
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Dim x As New wflClientes


        x.NuevoCliente(
                         TxtNombre.Text,
                         TxtApellido.Text,
                         TxtDNI.Text,
                         TxtDomicilio.Text,
                         CbSexo.Text,
                         DTPFechaDeNacimiento.Text,
                         TxtTelefono.Text,
                         TxtEmail.Text,
                         CbProvincia.Text,
                         CbLocalidad.Text,
                         CbEstado.Text
                         )



    End Sub

    Private Sub CbProvincia_MouseClick(sender As Object, e As MouseEventArgs) Handles CbProvincia.MouseClick


        Dim x As New wflClientes
        Dim dt As New DataTable

        x.ObtenerProvincia(
                        dt
                         )



    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub CbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProvincia.SelectedIndexChanged

    End Sub

    Private Sub CbLocalidad_MouseClick(sender As Object, e As MouseEventArgs) Handles CbLocalidad.MouseClick
        Dim x As New wflClientes
        Dim dt As New DataTable

        x.ObtenerLocalidad(
                        dt
                         )

    End Sub
End Class