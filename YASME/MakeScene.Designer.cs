namespace Test
{
    partial class MakeScene
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sceneID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullPath = new System.Windows.Forms.TextBox();
            this.modeFilters = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(16, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 20);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scene Path (from Data/Scenes)";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(16, 71);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(100, 20);
            this.path.TabIndex = 3;
            this.path.TextChanged += new System.EventHandler(this.refreshPath);
            this.path.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Scene ID (ex. \'1K\')";
            // 
            // sceneID
            // 
            this.sceneID.Location = new System.Drawing.Point(16, 112);
            this.sceneID.Name = "sceneID";
            this.sceneID.Size = new System.Drawing.Size(100, 20);
            this.sceneID.TabIndex = 5;
            this.sceneID.TextChanged += new System.EventHandler(this.refreshPath);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modeFilters);
            this.groupBox1.Location = new System.Drawing.Point(193, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode Filters";
            // 
            // fullPath
            // 
            this.fullPath.BackColor = System.Drawing.SystemColors.Window;
            this.fullPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullPath.Cursor = System.Windows.Forms.Cursors.Default;
            this.fullPath.Location = new System.Drawing.Point(16, 142);
            this.fullPath.Name = "fullPath";
            this.fullPath.ReadOnly = true;
            this.fullPath.Size = new System.Drawing.Size(276, 13);
            this.fullPath.TabIndex = 7;
            this.fullPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modeFilters
            // 
            this.modeFilters.BackColor = System.Drawing.SystemColors.Window;
            this.modeFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modeFilters.FormattingEnabled = true;
            this.modeFilters.Items.AddRange(new object[] {
            "Common",
            "Mania Mode",
            "Encore Mode"});
            this.modeFilters.Location = new System.Drawing.Point(7, 17);
            this.modeFilters.Name = "modeFilters";
            this.modeFilters.Size = new System.Drawing.Size(86, 45);
            this.modeFilters.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MakeScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(305, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fullPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sceneID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MakeScene";
            this.ShowIcon = false;
            this.Text = "Scene Editing";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sceneID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fullPath;
        private System.Windows.Forms.CheckedListBox modeFilters;
        private System.Windows.Forms.Button button1;
        private RSDKv5.GameConfig.SceneInfo sceneInfo = new RSDKv5.GameConfig.SceneInfo();
    }
}