using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelSEO
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }


        string username, email, phoneNumber, province,password;

        private void register_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Province_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

            register_email.Enabled = false;



            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True;" + "MultipleActiveResultSets=True;"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Text, connection))
                {
                    cmd.CommandText = String.Format("SELECT Username,Email,PhoneNumber,Province,Password FROM register_user WHERE Email = '{0}';", Form1.name);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        username = dr["Username"].ToString();
                        email = dr["Email"].ToString();
                        phoneNumber = dr["PhoneNumber"].ToString();
                        province = dr["Province"].ToString();
                    }
                }
            }
            register_username.Text = username;
            register_email.Text = email;
            phone_number.Text = phoneNumber;        

        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {


            string connection = @"Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = String.Format("UPDATE register_user SET Username = '{0}' ,Password = '{1}',PhoneNumber = '{2}' WHERE Email ='{3}';", register_username.Text, register_password.Text, phone_number.Text, register_email.Text);
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Data Saved");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();

            }





       

        }
    }
}
