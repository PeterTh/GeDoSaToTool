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
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuItemRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.dllVersionlabel = new System.Windows.Forms.Label();
            this.installLabel = new System.Windows.Forms.Label();
            this.activateButton = new System.Windows.Forms.Button();
            this.deactivateButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.globalHotkeyLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.balloonCheckBox = new System.Windows.Forms.CheckBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabelReadme = new System.Windows.Forms.LinkLabel();
            this.linkLabelVersions = new System.Windows.Forms.LinkLabel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.keybindingsButton = new System.Windows.Forms.Button();
            this.whitelistButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userWhitelistButton = new System.Windows.Forms.Button();
            this.postButton = new System.Windows.Forms.Button();
            this.altPostButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.logLinkLabel = new System.Windows.Forms.LinkLabel();
            this.screenshotsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.trayContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "GeDoSaTo minimized\r\nDouble-click to restore.";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuItemExit,
            this.trayMenuItemRestore});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(114, 48);
            // 
            // trayMenuItemExit
            // 
            this.trayMenuItemExit.Name = "trayMenuItemExit";
            this.trayMenuItemExit.Size = new System.Drawing.Size(113, 22);
            this.trayMenuItemExit.Text = "Exit";
            this.trayMenuItemExit.Click += new System.EventHandler(this.trayMenuItemExit_Click);
            // 
            // trayMenuItemRestore
            // 
            this.trayMenuItemRestore.Name = "trayMenuItemRestore";
            this.trayMenuItemRestore.Size = new System.Drawing.Size(113, 22);
            this.trayMenuItemRestore.Text = "Restore";
            this.trayMenuItemRestore.Click += new System.EventHandler(this.trayMenuItemRestore_Click);
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
            this.installLabel.Location = new System.Drawing.Point(12, 57);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(13, 13);
            this.installLabel.TabIndex = 1;
            this.installLabel.Text = "..";
            // 
            // activateButton
            // 
            this.activateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.activateButton.Location = new System.Drawing.Point(12, 249);
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
            this.deactivateButton.Location = new System.Drawing.Point(512, 249);
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
            this.reportLabel.Location = new System.Drawing.Point(12, 99);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(66, 13);
            this.reportLabel.TabIndex = 4;
            this.reportLabel.Text = "Not active";
            // 
            // globalHotkeyLabel
            // 
            this.globalHotkeyLabel.AutoSize = true;
            this.globalHotkeyLabel.Location = new System.Drawing.Point(12, 141);
            this.globalHotkeyLabel.Name = "globalHotkeyLabel";
            this.globalHotkeyLabel.Size = new System.Drawing.Size(74, 13);
            this.globalHotkeyLabel.TabIndex = 5;
            this.globalHotkeyLabel.Text = "Global Hotkey";
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Location = new System.Drawing.Point(15, 216);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(174, 17);
            this.startupCheckBox.TabIndex = 21;
            this.startupCheckBox.Text = "Start GeDoSaTo with Windows";
            this.toolTip.SetToolTip(this.startupCheckBox, "NOTE: Only works if UAC is disabled!");
            this.startupCheckBox.UseVisualStyleBackColor = true;
            this.startupCheckBox.CheckedChanged += new System.EventHandler(this.startupCheckBox_CheckedChanged);
            // 
            // balloonCheckBox
            // 
            this.balloonCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.balloonCheckBox.AutoSize = true;
            this.balloonCheckBox.Location = new System.Drawing.Point(15, 185);
            this.balloonCheckBox.Name = "balloonCheckBox";
            this.balloonCheckBox.Size = new System.Drawing.Size(162, 17);
            this.balloonCheckBox.TabIndex = 27;
            this.balloonCheckBox.Text = "Hide balloon when minimized";
            this.toolTip.SetToolTip(this.balloonCheckBox, "NOTE: Only works if UAC is disabled!");
            this.balloonCheckBox.UseVisualStyleBackColor = true;
            this.balloonCheckBox.CheckedChanged += new System.EventHandler(this.balloonCheckBox_CheckedChanged);
            // 
            // linkLabel
            // 
            this.linkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel.Location = new System.Drawing.Point(225, 272);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(213, 13);
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
            this.linkLabelReadme.Location = new System.Drawing.Point(156, 247);
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
            this.linkLabelVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelVersions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelVersions.Location = new System.Drawing.Point(390, 247);
            this.linkLabelVersions.Name = "linkLabelVersions";
            this.linkLabelVersions.Size = new System.Drawing.Size(116, 20);
            this.linkLabelVersions.TabIndex = 10;
            this.linkLabelVersions.TabStop = true;
            this.linkLabelVersions.Text = "Version History";
            this.linkLabelVersions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelVersions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVersions_LinkClicked);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.Location = new System.Drawing.Point(213, 180);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(123, 26);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.Text = "Edit Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // keybindingsButton
            // 
            this.keybindingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.keybindingsButton.Location = new System.Drawing.Point(213, 211);
            this.keybindingsButton.Name = "keybindingsButton";
            this.keybindingsButton.Size = new System.Drawing.Size(123, 26);
            this.keybindingsButton.TabIndex = 12;
            this.keybindingsButton.Text = "Edit Keybindings";
            this.keybindingsButton.UseVisualStyleBackColor = true;
            this.keybindingsButton.Click += new System.EventHandler(this.keybindingsButton_Click);
            // 
            // whitelistButton
            // 
            this.whitelistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.whitelistButton.Location = new System.Drawing.Point(6, 17);
            this.whitelistButton.Name = "whitelistButton";
            this.whitelistButton.Size = new System.Drawing.Size(74, 22);
            this.whitelistButton.TabIndex = 13;
            this.whitelistButton.Text = "Whitelist";
            this.whitelistButton.UseVisualStyleBackColor = true;
            this.whitelistButton.Click += new System.EventHandler(this.whitelistButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.whitelistButton);
            this.groupBox1.Controls.Add(this.userWhitelistButton);
            this.groupBox1.Location = new System.Drawing.Point(458, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 46);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Whitelisting";
            // 
            // userWhitelistButton
            // 
            this.userWhitelistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userWhitelistButton.Location = new System.Drawing.Point(86, 17);
            this.userWhitelistButton.Name = "userWhitelistButton";
            this.userWhitelistButton.Size = new System.Drawing.Size(85, 22);
            this.userWhitelistButton.TabIndex = 25;
            this.userWhitelistButton.Text = "User Whitelist";
            this.userWhitelistButton.UseVisualStyleBackColor = true;
            this.userWhitelistButton.Click += new System.EventHandler(this.userWhitelistButton_Click);
            // 
            // postButton
            // 
            this.postButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.postButton.Location = new System.Drawing.Point(360, 180);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(123, 26);
            this.postButton.TabIndex = 19;
            this.postButton.Text = "Edit Postprocessing";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // altPostButton
            // 
            this.altPostButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.altPostButton.Location = new System.Drawing.Point(360, 211);
            this.altPostButton.Name = "altPostButton";
            this.altPostButton.Size = new System.Drawing.Size(123, 26);
            this.altPostButton.TabIndex = 20;
            this.altPostButton.Text = "Edit Alt. Postproc.";
            this.altPostButton.UseVisualStyleBackColor = true;
            this.altPostButton.Click += new System.EventHandler(this.altPostButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Location = new System.Drawing.Point(512, 72);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 34);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // logLinkLabel
            // 
            this.logLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logLinkLabel.AutoSize = true;
            this.logLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.logLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.logLinkLabel.Location = new System.Drawing.Point(507, 184);
            this.logLinkLabel.Name = "logLinkLabel";
            this.logLinkLabel.Size = new System.Drawing.Size(110, 18);
            this.logLinkLabel.TabIndex = 26;
            this.logLinkLabel.TabStop = true;
            this.logLinkLabel.Text = "Show Log Files";
            this.logLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logLinkLabel_LinkClicked);
            // 
            // screenshotsLinkLabel
            // 
            this.screenshotsLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenshotsLinkLabel.AutoSize = true;
            this.screenshotsLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenshotsLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.screenshotsLinkLabel.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.screenshotsLinkLabel.Location = new System.Drawing.Point(507, 215);
            this.screenshotsLinkLabel.Name = "screenshotsLinkLabel";
            this.screenshotsLinkLabel.Size = new System.Drawing.Size(134, 18);
            this.screenshotsLinkLabel.TabIndex = 26;
            this.screenshotsLinkLabel.TabStop = true;
            this.screenshotsLinkLabel.Text = "Show Screenshots";
            this.screenshotsLinkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.screenshotsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.screenshotsLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 295);
            this.Controls.Add(this.balloonCheckBox);
            this.Controls.Add(this.screenshotsLinkLabel);
            this.Controls.Add(this.logLinkLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.startupCheckBox);
            this.Controls.Add(this.altPostButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.groupBox1);
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
            this.Text = "GeDoSaToTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.trayContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.LinkLabel linkLabelReadme;
        private System.Windows.Forms.LinkLabel linkLabelVersions;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button keybindingsButton;
        private System.Windows.Forms.Button whitelistButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.Button altPostButton;
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button userWhitelistButton;
        private System.Windows.Forms.LinkLabel logLinkLabel;
        private System.Windows.Forms.LinkLabel screenshotsLinkLabel;
        private System.Windows.Forms.CheckBox balloonCheckBox;
        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemRestore;
    }
}

