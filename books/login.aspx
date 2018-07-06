<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style1 {
            width: 34%;
        }
        .auto-style2 {
            height: 38px;
        }
        .auto-style3 {
            width: 87px;
        }
        .auto-style4 {
            height: 38px;
            width: 87px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
        لطفا وارد شوید
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="txt_uname" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">نام کاربری</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style3">رمز عبور</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="162px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style3">نقش</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">ثبت نام کنید</asp:LinkButton>
&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="ورود" Width="72px" OnClick="Button1_Click" />
                </td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    </div>
</asp:Content>

