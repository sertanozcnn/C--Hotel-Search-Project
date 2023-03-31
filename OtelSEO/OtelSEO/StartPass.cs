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
using System.Xml.Linq;

namespace OtelSEO
{
    public partial class StartPass : Form
    {
        public StartPass()
        {
            InitializeComponent();
        }

        private void start_pass_TextChanged(object sender, EventArgs e)
        {
           
                SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True");


                string query = "Select*From random Where sifre_giris ='" + start_pass.Text.Trim() +"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

            if (start_pass.Text.Length == 4)
            {

                if (dtbl.Rows.Count == 1)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış Pin");
                }

            }


      

         }

        private void StartPass_Load(object sender, EventArgs e)
        {

        }
    }

}

