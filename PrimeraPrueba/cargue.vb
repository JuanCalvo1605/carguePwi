Imports System.IO
Imports System.Data.Odbc
Imports System.Net
Imports excel = Microsoft.Office.Interop.Excel
Public Class cargue
    'variables publicas para usar en todo el programa
    Private usuario As String
    Private rol As String
    Private ruta As String
    Private descripcion As String
    Public Sub recibirValores(ByVal valores As String())
        'funcion que recibe los valores retornados en el form1
        usuario = valores(1)
        rol = valores(3)
        ruta = valores(4)
        descripcion = valores(5)
    End Sub
    Private Sub btn_openF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_openF.Click

        OpenFileDialog1.Title = "Seleccionar un archivo Excel"
        'valores para enviar a bd
        Dim fechaHoraActual As String = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
        Dim conn As OdbcConnection = ObtenerCadenaConexion.conexion()
        Dim nueva_rutaArchivo As String
        'filtro para que solo se pueda recibir archvios excel
        OpenFileDialog1.Filter = "Archivos de Excel|*.xls;*.xlsx"

        'validar que el combobox no este vació 
        If String.IsNullOrEmpty(Comb_mes.Text) And String.IsNullOrEmpty(Comb_anio.Text) Then
            ValidarCampoVSelect(Comb_mes, lbl_error_mes, "El campo no puede estar vacío", 5000)
            ValidarCampoVSelect(Comb_anio, lbl_error_anio, "El campo no puede estar vacío", 5000)
            Return
            'validar que el combobox no este vació
        ElseIf String.IsNullOrEmpty(Comb_anio.Text) Then
            ValidarCampoVSelect(Comb_anio, lbl_error_anio, "El campo no puede estar vacío", 5000)
            Return
        ElseIf String.IsNullOrEmpty(Comb_mes.Text) Then
            ValidarCampoVSelect(Comb_mes, lbl_error_mes, "El campo no puede estar vacío", 5000)
            Return
        End If

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'capturar valores 
            Dim nombreO As String = System.IO.Path.GetFileName(OpenFileDialog1.FileName)

            'capturar valor del messegun el combobox' 
            Dim fechaM As String = Comb_mes.Text
            'capturar valor del año segun el combobox
            Dim fechaA As String = Comb_anio.Text
            'capturar extencion
            Dim extension As String = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            Dim rutaOrigianl As String = OpenFileDialog1.FileName
            'variable que le coloca el nombre final al archivo
            Dim nombreF As String = fechaM & " " & fechaA & extension
            'inicializar el archvo
            Dim excelApp As New excel.Application()
            excelApp.Visible = False

            Dim wb As excel.Workbook = excelApp.Workbooks.Open(rutaOrigianl)

            Dim ws As excel.Worksheet = TryCast(excelApp.ActiveSheet, excel.Worksheet)
            'definir la hoja 
            Dim primeraHoja As excel.Worksheet = wb.Sheets(1)
            'Obtener la última fila con datos en la columna A
            Dim lastRow As Integer = ws.Cells(primeraHoja.Rows.Count, 1).End(excel.XlDirection.xlUp).Row
            'Dim columnaA As excel.Range = ws.Columns("A;A")

            ws.Columns("A:A").Insert(excel.XlInsertShiftDirection.xlShiftToRight, excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
            ' Rellenar la nueva columna A con texto
            For i As Integer = 1 To lastRow
                ws.Cells(i, 1).Value = fechaM & " " & fechaA ' Texto que deseas insertar en la columna A
            Next
            primeraHoja.Name = "Maestro"

            nueva_rutaArchivo = Path.ChangeExtension(ruta & nombreF, ".xlsx")
            wb.SaveAs(nueva_rutaArchivo, excel.XlFileFormat.xlOpenXMLWorkbook)
            wb.Close()
            conn.Open()
            ' inactivar mes luego de elegirlo 
            Try
                Dim callProcedure As New OdbcCommand("CALL inactivar_mes('" & fechaM & "' , '" & CInt(fechaA) & "')", conn)
                callProcedure.CommandType = CommandType.StoredProcedure
                callProcedure.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("error " & ex.Message)
            End Try
            'agregar registro al log
            Try
                Dim callProcedure2 As New OdbcCommand("CALL sp_log('" & rutaOrigianl & "' , '" & nombreO & "' , '" & nombreF & "' , '" & fechaHoraActual & "' , '" & usuario & "' )", conn)
                callProcedure2.CommandType = CommandType.StoredProcedure
                callProcedure2.ExecuteScalar()
            Catch ex As Exception
                MsgBox("error" & ex.Message)
            End Try

            cargue_Load(Nothing, Nothing)
            conn.Close()

            MsgBox("Cargue exitoso")
        Else
            MsgBox("Elige un archivo")
        End If

        

    End Sub

    Private Sub cargue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As OdbcConnection = ObtenerCadenaConexion.conexion()
        Dim meses As New List(Of String)()
        Dim anio As String = ""
        Dim estado As String = ""

        Comb_mes.Items.Clear()
        Comb_anio.Items.Clear()
        'datos de conexion
        Try
            conn.Open()
            Dim callProcedure As New OdbcCommand("CALL fechas_activas()", conn)
            'especificar que la variable es de tipo procedimiento almacena
            callProcedure.CommandType = CommandType.StoredProcedure
            Dim reader As OdbcDataReader = callProcedure.ExecuteReader()
            While reader.Read()
                meses.Add(reader.GetString(0)) ' Añade el mes a la lista de meses
                anio = reader.GetString(1) ' Asigna el año a la variable 'anio'
                estado = reader.GetString(2) ' Asigna el estado a la variable 'estado'
            End While
            If estado = "1" Then
                For Each mes As String In meses
                    Comb_mes.Items.Add(mes)
                Next
                Comb_anio.Items.Add(anio)
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("error " & ex.Message)
        End Try

    End Sub
End Class