using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dal;
namespace Bll
{
     public class admin
    {
        public int adminAdd(Model.admin admin)
        {
            string sql = "insert into  admin(username,password)values('" + admin.username + "','" + admin.password + "')";
            return DbHelperSQL.ExecuteSql(sql);
        }

        public int adminUpdate(Model.admin admin)
        {
            string sql = "update admin set username='" + admin.username + "',password='" + admin.password + "' where id=" + admin.id;
            return DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetadminList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from admin ");
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
        public void Deleteadmin(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete admin ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
    }
}
