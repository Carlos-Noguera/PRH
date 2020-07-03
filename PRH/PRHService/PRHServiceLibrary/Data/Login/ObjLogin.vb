Imports System.Runtime.Serialization
Imports RISQ.Tools

Namespace Data.Login

    <DataContract> Public Class ObjLogin
        <DataMember> <Mapping(Column:="NUMERO")> Property Usuario As Int32
        <DataMember> <Mapping(Column:="USERPASSWORD")> Property Contrasenia As String

    End Class

End Namespace
