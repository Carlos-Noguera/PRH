Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports PRHServiceLibrary.Data.Personal
Imports PRHServiceLibrary.Model.Personal
Imports RISQ.Tools
Imports RISQ.Utilities.Extensions

Namespace Controller.Personal

    Public Class PersonalImpl
        Inherits Connector
        Implements IPersonal

        Public Sub New(ByVal sql As SqlConnection)
            MCnn = sql
        End Sub


        Public Function GetPersonal(NUMERO As String) As ObjPersonal Implements IPersonal.GetPersonal
            Dim result As ObservableCollection(Of ObjPersonal)
            Const store As String = "spPRH_GetPersonal"
            Dim comando As New SqlCommand(store, MCnn)
            comando.Parameters.Add("@NUMERO", SqlDbType.Int).Value = NUMERO
            result = ExecStore(comando, (New StackFrame()).GetMethod().Name, store).Tables(0).ToObservableCollection(Of ObjPersonal)()

            Return result(0)

        End Function
    End Class
End Namespace