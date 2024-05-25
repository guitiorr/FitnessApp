<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ExerciseVideoPage.aspx.cs" Inherits="FitnessApp.Views.ExerciseVideoPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="GIFBox">
        <div id="GIFDiv1">
            <asp:Label ID="ExerciseLabel1" runat="server" Text=""></asp:Label>
            <asp:Label ID="MuscleTargetLabel1" runat="server" Text=""></asp:Label>
            <asp:Image ID="GIFPlayer1" runat="server"/>
        </div>
        <div id="GIFDiv2">
            <asp:Label ID="ExerciseLabel2" runat="server" Text=""></asp:Label>
            <asp:Label ID="MuscleTargetLabel2" runat="server" Text=""></asp:Label>
            <asp:Image ID="GIFPlayer2" runat="server"/>
        </div>
        <div id="GIFDiv3">
            <asp:Label ID="ExerciseLabel3" runat="server" Text=""></asp:Label>
            <asp:Label ID="MuscleTargetLabel3" runat="server" Text=""></asp:Label>
            <asp:Image ID="GIFPlayer3" runat="server"/>
        </div>
    </div>
    <div>
        <asp:Button ID="ChestButton" runat="server" Text="Chest" OnClick="ChestButton_Click"/>
    </div>
    <div>
        <asp:Button ID="ShoulderButton" runat="server" Text="Shoulder" OnClick="ShoulderButton_Click" />
    </div>
    <div>
        <asp:Button ID="BicepButton" runat="server" Text="Biceps" OnClick="BicepButton_Click" />
    </div>
    <div>
        <asp:Button ID="AbsButton" runat="server" Text="Abs" OnClick="AbsButton_Click" />
    </div>
    <div>
        <asp:Button ID="QuadsButton" runat="server" Text="Quads" OnClick="QuadsButton_Click" />
    </div>
    <div>
        <asp:Button ID="ForearmsButton" runat="server" Text="Forearms" OnClick="ForearmsButton_Click" />
    </div>

</asp:Content>
