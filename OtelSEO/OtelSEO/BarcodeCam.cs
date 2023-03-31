using AForge.Video.DirectShow;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelSEO
{
    public partial class BarcodeCam : Form
    {
        public static string BarcodeName ;


        public BarcodeCam()
        {
            InitializeComponent();

        }


        FilterInfoCollection filterInfoCollect;
        VideoCaptureDevice videoCaptureDevice;
        private void Barcode_Load(object sender, EventArgs e)
        {
            filterInfoCollect = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollect)
            {
                cboCamera.Items.Add(device.Name);
            }
            cboCamera.SelectedIndex = 0;

        }


        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate () { txtBarcode.Text = result.ToString(); }));
            }
            PictureBox.Image = bitmap;
        }


        private void BarcodeCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {            
                    videoCaptureDevice.Stop();
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollect[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BarcodeName = txtBarcode.Text;
            Home hm = new Home();
            hm.Show();
            this.Hide();

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
