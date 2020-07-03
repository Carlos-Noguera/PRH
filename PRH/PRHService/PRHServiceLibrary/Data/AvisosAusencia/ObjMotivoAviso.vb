Imports System.Runtime.Serialization
Imports RISQ.Tools

Namespace Data.MotivoAviso

    Public Class ObjMotivoAviso


        <DataMember> <Mapping(Column:="COD")> Property Cod As String
        <DataMember> <Mapping(Column:="DESCRIP")> Property Descrip As String
        <DataMember> <Mapping(Column:="VAC")> Property Vac As String

    End Class
End Namespace


