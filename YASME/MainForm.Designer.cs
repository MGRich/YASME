namespace Test
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gameName = new System.Windows.Forms.TextBox();
            this.gameSubname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.gamecTab = new System.Windows.Forms.TabPage();
            this.stageCategories = new System.Windows.Forms.TreeView();
            this.wavBox = new System.Windows.Forms.GroupBox();
            this.wcatAdd = new System.Windows.Forms.TextBox();
            this.awCategory = new System.Windows.Forms.Button();
            this.addWAV = new System.Windows.Forms.Button();
            this.wavTree = new System.Windows.Forms.TreeView();
            this.gcpBox = new System.Windows.Forms.GroupBox();
            this.sceneBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.scatAdd = new System.Windows.Forms.TextBox();
            this.scab = new System.Windows.Forms.TabPage();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.gamecTab.SuspendLayout();
            this.wavBox.SuspendLayout();
            this.sceneBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.Location = new System.Drawing.Point(8, 32);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(294, 20);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "Sonic Mania";
            this.gameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameSubname
            // 
            this.gameSubname.Location = new System.Drawing.Point(8, 71);
            this.gameSubname.Name = "gameSubname";
            this.gameSubname.Size = new System.Drawing.Size(294, 20);
            this.gameSubname.TabIndex = 2;
            this.gameSubname.Text = "By the Mania for the Mania.";
            this.gameSubname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gameSubname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Game Subname";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gameSubname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Names";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.gamecTab);
            this.tabs.Controls.Add(this.scab);
            this.tabs.Location = new System.Drawing.Point(0, 27);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1032, 599);
            this.tabs.TabIndex = 10;
            // 
            // gamecTab
            // 
            this.gamecTab.Controls.Add(this.stageCategories);
            this.gamecTab.Controls.Add(this.wavBox);
            this.gamecTab.Controls.Add(this.gcpBox);
            this.gamecTab.Controls.Add(this.groupBox1);
            this.gamecTab.Controls.Add(this.sceneBox);
            this.gamecTab.Location = new System.Drawing.Point(4, 22);
            this.gamecTab.Name = "gamecTab";
            this.gamecTab.Padding = new System.Windows.Forms.Padding(3);
            this.gamecTab.Size = new System.Drawing.Size(1024, 573);
            this.gamecTab.TabIndex = 0;
            this.gamecTab.Text = "GameConfig";
            this.gamecTab.UseVisualStyleBackColor = true;
            // 
            // stageCategories
            // 
            this.stageCategories.Location = new System.Drawing.Point(167, 134);
            this.stageCategories.Name = "stageCategories";
            this.stageCategories.Size = new System.Drawing.Size(141, 346);
            this.stageCategories.TabIndex = 10;
            // 
            // wavBox
            // 
            this.wavBox.Controls.Add(this.wcatAdd);
            this.wavBox.Controls.Add(this.awCategory);
            this.wavBox.Controls.Add(this.addWAV);
            this.wavBox.Controls.Add(this.wavTree);
            this.wavBox.Location = new System.Drawing.Point(8, 115);
            this.wavBox.Name = "wavBox";
            this.wavBox.Size = new System.Drawing.Size(149, 455);
            this.wavBox.TabIndex = 0;
            this.wavBox.TabStop = false;
            this.wavBox.Text = "Global WAVs";
            // 
            // wcatAdd
            // 
            this.wcatAdd.Location = new System.Drawing.Point(4, 371);
            this.wcatAdd.Name = "wcatAdd";
            this.wcatAdd.Size = new System.Drawing.Size(139, 20);
            this.wcatAdd.TabIndex = 3;
            this.wcatAdd.Text = "[category name]";
            this.wcatAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wavEnter);
            // 
            // awCategory
            // 
            this.awCategory.Location = new System.Drawing.Point(4, 397);
            this.awCategory.Name = "awCategory";
            this.awCategory.Size = new System.Drawing.Size(141, 23);
            this.awCategory.TabIndex = 2;
            this.awCategory.Text = "Add WAV Category";
            this.awCategory.UseVisualStyleBackColor = true;
            this.awCategory.Click += new System.EventHandler(this.aCat);
            // 
            // addWAV
            // 
            this.addWAV.Location = new System.Drawing.Point(4, 426);
            this.addWAV.Name = "addWAV";
            this.addWAV.Size = new System.Drawing.Size(141, 23);
            this.addWAV.TabIndex = 0;
            this.addWAV.Text = "Import WAV";
            this.addWAV.UseVisualStyleBackColor = true;
            this.addWAV.Click += new System.EventHandler(this.impWav);
            // 
            // wavTree
            // 
            this.wavTree.Location = new System.Drawing.Point(4, 19);
            this.wavTree.Name = "wavTree";
            this.wavTree.Size = new System.Drawing.Size(141, 346);
            this.wavTree.TabIndex = 11;
            // 
            // gcpBox
            // 
            this.gcpBox.Location = new System.Drawing.Point(320, 9);
            this.gcpBox.Name = "gcpBox";
            this.gcpBox.Size = new System.Drawing.Size(692, 558);
            this.gcpBox.TabIndex = 6;
            this.gcpBox.TabStop = false;
            this.gcpBox.Text = "Palette/Other";
            // 
            // sceneBox
            // 
            this.sceneBox.Controls.Add(this.button2);
            this.sceneBox.Controls.Add(this.button1);
            this.sceneBox.Controls.Add(this.scatAdd);
            this.sceneBox.Location = new System.Drawing.Point(163, 115);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.Size = new System.Drawing.Size(149, 455);
            this.sceneBox.TabIndex = 12;
            this.sceneBox.TabStop = false;
            this.sceneBox.Text = "Scenes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Import Scene";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.impScn);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Scene Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.aCat);
            // 
            // scatAdd
            // 
            this.scatAdd.Location = new System.Drawing.Point(4, 371);
            this.scatAdd.Name = "scatAdd";
            this.scatAdd.Size = new System.Drawing.Size(139, 20);
            this.scatAdd.TabIndex = 4;
            this.scatAdd.Text = "[category name]";
            // 
            // scab
            // 
            this.scab.Location = new System.Drawing.Point(4, 22);
            this.scab.Name = "scab";
            this.scab.Padding = new System.Windows.Forms.Padding(3);
            this.scab.Size = new System.Drawing.Size(1024, 573);
            this.scab.TabIndex = 1;
            this.scab.Text = "More soon..";
            this.scab.UseVisualStyleBackColor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openWithToolStripMenuItem,
            this.saveMenu,
            this.saveAsMenue});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openWithToolStripMenuItem.Text = "Open with..";
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(135, 22);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.save);
            // 
            // saveAsMenue
            // 
            this.saveAsMenue.Name = "saveAsMenue";
            this.saveAsMenue.Size = new System.Drawing.Size(135, 22);
            this.saveAsMenue.Text = "Save to..";
            this.saveAsMenue.Click += new System.EventHandler(this.saveAs);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 624);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1030, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.statusLabel.LinkColor = System.Drawing.Color.Black;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1030, 646);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Yet Another Sonic Mania Editor";
            this.Shown += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.gamecTab.ResumeLayout(false);
            this.wavBox.ResumeLayout(false);
            this.wavBox.PerformLayout();
            this.sceneBox.ResumeLayout(false);
            this.sceneBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gameName;
        private System.Windows.Forms.TextBox gameSubname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage gamecTab;
        private System.Windows.Forms.TabPage scab;
        private System.Windows.Forms.TreeView wavTree;
        private System.Windows.Forms.TreeView stageCategories;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gcpBox;
        private System.Windows.Forms.GroupBox wavBox;
        private System.Windows.Forms.Button addWAV;
        private System.Windows.Forms.Button awCategory;
        private System.Windows.Forms.TextBox wcatAdd;
        private System.Windows.Forms.GroupBox sceneBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox scatAdd;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

