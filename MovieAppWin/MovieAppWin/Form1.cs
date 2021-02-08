using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieAppWin
{
    public partial class Form1 : Form
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());

        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataTable dt = null;
        private void ShowData()
        {
            using (cmd = new SqlCommand("select * from MovieTable", cn))
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                cn.Close();
                
            }
        }
            public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_ShowMovieDetails", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@movieid", SqlDbType.Int).Value = txtMid.Text;
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows && dr.Read())
                    {
                        lblMName2.Text = dr["moviename"].ToString();
                        lblActor2.Text = dr["actor"].ToString();
                        lblTSold2.Text = dr["tickets"].ToString();

                        dr.Close();
                        cn.Close();
                        ShowData();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
            try
            {
                using (cmd = new SqlCommand("sp_ShowMovieNames", cn))
                {
                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    dr.Close();
                    cn.Close();

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                ShowData();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_UpdateMovie", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@movieid", SqlDbType.Int).Value = txtMid.Text;
                        cmd.Parameters.Add("@mname", SqlDbType.VarChar, 30).Value = txtMName.Text;
                        cmd.Parameters.Add("@mactor", SqlDbType.VarChar, 20).Value = txtActor.Text;
                        cmd.Parameters.Add("@mtickets", SqlDbType.Int).Value = txtTsold.Text;
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cn.Close();
                    ShowData();
                     }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            
            
        
    }
    }
    }
