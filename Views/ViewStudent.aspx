<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Header.Master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="FitnessApp.Views.ViewStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Repeater ID="repeatStudentList" runat="server" OnItemDataBound="repeatStudentList_ItemDataBound">
            <ItemTemplate>
                <asp:Label ID="NameLbl" runat="server" Text='<%# Eval("FullName") %>'></asp:Label>
                <asp:Image ID="ClientImg" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
