using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ldxt
{
    internal class DBHelper
    {
        // 连接字符串，请根据实际情况修改
        public static string str { get; } = "server=.;database=Smartsystem;uid=sa;pwd=sasa";

        // 执行单值查询，返回第一行第一列的结果
        public static object DHDL(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        if (parameters != null)
                        {
                            com.Parameters.AddRange(parameters);
                        }
                        con.Open();
                        return com.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("执行 ExecuteScalar 时发生错误: " + ex.Message);
                }
            }
        }

        // 执行查询，返回 SqlDataReader 对象
        public static SqlDataReader DQQ(string sql, SqlParameter[] parameters = null)
        {
            SqlConnection con = new SqlConnection(str);
            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                if (parameters != null)
                {
                    com.Parameters.AddRange(parameters);
                }
                con.Open();
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                con.Close();
                throw new Exception("执行 ExecuteReader 时发生错误: " + ex.Message);
            }
        }

        // 执行增删改操作，返回受影响的行数
        public static int ZSG(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    using (SqlCommand com = new SqlCommand(sql, con))
                    {
                        if (parameters != null)
                        {
                            com.Parameters.AddRange(parameters);
                        }
                        con.Open();
                        return com.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("执行 ExecuteNonQuery 时发生错误: " + ex.Message);
                }
            }
        }

        // 执行查询，返回 DataTable
        public static DataTable SPQ(string sql, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                try
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(sql, con))
                    {
                        if (parameters != null)
                        {
                            sda.SelectCommand.Parameters.AddRange(parameters);
                        }
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("执行 ExecuteQuery 时发生错误: " + ex.Message);
                }
            }

        }
        public static object DSG(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"执行 ExecuteScalar 时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
        }
    }
}
