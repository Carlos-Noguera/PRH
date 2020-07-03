Imports System.Runtime.Serialization
Imports RISQ.Tools

Namespace Data.AvisosAusencia
    <DataContract> Public Class ObjEdoVac

        <DataMember> <Mapping(Column:="NUMERO")> Property Numero As Double
        <DataMember> <Mapping(Column:="CICLO")> Property Ciclo As String
        <DataMember> <Mapping(Column:="FECHA_DI")> Property FechaDi As DateTime
        <DataMember> <Mapping(Column:="FECHA_DF")> Property FechaDf As DateTime
        <DataMember> <Mapping(Column:="DIAS")> Property Dias As Double
        <DataMember> <Mapping(Column:="DIAS_DISF")> Property DiasDisf As Double

    End Class
End Namespace