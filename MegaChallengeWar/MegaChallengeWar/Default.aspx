<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeWar.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Play War!</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Let's Play War</h1>
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </p>


</asp:Content>
