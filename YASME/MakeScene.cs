using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Test
{
    public partial class MakeScene : Form
    {
        private string dp = null;

        public MakeScene()
        {
            InitializeComponent();
            refreshPath(this, new EventArgs());
        }

        public MakeScene(RSDKv5.GameConfig.SceneInfo scn, string dpath)
        {
            dp = dpath.Replace("\\", "/");
            InitializeComponent();
            name.Text = scn.Name;
            path.Text = scn.Zone;
            sceneID.Text = scn.SceneID;

            //int i = 0;
            modeFilters.SetItemChecked(0, (scn.ModeFilter & 0b0001) != 0);
            modeFilters.SetItemChecked(1, (scn.ModeFilter & 0b0010) != 0);
            modeFilters.SetItemChecked(2, (scn.ModeFilter & 0b0100) != 0);
            /*foreach (string x in modeFilters.Items)
            {
                Console.WriteLine(x);
            }*/
        }

        private void refreshPath(object sender, EventArgs e)
        {
            fullPath.Text = "Full Path: Data/Scenes/" + path.Text + "/Scene" + sceneID.Text + ".bin";
            Console.WriteLine(dp + "/Scenes/" + path.Text + "/Scene" + sceneID.Text + ".bin");
            if (File.Exists(dp + "/Scenes/" + path.Text + "/Scene" + sceneID.Text + ".bin"))
            {
                fullPath.ForeColor = Color.Black;
            }
            else
            {
                fullPath.ForeColor = Color.Red;
            }
        }

        private void pCheck(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            Regex rg = new Regex(@"([A - z\/])");
            if (rg.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void save(object sender, EventArgs e)
        {
            sceneInfo.Name = name.Text;
            sceneInfo.Zone = path.Text;
            sceneInfo.SceneID = sceneID.Text;

            sceneInfo.ModeFilter |= (byte)((modeFilters.GetItemChecked(0) ? 1 : 0) << 0);
            sceneInfo.ModeFilter |= (byte)((modeFilters.GetItemChecked(1) ? 1 : 0) << 1);
            sceneInfo.ModeFilter |= (byte)((modeFilters.GetItemChecked(2) ? 1 : 0) << 2);
        }
    }
}