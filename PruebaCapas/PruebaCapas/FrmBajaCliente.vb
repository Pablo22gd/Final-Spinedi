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

        Dim x As New wflClientes
        Dim strmensaje As String = ""

        'x.eliminarCliente(txtIdCliente.Text, strmensaje)
        'MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")
        'txtIdCliente.Text = ""
        'txtrazonsocial.Text = ""

    End Sub

    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    '    Dim x As New wflClientes
    '    Dim dt As New DataTable

    '    Dim strmensaje As String = ""

    '    x.buscarCliente(CBFiltro.Text, TxtBuscar.Text, dt)

    '    If dt.Rows.Count > 0 Then
    '        For Each MiDataRow As DataRow In dt.Rows
    '            Me.TextBox1.Text = MiDataRow(1).ToString
    '        Next

    '    Else
    '        MsgBox("El cliente no existe en la base de datos", vbInformation + vbOKOnly, "Aviso al operador")
    '    End If

    'End Sub
End Class