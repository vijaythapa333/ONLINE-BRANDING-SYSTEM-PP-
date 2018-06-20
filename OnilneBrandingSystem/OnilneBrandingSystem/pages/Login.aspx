<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnilneBrandingSystem.pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="banner">
        <div class="brand-register">
            <h3>Log In Here</h3>
            <hr />
            <table style="width: 512px">
                <tr>
                    <td style="width: 63px">Email: </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is Required." ForeColor="#990000"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid Email" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>

                <tr>
                    <td style="width: 63px">Password: </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Required." ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                </tr>

                <tr>
                    <td style="width: 63px">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Height="37px" Text="Log In" Width="184px" OnClick="btnLogin_Click" />
                    </td>
                </tr>

                <tr>
                    <td colspan="2">
                        Not Registered Yet? <asp:LinkButton ID="lnkRegister" runat="server" PostBackUrl="~/pages/RegisterBrand.aspx" CausesValidation="False">Click Here </asp:LinkButton> to Register your Brand.
                    </td>
                </tr>
            </table>
        </div>
    </div>
</form>
</asp:Content>
