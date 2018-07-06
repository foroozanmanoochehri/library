<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zhaner.aspx.cs" Inherits="admin_zhaner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 34%;
        }
        .auto-style3 {
            width: 87px;
        }
        .auto-style2 {
            height: 38px;
        }
        .auto-style4 {
            height: 38px;
            width: 87px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        ثبت ژانر جدید&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">بازگشت</asp:LinkButton>
    
        <br />
        <div align="center">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="162px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">ژانر</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">نام ژانر</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button3" runat="server" Text="حذف" Width="72px" OnClick="Button3_Click" />
                        <asp:Button ID="Button2" runat="server" Text="ویرایش" Width="72px" OnClick="Button2_Click" />
                        <asp:Button ID="Button4" runat="server" Text="ثبت" Width="72px" OnClick="Button4_Click" />
                    </td>
                    <td class="auto-style4"></td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
