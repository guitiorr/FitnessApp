<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ViewTrainerPage.aspx.cs" Inherits="FitnessApp.Views.ViewTrainerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div>
            <h1>Your Trainer</h1>
        </div>
        <div>
            <asp:Image ID="TrainerPic" runat="server"/>
        </div>
        <div>
            <asp:Label ID="TrainerFullName" runat="server" Text=""></asp:Label>
        </div>


    </div>



</asp:Content>
