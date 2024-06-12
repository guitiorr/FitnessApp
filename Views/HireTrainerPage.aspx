<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="HireTrainerPage.aspx.cs" Inherits="FitnessApp.Views.HireTrainerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/HireTrainer.css?Version=2" rel="stylesheet" />
    <script src="https://kit.fontawesome.com/942c6b9015.js" crossorigin="anonymous"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="ListTrainer">

    <div class="Recommend">
        <h1>Recommended</h1>
        <div class="repeater">
        <asp:Repeater ID="RepeatRecommendedTrainer" runat="server" OnItemDataBound="RepeatRecommendedTrainer_ItemDataBound">
            <ItemTemplate>
                <div class="item">
                    <asp:Image CssClass="image" ID="RecommendedTrainerPic" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' />
                    <div class="info">
                        <asp:Label CssClass="name" ID="RecommendedTrainerName" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                        

                        <%--<div>
                        <asp:Button CssClass="hire" ID="HireButton" runat="server" Text="Hire" CommandArgument='<%# Eval("trainerId") %>' OnClick="HireButton_Click1"/>
                        </div>--%>

                    </div>
                        <div class="stars2">
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        </div>
                  </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>
    </div>

    <div class="List">
        <h1>Trainer List</h1>
        <asp:Repeater ID="RepeatTrainerList" runat="server" OnItemDataBound="RepeatTrainerList_ItemDataBound">
            <ItemTemplate>
                <div class="item2">
                    <asp:Image CssClass="listImage" ID="ListTrainerPic" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' />
                    <div class="info2">
                        <asp:Label ID="ListTrainerName" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                        <div class="stars">
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        <i class="fa-solid fa-star" style="color: #FFD43B;"></i>
                        </div>

                        <asp:Button CssClass="hire2" ID="HireButton" runat="server" Text="Hire" CommandArgument='<%# Eval("trainerId") %>' OnClick="HireButton_Click1" />
                    </div>
               </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </div>
</asp:Content>
