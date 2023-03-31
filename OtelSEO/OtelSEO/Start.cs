using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelSEO
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            start_bar.Value = 0;
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void start_bar_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start_bar.Value += 1;
            start_bar.Text = start_bar.Value.ToString();
            if (start_bar.Value == 100)
            {

                StartPass start_pass = new StartPass();
                start_pass.Show();
                this.Hide();

                timer1.Enabled = false;
            }
        }
    }
}
