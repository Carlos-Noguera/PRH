Imports PRH.PRHService
Imports RISQ.Utilities.GenericFunctions
Public Class Login
    Inherits System.Web.UI.Page

    Private WithEvents _Login As New LoginClient
    Private WithEvents _cliente As New PersonalClient
    Private WithEvents _Avisos As New AvisosAusenciaClient


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim Usuario As String = TxtUser.Text

        Dim num As Integer = TxtUser.Text

        Dim Contrasenia As String = GetSHAHash(TxtPass.Text)

        If Not IsNumeric(Usuario) Then
            MsgBox("usuario y/o contraseña equivocado")
            TxtUser.Text = ""
            TxtPass.Text = ""
            TxtUser.Focus()

        Else

            Dim obJLogin As ObjLogin = _Login.Login(Usuario, Contrasenia)
            If obJLogin IsNot Nothing Then

                'Usuario es el numero
                Dim obj As ObjPersonal = _cliente.GetPersonal(obJLogin.Usuario)

                Session("usuObj") = obj
                Session("usu") = obj.Nombres

                Response.Redirect("Index.aspx")
            Else
                MsgBox("usuario y/o contraseña equivocado")
                TxtUser.Text = ""
                TxtPass.Text = ""
                TxtUser.Focus()

            End If
        End If

    End Sub




End Class