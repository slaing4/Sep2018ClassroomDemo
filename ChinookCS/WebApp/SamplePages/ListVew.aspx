<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListVew.aspx.cs" Inherits="WebApp.SamplePages.ListVew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>ListView</h1>

    <asp:Label ID="SelectArtistLabel" runat="server" Text="Select an artist"></asp:Label>
    <asp:DropDownList ID="ArtistList" runat="server" DataSourceID="ArtistListODS" DataTextField="Name" DataValueField="ArtistId" AppendDataBoundItems="true">
        <asp:ListItem Value="0">Select...</asp:ListItem>

    </asp:DropDownList>
    <asp:LinkButton ID="FetchArtist" runat="server">Fetch</asp:LinkButton>
    
    <br />
    <br />

    <asp:ListView ID="AlbumListView" runat="server" DataSourceID="AlbumListODS"></asp:ListView>

    <asp:ObjectDataSource ID="ArtistListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_List" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>
    
    <asp:ObjectDataSource ID="AlbumListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Album_GetByArtistId" TypeName="ChinookSystem.BLL.AlbumController">
        <SelectParameters>
            <asp:Parameter Name="artistid" Type="Int32"></asp:Parameter>
        </SelectParameters>
    </asp:ObjectDataSource>



</asp:Content>
