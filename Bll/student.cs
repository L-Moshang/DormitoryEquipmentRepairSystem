using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Dal;

namespace Bll
{
     public class student
    {
         public int studentAdd(Model.student stu)
         {
             string sql = "insert into student(stuno,name,sex,zhuanye,roomno,bedno,intime,stuphone,teaphone,outtime,pass) values";
             sql += "('" + stu.stuno + "','" + stu.name + "','" + stu.sex + "','" + stu.zhuanye + "','" + stu.roomno + "','" + stu.bedno + "','" + stu.intime + "','" + stu.stuphone + "','" + stu.teaphone + "','" + stu.outtime + "','"+stu.pass+"')";
             return DbHelperSQL.ExecuteSql(sql);
         }

         public int studentUpate(Model.student stu)
         {
             string sql = "update student set stuno='" + stu.stuno + "',name='" + stu.name + "',sex='" + stu.sex + "',zhuanye='" + stu.zhuanye + "',roomno='" + stu.roomno + "',";
             sql += "bedno='" + stu.bedno + "',intime='" + stu.intime + "',stuphone='" + stu.stuphone + "',teaphone='" + stu.teaphone + "',outtime='" + stu.outtime + "' where id=" + stu.id;
             return DbHelperSQL.ExecuteSql(sql);
         }

        /// <summary>
        /// 获得数据列表
        /// </summary>
         public DataSet GetstudentList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from student ");
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
         public void Deletestudent(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete student ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
    }
}
