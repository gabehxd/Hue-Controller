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
            this.IPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isLightOn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.AlertType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EffectTypes = new System.Windows.Forms.ComboBox();
            this.SendCommand = new System.Windows.Forms.Button();
            this.lightFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(433, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ulitiesToolStripMenuItem
            // 
            this.ulitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bridgeFinderToolStripMenuItem,
            this.lightFinderToolStripMenuItem});
            this.ulitiesToolStripMenuItem.Name = "ulitiesToolStripMenuItem";
            this.ulitiesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ulitiesToolStripMenuItem.Text = "Utilities";
            // 
            // bridgeFinderToolStripMenuItem
            // 
            this.bridgeFinderToolStripMenuItem.Name = "bridgeFinderToolStripMenuItem";
            this.bridgeFinderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bridgeFinderToolStripMenuItem.Text = "Bridge Finder";
            this.bridgeFinderToolStripMenuItem.Click += new System.EventHandler(this.BridgeFinderToolStripMenuItem_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(150, 88);
            this.IPBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(132, 22);
            this.IPBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bridge IP";
            // 
            // isLightOn
            // 
            this.isLightOn.AutoSize = true;
            this.isLightOn.Checked = true;
            this.isLightOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isLightOn.Location = new System.Drawing.Point(192, 221);
            this.isLightOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isLightOn.Name = "isLightOn";
            this.isLightOn.Size = new System.Drawing.Size(49, 21);
            this.isLightOn.TabIndex = 4;
            this.isLightOn.Text = "On";
            this.isLightOn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bridge Key";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(150, 175);
            this.KeyBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.PasswordChar = '*';
            this.KeyBox.Size = new System.Drawing.Size(132, 22);
            this.KeyBox.TabIndex = 5;
            // 
            // AlertType
            // 
            this.AlertType.FormattingEnabled = true;
            this.AlertType.Location = new System.Drawing.Point(136, 307);
            this.AlertType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlertType.Name = "AlertType";
            this.AlertType.Size = new System.Drawing.Size(160, 24);
            this.AlertType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alert Type";
            // 
            // ColorBtn
            // 
            this.ColorBtn.Location = new System.Drawing.Point(166, 444);
            this.ColorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(100, 28);
            this.ColorBtn.TabIndex = 13;
            this.ColorBtn.Text = "Select Color";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 355);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Effect Type";
            // 
            // EffectTypes
            // 
            this.EffectTypes.FormattingEnabled = true;
            this.EffectTypes.Location = new System.Drawing.Point(136, 396);
            this.EffectTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EffectTypes.Name = "EffectTypes";
            this.EffectTypes.Size = new System.Drawing.Size(160, 24);
            this.EffectTypes.TabIndex = 14;
            this.EffectTypes.SelectedIndexChanged += new System.EventHandler(this.EffectTypes_SelectedIndexChanged);
            // 
            // SendCommand
            // 
            this.SendCommand.Location = new System.Drawing.Point(166, 496);
            this.SendCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.Size = new System.Drawing.Size(100, 28);
            this.SendCommand.TabIndex = 16;
            this.SendCommand.Text = "Send Command";
            this.SendCommand.UseVisualStyleBackColor = true;
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // lightFinderToolStripMenuItem
            // 
            this.lightFinderToolStripMenuItem.Name = "lightFinderToolStripMenuItem";
            this.lightFinderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lightFinderToolStripMenuItem.Text = "Light Finder";
            this.lightFinderToolStripMenuItem.Click += new System.EventHandler(this.LightFinderToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 570);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EffectTypes);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox EffectTypes;
        private System.Windows.Forms.Button SendCommand;
        private System.Windows.Forms.ToolStripMenuItem lightFinderToolStripMenuItem;
        public System.Windows.Forms.TextBox IPBox;
        public System.Windows.Forms.TextBox KeyBox;
    }
}

