<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PresentacionFinal.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <h1>Crea tu Perfil !</h1>

    <div class="row">
        <div class="col-4">

            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
                <asp:RegularExpressionValidator ErrorMessage="formato de email  requerido" ControlToValidate="txtEmail" runat="server" type="Email" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" />

            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="el nombre es requerido " MinimumValue="2" MaximumValue="20" ControlToValidate="txtNombre" runat="server" />

            </div>
            <div class="mb-3">
                <label for="txtApellido" class="form-label">Apellido</label>
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="el apellido es requerido " MinimumValue="2" MaximumValue="10" ControlToValidate="txtApellido" runat="server" />


            </div>

            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
                <a href="WebForm1.aspx">Cancelar</a>
            </div>

        </div>
        <div class="col-6">


            <asp:UpdatePanel ID="UpdatePannel1" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label class="form-label">Url Imagen</label>
                        <input type="file" id="txtImage" runat="server" class="form-control" />
                    </div>
                    <asp:Image ImageUrl="https://comunidades.cepal.org/ilpes/sites/default/files/users/pictures/default_0.png"
                        runat="server" ID="imgNuevoPerfil" Width="60%" />

                </ContentTemplate>
            </asp:UpdatePanel>

            <div class="mb-3">
                <label for="txtPassword" class="form-label">pass</label>
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator ErrorMessage="la contraseña es requerido " MinimumValue="2" MaximumValue="10" ControlToValidate="txtPassword" runat="server" />



            </div>
            <div class="mb-3">
                                <label for="CHKaDMIN" class="form-label">QUERES SER PARTE  ?</label>

                <asp:CheckBox runat="server" ID="chkAdmin"   OnCheckedChanged="chkAdmin_CheckedChanged"/>
            </div>



        </div>
    </div>

</asp:Content>
