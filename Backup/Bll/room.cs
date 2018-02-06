using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dal;
namespace Bll
{
    public class room
    {
        public int roomAdd(Model.room room)
        {
            string sql = "insert into room(louhao,loucheng,roomno,person,telphone,jilu,weisheng)values";
            sql += "('" + room.louhao + "','" + room.loucheng + "','" + room.roomno + "','" + room.person + "','" + room.telphone + "','" + room.jilu + "','" + room.weisheng + "')";
            return DbHelperSQL.ExecuteSql(sql);
        }

        public int roomUpdate(Model.room room)
        {
            string sql = "update room set louhao='" + room.louhao + "',loucheng='" + room.loucheng + "',roomno='" + room.roomno + "',person='" + room.person + "',telphone='" + room.telphone + "',jilu='" + room.jilu + "' ,weisheng='" + room.weisheng + "' where id=" + room.id;
            return DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetroomList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from room ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id desc");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Deleteroom(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete room ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
    }
}
