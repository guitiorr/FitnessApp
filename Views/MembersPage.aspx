<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MembersPage.aspx.cs" Inherits="FitnessApp.Views.MembersPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Membership</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="membershipContainer">
            <h1>Membership</h1>
            <div id="membershipOptions">
                <div id="memberOption1">
                    <h1>Bronze</h1>
                    <h2>Rp 50.000 / Month</h2>
                    <p>Benefit</p>
                    <p>Access All Courses and Video</p>
                    <p>Edit Your Workout Plan</p>
                    <p>Edit your Food Plan</p>
                    <asp:Button ID="PurchaseMemberButton1" runat="server" Text="Purchase" OnClick="PurchaseMemberButton1_Click"/>
                </div>
                <div id="memberOption2">
                    <h1>Silver</h1>
                    <h2>Rp 100.000 / Month</h2>
                    <p>Benefit</p>
                    <p>Access All Courses and Video</p>
                    <p>Edit Your Workout Plan</p>
                    <p>Edit your Food Plan</p>
                    <p>Private Coach</p>
                    <asp:Button ID="PurchaseMemberButton2" runat="server" Text="Purchase" OnClick="PurchaseMemberButton2_Click"/>
                </div>
                <div id="memberOption3">
                    <h1>Gold</h1>
                    <h2>Rp 150.000 / Month</h2>
                    <p>Benefit</p>
                    <p>Access All Courses and Video</p>
                    <p>Edit Your Workout Plan</p>
                    <p>Edit your Food Plan</p>
                    <p>Private Coach</p>
                    <p>Get ultimate Coach</p>
                    <asp:Button ID="PurchaseMemberButton3" runat="server" Text="Purchase" OnClick="PurchaseMemberButton3_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
