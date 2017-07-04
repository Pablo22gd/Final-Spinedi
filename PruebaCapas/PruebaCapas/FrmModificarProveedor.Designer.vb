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
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.CbLocalidad = New System.Windows.Forms.ComboBox()
        Me.CbProvincia = New System.Windows.Forms.ComboBox()
        Me.CbSexo = New System.Windows.Forms.ComboBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
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
        'CbEstado
        '
        Me.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Location = New System.Drawing.Point(162, 329)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(200, 21)
        Me.CbEstado.TabIndex = 77
        '
        'CbLocalidad
        '
        Me.CbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLocalidad.FormattingEnabled = True
        Me.CbLocalidad.Location = New System.Drawing.Point(162, 297)
        Me.CbLocalidad.Name = "CbLocalidad"
        Me.CbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CbLocalidad.TabIndex = 76
        '
        'CbProvincia
        '
        Me.CbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Location = New System.Drawing.Point(162, 270)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(200, 21)
        Me.CbProvincia.TabIndex = 75
        '
        'CbSexo
        '
        Me.CbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSexo.FormattingEnabled = True
        Me.CbSexo.Location = New System.Drawing.Point(162, 185)
        Me.CbSexo.Name = "CbSexo"
        Me.CbSexo.Size = New System.Drawing.Size(200, 21)
        Me.CbSexo.TabIndex = 74
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(162, 212)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(200, 20)
        Me.TxtEmail.TabIndex = 73
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(162, 159)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefono.TabIndex = 72
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(162, 135)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(200, 20)
        Me.TxtDNI.TabIndex = 71
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(162, 244)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TxtDomicilio.TabIndex = 70
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(162, 80)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(200, 20)
        Me.TxtApellido.TabIndex = 69
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(162, 109)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(200, 20)
        Me.TxtNombre.TabIndex = 68
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(52, 332)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 67
        Me.LblEstado.Text = "Estado"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(52, 300)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 66
        Me.LblLocalidad.Text = "Localidad"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(52, 273)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 65
        Me.LblProvincia.Text = "Provincia"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(51, 216)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 64
        Me.LblEmail.Text = "Email"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(50, 161)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 63
        Me.LblTelefono.Text = "Telefono"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(51, 188)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 62
        Me.LblSexo.Text = "Sexo"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(51, 138)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(26, 13)
        Me.LblDNI.TabIndex = 61
        Me.LblDNI.Text = "DNI"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(51, 247)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 60
        Me.LblDomicilio.Text = "Domicilio"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(51, 86)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 59
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(51, 116)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 58
        Me.LblNombre.Text = "Nombre"
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
        'FrmModificarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 523)
        Me.Controls.Add(Me.PictureModificarCliente)
        Me.Controls.Add(Me.DGVGrillaModificarProveedor)
        Me.Controls.Add(Me.LblModificarProveedor)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.CbLocalidad)
        Me.Controls.Add(Me.CbProvincia)
        Me.Controls.Add(Me.CbSexo)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.LblDomicilio)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
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
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents CbLocalidad As ComboBox
    Friend WithEvents CbProvincia As ComboBox
    Friend WithEvents CbSexo As ComboBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents LblLocalidad As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnModificar As Button
End Class
