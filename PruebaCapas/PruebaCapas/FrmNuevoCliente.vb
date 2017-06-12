Imports wflSistema
Public Class FrmIngresarNuevoCliente
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        Dim x As New wflClientes
        Dim strmensaje As String = "El cliente se cargo con exito"

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

        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

    End Sub
End Class