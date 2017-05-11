<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarCliente
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
        Me.DGVGrillaModificarCliente = New System.Windows.Forms.DataGridView()
        Me.LblModificarCliente = New System.Windows.Forms.Label()
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
        Me.PictureModificarCliente = New System.Windows.Forms.PictureBox()
        CType(Me.DGVGrillaModificarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureModificarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVGrillaModificarCliente
        '
        Me.DGVGrillaModificarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGrillaModificarCliente.Location = New System.Drawing.Point(388, 277)
        Me.DGVGrillaModificarCliente.Name = "DGVGrillaModificarCliente"
        Me.DGVGrillaModificarCliente.Size = New System.Drawing.Size(580, 108)
        Me.DGVGrillaModificarCliente.TabIndex = 54
        '
        'LblModificarCliente
        '
        Me.LblModificarCliente.AutoSize = True
        Me.LblModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModificarCliente.Location = New System.Drawing.Point(614, 87)
        Me.LblModificarCliente.Name = "LblModificarCliente"
        Me.LblModificarCliente.Size = New System.Drawing.Size(135, 18)
        Me.LblModificarCliente.TabIndex = 53
        Me.LblModificarCliente.Text = "Modificar Cliente"
        '
        'CbEstado
        '
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Location = New System.Drawing.Point(150, 364)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(200, 21)
        Me.CbEstado.TabIndex = 52
        '
        'CbLocalidad
        '
        Me.CbLocalidad.FormattingEnabled = True
        Me.CbLocalidad.Location = New System.Drawing.Point(150, 332)
        Me.CbLocalidad.Name = "CbLocalidad"
        Me.CbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CbLocalidad.TabIndex = 51
        '
        'CbProvincia
        '
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Location = New System.Drawing.Point(150, 305)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(200, 21)
        Me.CbProvincia.TabIndex = 50
        '
        'CbSexo
        '
        Me.CbSexo.FormattingEnabled = True
        Me.CbSexo.Location = New System.Drawing.Point(150, 220)
        Me.CbSexo.Name = "CbSexo"
        Me.CbSexo.Size = New System.Drawing.Size(200, 21)
        Me.CbSexo.TabIndex = 49
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(150, 247)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(200, 20)
        Me.TxtEmail.TabIndex = 48
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(150, 194)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(200, 20)
        Me.TxtTelefono.TabIndex = 47
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(150, 170)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(200, 20)
        Me.TxtDNI.TabIndex = 46
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(150, 279)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(200, 20)
        Me.TxtDomicilio.TabIndex = 45
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(150, 140)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(200, 20)
        Me.TxtApellido.TabIndex = 44
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(150, 114)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(200, 20)
        Me.TxtNombre.TabIndex = 43
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(40, 367)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 42
        Me.LblEstado.Text = "Estado"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(40, 335)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 41
        Me.LblLocalidad.Text = "Localidad"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(40, 308)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 40
        Me.LblProvincia.Text = "Provincia"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(39, 251)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 39
        Me.LblEmail.Text = "Email"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(38, 196)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 38
        Me.LblTelefono.Text = "Telefono"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(39, 223)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 37
        Me.LblSexo.Text = "Sexo"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(39, 173)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(26, 13)
        Me.LblDNI.TabIndex = 36
        Me.LblDNI.Text = "DNI"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(39, 282)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 35
        Me.LblDomicilio.Text = "Domicilio"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(39, 147)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 34
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(39, 121)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 33
        Me.LblNombre.Text = "Nombre"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(823, 408)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 32
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(509, 408)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 31
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'PictureModificarCliente
        '
        Me.PictureModificarCliente.Location = New System.Drawing.Point(584, 121)
        Me.PictureModificarCliente.Name = "PictureModificarCliente"
        Me.PictureModificarCliente.Size = New System.Drawing.Size(204, 131)
        Me.PictureModificarCliente.TabIndex = 55
        Me.PictureModificarCliente.TabStop = False
        '
        'FrmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 518)
        Me.Controls.Add(Me.PictureModificarCliente)
        Me.Controls.Add(Me.DGVGrillaModificarCliente)
        Me.Controls.Add(Me.LblModificarCliente)
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
        Me.Name = "FrmModificarCliente"
        Me.Text = "Asistente para modificar cliente"
        CType(Me.DGVGrillaModificarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureModificarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVGrillaModificarCliente As DataGridView
    Friend WithEvents LblModificarCliente As Label
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
    Friend WithEvents PictureModificarCliente As PictureBox
End Class
