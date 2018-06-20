<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="RegisterBrand.aspx.cs" Inherits="OnilneBrandingSystem.pages.RegisterBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="banner">
        <div class="brand-register">
            <h3>Register Brand Here</h3>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblImage" runat="server"></asp:Label>
            <table style="width: 518px">
                <tr>
                    <td style="width: 146px">Brand Name: </td>
                    <td>
                        <asp:TextBox ID="txtBrandName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvBrandName" runat="server" ControlToValidate="txtBrandName" ErrorMessage="Brand Name is Required." ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Email: </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is Required." ForeColor="#990000"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email." ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Password: </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Required." ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Contact: </td>
                    <td>
                        <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Location: </td>
                    <td>
                        <asp:TextBox ID="txtLocation" runat="server" Height="92px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Description: </td>
                    <td>
                        <asp:TextBox ID="txtDescription" runat="server" Height="90px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Keywords: </td>
                    <td>
                        <asp:TextBox ID="txtKeywords" runat="server" Height="117px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Image: </td>
                    <td>
                        <asp:FileUpload ID="FileUploadImage" runat="server" />
                        <asp:Label ID="lblImagePath" runat="server" Text="."></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td style="width: 146px">Category: </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>E-Commerce</asp:ListItem>
                            <asp:ListItem>NGO</asp:ListItem>
                            <asp:ListItem>Travels</asp:ListItem>
                            <asp:ListItem>Clothing</asp:ListItem>
                            <asp:ListItem>Gadgets</asp:ListItem>
                            <asp:ListItem>Furniture</asp:ListItem>
                            <asp:ListItem>Consultancy</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Height="38px" Text="Register" Width="354px" OnClick="btnRegister_Click" />
                    </td>
                </tr>
                
                <tr>
                    <td colspan="2">
                        Not Registered Yet? <asp:LinkButton ID="lnkregister" runat="server" PostBackUrl="~/pages/RegisterBrand.aspx">Click Here </asp:LinkButton> to register.
                    </td>
                </tr>

            </table>
        </div>
    </div>
    </form>
</asp:Content>
