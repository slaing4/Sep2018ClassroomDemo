<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testquery.aspx.cs" Inherits="WebApp.SamplePages.testquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Title" DataValueField="ArtistId"></asp:DropDownList>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Album_List" TypeName="ChinookSystem.BLL.AlbumController"></asp:ObjectDataSource>













</asp:Content>
