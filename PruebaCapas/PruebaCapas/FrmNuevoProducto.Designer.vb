<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoProducto
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
        Me.LblNuevoProducto = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblDetalle = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.PictureNuevoProducto = New System.Windows.Forms.PictureBox()
        Me.DGVNuevoProducto = New System.Windows.Forms.DataGridView()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtDetalle = New System.Windows.Forms.TextBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        CType(Me.PictureNuevoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVNuevoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNuevoProducto
        '
        Me.LblNuevoProducto.AutoSize = True
        Me.LblNuevoProducto.Location = New System.Drawing.Point(567, 30)
        Me.LblNuevoProducto.Name = "LblNuevoProducto"
        Me.LblNuevoProducto.Size = New System.Drawing.Size(84, 13)
        Me.LblNuevoProducto.TabIndex = 0
        Me.LblNuevoProducto.Text = "Nuevo producto"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(34, 116)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(34, 146)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(37, 13)
        Me.LblMarca.TabIndex = 2
        Me.LblMarca.Text = "Marca"
        '
        'LblDetalle
        '
        Me.LblDetalle.AutoSize = True
        Me.LblDetalle.Location = New System.Drawing.Point(34, 172)
        Me.LblDetalle.Name = "LblDetalle"
        Me.LblDetalle.Size = New System.Drawing.Size(40, 13)
        Me.LblDetalle.TabIndex = 3
        Me.LblDetalle.Text = "Detalle"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(34, 195)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LblCantidad.TabIndex = 4
        Me.LblCantidad.Text = "Cantidad"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(34, 224)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 5
        Me.LblEstado.Text = "Estado"
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Location = New System.Drawing.Point(34, 248)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.LblProveedor.TabIndex = 7
        Me.LblProveedor.Text = "Proveedor"
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(34, 287)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 8
        Me.LblObservaciones.Text = "Observaciones"
        '
        'PictureNuevoProducto
        '
        Me.PictureNuevoProducto.Location = New System.Drawing.Point(525, 57)
        Me.PictureNuevoProducto.Name = "PictureNuevoProducto"
        Me.PictureNuevoProducto.Size = New System.Drawing.Size(163, 144)
        Me.PictureNuevoProducto.TabIndex = 10
        Me.PictureNuevoProducto.TabStop = False
        '
        'DGVNuevoProducto
        '
        Me.DGVNuevoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNuevoProducto.Location = New System.Drawing.Point(314, 287)
        Me.DGVNuevoProducto.Name = "DGVNuevoProducto"
        Me.DGVNuevoProducto.Size = New System.Drawing.Size(608, 89)
        Me.DGVNuevoProducto.TabIndex = 11
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(472, 407)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 8
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(719, 407)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(118, 113)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(178, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(118, 248)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(178, 20)
        Me.TxtProveedor.TabIndex = 5
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(118, 287)
        Me.TxtObservaciones.MaxLength = 100
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(178, 89)
        Me.TxtObservaciones.TabIndex = 6
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(118, 195)
        Me.TxtCantidad.MaxLength = 6
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(178, 20)
        Me.TxtCantidad.TabIndex = 3
        '
        'TxtDetalle
        '
        Me.TxtDetalle.Location = New System.Drawing.Point(118, 169)
        Me.TxtDetalle.MaxLength = 30
        Me.TxtDetalle.Name = "TxtDetalle"
        Me.TxtDetalle.Size = New System.Drawing.Size(178, 20)
        Me.TxtDetalle.TabIndex = 2
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(118, 143)
        Me.TxtMarca.MaxLength = 30
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(178, 20)
        Me.TxtMarca.TabIndex = 1
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CBEstado.Location = New System.Drawing.Point(118, 221)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(178, 21)
        Me.CBEstado.TabIndex = 4
        '
        'FrmNuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 486)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.TxtDetalle)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.DGVNuevoProducto)
        Me.Controls.Add(Me.PictureNuevoProducto)
        Me.Controls.Add(Me.LblObservaciones)
        Me.Controls.Add(Me.LblProveedor)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblCantidad)
        Me.Controls.Add(Me.LblDetalle)
        Me.Controls.Add(Me.LblMarca)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblNuevoProducto)
        Me.Name = "FrmNuevoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente para ingresar un nuevo producto"
        CType(Me.PictureNuevoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVNuevoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNuevoProducto As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblDetalle As Label
    Friend WithEvents LblCantidad As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblProveedor As Label
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents PictureNuevoProducto As PictureBox
    Friend WithEvents DGVNuevoProducto As DataGridView
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents TxtDetalle As TextBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents CBEstado As ComboBox
End Class
