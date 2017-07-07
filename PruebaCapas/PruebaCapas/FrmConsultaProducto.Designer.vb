<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaProducto
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
        Me.DGVConsultaProducto = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LblConsultaProducto = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.DGVConsultaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVConsultaProducto
        '
        Me.DGVConsultaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsultaProducto.Location = New System.Drawing.Point(201, 128)
        Me.DGVConsultaProducto.Name = "DGVConsultaProducto"
        Me.DGVConsultaProducto.Size = New System.Drawing.Size(734, 174)
        Me.DGVConsultaProducto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingresar nombre del producto "
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(201, 63)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(164, 20)
        Me.TxtBuscar.TabIndex = 2
        '
        'LblConsultaProducto
        '
        Me.LblConsultaProducto.AutoSize = True
        Me.LblConsultaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConsultaProducto.Location = New System.Drawing.Point(547, 25)
        Me.LblConsultaProducto.Name = "LblConsultaProducto"
        Me.LblConsultaProducto.Size = New System.Drawing.Size(147, 18)
        Me.LblConsultaProducto.TabIndex = 3
        Me.LblConsultaProducto.Text = "Consulta producto"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(387, 63)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(668, 312)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 5
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmConsultaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 351)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LblConsultaProducto)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVConsultaProducto)
        Me.Name = "FrmConsultaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Producto"
        CType(Me.DGVConsultaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVConsultaProducto As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LblConsultaProducto As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnVolver As Button
End Class
