Imports PRH.PRHService

Public Class MiPerfil
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Session("usu") = Nothing) Then
            Response.Redirect("Login.aspx")

        End If

        InfoPersonal()

    End Sub
    Public Sub InfoPersonal()

        Dim user As New ObjPersonal
        user = Session("usuObj")

        'TAB DE DATOS PERSONALES
        TxtNombre.Text = user.Nombres
        TxtPaterno.Text = user.Paterno
        TxtMaterno.Text = user.Materno
        TxtSexo.Text = user.SEXI_DESC

        TxtFecha_Nac.Text = user.FechaNac
        TxtEdo_Civil.Text = user.EDO_CIVIL_DES
        TxtGpo_S.Text = user.GpoS
        TxtEscolaridad.Text = user.ESCOLARIDAD_DESC

        TxtTelefono.Text = user.Telefono
        TxtEmail.Text = user.Email
        TxtRfc.Text = user.RFc
        TxtCurp.Text = user.Curp

        TxtTalla_Pf.Text = user.TallaPf
        TxtTalla_Cv.Text = user.TallaCb

        'TAB DE DOMICILIO
        TxtCalle.Text = user.Calle
        TxtNum_E.Text = user.NumE
        TxtNum_I.Text = user.NumI
        TxtColonia.Text = user.Colonia
        TxtDel_Mun.Text = user.DelMun
        TxtEntidad.Text = user.Entidad
        TxtCp.Text = user.Cp

        'TAB DE SEGURO
        TxtI_M_S_S.Text = user.IMss
        TxtClinica.Text = user.Clinica
        TxtAfore.Text = user.Afore

        'TAB LABORAL
        TxtFechaIngr.Text = user.FechaIng
        TxtFechaCaja.Text = user.FechaCaja
        TxtFechaEgr.Text = user.FechaEgr
        TxtFechaAnt.Text = user.FechaAnt
        TxtNumContrato.Text = user.NContrato
        TxtUbicacion.Text = user.UBICACION_DESC
        TxtLoc.Text = user.LOC_DESC


        'TAB BANCARIO
        TxtNumCuenta.Text = user.NCuenta
        TxtNumBanco.Text = user.NBanco
        TxtCuentaProm.Text = user.CtaPromex

        'TAB SALARIO
        TxtSDI.Text = user.SDi
        TxtCP90.Text = user.CuotaNpos90
        TexboxContrato.Text = user.CONTRATO_DESC


    End Sub


End Class