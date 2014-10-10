<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RoomType.aspx.cs" Inherits="HotelManage.RoomType1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
    <div>
        <table >
            <tr>
                <td>类型名称：</td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>类型价格：</td>
                <td><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>加床价格：</td>
                <td><asp:TextBox ID="txtAddBed" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>是否加床：</td>
                <td><asp:RadioButton ID="rdbYes" runat="server" GroupName="YNAddBed" />是<asp:RadioButton ID="rdbNo" runat="server" GroupName="YNAddBed"/>否</td>
            </tr>
            <tr>
                <td>备&nbsp;&nbsp;注：</td>
                <td><asp:TextBox ID="txtRemark" runat="server" Height="90px" TextMode="MultiLine" Width="300px"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="center"><asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
