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

    Private Sub CbLocalidad_MouseClick(sender As Object, e As MouseEventArgs) Handles CbLocalidad.MouseClick
        Dim x As New wflClientes
        Dim dt As New DataTable



        Dim valor As [String] = DirectCast(CbProvincia.SelectedItem, System.Data.DataRowView).Row.ItemArray(0).ToString()


        x.ObtenerLocalidad(valor,
                        dt
                         )

        CbLocalidad.DataSource = dt

        CbLocalidad.ValueMember = "localidad"

        CbLocalidad.DisplayMember = "localidad"
    End Sub

    Private Sub CbProvincia_MouseClick(sender As Object, e As MouseEventArgs) Handles CbProvincia.MouseClick
        Dim x As New wflClientes
        Dim dt As New DataTable

        x.ObtenerProvincia(dt)

        CbLocalidad.SelectedValue = ""
        CbLocalidad.Text = ""
        CbProvincia.DataSource = dt

        CbProvincia.ValueMember = "provincia"

        CbProvincia.DisplayMember = "provincia"

    End Sub
End Class