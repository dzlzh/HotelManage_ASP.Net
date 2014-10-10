<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Room.aspx.cs" Inherits="HotelManage.Room1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
    <table>
        <tr>
            <td>房 间 号：</td>
            <td><asp:TextBox ID="txtRoomName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>客房类型：</td>
            <td><asp:DropDownList ID="ddlType" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>客户状态：</td>
            <td><asp:DropDownList ID="ddlState" runat="server">
                <asp:ListItem Value="arrive">将到</asp:ListItem>
                <asp:ListItem Value="modify">维修</asp:ListItem>
                <asp:ListItem Value="housing">入住</asp:ListItem>
                <asp:ListItem Value="helpOneself">自用</asp:ListItem> 
                <asp:ListItem Value="empty">空闲</asp:ListItem>
                <asp:ListItem Value="leave">离去</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>床 位 数：</td>
            <td><asp:TextBox ID="txtBebNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>客 人 数：</td>
            <td><asp:TextBox ID="txtGuestNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>描&nbsp;述：</td>
            <td><asp:TextBox ID="txtDescription" runat="server" Height="65px" TextMode="MultiLine" Width="239px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" align="center"><asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click"  /></td>
        </tr>
    </table>
</asp:Content>
