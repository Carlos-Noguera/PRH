Imports System.Collections.ObjectModel
Imports PRHServiceLibrary.Data.Login

Namespace Model.Login

    <ServiceContract> Public Interface ILogin

        <OperationContract> Function Login(ByVal usuario As String, ByVal contrasenia As String) As ObjLogin

    End Interface
End Namespace