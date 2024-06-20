    <%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ExerciseVideoPage.aspx.cs" Inherits="FitnessApp.Views.ExerciseVideoPage" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/ExerciseVideo.css?Version=3" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div>
        <h1>Today's Exercise</h1>


        <div>
            <asp:Repeater ID="repeatTodayExercise" runat="server" OnItemDataBound="repeatTodayExercise_ItemDataBound">
                <ItemTemplate>
                    <asp:Label ID="ExerciseNameLbl" runat="server" Text='<%# Eval("ExerciseID") %>'></asp:Label>
                    <asp:Label ID="SetsLbl" runat="server" Text='<%# Eval("Reps") + " Reps" %>'></asp:Label>
                    <asp:Label ID="RepsLbl" runat="server" Text='<%# Eval("Sets") + " Sets" %>'></asp:Label>
                    <asp:Image ID="ExerciseImage" runat="server" />
                    <asp:Button ID="RemoveBtn" runat="server" Text="Remove" CommandArgument='<%# Eval("ExercisePlanID") %>' OnClick="RemoveBtn_Click" />
                </ItemTemplate>
            </asp:Repeater>


        </div>



    </div>


    <div>
        <h1>Add Exercise</h1>

        <asp:Label ID="AlertLbl" runat="server" Text="Please fill number of reps and sets" Visible="true"></asp:Label>

        <div>
            <asp:Label ID="SetsLbl" runat="server" Text="Sets" Visible="true"></asp:Label>
            <asp:TextBox ID="SetsTB" runat="server" Visible="true"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="RepsLbl" runat="server" Text="Reps" Visible="true"></asp:Label>
            <asp:TextBox ID="RepsTB" runat="server" Visible="true"></asp:TextBox>
        </div>

        <h1>Exercise List</h1>
        <asp:Repeater ID="repeatBrowseExercise" runat="server" OnItemDataBound="repeatBrowseExercise_ItemDataBound">
            <ItemTemplate>
                <asp:Image ID="ExerciseImage" runat="server"/>
                <asp:Label ID="ExerciseNameLbl" runat="server" Text='<%# Eval("ExerciseName") %>'></asp:Label>
                <asp:Button ID="AddExerciseBtn" runat="server" Text="Add" OnClick="AddExerciseBtn_Click"/>
            </ItemTemplate>
        </asp:Repeater>






    </div>




    
    <div id="GIFBox">
        <div class="ButtonBox">
            <div>
                <asp:Button CssClass="BTN" ID="ChestButton" runat="server" Text="Chest" OnClick="ChestButton_Click"/>

            </div>
            <div>
                <asp:Button CssClass="BTN" ID="ShoulderButton" runat="server" Text="Shoulder" OnClick="ShoulderButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="BicepButton" runat="server" Text="Biceps" OnClick="BicepButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="AbsButton" runat="server" Text="Abs" OnClick="AbsButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="QuadsButton" runat="server" Text="Quads" OnClick="QuadsButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="ForearmsButton" runat="server" Text="Forearms" OnClick="ForearmsButton_Click" />
            </div>
            <div>
                <asp:Button CssClass="BTN" ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click"/>
            </div>
        </div>

        <div class="btm">
             <div class="GIFDIP" id="GIFDiv1">
                <asp:Label CssClass="span" ID="ExerciseLabel1" runat="server" Text=""></asp:Label>
                <asp:Label CssClass="span" ID="MuscleTargetLabel1" runat="server" Text=""></asp:Label>
                <asp:Image ID="GIFPlayer1" runat="server"/>
            </div>
            <div class="GIFDIP" id="GIFDiv2">
                <asp:Label CssClass="span" ID="ExerciseLabel2" runat="server" Text=""></asp:Label>
                <asp:Label CssClass="span" ID="MuscleTargetLabel2" runat="server" Text=""></asp:Label>
                <asp:Image ID="GIFPlayer2" runat="server"/>
            </div>
            <div class="GIFDIP" id="GIFDiv3">
                <asp:Label CssClass="span" ID="ExerciseLabel3" runat="server" Text=""></asp:Label>
                <asp:Label CssClass="span" ID="MuscleTargetLabel3" runat="server" Text=""></asp:Label>
                <asp:Image ID="GIFPlayer3" runat="server"/>
            </div>
        </div>

        
    </div>
    

</asp:Content>
