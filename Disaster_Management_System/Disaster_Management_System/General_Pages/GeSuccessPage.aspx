<%@ Page Title="" Language="C#" MasterPageFile="~/General_Pages/General1.Master" AutoEventWireup="true" CodeBehind="GeSuccessPage.aspx.cs" Inherits="Disaster_Management_System.General_Pages.GeSuccessPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style29 {
            width: 100%;
        }
        .auto-style30 {
            text-align: center;
            height: 45px;
        }
        .auto-style31 {
            text-align: left;
        }
        .auto-style32 {
            text-align: center;
    }
        .auto-style33 {
            width: 261px;
        }
        .auto-style34 {
            text-align: left;
            width: 203px;
        }
    .auto-style35 {
        text-align: center;
        height: 26px;
    }
    .auto-style36 {
        text-align: left;
        width: 203px;
        height: 26px;
    }
    .auto-style37 {
        width: 261px;
        height: 26px;
    }
    .auto-style38 {
        height: 26px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style29">
        <tr>
            <td class="auto-style30" colspan="4">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="20pt" Text="VERIFY YOUR DETAILS "></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblName0" runat="server" Text="Name :"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblCountry0" runat="server" Text="Country :"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblCountry" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblState0" runat="server" Text="State :"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblState" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblDist0" runat="server" Text="District : "></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblDist" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblPin0" runat="server" Text="Pin :"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblPin" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblMobile0" runat="server" Text="Mobile :"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblMobile" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblMail0" runat="server" Text="Email : "></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblMail" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">
                <asp:Label ID="lblPass0" runat="server" Text="Password :"></asp:Label>
            </td>
            <td class="auto-style33">
                <asp:Label ID="lblPass" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35"></td>
            <td class="auto-style36">
                <asp:Label ID="lblUserStatus0" runat="server" Text="User Status : "></asp:Label>
            </td>
            <td class="auto-style37">
                <asp:Label ID="lblUserStatus" runat="server"></asp:Label>
            </td>
            <td class="auto-style38"></td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style31" colspan="2">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="151px" Font-Bold="True" Font-Size="12pt" ForeColor="#FF66CC" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnPrevious" runat="server" Text="Previous" Width="151px" Font-Bold="True" Font-Size="12pt" ForeColor="#FF66CC" OnClick="btnPrevious_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32" colspan="4">
                <asp:Label ID="lblSuccessMsg" runat="server" ForeColor="#00E800"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style34">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
