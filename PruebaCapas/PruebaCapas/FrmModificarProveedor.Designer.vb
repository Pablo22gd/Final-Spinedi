<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarProveedor
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
        Me.T = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.CbLocalidad = New System.Windows.Forms.ComboBox()
        Me.DGVgrillaModificarProveedor = New System.Windows.Forms.DataGridView()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.NUDProducto = New System.Windows.Forms.NumericUpDown()
        Me.LblNuevoProveedor = New System.Windows.Forms.Label()
        Me.PictureModificarProveedor = New System.Windows.Forms.PictureBox()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.CbProvincia = New System.Windows.Forms.ComboBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        CType(Me.DGVgrillaModificarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureModificarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T
        '
        Me.T.Location = New System.Drawing.Point(187, 65)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(200, 20)
        Me.T.TabIndex = 133
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(84, 67)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 132
        Me.LblApellido.Text = "Apellido"
        '
        'CbLocalidad
        '
        Me.CbLocalidad.FormattingEnabled = True
        Me.CbLocalidad.Location = New System.Drawing.Point(187, 145)
        Me.CbLocalidad.Name = "CbLocalidad"
        Me.CbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CbLocalidad.TabIndex = 131
        '
        'DGVgrillaModificarProveedor
        '
        Me.DGVgrillaModificarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVgrillaModificarProveedor.Location = New System.Drawing.Point(425, 278)
        Me.DGVgrillaModificarProveedor.Name = "DGVgrillaModificarProveedor"
        Me.DGVgrillaModificarProveedor.Size = New System.Drawing.Size(513, 138)
        Me.DGVgrillaModificarProveedor.TabIndex = 130
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(83, 289)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 129
        Me.LblObservaciones.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(187, 294)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(200, 74)
        Me.TxtObservaciones.TabIndex = 128
        '
        'NUDProducto
        '
        Me.NUDProducto.Location = New System.Drawing.Point(187, 229)
        Me.NUDProducto.Name = "NUDProducto"
        Me.NUDProducto.Size = New System.Drawing.Size(200, 20)
        Me.NUDProducto.TabIndex = 127
        '
        'LblNuevoProveedor
        '
        Me.LblNuevoProveedor.AutoSize = True
        Me.LblNuevoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNuevoProveedor.Location = New System.Drawing.Point(600, 57)
        Me.LblNuevoProveedor.Name = "LblNuevoProveedor"
        Me.LblNuevoProveedor.Size = New System.Drawing.Size(161, 18)
        Me.LblNuevoProveedor.TabIndex = 126
        Me.LblNuevoProveedor.Text = "Modificar Proveedor"
        '
        'PictureModificarProveedor
        '
        Me.PictureModificarProveedor.Location = New System.Drawing.Point(561, 89)
        Me.PictureModificarProveedor.Name = "PictureModificarProveedor"
        Me.PictureModificarProveedor.Size = New System.Drawing.Size(233, 176)
        Me.PictureModificarProveedor.TabIndex = 125
        Me.PictureModificarProveedor.TabStop = False
        '
        'CbEstado
        '
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Location = New System.Drawing.Point(187, 260)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(200, 21)
        Me.CbEstado.TabIndex = 124
        '
        'CbProvincia
        '
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Location = New System.Drawing.Point(187, 176)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(200, 21)
        Me.CbProvincia.TabIndex = 123
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(187, 203)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TxtDomicilio.TabIndex = 122
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(187, 119)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(200, 20)
        Me.TxtApellido.TabIndex = 121
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(187, 93)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(200, 20)
        Me.TxtNombre.TabIndex = 120
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(83, 255)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 119
        Me.LblEstado.Text = "Estado"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(84, 145)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 118
        Me.LblLocalidad.Text = "Localidad"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(84, 171)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 117
        Me.LblProvincia.Text = "Provincia"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(84, 226)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(50, 13)
        Me.LblProducto.TabIndex = 116
        Me.LblProducto.Text = "Producto"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(83, 199)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 115
        Me.LblTelefono.Text = "Telefono"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(83, 118)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 114
        Me.LblDomicilio.Text = "Domicilio"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(84, 92)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 113
        Me.LblNombre.Text = "Nombre"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(561, 422)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 112
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(719, 422)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 111
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'FrmModificarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 503)
        Me.Controls.Add(Me.T)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.CbLocalidad)
        Me.Controls.Add(Me.DGVgrillaModificarProveedor)
        Me.Controls.Add(Me.LblObservaciones)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.NUDProducto)
        Me.Controls.Add(Me.LblNuevoProveedor)
        Me.Controls.Add(Me.PictureModificarProveedor)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.CbProvincia)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblProducto)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblDomicilio)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnModificar)
        Me.Name = "FrmModificarProveedor"
        Me.Text = "FrmModificarProveedor"
        CType(Me.DGVgrillaModificarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureModificarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents T As TextBox
    Friend WithEvents LblApellido As Label
    Friend WithEvents CbLocalidad As ComboBox
    Friend WithEvents DGVgrillaModificarProveedor As DataGridView
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents NUDProducto As NumericUpDown
    Friend WithEvents LblNuevoProveedor As Label
    Friend WithEvents PictureModificarProveedor As PictureBox
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents CbProvincia As ComboBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblLocalidad As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents LblProducto As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnModificar As Button
End Class
