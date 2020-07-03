<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="Vacaciones.aspx.vb" Inherits="PRH.Vacaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="AVISOS DE AUSENCIA"></asp:Label> 
    

            <asp:Label ID="lbTipo" runat="server" Text=""></asp:Label>

            <asp:Label ID="LbPasaFolio" runat="server" Text=""></asp:Label>

    <div class="badge-info">
        <br />
                                                <%-- NÚMERO DE TRABAJADOR --%>

   
        <div class="form-row"> 
            <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                <asp:Label ID="Label2" runat="server" Text="Número de Trabajador" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>

            </div>
            <div class="col-sm-12	col-md-1	col-lg-1	col-xl-1">
                <asp:TextBox ID="TxtNumTrabajador" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <br />

                                                <%-- NOMBRE --%>   

        <div class="form-row"> 
            <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                <asp:Label ID="Label3" runat="server" Text="Nombre" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
            </div>
            <div class="col-sm-12	col-md-9	col-lg-9	col-xl-9">
                <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <br />
                                                <%-- CENTRO DE COSTO --%>
    
        <div class="form-row"> 
            <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                <asp:Label ID="Label4" runat="server" Text="Centro de Costo" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
            </div>
            <div class="col-sm-12	col-md-1	col-lg-1	col-xl-1">
                <asp:TextBox ID="TxtCentroCosto" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-sm-12	col-md-8	col-lg-8	col-xl-8">
                <asp:TextBox ID="TxtServiCentroCosto" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
            </div>
        </div>
        <br />
         <%-- PUESTO --%>

        <div class="form-row"> 
            <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                <asp:Label ID="Label5" runat="server" Text="Puesto" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
            </div>
            <div class="col-sm-12	col-md-1	col-lg-1	col-xl-1">
                <asp:TextBox ID="TxtPuesto" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="col-sm-12	col-md-8	col-lg-8	col-xl-8">
                <asp:TextBox ID="TxtTipoPuesto" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
            </div>
              <br />
              <br />
        </div>
        </div>
      

         <%-- GRID --%>
 <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
    <Triggers>
      <asp:AsyncPostBackTrigger ControlID="GridViewAvisosAusensia" /> 
      <asp:AsyncPostBackTrigger ControlID="BtnGuardar" EventName="Click" /> 
      <asp:AsyncPostBackTrigger ControlID="BtnCancelar" EventName="Click" /> 
     </Triggers>

        <ContentTemplate >
            
           
            <asp:GridView ID="GridViewAvisosAusensia" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="3"  Style="width:100%;text-align:center" autogeneratecolumns="False" >

                    <Columns>
                       <asp:ButtonField ButtonType="Image" Text="Editar" HeaderText="Editar" ImageUrl="~/Resources/picture/Editar.png"  CommandName="BtnEditar" />
                       <asp:ButtonField ButtonType="Image" Text="Eliminar" HeaderText="Eliminar" ImageUrl="~/Resources/picture/Eliminar.png" CommandName="BtnEliminar" />
                       
                       <asp:BoundField DataField="Folio" HeaderText="Folio" />
                       <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                       <asp:BoundField DataField="Ciclo" HeaderText="Ciclo" />
                       <asp:BoundField DataField="Expira" HeaderText="Expira" />
                       <asp:BoundField DataField="FechaI" HeaderText="FechaI" />
                       <asp:BoundField DataField="FechaF" HeaderText="FechaF" />
                       <asp:BoundField DataField="Dias" HeaderText="Dias" />
                       <asp:BoundField DataField="Motivo" HeaderText="Motivo" />  
                       <asp:BoundField DataField="Condics" HeaderText="Condiciones" />  
                       <asp:BoundField DataField="Autoriza" HeaderText="Autoriza" />
                       <asp:BoundField DataField="Observ1" HeaderText="Observ1" />
                        <asp:BoundField DataField="Observ2" HeaderText="Observ2" />
                        <asp:BoundField DataField="Status" HeaderText="Status" />
   
                    </Columns>

                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#003399" BackColor="White" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />

                </asp:GridView>
           
                

        <%--FIN DEL GRID--%>
      
  

