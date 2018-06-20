<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="brandProfile.aspx.cs" Inherits="OnilneBrandingSystem.pages.brandProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <!--Our Customers Starts Here-->
        <div class="brands">
            <div class="wrapper">
                <h3>Brand Profile Page</h3>
                <asp:Label ID="lblTest" runat="server" Text=""></asp:Label>
               
                <div class="clearfix">
                     <h2>Upload Image To The Gallery</h2>
                    <asp:Label ID="lblImage" runat="server" Text=""></asp:Label><br />
                    <asp:TextBox ID="txtImageName" runat="server" placeholder="Image Name" Style="padding: 1%;width: 17%;"></asp:TextBox><br />
                    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                    <asp:Button ID="btnUpload" runat="server" Text="SAVE" Style="padding: 1%;width: 17%;" OnClick="btnUpload_Click" />
                </div>
               
                <!--Gallery Starts Here-->
                <div class='gallery'>
                    <h3>Gallery</h3>
                    <asp:Label ID="lblGallery" runat="server" Text=""></asp:Label>
                    
                    
                    
                    
                    <div class='clearfix'></div>
                    
                </div>
                <hr />
                <!--Gallery Ends Here-->
            </div>
        </div>
        <!--Our Customers Starts Here-->
    </form>
</asp:Content>
