<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SeeMessages.aspx.cs" Inherits="Blog.Web.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        Messages Received:

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Subject" HeaderText="Subject" SortExpression="Subject" />
                <asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FeedbackConnectionString1 %>" DeleteCommand="DELETE FROM [Feedback] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Feedback] ([Name], [Email], [Subject], [Message]) VALUES (@Name, @Email, @Subject, @Message)" ProviderName="<%$ ConnectionStrings:FeedbackConnectionString1.ProviderName %>" SelectCommand="SELECT [Id], [Name], [Email], [Subject], [Message] FROM [Feedback]" UpdateCommand="UPDATE [Feedback] SET [Name] = @Name, [Email] = @Email, [Subject] = @Subject, [Message] = @Message WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Subject" Type="String" />
                <asp:Parameter Name="Message" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Email" Type="String" />
                <asp:Parameter Name="Subject" Type="String" />
                <asp:Parameter Name="Message" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

    </div>

</asp:Content>
