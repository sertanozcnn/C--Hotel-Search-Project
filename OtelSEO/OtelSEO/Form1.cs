using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OtelSEO
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True");







      


        public static string name ;

        public Form1()
        {
            InitializeComponent();


        }


        private static Regex email_check() //
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex validate_emailcheck = email_check();

        private void guna2Button1_Click(object sender, EventArgs e) //LOGİN
        {



            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True");


            string query = "Select*From register_user Where Email ='" + login_email.Text.Trim() + "' and Password = '" + login_password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            name = login_email.Text;

            if (dtbl.Rows.Count == 1)
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Not Found");
            }



            //////////EMAİL_CHECK

            if (validate_emailcheck.IsMatch(login_email.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                login_email.Focus();
                return;
            }
            else { }
        }

        private void guna2Button2_Click(object sender, EventArgs e) //REGİSTER
        {            
            guna2Panel2.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e) //CREATE
        {
            if (register_username.Text == "" || register_username.Text == "" || register_email.Text == "" || register_password.Text == "" || phone_number.Text == "" || Province.Text == "")
            {
                MessageBox.Show("Please Fill In The Fields Fully");
            }
            else if(register_password.Text != register_again_password.Text)
            {
                MessageBox.Show("Passwords Incompatible");
            }
            string connection = @"Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "insert into register_user(Username,Email,Password,PhoneNumber,Province) Values('"+register_username.Text+ "','"+register_email.Text+ "','"+register_password.Text+ "','"+phone_number.Text+"','"+Province.Text+"');";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Data Saved");
                ClearData();
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

        private void ClearData()
        {
            register_username.Text = "";
            register_email.Text = "";
            register_password.Text = "";
        }


        private void Province_SelectedIndexChanged(object sender, EventArgs e)
        {

            


        }

        
        private void email(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z\\.]+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(login_email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.login_email, "Plzz Provide");
                return;
            }
        }







        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Panel1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Province";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Province.Items.Add(dr["Province"]);

            }
            baglanti.Close();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_again_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
