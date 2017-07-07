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

        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtDNI.Text = ""
        TxtDomicilio.Text = ""
        CbSexo.Text = ""
        DTPFechaDeNacimiento.Text = ""
        TxtTelefono.Text = ""
        TxtEmail.Text = ""
        CbProvincia.Text = ""
        CbLocalidad.Text = ""
        CbEstado.Text = ""

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

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub CbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProvincia.SelectedIndexChanged

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

    Private Sub TxtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNI.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub CbProvincia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CbProvincia.KeyPress

    End Sub

    Private Sub CbProvincia_KeyDown(sender As Object, e As KeyEventArgs) Handles CbProvincia.KeyDown

    End Sub
End Class