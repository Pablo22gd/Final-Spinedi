<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacturacion
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
        Me.DgvGrillaFacturacion = New System.Windows.Forms.DataGridView()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        Me.DGVSeleccionarProducto = New System.Windows.Forms.DataGridView()
        Me.GBProducto = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.LblBuscarProducto = New System.Windows.Forms.Label()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.LblNombreProducto = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.GBFacturacion = New System.Windows.Forms.GroupBox()
        Me.CBTipoDeFactura = New System.Windows.Forms.ComboBox()
        Me.LblMostrarTotal = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblRazonSocial = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LblTipoDeFactura = New System.Windows.Forms.Label()
        Me.btnBuscarClientes = New System.Windows.Forms.Button()
        Me.TxtBuscarClientes = New System.Windows.Forms.TextBox()
        Me.DGVGrillaCliente = New System.Windows.Forms.DataGridView()
        Me.LblBuscar = New System.Windows.Forms.Label()
        CType(Me.DgvGrillaFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSeleccionarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBProducto.SuspendLayout()
        Me.GBFacturacion.SuspendLayout()
        CType(Me.DGVGrillaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvGrillaFacturacion
        '
        Me.DgvGrillaFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGrillaFacturacion.Location = New System.Drawing.Point(21, 36)
        Me.DgvGrillaFacturacion.Name = "DgvGrillaFacturacion"
        Me.DgvGrillaFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvGrillaFacturacion.Size = New System.Drawing.Size(509, 353)
        Me.DgvGrillaFacturacion.TabIndex = 9
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(774, 528)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Location = New System.Drawing.Point(878, 528)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(75, 23)
        Me.BtnFacturar.TabIndex = 29
        Me.BtnFacturar.Text = "Facturar"
        Me.BtnFacturar.UseVisualStyleBackColor = True
        '
        'DGVSeleccionarProducto
        '
        Me.DGVSeleccionarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSeleccionarProducto.Location = New System.Drawing.Point(11, 270)
        Me.DGVSeleccionarProducto.Name = "DGVSeleccionarProducto"
        Me.DGVSeleccionarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSeleccionarProducto.Size = New System.Drawing.Size(357, 119)
        Me.DGVSeleccionarProducto.TabIndex = 30
        '
        'GBProducto
        '
        Me.GBProducto.Controls.Add(Me.btnBuscarClientes)
        Me.GBProducto.Controls.Add(Me.TxtBuscarClientes)
        Me.GBProducto.Controls.Add(Me.DGVGrillaCliente)
        Me.GBProducto.Controls.Add(Me.LblBuscar)
        Me.GBProducto.Controls.Add(Me.BtnBuscar)
        Me.GBProducto.Controls.Add(Me.Label3)
        Me.GBProducto.Controls.Add(Me.txtNombreCliente)
        Me.GBProducto.Controls.Add(Me.LblBuscarProducto)
        Me.GBProducto.Controls.Add(Me.DGVSeleccionarProducto)
        Me.GBProducto.Controls.Add(Me.TxtNombreProducto)
        Me.GBProducto.Controls.Add(Me.BtnAceptar)
        Me.GBProducto.Controls.Add(Me.TxtBuscarProducto)
        Me.GBProducto.Controls.Add(Me.LblNombreProducto)
        Me.GBProducto.Controls.Add(Me.TxtCantidad)
        Me.GBProducto.Controls.Add(Me.LblCantidad)
        Me.GBProducto.Location = New System.Drawing.Point(12, 29)
        Me.GBProducto.Name = "GBProducto"
        Me.GBProducto.Size = New System.Drawing.Size(380, 504)
        Me.GBProducto.TabIndex = 31
        Me.GBProducto.TabStop = False
        Me.GBProducto.Text = "Seleccinar el producto que desea adquirir"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(233, 241)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 38
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Nombre cliente"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(98, 190)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCliente.TabIndex = 32
        '
        'LblBuscarProducto
        '
        Me.LblBuscarProducto.AutoSize = True
        Me.LblBuscarProducto.Location = New System.Drawing.Point(17, 243)
        Me.LblBuscarProducto.Name = "LblBuscarProducto"
        Me.LblBuscarProducto.Size = New System.Drawing.Size(85, 13)
        Me.LblBuscarProducto.TabIndex = 37
        Me.LblBuscarProducto.Text = "Buscar producto"
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(109, 406)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.ReadOnly = True
        Me.TxtNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombreProducto.TabIndex = 32
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(290, 475)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 31
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtBuscarProducto
        '
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(118, 243)
        Me.TxtBuscarProducto.Name = "TxtBuscarProducto"
        Me.TxtBuscarProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtBuscarProducto.TabIndex = 36
        '
        'LblNombreProducto
        '
        Me.LblNombreProducto.AutoSize = True
        Me.LblNombreProducto.Location = New System.Drawing.Point(12, 406)
        Me.LblNombreProducto.Name = "LblNombreProducto"
        Me.LblNombreProducto.Size = New System.Drawing.Size(89, 13)
        Me.LblNombreProducto.TabIndex = 34
        Me.LblNombreProducto.Text = "Nombre producto"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(109, 432)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 33
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(11, 432)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LblCantidad.TabIndex = 35
        Me.LblCantidad.Text = "Cantidad"
        '
        'GBFacturacion
        '
        Me.GBFacturacion.Controls.Add(Me.CBTipoDeFactura)
        Me.GBFacturacion.Controls.Add(Me.LblMostrarTotal)
        Me.GBFacturacion.Controls.Add(Me.LblTotal)
        Me.GBFacturacion.Controls.Add(Me.LblRazonSocial)
        Me.GBFacturacion.Controls.Add(Me.TextBox5)
        Me.GBFacturacion.Controls.Add(Me.LblTipoDeFactura)
        Me.GBFacturacion.Controls.Add(Me.DgvGrillaFacturacion)
        Me.GBFacturacion.Location = New System.Drawing.Point(398, 29)
        Me.GBFacturacion.Name = "GBFacturacion"
        Me.GBFacturacion.Size = New System.Drawing.Size(548, 493)
        Me.GBFacturacion.TabIndex = 32
        Me.GBFacturacion.TabStop = False
        Me.GBFacturacion.Text = "Facturacion"
        '
        'CBTipoDeFactura
        '
        Me.CBTipoDeFactura.FormattingEnabled = True
        Me.CBTipoDeFactura.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C"})
        Me.CBTipoDeFactura.Location = New System.Drawing.Point(126, 445)
        Me.CBTipoDeFactura.Name = "CBTipoDeFactura"
        Me.CBTipoDeFactura.Size = New System.Drawing.Size(121, 21)
        Me.CBTipoDeFactura.TabIndex = 41
        '
        'LblMostrarTotal
        '
        Me.LblMostrarTotal.AutoSize = True
        Me.LblMostrarTotal.Location = New System.Drawing.Point(386, 409)
        Me.LblMostrarTotal.Name = "LblMostrarTotal"
        Me.LblMostrarTotal.Size = New System.Drawing.Size(16, 13)
        Me.LblMostrarTotal.TabIndex = 40
        Me.LblMostrarTotal.Text = "..."
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(343, 406)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(37, 13)
        Me.LblTotal.TabIndex = 39
        Me.LblTotal.Text = "Total: "
        '
        'LblRazonSocial
        '
        Me.LblRazonSocial.AutoSize = True
        Me.LblRazonSocial.Location = New System.Drawing.Point(312, 448)
        Me.LblRazonSocial.Name = "LblRazonSocial"
        Me.LblRazonSocial.Size = New System.Drawing.Size(68, 13)
        Me.LblRazonSocial.TabIndex = 38
        Me.LblRazonSocial.Text = "Razon social"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(409, 448)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(121, 20)
        Me.TextBox5.TabIndex = 37
        '
        'LblTipoDeFactura
        '
        Me.LblTipoDeFactura.AutoSize = True
        Me.LblTipoDeFactura.Location = New System.Drawing.Point(29, 448)
        Me.LblTipoDeFactura.Name = "LblTipoDeFactura"
        Me.LblTipoDeFactura.Size = New System.Drawing.Size(79, 13)
        Me.LblTipoDeFactura.TabIndex = 36
        Me.LblTipoDeFactura.Text = "Tipo de factura"
        '
        'btnBuscarClientes
        '
        Me.btnBuscarClientes.Location = New System.Drawing.Point(270, 31)
        Me.btnBuscarClientes.Name = "btnBuscarClientes"
        Me.btnBuscarClientes.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarClientes.TabIndex = 42
        Me.btnBuscarClientes.Text = "Buscar"
        Me.btnBuscarClientes.UseVisualStyleBackColor = True
        '
        'TxtBuscarClientes
        '
        Me.TxtBuscarClientes.Location = New System.Drawing.Point(129, 33)
        Me.TxtBuscarClientes.Name = "TxtBuscarClientes"
        Me.TxtBuscarClientes.Size = New System.Drawing.Size(122, 20)
        Me.TxtBuscarClientes.TabIndex = 41
        '
        'DGVGrillaCliente
        '
        Me.DGVGrillaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGrillaCliente.Location = New System.Drawing.Point(11, 65)
        Me.DGVGrillaCliente.Name = "DGVGrillaCliente"
        Me.DGVGrillaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGrillaCliente.Size = New System.Drawing.Size(363, 94)
        Me.DGVGrillaCliente.TabIndex = 40
        '
        'LblBuscar
        '
        Me.LblBuscar.AutoSize = True
        Me.LblBuscar.Location = New System.Drawing.Point(8, 36)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(124, 13)
        Me.LblBuscar.TabIndex = 39
        Me.LblBuscar.Text = "Ingrese nombre a buscar"
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 563)
        Me.Controls.Add(Me.GBFacturacion)
        Me.Controls.Add(Me.GBProducto)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "FrmFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        CType(Me.DgvGrillaFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSeleccionarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBProducto.ResumeLayout(False)
        Me.GBProducto.PerformLayout()
        Me.GBFacturacion.ResumeLayout(False)
        Me.GBFacturacion.PerformLayout()
        CType(Me.DGVGrillaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvGrillaFacturacion As DataGridView
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnFacturar As Button
    Friend WithEvents DGVSeleccionarProducto As DataGridView
    Friend WithEvents GBProducto As GroupBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblBuscarProducto As Label
    Friend WithEvents TxtBuscarProducto As TextBox
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblNombreProducto As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtNombreProducto As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents GBFacturacion As GroupBox
    Friend WithEvents LblMostrarTotal As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblRazonSocial As Label
    Friend WithEvents TextBox5 As TextBox
    Protected WithEvents LblTipoDeFactura As Label
    Friend WithEvents CBTipoDeFactura As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents btnBuscarClientes As Button
    Friend WithEvents TxtBuscarClientes As TextBox
    Friend WithEvents DGVGrillaCliente As DataGridView
    Friend WithEvents LblBuscar As Label
End Class
