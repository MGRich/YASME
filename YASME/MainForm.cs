using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using Cyotek.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Test
{
    public partial class MainForm : Form
    {
        public RSDKv5.GameConfig gc;

        private string gcf;

        private string data;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = textBox2.Text;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //open
        {
            bool nw = false;
            if (sender is MainForm)
            {
                nw = true;
            }
            CommonOpenFileDialog dlg = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };
            dlg.Title = "Sonic Mania Data Folder";
            bool fl = true;
            while (fl)
            {
                if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    data = dlg.FileName;
                    Console.WriteLine(data);
                    //load GC
                    try
                    {
                        gc = new RSDKv5.GameConfig(data + "\\Game\\GameConfig.bin");
                        gcf = data + "\\Game\\GameConfig.bin";
                        openGC(gc);
                        status.Text = "Loaded GameConfig.";
                        fl = false;
                    }
                    catch
                    {
                        MessageBox.Show("Please select a valid Sonic Mania Data folder.", "Invalid Selection");
                    }
                }
                else
                {
                    if (!nw)
                    {
                        fl = false;
                    }
                }
            }
        }

        //private Color[][][] clrp = new Color[8][][];
        //private Color[][] clrs = new Color[8][];
        private Color[][] clrs = new Color[8][];

        private Dictionary<string, int> cat = new Dictionary<string, int> { };
        private Dictionary<string, RSDKv5.GameConfig.SceneInfo> scn = new Dictionary<string, RSDKv5.GameConfig.SceneInfo> { };
        private Dictionary<string, RSDKv5.GameConfig.Category> cts = new Dictionary<string, RSDKv5.GameConfig.Category> { };
        private Dictionary<RSDKv5.GameConfig.SceneInfo, RSDKv5.GameConfig.Category> stn = new Dictionary<RSDKv5.GameConfig.SceneInfo, RSDKv5.GameConfig.Category>();

        private int lys = 0;

        private List<bool> cks = new List<bool>();
        private int lar = 0;

        private void openGC(RSDKv5.GameConfig gc)
        {
            gameName.Text = gc.GameName;
            gameSubname.Text = gc.GameSubname;
            //Console.WriteLine(gc.GameSubname);

            //WAVS

            string[][] wvs = new string[gc.WAVs.Count][];
            int i = -1;
            foreach (RSDKv5.WAVConfiguration x in gc.WAVs)
            {
                i++;
                //Console.WriteLine(x.Name);
                string[] nm = x.Name.Split('/');
                wvs[i] = nm;
            }
            i = 0;
            int e = 0;
            string[] wvl = formNode(wvs, wavTree);

            //TreeNode wvst;

            //CATEGORIES

            i = 0;
            e = 0;
            //TreeNode ctst;
            cts = new Dictionary<string, RSDKv5.GameConfig.Category>();
            scn = new Dictionary<string, RSDKv5.GameConfig.SceneInfo>();
            stn = new Dictionary<RSDKv5.GameConfig.SceneInfo, RSDKv5.GameConfig.Category>();
            cat = new Dictionary<string, int>();

            foreach (RSDKv5.GameConfig.Category x in gc.Categories)
            {
                foreach (RSDKv5.GameConfig.SceneInfo y in x.Scenes)
                {
                    e++;
                }
            }
            //string[] snl = new string[e];
            string[][] ctsl = new string[e][];
            List<string> kndc = new List<string>();
            i = -1;
            foreach (RSDKv5.GameConfig.Category x in gc.Categories)
            {
                cts.Add(x.Name, x);
                Console.WriteLine(x.Name);
                bool z = false;
                foreach (RSDKv5.GameConfig.SceneInfo y in x.Scenes)
                {
                    stn.Add(y, x);
                    i++;
                    //string[] csa = { x.Name, y.Name};
                    //Console.WriteLine(y.Zone + " " + y.Name);
                    string yna = y.Name;
                    if (x.Name.Substring(x.Name.Length - 4) == "Mode")
                    {
                        //string yna = y.Name;
                        string zna = y.Zone;
                        if (yna.Contains(" "))
                        {
                            yna = yna.Substring(yna.Length - 1);
                        }
                        if (Regex.Match(zna, @"\d{1}$").Success)
                        {
                            //yna = zna.Substring(zna.Length - 1);
                            zna = zna.Substring(0, zna.Length - 1);
                        }
                        if (x.Name == "Encore Mode")
                        {
                            zna = zna + "+";
                        }
                        if (zna == "ERZ")
                        {
                            yna = "";
                        }
                        yna = zna + " " + yna;
                        //Console.WriteLine(yna);
                        //scn.Add(yna, y);
                    }
                    Console.WriteLine(yna.Contains("+"));
                    if (x.Name == "Special Stage")
                    {
                        if (yna.Contains("+"))
                        {
                            z = true;
                        }
                        yna = "SS " + yna.Substring(yna.Length - 1);
                        if (z)
                        {
                            yna = yna.Insert(2, "+");
                        }
                    }
                    if (x.Name == "Blue Spheres")
                    {
                        if (yna.Contains("Blue Spheres"))
                        {
                            yna = yna.Substring(yna.Length - 1);
                        }
                    }
                    string[] csa = { x.Name, yna };
                    ctsl[i] = csa;
                    Console.WriteLine(yna);
                    scn.Add(yna, y);
                }
                /*Console.WriteLine(x.Name);
                string[] car = { x.Name, x.Scenes };
                wvs[i] = nm;*/
            }
            i = 0;
            e = 0;
            formNode(ctsl, stageCategories);
            makePalette(formPalette(gc.Palettes), lar, gcpBox);
            /*foreach (string x in wvl)
            {
                //string nm = x.Name;
                wavSelect.Items.Add(x);
            }*/
        }

        private Color[][] formPalette(RSDKv5.Palette[] palettes)
        {
            Color[] clrp = new Color[256];
            lys = 0;
            cks = new List<bool>();
            int i = 0;
            int e = 0;
            int u = 0;
            //int q = 0;
            foreach (RSDKv5.Palette x in palettes)
            {
                //Console.WriteLine(x.Colors[0].Length + "______________________________________________________________________________________________");
                foreach (RSDKv5.PaletteColor[] y in x.Colors)
                {
                    //Console.WriteLine(y.Length + "______________________________________________________________________________________________");
                    Console.WriteLine(y);
                    if (y == null)
                    {
                        for (int d = 0; d < 16; d++)
                        {
                            if (i == 256)
                            {
                                break;
                            }
                            clrp[i] = Color.Black;
                            Console.WriteLine(i + " i");
                            i++;
                        }
                        cks.Add(false);
                        //if (i == 256)
                        //{
                        //    break;
                        //}
                    }
                    else
                    {
                        int t = 0;
                        foreach (RSDKv5.PaletteColor z in y)
                        {
                            Console.WriteLine(z.R + " R");
                            Console.WriteLine(z.B + " B");
                            Console.WriteLine(z.G + " G");
                            Console.WriteLine(i + " i");
                            //Console.WriteLine(q + " q");
                            clrp[i] = Color.FromArgb(255, z.R, z.G, z.B);
                            if (clrp[i] == Color.Empty)
                            {
                                Console.WriteLine(Color.FromArgb(255, z.R, z.G, z.B) + " " + z.R + z.B + z.G);
                            }
                            t++;
                            Console.WriteLine(t + "- - - -  -- - - -  - - --- - - - - -");
                            i++;
                        }
                        cks.Add(true);
                        t = 0;
                    }
                    //i = 0;
                    Console.WriteLine(e);
                    e++;
                    if (e == 16)
                    {
                        break;
                    }
                    //if (i == 256)
                    //{
                    //    break;
                    //}
                    //break;
                }
                clrs[u] = clrp;
                clrp = new Color[256];
                e = 0;
                lys++;
                u++;
            }
            Console.WriteLine(clrs[0] == clrs[1]);
            i = 0;
            foreach (Color[] x in clrs)
            {
                //Console.WriteLine(x.Distinct().Count());
                if (x.Distinct().Count() == 1)
                {
                    Color[] y = Enumerable.Repeat(Color.Black, 256).ToArray();
                    clrs[i] = y;
                    foreach (Color z in y)
                    {
                        cks.Add(false);
                    }
                }
                i++;
            }
            /*int[] h = new int[1];
            for (int w = 0; w < 2; w++)
            {
                Console.WriteLine(h[i]);
            }*/
            return clrs;
        }

        /*private void parsePalette(Color[][] pal, RSDKv5.Palette[] palette)
        {
            for (int i = 0; i < lys; i++)
            {
                int e = 0;
                int u = 0;
                Color[] pll = pal[i];
                foreach (RSDKv5.PaletteColor[] y in palette[i].Colors)
                {
                    RSDKv5.PaletteColor[] a = null;
                    if (cks[u] && y == null)
                    {
                        a = Enumerable.Repeat(new RSDKv5.PaletteColor(), 16).ToArray();
                    }
                    //else if (!cks[u] && y != null)
                    //{
                    //    a = y;
                    //}
                    if (a == null)
                    {
                        e += 16;
                        continue;
                    }
                    foreach (RSDKv5.PaletteColor z in a)
                    {
                        if (a != null)
                        {
                            z.R = pll[e].R;
                            z.G = pll[e].G;
                            z.B = pll[e].B;
                        }
                        e++;
                    }
                    palette[i].Colors[u] = a;
                    u++;
                }
            }
        }*/

        private List<PictureBox> dpl = new List<PictureBox>();
        private Dictionary<PictureBox, int> dpd = new Dictionary<PictureBox, int>();

        //private List<CheckBox> chl = new List<CheckBox>();
        private Dictionary<CheckBox, int> chr = new Dictionary<CheckBox, int>();

        private void makePalette(Color[][] pal, int lyr, Control parent)
        {
            Console.WriteLine(lyr + "--------------------------------");
            Color[] colors = pal[lyr];
            //const int pic_width = 30;
            //const int pic_height = 30;
            //const int spacing = 3;
            const int x = 8;
            const int y = 21;
            //Control parent = gcpBox;
            EventHandler event_handler = palletePick;
            int row_y = y;
            int column_x = x;
            int e = 0;
            int[] posy = new int[16];
            int posx = 0;
            if (dpl.Count == 0)
            {
                //int dv = 16;
                for (int i = 0; i < 16; i++)
                {
                    for (int u = 0; u < 16; u++)
                    {
                        PictureBox pc = new PictureBox
                        {
                            Size = new Size(30, 30),
                            Location = new Point(column_x, row_y),
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        column_x = column_x + 33;
                        dpl.Add(pc);
                        dpd.Add(pc, e);
                        Console.WriteLine(u + " " + column_x + " " + row_y);
                        //int dv = 16;
                        e++;
                    }
                    posy[i] = row_y;
                    row_y = row_y + 33;
                    posx = column_x;
                    column_x = x;
                }
                for (int i = 0; i < 16; i++)
                {
                    CheckBox ck = new CheckBox
                    {
                        Location = new Point(posx + 13, posy[i] + 3),
                        Parent = parent,
                        Checked = cks[i],
                        Size = new Size(20, 20)
                    };
                    //Console.WriteLine();
                    ck.Click += disableColumn;
                    chr.Add(ck, i);
                    //chl.Add(ck);
                }
                int btnx = posx + 33;
                int btny = posy[14];
                e = 1;
                for (int i = 14; i < 16; i++)
                {
                    btny = posy[i];
                    for (int u = 0; u < 4; u++)
                    {
                        Button btn = new Button
                        {
                            Location = new Point(btnx, btny),
                            Size = new Size(25, 25),
                            Text = e.ToString(),
                            Parent = parent
                        };
                        btn.Click += changeLayer;
                        btnx = btnx + 28;
                        e++;
                    }
                    btnx = posx + 33;
                }
                Console.WriteLine("new dpl end");
            }
            int q = 0;
            foreach (CheckBox check in chr.Keys.ToArray())
            {
                check.Checked = false;
            }
            foreach (PictureBox pic in dpl)
            {
                pic.Parent = parent;
                int r = dpd[pic] + 256 * lyr;
                r = r / 16;
                pic.BackColor = colors[q];
                if (cks[r])
                {
                    pic.Click += event_handler;
                    chr.Keys.ToArray()[r - 256 * lyr].Checked = true;
                }
                else
                {
                    pic.BackColor = Color.Empty;
                }
                //r = (int)r;
                Console.WriteLine(r + " " + dpd[pic] + " " + (lyr + 1));
                q++;
            }
        }

        public void changeLayer(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int i = int.Parse(btn.Text);
            lar = i - 1;
            makePalette(formPalette(gc.Palettes), lar, btn.Parent);
        }

        public void palletePick(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            ColorPickerDialog colorPicker = new ColorPickerDialog
            {
                Color = pic.BackColor,
                ShowAlphaChannel = false
            };
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                int clr = dpd[pic];
                clrs[lar][clr] = colorPicker.Color;
                Console.WriteLine(clrs[lar][clr]);
                pic.BackColor = colorPicker.Color;
                //parsePalette(clrs, gc.Palettes);
            }
        }

        public string[] formNode(string[][] lst, TreeView view)
        {
            List<string> knds = new List<string>();
            Dictionary<string, int> nds = new Dictionary<string, int> { };
            int e = 0;
            int i = 0;
            foreach (string[] x in lst)
            {
                Console.WriteLine(i);

                if (!knds.Contains(x[0]))
                {
                    view.Nodes.Add(x[0]);
                    nds.Add(x[0], e);
                    knds.Add(x[0]);
                    e++;
                }

                Console.WriteLine(nds[x[0]]);
                Console.WriteLine(x[1]);
                view.Nodes[nds[x[0]]].Nodes.Add(x[1]);
                i++;
            }
            return knds.ToArray();
        }

        public void disableColumn(object sender, EventArgs e)
        {
            CheckBox ck = sender as CheckBox;
            int num = chr[ck] * 16;
            List<PictureBox> lst = new List<PictureBox>();
            for (int i = 0; i < dpl.Count; i++)
            {
                if (i >= num && i <= num + 15)
                {
                    lst.Add(dpl[i]);
                }
            }
            //List<PictureBox> lst = dpl.GetRange(num, num + 16);
            foreach (PictureBox x in lst)
            {
                if (ck.Checked)
                {
                    x.Click += palletePick;
                    int clr = dpd[x];
                    x.BackColor = clrs[lar][clr];
                }
                else
                {
                    x.Click -= palletePick;
                    x.BackColor = Color.Empty;
                }
            }
        }

        private void nodeSelect(object sender, EventArgs e)
        {
            TreeView tr = sender as TreeView;
            TreeNode tn = tr.SelectedNode;
            string nm = tn.Name;
            string[] scl = scn.Keys.ToArray();
            string[] ctl = cts.Keys.ToArray();
            RSDKv5.GameConfig.Category ct = null;
            if (ctl.Contains(nm))
            {
                ct = cts[nm];
            }
            else if (scl.Contains(nm))
            {
                RSDKv5.GameConfig.SceneInfo sn = scn[nm];
                ct = stn[sn];
            }
        }

        private void save(object sender, EventArgs e) //savenorm
        {
            gc.GameName = gameName.Text;
            gc.GameSubname = gameSubname.Text;
            gc.Write(gcf, false);
            status.Text = "Saved GameConfig.";
        }

        private void saveAs(object sender, EventArgs e) //saveas
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                gc.GameName = gameName.Text;
                gc.GameSubname = gameSubname.Text;
                string pth = dlg.SelectedPath + "\\GameConfig.bin";
                gc.Write(pth, false);
                status.Text = "Saved GameConfig to " + pth + ".";
            }
        }

        private TreeNode adn = null;

        private void awCat(object sender, EventArgs e)
        {
            if (wcatAdd.Text == "[added!]" || wcatAdd.Text == "[category name]")
            {
                return;
            }
            if (!Directory.Exists(data + "\\SoundFX\\" + wcatAdd.Text))
            {
                Directory.CreateDirectory(data + "\\SoundFX\\" + wcatAdd.Text);
                string h = wcatAdd.Text;
                adn = wavTree.Nodes.Add(h);
            }
            impWav(sender, e);
            //wcatAdd.Text = "[added!]";
        }

        private void impWav(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string cat = null;
            bool cta = false;
            TreeNode node = wavTree.SelectedNode;
            if (btn.Text == "Add WAV Category")
            {
                cat = wcatAdd.Text;
                node = adn;
                cta = true;
            }
            else
            {
                if (wavTree.SelectedNode == null)
                {
                    return;
                }
                //try
                //{
                node = wavTree.SelectedNode;
                bool h = true;
                while (h)
                {
                    if (node.Parent == null)
                    {
                        h = false;
                        cat = node.Text;
                    }
                    else
                    {
                        node = node.Parent;
                    }
                }
                //}
                //catch { }
            }
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "WAV Files|*.wav"
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Console.WriteLine(data + "\\SoundFX\\" + cat + "\\" + dlg.FileName);
                string fln = Path.GetFileName(dlg.FileName);
                File.Copy(dlg.FileName, data + "\\SoundFX\\" + cat + "\\" + fln, true);
                node.Nodes.Add(fln);
                /*if (nds == null)
                {
                    MessageBox.Show(cat);
                }*/
                //nds.Nodes.Add(dlg.FileName);
            }
            else
            {
                if (cta)
                {
                    wavTree.Nodes.Remove(adn);
                }
            }
        }

        private void wavEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button btn = new Button
                {
                    Text = "Add WAV Category" //enough to trick it
                };
                awCat(btn, e);
            }
        }
    }
}