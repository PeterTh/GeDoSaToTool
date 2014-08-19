namespace GeDoSaToTool
{
    partial class NewProfileForm
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTop = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(266, 117);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(185, 117);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(12, 26);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(209, 13);
            this.labelTop.TabIndex = 2;
            this.labelTop.Text = "Create a new profile for (executable name):";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(15, 51);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(326, 20);
            this.textBoxFN.TabIndex = 3;
            this.textBoxFN.TextChanged += new System.EventHandler(this.textBoxFN_TextChanged);
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(12, 84);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(16, 13);
            this.labelFolder.TabIndex = 4;
            this.labelFolder.Text = "...";
            // 
            // NewProfileForm
            // 
            this.AcceptButton = this.buttonCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(353, 152);
            this.ControlBox = false;
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.textBoxFN);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProfileForm";
            this.Text = "New Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Label labelFolder;
    }
}