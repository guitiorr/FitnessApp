<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ExerciseVideoPage.aspx.cs" Inherits="FitnessApp.Views.ExerciseVideoPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="GIFBox">
        <div id="GIFDiv1">
            <asp:Image ID="GIFPlayer1" runat="server"/>
        </div>
        <div id="GIFDiv2">
            <asp:Image ID="GIFPlayer2" runat="server"/>
        </div>
        <div id="GIFDiv3">
            <asp:Image ID="GIFPlayer3" runat="server"/>
        </div>
    </div>
    <div>
        <asp:Button ID="ChestButton" runat="server" Text="Chest" OnClick="ChestButton_Click"/>
    </div>
    <div>

    </div>
</asp:Content>
