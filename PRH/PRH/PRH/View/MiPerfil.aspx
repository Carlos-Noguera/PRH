<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="MiPerfil.aspx.vb" Inherits="PRH.MiPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="MI PERFIL"></asp:Label>
                                                      <!--TABS DE PERFIL-->
    <ul class="nav nav-tabs" id="myTab" role="tablist">    
          <li class="nav-item">
            <a class="nav-link" id="DatosPer-tab" data-toggle="tab" href="#DatosPer" role="tab" aria-controls="DatosPer" aria-selected="false">Datos Personales</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" id="Domicilio-tab" data-toggle="tab" href="#Domicilio" role="tab" aria-controls="Domicilio" aria-selected="false">Domicilio</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" id="Seguro-tab" data-toggle="tab" href="#Seguro" role="tab" aria-controls="Seguro" aria-selected="false">Seguro</a>
          </li>
          <li class="nav-item">
              <a class="nav-link" id="Laboral-tab" data-toggle="tab" href="#Laboral" role="tab" aria-controls="Laboral" aria-selected="false">Laboral</a>
          </li>
          <li class="nav-item">
              <a class="nav-link" id="Bancario-tab" data-toggle="tab" href="#Bancario" role="tab" aria-controls="Bancario" aria-selected="false">Bancario</a>
          </li>          
    </ul>
                
                                            <!--TAB DE DATOS PERSONALES-->

<div class="tab-content" id="myTabContent">
      <div class="tab-pane fade show active" id="DatosPer" role="tabpanel" aria-labelledby="contact-tab">
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label2" runat="server" Text="Nombre: " ReadOnly="true" Font-Bold="True" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtNombre" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" runat="server"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label3" runat="server" Text="Apellido Paterno: " Font-Bold="True" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtPaterno" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" runat="server" ReadOnly="true"></asp:TextBox>
              </div>       
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label4" runat="server" Text="Apellido Materno: " Font-Bold="True" ForeColor="#006666">
                  </asp:Label><asp:TextBox ID="TxtMaterno" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label15" runat="server" Text="Sexo: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtSexo" CssClass="form-control"  Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label9" runat="server" Text="Fecha de Nac.: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtFecha_Nac" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label10" runat="server" Text="Estado Civil: " Font-Bold="True" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtEdo_Civil" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label14" runat="server" Text="Grupo Sanuguinio: " Font-Bold="True" ForeColor="#006666"> </asp:Label>
                  
                  <asp:TextBox ID="TxtGpo_S" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label29" runat="server" Text="Escolaridad: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtEscolaridad" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label7" runat="server" Text="Teléfono: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtTelefono" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label8" runat="server" Text="E-mail: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtEmail" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge" runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label21" runat="server" Text="RFC: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtRfc" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label11" runat="server" Text="CURP: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtCurp" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label16" runat="server" Text="Talla PF: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtTalla_Pf" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">                                
                <asp:Label ID="Label17" runat="server" Text="Talla CV: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtTalla_Cv" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>            
              </div>
          </div>
      </div>

                                                    <!--TAB DE DOMICILIO-->

      <div class="tab-pane fade" id="Domicilio" role="tabpanel" aria-labelledby="contact-tab">
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label23" runat="server" Text="Calle: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtCalle" CssClass="form-control" Height="25px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label24" runat="server" Text="Número Exterior: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtNum_E" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label25" runat="server" Text="Número Interior: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtNum_I" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label22" runat="server" Text="Colonia: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtColonia" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label26" runat="server" Text="Dele y/o Muni: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtDel_Mun" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label27" runat="server" Text="Entidad: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtEntidad" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label28" runat="server" Text="CP: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtCp" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
      </div>

                                                      <!--TAB DE SEGURO-->

      <div class="tab-pane fade" id="Seguro" role="tabpanel" aria-labelledby="contact-tab">
          <div class="form-row">
              <div class="col-sm-12	col-md-4	col-lg-4 col-xl-4 ">
                 <asp:Label ID="Label18" runat="server" Text="IMSS: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtI_M_S_S" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-4	col-lg-4	col-xl-4 ">
                  <asp:Label ID="Label19" runat="server" Text="Clinica: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtClinica" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-4	col-lg-4	col-xl-4 ">
                   <asp:Label ID="Label20" runat="server" Text="Afore: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtAfore" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
      </div>

                                                        <!--TAB LABORAL-->

      <div class="tab-pane fade" id="Laboral" role="tabpanel" aria-labelledby="contact-tab">
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                 <asp:Label ID="Label5" runat="server" Text="Fexha de Ingreso: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtFechaIngr" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label6" runat="server" Text="Fecha de Caja: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtFechaCaja" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                   <asp:Label ID="Label12" runat="server" Text="Fecha de Egreso: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtFechaEgr" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label13" runat="server" Text="Fecha de Ant.: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtFechaAnt" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label30" runat="server" Text="No. de Contrato: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtNumContrato" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label41" runat="server" Text="Ubicación: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtUbicacion" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label34" runat="server" Text="Localidad: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtLoc" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
               <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                 <asp:Label ID="Label36" runat="server" Text="SDI: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                   <asp:TextBox ID="TxtSDI" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label37" runat="server" Text="Cuota pos 90: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtCP90" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                   <asp:Label ID="Label38" runat="server" Text="SBC: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtSBC" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
      </div>

                                                            <!--TAB BANCARIO-->

      <div class="tab-pane fade" id="Bancario" role="tabpanel" aria-labelledby="contact-tab">
          <div class="form-row">
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                 <asp:Label ID="Label31" runat="server" Text="No. de cuenta: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtNumCuenta" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                  <asp:Label ID="Label32" runat="server" Text="No. de banco: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtNumBanco" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
              <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                   <asp:Label ID="Label33" runat="server" Text="Cuenta Promo: " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                  <asp:TextBox ID="TxtCuentaProm" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
               <div class="col-sm-12	col-md-3	col-lg-3	col-xl-3 ">
                   <asp:Label ID="Label35" runat="server" Text="Contrato " Font-Bold="True" Font-Italic="False" ForeColor="#006666"></asp:Label>
                   <asp:TextBox ID="TexboxContrato" CssClass="form-control" Height="25px" BorderWidth="1px" BorderStyle="Ridge"  runat="server" ReadOnly="true"></asp:TextBox>
              </div>
          </div>
          </div>
    </div>

  
</asp:Content>
