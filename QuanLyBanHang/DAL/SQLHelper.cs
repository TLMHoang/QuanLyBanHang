using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class SQLHelper
    {
        private string connStr = @"Data Source=DESKTOP-MPFCGCF;Initial Catalog=QLBH;Integrated Security=True";


        public async Task<int> ExecuteNonQuery(string ProcName, params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(ProcName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        await con.OpenAsync();
                        return await cmd.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n\n" + ex.ToString());
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }

            return 0;
        }
        
        public  async Task<DataTable> ExecuteQuery(string ProcName, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(ProcName,con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        await con.OpenAsync();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi \n\n" + ex.ToString());
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }

            return dt;
        }
    }
}
