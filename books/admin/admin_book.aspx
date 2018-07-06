<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_book.aspx.cs" Inherits="admin_admin_book" %>

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
    
        لیست کتاب ها&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">بازگشت</asp:LinkButton>
        <br />
    
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <div align="center">
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:TextBox ID="txt_id" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">کد کتاب</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">نام کتاب</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txt_author" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">نام نویسنده</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="162px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">ژانر</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button3" runat="server" Text="حذف" Width="72px" OnClick="Button3_Click" />
                        <asp:Button ID="Button2" runat="server" Text="ویرایش" Width="72px" OnClick="Button2_Click" />
                        <asp:Button ID="Button1" runat="server" Text="ثبت" Width="72px" OnClick="Button1_Click" />
                    </td>
                    <td class="auto-style4"></td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
