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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmrBajaProveedor))
        Me.LblingresarDato = New System.Windows.Forms.Label()
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
        'LblingresarDato
        '
        Me.LblingresarDato.AutoSize = True
        Me.LblingresarDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblingresarDato.Location = New System.Drawing.Point(151, 100)
        Me.LblingresarDato.Name = "LblingresarDato"
        Me.LblingresarDato.Size = New System.Drawing.Size(194, 16)
        Me.LblingresarDato.TabIndex = 2
        Me.LblingresarDato.Text = "Ingresar nombre del proveedor"
        '
        'TxtIngresarDato
        '
        Me.TxtIngresarDato.Location = New System.Drawing.Point(147, 136)
        Me.TxtIngresarDato.Name = "TxtIngresarDato"
        Me.TxtIngresarDato.Size = New System.Drawing.Size(206, 20)
        Me.TxtIngresarDato.TabIndex = 4
        '
        'DGVBjaProveedor
        '
        Me.DGVBjaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBjaProveedor.Location = New System.Drawing.Point(60, 283)
        Me.DGVBjaProveedor.Name = "DGVBjaProveedor"
        Me.DGVBjaProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVBjaProveedor.Size = New System.Drawing.Size(839, 150)
        Me.DGVBjaProveedor.TabIndex = 5
        '
        'PictureBajaProveedor
        '
        Me.PictureBajaProveedor.Image = CType(resources.GetObject("PictureBajaProveedor.Image"), System.Drawing.Image)
        Me.PictureBajaProveedor.Location = New System.Drawing.Point(525, 72)
        Me.PictureBajaProveedor.Name = "PictureBajaProveedor"
        Me.PictureBajaProveedor.Size = New System.Drawing.Size(231, 185)
        Me.PictureBajaProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        Me.Controls.Add(Me.LblingresarDato)
        Me.Name = "FmrBajaProveedor"
        Me.Text = "Asistente para eliminar un proveedor"
        CType(Me.DGVBjaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBajaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblingresarDato As Label
    Friend WithEvents TxtIngresarDato As TextBox
    Friend WithEvents DGVBjaProveedor As DataGridView
    Friend WithEvents PictureBajaProveedor As PictureBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblbajaProveedor As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnEliminar As Button
End Class
