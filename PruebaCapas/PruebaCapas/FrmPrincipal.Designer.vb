<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.FacturacionToolStripMenuItem, Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem, Me.BajaClienteToolStripMenuItem, Me.ConsultaClienteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AltaClienteToolStripMenuItem.Text = "Alta Cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar Cliente"
        '
        'BajaClienteToolStripMenuItem
        '
        Me.BajaClienteToolStripMenuItem.Name = "BajaClienteToolStripMenuItem"
        Me.BajaClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.BajaClienteToolStripMenuItem.Text = "Baja Cliente"
        '
        'ConsultaClienteToolStripMenuItem
        '
        Me.ConsultaClienteToolStripMenuItem.Name = "ConsultaClienteToolStripMenuItem"
        Me.ConsultaClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ConsultaClienteToolStripMenuItem.Text = "Consulta Cliente"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaProveedorToolStripMenuItem, Me.ModificarProveedorToolStripMenuItem, Me.BajaProveedorToolStripMenuItem, Me.ListadoDeProveedoresToolStripMenuItem})
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'AltaProveedorToolStripMenuItem
        '
        Me.AltaProveedorToolStripMenuItem.Name = "AltaProveedorToolStripMenuItem"
        Me.AltaProveedorToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AltaProveedorToolStripMenuItem.Text = "Alta Proveedor"
        '
        'ModificarProveedorToolStripMenuItem
        '
        Me.ModificarProveedorToolStripMenuItem.Name = "ModificarProveedorToolStripMenuItem"
        Me.ModificarProveedorToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ModificarProveedorToolStripMenuItem.Text = "Modificar Proveedor"
        '
        'BajaProveedorToolStripMenuItem
        '
        Me.BajaProveedorToolStripMenuItem.Name = "BajaProveedorToolStripMenuItem"
        Me.BajaProveedorToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.BajaProveedorToolStripMenuItem.Text = "Baja Proveedor"
        '
        'ListadoDeProveedoresToolStripMenuItem
        '
        Me.ListadoDeProveedoresToolStripMenuItem.Name = "ListadoDeProveedoresToolStripMenuItem"
        Me.ListadoDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaProductoToolStripMenuItem, Me.ModificarProductoToolStripMenuItem, Me.BajaProductoToolStripMenuItem, Me.ConsultaProductoToolStripMenuItem})
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'AltaProductoToolStripMenuItem
        '
        Me.AltaProductoToolStripMenuItem.Name = "AltaProductoToolStripMenuItem"
        Me.AltaProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AltaProductoToolStripMenuItem.Text = "Alta Producto"
        '
        'ModificarProductoToolStripMenuItem
        '
        Me.ModificarProductoToolStripMenuItem.Name = "ModificarProductoToolStripMenuItem"
        Me.ModificarProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ModificarProductoToolStripMenuItem.Text = "Modificar Producto"
        '
        'BajaProductoToolStripMenuItem
        '
        Me.BajaProductoToolStripMenuItem.Name = "BajaProductoToolStripMenuItem"
        Me.BajaProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BajaProductoToolStripMenuItem.Text = "Baja Producto"
        '
        'ConsultaProductoToolStripMenuItem
        '
        Me.ConsultaProductoToolStripMenuItem.Name = "ConsultaProductoToolStripMenuItem"
        Me.ConsultaProductoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ConsultaProductoToolStripMenuItem.Text = "Consulta Producto"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompraDeProductosToolStripMenuItem, Me.ListadoDeFacturaToolStripMenuItem})
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'CompraDeProductosToolStripMenuItem
        '
        Me.CompraDeProductosToolStripMenuItem.Name = "CompraDeProductosToolStripMenuItem"
        Me.CompraDeProductosToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CompraDeProductosToolStripMenuItem.Text = "Compra de productos"
        '
        'ListadoDeFacturaToolStripMenuItem
        '
        Me.ListadoDeFacturaToolStripMenuItem.Name = "ListadoDeFacturaToolStripMenuItem"
        Me.ListadoDeFacturaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ListadoDeFacturaToolStripMenuItem.Text = "Listado de Factura"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(880, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 355)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
End Class
