Imports wflSistema


Public Class FrmNuevoProveedor
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim x As New wflClientes


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


        TxtNombre.Text = ""
        TxtDomicilio.Text = ""
        CbLocalidad.SelectedValue = ""
        CbProvincia.ValueMember = ""
        TxtTelefono.Text = ""
        TxtCuit.Text = ""
        CbEstado.ValueMember = ""
        TxtObservaciones.Text = ""
        TxtRazonSocial.Text = ""


    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub LblObservaciones_Click(sender As Object, e As EventArgs) Handles LblObservaciones.Click

    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged

    End Sub

    Private Sub TxtTelefono_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTelefono.KeyDown

    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtCuit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCuit.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Class