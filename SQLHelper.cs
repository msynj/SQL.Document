using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//分支一修改
//分支二修改
//分支一修改
public class SQLHelper
{
    //Main
    //V1
    //V2
    private static string connString = ConfigurationManager.ConnectionStrings["Corporation"].ConnectionString;

    public static DataTable ExecuteDataTable(CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            //设置参数
            foreach (SqlParameter parm in cmdParms)
            {
                cmd.Parameters.Add(parm);
            }
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds.Tables[0];
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    public static DataTable ExecuteDataTable(CommandType cmdType, string cmdText)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds.Tables[0];
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    public static SqlDataReader ExecuteReader(CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlCommand cmd = new SqlCommand();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            //设置参数
            foreach (SqlParameter parm in cmdParms)
            {
                cmd.Parameters.Add(parm);
            }
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    public static SqlDataReader ExecuteReader(CommandType cmdType, string cmdText)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlCommand cmd = new SqlCommand();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    public static object ExecuteScalar(CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlCommand cmd = new SqlCommand();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            //设置参数
            foreach (SqlParameter parm in cmdParms)
            {
                cmd.Parameters.Add(parm);
            }
            object obj = cmd.ExecuteScalar();
            return obj;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    public static object ExecuteScalar(CommandType cmdType, string cmdText)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlCommand cmd = new SqlCommand();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            object obj = cmd.ExecuteScalar();
            return obj;
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    public static void ExecuteNonQuery(CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlCommand cmd = new SqlCommand();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            //设置参数
            foreach (SqlParameter parm in cmdParms)
            {
                cmd.Parameters.Add(parm);
            }
            cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }

    public static void ExecuteNonQuery(CommandType cmdType, string cmdText)
    {
        SqlConnection conn = new SqlConnection(connString);
        SqlCommand cmd = new SqlCommand();

        //使用try/catch结构执行SQL文本命令/存储过程
        try
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            conn.Close();
        }
    }
}
