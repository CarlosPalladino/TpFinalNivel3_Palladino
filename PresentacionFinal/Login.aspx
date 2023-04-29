<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentacionFinal.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Email address</label>
            <asp:Label runat="server" ID="" CssClass ="form-label">email</asp:Label>
            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />

            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
            <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
        </div>
        <div class="mb-3">
            <label for="exampleInputPassword1" class="form-label">Password</label>
            <asp:Label runat="server" CssClass="form-label" >Contraseña</asp:Label>
            <input type="password" class="form-control" id="exampleInputPassword1">
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" ></asp:TextBox>
        </div>
       
        <button type="submit" class="btn btn-primary">Submit</button>
    <asp:Button ID="btnLogin" OnClick="btnLogin_Click" runat="server" />



</asp:Content>
