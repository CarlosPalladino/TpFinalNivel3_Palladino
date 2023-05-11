<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoArticulo.aspx.cs" Inherits="PresentacionFinal.NuevoArticulo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <%--<label for="txtId"  class="form-label">Id</label>--%>
                <asp:TextBox runat="server" ID="txtId" Visible="false" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtCodigo" class="form-label">codigo</label>
                <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control" />
            </div>
            <a href="NuevoArticulo.aspx">NuevoArticulo.aspx</a>
            <div class="mb-3">
                <label for="ddlAMarca" class="form-label">Marca</label>
                <asp:DropDownList ID="ddlMarca" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="ddlCategorias" class="form-label">Categorias</label>
                <asp:DropDownList ID="ddlCategorias" CssClass="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
            </div>
            <div class="row">
                <div class="col-6">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>

                            <%                if (Request.QueryString["id"] != null)


                                    { %>

                            <asp:Button Text="eliminar" ID="btnEliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" runat="server" />

                            <%} %>
                            <div class="mb-3">
                                <%
                                    if (ConfirmarEliminacion)
                                    {%>
                            </div>
                            <div class="mb-3">
                                <asp:CheckBox Text="confirmar eliminación" ID="chkConfirmarEliminacion" CssClass="btn btn-warning" runat="server" />
                                <asp:Button Text="eliminar" ID="btnConfirmarEliminar" CssClass="btn btn danger" OnClick="btnConfirmarEliminar_Click" runat="server" />


                            </div>

                            <%} %>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" OnClick="btnAceptar_Click" runat="server" />
            <a href="Default.aspx" class="btn btn-wanring">Cancelar</a>
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
                        AutoPostBack="true" OnTextChanged="txtImagenUrl_TextChanged" />
                </div>
                <asp:Image ImageUrl="https://comunidades.cepal.org/ilpes/sites/default/files/users/pictures/default_0.png"
                    runat="server" ID="imgArticulo" Width="60%" />

            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
