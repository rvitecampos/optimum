Public Class Form1

 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DespensaDataSet.Reporte_Inventario' table. You can move, or remove it, as needed.
        Me.Reporte_InventarioTableAdapter.Fill(Me.DespensaDataSet.Reporte_Inventario)

    End Sub
End Class
