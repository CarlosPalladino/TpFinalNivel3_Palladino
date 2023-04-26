<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="PresentacionFinal.Catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="dgv" runat="server"
        OnSelectedIndexChanged="dgv_SelectedIndexChanged"
        AutoGenerateColumns="false" CssClass="table"
        OnPageIndexChanged="dgv_PageIndexChanged"
        AllowPaging="true" PageSize="5">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <asp:BoundField HeaderText="Marcas" DataField="Marcas" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
        </Columns>

    </asp:GridView>
    <a href="NuevoArticulo.aspx" class="btn btn primary">Ingresar Nuevo Articulo</a>


</asp:Content>
