<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoArticulo.aspx.cs" Inherits="PresentacionFinal.NuevoArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Nuevo Articulo</h1>

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtCodigo" class="form-label">codigo</label>
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="ddlAMarca" class="form-label">Marca</label>
                <asp:DropDownList ID="ddlMArca" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="ddlCategorias" class="form-label">Categorias</label>
                <asp:DropDownList ID="ddlCategorias" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
              <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary"  runat="server" />
                <a href="WebForm1.aspx">Cancelar</a>
                <asp:Button Text="Desactivar" runat="server" ID="btnInactivar" CssClass="btn btn-warning" />
            </div>

        </div>
        <div class="col-6">

            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" CssClass="form-control" />

            </div>
            <asp:UpdatePanel ID="UpdatePannel1" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtImagenUrl" class="form-label">Url Imagen</label>
                        <asp:TextBox runat="server" ID="txtImagenUrl" CssClass="form-control"
                            AutoPostBack="true" OnTextChanged="txtImagenUrl_TextChanged1" />
                    </div>
                    <asp:Image ImageUrl="https://comunidades.cepal.org/ilpes/sites/default/files/users/pictures/default_0.png"
                        runat="server" ID="imgPokemon" Width="60%" />

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
</asp:Content>
