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
    }
}