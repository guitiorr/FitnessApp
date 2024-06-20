<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="MealPage.aspx.cs" Inherits="FitnessApp.Views.MealPage" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/Meal.css?Version=2" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="top-meal">
            <h1 style="font-size: 50px">Today's Meal</h1>
            <asp:Repeater ID="repeatTodayMeal" runat="server" OnItemDataBound="repeatTodayMeal_ItemDataBound">
                <ItemTemplate>
                    <div class="today-meal">
                        <asp:Image CssClass="image" ID="FoodImageToday" runat="server" />
                        <div class="info">
                            <asp:Label CssClass="label" ID="FoodNameLbl" runat="server" Text='<%# Eval("foodId") %>'></asp:Label>
                            <asp:Label ID="MealTime" runat="server" Text='<%# Eval("mealTime") %>'></asp:Label>
                        </div>

                        <asp:Button CssClass="remove" ID="RemoveBtn" runat="server" Text="Remove" CommandArgument='<%# Eval("FoodId") %>' OnClick="RemoveBtn_Click" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <div class="bottom-meal">
            <h1>Browse Meals</h1>

            <h2 style="text-align: center;">Breakfast</h2>

            <div class="breakfast">
                <asp:Repeater ID="repeatBrowseMealBreakfast" runat="server" OnItemDataBound="repeatBrowseMealBreakfast_ItemDataBound">
                    <ItemTemplate>
                        <div class="choice-div" style="background-color: #DDF7A7; color: black">
                            <asp:Image CssClass="choice" ID="FoodImageBreakfast" runat="server" />
                            <div class="choice-info">
                                <asp:Label CssClass="choice-label" ID="FoodNameLblBreakfast" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
                            </div>

                            <asp:Button CssClass="addBtn" ID="addBreakfastBtn" runat="server" Text="Add" OnClick="addBreakfastBtn_Click" />
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
            </div>

            <h2 style="text-align: center;">Lunch</h2>

            <div class="breakfast">
                <asp:Repeater ID="repeatBrowseMealLunch" runat="server" OnItemDataBound="repeatBrowseMealLunch_ItemDataBound">
                    <ItemTemplate>
                        <div class="choice-div"  style="background-color: #49FDBB; color: black">
                            <asp:Image CssClass="choice" ID="FoodImageLunch" runat="server" />
                            <div class="choice-info">
                                <asp:Label CssClass="choice-label" ID="FoodNameLblLunch" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
                            </div>
                            <asp:Button CssClass="addBtn" ID="addLunchBtn" runat="server" Text="Add" OnClick="addLunchBtn_Click" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>


            <h2 style="text-align: center;">Dinner</h2>

            <div class="breakfast">
                <asp:Repeater ID="repeatBrowseMealDinner" runat="server" OnItemDataBound="repeatBrowseMealDinner_ItemDataBound">
                    <ItemTemplate>
                        <div class="choice-div"  style="background-color: #BEBCB8; color:black">
                            <asp:Image CssClass="choice" ID="FoodImageDinner" runat="server" />
                            <div class="choice-info">
                                <asp:Label CssClass="choice-label" ID="FoodNameLblDinner" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
                            </div>
                            <asp:Button CssClass="addBtn" ID="addLunchDinner" runat="server" Text="Add" OnClick="addLunchDinner_Click" />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
