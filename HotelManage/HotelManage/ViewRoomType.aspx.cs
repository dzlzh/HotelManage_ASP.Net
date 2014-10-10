using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelManage
{
    public partial class ViewRoomType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = RoomType.GetRoomType();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor");

                ImageButton imgbtn = (ImageButton)e.Row.FindControl("delete");
                imgbtn.Attributes.Add("onclick", "return confirm('您确定要删除吗？');");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string cmd = e.CommandName;
            int typeid = Convert.ToInt32(e.CommandArgument);
            if (cmd == "De")
            {
                RoomType.DeleteRoomType(typeid);
            }
            else if(cmd=="Ed")
            {
                Response.Redirect("RoomType.aspx?id="+Convert.ToInt32(typeid));
            }
            GridView1.DataSource = RoomType.GetRoomType();
            GridView1.DataBind();
        }
    }
}