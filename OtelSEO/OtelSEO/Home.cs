using BarcodeLib;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.xmp.impl;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Utilities.Collections;
using OtelSEO.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters.Entities;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static ZXing.QrCode.Internal.Mode;
using Barcode = BarcodeLib.Barcode;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;
using Rectangle = System.Drawing.Rectangle;

namespace OtelSEO
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Logout_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            barcode_Search.Text = BarcodeCam.BarcodeName;

            //welcome_name.Text = Form1.name.ToString();

            // guna2DataGridView1.Columns.Add("NNA","gsa");
            // guna2DataGridView1.Columns.Add("NNA", "fsd");



            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True;" + "MultipleActiveResultSets=True;"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Text, connection))
                {
                    cmd.CommandText = String.Format("SELECT Username FROM register_user WHERE Email = '{0}';", Form1.name);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        welcome_name.Text = "Hoşgeldin " + dr["Username"].ToString();

                    }


                }
                using (SqlCommand cmd2 = new SqlCommand(Text, connection))
                {
                    cmd2.CommandText = "SELECT *FROM Province";
                    cmd2.Connection = connection;
                    cmd2.CommandType = CommandType.Text;
                    SqlDataReader dr;
                    dr = cmd2.ExecuteReader();
                    while (dr.Read())
                    {
                        Province.Items.Add(dr["Province"]);

                    }

                }

                // etc
            }

           


            price_trackbar.Minimum = 0;
            price_trackbar.Maximum = 10000;


            /*SqlConnection transition = new SqlConnection("Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True;" +"MultipleActiveResultSets=True;") ;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = String.Format("SELECT Username FROM register_user WHERE Email = '{0}';", Form1.name);
            cmd.Connection = transition;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            transition.Open();
            dr = cmd.ExecuteReader();





            while (dr.Read())
            {
                welcome_name.Text = "Welcome " + dr["Username"].ToString();

            }

            transition.Close();*/




            /*SqlConnection baglanti = new SqlConnection();
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
            baglanti.Close();*/



            read_barcode = barcode_Search.Text;



        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void price_trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            price_textbox.Text = price_trackbar.Value.ToString();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                price_trackbar.Value = Convert.ToInt32(price_textbox.Text);
            }
            catch
            {

            }
        }

        private void price_value_Click(object sender, EventArgs e)
        {

        }

        private void price_textbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void price_textbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {




            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True");
            try
            {
                string query = "Select*From Search Where Location ='" + Province.Text.Trim() + "' and Price BETWEEN 0 AND '" + price_textbox.Text.Trim() + "' and Point = '" +star_point.Value.ToString()+ "'and HouseType='" + HouseType.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                guna2DataGridView1.DataSource = dtbl;

                dtbl.Columns[0].ColumnName = "ID";
                dtbl.Columns[1].ColumnName = "Fotoğraf";
                dtbl.Columns[2].ColumnName = "Konum";
                dtbl.Columns[3].ColumnName = "Günlük Fiyat";
                dtbl.Columns[4].ColumnName = "Puan";
                dtbl.Columns[5].ColumnName = "Ev Tipi";



                int a = Convert.ToInt32(person_combox.SelectedItem.ToString());

                DateTime ilkdeger = datetimepicker_one.Value;
                DateTime sondeger = datetimepicker_two.Value;

                System.TimeSpan zaman;
                zaman = sondeger.Subtract(ilkdeger);
                int toplamgun = Convert.ToInt32(zaman.TotalDays);


                string query2 = "Select Price *" + a * toplamgun + "AS ToplamFiyat FROM Search  Where Location ='" + Province.Text.Trim() + "' and Price BETWEEN 0 AND '" + price_textbox.Text.Trim() + "' and Point = '" + star_point.Value.ToString() + "'and HouseType='" + HouseType.Text.Trim() + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, baglanti);
                DataTable dtbl2 = new DataTable();
                sda2.Fill(dtbl2);
                guna2DataGridView2.DataSource = dtbl2;



                DataGridViewColumn column = guna2DataGridView1.Columns[7];
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                ((DataGridViewImageColumn)guna2DataGridView1.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                guna2DataGridView1.Rows[0].Height = 100;




            }
            catch
            {
                MessageBox.Show("Farklı Değerler Giriniz");

            }


       

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void welcome_name_Click(object sender, EventArgs e)
        {

        }

        private void Province_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void person_combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = null;



            guna2DataGridView2.Columns.Clear();
        }

        private void HouseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void star_point_ValueChanged(object sender, EventArgs e)
        {

        }

        string username_print, email_print, phoneNumber_print, province_print;

        string deger;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True;" + "MultipleActiveResultSets=True;"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Text, connection))
                {
                    cmd.CommandText = String.Format("SELECT Username,Email,PhoneNumber,Province FROM register_user WHERE Email = '{0}';", Form1.name);
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        username_print =  dr["Username"].ToString();
                        email_print   = dr["Email"].ToString();
                        phoneNumber_print = dr["PhoneNumber"].ToString();
                        province_print = dr["Province"].ToString();
                    }
                }
            }


            /*String textToDraw = "Adavesh";
            Size sizeOfText = TextRenderer.MeasureText(textToDraw, new Font("Arial", 500f));
            Rectangle rect = new Rectangle(new Point(10, 10), sizeOfText);
            e.Graphics.FillRectangle(Brushes.DarkSlateGray, rect);*/

            //Image newImage = Image.FromFile("LOGO.png");

            Random rastgele = new Random();
            string harfler = "123456789";
            string uret="" ;
            
            for (int i = 1; i < 12; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            /*deger = uret;
            Barcode barcode = new Barcode();
            Color foreColor = Color.Black;
            Color backColor = Color.Transparent;
            Image img2 = barcode.Encode(TYPE.UPCA, uret, foreColor, backColor);

            */
            deger = uret;

            Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;


            //pictureBox1.Image = img2;

            Image img2 = brCode.Draw(deger, 30);

            var img = Resources.LOGO;


            RectangleF srcRect = new RectangleF(50.0F, 50.0F, 150.0F, 150.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;

            var pen = new Pen(Color.Gray, 3);
            var pen_med = new Pen(Color.FromArgb(107, 193, 200), 2); 

            var font1 = new Font("Righteous", 13);
            var font2 = new Font("Righteous", 16);
            var blackBrush =new SolidBrush(Color.Black);
            var blackBrush2 = new SolidBrush(Color.FromArgb(115, 60, 151));
            var blackBrush3 = new SolidBrush(Color.FromArgb(247, 148, 29));

            e.Graphics.DrawImage(img, 250, 100, 300, 100);
            
            e.Graphics.DrawLine(pen,20,200,800,200);
            e.Graphics.DrawString("Ad", font2, blackBrush, new PointF(80, 215));
            e.Graphics.DrawString("Email", font2, blackBrush, new PointF(245, 215));
            e.Graphics.DrawString("Telefon Numara", font2, blackBrush, new PointF(435, 215));
            e.Graphics.DrawString("İl", font2, blackBrush, new PointF(685, 215));
            e.Graphics.DrawLine(pen, 20, 250, 800, 250);

            e.Graphics.DrawString(username_print, font1, blackBrush, new PointF(60, 260));
            e.Graphics.DrawString(email_print, font1, blackBrush, new PointF(180, 260));
            e.Graphics.DrawString(phoneNumber_print, font1, blackBrush, new PointF(455, 260));
            e.Graphics.DrawString(province_print, font1, blackBrush, new PointF(660, 260));

            e.Graphics.DrawLine(pen, 20, 290, 800, 290);

            e.Graphics.DrawLine(pen_med, 20, 350, 800, 350);

            e.Graphics.DrawString("Konum", font2, blackBrush2, new PointF(60, 355));
            e.Graphics.DrawString("Günlük Fiyat", font2, blackBrush2, new PointF(220, 355));
            e.Graphics.DrawString("Ev Tipi", font2, blackBrush2, new PointF(475, 355));
            e.Graphics.DrawString("Puan", font2, blackBrush2, new PointF(665, 355));

            e.Graphics.DrawLine(pen_med, 20, 390, 800, 390);

            try {
                e.Graphics.DrawString(guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[8].Value.ToString(), font1, blackBrush3, new PointF(55, 400));
                e.Graphics.DrawString(guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[9].Value.ToString(), font1, blackBrush3, new PointF(260, 400));
                e.Graphics.DrawString(guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[11].Value.ToString(), font1, blackBrush3, new PointF(487, 400));
                e.Graphics.DrawString(guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[10].Value.ToString(), font1, blackBrush3, new PointF(685, 400));

            }
            catch
            {

            }
            
           
            e.Graphics.DrawLine(pen_med, 20, 432, 800, 432);



            e.Graphics.DrawImage(img2, 270, 600, 300, 130);

            e.Graphics.DrawString("Lütfen Bu Belgeyi Saklayınız.", font1, blackBrush, new PointF(300, 780));



            //emailllllllllll//e.Graphics.DrawString(guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[9].Value.ToString(), font2, blackBrush, new PointF(10, 110));


            /*for (int i=CountedNo; i < guna2DataGridView3.Rows.Count; i++) {

                var row = guna2DataGridView3.Rows[i];
                numberPage++;

                if (numberPage <= 47)
                {
                    CountedNo++;

                    if(CountedNo<=guna2DataGridView3.Rows.Count)
                    {
                        e.Graphics.DrawString(row.Cells[0].Value.ToString(), font2, blackBrush, new PointF(10, height));
                        
                        e.Graphics.DrawString(row.Cells["Puan"].Value.ToString(), font2, blackBrush, new PointF(300, height));
                        e.Graphics.DrawString(row.Cells["EvTipi"].Value.ToString(), font2, blackBrush, new PointF(500, height));

                        height += 20;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    CountedNo = 0;
                    e.HasMorePages = true;
                    return;
                }



            }
            height += 10;
            e.Graphics.DrawLine(pen, 10, height, 800, height);

            CountedNo = 0;
            numberPage = 0;
            */











        }

        private void print_button_Click(object sender, EventArgs e)
        {
          

           using (var document = new PrintPreviewDialog())
            {
                document.Document = printDocument1;
                document.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                document.ShowDialog(this);

            }

            string connection = @"Data Source=DESKTOP-RVBA1K3;Initial Catalog=OtelSEO;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                int a = Convert.ToInt32(person_combox.SelectedItem.ToString());

                DateTime ilkdeger = datetimepicker_one.Value;
                DateTime sondeger = datetimepicker_two.Value;
                System.TimeSpan zaman;
                zaman = sondeger.Subtract(ilkdeger);
                int toplamgun = Convert.ToInt32(zaman.TotalDays);
                string query = "INSERT INTO BarcodeReaderScan(Barcode, Select_HouseType, Total, Select_Location , Select_Person ,Select_DateLogin ,Select_DateExit , Username, Email, PhoneNumber, Province) SELECT  '"+deger.ToString()+"','" + guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[8].Value.ToString() + "','" + a * toplamgun * Convert.ToInt32(guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[9].Value) + "','" + guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[11].Value.ToString() + "', '" + a + "' , '" + datetimepicker_one.Value.ToString("dd'/'MM'/'yyyy") +"' , '" + datetimepicker_two.Value.ToString("dd'/'MM'/'yyyy") + "' , register_user.Username, register_user.Email,register_user.PhoneNumber,Province FROM   register_user  WHERE   register_user.Email = '"+Form1.name+"'";
                //string query =   "INSERT INTO BarcodeReaderScan(Select_DateLogin,Username) SELECT  '"+ datetimepicker_one.Value.ToString("dd'/'MM'/'yyyy") +"' , register_user.Username FROM register_user  WHERE register_user.Email = '" + Form1.name + "'";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
             
                con.Open();
                da.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Veriler Kaydedildi");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();

            }

            /*       guna2DataGridView3.Rows.Add(guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[8].Value,
                        guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[9].Value,
                        guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[10].Value,
                        guna2DataGridView1.Rows[guna2DataGridView1.CurrentRow.Index].Cells[11].Value);
            */










            //DataTable dt = new DataTable();
            //if (guna2DataGridView1.Rows.Count > 0)
            //{
            //    SaveFileDialog save = new SaveFileDialog();
            //    save.Filter = "PDF (*.pdf)|*.pdf";
            //    save.FileName = "Result";
            //    bool ErrorMessage = false;

            //    if (save.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(save.FileName))
            //        {
            //            try
            //            {
            //                File.Delete(save.FileName);
            //            }
            //            catch (Exception ex)
            //            {
            //                ErrorMessage = true;
            //                MessageBox.Show("unable to wride data in disk" + ex.Message);
            //            }
            //        }
            //        if (!ErrorMessage)
            //        {
            //            try
            //            {
            //                PdfPTable pTable = new PdfPTable(guna2DataGridView1.ColumnCount);
            //                pTable.DefaultCell.Padding = 2;
            //                pTable.WidthPercentage = 100;
            //                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //                foreach(DataGridViewColumn col in guna2DataGridView1.Columns)
            //                {
            //                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
            //                    pTable.AddCell(pCell);

            //                }

            //                foreach (DataGridViewRow viewRow in guna2DataGridView1.Rows)
            //                {
            //                    foreach (DataGridViewCell dcell in viewRow.Cells)
            //                    {
            //                        pTable.AddCell(dcell.Value.ToString());

            //                    }
            //                }

            //                using(FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
            //                {
            //                    Document document = new Document(PageSize.A4,8f,16f,16f,8f);
            //                    document.Open();
            //                    document.Add(pTable);
            //                    document.Close();
            //                    fileStream.Close();
            //                }
            //                MessageBox.Show("Data Export Sucesfuly", "info");




            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error while exporting data"+ex.Message);

            //            }

            //        }
            //    }

            //}
            //else
            //{

            //    MessageBox.Show("No record Found", "info");
            //}



        }

        private void Settings_Click_Click(object sender, EventArgs e)
        {
            Settings settings1 = new Settings();
            settings1.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

            BarcodeCam barcodeCam = new BarcodeCam();
            barcodeCam.Show();
            this.Hide();
        }

        private void barcode_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
        }
        public static string read_barcode;

        private void panel_login_Click(object sender, EventArgs e)
        {
            BarcodeRead barcodeRead = new BarcodeRead();
            barcodeRead.Show();
            this.Show();
            read_barcode = barcode_Search.Text;
        }

        private void guna2DataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView3_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
