<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaCliente
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
        Me.LblFiltrarPor = New System.Windows.Forms.Label()
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.DGVGrillaBajaCliente = New System.Windows.Forms.DataGridView()
        Me.PictureBajaCliente = New System.Windows.Forms.PictureBox()
        Me.CBFiltro = New System.Windows.Forms.ComboBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LblBajaCliente = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        CType(Me.DGVGrillaBajaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBajaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblFiltrarPor
        '
        Me.LblFiltrarPor.AutoSize = True
        Me.LblFiltrarPor.Location = New System.Drawing.Point(112, 106)
        Me.LblFiltrarPor.Name = "LblFiltrarPor"
        Me.LblFiltrarPor.Size = New System.Drawing.Size(50, 13)
        Me.LblFiltrarPor.TabIndex = 0
        Me.LblFiltrarPor.Text = "Filtrar por"
        '
        'LblBuscar
        '
        Me.LblBuscar.AutoSize = True
        Me.LblBuscar.Location = New System.Drawing.Point(112, 149)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.LblBuscar.TabIndex = 1
        Me.LblBuscar.Text = "Buscar"
        '
        'DGVGrillaBajaCliente
        '
        Me.DGVGrillaBajaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGrillaBajaCliente.Location = New System.Drawing.Point(377, 233)
        Me.DGVGrillaBajaCliente.Name = "DGVGrillaBajaCliente"
        Me.DGVGrillaBajaCliente.Size = New System.Drawing.Size(608, 94)
        Me.DGVGrillaBajaCliente.TabIndex = 2
        '
        'PictureBajaCliente
        '
        Me.PictureBajaCliente.Location = New System.Drawing.Point(585, 85)
        Me.PictureBajaCliente.Name = "PictureBajaCliente"
        Me.PictureBajaCliente.Size = New System.Drawing.Size(209, 103)
        Me.PictureBajaCliente.TabIndex = 3
        Me.PictureBajaCliente.TabStop = False
        '
        'CBFiltro
        '
        Me.CBFiltro.FormattingEnabled = True
        Me.CBFiltro.Items.AddRange(New Object() {"DNI", "Apellido", "Numero de Cliente", "cuit"})
        Me.CBFiltro.Location = New System.Drawing.Point(178, 106)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(179, 21)
        Me.CBFiltro.TabIndex = 4
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(178, 149)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(179, 20)
        Me.TxtBuscar.TabIndex = 5
        '
        'LblBajaCliente
        '
        Me.LblBajaCliente.AutoSize = True
        Me.LblBajaCliente.Location = New System.Drawing.Point(656, 49)
        Me.LblBajaCliente.Name = "LblBajaCliente"
        Me.LblBajaCliente.Size = New System.Drawing.Size(78, 13)
        Me.LblBajaCliente.TabIndex = 6
        Me.LblBajaCliente.Text = "Baja de Cliente"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(585, 352)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(719, 352)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 8
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmBajaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 395)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblBajaCliente)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.CBFiltro)
        Me.Controls.Add(Me.PictureBajaCliente)
        Me.Controls.Add(Me.DGVGrillaBajaCliente)
        Me.Controls.Add(Me.LblBuscar)
        Me.Controls.Add(Me.LblFiltrarPor)
        Me.Name = "FrmBajaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente para dar de baja el cliente"
        CType(Me.DGVGrillaBajaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBajaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFiltrarPor As Label
    Friend WithEvents LblBuscar As Label
    Friend WithEvents DGVGrillaBajaCliente As DataGridView
    Friend WithEvents PictureBajaCliente As PictureBox
    Friend WithEvents CBFiltro As ComboBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LblBajaCliente As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnEliminar As Button
End Class
