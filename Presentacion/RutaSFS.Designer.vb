<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RutaSFS
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
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(105, 73)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(108, 35)
        Me.btnRuta.TabIndex = 1
        Me.btnRuta.Text = "Cambiar Ruta"
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Location = New System.Drawing.Point(102, 28)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(30, 13)
        Me.lblRuta.TabIndex = 2
        Me.lblRuta.Text = "Ruta"
        '
        'RutaSFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 167)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.btnRuta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RutaSFS"
        Me.Text = "RutaSFS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRuta As System.Windows.Forms.Button
    Friend WithEvents lblRuta As System.Windows.Forms.Label
End Class
