<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleDartsEpicU.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 720px;
            height: 460px;
        }
    </style>
</head>
<body>
    <h1>Challenge Simple Darts</h1>

    <p>
        <img alt="Dart Board" class="auto-style1" src="Images/DartBoard.jpg" /></p>
    <form id="form1" runat="server">
    <p>
        &nbsp;&nbsp;<asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="Click to Play!" />
        </p>
    <div>
    
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
