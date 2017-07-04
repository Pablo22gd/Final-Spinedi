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
        Me.LblBuscarProducto = New System.Windows.Forms.Label()
        Me.TxtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblNombreProducto = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.GBFacturacion = New System.Windows.Forms.GroupBox()
        Me.CBTipoDeFactura = New System.Windows.Forms.ComboBox()
        Me.LblMostrarTotal = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblRazonSocial = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LblTipoDeFactura = New System.Windows.Forms.Label()
        CType(Me.DgvGrillaFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSeleccionarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBProducto.SuspendLayout()
        Me.GBFacturacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvGrillaFacturacion
        '
        Me.DgvGrillaFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGrillaFacturacion.Location = New System.Drawing.Point(21, 36)
        Me.DgvGrillaFacturacion.Name = "DgvGrillaFacturacion"
        Me.DgvGrillaFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvGrillaFacturacion.Size = New System.Drawing.Size(458, 133)
        Me.DgvGrillaFacturacion.TabIndex = 9
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(769, 363)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnFacturar
        '
        Me.BtnFacturar.Location = New System.Drawing.Point(873, 363)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(75, 23)
        Me.BtnFacturar.TabIndex = 29
        Me.BtnFacturar.Text = "Facturar"
        Me.BtnFacturar.UseVisualStyleBackColor = True
        '
        'DGVSeleccionarProducto
        '
        Me.DGVSeleccionarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSeleccionarProducto.Location = New System.Drawing.Point(15, 50)
        Me.DGVSeleccionarProducto.Name = "DGVSeleccionarProducto"
        Me.DGVSeleccionarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSeleccionarProducto.Size = New System.Drawing.Size(277, 119)
        Me.DGVSeleccionarProducto.TabIndex = 30
        '
        'GBProducto
        '
        Me.GBProducto.Controls.Add(Me.BtnBuscar)
        Me.GBProducto.Controls.Add(Me.LblBuscarProducto)
        Me.GBProducto.Controls.Add(Me.TxtBuscarProducto)
        Me.GBProducto.Controls.Add(Me.LblCantidad)
        Me.GBProducto.Controls.Add(Me.LblNombreProducto)
        Me.GBProducto.Controls.Add(Me.TxtCantidad)
        Me.GBProducto.Controls.Add(Me.TxtNombreProducto)
        Me.GBProducto.Controls.Add(Me.BtnAceptar)
        Me.GBProducto.Controls.Add(Me.DGVSeleccionarProducto)
        Me.GBProducto.Location = New System.Drawing.Point(34, 29)
        Me.GBProducto.Name = "GBProducto"
        Me.GBProducto.Size = New System.Drawing.Size(321, 312)
        Me.GBProducto.TabIndex = 31
        Me.GBProducto.TabStop = False
        Me.GBProducto.Text = "Seleccinar el producto que desea adquirir"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(228, 21)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 38
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LblBuscarProducto
        '
        Me.LblBuscarProducto.AutoSize = True
        Me.LblBuscarProducto.Location = New System.Drawing.Point(12, 23)
        Me.LblBuscarProducto.Name = "LblBuscarProducto"
        Me.LblBuscarProducto.Size = New System.Drawing.Size(85, 13)
        Me.LblBuscarProducto.TabIndex = 37
        Me.LblBuscarProducto.Text = "Buscar producto"
        '
        'TxtBuscarProducto
        '
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(113, 23)
        Me.TxtBuscarProducto.Name = "TxtBuscarProducto"
        Me.TxtBuscarProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtBuscarProducto.TabIndex = 36
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(6, 212)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LblCantidad.TabIndex = 35
        Me.LblCantidad.Text = "Cantidad"
        '
        'LblNombreProducto
        '
        Me.LblNombreProducto.AutoSize = True
        Me.LblNombreProducto.Location = New System.Drawing.Point(7, 186)
        Me.LblNombreProducto.Name = "LblNombreProducto"
        Me.LblNombreProducto.Size = New System.Drawing.Size(89, 13)
        Me.LblNombreProducto.TabIndex = 34
        Me.LblNombreProducto.Text = "Nombre producto"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(104, 212)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 33
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(104, 186)
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombreProducto.TabIndex = 32
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(217, 249)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 31
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
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
        Me.GBFacturacion.Size = New System.Drawing.Size(548, 312)
        Me.GBFacturacion.TabIndex = 32
        Me.GBFacturacion.TabStop = False
        Me.GBFacturacion.Text = "Facturacion"
        '
        'CBTipoDeFactura
        '
        Me.CBTipoDeFactura.FormattingEnabled = True
        Me.CBTipoDeFactura.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C"})
        Me.CBTipoDeFactura.Location = New System.Drawing.Point(146, 235)
        Me.CBTipoDeFactura.Name = "CBTipoDeFactura"
        Me.CBTipoDeFactura.Size = New System.Drawing.Size(121, 21)
        Me.CBTipoDeFactura.TabIndex = 41
        '
        'LblMostrarTotal
        '
        Me.LblMostrarTotal.AutoSize = True
        Me.LblMostrarTotal.Location = New System.Drawing.Point(388, 182)
        Me.LblMostrarTotal.Name = "LblMostrarTotal"
        Me.LblMostrarTotal.Size = New System.Drawing.Size(16, 13)
        Me.LblMostrarTotal.TabIndex = 40
        Me.LblMostrarTotal.Text = "..."
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(349, 182)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(37, 13)
        Me.LblTotal.TabIndex = 39
        Me.LblTotal.Text = "Total: "
        '
        'LblRazonSocial
        '
        Me.LblRazonSocial.AutoSize = True
        Me.LblRazonSocial.Location = New System.Drawing.Point(49, 273)
        Me.LblRazonSocial.Name = "LblRazonSocial"
        Me.LblRazonSocial.Size = New System.Drawing.Size(68, 13)
        Me.LblRazonSocial.TabIndex = 38
        Me.LblRazonSocial.Text = "Razon social"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(146, 273)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(121, 20)
        Me.TextBox5.TabIndex = 37
        '
        'LblTipoDeFactura
        '
        Me.LblTipoDeFactura.AutoSize = True
        Me.LblTipoDeFactura.Location = New System.Drawing.Point(49, 238)
        Me.LblTipoDeFactura.Name = "LblTipoDeFactura"
        Me.LblTipoDeFactura.Size = New System.Drawing.Size(79, 13)
        Me.LblTipoDeFactura.TabIndex = 36
        Me.LblTipoDeFactura.Text = "Tipo de factura"
        '
        'FrmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 413)
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
End Class
