using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelSEO
{
    public partial class Cable : Form
    {
        public Cable()
        {
            InitializeComponent();
        }

        private void Cable_Load(object sender, EventArgs e)
        {

        }
        bool src_takildi = false;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x219)
            {
                DriveInfo[] suruculer = DriveInfo.GetDrives();

                foreach (DriveInfo surucu in suruculer)
                {
                    System.Threading.Thread.Sleep(200);
                    if (surucu.IsReady)
                    {
                        if (surucu.VolumeLabel != "OS" && src_takildi == false)
                        {
                           
                            src_takildi = true;

                            DialogResult result = MessageBox.Show("Usb Algılandı", "Confirmation", MessageBoxButtons.YesNoCancel);
                            if (result == DialogResult.Yes)
                            {
                         
                                Start st = new Start();
                                st.Show();
                                this.Hide();
                            }
                            else if (result == DialogResult.No)
                            {
                                this.Close();
                            }

                            timer1.Enabled = true;
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }



    }
}
