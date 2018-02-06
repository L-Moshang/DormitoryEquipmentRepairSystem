using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dal;
namespace Bll
{
    public class repair
    {

        public int repairAdd(Model.repair re)
        {
            string sql = "insert into repair(name,roomno,sname,stuno,madetime,reason)values('" + re.name + "','" + re.roomno + "','" + re.sname + "','" + re.stuno + "','" + re.madetime + "','" + re.reason + "')";
            return DbHelperSQL.ExecuteSql(sql);
        }

        public int repaireUpdate(Model.repair re)
        {
            string sql = "update repair set name='" + re.name + "',roomno='" + re.roomno + "',sname='" + re.sname + "',stuno='" + re.stuno + "',madetime='" + re.madetime + "',reason='" + re.reason + "' where id=" + re.id;
            return DbHelperSQL.ExecuteSql(sql);
        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetrepairList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from repair ");
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
        public void Deleterepair(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete repair ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
    }
}
