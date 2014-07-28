namespace GeDoSaToTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.dllVersionlabel = new System.Windows.Forms.Label();
            this.installLabel = new System.Windows.Forms.Label();
            this.activateButton = new System.Windows.Forms.Button();
            this.deactivateButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.globalHotkeyLabel = new System.Windows.Forms.Label();
            this.whitelistRadioButton = new System.Windows.Forms.RadioButton();
            this.blacklistRadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabelReadme = new System.Windows.Forms.LinkLabel();
            this.linkLabelVersions = new System.Windows.Forms.LinkLabel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.keybindingsButton = new System.Windows.Forms.Button();
            this.blacklistButton = new System.Windows.Forms.Button();
            this.whitelistButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.postButton = new System.Windows.Forms.Button();
            this.altPostButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "GeDoSaTo minimized\r\nDouble-click to restore.";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // dllVersionlabel
            // 
            this.dllVersionlabel.AutoSize = true;
            this.dllVersionlabel.Location = new System.Drawing.Point(12, 15);
            this.dllVersionlabel.Name = "dllVersionlabel";
            this.dllVersionlabel.Size = new System.Drawing.Size(74, 13);
            this.dllVersionlabel.TabIndex = 0;
            this.dllVersionlabel.Text = "GeDoSaTo.dll";
            // 
            // installLabel
            // 
            this.installLabel.AutoSize = true;
            this.installLabel.Location = new System.Drawing.Point(12, 60);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(13, 13);
            this.installLabel.TabIndex = 1;
            this.installLabel.Text = "..";
            // 
            // activateButton
            // 
            this.activateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.activateButton.Location = new System.Drawing.Point(12, 283);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(123, 34);
            this.activateButton.TabIndex = 2;
            this.activateButton.Text = "Activate";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // deactivateButton
            // 
            this.deactivateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deactivateButton.Enabled = false;
            this.deactivateButton.Location = new System.Drawing.Point(512, 283);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(123, 34);
            this.deactivateButton.TabIndex = 3;
            this.deactivateButton.Text = "Deactivate";
            this.deactivateButton.UseVisualStyleBackColor = true;
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(12, 105);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(66, 13);
            this.reportLabel.TabIndex = 4;
            this.reportLabel.Text = "Not active";
            // 
            // globalHotkeyLabel
            // 
            this.globalHotkeyLabel.AutoSize = true;
            this.globalHotkeyLabel.Location = new System.Drawing.Point(12, 150);
            this.globalHotkeyLabel.Name = "globalHotkeyLabel";
            this.globalHotkeyLabel.Size = new System.Drawing.Size(74, 13);
            this.globalHotkeyLabel.TabIndex = 5;
            this.globalHotkeyLabel.Text = "Global Hotkey";
            // 
            // whitelistRadioButton
            // 
            this.whitelistRadioButton.AutoSize = true;
            this.whitelistRadioButton.Checked = true;
            this.whitelistRadioButton.Location = new System.Drawing.Point(15, 19);
            this.whitelistRadioButton.Name = "whitelistRadioButton";
            this.whitelistRadioButton.Size = new System.Drawing.Size(87, 17);
            this.whitelistRadioButton.TabIndex = 6;
            this.whitelistRadioButton.TabStop = true;
            this.whitelistRadioButton.Text = "Use Whitelist";
            this.toolTip.SetToolTip(this.whitelistRadioButton, resources.GetString("whitelistRadioButton.ToolTip"));
            this.whitelistRadioButton.UseVisualStyleBackColor = true;
            this.whitelistRadioButton.CheckedChanged += new System.EventHandler(this.whitelistRadioButton_CheckedChanged);
            // 
            // blacklistRadioButton
            // 
            this.blacklistRadioButton.AutoSize = true;
            this.blacklistRadioButton.Location = new System.Drawing.Point(15, 42);
            this.blacklistRadioButton.Name = "blacklistRadioButton";
            this.blacklistRadioButton.Size = new System.Drawing.Size(86, 17);
            this.blacklistRadioButton.TabIndex = 7;
            this.blacklistRadioButton.Text = "Use Blacklist";
            this.toolTip.SetToolTip(this.blacklistRadioButton, resources.GetString("blacklistRadioButton.ToolTip"));
            this.blacklistRadioButton.UseVisualStyleBackColor = true;
            this.blacklistRadioButton.CheckedChanged += new System.EventHandler(this.blacklistRadioButton_CheckedChanged);
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Location = new System.Drawing.Point(254, 190);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(174, 17);
            this.startupCheckBox.TabIndex = 21;
            this.startupCheckBox.Text = "Start GeDoSaTo with Windows";
            this.toolTip.SetToolTip(this.startupCheckBox, "NOTE: Only works if UAC is disabled!");
            this.startupCheckBox.UseVisualStyleBackColor = true;
            this.startupCheckBox.CheckedChanged += new System.EventHandler(this.startupCheckBox_CheckedChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel.Location = new System.Drawing.Point(233, 306);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(181, 12);
            this.linkLabel.TabIndex = 8;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Donate to support GeDoSaTo development";
            this.linkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelReadme
            // 
            this.linkLabelReadme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelReadme.AutoSize = true;
            this.linkLabelReadme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelReadme.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelReadme.Location = new System.Drawing.Point(170, 283);
            this.linkLabelReadme.Name = "linkLabelReadme";
            this.linkLabelReadme.Size = new System.Drawing.Size(228, 20);
            this.linkLabelReadme.TabIndex = 9;
            this.linkLabelReadme.TabStop = true;
            this.linkLabelReadme.Text = "Problems? Read the README";
            this.linkLabelReadme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelReadme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReadme_LinkClicked);
            // 
            // linkLabelVersions
            // 
            this.linkLabelVersions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelVersions.AutoSize = true;
            this.linkLabelVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelVersions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelVersions.Location = new System.Drawing.Point(402, 287);
            this.linkLabelVersions.Name = "linkLabelVersions";
            this.linkLabelVersions.Size = new System.Drawing.Size(69, 12);
            this.linkLabelVersions.TabIndex = 10;
            this.linkLabelVersions.TabStop = true;
            this.linkLabelVersions.Text = "Version History";
            this.linkLabelVersions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelVersions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVersions_LinkClicked);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.Location = new System.Drawing.Point(254, 213);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(123, 22);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.Text = "Edit Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // keybindingsButton
            // 
            this.keybindingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.keybindingsButton.Location = new System.Drawing.Point(254, 241);
            this.keybindingsButton.Name = "keybindingsButton";
            this.keybindingsButton.Size = new System.Drawing.Size(123, 22);
            this.keybindingsButton.TabIndex = 12;
            this.keybindingsButton.Text = "Edit Keybindings";
            this.keybindingsButton.UseVisualStyleBackColor = true;
            this.keybindingsButton.Click += new System.EventHandler(this.keybindingsButton_Click);
            // 
            // blacklistButton
            // 
            this.blacklistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.blacklistButton.Location = new System.Drawing.Point(512, 241);
            this.blacklistButton.Name = "blacklistButton";
            this.blacklistButton.Size = new System.Drawing.Size(123, 22);
            this.blacklistButton.TabIndex = 14;
            this.blacklistButton.Text = "Edit Blacklist";
            this.blacklistButton.UseVisualStyleBackColor = true;
            this.blacklistButton.Click += new System.EventHandler(this.blacklistButton_Click);
            // 
            // whitelistButton
            // 
            this.whitelistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.whitelistButton.Location = new System.Drawing.Point(512, 213);
            this.whitelistButton.Name = "whitelistButton";
            this.whitelistButton.Size = new System.Drawing.Size(123, 22);
            this.whitelistButton.TabIndex = 13;
            this.whitelistButton.Text = "Edit Whitelist";
            this.whitelistButton.UseVisualStyleBackColor = true;
            this.whitelistButton.Click += new System.EventHandler(this.whitelistButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.whitelistRadioButton);
            this.groupBox1.Controls.Add(this.blacklistRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 69);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Whitelisting Options";
            // 
            // postButton
            // 
            this.postButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.postButton.Location = new System.Drawing.Point(383, 213);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(123, 22);
            this.postButton.TabIndex = 19;
            this.postButton.Text = "Edit Postprocessing";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // altPostButton
            // 
            this.altPostButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.altPostButton.Location = new System.Drawing.Point(383, 241);
            this.altPostButton.Name = "altPostButton";
            this.altPostButton.Size = new System.Drawing.Size(123, 22);
            this.altPostButton.TabIndex = 20;
            this.altPostButton.Text = "Edit Alt. Postproc.";
            this.altPostButton.UseVisualStyleBackColor = true;
            this.altPostButton.Click += new System.EventHandler(this.altPostButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 329);
            this.Controls.Add(this.startupCheckBox);
            this.Controls.Add(this.altPostButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.blacklistButton);
            this.Controls.Add(this.whitelistButton);
            this.Controls.Add(this.keybindingsButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.linkLabelVersions);
            this.Controls.Add(this.linkLabelReadme);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.globalHotkeyLabel);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.deactivateButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.installLabel);
            this.Controls.Add(this.dllVersionlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "GeDoSaTo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label dllVersionlabel;
        private System.Windows.Forms.Label installLabel;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Button deactivateButton;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Label globalHotkeyLabel;
        private System.Windows.Forms.RadioButton whitelistRadioButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton blacklistRadioButton;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.LinkLabel linkLabelReadme;
        private System.Windows.Forms.LinkLabel linkLabelVersions;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button keybindingsButton;
        private System.Windows.Forms.Button blacklistButton;
        private System.Windows.Forms.Button whitelistButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button altPostButton;
        private System.Windows.Forms.CheckBox startupCheckBox;
    }
}

