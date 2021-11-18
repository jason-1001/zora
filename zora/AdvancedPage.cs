using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Windows.Forms;

namespace zora
{
    public partial class AdvancedPage : MaterialForm
    {
        public AdvancedPage()
        {
            InitializeComponent();
            MaterialSkinManager msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        
        }

        private void AdvancedPage_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "ipconfig";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/all";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Text = test.StandardOutput.ReadToEnd();
        }
    }
}
