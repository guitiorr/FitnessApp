<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MembersPage.aspx.cs" Inherits="FitnessApp.Views.MembersPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Style/Member.css" rel="stylesheet" />
    <title>Membership</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="membershipContainer">
            <h1 class="member-txt">MEMBERSHIP</h1>
            <div id="membershipOptions">
                <div class="container" id="memberOption1">
                    
                    <div class="top">
                        <h1 style="margin-top:0">STARTER</h1>
                        <h2><span class="span">$5 </span></h2>
                        <h1 style="font-size:20px">/ Month</h1>
                    </div>
                    


                    <p>Access All Courses and Video</p>
                    <p>Edit Your Workout Plan</p>
                    <p>Edit your Food Plan</p>
                    <asp:Button CssClass="Purchase prcs" ID="PurchaseMemberButton1" runat="server" Text="Purchase"
                        OnClick="PurchaseMemberButton1_Click" />

                    <%--<button class="Purchase prcs">Purchase</button>--%>


                </div>
                <div class="container" id="memberOption2">
                    <div>
                        <div class="top">
                            <h1 style="margin-top:0">PRO</h1>
                            <h2><span class="span" style="color: rgba(205, 181, 11, 0.8)">$10 </span></h2>
                            <h2>/ Month</h2>
                        </div>
                        
                        <p>Access All Courses and Video</p>
                        <p>Edit Your Workout Plan</p>
                        <p>Edit your Food Plan</p>
                        <p>Private Coach</p>
                    </div>

                    <asp:Button CssClass="Purchase1 prcs" ID="PurchaseMemberButton2" runat="server" Text="Purchase"
                        OnClick="PurchaseMemberButton2_Click" />

                    <%--<button class="Purchase1 prcs">Purchase</button>--%>

                </div>
                <div class="container" id="memberOption3">
                    <div>
                        <div class="top">
                            <h1 style="margin-top:0">ELITE</h1>
                            <h2><span class="span" style="color: rgba(238, 24, 73, 1)">$15 </span></h2>
                            <h2>/ Month</h2>
                        </div>
                        
                        <p>Access All Courses and Video</p>
                        <p>Edit Your Workout Plan</p>
                        <p>Edit your Food Plan</p>
                        <p>Private Coach</p>
                        <p>Get ultimate Coach</p>
                    </div>

                    <asp:Button CssClass="Purchase2 prcs" ID="PurchaseMemberButton3" runat="server" Text="Purchase"
                        OnClick="PurchaseMemberButton3_Click" />

                    <%--<button class="Purchase2 prcs">Purchase</button>--%>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
