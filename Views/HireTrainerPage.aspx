<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="HireTrainerPage.aspx.cs" Inherits="FitnessApp.Views.HireTrainerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h1>Recommended</h1>
        <asp:Repeater ID="RepeatRecommendedTrainer" runat="server" OnItemDataBound="RepeatRecommendedTrainer_ItemDataBound">
            <ItemTemplate>
                <div>
                    <asp:Label ID="RecommendedTrainerName" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                    <asp:Image ID="RecommendedTrainerPic" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' />
                    <asp:Button ID="HireButton" runat="server" Text="Hire" CommandArgument='<%# Eval("trainerId") %>' OnClick="HireButton_Click1"/>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <div>
        <h1>Trainer List</h1>
        <asp:Repeater ID="RepeatTrainerList" runat="server" OnItemDataBound="RepeatTrainerList_ItemDataBound">
            <ItemTemplate>
                <div>
                    <asp:Label ID="ListTrainerName" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                    <asp:Image ID="ListTrainerPic" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' />
                    <asp:Button ID="HireButton" runat="server" Text="Hire" CommandArgument='<%# Eval("trainerId") %>' OnClick="HireButton_Click1" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
