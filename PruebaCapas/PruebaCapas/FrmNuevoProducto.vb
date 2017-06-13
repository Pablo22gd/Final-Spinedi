Imports wflSistema
Public Class FrmNuevoProducto
    Private Sub LblNuevoProducto_Click(sender As Object, e As EventArgs) Handles LblNuevoProducto.Click

    End Sub

    Private Sub FrmNuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblEstado_Click(sender As Object, e As EventArgs) Handles LblEstado.Click

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim x As New wflClientes
        Dim strmensaje As String = "El producto se cargo con exito"

        x.NuevoProducto(
                         TxtNombre.Text,
                         TxtMarca.Text,
                         TxtDetalle.Text,
                         TxtCantidad.Text,
                         CBEstado.Text,
                         TxtProveedor.Text,
                         TxtObservaciones.Text
                                               )

        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

    End Sub
End Class