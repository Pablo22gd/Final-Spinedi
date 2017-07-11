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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarProveedor))
        Me.PictureModificarCliente = New System.Windows.Forms.PictureBox()
        Me.DGVGrillaModificarProveedor = New System.Windows.Forms.DataGridView()
        Me.LblModificarProveedor = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.CbLocalidad = New System.Windows.Forms.ComboBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.LblRazonSocial = New System.Windows.Forms.Label()
        Me.LblCuit = New System.Windows.Forms.Label()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.CbProvincia = New System.Windows.Forms.ComboBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        CType(Me.PictureModificarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGrillaModificarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureModificarCliente
        '
        Me.PictureModificarCliente.Image = CType(resources.GetObject("PictureModificarCliente.Image"), System.Drawing.Image)
        Me.PictureModificarCliente.Location = New System.Drawing.Point(565, 76)
        Me.PictureModificarCliente.Name = "PictureModificarCliente"
        Me.PictureModificarCliente.Size = New System.Drawing.Size(263, 190)
        Me.PictureModificarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureModificarCliente.TabIndex = 80
        Me.PictureModificarCliente.TabStop = False
        '
        'DGVGrillaModificarProveedor
        '
        Me.DGVGrillaModificarProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGrillaModificarProveedor.Location = New System.Drawing.Point(400, 279)
        Me.DGVGrillaModificarProveedor.Name = "DGVGrillaModificarProveedor"
        Me.DGVGrillaModificarProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGrillaModificarProveedor.Size = New System.Drawing.Size(580, 108)
        Me.DGVGrillaModificarProveedor.TabIndex = 79
        '
        'LblModificarProveedor
        '
        Me.LblModificarProveedor.AutoSize = True
        Me.LblModificarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModificarProveedor.Location = New System.Drawing.Point(619, 36)
        Me.LblModificarProveedor.Name = "LblModificarProveedor"
        Me.LblModificarProveedor.Size = New System.Drawing.Size(161, 18)
        Me.LblModificarProveedor.TabIndex = 78
        Me.LblModificarProveedor.Text = "Modificar Proveedor"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(835, 410)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 57
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(521, 410)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 56
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'CbLocalidad
        '
        Me.CbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLocalidad.FormattingEnabled = True
        Me.CbLocalidad.Items.AddRange(New Object() {"bsas"})
        Me.CbLocalidad.Location = New System.Drawing.Point(164, 159)
        Me.CbLocalidad.Name = "CbLocalidad"
        Me.CbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CbLocalidad.TabIndex = 99
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(164, 187)
        Me.TxtTelefono.MaxLength = 20
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefono.TabIndex = 101
        '
        'TxtCuit
        '
        Me.TxtCuit.Location = New System.Drawing.Point(164, 213)
        Me.TxtCuit.MaxLength = 13
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(200, 20)
        Me.TxtCuit.TabIndex = 102
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(164, 266)
        Me.TxtRazonSocial.MaxLength = 30
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(200, 20)
        Me.TxtRazonSocial.TabIndex = 104
        '
        'LblRazonSocial
        '
        Me.LblRazonSocial.AutoSize = True
        Me.LblRazonSocial.Location = New System.Drawing.Point(29, 269)
        Me.LblRazonSocial.Name = "LblRazonSocial"
        Me.LblRazonSocial.Size = New System.Drawing.Size(68, 13)
        Me.LblRazonSocial.TabIndex = 114
        Me.LblRazonSocial.Text = "Razon social"
        '
        'LblCuit
        '
        Me.LblCuit.AutoSize = True
        Me.LblCuit.Location = New System.Drawing.Point(31, 216)
        Me.LblCuit.Name = "LblCuit"
        Me.LblCuit.Size = New System.Drawing.Size(25, 13)
        Me.LblCuit.TabIndex = 113
        Me.LblCuit.Text = "Cuit"
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(29, 295)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 112
        Me.LblObservaciones.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(164, 292)
        Me.TxtObservaciones.MaxLength = 50
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(200, 86)
        Me.TxtObservaciones.TabIndex = 105
        '
        'CbEstado
        '
        Me.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CbEstado.Location = New System.Drawing.Point(164, 239)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(200, 21)
        Me.CbEstado.TabIndex = 103
        '
        'CbProvincia
        '
        Me.CbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Items.AddRange(New Object() {"bsas"})
        Me.CbProvincia.Location = New System.Drawing.Point(164, 130)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(200, 21)
        Me.CbProvincia.TabIndex = 100
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(164, 102)
        Me.TxtDomicilio.MaxLength = 30
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TxtDomicilio.TabIndex = 98
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(164, 76)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(200, 20)
        Me.TxtNombre.TabIndex = 97
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(31, 242)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 111
        Me.LblEstado.Text = "Estado"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(29, 162)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 110
        Me.LblLocalidad.Text = "Localidad"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(29, 138)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 109
        Me.LblProvincia.Text = "Provincia"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(31, 190)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 108
        Me.LblTelefono.Text = "Telefono"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(31, 105)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 107
        Me.LblDomicilio.Text = "Domicilio"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(31, 79)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 106
        Me.LblNombre.Text = "Nombre"
        '
        'FrmModificarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 523)
        Me.Controls.Add(Me.CbLocalidad)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCuit)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.LblRazonSocial)
        Me.Controls.Add(Me.LblCuit)
        Me.Controls.Add(Me.LblObservaciones)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.CbProvincia)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblDomicilio)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.PictureModificarCliente)
        Me.Controls.Add(Me.DGVGrillaModificarProveedor)
        Me.Controls.Add(Me.LblModificarProveedor)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnModificar)
        Me.Name = "FrmModificarProveedor"
        Me.Text = "Asistente para modificar proveedor"
        CType(Me.PictureModificarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGrillaModificarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureModificarCliente As PictureBox
    Friend WithEvents DGVGrillaModificarProveedor As DataGridView
    Friend WithEvents LblModificarProveedor As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents CbLocalidad As ComboBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCuit As TextBox
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents LblRazonSocial As Label
    Friend WithEvents LblCuit As Label
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents CbProvincia As ComboBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblLocalidad As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents LblNombre As Label
End Class
