using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace zora
{
    public partial class InfoWindow : UserControl
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void InfoWindow_Load(object sender, EventArgs e)
        {
            Label1.Font = new Font("Roboto", 26, FontStyle.Regular);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/jebbidan?sub_confirmation=1");
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://jebbidanyt.000webhostapp.com/");
        }
    }
}
