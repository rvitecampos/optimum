Imports System.Data.SQLite
Public Class crud
    ':::Creamos nuestra conexión a la base de Datos
    Dim con As New SQLiteConnection("Data Source=D:\FACTURADOR\SFS_v1.2\bd\BDFacturador.db;")
    'Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\FACTURADOR\SFS_v1.2\bd\BDFacturador.db;")
    '  ;Persist Security Info=True;Integrated Security=SSPI;")
    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\myDb;
    'Extended Properties=Paradox 5.x;
    ':::Creamos el procedimiento conexion
    Sub conexion()
        ':::Instruccion Try para capturar errores
        Try
            ':::Abrimos nuestro conexion con la propiedad Open
            con.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Tutorial CRUD")
            ':::Y cerramos la conexion
            con.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD")
        End Try
    End Sub
End Class
