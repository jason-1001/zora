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
using System.Net;
using System.Net.Sockets;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace zora
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoWindow1.Hide();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            resultText.Text = GetLocalIPAddress();
            string strHostName = System.Net.Dns.GetHostName(); ;
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            Console.WriteLine(addr[addr.Length - 1].ToString());
            if (addr[0].AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
            {
                resultIPv6.Text = (addr[0].ToString()); 
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            AdvancedPage advancedPage = new AdvancedPage();
            advancedPage.ShowDialog();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            resultIPv6.Text = "";
            resultText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoWindow1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infoWindow1.Hide();
        }
    }
}
