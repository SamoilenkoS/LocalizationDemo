
namespace LocalizationDemo
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.radioButtonChoise3 = new System.Windows.Forms.RadioButton();
            this.radioButtonChoise2 = new System.Windows.Forms.RadioButton();
            this.radioButtonChoise1 = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButtonR1 = new System.Windows.Forms.RadioButton();
            this.radioButtonR2 = new System.Windows.Forms.RadioButton();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxSet2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxSet1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSomeInfo = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxSet2.SuspendLayout();
            this.groupBoxSet1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.languageMenuItem,
            this.editMenuItem,
            this.exitMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(558, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem,
            this.closeMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openMenuItem.Text = "Open";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveMenuItem.Text = "Save";
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeMenuItem.Text = "Close";
            // 
            // languageMenuItem
            // 
            this.languageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishMenuItem,
            this.russianMenuItem});
            this.languageMenuItem.Name = "languageMenuItem";
            this.languageMenuItem.Size = new System.Drawing.Size(88, 24);
            this.languageMenuItem.Text = "Language";
            // 
            // englishMenuItem
            // 
            this.englishMenuItem.Checked = true;
            this.englishMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishMenuItem.Name = "englishMenuItem";
            this.englishMenuItem.Size = new System.Drawing.Size(224, 26);
            this.englishMenuItem.Text = "English";
            this.englishMenuItem.Click += new System.EventHandler(this.englishMenuItem_Click);
            // 
            // russianMenuItem
            // 
            this.russianMenuItem.Name = "russianMenuItem";
            this.russianMenuItem.Size = new System.Drawing.Size(224, 26);
            this.russianMenuItem.Text = "Русский";
            this.russianMenuItem.Click += new System.EventHandler(this.russianMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editMenuItem.Text = "Edit";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitMenuItem.Text = "Exit";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(20, 206);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 104);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(158, 206);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(137, 104);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radioButtonChoise3);
            this.groupBoxOptions.Controls.Add(this.radioButtonChoise2);
            this.groupBoxOptions.Controls.Add(this.radioButtonChoise1);
            this.groupBoxOptions.Controls.Add(this.checkBox3);
            this.groupBoxOptions.Controls.Add(this.checkBox2);
            this.groupBoxOptions.Controls.Add(this.checkBox1);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 31);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(297, 125);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // radioButtonChoise3
            // 
            this.radioButtonChoise3.AutoSize = true;
            this.radioButtonChoise3.Location = new System.Drawing.Point(146, 84);
            this.radioButtonChoise3.Name = "radioButtonChoise3";
            this.radioButtonChoise3.Size = new System.Drawing.Size(84, 21);
            this.radioButtonChoise3.TabIndex = 5;
            this.radioButtonChoise3.TabStop = true;
            this.radioButtonChoise3.Text = "Choise 3";
            this.radioButtonChoise3.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoise2
            // 
            this.radioButtonChoise2.AutoSize = true;
            this.radioButtonChoise2.Location = new System.Drawing.Point(146, 56);
            this.radioButtonChoise2.Name = "radioButtonChoise2";
            this.radioButtonChoise2.Size = new System.Drawing.Size(84, 21);
            this.radioButtonChoise2.TabIndex = 4;
            this.radioButtonChoise2.TabStop = true;
            this.radioButtonChoise2.Text = "Choise 2";
            this.radioButtonChoise2.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoise1
            // 
            this.radioButtonChoise1.AutoSize = true;
            this.radioButtonChoise1.Location = new System.Drawing.Point(146, 28);
            this.radioButtonChoise1.Name = "radioButtonChoise1";
            this.radioButtonChoise1.Size = new System.Drawing.Size(84, 21);
            this.radioButtonChoise1.TabIndex = 3;
            this.radioButtonChoise1.TabStop = true;
            this.radioButtonChoise1.Text = "Choise 1";
            this.radioButtonChoise1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 84);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(85, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Option C";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Option B";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Option A";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButtonR1
            // 
            this.radioButtonR1.AutoSize = true;
            this.radioButtonR1.Location = new System.Drawing.Point(16, 28);
            this.radioButtonR1.Name = "radioButtonR1";
            this.radioButtonR1.Size = new System.Drawing.Size(51, 21);
            this.radioButtonR1.TabIndex = 4;
            this.radioButtonR1.TabStop = true;
            this.radioButtonR1.Text = "R 1";
            this.radioButtonR1.UseVisualStyleBackColor = true;
            // 
            // radioButtonR2
            // 
            this.radioButtonR2.AutoSize = true;
            this.radioButtonR2.Location = new System.Drawing.Point(16, 55);
            this.radioButtonR2.Name = "radioButtonR2";
            this.radioButtonR2.Size = new System.Drawing.Size(51, 21);
            this.radioButtonR2.TabIndex = 5;
            this.radioButtonR2.TabStop = true;
            this.radioButtonR2.Text = "R 2";
            this.radioButtonR2.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.groupBoxSet2);
            this.groupBoxDetails.Controls.Add(this.groupBoxSet1);
            this.groupBoxDetails.Location = new System.Drawing.Point(315, 36);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(238, 298);
            this.groupBoxDetails.TabIndex = 6;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // groupBoxSet2
            // 
            this.groupBoxSet2.Controls.Add(this.listBox1);
            this.groupBoxSet2.Location = new System.Drawing.Point(7, 136);
            this.groupBoxSet2.Name = "groupBoxSet2";
            this.groupBoxSet2.Size = new System.Drawing.Size(225, 156);
            this.groupBoxSet2.TabIndex = 1;
            this.groupBoxSet2.TabStop = false;
            this.groupBoxSet2.Text = "Set 2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.listBox1.Location = new System.Drawing.Point(7, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 116);
            this.listBox1.TabIndex = 0;
            // 
            // groupBoxSet1
            // 
            this.groupBoxSet1.Controls.Add(this.label2);
            this.groupBoxSet1.Controls.Add(this.radioButtonR1);
            this.groupBoxSet1.Controls.Add(this.radioButtonR2);
            this.groupBoxSet1.Location = new System.Drawing.Point(7, 24);
            this.groupBoxSet1.Name = "groupBoxSet1";
            this.groupBoxSet1.Size = new System.Drawing.Size(225, 105);
            this.groupBoxSet1.TabIndex = 0;
            this.groupBoxSet1.TabStop = false;
            this.groupBoxSet1.Text = "Set 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Another info";
            // 
            // labelSomeInfo
            // 
            this.labelSomeInfo.AutoSize = true;
            this.labelSomeInfo.Location = new System.Drawing.Point(9, 172);
            this.labelSomeInfo.Name = "labelSomeInfo";
            this.labelSomeInfo.Size = new System.Drawing.Size(71, 17);
            this.labelSomeInfo.TabIndex = 7;
            this.labelSomeInfo.Text = "Some info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 341);
            this.Controls.Add(this.labelSomeInfo);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localization demo";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxSet2.ResumeLayout(false);
            this.groupBoxSet1.ResumeLayout(false);
            this.groupBoxSet1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioButtonChoise3;
        private System.Windows.Forms.RadioButton radioButtonChoise2;
        private System.Windows.Forms.RadioButton radioButtonChoise1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButtonR1;
        private System.Windows.Forms.RadioButton radioButtonR2;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.GroupBox groupBoxSet2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSomeInfo;
        private System.Windows.Forms.ToolStripMenuItem englishMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianMenuItem;
    }
}

