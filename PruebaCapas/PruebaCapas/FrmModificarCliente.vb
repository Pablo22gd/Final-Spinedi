Imports wflSistema
Public Class FrmModificarCliente
    Private Sub FrmModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaModCliente(dt)

        DGVGrillaModificarCliente.DataSource = dt
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        Dim x As New wflClientes
        Dim tabla As New DataTable
        Dim modSeleccion As String
        Dim dt As New DataTable



        modSeleccion = (DGVGrillaModificarCliente(0, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())

        x.modificarClienteSeleccionado(TxtNombre.Text,
                         TxtApellido.Text,
                         TxtDNI.Text,
                         TxtDomicilio.Text,
                         CbSexo.Text,
                         fechaNacimiento.Text,
                         TxtTelefono.Text,
                         TxtEmail.Text,
                         CbProvincia.Text,
                         CbLocalidad.Text,
                         CbEstado.Text,
                         modSeleccion)

        x.obtenerGrillaCliente(dt)

        DGVGrillaModificarCliente.DataSource = dt

    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDNI.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub DGVGrillaModificarCliente_SelectionChanged(sender As Object, e As EventArgs) Handles DGVGrillaModificarCliente.SelectionChanged

        Dim x As New wflClientes
        Dim tabla As New DataTable
        Dim modSeleccion As String


        modSeleccion = (DGVGrillaModificarCliente(0, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())

        x.obtenerGrillaClienteFiltrada(modSeleccion, tabla)

        If tabla.Rows.Count > -1 Then

            TxtNombre.Text = (DGVGrillaModificarCliente(1, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            TxtApellido.Text = (DGVGrillaModificarCliente(2, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            TxtDNI.Text = (DGVGrillaModificarCliente(3, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            TxtDomicilio.Text = (DGVGrillaModificarCliente(4, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            CbSexo.Text = (DGVGrillaModificarCliente(5, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            fechaNacimiento.Text = (DGVGrillaModificarCliente(6, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            TxtTelefono.Text = (DGVGrillaModificarCliente(7, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            TxtEmail.Text = (DGVGrillaModificarCliente(8, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            CbProvincia.Text = (DGVGrillaModificarCliente(9, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            CbLocalidad.Text = (DGVGrillaModificarCliente(10, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
            CbEstado.Text = (DGVGrillaModificarCliente(11, DGVGrillaModificarCliente.CurrentCell.RowIndex).Value.ToString())
        End If

    End Sub
End Class