using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dal;
namespace Bll
{
     public class shebie
    {
        public int shebieAdd(Model.shebie shebie)
        {
            string sql = "insert into  shebie(wname)values('" + shebie.wname + "')";
            return DbHelperSQL.ExecuteSql(sql);
        }

        public int shebieUpdate(Model.shebie shebie)
        {
            string sql = "update shebie set wname='" + shebie.wname + "' where id=" + shebie.id;
            return DbHelperSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetshebieList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from shebie ");
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
        public void Deleteshebie(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete shebie ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
    }
}
