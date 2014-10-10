using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelManage
{
    public partial class ViewRoom : System.Web.UI.Page
    {
        public string GetType(object id)
        {
            int Typeid = Convert.ToInt32(id);
            string sqlstr = string.Format("select TypeName from RoomType where TypeID={0}", Typeid);
            string Name=DBHelper.GetTable(sqlstr).Rows[0]["TypeName"].ToString();
            return Name;
        }
        public string GetState(object State)
        {
            string state = State.ToString();
            string ZT = "";
            if (state == "arrive")
            {
               ZT=  "将到";
            }
            else if (state == "modify")
            {
                ZT = "维修";
            }
            else if (state == "housing")
            {
                ZT = "入住";
            }
            else if (state == "helpOneself")
            {
                ZT = "自用";
            }
            else if (state == "empty")
            {
                ZT = "空闲";
            }
            else if (state == "leave")
            {
                ZT = "离去";
            }
            return ZT;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = Room.GetRoom();
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
            int roomid = Convert.ToInt32(e.CommandArgument);
            if (cmd == "De")
            {
                Room.DeleteRoom(roomid);
            }
            else if (cmd == "Ed")
            {
                Response.Redirect("Room.aspx?id=" + Convert.ToInt32(roomid));
            }
            GridView1.DataSource = Room.GetRoom();
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = Room.GetRoom();
            GridView1.DataBind();
        }


    }
}