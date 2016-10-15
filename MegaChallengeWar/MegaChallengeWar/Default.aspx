<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengeWar.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Play War!</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h1>Let's Play War</h1>
    <div class="row">
        <div class="col-md-2">
            <asp:Label ID="player1Label" runat="server"></asp:Label>
        </div>
        <div class="col-md-3">
            <%--<asp:Image ID="card1Image" runat="server" Height="180px" Width="180px" />--%>
        </div>
        <div class="col-md-2"></div>
        <asp:Button ID="playButton" runat="server" Text="Play War!" OnClick="playButton_Click" />

        <div class="col-md-3">
            <%--<asp:Image ID="card2Image" runat="server" Height="180px" Width="180px" />--%>
        </div>
        <div class="col-md-2">
            <asp:Label ID="player2Label" runat="server"></asp:Label>
        </div>
    </div>
    
    <p>&nbsp;</p>
    <p>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </p>


</asp:Content>

