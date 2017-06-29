<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoProveedor
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
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.NUDCantidad = New System.Windows.Forms.NumericUpDown()
        Me.LblRazonSocial = New System.Windows.Forms.Label()
        Me.Lblcantidad = New System.Windows.Forms.Label()
        Me.LblCuit = New System.Windows.Forms.Label()
        Me.LblPrecioVenta = New System.Windows.Forms.Label()
        Me.LblPrecioCompra = New System.Windows.Forms.Label()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.NUDProducto = New System.Windows.Forms.NumericUpDown()
        Me.LblNuevoProveedor = New System.Windows.Forms.Label()
        Me.PictureNuevoProveedor = New System.Windows.Forms.PictureBox()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.CbProvincia = New System.Windows.Forms.ComboBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.TxtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.CbLocalidad = New System.Windows.Forms.ComboBox()
        Me.DGVNuevoProveedor = New System.Windows.Forms.DataGridView()
        CType(Me.NUDCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureNuevoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVNuevoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCuit
        '
        Me.TxtCuit.Location = New System.Drawing.Point(266, 274)
        Me.TxtCuit.MaxLength = 13
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(200, 20)
        Me.TxtCuit.TabIndex = 5
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(266, 441)
        Me.TxtRazonSocial.MaxLength = 30
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(200, 20)
        Me.TxtRazonSocial.TabIndex = 11
        '
        'NUDCantidad
        '
        Me.NUDCantidad.Location = New System.Drawing.Point(266, 413)
        Me.NUDCantidad.Name = "NUDCantidad"
        Me.NUDCantidad.Size = New System.Drawing.Size(200, 20)
        Me.NUDCantidad.TabIndex = 10
        '
        'LblRazonSocial
        '
        Me.LblRazonSocial.AutoSize = True
        Me.LblRazonSocial.Location = New System.Drawing.Point(133, 441)
        Me.LblRazonSocial.Name = "LblRazonSocial"
        Me.LblRazonSocial.Size = New System.Drawing.Size(68, 13)
        Me.LblRazonSocial.TabIndex = 96
        Me.LblRazonSocial.Text = "Razon social"
        '
        'Lblcantidad
        '
        Me.Lblcantidad.AutoSize = True
        Me.Lblcantidad.Location = New System.Drawing.Point(133, 413)
        Me.Lblcantidad.Name = "Lblcantidad"
        Me.Lblcantidad.Size = New System.Drawing.Size(49, 13)
        Me.Lblcantidad.TabIndex = 95
        Me.Lblcantidad.Text = "Cantidad"
        '
        'LblCuit
        '
        Me.LblCuit.AutoSize = True
        Me.LblCuit.Location = New System.Drawing.Point(133, 274)
        Me.LblCuit.Name = "LblCuit"
        Me.LblCuit.Size = New System.Drawing.Size(25, 13)
        Me.LblCuit.TabIndex = 94
        Me.LblCuit.Text = "Cuit"
        '
        'LblPrecioVenta
        '
        Me.LblPrecioVenta.AutoSize = True
        Me.LblPrecioVenta.Location = New System.Drawing.Point(133, 386)
        Me.LblPrecioVenta.Name = "LblPrecioVenta"
        Me.LblPrecioVenta.Size = New System.Drawing.Size(68, 13)
        Me.LblPrecioVenta.TabIndex = 93
        Me.LblPrecioVenta.Text = "Precio Venta"
        '
        'LblPrecioCompra
        '
        Me.LblPrecioCompra.AutoSize = True
        Me.LblPrecioCompra.Location = New System.Drawing.Point(131, 354)
        Me.LblPrecioCompra.Name = "LblPrecioCompra"
        Me.LblPrecioCompra.Size = New System.Drawing.Size(75, 13)
        Me.LblPrecioCompra.TabIndex = 92
        Me.LblPrecioCompra.Text = "Precio compra"
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(133, 478)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 91
        Me.LblObservaciones.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(266, 475)
        Me.TxtObservaciones.MaxLength = 50
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(200, 86)
        Me.TxtObservaciones.TabIndex = 12
        '
        'NUDProducto
        '
        Me.NUDProducto.Location = New System.Drawing.Point(266, 298)
        Me.NUDProducto.Name = "NUDProducto"
        Me.NUDProducto.Size = New System.Drawing.Size(200, 20)
        Me.NUDProducto.TabIndex = 6
        '
        'LblNuevoProveedor
        '
        Me.LblNuevoProveedor.AutoSize = True
        Me.LblNuevoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevoProveedor.Location = New System.Drawing.Point(662, 51)
        Me.LblNuevoProveedor.Name = "LblNuevoProveedor"
        Me.LblNuevoProveedor.Size = New System.Drawing.Size(139, 18)
        Me.LblNuevoProveedor.TabIndex = 88
        Me.LblNuevoProveedor.Text = "Nuevo Proveedor"
        '
        'PictureNuevoProveedor
        '
        Me.PictureNuevoProveedor.Location = New System.Drawing.Point(616, 91)
        Me.PictureNuevoProveedor.Name = "PictureNuevoProveedor"
        Me.PictureNuevoProveedor.Size = New System.Drawing.Size(233, 150)
        Me.PictureNuevoProveedor.TabIndex = 87
        Me.PictureNuevoProveedor.TabStop = False
        '
        'CbEstado
        '
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"activo"})
        Me.CbEstado.Location = New System.Drawing.Point(266, 324)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(200, 21)
        Me.CbEstado.TabIndex = 7
        '
        'CbProvincia
        '
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Items.AddRange(New Object() {"bsas"})
        Me.CbProvincia.Location = New System.Drawing.Point(266, 223)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(200, 21)
        Me.CbProvincia.TabIndex = 3
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(266, 166)
        Me.TxtDomicilio.MaxLength = 30
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TxtDomicilio.TabIndex = 1
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(266, 62)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(200, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(131, 324)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 80
        Me.LblEstado.Text = "Estado"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(131, 197)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 79
        Me.LblLocalidad.Text = "Localidad"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(131, 223)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 78
        Me.LblProvincia.Text = "Provincia"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(131, 300)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(50, 13)
        Me.LblProducto.TabIndex = 77
        Me.LblProducto.Text = "Producto"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(130, 251)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 76
        Me.LblTelefono.Text = "Telefono"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(130, 170)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 75
        Me.LblDomicilio.Text = "Domicilio"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(130, 65)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 74
        Me.LblNombre.Text = "Nombre"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(607, 413)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 14
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(803, 410)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(266, 251)
        Me.TxtTelefono.MaxLength = 20
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefono.TabIndex = 4
        '
        'TxtPrecioCompra
        '
        Me.TxtPrecioCompra.Location = New System.Drawing.Point(266, 354)
        Me.TxtPrecioCompra.MaxLength = 6
        Me.TxtPrecioCompra.Name = "TxtPrecioCompra"
        Me.TxtPrecioCompra.Size = New System.Drawing.Size(200, 20)
        Me.TxtPrecioCompra.TabIndex = 8
        '
        'TxtPrecioVenta
        '
        Me.TxtPrecioVenta.Location = New System.Drawing.Point(266, 383)
        Me.TxtPrecioVenta.MaxLength = 6
        Me.TxtPrecioVenta.Name = "TxtPrecioVenta"
        Me.TxtPrecioVenta.Size = New System.Drawing.Size(200, 20)
        Me.TxtPrecioVenta.TabIndex = 9
        '
        'CbLocalidad
        '
        Me.CbLocalidad.FormattingEnabled = True
        Me.CbLocalidad.Items.AddRange(New Object() {"bsas"})
        Me.CbLocalidad.Location = New System.Drawing.Point(266, 192)
        Me.CbLocalidad.Name = "CbLocalidad"
        Me.CbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CbLocalidad.TabIndex = 2
        '
        'DGVNuevoProveedor
        '
        Me.DGVNuevoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNuevoProveedor.Location = New System.Drawing.Point(488, 283)
        Me.DGVNuevoProveedor.Name = "DGVNuevoProveedor"
        Me.DGVNuevoProveedor.Size = New System.Drawing.Size(485, 91)
        Me.DGVNuevoProveedor.TabIndex = 108
        '
        'FrmNuevoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 598)
        Me.Controls.Add(Me.DGVNuevoProveedor)
        Me.Controls.Add(Me.CbLocalidad)
        Me.Controls.Add(Me.TxtPrecioVenta)
        Me.Controls.Add(Me.TxtPrecioCompra)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCuit)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.NUDCantidad)
        Me.Controls.Add(Me.LblRazonSocial)
        Me.Controls.Add(Me.Lblcantidad)
        Me.Controls.Add(Me.LblCuit)
        Me.Controls.Add(Me.LblPrecioVenta)
        Me.Controls.Add(Me.LblPrecioCompra)
        Me.Controls.Add(Me.LblObservaciones)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.NUDProducto)
        Me.Controls.Add(Me.LblNuevoProveedor)
        Me.Controls.Add(Me.PictureNuevoProveedor)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.CbProvincia)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblProducto)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblDomicilio)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "FrmNuevoProveedor"
        Me.Text = "Asistente para agregar un nuevo proveedor"
        CType(Me.NUDCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureNuevoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVNuevoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCuit As TextBox
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents NUDCantidad As NumericUpDown
    Friend WithEvents LblRazonSocial As Label
    Friend WithEvents Lblcantidad As Label
    Friend WithEvents LblCuit As Label
    Friend WithEvents LblPrecioVenta As Label
    Friend WithEvents LblPrecioCompra As Label
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents NUDProducto As NumericUpDown
    Friend WithEvents LblNuevoProveedor As Label
    Friend WithEvents PictureNuevoProveedor As PictureBox
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents CbProvincia As ComboBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblLocalidad As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents LblProducto As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtPrecioCompra As TextBox
    Friend WithEvents TxtPrecioVenta As TextBox
    Friend WithEvents CbLocalidad As ComboBox
    Friend WithEvents DGVNuevoProveedor As DataGridView
End Class
