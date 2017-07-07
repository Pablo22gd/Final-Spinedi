Public Class FrmPrincipal
    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        Dim frmAltaCliente As New FrmIngresarNuevoCliente()
        frmAltaCliente.Show()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        Dim frmModificarCliente As New FrmModificarCliente()
        frmModificarCliente.Show()
    End Sub

    Private Sub BajaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaClienteToolStripMenuItem.Click
        Dim frmBajaCliente As New FrmBajaCliente()
        frmBajaCliente.Show()
    End Sub

    Private Sub AltaProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaProveedorToolStripMenuItem.Click
        Dim frmAltaProveedor As New FrmNuevoProveedor()
        FrmNuevoProveedor.Show()
    End Sub

    Private Sub ModificarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProveedorToolStripMenuItem.Click
        Dim frmModificarProveedor As New FrmModificarProveedor()
        frmModificarProveedor.Show()
    End Sub

    Private Sub BajaProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaProveedorToolStripMenuItem.Click
        Dim frmBajaProveedor As New FmrBajaProveedor()
        frmBajaProveedor.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AltaProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaProductoToolStripMenuItem.Click
        Dim frmNuevoProducto As New FrmNuevoProducto()
        frmNuevoProducto.Show()
    End Sub

    Private Sub ModificarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        Dim frmModificarProducto As New FrmModificarProducto()
        frmModificarProducto.Show()
    End Sub

    Private Sub BajaProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaProductoToolStripMenuItem.Click
        Dim frmBajaProducto As New FrmBajaProducto()
        frmBajaProducto.Show()
    End Sub

    Private Sub CompraDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeProductosToolStripMenuItem.Click
        Dim frmFacturacion As New FrmFacturacion()
        frmFacturacion.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConsultaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaClienteToolStripMenuItem.Click
        Dim frmconsultaCliente As New FrmConsultaCliente()
        frmconsultaCliente.Show()
    End Sub

    Private Sub ConsultaProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaProductoToolStripMenuItem.Click
        Dim frmconsultaProducto As New FrmConsultaProducto()
        frmconsultaProducto.Show()
    End Sub
End Class