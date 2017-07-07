<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCliente
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
        Me.DGVGrillaCliente = New System.Windows.Forms.DataGridView()
        Me.LblBajaCliente = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.DGVGrillaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVGrillaCliente
        '
        Me.DGVGrillaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVGrillaCliente.Location = New System.Drawing.Point(12, 134)
        Me.DGVGrillaCliente.Name = "DGVGrillaCliente"
        Me.DGVGrillaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGrillaCliente.Size = New System.Drawing.Size(880, 179)
        Me.DGVGrillaCliente.TabIndex = 3
        '
        'LblBajaCliente
        '
        Me.LblBajaCliente.AutoSize = True
        Me.LblBajaCliente.Location = New System.Drawing.Point(448, 41)
        Me.LblBajaCliente.Name = "LblBajaCliente"
        Me.LblBajaCliente.Size = New System.Drawing.Size(96, 13)
        Me.LblBajaCliente.TabIndex = 7
        Me.LblBajaCliente.Text = "consulta de cliente"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(817, 327)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(227, 92)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(222, 20)
        Me.txtBuscar.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ingrese el nombre que desea buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(469, 90)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmConsultaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 362)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.LblBajaCliente)
        Me.Controls.Add(Me.DGVGrillaCliente)
        Me.Name = "FrmConsultaCliente"
        Me.Text = "Consuta de clientes"
        CType(Me.DGVGrillaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVGrillaCliente As DataGridView
    Friend WithEvents LblBajaCliente As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
End Class
