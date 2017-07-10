<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaProveedor
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
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblConsultaProducto = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVConsultaProveedor = New System.Windows.Forms.DataGridView()
        CType(Me.DGVConsultaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(641, 314)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 11
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(360, 65)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 10
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LblConsultaProducto
        '
        Me.LblConsultaProducto.AutoSize = True
        Me.LblConsultaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultaProducto.Location = New System.Drawing.Point(520, 27)
        Me.LblConsultaProducto.Name = "LblConsultaProducto"
        Me.LblConsultaProducto.Size = New System.Drawing.Size(158, 18)
        Me.LblConsultaProducto.TabIndex = 9
        Me.LblConsultaProducto.Text = "Consulta Proveedor"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(174, 65)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(164, 20)
        Me.TxtBuscar.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ingresar nombre del proveedor"
        '
        'DGVConsultaProveedor
        '
        Me.DGVConsultaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsultaProveedor.Location = New System.Drawing.Point(174, 130)
        Me.DGVConsultaProveedor.Name = "DGVConsultaProveedor"
        Me.DGVConsultaProveedor.Size = New System.Drawing.Size(734, 174)
        Me.DGVConsultaProveedor.TabIndex = 6
        '
        'FrmConsultaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 343)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LblConsultaProducto)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVConsultaProveedor)
        Me.Name = "FrmConsultaProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de consulta"
        CType(Me.DGVConsultaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblConsultaProducto As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVConsultaProveedor As DataGridView
End Class
