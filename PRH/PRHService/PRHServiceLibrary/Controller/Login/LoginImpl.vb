Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports PRHServiceLibrary.Data.Login
Imports PRHServiceLibrary.Model.Login
Imports RISQ.Tools
Imports RISQ.Utilities.Extensions

Namespace Controller.Login

    Public Class LoginImpl
        Inherits Connector
        Implements ILogin

        Public Sub New(ByVal sql As SqlConnection)
            MCnn = sql
        End Sub

        Public Function Login(usuario As String, contrasenia As String) As ObjLogin Implements ILogin.Login

            Dim result As ObservableCollection(Of ObjLogin)
            Const store As String = "spPRH_Login"
            Dim comando As New SqlCommand(store, MCnn)
            comando.Parameters.Add("@NUMERO", SqlDbType.Int).Value = usuario
            comando.Parameters.Add("@USERPASSWORD", SqlDbType.NVarChar).Value = contrasenia
            result = ExecStore(comando, (New StackFrame()).GetMethod().Name, store).Tables(0).ToObservableCollection(Of ObjLogin)()

            If result.Count > 0 Then
                Return result(0)
            Else
                Return Nothing
            End If

        End Function
    End Class
End Namespace
