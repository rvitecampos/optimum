
Imports System.Data.SQLite

Public Class crud
    Private dt As DataTable
    Public Function SFS() As String
        Dim func As New fRutaSFS
        dt = func.mostrar
        Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
        Dim raiz As String
        raiz = row.Item("rutasfs")


        Return Trim(raiz)
    End Function


    Dim cs As String = "Data Source=" + SFS() + "\bd\BDFacturador.db;"
    ' Dim con As New SQLiteConnection(connectionString)
    ':::Creamos nuestra conexión a la base de Datos
    '    Dim con As New SQLiteConnection("Data Source=D:\FACTURADOR\SFS_v1.2\bd\BDFacturador.db;")
    'Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\FACTURADOR\SFS_v1.2\bd\BDFacturador.db;")
    '  ;Persist Security Info=True;Integrated Security=SSPI;")
    'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\myDb;
    'Extended Properties=Paradox 5.x;
    ':::Creamos el procedimiento conexion
    Sub conexion()
        ':::Instruccion Try para capturar errores
        Try
            ':::Abrimos nuestro conexion con la propiedad Open
            '  con.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "Tutorial CRUD")
            ':::Y cerramos la conexion
            ' con.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD")
        End Try
    End Sub
    Public Function mostrar() As DataTable
        ' Dim cs As String = "Data Source=D:\FACTURADOR\SFS_v1.2\bd\BDFacturador.db;"
        'conexion()
        Try
            Dim SQLSelect As String = "SELECT NOM_ARCH FROM DOCUMENTO"
            'Creamos un SQLiteCommand y le asignamos la cadena de consulta

            Using con As New SQLiteConnection(cs)
                Dim command As New SQLiteCommand(SQLSelect, con)
                Dim da As SQLiteDataAdapter = New SQLiteDataAdapter(command)
                da.SelectCommand = command
                Dim dt As New DataTable
                da.Fill(dt)
                con.Close()
                Return dt
            End Using
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "Tutorial CRUD")
        End Try
    End Function
    Public Function eliminar(ByVal ARCH As String) As Boolean
        Try
            Dim SQLDelete As String = "DELETE FROM DOCUMENTO WHERE NOM_ARCH = ?"

            Using con As New SQLiteConnection(cs)
                con.Open()
                Dim command As New SQLiteCommand(SQLDelete, con)
                command.Parameters.AddWithValue("NOM_ARCH", ARCH)
                command.ExecuteNonQuery()


                con.Close()
                Return True

            End Using

        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        End Try

    End Function


End Class
