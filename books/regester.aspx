<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="regester.aspx.cs" Inherits="regester" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style1 {
            width: 34%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div align="center">
        ثبت نام کنید
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                </td>
                <td>نام</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_uname" runat="server"></asp:TextBox>
                </td>
                <td>نام کاربری</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_pass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>رمز عبور</td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="162px">
                    </asp:DropDownList>
                </td>
                <td>نقش</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="ثبت" Width="72px" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>

