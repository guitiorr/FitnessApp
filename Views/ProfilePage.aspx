<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="FitnessApp.Views.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h1>Profile</h1>
        <div>
            <asp:Button ID="EditProfileBtn" runat="server" Text="Edit Profile" OnClick="EditProfileBtn_Click"/>
        </div>
        <div>
            <asp:Image ID="ProfilePicture" runat="server"/>
        </div>
        <div>
            <asp:Label ID="UsernameLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="EmailLbl" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <div>
                <h1>Self Info</h1>
                <div>
                    <asp:Label ID="AgeLbl" runat="server" Text=""></asp:Label>
                    <asp:Label ID="HeightLbl" runat="server" Text=""></asp:Label>
                    <asp:Label ID="WeightLbl" runat="server" Text=""></asp:Label>
                    <asp:Label ID="WeightGoalLbl" runat="server" Text=""></asp:Label>
                    <asp:Label ID="ActiveLevelLbl" runat="server" Text=""></asp:Label>
                    <asp:Label ID="PhoneLbl" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div>
                <h1>Health Info</h1>
                <div>
                    <asp:Label ID="MedicalConditionLbl" runat="server" Text=""></asp:Label>
                </div>
                <div>
                    <asp:Label ID="AllergiesLbl" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
