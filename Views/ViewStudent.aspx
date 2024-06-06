<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="FitnessApp.Views.ViewStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/ViewStudent.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Student">
        <asp:Repeater ID="repeatStudentList" runat="server" OnItemDataBound="repeatStudentList_ItemDataBound">
            <ItemTemplate>
                <div class="item">
                <div class="img-bg">
                    <asp:Label ID="NameLbl" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                </div>
                <div class="name">
                    <asp:Image ID="ClientImg" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' />
                </div>
                </div>
                <h1>HI</h1>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
