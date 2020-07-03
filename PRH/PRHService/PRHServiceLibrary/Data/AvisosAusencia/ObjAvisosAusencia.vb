Imports System.Runtime.Serialization
Imports RISQ.Tools

Namespace Data.AvisosAusencia
    <DataContract> Public Class ObjAvisosAusencia
        <DataMember> <Mapping(Column:="FOLIO")> Property Folio As Int64
        <DataMember> <Mapping(Column:="NUMERO")> Property Numero As Int32
        <DataMember> <Mapping(Column:="NOMBRE")> Property Nombre As String
        <DataMember> <Mapping(Column:="FECHA")> Property Fecha As String
        <DataMember> <Mapping(Column:="EXPIRA")> Property Expira As String
        <DataMember> <Mapping(Column:="CTRO_CTO")> Property CtroCto As String
        <DataMember> <Mapping(Column:="PUESTO")> Property Puesto As Double
        <DataMember> <Mapping(Column:="FECHA_I")> Property FechaI As String
        <DataMember> <Mapping(Column:="FECHA_F")> Property FechaF As String
        <DataMember> <Mapping(Column:="INTERVALO")> Property Intervalo As String
        <DataMember> <Mapping(Column:="DIAS")> Property Dias As Double
        <DataMember> <Mapping(Column:="MOTIVO")> Property Motivo As String
        <DataMember> <Mapping(Column:="CICLO")> Property Ciclo As String
        <DataMember> <Mapping(Column:="CONDICS")> Property Condics As String
        <DataMember> <Mapping(Column:="AUTORIZA")> Property Autoriza As String
        <DataMember> <Mapping(Column:="OBSERV1")> Property Observ1 As String
        <DataMember> <Mapping(Column:="OBSERV2")> Property Observ2 As String
        <DataMember> <Mapping(Column:="STATUS")> Property Status As String
        <DataMember> <Mapping(Column:="LOC")> Property Loc As String



    End Class
End Namespace