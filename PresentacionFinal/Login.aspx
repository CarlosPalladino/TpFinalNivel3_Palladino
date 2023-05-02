<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentacionFinal.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="mb-3">
        <asp:Label runat="server"  CssClass="form-label" Text="Email" />
        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />
        <asp:RequiredFieldValidator ErrorMessage="Tienes que ser introducir un formate de mail válido " ControlToValidate="txtEmail" runat="server" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" />

    </div>
    <div class="mb-3">
        <asp:Label runat="server" CssClass="form-label" Text="Contraseña"/>
        <asp:TextBox ID="txtPassword"   CssClass="form-control" TextMode="Password" runat="server"/>

        <asp:RequiredFieldValidator ErrorMessage="Tienes que introducir una contraseña válida "  ControlToValidate="txtPassword" runat="server" />

    </div>

    <asp:Button ID="btnLogin"  class="btn btn-primary" OnClick="btnLogin_Click" Text="Loguearse" runat="server" />



</asp:Content>