<%-- BOTON ALTA --%>
      
        <asp:Button ID="BtnAlta"  runat="server" Text="ALTA" Height="45px" Width="115px" ></asp:Button>
                                               <%-- GRID --%>
    <%--FIN DEL GRID--%>
                

                                               <%-- DATOS FECHA --%>
  
            <asp:Panel ID="PlDatos" runat="server">
          <div class="bg-light">
          <div class="form-row">
                 <div class="col-sm-12	col-md-1	col-lg-1	col-xl-1">
                    </div>
            
                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-center">
                        <asp:Label ID="Label11" runat="server" Text="Fecha"></asp:Label>
                    <div class="form-row">
                        <asp:TextBox ID="TxtFecha" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
                        </div>
                    </div>

                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-center">
                        <asp:Label ID="Label6" runat="server" Text="Vigencia"></asp:Label>
                    <div class="form-row">
                        <asp:TextBox ID="TxtVigencia" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="TxtVigencia_CalendarExtender" runat="server" BehaviorID="TxtVigencia_CalendarExtender" TargetControlID="TxtVigencia" Format="dd/MM/yyyy" />
                    </div>
                </div>
         
                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-center">
                        <asp:Label ID="Label7" runat="server" Text="Intervalo Inicial"></asp:Label>
                    <div class="form-row">
          
                        <asp:TextBox ID="TxtInterInicial" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="TxtInterInicial_CalendarExtender" runat="server" BehaviorID="TxtInterInicial_CalendarExtender" TargetControlID="TxtInterInicial" Format="dd/MM/yyyy"/>
                    </div>
                        </div>

                        <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-center">
                        <asp:Label ID="Label8" runat="server" Text="Intervalo Final"></asp:Label>
                    <div class="form-row">
                        <asp:TextBox ID="TxtInterFinal" runat="server" CssClass="form-control"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="TxtInterFinal_CalendarExtender" runat="server" BehaviorID="TxtInterFinal_CalendarExtender" TargetControlID="TxtInterFinal" Format="dd/MM/yyyy" />
                    </div>
                    </div>
            
                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-center">
                        <asp:Label ID="Label15" runat="server" Text="Días"></asp:Label>
                    <div class="form-row">
                        <asp:TextBox ID="TxtDias" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    </div>
              <div class="col-sm-12	col-md-1	col-lg-1	col-xl-1">
                    </div>
                </div>  
            <br />

                                                        <%-- INTERVALO --%>

                         <div class="form-row"> 
                                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                                        <asp:Label ID="Label9" runat="server" Text="Intervalo" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
                                    </div>
                                    <div class="col-sm-12	col-md-9	col-lg-9	col-xl-9">
                                        <asp:TextBox ID="TxtIntervalo" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                                                        <%-- MOTIVO --%>

                                    <div class="form-row"> 
                                        <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                                            <asp:Label ID="LblMotivo" runat="server" Text="Motivo" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
                                        </div>
                                        <div class="col-sm-12	col-md-5	col-lg-5	col-xl-5">
                                        <asp:TextBox ID="TxtMotivo" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <br />


                                                        <%-- CONDICIONES --%>
                                   <div class="form-row"> 
                                       <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                                        <asp:Label ID="LblCondiciones" runat="server" Text="Condiciones" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
                                    </div>
                                    <div class="col-sm-12	col-md-5	col-lg-5	col-xl-5">
                                        <asp:TextBox ID="TxtCondiciones" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>
                                <br />

                                                        <%-- AUTORIZA --%>

                                <div class="form-row"> 
                                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                                        <asp:Label ID="LblAutoriza" runat="server" Text="Autoriza" ReadOnly="true" Font-Bold="True" ForeColor="#006666" ></asp:Label>
                                    </div>
                                    <div class="col-sm-12	col-md-9	col-lg-9	col-xl-9">
                                        <asp:TextBox ID="TxtAutoriza" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="true"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
        
                                                        <%-- OBSERVACIONES --%>

                                <div class="form-row"> 
                                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                                        <asp:Label ID="LblObservacion1" runat="server" Text="Observación 1" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
                                    </div>
                                    <div class="col-sm-12	col-md-9	col-lg-9	col-xl-9">
                                        <asp:TextBox ID="TxtObservacion1" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="False"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                                <div class="form-row"> 
                                    <div class="col-sm-12	col-md-2	col-lg-2	col-xl-2 text-right">
                                        <asp:Label ID="LblObservacion2" runat="server" Text="Observación 2" ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
                                    </div>
                                    <div class="col-sm-12	col-md-9	col-lg-9	col-xl-9">
                                        <asp:TextBox ID="TxtObservacion2" runat="server" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" ReadOnly="False"></asp:TextBox>
                                    </div>
                                </div>
                                 <br />

              <%-- BOTONES GUARDAR/CANCELAR --%>   
                <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" />
                <asp:Button ID="BtnGuardar" runat="server" Text="Guardar"  />
      
              <br />
              </div>
        </asp:Panel>

        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
