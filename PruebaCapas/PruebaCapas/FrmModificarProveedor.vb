Imports wflSistema
Public Class FrmModificarProveedor
    Private Sub FrmModificarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaModProveedor(dt)

        DGVGrillaModificarProveedor.DataSource = dt

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim x As New wflClientes
        Dim tabla As New DataTable
        Dim modSeleccion As String
        Dim dt As New DataTable


        modSeleccion = (DGVGrillaModificarProveedor(0, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())

        x.modificarProveedorSeleccionado(TxtNombre.Text,
                          TxtDomicilio.Text,
                          CbLocalidad.Text,
                          CbProvincia.Text,
                          TxtTelefono.Text,
                          TxtCuit.Text,
                          CbEstado.Text,
                          TxtObservaciones.Text,
                          TxtRazonSocial.Text,
                          modSeleccion)

        x.obtenerGrillaProveedores(dt)

        DGVGrillaModificarProveedor.DataSource = dt


    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub DGVGrillaModificarProveedor_SelectionChanged(sender As Object, e As EventArgs) Handles DGVGrillaModificarProveedor.SelectionChanged

        Dim x As New wflClientes
        Dim tabla As New DataTable


        If tabla.Rows.Count > -1 Then

            TxtNombre.Text = (DGVGrillaModificarProveedor(1, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            TxtDomicilio.Text = (DGVGrillaModificarProveedor(2, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            CbProvincia.Text = (DGVGrillaModificarProveedor(3, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            CbLocalidad.Text = (DGVGrillaModificarProveedor(4, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            TxtTelefono.Text = (DGVGrillaModificarProveedor(5, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            TxtCuit.Text = (DGVGrillaModificarProveedor(6, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            CbEstado.Text = (DGVGrillaModificarProveedor(7, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            TxtRazonSocial.Text = (DGVGrillaModificarProveedor(8, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())
            TxtObservaciones.Text = (DGVGrillaModificarProveedor(9, DGVGrillaModificarProveedor.CurrentCell.RowIndex).Value.ToString())

        End If
    End Sub

End Class