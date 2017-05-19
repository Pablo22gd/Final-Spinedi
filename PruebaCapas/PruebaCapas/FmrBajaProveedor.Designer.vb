<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmrBajaProveedor
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
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.LblingresarDato = New System.Windows.Forms.Label()
        Me.Cbfiltrar = New System.Windows.Forms.ComboBox()
        Me.TxtIngresarDato = New System.Windows.Forms.TextBox()
        Me.DGVBjaProveedor = New System.Windows.Forms.DataGridView()
        Me.PictureBajaProveedor = New System.Windows.Forms.PictureBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblbajaProveedor = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.DGVBjaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBajaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFiltrar
        '
        Me.LblFiltrar.AutoSize = True
        Me.LblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltrar.Location = New System.Drawing.Point(38, 109)
        Me.LblFiltrar.Name = "LblFiltrar"
        Me.LblFiltrar.Size = New System.Drawing.Size(41, 16)
        Me.LblFiltrar.TabIndex = 1
        Me.LblFiltrar.Text = "Filtrar"
        '
        'LblingresarDato
        '
        Me.LblingresarDato.AutoSize = True
        Me.LblingresarDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblingresarDato.Location = New System.Drawing.Point(36, 159)
        Me.LblingresarDato.Name = "LblingresarDato"
        Me.LblingresarDato.Size = New System.Drawing.Size(87, 16)
        Me.LblingresarDato.TabIndex = 2
        Me.LblingresarDato.Text = "Ingresar dato"
        '
        'Cbfiltrar
        '
        Me.Cbfiltrar.FormattingEnabled = True
        Me.Cbfiltrar.Items.AddRange(New Object() {"codigo", "DNI", "Apellido", "Cuit"})
        Me.Cbfiltrar.Location = New System.Drawing.Point(145, 109)
        Me.Cbfiltrar.Name = "Cbfiltrar"
        Me.Cbfiltrar.Size = New System.Drawing.Size(199, 21)
        Me.Cbfiltrar.TabIndex = 3
        '
        'TxtIngresarDato
        '
        Me.TxtIngresarDato.Location = New System.Drawing.Point(145, 159)
        Me.TxtIngresarDato.Name = "TxtIngresarDato"
        Me.TxtIngresarDato.Size = New System.Drawing.Size(199, 20)
        Me.TxtIngresarDato.TabIndex = 4
        '
        'DGVBjaProveedor
        '
        Me.DGVBjaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBjaProveedor.Location = New System.Drawing.Point(60, 283)
        Me.DGVBjaProveedor.Name = "DGVBjaProveedor"
        Me.DGVBjaProveedor.Size = New System.Drawing.Size(839, 150)
        Me.DGVBjaProveedor.TabIndex = 5
        '
        'PictureBajaProveedor
        '
        Me.PictureBajaProveedor.Location = New System.Drawing.Point(533, 72)
        Me.PictureBajaProveedor.Name = "PictureBajaProveedor"
        Me.PictureBajaProveedor.Size = New System.Drawing.Size(225, 161)
        Me.PictureBajaProveedor.TabIndex = 6
        Me.PictureBajaProveedor.TabStop = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(387, 136)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(99, 23)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseMnemonic = False
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LblbajaProveedor
        '
        Me.LblbajaProveedor.AutoSize = True
        Me.LblbajaProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblbajaProveedor.Location = New System.Drawing.Point(575, 40)
        Me.LblbajaProveedor.Name = "LblbajaProveedor"
        Me.LblbajaProveedor.Size = New System.Drawing.Size(131, 20)
        Me.LblbajaProveedor.TabIndex = 8
        Me.LblbajaProveedor.Text = "Baja Proveedor"
        '
        'BtnVolver
        '
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(258, 457)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 9
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(628, 456)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FmrBajaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 494)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblbajaProveedor)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.PictureBajaProveedor)
        Me.Controls.Add(Me.DGVBjaProveedor)
        Me.Controls.Add(Me.TxtIngresarDato)
        Me.Controls.Add(Me.Cbfiltrar)
        Me.Controls.Add(Me.LblingresarDato)
        Me.Controls.Add(Me.LblFiltrar)
        Me.Name = "FmrBajaProveedor"
        Me.Text = "Asistente para eliminar un proveedor"
        CType(Me.DGVBjaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBajaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFiltrar As Label
    Friend WithEvents LblingresarDato As Label
    Friend WithEvents Cbfiltrar As ComboBox
    Friend WithEvents TxtIngresarDato As TextBox
    Friend WithEvents DGVBjaProveedor As DataGridView
    Friend WithEvents PictureBajaProveedor As PictureBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblbajaProveedor As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnEliminar As Button
End Class
