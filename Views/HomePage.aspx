<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FitnessApp.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/Homee.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap" rel="stylesheet">
    <link href="https://unpkg.com/aos@2.3.1/dist/aos.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   
        <div class="div-main">
                <div class="inside">
                    <div class="main-txt">
                        <h1 style="margin-top: 0;">YOUR PERSONALIZED JOURNEY TO HEALTH & FITNESS</h1>
                        <br>
                        <asp:Button class="join" ID="Button1" runat="server" Text="Join" />
                    </div>
                </div>
        </div>
        <div class="div-main">
        <div class="inside">
            <div class="main-txt">
                <h1 style="margin-top: 0;">YOUR PERSONALIZED JOURNEY TO HEALTH & FITNESS</h1>
                <br>
                <asp:Button class="join" ID="Button2" runat="server" Text="Join" />
            </div>
        </div>
</div><div class="div-main">
        <div class="inside">
            <div class="main-txt">
                <h1 style="margin-top: 0;">YOUR PERSONALIZED JOURNEY TO HEALTH & FITNESS</h1>
                <br>
                <asp:Button class="join" ID="Button3" runat="server" Text="Join" />
            </div>
        </div>
</div><div class="div-main">
        <div class="inside">
            <div class="main-txt">
                <h1 style="margin-top: 0;">YOUR PERSONALIZED JOURNEY TO HEALTH & FITNESS</h1>
                <br>
                <asp:Button class="join" ID="Button4" runat="server" Text="Join" />
            </div>
        </div>
</div>
        


    

    <div>
        <asp:Button ID="becomeMemberButton" runat="server" Text="Become Member" OnClick="becomeMemberButton_Click" />
    </div>
    <div>
        <asp:Button ID="becomeTrainerButton" runat="server" Text="Become Trainer" OnClick="becomeTrainerButton_Click" />
    </div>
</asp:Content>
