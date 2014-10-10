using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace HotelManage
{
    public class RoomType
    {
        public static DataTable GetRoomType()
        {
            string sqlstr = "select * from RoomType";
            return DBHelper.GetTable(sqlstr);
        }
        public static void DeleteRoomType(int typeid)
        {
            string sqlstr = string.Format("delete from RoomType where TypeID={0}", typeid);
            int index = DBHelper.SqlZSG(sqlstr);
        }
        public static DataTable GetRoomTypeID(int typeid)
        {
            string sqlstr=string.Format("select * from RoomType where TypeID={0}",typeid);
            return DBHelper.GetTable(sqlstr);
        }
        public static int EditRoomTpye(int Id,  double Price, double AddBed, string IsBed, string Remark)
        {
            string sqlstr = string.Format("update RoomType set TypePrice={0},AddBedPrice={1},IsAddBed='{2}',Remark='{3}' where TypeID={4}",  Price, AddBed, IsBed, Remark, Id);
            return DBHelper.SqlZSG(sqlstr);
        }
        public static int InsertRoomType(string Name, double Price, double AddBed, string IsBed, string Remark)
        {
            string sqlstr = string.Format("insert into RoomType values ('{0}',{1},{2},'{3}','{4}') ",Name,Price,AddBed,IsBed,Remark);
            return DBHelper.SqlZSG(sqlstr);
        }
    }
}