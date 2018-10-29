<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListFactura
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
        Me.components = New System.ComponentModel.Container()
        Me.inexistente = New System.Windows.Forms.Label()
        Me.datalistadoFactura = New System.Windows.Forms.DataGridView()
        Me.dtfacLblXML = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtfacLblPdf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtfacLblSUNAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampos = New System.Windows.Forms.ComboBox()
        Me.Erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblXml = New System.Windows.Forms.Label()
        Me.lblPdf = New System.Windows.Forms.Label()
        Me.btnPdf = New System.Windows.Forms.Button()
        Me.lblCDR = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.btnEstado = New System.Windows.Forms.Button()
        CType(Me.datalistadoFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(241, 265)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 30
        Me.inexistente.Text = "Datos inexistentes"
        '
        'datalistadoFactura
        '
        Me.datalistadoFactura.AllowUserToAddRows = False
        Me.datalistadoFactura.AllowUserToDeleteRows = False
        Me.datalistadoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtfacLblXML, Me.dtfacLblPdf, Me.dtfacLblSUNAT})
        Me.datalistadoFactura.Location = New System.Drawing.Point(16, 108)
        Me.datalistadoFactura.Name = "datalistadoFactura"
        Me.datalistadoFactura.ReadOnly = True
        Me.datalistadoFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoFactura.Size = New System.Drawing.Size(1119, 245)
        Me.datalistadoFactura.TabIndex = 0
        '
        'dtfacLblXML
        '
        Me.dtfacLblXML.HeaderText = "XML"
        Me.dtfacLblXML.Name = "dtfacLblXML"
        Me.dtfacLblXML.ReadOnly = True
        '
        'dtfacLblPdf
        '
        Me.dtfacLblPdf.HeaderText = "PDF"
        Me.dtfacLblPdf.Name = "dtfacLblPdf"
        Me.dtfacLblPdf.ReadOnly = True
        '
        'dtfacLblSUNAT
        '
        Me.dtfacLblSUNAT.HeaderText = "SUNAT"
        Me.dtfacLblSUNAT.Name = "dtfacLblSUNAT"
        Me.dtfacLblSUNAT.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRefresh)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.Txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampos)
        Me.GroupBox2.Controls.Add(Me.datalistadoFactura)
        Me.GroupBox2.Location = New System.Drawing.Point(44, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1161, 373)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Facturas"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(16, 63)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(89, 28)
        Me.btnRefresh.TabIndex = 32
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(566, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(121, 37)
        Me.btnBuscar.TabIndex = 31
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Txtbuscar
        '
        Me.Txtbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbuscar.Location = New System.Drawing.Point(185, 22)
        Me.Txtbuscar.Name = "Txtbuscar"
        Me.Txtbuscar.Size = New System.Drawing.Size(362, 29)
        Me.Txtbuscar.TabIndex = 29
        '
        'cbocampos
        '
        Me.cbocampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocampos.FormattingEnabled = True
        Me.cbocampos.Items.AddRange(New Object() {"Cliente", "Cod_Venta"})
        Me.cbocampos.Location = New System.Drawing.Point(16, 19)
        Me.cbocampos.Name = "cbocampos"
        Me.cbocampos.Size = New System.Drawing.Size(152, 32)
        Me.cbocampos.TabIndex = 1
        Me.cbocampos.Text = "Cliente"
        '
        'Erroricono
        '
        Me.Erroricono.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISVENTAS.My.Resources.Resources.listaFacturas
        Me.PictureBox1.Location = New System.Drawing.Point(196, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(871, 126)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'lblXml
        '
        Me.lblXml.AutoSize = True
        Me.lblXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXml.ForeColor = System.Drawing.Color.Black
        Me.lblXml.Location = New System.Drawing.Point(404, 564)
        Me.lblXml.Name = "lblXml"
        Me.lblXml.Size = New System.Drawing.Size(50, 24)
        Me.lblXml.TabIndex = 94
        Me.lblXml.Text = "XML"
        '
        'lblPdf
        '
        Me.lblPdf.AutoSize = True
        Me.lblPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPdf.ForeColor = System.Drawing.Color.Black
        Me.lblPdf.Location = New System.Drawing.Point(585, 564)
        Me.lblPdf.Name = "lblPdf"
        Me.lblPdf.Size = New System.Drawing.Size(47, 24)
        Me.lblPdf.TabIndex = 95
        Me.lblPdf.Text = "PDF"
        '
        'btnPdf
        '
        Me.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPdf.FlatAppearance.BorderSize = 3
        Me.btnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPdf.Location = New System.Drawing.Point(589, 591)
        Me.btnPdf.Name = "btnPdf"
        Me.btnPdf.Size = New System.Drawing.Size(87, 37)
        Me.btnPdf.TabIndex = 96
        Me.btnPdf.Text = "Imprimir"
        Me.btnPdf.UseVisualStyleBackColor = True
        Me.btnPdf.Visible = False
        '
        'lblCDR
        '
        Me.lblCDR.AutoSize = True
        Me.lblCDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCDR.ForeColor = System.Drawing.Color.Black
        Me.lblCDR.Location = New System.Drawing.Point(770, 564)
        Me.lblCDR.Name = "lblCDR"
        Me.lblCDR.Size = New System.Drawing.Size(49, 24)
        Me.lblCDR.TabIndex = 97
        Me.lblCDR.Text = "CDR"
        '
        'btnEnviar
        '
        Me.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnviar.FlatAppearance.BorderSize = 3
        Me.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(1082, 555)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(123, 46)
        Me.btnEnviar.TabIndex = 98
        Me.btnEnviar.Text = "Enviar Correo"
        Me.btnEnviar.UseVisualStyleBackColor = True
        Me.btnEnviar.Visible = False
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.Location = New System.Drawing.Point(56, 568)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(23, 24)
        Me.lblFactura.TabIndex = 99
        Me.lblFactura.Text = "F"
        '
        'btnEstado
        '
        Me.btnEstado.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEstado.FlatAppearance.BorderSize = 3
        Me.btnEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstado.Location = New System.Drawing.Point(60, 600)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.Size = New System.Drawing.Size(87, 37)
        Me.btnEstado.TabIndex = 100
        Me.btnEstado.Text = "Estado"
        Me.btnEstado.UseVisualStyleBackColor = True
        Me.btnEstado.Visible = False
        '
        'FrmListFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1246, 649)
        Me.Controls.Add(Me.btnEstado)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblCDR)
        Me.Controls.Add(Me.btnPdf)
        Me.Controls.Add(Me.lblPdf)
        Me.Controls.Add(Me.lblXml)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmListFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Facturas"
        CType(Me.datalistadoFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inexistente As System.Windows.Forms.Label
    Friend WithEvents datalistadoFactura As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampos As System.Windows.Forms.ComboBox
    Friend WithEvents Erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblXml As System.Windows.Forms.Label
    Friend WithEvents lblPdf As System.Windows.Forms.Label
    Friend WithEvents btnPdf As System.Windows.Forms.Button
    Friend WithEvents lblCDR As System.Windows.Forms.Label
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents dtfacLblXML As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtfacLblPdf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtfacLblSUNAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnEstado As System.Windows.Forms.Button
End Class
