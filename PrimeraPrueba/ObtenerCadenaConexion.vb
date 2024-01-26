Imports System.Data.Odbc

Public Class ObtenerCadenaConexion
    Public Shared Function conexion() As OdbcConnection
        Dim connStr As String = "DSN=DBPW;UID=remoto;PWD=1234;"
        Dim conn As New OdbcConnection(connStr)
        Return conn
    End Function
End Class
