<%@ Page Title="" Language="C#" MasterPageFile="~/General_Pages/General1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Disaster_Management_System.General_Pages.GeneralRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style29 {
            width: 100%;
        }
        .auto-style32 {
            text-align: center;
            height: 48px;
        }
        .auto-style37 {
        }
        .auto-style40 {
        width: 237px;
    }
        .auto-style42 {
            height: 26px;
            width: 237px;
        }
        .auto-style43 {        text-align: center;
    }
        .auto-style45 {
            height: 26px;
            width: 317px;
        }
        .auto-style46 {
            text-align: left;
        }
        .auto-style48 {
            height: 26px;
            width: 194px;
        text-align: left;
    }
        .auto-style49 {
            height: 29px;
            width: 317px;
        }
        .auto-style50 {
            height: 29px;
            width: 194px;
        text-align: left;
    }
        .auto-style51 {
            height: 29px;
            width: 237px;
        }
        .auto-style52 {
            height: 32px;
        width: 317px;
    }
        .auto-style56 {
            height: 48px;
            width: 194px;
        }
        .auto-style58 {
        height: 32px;
        width: 194px;
    }
    .auto-style59 {
        height: 32px;
        width: 237px;
    }
    .auto-style60 {
        text-align: center;
        height: 26px;
    }
    .auto-style61 {
        height: 26px;
    }
    .auto-style63 {
        height: 48px;
        width: 237px;
    }
    .auto-style64 {
        text-align: center;
        width: 317px;
    }
    .auto-style65 {
        text-align: center;
        height: 26px;
        width: 317px;
    }
    .auto-style66 {
        height: 48px;
        width: 317px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style29">
        <tr>
            <td class="auto-style32" colspan="4">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="20pt" ForeColor="#CC0099" Text="FILL THIS FORM CAREFULLY"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46" colspan="2">
                <asp:Label ID="lblUserClass" runat="server" Font-Bold="True" ForeColor="#00C600"></asp:Label>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style49"></td>
            <td class="auto-style50">
                <asp:Label ID="lblName" runat="server" Text="Enter Your Name  : " style="text-align: right"></asp:Label>
            </td>
            <td class="auto-style51">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">
                <asp:Label ID="lblCountry" runat="server" Text="Country  :" style="text-align: left"></asp:Label>
            </td>
            <td class="auto-style40">
                <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">
                <asp:Label ID="lblState" runat="server" Text="State :"></asp:Label>
            </td>
            <td class="auto-style40">
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style45"></td>
            <td class="auto-style48">
                <asp:Label ID="lblDist" runat="server" Text="District  :"></asp:Label>
            </td>
            <td class="auto-style42">
                <asp:TextBox ID="txtDist" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style61"></td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">
                <asp:Label ID="lblPin" runat="server" Text="Pin  :"></asp:Label>
            </td>
            <td class="auto-style40">
                <asp:TextBox ID="txtPin" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">
                <asp:Label ID="lblMobile" runat="server" Text="Mobile  :"></asp:Label>
            </td>
            <td class="auto-style40">
                <asp:TextBox ID="txtMobile" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">
                <asp:Label ID="lblMail" runat="server"></asp:Label>
            </td>
            <td class="auto-style40">
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">
                <asp:Label ID="lblPass" runat="server" Text="Password  :"></asp:Label>
            </td>
            <td class="auto-style40">
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">
                <asp:Label ID="lblComPass" runat="server" Text="Comfarm Password  :"></asp:Label>
            </td>
            <td class="auto-style40">
                <asp:TextBox ID="txtComPass" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style43" colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style65"></td>
            <td class="auto-style60" colspan="2">
                <asp:Button ID="btnPreview" runat="server" Font-Bold="True" ForeColor="#CC3300"  Text="Preview" Width="170px" Font-Size="12pt" OnClick="btnPreview_Click" />
            </td>
            <td class="auto-style61"></td>
        </tr>
        <tr>
            <td class="auto-style43" colspan="4">
                <asp:Label ID="lblErrorMsg" runat="server" Font-Size="12pt" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style66"></td>
            <td class="auto-style56"></td>
            <td class="auto-style63"></td>
            <td class="auto-style22"></td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style52"></td>
            <td class="auto-style58"></td>
            <td class="auto-style59"></td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style64">&nbsp;</td>
            <td class="auto-style46">&nbsp;</td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style37">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
