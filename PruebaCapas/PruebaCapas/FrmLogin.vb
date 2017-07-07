
Imports wflSistema
Public Class FrmLogin
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable


        x.logueo(TxtUsuario.Text, TxtPassword.Text, dt)


    End Sub
End Class