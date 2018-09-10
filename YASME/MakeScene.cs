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

        public MakeScene(RSDKv5.GameConfig.SceneInfo info, string dpath, string[] ctl, string ct)
        {
            dp = dpath.Replace("\\", "/");
            InitializeComponent();
            name.Text = info.Name;
            path.Text = info.Zone;
            sceneID.Text = info.SceneID;

            //int i = 0;
            modeFilters.SetItemChecked(0, (info.ModeFilter & 0b0001) != 0);
            modeFilters.SetItemChecked(1, (info.ModeFilter & 0b0010) != 0);
            modeFilters.SetItemChecked(2, (info.ModeFilter & 0b0100) != 0);

            foreach (string x in ctl)
            {
                catBox.Items.Add(x);
            }
            catBox.SelectedItem = ct;
            /*foreach (string x in modeFilters.Items)
            {
                Console.WriteLine(x);
            }*/
        }

        private void refreshPath(object sender, EventArgs e)
        {
            fullPath.Text = "Full Path: Data/Stages/" + path.Text + "/Scene" + sceneID.Text + ".bin";
            string snf = dp + "/Stages/" + path.Text + "/Scene" + sceneID.Text + ".bin";
            Console.WriteLine(snf);
            if (File.Exists(snf))
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
            sceneInfo = new RSDKv5.GameConfig.SceneInfo
            {
                Name = name.Text,
                Zone = path.Text,
                SceneID = sceneID.Text
            };
            sceneInfo.ModeFilter |= (byte)((modeFilters.GetItemChecked(0) ? 1 : 0) << 0);
            sceneInfo.ModeFilter |= (byte)((modeFilters.GetItemChecked(1) ? 1 : 0) << 1);
            sceneInfo.ModeFilter |= (byte)((modeFilters.GetItemChecked(2) ? 1 : 0) << 2);
            cat = catBox.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}