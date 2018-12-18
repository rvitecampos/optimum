<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class crudDB
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtgDB = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtARCH = New System.Windows.Forms.TextBox()
        CType(Me.dtgDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Conexion DB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtgDB
        '
        Me.dtgDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDB.Location = New System.Drawing.Point(40, 74)
        Me.dtgDB.Name = "dtgDB"
        Me.dtgDB.Size = New System.Drawing.Size(373, 169)
        Me.dtgDB.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(264, 270)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 26)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtARCH
        '
        Me.txtARCH.Location = New System.Drawing.Point(40, 270)
        Me.txtARCH.Name = "txtARCH"
        Me.txtARCH.Size = New System.Drawing.Size(100, 20)
        Me.txtARCH.TabIndex = 3
        '
        'crudDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 327)
        Me.Controls.Add(Me.txtARCH)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dtgDB)
        Me.Controls.Add(Me.Button1)
        Me.Name = "crudDB"
        Me.Text = "crudDB"
        CType(Me.dtgDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtgDB As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtARCH As System.Windows.Forms.TextBox
End Class
