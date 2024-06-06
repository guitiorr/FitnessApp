<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ViewTrainerPage.aspx.cs" Inherits="FitnessApp.Views.ViewTrainerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/ViewTrainer.css" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/942c6b9015.js" crossorigin="anonymous"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="Trainer">
        <div>
            <h1>Your Trainer</h1>
        </div>
        <div>
            <asp:Image CssClass="Image" ID="TrainerPic" runat="server"/>
        </div>
        <div class="name">
            <asp:Label ID="TrainerFullName" runat="server" Text=""></asp:Label>
        </div>
        <div class="icon">
            <i class="fa-solid fa-message fa-2xl" style="color: #ffffff;"></i>
            <i class="fa-solid fa-user fa-2xl" style="color: #ffffff;"></i>
            <i class="fa-solid fa-phone fa-2xl" style="color: #ffffff;"></i>
        </div>

    </div>



</asp:Content>
