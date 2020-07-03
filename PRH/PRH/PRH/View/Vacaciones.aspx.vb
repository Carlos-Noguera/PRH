
Imports PRH.PRHService
Public Class Vacaciones
    Inherits System.Web.UI.Page
    Private WithEvents _client As New AvisosAusenciaClient
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Session("usu") = Nothing) Then
            Response.Redirect("Login.aspx")

        End If

        AvisosAusencia()
        VisibleFalse()

    End Sub

    Public Sub VisibleFalse()
        PlDatos.Visible = False
        LbPasaFolio.Visible = False
        lbTipo.Visible = False
    End Sub
    'llena los datos de avisos ausencia y el  gridview
    Public Sub AvisosAusencia()


        Dim user As New ObjPersonal
        user = Session("usuObj")

        TxtNumTrabajador.Text = user.Numero
        TxtNombre.Text = user.Nombre
        TxtCentroCosto.Text = user.CtroCto
        TxtServiCentroCosto.Text = user.CTRO_CTO_DESC
        TxtPuesto.Text = user.Puesto
        TxtTipoPuesto.Text = user.PustoDescrip

        GridViewAvisosAusensia.DataSource = _client.GetAvisos(user.Numero, "VA")
        GridViewAvisosAusensia.DataBind()




    End Sub

    Private Sub GridViewAvisosAusensia_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GridViewAvisosAusensia.RowCommand

        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = GridViewAvisosAusensia.Rows(index)
        Dim obj As New ObjAvisosAusencia

        obj.Folio = row.Cells()(2).Text
        LbPasaFolio.Text = obj.Folio
        obj.Fecha = row.Cells()(3).Text
        obj.Ciclo = row.Cells()(4).Text
        obj.Expira = row.Cells()(5).Text
        obj.FechaI = row.Cells()(6).Text
        obj.FechaF = row.Cells(7).Text
        obj.Dias = row.Cells(8).Text
        obj.Motivo = row.Cells(9).Text
        obj.Condics = row.Cells(10).Text
        obj.Autoriza = row.Cells(11).Text
        obj.Observ1 = row.Cells(12).Text
        obj.Observ2 = row.Cells(13).Text
        obj.Status = row.Cells(14).Text

        If e.CommandName = "BtnEditar" Then

            TxtFecha.Text = Format(Now, "dd/MM/yyyy")
            TxtVigencia.Text = obj.Expira
            TxtInterInicial.Text = obj.FechaI
            TxtInterFinal.Text = obj.FechaF
            TxtDias.Text = obj.Dias
            TxtIntervalo.Text = obj.Intervalo
            TxtAutoriza.Text = obj.Autoriza
            TxtObservacion1.Text = obj.Observ1
            TxtObservacion2.Text = obj.Observ2
            TxtMotivo.Text = obj.Motivo
            TxtCondiciones.Text = obj.Condics
            lbTipo.Text = "E"
            PlDatos.Visible = True
            GridViewAvisosAusensia.Visible = False
            BtnAlta.Visible = False

        ElseIf e.CommandName = "BtnEliminar" Then

            _client.DeleteAviso(obj.Folio)

        End If
    End Sub


    Protected Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        BorrarAlta()
        lbTipo.Text = "A"
        BtnAlta.Visible = False
        GridViewAvisosAusensia.Visible = False
        PlDatos.Visible = True
        TxtFecha.Text = Format(Now, "dd/MM/yyyy")
        TxtCondiciones.Text = "ACV- A cuenta de vacaciones"
        TxtMotivo.Text = "Vacaciones"
    End Sub

    Protected Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        BtnAlta.Visible = True
        GridViewAvisosAusensia.Visible = True
        PlDatos.Visible = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        validar()
        Dim objG As New ObjAvisosAusencia
        Dim user As New ObjPersonal
        user = Session("usuObj")

        objG.Nombre = TxtNombre.Text
        objG.CtroCto = TxtCentroCosto.Text

        objG.Ciclo = ""
        objG.Condics = TxtCondiciones.Text
        objG.Dias = TxtDias.Text
        objG.Expira = TxtVigencia.Text
        objG.Fecha = Format(Now, "dd/MM/yyyy")
        objG.FechaI = TxtInterInicial.Text
        objG.FechaF = TxtInterFinal.Text
        objG.Intervalo = TxtInterInicial.Text + " - " + TxtInterFinal.Text
        objG.Loc = user.Loc
        objG.Motivo = "VA"
        objG.Numero = user.Numero
        objG.Observ1 = TxtObservacion1.Text
        objG.Observ2 = TxtObservacion2.Text
        objG.Puesto = TxtPuesto.Text
        objG.Status = "A"

        If lbTipo.Text = "E" Then
            objG.Folio = LbPasaFolio.Text
            objG.Autoriza = TxtAutoriza.Text
            _client.UpdateAviso(objG)

        ElseIf lbTipo.Text = "A" Then
            objG.Autoriza = "CARLOS"
            objG.Status = "P"
            _client.UpdateAviso(objG)

        End If
        PlDatos.Visible = False
        GridViewAvisosAusensia.Visible = True
        BtnAlta.Visible = True
    End Sub


    Public Sub BorrarAlta()

        TxtFecha.Text = Nothing
        TxtVigencia.Text = Nothing
        TxtInterInicial.Text = Nothing
        TxtInterFinal.Text = Nothing
        TxtDias.Text = Nothing
        TxtIntervalo.Text = Nothing
        TxtAutoriza.Text = Nothing
        TxtObservacion1.Text = Nothing
        TxtObservacion2.Text = Nothing

    End Sub
    Public Sub validar()

        If TxtInterFinal.Text = Nothing Then
            MsgBox("FI")

        End If



    End Sub




End Class