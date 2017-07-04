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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoProveedor))
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.LblRazonSocial = New System.Windows.Forms.Label()
        Me.LblCuit = New System.Windows.Forms.Label()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.LblNuevoProveedor = New System.Windows.Forms.Label()
        Me.PictureNuevoProveedor = New System.Windows.Forms.PictureBox()
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
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.CbLocalidad = New System.Windows.Forms.ComboBox()
        Me.DGVNuevoProveedor = New System.Windows.Forms.DataGridView()
        CType(Me.PictureNuevoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVNuevoProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCuit
        '
        Me.TxtCuit.Location = New System.Drawing.Point(212, 223)
        Me.TxtCuit.MaxLength = 13
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(200, 20)
        Me.TxtCuit.TabIndex = 5
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(212, 276)
        Me.TxtRazonSocial.MaxLength = 30
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(200, 20)
        Me.TxtRazonSocial.TabIndex = 11
        '
        'LblRazonSocial
        '
        Me.LblRazonSocial.AutoSize = True
        Me.LblRazonSocial.Location = New System.Drawing.Point(77, 279)
        Me.LblRazonSocial.Name = "LblRazonSocial"
        Me.LblRazonSocial.Size = New System.Drawing.Size(68, 13)
        Me.LblRazonSocial.TabIndex = 96
        Me.LblRazonSocial.Text = "Razon social"
        '
        'LblCuit
        '
        Me.LblCuit.AutoSize = True
        Me.LblCuit.Location = New System.Drawing.Point(79, 226)
        Me.LblCuit.Name = "LblCuit"
        Me.LblCuit.Size = New System.Drawing.Size(25, 13)
        Me.LblCuit.TabIndex = 94
        Me.LblCuit.Text = "Cuit"
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.Location = New System.Drawing.Point(77, 305)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(78, 13)
        Me.LblObservaciones.TabIndex = 91
        Me.LblObservaciones.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(212, 302)
        Me.TxtObservaciones.MaxLength = 50
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(200, 86)
        Me.TxtObservaciones.TabIndex = 12
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
        Me.PictureNuevoProveedor.Image = CType(resources.GetObject("PictureNuevoProveedor.Image"), System.Drawing.Image)
        Me.PictureNuevoProveedor.Location = New System.Drawing.Point(616, 91)
        Me.PictureNuevoProveedor.Name = "PictureNuevoProveedor"
        Me.PictureNuevoProveedor.Size = New System.Drawing.Size(236, 179)
        Me.PictureNuevoProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureNuevoProveedor.TabIndex = 87
        Me.PictureNuevoProveedor.TabStop = False
        '
        'CbEstado
        '
        Me.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"activo"})
        Me.CbEstado.Location = New System.Drawing.Point(212, 249)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(200, 21)
        Me.CbEstado.TabIndex = 7
        '
        'CbProvincia
        '
        Me.CbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Items.AddRange(New Object() {"bsas"})
        Me.CbProvincia.Location = New System.Drawing.Point(212, 169)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(200, 21)
        Me.CbProvincia.TabIndex = 3
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(212, 112)
        Me.TxtDomicilio.MaxLength = 30
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TxtDomicilio.TabIndex = 1
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(212, 86)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(200, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(79, 252)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 80
        Me.LblEstado.Text = "Estado"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(79, 143)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 79
        Me.LblLocalidad.Text = "Localidad"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(79, 172)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 78
        Me.LblProvincia.Text = "Provincia"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(79, 200)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 76
        Me.LblTelefono.Text = "Telefono"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(79, 115)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 75
        Me.LblDomicilio.Text = "Domicilio"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(79, 89)
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
        Me.TxtTelefono.Location = New System.Drawing.Point(212, 197)
        Me.TxtTelefono.MaxLength = 20
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefono.TabIndex = 4
        '
        'CbLocalidad
        '
        Me.CbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLocalidad.FormattingEnabled = True
        Me.CbLocalidad.Items.AddRange(New Object() {"bsas"})
        Me.CbLocalidad.Location = New System.Drawing.Point(212, 140)
        Me.CbLocalidad.Name = "CbLocalidad"
        Me.CbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CbLocalidad.TabIndex = 2
        '
        'DGVNuevoProveedor
        '
        Me.DGVNuevoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVNuevoProveedor.Location = New System.Drawing.Point(488, 283)
        Me.DGVNuevoProveedor.Name = "DGVNuevoProveedor"
        Me.DGVNuevoProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtCuit)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.LblRazonSocial)
        Me.Controls.Add(Me.LblCuit)
        Me.Controls.Add(Me.LblObservaciones)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.LblNuevoProveedor)
        Me.Controls.Add(Me.PictureNuevoProveedor)
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
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "FrmNuevoProveedor"
        Me.Text = "Asistente para agregar un nuevo proveedor"
        CType(Me.PictureNuevoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVNuevoProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCuit As TextBox
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents LblRazonSocial As Label
    Friend WithEvents LblCuit As Label
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents LblNuevoProveedor As Label
    Friend WithEvents PictureNuevoProveedor As PictureBox
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
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents CbLocalidad As ComboBox
    Friend WithEvents DGVNuevoProveedor As DataGridView
End Class
