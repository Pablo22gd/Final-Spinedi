<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarProducto))
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtDetalle = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.DGVModificarProducto = New System.Windows.Forms.DataGridView()
        Me.PictureModificarProducto = New System.Windows.Forms.PictureBox()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblDetalle = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblModificarProducto = New System.Windows.Forms.Label()
        CType(Me.DGVModificarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureModificarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBEstado
        '
        Me.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CBEstado.Location = New System.Drawing.Point(136, 235)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(178, 21)
        Me.CBEstado.TabIndex = 40
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(136, 157)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(178, 20)
        Me.TxtMarca.TabIndex = 39
        '
        'TxtDetalle
        '
        Me.TxtDetalle.Location = New System.Drawing.Point(136, 183)
        Me.TxtDetalle.Name = "TxtDetalle"
        Me.TxtDetalle.Size = New System.Drawing.Size(178, 20)
        Me.TxtDetalle.TabIndex = 38
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(136, 209)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(178, 20)
        Me.TxtCantidad.TabIndex = 37
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(136, 301)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(178, 89)
        Me.TxtObservaciones.TabIndex = 36
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(136, 262)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(178, 20)
        Me.TxtProveedor.TabIndex = 35
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(136, 127)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(178, 20)
        Me.TxtNombre.TabIndex = 34
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(737, 421)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 33
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(490, 421)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 32
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'DGVModificarProducto
        '
        Me.DGVModificarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVModificarProducto.Location = New System.Drawing.Point(332, 301)
        Me.DGVModificarProducto.Name = "DGVModificarProducto"
        Me.DGVModificarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVModificarProducto.Size = New System.Drawing.Size(608, 89)
        Me.DGVModificarProducto.TabIndex = 31
        '
        'PictureModificarProducto
        '
        Me.PictureModificarProducto.Image = CType(resources.GetObject("PictureModificarProducto.Image"), System.Drawing.Image)
        Me.PictureModificarProducto.Location = New System.Drawing.Point(519, 71)
        Me.PictureModificarProducto.Name = "PictureModificarProducto"
        Me.PictureModificarProducto.Size = New System.Drawing.Size(203, 180)
        Me.PictureModificarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureModificarProducto.TabIndex = 30
        Me.PictureModificarProducto.TabStop = False
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(52, 301)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 29
        Me.LblObservaciones.Text = "Observaciones"
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Location = New System.Drawing.Point(52, 262)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.LblProveedor.TabIndex = 28
        Me.LblProveedor.Text = "Proveedor"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(52, 238)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 27
        Me.LblEstado.Text = "Estado"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(52, 209)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LblCantidad.TabIndex = 26
        Me.LblCantidad.Text = "Cantidad"
        '
        'LblDetalle
        '
        Me.LblDetalle.AutoSize = True
        Me.LblDetalle.Location = New System.Drawing.Point(52, 186)
        Me.LblDetalle.Name = "LblDetalle"
        Me.LblDetalle.Size = New System.Drawing.Size(40, 13)
        Me.LblDetalle.TabIndex = 25
        Me.LblDetalle.Text = "Detalle"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(52, 160)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(37, 13)
        Me.LblMarca.TabIndex = 24
        Me.LblMarca.Text = "Marca"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(52, 130)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 23
        Me.LblNombre.Text = "Nombre"
        '
        'LblModificarProducto
        '
        Me.LblModificarProducto.AutoSize = True
        Me.LblModificarProducto.Location = New System.Drawing.Point(579, 44)
        Me.LblModificarProducto.Name = "LblModificarProducto"
        Me.LblModificarProducto.Size = New System.Drawing.Size(95, 13)
        Me.LblModificarProducto.TabIndex = 22
        Me.LblModificarProducto.Text = "Modificar producto"
        '
        'FrmModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 489)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.TxtDetalle)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.DGVModificarProducto)
        Me.Controls.Add(Me.PictureModificarProducto)
        Me.Controls.Add(Me.LblObservaciones)
        Me.Controls.Add(Me.LblProveedor)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblDetalle)
        Me.Controls.Add(Me.LblMarca)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblModificarProducto)
        Me.Name = "FrmModificarProducto"
        Me.Text = "Asistente para modificar producto"
        CType(Me.DGVModificarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureModificarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents TxtDetalle As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents DGVModificarProducto As DataGridView
    Friend WithEvents PictureModificarProducto As PictureBox
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents LblProveedor As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblDetalle As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblModificarProducto As Label
End Class
