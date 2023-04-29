<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="PresentacionFinal.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end;">
        <div class="mb-3">
            <asp:CheckBox ID="chkAvanzado" runat="server"
                AutoPostBack="true" Text="Filtro Avanzado" OnCheckedChanged="chkAvanzado_CheckedChanged1" />
        </div>
    </div>

    <%if (filtroAvanzado)
        {%>
    <div class=" row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Campo" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlCampo" OnSelectedIndexChanged="dllCampo_SelectedIndexChanged"
                    runat="server" CssClass="form-control"
                    AutoPostBack="true">
                    <asp:ListItem Text="Nombre"></asp:ListItem>
                    <asp:ListItem Text="Precio"></asp:ListItem>
                    <asp:ListItem Text="Descripcion"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="col-3">
        <div class="mb-3">
            <asp:Label Text="Criterio" runat="server" />
            <asp:DropDownList ID="ddlCriterio" CssClass="form-control" runat="server">
            </asp:DropDownList>
        </div>
    </div>
    <div class="col-3">
        <div clas="mb-3">
            <asp:Label Text="Filtro" runat="server" />
            <asp:TextBox ID="txtFiltroAvanzado" runat="server"></asp:TextBox>

        </div>
    </div>

    <div clkas="col-3">
        <div class="mb-3">
            <asp:Button ID="btnBuscar" Text="Buscar" runat="server" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />

        </div>
    </div>
    <% } %>
    <asp:GridView ID="dgv" runat="server"
        AutoGenerateColumns="false" CssClass="table" DataKeyNames="Id"
        OnSelectedIndexChanged="dgv_SelectedIndexChanged"
        OnPageIndexChanging="dgv_PageIndexChanging"
        AllowPaging="true" PageSize="5">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="Marcas" DataField="Marcas" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
            <asp:CommandField HeaderText="accion" ShowSelectButton="true" SelectText="detalle" />
        </Columns>

    </asp:GridView>
    <a href="NuevoArticulo.aspx" class="btn btn primary">Ingresar Nuevo Articulo</a>
</asp:Content>
