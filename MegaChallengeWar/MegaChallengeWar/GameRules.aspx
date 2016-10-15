<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="GameRules.aspx.cs" Inherits="MegaChallengeWar.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Game Rules</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Game Rules</h1>

    <p>The goal is to be the first player to win all 52 cards</p>

    <h5>THE DEAL</h5>
    <p>The deck is divided evenly, with each player receiving 26 cards, dealt one at a time, face down. Anyone may deal first. 
    Each player places his stack of cards face down, in front of him.</p>

    <h5>THE PLAY</h5>
    <p>Each player turns up a card at the same time and the player with the higher card takes both cards and puts them, face down, on the bottom of his stack.</p>

    <p>If the cards are the same rank, it is War. Each player turns up one card face down and one card face up. 
    The player with the higher cards takes both piles (six cards). If the turned-up cards are again the same rank, each player places another card face down 
    and turns another card face up. The player with the higher card takes all 10 cards, and so on.</p>

    HOW TO KEEP SCORE
    <p>The game ends when one player has won all the cards.</p>


http://www.bicyclecards.com/how-to-play/war/
</asp:Content>
