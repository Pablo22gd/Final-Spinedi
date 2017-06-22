Imports wflSistema
Public Class FrmBajaCliente


    Private Sub FrmBajaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim x As New wflClientes
        Dim dt As New DataTable

            Dim strmensaje As String = ""


        x.obtenerGrillaCliente(dt)

        DGVGrillaBajaCliente.DataSource = dt




    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (DGVGrillaBajaCliente.SelectedRows.Count <> 0) Then

            Dim modSeleccion As String = 0

            modSeleccion = (DGVGrillaBajaCliente(0, DGVGrillaBajaCliente.CurrentCell.RowIndex).Value.ToString())

            Dim x As New wflClientes

            Dim strmensaje As String = ""


            x.eliminarCliente(modSeleccion)

            Dim dt As New DataTable

            x.obtenerGrillaCliente(dt)

            DGVGrillaBajaCliente.DataSource = dt

        End If

    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub
End Class