Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports PRHServiceLibrary.Data.AvisosAusencia
Imports PRHServiceLibrary.Data.MotivoAviso
Imports PRHServiceLibrary.Model.AvisosAusencia
Imports RISQ.Tools
Imports RISQ.Utilities.Extensions

Namespace Controller.AvisosAusencia

    Public Class AvisosAusenciaImpl
        Inherits Connector
        Implements IAvisosAusencia
        Public Sub New(ByVal sql As SqlConnection)
            MCnn = sql
        End Sub

        Public Sub UpdateAviso(aviso As ObjAvisosAusencia) Implements IAvisosAusencia.UpdateAviso
            Const store As String = "spPRH_ActualizarAviso"
            Dim comando As New SqlCommand(store, MCnn)
            comando.Parameters.Add("@FOLIO", SqlDbType.Int).Value = aviso.Folio
            comando.Parameters.Add("@NUMERO", SqlDbType.Int).Value = aviso.Numero
            comando.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = aviso.Nombre
            comando.Parameters.Add("@EXPIRA", SqlDbType.Date).Value = Date.Parse(aviso.Expira)
            comando.Parameters.Add("@CTRO_CTO", SqlDbType.NVarChar).Value = aviso.CtroCto
            comando.Parameters.Add("@PUESTO", SqlDbType.Float).Value = aviso.Puesto
            comando.Parameters.Add("@FECHA", SqlDbType.Date).Value = Date.Parse(aviso.Fecha)
            comando.Parameters.Add("@FECHA_I", SqlDbType.Date).Value = Date.Parse(aviso.FechaI)
            comando.Parameters.Add("@FECHA_F", SqlDbType.Date).Value = Date.Parse(aviso.FechaF)
            comando.Parameters.Add("@INTERVALO", SqlDbType.NVarChar).Value = aviso.Intervalo
            comando.Parameters.Add("@DIAS", SqlDbType.Float).Value = aviso.Dias
            comando.Parameters.Add("@MOTIVO", SqlDbType.NVarChar).Value = aviso.Motivo
            comando.Parameters.Add("@CICLO", SqlDbType.NVarChar).Value = aviso.Ciclo
            comando.Parameters.Add("@CONDICS", SqlDbType.NVarChar).Value = aviso.Condics
            comando.Parameters.Add("@AUTORIZA", SqlDbType.NVarChar).Value = aviso.Autoriza
            comando.Parameters.Add("@OBSERV1", SqlDbType.NVarChar).Value = aviso.Observ1
            comando.Parameters.Add("@OBSERV2", SqlDbType.NVarChar).Value = aviso.Observ2
            comando.Parameters.Add("@STATUS", SqlDbType.NVarChar).Value = aviso.Status
            comando.Parameters.Add("@LOC", SqlDbType.NVarChar).Value = aviso.Loc
            ExecStore(comando, (New StackFrame()).GetMethod().Name, store)
        End Sub

        Public Function DeleteAviso(FOLIO As Integer) As Object Implements IAvisosAusencia.DeleteAviso
            Dim result As String
            result = ""
            Const store As String = "spPRH_EliminarAviso"
            Dim comando As New SqlCommand(store, MCnn)
            comando.Parameters.Add("@FOLIO", SqlDbType.BigInt).Value = FOLIO
            ExecStore(comando, (New StackFrame()).GetMethod().Name, store)
            result = "correcto"
            Return result
        End Function

        Public Function InsertAviso(nuevo As ObjAvisosAusencia) As String Implements IAvisosAusencia.InsertAviso
            Dim result As String = ""

            Const store As String = "spPRH_InsertarAviso"
            Dim comando As New SqlCommand(store, MCnn)

            comando.Parameters.Add("@NUMERO", SqlDbType.Int).Value = nuevo.Numero
            comando.Parameters.Add("@NOMBRE", SqlDbType.NVarChar).Value = nuevo.Nombre
            comando.Parameters.Add("@EXPIRA", SqlDbType.Date).Value = Date.Parse(nuevo.Expira)
            comando.Parameters.Add("@CTRO_CTO", SqlDbType.NVarChar).Value = nuevo.CtroCto
            comando.Parameters.Add("@PUESTO", SqlDbType.Float).Value = nuevo.Puesto
            comando.Parameters.Add("@FECHA", SqlDbType.Date).Value = Date.Parse(nuevo.Fecha)
            comando.Parameters.Add("@FECHA_I", SqlDbType.Date).Value = Date.Parse(nuevo.FechaI)
            comando.Parameters.Add("@FECHA_F", SqlDbType.Date).Value = Date.Parse(nuevo.FechaF)
            comando.Parameters.Add("@INTERVALO", SqlDbType.NVarChar).Value = nuevo.Intervalo
            comando.Parameters.Add("@DIAS", SqlDbType.Float).Value = nuevo.Dias
            comando.Parameters.Add("@MOTIVO", SqlDbType.NVarChar).Value = nuevo.Motivo
            comando.Parameters.Add("@CICLO", SqlDbType.NVarChar).Value = nuevo.Ciclo
            comando.Parameters.Add("@CONDICS", SqlDbType.NVarChar).Value = nuevo.Condics
            comando.Parameters.Add("@AUTORIZA", SqlDbType.NVarChar).Value = nuevo.Autoriza
            comando.Parameters.Add("@OBSERV1", SqlDbType.NVarChar).Value = nuevo.Observ1
            comando.Parameters.Add("@OBSERV2", SqlDbType.NVarChar).Value = nuevo.Observ2
            comando.Parameters.Add("@STATUS", SqlDbType.NVarChar).Value = nuevo.Status
            comando.Parameters.Add("@LOC", SqlDbType.NVarChar).Value = nuevo.Loc
            ExecStore(comando, (New StackFrame()).GetMethod().Name, store)
            result = "correcto"



            Return result
        End Function

        Public Function GetAvisos(NUMERO As Integer, MOTIVO As String) As ObservableCollection(Of ObjAvisosAusencia) Implements IAvisosAusencia.GetAvisos

            Dim result As ObservableCollection(Of ObjAvisosAusencia)
            Const store As String = "spPRH_AvisosAusencia"
            Dim comando As New SqlCommand(store, MCnn)
            comando.Parameters.Add("@NUMERO", SqlDbType.Int).Value = NUMERO
            comando.Parameters.Add("@MOTIVO", SqlDbType.NVarChar).Value = MOTIVO

            result = ExecStore(comando, (New StackFrame()).GetMethod().Name, store).Tables(0).ToObservableCollection(Of ObjAvisosAusencia)()
            Return result

        End Function

        Public Function GetMotivo() As ObservableCollection(Of ObjMotivoAviso) Implements IAvisosAusencia.GetMotivo
            Dim result As ObservableCollection(Of ObjMotivoAviso)
            Const store As String = "spPRH_MotivoAviso"
            Dim comando As New SqlCommand(store, MCnn)

            result = ExecStore(comando, (New StackFrame()).GetMethod().Name, store).Tables(0).ToObservableCollection(Of ObjMotivoAviso)()
            Return result
        End Function

        Public Function GetEdoVac(NumeroEmpleado As Integer) As ObservableCollection(Of ObjAvisosAusencia) Implements IAvisosAusencia.GetEdoVac
            Dim result As ObservableCollection(Of ObjAvisosAusencia)
            Const store As String = "spPRH_GetEdoVac"
            Dim comando As New SqlCommand(store, MCnn)
            comando.Parameters.Add("@NUMERO", SqlDbType.Int).Value = NumeroEmpleado
            result = ExecStore(comando, (New StackFrame()).GetMethod().Name, store).Tables(0).ToObservableCollection(Of ObjAvisosAusencia)()
            Return result
        End Function
    End Class
End Namespace