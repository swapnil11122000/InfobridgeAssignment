<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="InfobridgeProject.Information" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 381px;
        }
        .auto-style3 {
            height: 687px;
        }
        .auto-style4 {
            height: 249px;
        }
        .auto-style5 {
            width: 381px;
            height: 249px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <table class="auto-style1">
                <tr>
                    <td>Id</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click1" Text="Search" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click1" Text="Delete" Width="55px" />
                    </td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>DOB</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Sex</td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="rbtSex" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" Width="70px" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click1" Text="Update" Width="75px" />
                    </td>
                    <td>
                        <asp:Label ID="lblMsg" runat="server" Text="Msg"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:GridView ID="GridView1" runat="server" Width="355px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
