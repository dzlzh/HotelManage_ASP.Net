<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewRoomType.aspx.cs" Inherits="HotelManage.ViewRoomType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" DataKeyNames="TypeID" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="TypeName" HeaderText="类型名称" />
            <asp:BoundField DataField="TypePrice" HeaderText="类型价格" />
            <asp:BoundField DataField="AddBedPrice" HeaderText="加床价格" />
            <asp:BoundField DataField="IsAddBed" HeaderText="是否加床" />
            <asp:BoundField DataField="Remark" HeaderText="备注" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="edit" runat="server" ImageUrl="~/image/edit.gif"  CommandArgument=<%#Eval("TypeID")%> CommandName="Ed"  />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="delete" runat="server" ImageUrl="~/image/delete.gif" CommandArgument=<%#Eval("TypeID")%> CommandName="De"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
