using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace HotelManage
{
    public partial class RoomType1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"]!= null)
                {
                    txtName.Enabled = false;
                    int typeid = Convert.ToInt32(Request.QueryString["id"]);
                    DataTable ds = new DataTable();
                    ds = RoomType.GetRoomTypeID(typeid);
                    txtName.Text = ds.Rows[0]["TypeName"].ToString();
                    txtPrice.Text = ds.Rows[0]["TypePrice"].ToString();
                    txtAddBed.Text = ds.Rows[0]["AddBedPrice"].ToString();
                    string YNAddBed = ds.Rows[0]["IsAddBed"].ToString().Trim();
                    if (YNAddBed == "是")
                    {
                        rdbYes.Checked = true;
                    }
                    else if (YNAddBed == "否")
                    {
                        rdbNo.Checked = true;
                    }
                    txtRemark.Text = ds.Rows[0]["Remark"].ToString();
                    
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int typeid = Convert.ToInt32(Request.QueryString["id"]);
            string Name = txtName.Text.Trim();
            double Price = Convert.ToDouble(txtPrice.Text.Trim());
            double AddBed = Convert.ToDouble(txtAddBed.Text.Trim());
             string IsBed="";
             if(rdbYes.Checked)
             {
                IsBed="是";
             }
             else if(rdbNo.Checked)
             {
                IsBed="否";
             }
             string Remark = txtRemark.Text.Trim();
             if (Request.QueryString["id"] != null)
             {
                 int Edit = RoomType.EditRoomTpye(typeid, Price, AddBed, IsBed, Remark);
                 if (Edit > 0)
                 {
                     Response.Write("<script>alert('修改成功！');</script>");
                     Response.Redirect("ViewRoomType.aspx");

                 }
                 else
                 {
                     Response.Write("<script>alert('修改失败！');</script>");
                 }
             }
             else
             {
                 int inster = RoomType.InsertRoomType(Name, Price, AddBed, IsBed, Remark);
                 if (inster > 0)
                 {
                     Response.Write("<script>alert('增加成功！');</script>");
                     Response.Redirect("ViewRoomType.aspx");

                 }
                 else
                 {
                     Response.Write("<script>alert('增加失败！');</script>");
                 }
             }
        }
    }
}