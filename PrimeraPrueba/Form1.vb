Imports System.Data.Odbc
Public Class form1
    Private Sub ObtenerCadenaConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_email.Focus()
    End Sub
    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim usuario, contras As String
        Dim exito As Boolean
        Dim valores(1) As String ' Array para almacenar los valores

        ' Asignar valores del formulario a variables
        usuario = txt_email.Text
        contras = txt_password.Text

        'validar que los campos no esten vacios 
        If String.IsNullOrEmpty(txt_email.Text) And String.IsNullOrEmpty(txt_password.Text) Then
            validaciones.ValidarCampoV(txt_email, lbl_error_mail, "El campo correo es obligatorio", 5000)
            validaciones.ValidarCampoV(txt_password, lbl_error_cont, "El campo contraseña es obligatorio", 5000)
            Return
        ElseIf String.IsNullOrEmpty(txt_email.Text) Then
            validaciones.ValidarCampoV(txt_email, lbl_error_mail, "El campo correo es obligatorio", 5000)
        ElseIf String.IsNullOrEmpty(txt_password.Text) Then
            validaciones.ValidarCampoV(txt_password, lbl_error_cont, "El campo contraseña es obligatorio", 5000)
            Return
        End If
        'validar que los campos no sean mayores a 50 caracteres
        If txt_email.Text.Length > 50 And txt_password.Text.Length > 20 Then
            validaciones.ValidarCampoV(txt_email, lbl_error_mail, "El campo supera los 50 caracteres", 5000)
            validaciones.ValidarCampoV(txt_password, lbl_error_cont, "El campo supera los 10 caracteres", 5000)
            Return
        ElseIf txt_password.Text.Length > 12 Then
            validaciones.ValidarCampoV(txt_password, lbl_error_cont, "El campo supera los 10 caracteres", 5000)
            Return
        ElseIf txt_email.Text.Length > 50 Then
            validaciones.ValidarCampoV(txt_email, lbl_error_mail, "El campo supera los 50 caracteres", 5000)
            Return
        End If

        ' Llamar a la función de validación
        Dim resultado = validarIngreso(usuario, contras)

        If resultado IsNot Nothing Then
            exito = resultado(0)
            valores = resultado
        Else
            ' Credenciales no válidas
            MsgBox("Usuario o contraseña incorrectos por favor valide sus credenciales")
        End If

        If exito Then

            Dim cargue As New cargue()
            ' Credenciales válidas, realizar operaciones aquí
            MsgBox("Credenciales válidas")
            cargue.Show()
            cargue.recibirValores(valores)

            Me.Close()
        Else
            ' Credenciales no válidas
            MsgBox("Credenciales no válidas")
        End If
    End Sub

    Public Function validarIngreso(ByVal usuario As String, ByVal contra As String) As String()
        Dim conn As OdbcConnection = ObtenerCadenaConexion.conexion()
        Dim valores(5) As String

        If conn Is Nothing Then
            ' No se pudo obtener la conexión
            Return Nothing
        End If

        ' Abre la conexión
        conn.Open()

        Try
            Dim callProcedure As New OdbcCommand("CALL sp_login('" & usuario & "' , '" & contra & "')", conn)
            callProcedure.CommandType = CommandType.StoredProcedure

            Dim reader As OdbcDataReader = callProcedure.ExecuteReader()

            If reader.Read() Then
                ' Leer y almacenar los valores resultantes en el array
                valores(0) = "True" ' Supongamos que el primer valor indica éxito
                valores(1) = reader.GetString(0) 'usuario
                valores(2) = reader.GetString(1) 'contraseña
                valores(3) = reader.GetString(2) 'rol
                valores(4) = reader.GetString(3) 'ruta
                valores(5) = reader.GetString(4) 'descripcion
                Return valores
            Else
                Return Nothing
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error de conexión a la base de datos: " & ex.Message)
        Finally
            ' Asegúrate de cerrar la conexión cuando hayas terminado
            conn.Close()
        End Try


    End Function
End Class
