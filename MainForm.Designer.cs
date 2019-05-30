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
            this.BrightnessBar = new System.Windows.Forms.TrackBar();
            this.isLightOn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BrightnessDisplay = new System.Windows.Forms.Label();
            this.AlertType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EffectTypes = new System.Windows.Forms.ComboBox();
            this.SendCommand = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ulitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ulitiesToolStripMenuItem
            // 
            this.ulitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bridgeFinderToolStripMenuItem});
            this.ulitiesToolStripMenuItem.Name = "ulitiesToolStripMenuItem";
            this.ulitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ulitiesToolStripMenuItem.Text = "Utilities";
            // 
            // bridgeFinderToolStripMenuItem
            // 
            this.bridgeFinderToolStripMenuItem.Name = "bridgeFinderToolStripMenuItem";
            this.bridgeFinderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bridgeFinderToolStripMenuItem.Text = "Bridge Finder";
            this.bridgeFinderToolStripMenuItem.Click += new System.EventHandler(this.BridgeFinderToolStripMenuItem_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(130, 68);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bridge IP";
            // 
            // BrightnessBar
            // 
            this.BrightnessBar.Location = new System.Drawing.Point(74, 227);
            this.BrightnessBar.Maximum = 255;
            this.BrightnessBar.Minimum = 1;
            this.BrightnessBar.Name = "BrightnessBar";
            this.BrightnessBar.Size = new System.Drawing.Size(212, 45);
            this.BrightnessBar.TabIndex = 3;
            this.BrightnessBar.Value = 255;
            this.BrightnessBar.Scroll += new System.EventHandler(this.BrightnessBar_Scroll);
            // 
            // isLightOn
            // 
            this.isLightOn.AutoSize = true;
            this.isLightOn.Checked = true;
            this.isLightOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isLightOn.Location = new System.Drawing.Point(160, 174);
            this.isLightOn.Name = "isLightOn";
            this.isLightOn.Size = new System.Drawing.Size(40, 17);
            this.isLightOn.TabIndex = 4;
            this.isLightOn.Text = "On";
            this.isLightOn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bridge Key";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(130, 133);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.PasswordChar = '*';
            this.KeyBox.Size = new System.Drawing.Size(100, 20);
            this.KeyBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "255";
            // 
            // BrightnessDisplay
            // 
            this.BrightnessDisplay.AutoSize = true;
            this.BrightnessDisplay.Location = new System.Drawing.Point(168, 273);
            this.BrightnessDisplay.Name = "BrightnessDisplay";
            this.BrightnessDisplay.Size = new System.Drawing.Size(25, 13);
            this.BrightnessDisplay.TabIndex = 10;
            this.BrightnessDisplay.Text = "255";
            // 
            // AlertType
            // 
            this.AlertType.FormattingEnabled = true;
            this.AlertType.Location = new System.Drawing.Point(120, 333);
            this.AlertType.Name = "AlertType";
            this.AlertType.Size = new System.Drawing.Size(121, 21);
            this.AlertType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alert Type";
            // 
            // ColorBtn
            // 
            this.ColorBtn.Location = new System.Drawing.Point(143, 456);
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
            this.label7.Location = new System.Drawing.Point(149, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Effect Type";
            // 
            // EffectTypes
            // 
            this.EffectTypes.FormattingEnabled = true;
            this.EffectTypes.Location = new System.Drawing.Point(120, 404);
            this.EffectTypes.Name = "EffectTypes";
            this.EffectTypes.Size = new System.Drawing.Size(121, 21);
            this.EffectTypes.TabIndex = 14;
            this.EffectTypes.SelectedIndexChanged += new System.EventHandler(this.EffectTypes_SelectedIndexChanged);
            // 
            // SendCommand
            // 
            this.SendCommand.Location = new System.Drawing.Point(143, 497);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.Size = new System.Drawing.Size(75, 23);
            this.SendCommand.TabIndex = 16;
            this.SendCommand.Text = "Send Command";
            this.SendCommand.UseVisualStyleBackColor = true;
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 553);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EffectTypes);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AlertType);
            this.Controls.Add(this.BrightnessDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.isLightOn);
            this.Controls.Add(this.BrightnessBar);
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
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ulitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bridgeFinderToolStripMenuItem;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar BrightnessBar;
        private System.Windows.Forms.CheckBox isLightOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BrightnessDisplay;
        private System.Windows.Forms.ComboBox AlertType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EffectTypes;
        private System.Windows.Forms.Button SendCommand;
    }
}

