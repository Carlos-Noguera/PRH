Imports System.Collections.ObjectModel
Imports PRHServiceLibrary.Data.Personal

Namespace Model.Personal

    <ServiceContract> Public Interface IPersonal
        <OperationContract> Function GetPersonal(ByVal NUMERO As String) As ObjPersonal

    End Interface
End Namespace