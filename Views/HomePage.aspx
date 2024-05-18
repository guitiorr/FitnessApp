<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FitnessApp.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Home Page lol</h1>
    </div>
    <div>
        <asp:Button ID="becomeMemberButton" runat="server" Text="Become Member" OnClick="becomeMemberButton_Click" />
    </div>
    <div>
        <asp:Button ID="becomeTrainerButton" runat="server" Text="Become Trainer" OnClick="becomeTrainerButton_Click" />
    </div>
</asp:Content>
