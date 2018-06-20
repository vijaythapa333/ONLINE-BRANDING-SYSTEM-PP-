<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="BrandsByCategory.aspx.cs" Inherits="OnilneBrandingSystem.pages.BrandsByCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Our Customers Starts Here-->
        <div class="brands">
            <div class="wrapper">
                <!--Navigation Starts Here-->
                <div class="categories">
                    <strong>Categories</strong>
                    <ul>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=E-Commerce" runat="server">E-Commerce<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=NGO" runat="server">NGO<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Travels" runat="server">Travels<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Clothing" runat="server">Clothing<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Gadgets" runat="server">Gadgets<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Furniture" runat="server">Furniture<li></li></a>
                        <a href="~/Pages/BrandsByCategory.aspx?cat=Consultancy" runat="server">Consultancy<li></li></a>
                    </ul>
                </div>
                
                <div class="search">
                    <strong> &nbsp;</strong>
                    <form id="form1" runat="server">
                        <asp:TextBox ID="txtSearch" runat="server" style="width: 70%;border: 2px solid rgb(245,124,33);">

                        </asp:TextBox><asp:Button ID="btnSearch" runat="server" Text="SEARCH" style="padding: 2%; " OnClick="btnSearch_Click" />
                    </form>
                </div>
                <div class="clearfix"></div>
                <!--Navigation Ends Here-->
                <div class="cat-title">BRANDS BY CATEGORY</div>

                    <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
                <div class="clearfix"></div>
            </div>
        </div>
    
        <!--Our Customers Starts Here-->
</asp:Content>
