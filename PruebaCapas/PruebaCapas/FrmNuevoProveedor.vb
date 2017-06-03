Imports wflSistema


Public Class FrmNuevoProveedor
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.NuevoProveedor(
                         TxtNombre.Text,
                         TxtDomicilio.Text,
                         CbLocalidad.Text,
                         CbProvincia.Text,
                         TxtTelefono.Text,
                         TxtCuit.Text,
                         CbEstado.Text,
                         TxtObservaciones.Text,
                         TxtRazonSocial.Text)

        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")


    End Sub
End Class