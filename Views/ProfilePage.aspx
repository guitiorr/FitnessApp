<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="FitnessApp.Views.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/Profile.css?Version=2" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                    
    <div class="out-profile">
        <h1>Profile</h1>
        <div class="profile">
            <div class="left-profile">
                <div>
                    <asp:Image class="img" ID="ProfilePicture" runat="server" Width="200" Height="200"/>
                </div>
                <div style="margin-top:50px;font-weight:bolder">
                    <asp:Label ID="UsernameLbl" runat="server" Text=""></asp:Label>
                </div>
                <div style="margin-top:10px;font-weight:bolder">
                    <asp:Label ID="EmailLbl" runat="server" Text=""></asp:Label>
                </div>
            </div>
        
            <div class="right-profile">
                <div class="Self-Info">
                    <h1>Self Info</h1>
                    <div class="Label-Div">
                        <asp:Label CssClass="label" ID="AgeLbl" runat="server" Text=""></asp:Label>
                        <asp:Label CssClass="label" ID="HeightLbl" runat="server" Text=""></asp:Label>
                        <asp:Label CssClass="label" ID="WeightLbl" runat="server" Text=""></asp:Label>
                        <asp:Label CssClass="label" ID="WeightGoalLbl" runat="server" Text=""></asp:Label>
                        <asp:Label CssClass="label" ID="PhoneLbl" runat="server" Text=""></asp:Label>
                        <asp:Button CssClass="edit-btn" ID="EditProfileBtn" runat="server" Text="Edit Profile" OnClick="EditProfileBtn_Click"/>
                    </div>

                </div>
                <div class="Health-Info">
                    <h1>Health Info</h1>
                    <div class="Label-Div">
                        <asp:Label CssClass="label" ID="MedicalConditionLbl" runat="server" Text=""></asp:Label>
                        <asp:Label CssClass="label" ID="AllergiesLbl" runat="server" Text=""></asp:Label>
                    </div>
                        
                </div>
            </div>
        </div>
    </div>

</asp:Content>
