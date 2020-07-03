Imports System.Runtime.Serialization
Imports RISQ.Tools

Namespace Data.Personal

    <DataContract> Public Class ObjPersonal
        <DataMember> <Mapping(Column:="NUMERO")> Property Numero As Int32
        <DataMember> <Mapping(Column:="NUMERO_OLD")> Property NumeroOld As Int32
        <DataMember> <Mapping(Column:="NOMBRE")> Property Nombre As String
        <DataMember> <Mapping(Column:="PATERNO")> Property Paterno As String
        <DataMember> <Mapping(Column:="MATERNO")> Property Materno As String
        <DataMember> <Mapping(Column:="NOMBRES")> Property Nombres As String
        <DataMember> <Mapping(Column:="EDO_CIVIL")> Property EdoCivil As Double
        <DataMember> <Mapping(Column:="GPO_S")> Property GpoS As String
        <DataMember> <Mapping(Column:="SEXO")> Property Sexo As String
        <DataMember> <Mapping(Column:="FECHA_NAC")> Property FechaNac As String
        <DataMember> <Mapping(Column:="L_NAC")> Property LNac As Double
        <DataMember> <Mapping(Column:="FECHA_ING")> Property FechaIng As String
        <DataMember> <Mapping(Column:="FECHA_CAJA")> Property FechaCaja As String
        <DataMember> <Mapping(Column:="FECHA_EGR")> Property FechaEgr As String
        <DataMember> <Mapping(Column:="FECHA_ANT")> Property FechaAnt As String
        <DataMember> <Mapping(Column:="TALLA_PF")> Property TallaPf As Int16
        <DataMember> <Mapping(Column:="TALLA_CB")> Property TallaCb As Int16
        <DataMember> <Mapping(Column:="I_M_S_S")> Property IMss As String
        <DataMember> <Mapping(Column:="CLINICA")> Property Clinica As String
        <DataMember> <Mapping(Column:="AFORE")> Property Afore As String
        <DataMember> <Mapping(Column:="TIPO_TRAB")> Property TipoTrab As String
        <DataMember> <Mapping(Column:="R_F_C")> Property RFc As String
        <DataMember> <Mapping(Column:="CURP")> Property Curp As String
        <DataMember> <Mapping(Column:="CARTILLA")> Property Cartilla As String
        <DataMember> <Mapping(Column:="N_PADRE")> Property NPadre As String
        <DataMember> <Mapping(Column:="N_MADRE")> Property NMadre As String
        <DataMember> <Mapping(Column:="N_CUENTA")> Property NCuenta As String
        <DataMember> <Mapping(Column:="N_BANCO")> Property NBanco As String
        <DataMember> <Mapping(Column:="CTA_PROMEX")> Property CtaPromex As String
        <DataMember> <Mapping(Column:="CTA_BNM")> Property CtaBnm As String
        <DataMember> <Mapping(Column:="CTA_BCH")> Property CtaBch As String
        <DataMember> <Mapping(Column:="N_CONTRATO")> Property NContrato As Double
        <DataMember> <Mapping(Column:="NCREDINFO")> Property Ncredinfo As String
        <DataMember> <Mapping(Column:="PORPAGINFO")> Property Porpaginfo As Decimal
        <DataMember> <Mapping(Column:="CASA_O_EDI")> Property CasaOedi As String
        <DataMember> <Mapping(Column:="FECHAINID")> Property Fechainid As String
        <DataMember> <Mapping(Column:="S_D_I")> Property SDi As Decimal
        <DataMember> <Mapping(Column:="SDI_INFO")> Property SdiInfo As Decimal
        <DataMember> <Mapping(Column:="UBICACION")> Property Ubicacion As Byte
        <DataMember> <Mapping(Column:="LOC")> Property Loc As String
        <DataMember> <Mapping(Column:="CTRO_CTO")> Property CtroCto As String
        <DataMember> <Mapping(Column:="PUESTO")> Property Puesto As Int16
        <DataMember> <Mapping(Column:="PTO_PLAN")> Property PtoPlan As String
        <DataMember> <Mapping(Column:="FECHA_PTO")> Property FechaPto As String
        <DataMember> <Mapping(Column:="GDO")> Property Gdo As Byte
        <DataMember> <Mapping(Column:="POS_N")> Property PosN As Byte
        <DataMember> <Mapping(Column:="CUOTA_N")> Property CuotaN As Decimal
        <DataMember> <Mapping(Column:="POS_G")> Property PosG As Byte
        <DataMember> <Mapping(Column:="CUOTA_G")> Property CuotaG As Decimal
        <DataMember> <Mapping(Column:="HSM")> Property Hsm As Byte
        <DataMember> <Mapping(Column:="TAB")> Property Tab As String
        <DataMember> <Mapping(Column:="JORNADA")> Property Jornada As String
        <DataMember> <Mapping(Column:="JORNADAP")> Property Jornadap As Decimal
        <DataMember> <Mapping(Column:="CONTRATO")> Property Contrato As String
        <DataMember> <Mapping(Column:="FECHA_T")> Property FechaT As String
        <DataMember> <Mapping(Column:="OBRA")> Property Obra As String
        <DataMember> <Mapping(Column:="OBRA1")> Property Obra1 As String
        <DataMember> <Mapping(Column:="OBRA2")> Property Obra2 As String
        <DataMember> <Mapping(Column:="OBRA3")> Property Obra3 As String
        <DataMember> <Mapping(Column:="HORARIO")> Property Horario As String
        <DataMember> <Mapping(Column:="DIR1")> Property Dir1 As String
        <DataMember> <Mapping(Column:="DIR2")> Property Dir2 As String
        <DataMember> <Mapping(Column:="CALLE")> Property Calle As String
        <DataMember> <Mapping(Column:="NUM_E")> Property NumE As String
        <DataMember> <Mapping(Column:="NUM_I")> Property NumI As String
        <DataMember> <Mapping(Column:="COLONIA")> Property Colonia As String
        <DataMember> <Mapping(Column:="DEL_MUN")> Property DelMun As String
        <DataMember> <Mapping(Column:="ENTIDAD")> Property Entidad As String
        <DataMember> <Mapping(Column:="CP")> Property Cp As String
        <DataMember> <Mapping(Column:="TELEFONO")> Property Telefono As String
        <DataMember> <Mapping(Column:="ESCOLARIDAD")> Property Escolaridad As Int16
        <DataMember> <Mapping(Column:="DOCTO_ESCOLAR")> Property DoctoEscolar As String
        <DataMember> <Mapping(Column:="STATUS")> Property Status As String
        <DataMember> <Mapping(Column:="CAJA_B")> Property CajaB As String
        <DataMember> <Mapping(Column:="CAJA_F")> Property CajaF As String
        <DataMember> <Mapping(Column:="PARENTTIP")> Property Parenttip As Int16
        <DataMember> <Mapping(Column:="PARENTEMP")> Property Parentemp As String
        <DataMember> <Mapping(Column:="PARENTWHO")> Property Parentwho As String
        <DataMember> <Mapping(Column:="CLASE_RGO")> Property ClaseRgo As Int16
        <DataMember> <Mapping(Column:="SUCURSAL")> Property Sucursal As Int16
        <DataMember> <Mapping(Column:="SDI_VAR")> Property SdiVar As Decimal
        <DataMember> <Mapping(Column:="SDI_FIJO")> Property SdiFijo As Decimal
        <DataMember> <Mapping(Column:="SUA")> Property Sua As String
        <DataMember> <Mapping(Column:="CENTRO_T")> Property CentroT As Int32
        <DataMember> <Mapping(Column:="CAJA")> Property Caja As String
        <DataMember> <Mapping(Column:="TARJETA")> Property Tarjeta As String
        <DataMember> <Mapping(Column:="TIPO")> Property Tipo As String
        <DataMember> <Mapping(Column:="CUOTA_NPOS90")> Property CuotaNpos90 As Decimal
        <DataMember> <Mapping(Column:="PENSIONADO")> Property Pensionado As String
        <DataMember> <Mapping(Column:="CTRO_ORG")> Property CtroOrg As String
        <DataMember> <Mapping(Column:="EMAIL")> Property Email As String
        <DataMember> <Mapping(Column:="EMAILI")> Property Emaili As String
        <DataMember> <Mapping(Column:="CUENTABANORTE")> Property Cuentabanorte As String
        <DataMember> <Mapping(Column:="USERPASSWORD")> Property Userpassword As String


        <DataMember> <Mapping(Column:="EDO_CIVIL_DES")> Property EDO_CIVIL_DES As String
        <DataMember> <Mapping(Column:="SEXO_DESC")> Property SEXI_DESC As String
        <DataMember> <Mapping(Column:="CTRO_CTO_DESC")> Property CTRO_CTO_DESC As String
        <DataMember> <Mapping(Column:="UBICACION_DESC")> Property UBICACION_DESC As String

        <DataMember> <Mapping(Column:="LOC_DESC")> Property LOC_DESC As String

        <DataMember> <Mapping(Column:="ESCOLARIDAD_DESC")> Property ESCOLARIDAD_DESC As String
        <DataMember> <Mapping(Column:="CONTRATO_DESC")> Property CONTRATO_DESC As String

        <DataMember> <Mapping(Column:="PUESTO_DES")> Property PustoDescrip As String

        <DataMember> <Mapping(Column:="SUCURSAL_DESC")> Property SUCURSAL_DESC As String





    End Class
End Namespace

