﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentacionFinal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>esta es la pagina principal-base</h1>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater ID="repetidor" runat="server">
            <ItemTemplate>
                <div class="col">
                    <div class="card card-body">
                        <img src="<%#Eval("ImagenUrl")%>" class="card -img-top" alt="imagen">
                        <div class="card-body">
                            <h2>Nombre</h2>
                            <h5 class="card-title"><%#Eval("Nombre") %> </h5>
                            <h2>Descripcion</h2>
                            <h5 class="card-title"><%#Eval("Descripcion") %></h5>
                            <h2>Codigo</h2>
                            <h5 class="card-title"><%#Eval("Codigo") %></h5>
                            <h2>Categoria</h2>
                            <h5 class="card-title"><%#Eval("Categoria") %></h5>
                            <h2>Marcas</h2>
                            <h5 class="card-title"><%#Eval("Marcas") %></h5>
                            <h2>Precio</h2>
                            <h5 class="card-title"><%#Eval("Precio") %>$</h5>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
