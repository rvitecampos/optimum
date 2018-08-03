<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFondo
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
        Me.DatalistadoFondo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFondo = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        CType(Me.DatalistadoFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatalistadoFondo
        '
        Me.DatalistadoFondo.AllowUserToAddRows = False
        Me.DatalistadoFondo.AllowUserToDeleteRows = False
        Me.DatalistadoFondo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatalistadoFondo.Location = New System.Drawing.Point(289, 55)
        Me.DatalistadoFondo.Name = "DatalistadoFondo"
        Me.DatalistadoFondo.ReadOnly = True
        Me.DatalistadoFondo.Size = New System.Drawing.Size(149, 66)
        Me.DatalistadoFondo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fondo:"
        '
        'TxtFondo
        '
        Me.TxtFondo.Location = New System.Drawing.Point(95, 32)
        Me.TxtFondo.Name = "TxtFondo"
        Me.TxtFondo.Size = New System.Drawing.Size(135, 20)
        Me.TxtFondo.TabIndex = 2
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(55, 113)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(204, 35)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(315, 83)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 31
        Me.inexistente.Text = "Datos inexistentes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Gs."
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(55, 75)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(99, 32)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.Text = "Agregar Dinero"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(160, 75)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(99, 32)
        Me.btnQuitar.TabIndex = 3
        Me.btnQuitar.Text = "Quitar Dinero"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'FrmFondo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 176)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.TxtFondo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatalistadoFondo)
        Me.Name = "FrmFondo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FONDO"
        CType(Me.DatalistadoFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatalistadoFondo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFondo As System.Windows.Forms.TextBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents inexistente As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
End Class
