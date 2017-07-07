<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresarNuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresarNuevoCliente))
        Me.LblIngresarNuevoCliente = New System.Windows.Forms.Label()
        Me.PictureNuevoCliente = New System.Windows.Forms.PictureBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.CbSexo = New System.Windows.Forms.ComboBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.DTPFechaDeNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.CbProvincia = New System.Windows.Forms.ComboBox()
        Me.CbLocalidad = New System.Windows.Forms.ComboBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        CType(Me.PictureNuevoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIngresarNuevoCliente
        '
        Me.LblIngresarNuevoCliente.AutoSize = True
        Me.LblIngresarNuevoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIngresarNuevoCliente.Location = New System.Drawing.Point(580, 67)
        Me.LblIngresarNuevoCliente.Name = "LblIngresarNuevoCliente"
        Me.LblIngresarNuevoCliente.Size = New System.Drawing.Size(166, 16)
        Me.LblIngresarNuevoCliente.TabIndex = 0
        Me.LblIngresarNuevoCliente.Text = "Ingresar Nuevo Cliente"
        '
        'PictureNuevoCliente
        '
        Me.PictureNuevoCliente.Image = CType(resources.GetObject("PictureNuevoCliente.Image"), System.Drawing.Image)
        Me.PictureNuevoCliente.Location = New System.Drawing.Point(583, 110)
        Me.PictureNuevoCliente.Name = "PictureNuevoCliente"
        Me.PictureNuevoCliente.Size = New System.Drawing.Size(163, 163)
        Me.PictureNuevoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureNuevoCliente.TabIndex = 1
        Me.PictureNuevoCliente.TabStop = False
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(31, 83)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(31, 110)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 3
        Me.LblApellido.Text = "Apellido"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(31, 137)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(26, 13)
        Me.LblDNI.TabIndex = 4
        Me.LblDNI.Text = "DNI"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(31, 166)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LblDomicilio.TabIndex = 5
        Me.LblDomicilio.Text = "Domicilio"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(31, 194)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 6
        Me.LblSexo.Text = "Sexo"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(151, 79)
        Me.TxtNombre.MaxLength = 30
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(210, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(151, 105)
        Me.TxtApellido.MaxLength = 30
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(210, 20)
        Me.TxtApellido.TabIndex = 1
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(151, 130)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(210, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Location = New System.Drawing.Point(151, 159)
        Me.TxtDomicilio.MaxLength = 50
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(210, 20)
        Me.TxtDomicilio.TabIndex = 3
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(151, 245)
        Me.TxtTelefono.MaxLength = 20
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(210, 20)
        Me.TxtTelefono.TabIndex = 6
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(151, 271)
        Me.TxtEmail.MaxLength = 50
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(210, 20)
        Me.TxtEmail.TabIndex = 7
        '
        'LblFechaDeNacimiento
        '
        Me.LblFechaDeNacimiento.AutoSize = True
        Me.LblFechaDeNacimiento.Location = New System.Drawing.Point(31, 220)
        Me.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento"
        Me.LblFechaDeNacimiento.Size = New System.Drawing.Size(108, 13)
        Me.LblFechaDeNacimiento.TabIndex = 15
        Me.LblFechaDeNacimiento.Text = "Fecha de Nacimiento"
        '
        'CbSexo
        '
        Me.CbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbSexo.FormattingEnabled = True
        Me.CbSexo.Items.AddRange(New Object() {"Masculino ", "Femenino"})
        Me.CbSexo.Location = New System.Drawing.Point(151, 186)
        Me.CbSexo.Name = "CbSexo"
        Me.CbSexo.Size = New System.Drawing.Size(210, 21)
        Me.CbSexo.TabIndex = 4
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(31, 248)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 17
        Me.LblTelefono.Text = "Telefono"
        '
        'DTPFechaDeNacimiento
        '
        Me.DTPFechaDeNacimiento.Location = New System.Drawing.Point(151, 214)
        Me.DTPFechaDeNacimiento.MaxDate = New Date(1998, 12, 31, 0, 0, 0, 0)
        Me.DTPFechaDeNacimiento.Name = "DTPFechaDeNacimiento"
        Me.DTPFechaDeNacimiento.Size = New System.Drawing.Size(210, 20)
        Me.DTPFechaDeNacimiento.TabIndex = 5
        Me.DTPFechaDeNacimiento.Value = New Date(1998, 12, 31, 0, 0, 0, 0)
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(31, 274)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 19
        Me.LblEmail.Text = "Email"
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(31, 306)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(51, 13)
        Me.LblProvincia.TabIndex = 20
        Me.LblProvincia.Text = "Provincia"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(31, 339)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(53, 13)
        Me.LblLocalidad.TabIndex = 21
        Me.LblLocalidad.Text = "Localidad"
        '
        'CbProvincia
        '
        Me.CbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbProvincia.FormattingEnabled = True
        Me.CbProvincia.Items.AddRange(New Object() {"BS AS"})
        Me.CbProvincia.Location = New System.Drawing.Point(151, 303)
        Me.CbProvincia.Name = "CbProvincia"
        Me.CbProvincia.Size = New System.Drawing.Size(210, 21)
        Me.CbProvincia.TabIndex = 8
        '
        'CbLocalidad
        '
        Me.CbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbLocalidad.FormattingEnabled = True
        Me.CbLocalidad.Items.AddRange(New Object() {"LA PLATA"})
        Me.CbLocalidad.Location = New System.Drawing.Point(151, 336)
        Me.CbLocalidad.Name = "CbLocalidad"
        Me.CbLocalidad.Size = New System.Drawing.Size(210, 21)
        Me.CbLocalidad.TabIndex = 9
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(31, 371)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 26
        Me.LblEstado.Text = "Estado"
        '
        'CbEstado
        '
        Me.CbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CbEstado.Location = New System.Drawing.Point(151, 368)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(210, 21)
        Me.CbEstado.TabIndex = 10
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(583, 316)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 12
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(670, 316)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 11
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'FrmIngresarNuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 526)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.CbEstado)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.CbLocalidad)
        Me.Controls.Add(Me.CbProvincia)
        Me.Controls.Add(Me.LblLocalidad)
        Me.Controls.Add(Me.LblProvincia)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.DTPFechaDeNacimiento)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.CbSexo)
        Me.Controls.Add(Me.LblFechaDeNacimiento)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblDomicilio)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.PictureNuevoCliente)
        Me.Controls.Add(Me.LblIngresarNuevoCliente)
        Me.Name = "FrmIngresarNuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente Para Ingresar Nuevo Cliente"
        CType(Me.PictureNuevoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIngresarNuevoCliente As Label
    Friend WithEvents PictureNuevoCliente As PictureBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents LblFechaDeNacimiento As Label
    Friend WithEvents CbSexo As ComboBox
    Friend WithEvents LblTelefono As Label
    Friend WithEvents DTPFechaDeNacimiento As DateTimePicker
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblProvincia As Label
    Friend WithEvents LblLocalidad As Label
    Friend WithEvents CbProvincia As ComboBox
    Friend WithEvents CbLocalidad As ComboBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnAgregar As Button
End Class
