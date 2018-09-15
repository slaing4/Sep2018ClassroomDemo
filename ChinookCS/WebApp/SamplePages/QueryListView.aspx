<%@ Page Title="Query ListView" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QueryListView.aspx.cs" Inherits="WebApp.SamplePages.QueryListView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>ODS GridView</h1>
    

    <asp:Label ID="SelectArtistLabel" runat="server" Text="Select an artist"></asp:Label>
    <asp:DropDownList ID="ArtistList" runat="server" DataSourceID="ArtistListODS" DataTextField="Name" DataValueField="ArtistId" AppendDataBoundItems="true">
        <asp:ListItem Value="0">Select...</asp:ListItem>

    </asp:DropDownList>
    <asp:LinkButton ID="FetchArtist" runat="server">Fetch</asp:LinkButton>
    
    <br />
    <br />





</asp:Content>
