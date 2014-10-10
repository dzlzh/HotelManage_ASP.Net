using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace HotelManage
{
    public class Room
    {
        public static DataTable GetRoom()
        {
            string sqlstr = "select * from Room";
            return DBHelper.GetTable(sqlstr);
        }
        public static void DeleteRoom(int roomid)
        {
            string sqlstr = string.Format("delete from Room where RoomID={0}", roomid);
            int index = DBHelper.SqlZSG(sqlstr);
        }
        public static DataTable GetRoomID(int roomid)
        {
            string sqlstr = string.Format("select * from Room where RoomID={0}", roomid);
            return DBHelper.GetTable(sqlstr);
        }
        public static int EditRoom(int roomid, int typeid, string state, int bednumber, int gustnumber,string description)
        {
            string sqlstr = string.Format("update Room set TypeID={0},State='{1}',BedNumber={2},GuestNumber={3},Description='{4}' where RoomID={5}", typeid, state, bednumber, gustnumber, description, roomid);
            return DBHelper.SqlZSG(sqlstr);
        }
        public static int InsertRoom(string Number, int TypeID, int BedNumber, string Description, string State, int GustNumber)
        {
            string sqlstr = string.Format("insert into Room values ('{0}',{1},{2},'{3}','{4}',{5}) ", Number,  TypeID,  BedNumber,  Description,  State, GustNumber);
            return DBHelper.SqlZSG(sqlstr);
        }
    }
}