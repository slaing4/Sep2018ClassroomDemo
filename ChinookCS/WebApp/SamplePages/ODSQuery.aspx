<%@ Page Title="ODS Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ODSQuery.aspx.cs" Inherits="WebApp.SamplePages.ODSQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    

    <asp:Label ID="SelectArtistLabel" runat="server" Text="Select an artist"></asp:Label>
    <asp:DropDownList ID="ArtistList" runat="server" DataSourceID="ArtistListODS" DataTextField="Name" DataValueField="ArtistId" AppendDataBoundItems="true">
        <asp:ListItem Value="0">Select...</asp:ListItem>

    </asp:DropDownList>
    <asp:LinkButton ID="FetchArtist" runat="server">Fetch</asp:LinkButton>
    
    <br />
    <br />
    
    <!--Bind("xxx") is both input and output, Eval is output only -->

    <asp:GridView ID="AlbumList" runat="server" AutoGenerateColumns="False" DataSourceID="AlbumListODS">
        <Columns>
            <asp:TemplateField HeaderText="Album ID" SortExpression="AlbumId">
               
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("AlbumId") %>' ID="Label2"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Title" SortExpression="Title">
                
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("Title") %>' ID="Label1"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Artist" SortExpression="ArtistId">
                
                <ItemTemplate>
                    <asp:DropDownList ID="AlbumArtistList" runat="server" DataSourceID="ArtistListODS" DataTextField="Name" DataValueField="ArtistId" SelectedValue='<%# Eval("ArtistId") %>' ></asp:DropDownList>

                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Release Year" SortExpression="ReleaseYear">
                
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("ReleaseYear") %>' ID="Label4"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Release Label" SortExpression="ReleaseLabel">
                
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("ReleaseLabel") %>' ID="Label5"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
        <EmptyDataTemplate>No data is avalible</EmptyDataTemplate>

    </asp:GridView>


    <asp:ObjectDataSource ID="ArtistListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Artist_List" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>
    
    <asp:ObjectDataSource ID="AlbumListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Album_GetByArtistId" TypeName="ChinookSystem.BLL.AlbumController">
        <SelectParameters>
            <asp:Parameter Name="artistid" Type="Int32"></asp:Parameter>
        </SelectParameters>
    </asp:ObjectDataSource>



</asp:Content>
