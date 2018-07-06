<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <p>پنل مدیریتی&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">خروج</asp:LinkButton>
        </p>
    </div>
        <div align="center">
            <p>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">لیست درخواست ها</asp:LinkButton>
            </p>
    </div>
        <div align="center">
            <p>
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">لیست تمام کاربران</asp:LinkButton>
            </p>
    </div>
        <div align="center">
            <p>
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">لیست کتاب ها</asp:LinkButton>
            </p>
    </div>
        <div align="center">
            <p>
                <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">لیست ژانر ها</asp:LinkButton>
            </p>
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
