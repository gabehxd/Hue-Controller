namespace Hue_Controller
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ulitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bridgeFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isLightOn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.AlertType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EffectType = new System.Windows.Forms.ComboBox();
            this.SendCommand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Selected = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ulitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(325, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ulitiesToolStripMenuItem
            // 
            this.ulitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bridgeFinderToolStripMenuItem,
            this.lightFinderToolStripMenuItem});
            this.ulitiesToolStripMenuItem.Name = "ulitiesToolStripMenuItem";
            this.ulitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ulitiesToolStripMenuItem.Text = "Utilities";
            // 
            // bridgeFinderToolStripMenuItem
            // 
            this.bridgeFinderToolStripMenuItem.Name = "bridgeFinderToolStripMenuItem";
            this.bridgeFinderToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.bridgeFinderToolStripMenuItem.Text = "Bridge Finder";
            this.bridgeFinderToolStripMenuItem.Click += new System.EventHandler(this.BridgeFinderToolStripMenuItem_Click);
            // 
            // lightFinderToolStripMenuItem
            // 
            this.lightFinderToolStripMenuItem.Name = "lightFinderToolStripMenuItem";
            this.lightFinderToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.lightFinderToolStripMenuItem.Text = "Light Finder";
            this.lightFinderToolStripMenuItem.Click += new System.EventHandler(this.LightFinderToolStripMenuItem_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(102, 70);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(121, 20);
            this.IPBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bridge IP";
            // 
            // isLightOn
            // 
            this.isLightOn.AutoSize = true;
            this.isLightOn.Checked = true;
            this.isLightOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isLightOn.Location = new System.Drawing.Point(144, 240);
            this.isLightOn.Name = "isLightOn";
            this.isLightOn.Size = new System.Drawing.Size(40, 17);
            this.isLightOn.TabIndex = 4;
            this.isLightOn.Text = "On";
            this.isLightOn.UseVisualStyleBackColor = true;
            this.isLightOn.CheckedChanged += new System.EventHandler(this.IsLightOn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bridge Key";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(89, 141);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.PasswordChar = '*';
            this.KeyBox.Size = new System.Drawing.Size(147, 20);
            this.KeyBox.TabIndex = 5;
            // 
            // AlertType
            // 
            this.AlertType.FormattingEnabled = true;
            this.AlertType.Location = new System.Drawing.Point(102, 308);
            this.AlertType.Name = "AlertType";
            this.AlertType.Size = new System.Drawing.Size(121, 21);
            this.AlertType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alert Type";
            // 
            // ColorBtn
            // 
            this.ColorBtn.Location = new System.Drawing.Point(124, 420);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(75, 23);
            this.ColorBtn.TabIndex = 13;
            this.ColorBtn.Text = "Select Color";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Effect Type";
            // 
            // EffectType
            // 
            this.EffectType.FormattingEnabled = true;
            this.EffectType.Location = new System.Drawing.Point(102, 380);
            this.EffectType.Name = "EffectType";
            this.EffectType.Size = new System.Drawing.Size(121, 21);
            this.EffectType.TabIndex = 14;
            this.EffectType.SelectedIndexChanged += new System.EventHandler(this.EffectTypes_SelectedIndexChanged);
            // 
            // SendCommand
            // 
            this.SendCommand.Location = new System.Drawing.Point(124, 462);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.Size = new System.Drawing.Size(75, 23);
            this.SendCommand.TabIndex = 16;
            this.SendCommand.Text = "Send Command";
            this.SendCommand.UseVisualStyleBackColor = true;
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Lights to (not) control (optional)";
            // 
            // Selected
            // 
            this.Selected.Location = new System.Drawing.Point(89, 205);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(147, 20);
            this.Selected.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Selected);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EffectType);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AlertType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.isLightOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hue Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ulitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bridgeFinderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isLightOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AlertType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EffectType;
        private System.Windows.Forms.Button SendCommand;
        private System.Windows.Forms.ToolStripMenuItem lightFinderToolStripMenuItem;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Selected;
    }
}

