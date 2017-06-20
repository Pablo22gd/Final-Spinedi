Imports wflSistema
Public Class FrmBajaCliente


    'Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
    '    Dim x As New wflClientes
    '    Dim strmensaje As String = ""

    '    x.eliminarCliente(idCliente, strmensaje)
    '    MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

    'End Sub

    Private Sub FrmBajaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        'Dim x As New wflClientes
        'Dim strmensaje As String = ""

        'x.eliminarCliente(txtIdCliente.Text, strmensaje)
        'MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")
        'txtIdCliente.Text = ""
        'txtrazonsocial.Text = ""

    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim x As New wflClientes
        Dim dt As New DataTable

        Dim strmensaje As String = ""


        x.obtenerGrillaCliente(CBFiltro.Text, TxtBuscar.Text, dt)

        DGVGrillaBajaCliente.DataSource = dt
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

    End Sub



End Class