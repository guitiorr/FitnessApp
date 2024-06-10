﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="MealPage.aspx.cs" Inherits="FitnessApp.Views.MealPage" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Today's Meal</h1>
    <asp:Repeater ID="repeatTodayMeal" runat="server" OnItemDataBound="repeatTodayMeal_ItemDataBound">
        <ItemTemplate>
            <asp:Label ID="FoodNameLbl" runat="server" Text='<%# Eval("foodId") %>'></asp:Label>
            <asp:Label ID="MealTime" runat="server" Text='<%# Eval("mealTime") %>'></asp:Label>
            <asp:Image ID="FoodImageToday" runat="server"/>
            <asp:Button ID="RemoveBtn" runat="server" Text="Remove" CommandArgument='<%# Eval("FoodId") %>' OnClick="RemoveBtn_Click" />
        </ItemTemplate>
    </asp:Repeater>

    <h1>Browse Meals</h1>

    <h2>Breakfast</h2>
    <asp:Repeater ID="repeatBrowseMealBreakfast" runat="server" OnItemDataBound="repeatBrowseMealBreakfast_ItemDataBound">
        <ItemTemplate>
            <asp:Label ID="FoodNameLblBreakfast" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
            <asp:Image ID="FoodImageBreakfast" runat="server" />
            <asp:Button ID="addBreakfastBtn" runat="server" Text="Add" OnClick="addBreakfastBtn_Click"/>
        </ItemTemplate>
    </asp:Repeater>

    <h2>Lunch</h2>
    <asp:Repeater ID="repeatBrowseMealLunch" runat="server" OnItemDataBound="repeatBrowseMealLunch_ItemDataBound">
        <ItemTemplate>
            <asp:Label ID="FoodNameLblLunch" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
            <asp:Image ID="FoodImageLunch" runat="server" />
            <asp:Button ID="addLunchBtn" runat="server" Text="Add" OnClick="addLunchBtn_Click"/>
        </ItemTemplate>
    </asp:Repeater>



    <h2>Dinner</h2>
    <asp:Repeater ID="repeatBrowseMealDinner" runat="server" OnItemDataBound="repeatBrowseMealDinner_ItemDataBound">
        <ItemTemplate>
            <asp:Label ID="FoodNameLblDinner" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
            <asp:Image ID="FoodImageDinner" runat="server" />
            <asp:Button ID="addLunchDinner" runat="server" Text="Add" OnClick="addLunchDinner_Click"/>
        </ItemTemplate>
    </asp:Repeater>



</asp:Content>
