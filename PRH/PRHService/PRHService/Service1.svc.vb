' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
' NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.vb en el Explorador de soluciones e inicie la depuración.
#Region "Imports"


Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Imports PRHServiceLibrary.Controller.Personal
Imports PRHServiceLibrary.Data.Personal
Imports PRHServiceLibrary.Model.Personal

Imports PRHServiceLibrary.Controller.AvisosAusencia
Imports PRHServiceLibrary.Data.AvisosAusencia
Imports PRHServiceLibrary.Model.AvisosAusencia

Imports PRHServiceLibrary.Controller.Login
Imports PRHServiceLibrary.Data.Login
Imports PRHServiceLibrary.Model.Login

Imports PRHServiceLibrary.Data.MotivoAviso
#End Region
Public Class Service1
    Implements IPersonal
    Implements IAvisosAusencia

    Implements ILogin


    Private ReadOnly _cnn As New SqlConnection(ConfigurationManager.ConnectionStrings("ConexionData").ConnectionString)



#Region "Login"
    Public Function Login(usuario As String, contrasenia As String) As ObjLogin Implements ILogin.Login

        Return New LoginImpl(_cnn).Login(usuario, contrasenia)

    End Function
#End Region

#Region "Personal"
    Public Function GetPersonal(ByVal NUMERO As String) As ObjPersonal Implements IPersonal.GetPersonal
        Return New PersonalImpl(_cnn).GetPersonal(NUMERO)
    End Function
#End Region

#Region "AvisosAusencia"
    Public Function GetAvisos(NUMERO As Integer, MOTIVO As String) As ObservableCollection(Of ObjAvisosAusencia) Implements IAvisosAusencia.GetAvisos
        Return New AvisosAusenciaImpl(_cnn).GetAvisos(NUMERO, MOTIVO)
    End Function

    Public Sub Actualizar(aviso As ObjAvisosAusencia) Implements IAvisosAusencia.UpdateAviso


        Dim resultado As New AvisosAusenciaImpl(_cnn)
        resultado.UpdateAviso(aviso)

    End Sub

    Public Function InsertAviso(nuevo As ObjAvisosAusencia) As String Implements IAvisosAusencia.InsertAviso

        Return New AvisosAusenciaImpl(_cnn).InsertAviso(nuevo)

    End Function



    Public Function DeleteAviso(FOLIO As Integer) As Object Implements IAvisosAusencia.DeleteAviso
        Return New AvisosAusenciaImpl(_cnn).DeleteAviso(FOLIO)

    End Function
    Public Function GetMotivo() As ObservableCollection(Of ObjMotivoAviso) Implements IAvisosAusencia.GetMotivo
        Return New AvisosAusenciaImpl(_cnn).GetMotivo()
    End Function

    Public Function GetEdoVac(NumeroEmpleado As Integer) As ObservableCollection(Of ObjAvisosAusencia) Implements IAvisosAusencia.GetEdoVac
        Return New AvisosAusenciaImpl(_cnn).GetEdoVac(NumeroEmpleado)
    End Function



#End Region






End Class
