using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Barcode = BarcodeLib.Barcode;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;
namespace OtelSEO
{
    public partial class BarcodeRead : Form
    {
        public BarcodeRead()
        {
            InitializeComponent();
        }
        string usernameBR, emailBR, phoneNumberBR,provinceBR,housetypeBR,locationBR,dateLoginBR,dateExitBR,totalBR,personBR, barcodeBR;

    

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        string SaveFileNameCheck(string path, string filename)
        {
            if (!Directory.Exists(path)) return "";
            string filenamewoext = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);
            int count = 1;
            while (File.Exists(path + filename))
            {
                filename = filenamewoext + "(" + count.ToString() + ")" + extension;
                count++;
            }
            return path + filename;
        }
        private void panel_login_Click(object sender, EventArgs e)
        {
            string MyDesktopPath = Environment.GetFolderPath(
                                System.Environment.SpecialFolder.DesktopDirectory) + "\\";

            using (Bitmap bmpScreenshot = new Bitmap(Bounds.Width, Bounds.Height, PixelFormat.Format32bppArgb))
            {
                Rectangle rect = new Rectangle(0, 0, this.Bounds.Width, 480);
                this.DrawToBitmap(bmpScreenshot, rect);

                // Build the filename
                string myFilepath = SaveFileNameCheck(MyDesktopPath, "Ticket.png");
                if (myFilepath == "")
                {
                    Console.WriteLine("Form image save FAILED!");
                    return;
                }
                bmpScreenshot.Save(myFilepath, ImageFormat.Png);
                Console.WriteLine("Form image saved: {0}", myFilepath);
            }

            this.Close();

        }




        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void BarcodeRead_Load(object sender, EventArgs e)
        {
        
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True;" + "MultipleActiveResultSets=True;"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Text, connection))
                {
                    cmd.CommandText = String.Format("SELECT Username,Email,PhoneNumber,Province,Select_HouseType,Select_Location,Select_DateLogin,Select_DateExit,Total,Select_Person,Barcode FROM BarcodeReaderScan WHERE Barcode = '{0}';", Home.read_barcode);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        usernameBR = dr["Username"].ToString();
                        emailBR = dr["Email"].ToString();
                        phoneNumberBR = dr["PhoneNumber"].ToString();
                        provinceBR = dr["Province"].ToString();
                        housetypeBR = dr["Select_HouseType"].ToString();
                        locationBR = dr["Select_Location"].ToString();
                        dateLoginBR = dr["Select_DateLogin"].ToString();
                        dateExitBR = dr["Select_DateExit"].ToString();
                        totalBR = dr["Total"].ToString();
                        personBR = dr["Select_Person"].ToString();
                        barcodeBR = dr["Barcode"].ToString();




                    }
                }
            }
            ad_label.Text = usernameBR;
            email_label.Text = emailBR;
            phone_label.Text = phoneNumberBR;
            province_label.Text = provinceBR;
            oteltip_label.Text = locationBR;
            otelkonum_label.Text = housetypeBR;
            otelgiris_label.Text = dateLoginBR;
            otelcikis_label.Text = dateExitBR;
            total_label.Text = totalBR;
            kisiSayi_label.Text = personBR;
            barcode_read_label.Text = barcodeBR;

            barcode_read_label.Text = barcodeBR;

            string barCode = barcode_read_label.Text;

            //pictureBox1.Image = img2;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

                Image img2 = brCode.Draw(barCode, 250);

                pictureBox1.Image = img2;
            }
            catch(Exception)
            {

            }
           


        }
    }
    
}
