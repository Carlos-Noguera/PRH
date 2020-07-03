
Imports System.Collections.ObjectModel
Imports PRHServiceLibrary.Data.AvisosAusencia
Imports PRHServiceLibrary.Data.Login
Imports PRHServiceLibrary.Data.MotivoAviso

Namespace Model.AvisosAusencia

    <ServiceContract> Public Interface IAvisosAusencia

        <OperationContract> Function GetAvisos(ByVal NUMERO As Integer, ByVal MOTIVO As String) As ObservableCollection(Of ObjAvisosAusencia)

        <OperationContract> Sub UpdateAviso(ByVal aviso As ObjAvisosAusencia)

        <OperationContract> Function InsertAviso(ByVal nuevo As ObjAvisosAusencia) As String

        <OperationContract> Function DeleteAviso(ByVal FOLIO As Integer)

        <OperationContract> Function GetMotivo() As ObservableCollection(Of ObjMotivoAviso)

        <OperationContract> Function GetEdoVac(ByVal NumeroEmpleado As Integer) As ObservableCollection(Of ObjAvisosAusencia)





    End Interface
End Namespace