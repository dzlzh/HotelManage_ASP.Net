using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace HotelManage
{
    public partial class Room1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlType.DataSource = RoomType.GetRoomType();
                ddlType.DataTextField = "TypeName";
                ddlType.DataValueField = "TypeID";
                ddlType.DataBind();
                if (Request.QueryString["id"] != null)
                {
                    txtRoomName.Enabled = false;
                    int roomid = Convert.ToInt32(Request.QueryString["id"]);
                    
                    DataTable ds = new DataTable();
                    ds = Room.GetRoomID(roomid);
                    txtRoomName.Text = ds.Rows[0]["Number"].ToString();
                    ddlType.SelectedValue = ds.Rows[0]["TypeID"].ToString();
                    ddlState.SelectedValue = ds.Rows[0]["State"].ToString();
                    txtBebNumber.Text = ds.Rows[0]["BedNumber"].ToString();
                    txtGuestNumber.Text = ds.Rows[0]["GuestNumber"].ToString();
                    txtDescription.Text = ds.Rows[0]["Description"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int roomid = Convert.ToInt32(Request.QueryString["id"]);
            string Number = txtRoomName.Text.Trim();
            int TypeID =Convert.ToInt32( ddlType.SelectedValue);
            string State = ddlState.SelectedValue;
            int BedNumber = Convert.ToInt32(txtBebNumber.Text.Trim());
            int GustNumber = Convert.ToInt32(txtGuestNumber.Text.Trim());
            string Description = txtDescription.Text.Trim();
            if (Request.QueryString["id"] != null)
            {
                int Edit = Room.EditRoom(roomid, TypeID, State, BedNumber, GustNumber, Description);
                if (Edit > 0)
                {
                    Response.Write("<script>alert('修改成功！');</script>");
                    Response.Redirect("ViewRoom.aspx");
                }
                else
                {
                    Response.Write("<script>alert('修改失败！');</script>");
                }
            }
            else
            {
                int inster = Room.InsertRoom(Number,TypeID,  BedNumber, Description,State, GustNumber);
                if (inster > 0)
                {
                    Response.Write("<script>alert('增加成功！');</script>");
                    Response.Redirect("ViewRoom.aspx");
                }
                else
                {
                    Response.Write("<script>alert('增加失败！');</script>");
                }
            }
        }
    }
}