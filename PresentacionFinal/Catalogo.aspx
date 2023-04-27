<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="PresentacionFinal.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
