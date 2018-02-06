using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Dal
{
    /// <summary>
    /// 数据访问基类
    /// </summary>
    public abstract class DbHelperSQL
    {
        public DbHelperSQL()
        { }
        /// <summary>
        /// 连接数据库对象
        /// </summary>
        protected static string connstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region 公用方法
        /// <summary>
        /// 参数化检查登录用户
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static bool Exists(string strSql, params SqlParameter[] cmdParms)
        {
            object obj = GetSingle(strSql, cmdParms);
            int cmdresult;//结果
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region 执行简单的SQL语句
        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string strSql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand comm = new SqlCommand(strSql, conn))
                {
                    try
                    {
                        conn.Open();
                        int rows = comm.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        conn.Close();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static object GetSingle(string strSql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand comm = new SqlCommand(strSql, conn))
                {
                    try
                    {
                        conn.Open();
                        object obj = comm.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        conn.Close();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 执行连接式查询语句，返回SqlDataReader
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string strSql)
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand comm = new SqlCommand(strSql, conn);
            try
            {
                conn.Open();
                SqlDataReader myReader = comm.ExecuteReader();
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }

        }
        /// <summary>
        /// 执行非连接式查询语句，返回DataSet
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public static DataSet Query(string strSql)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter(strSql, conn);
                    cmd.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    throw new Exception(e.Message);
                }
                return ds;
            }
        }
        #endregion

        #region 执行带参数的SQL语句
        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="cmdParms"></param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string strSQL, params SqlParameter[] cmdParms)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(comm, conn, strSQL, cmdParms);
                        int rows = comm.ExecuteNonQuery();
                        comm.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }

        }
        /// <summary>
        /// SQL语句的参数化赋值
        /// </summary>
        /// <param name="comm">SqlCommand对象</param>
        /// <param name="conn">SqlConnection对象</param>
        /// <param name="cmdText">Sql语句</param>
        /// <param name="cmdParms">SQL参数</param>
        public static void PrepareCommand(SqlCommand comm, SqlConnection conn, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            comm.Connection = conn;
            comm.CommandText = cmdText;
            comm.CommandType = CommandType.Text;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                {
                    comm.Parameters.Add(parm);
                }
            }
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="cmdParms"></param>
        /// <returns></returns>
        public static object GetSingle(string strSQL, params SqlParameter[] cmdParms)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                using (SqlCommand cmd = new SqlCommand(strSQL, conn))
                {
                    try
                    {
                        if (cmdParms != null)
                        {
                            foreach (SqlParameter parm in cmdParms)
                            {
                                cmd.Parameters.Add(parm);
                            }
                        }
                        conn.Open();
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string strSQL, params SqlParameter[] cmdParms)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                SqlCommand comm = new SqlCommand(strSQL, conn);
                using (SqlDataAdapter da = new SqlDataAdapter(comm))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        if (cmdParms != null)
                        {
                            foreach (SqlParameter parm in cmdParms)
                            {
                                comm.Parameters.Add(parm);
                            }
                        }
                        da.Fill(ds, "ds");
                        comm.Parameters.Clear();
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw new Exception(e.Message);
                    }
                    return ds;
                }
            }
        }
        #endregion

    }
}
