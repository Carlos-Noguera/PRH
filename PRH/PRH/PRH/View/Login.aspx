<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="PRH.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="Resources/css/EstiloLogin.css"/>

    <title>Iniciar Sesión</title>
</head>
<body>
        <header >
            <h1 class="container-fluid ">
               PORTAL DE RECURSOS HUMANOS
            </h1> 
        </header>
    <form id="form1" runat="server">
        

                    <div class="back">
                      <div class="div-center">
                        <div class="content">
                          <h3>Iniciar Sesion</h3>
                          <hr />
                        
                            <div class="form-group">

                             <asp:TextBox ID="TxtUser" CssClass="form-control" Width="250px" placeholder="USUARIO" runat="server" BackColor="WindowFrame"></asp:TextBox>
                            </div>
                            <div class="form-group">
                             
                                <asp:TextBox ID="TxtPass" CssClass="form-control" Width="250px" placeholder="USUARIO" runat="server" BackColor="WindowFrame"></asp:TextBox>
                            </div>
                         
                            <hr />
                            <asp:Button class="btn btn-info" ID="BtnCancelar" runat="server" Text="Cancelar" BackColor="#339966" />
                            <asp:Button class="btn btn-info" ID="BtnAceptar" runat="server" Text="Aceptar" BackColor="#00CC00"/>

                        </div>
                      </div>
                    </div>









     
    </form>
</body>
</html>
