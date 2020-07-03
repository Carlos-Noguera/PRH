Public Class Master
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If (Session("usu") = Nothing) Then
            Response.Redirect("Login.aspx")
        Else
            Dim usu = Session("usu").ToString
            LabelPerfil.Text = usu

        End If

    End Sub

    Protected Sub BtnCuenta_Click(sender As Object, e As EventArgs) Handles BtnMiCuenta.Click
        Response.Redirect("MiPerfil.aspx")
    End Sub

    Protected Sub BtnAvisosAusencia_Click(sender As Object, e As EventArgs) Handles BtnAvisosAusencia.Click
        Response.Redirect("AvisosAusencia.aspx")
    End Sub

    Protected Sub BtnDerechohabiente_Click(sender As Object, e As EventArgs) Handles BtnDerechohabiente.Click
        Response.Redirect("Derechohabiente.aspx")
    End Sub

    Protected Sub BtnRecibosNomina_Click(sender As Object, e As EventArgs) Handles BtnRecibosNomina.Click
        Response.Redirect("RecibosNomina.aspx")
    End Sub

    Protected Sub BtnVacaciones_Click(sender As Object, e As EventArgs) Handles BtnVacaciones.Click
        Response.Redirect("Vacaciones.aspx")
    End Sub

    Protected Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Session.RemoveAll()
        Response.Redirect("Login.aspx")
    End Sub
End Class