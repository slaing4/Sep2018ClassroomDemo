﻿<%@ Page Title="ODS Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ODSQuery.aspx.cs" Inherits="WebApp.SamplePages.ODSQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="SelectArtistLabel" runat="server" Text="Select an artist"></asp:Label>
    <asp:DropDownList ID="ArtistList" runat="server" DataSourceID="ArtistListODS" DataTextField="Name" DataValueField="ArtistId" AppendDataBoundItems="true">
        <asp:ListItem Value="0">Select...</asp:ListItem>

    </asp:DropDownList>
    <asp:LinkButton ID="FetchArtist" runat="server">Fetch</asp:LinkButton>
    
    <asp:ObjectDataSource ID="ArtistListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_List" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>




</asp:Content>
