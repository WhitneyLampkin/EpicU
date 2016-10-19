<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="GameRules.aspx.cs" Inherits="MegaChallengeWar.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Game Rules</title>
    <style>
        .main{
            margin-left: 600px;
            margin-right: 600px;
            padding: 50px;
            padding-top: 0;
        }

        .auto-style2 {
            font-size: large;
        }
        .auto-style3 {
            font-size: medium;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="main">
    <h1>Game Rules</h1>

    <p class="auto-style3">The goal is to be the first player to win all 52 cards.</p>

    <h3 class="auto-style2">THE DEAL</h3>
    <p class="auto-style3">The deck is divided evenly, with each player receiving 26 cards, dealt one at a time, face down. Anyone may deal first. 
    Each player places his stack of cards face down, in front of him.</p>
        <br />
    <h3 class="auto-style2">THE PLAY</h3>
    <p class="auto-style3">Each player turns up a card at the same time and the player with the higher card takes both cards and puts them, face down, on the bottom of his stack.</p>
        <br />
    <p class="auto-style3">If the cards are the same rank, it is War. Each player turns up one card face down and one card face up. 
    The player with the higher cards takes both piles (six cards). If the turned-up cards are again the same rank, each player places another card face down 
    and turns another card face up. The player with the higher card takes all 10 cards, and so on.</p>
        <br />
    <h3 class="auto-style2">HOW TO KEEP SCORE</h3>
    <p class="auto-style3">The game ends when one player has won all the cards.</p>
    <a href="http://www.bicyclecards.com/how-to-play/war/">Click here for more info.</a>
        </div>
</asp:Content>
