using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeDoSaToTool
{
    public partial class NewProfileForm : Form
    {
        string baseFn, createdFn = "";

        public NewProfileForm(string baseFn)
        {
            this.baseFn = baseFn;
            InitializeComponent();
        }

        public string Prompt()
        {
            ShowDialog();
            return createdFn;
        }

        private void textBoxFN_TextChanged(object sender, EventArgs e)
        {
            string curCreatedFN = "config\\" + textBoxFN.Text + "\\" + Path.GetFileName(baseFn);
            var isValid = !string.IsNullOrEmpty(curCreatedFN)
                        && textBoxFN.Text.IndexOfAny(Path.GetInvalidFileNameChars()) < 0
                        && Path.GetFileName(curCreatedFN).IndexOfAny(Path.GetInvalidFileNameChars()) < 0
                        && curCreatedFN.IndexOfAny(Path.GetInvalidPathChars()) < 0
                        && !File.Exists(curCreatedFN);
            if (!isValid)
            {
                labelFolder.Text = "Invalid or existing path.";
                createdFn = "";
                buttonCreate.Enabled = false;
                return;
            }
            createdFn = curCreatedFN;
            buttonCreate.Enabled = true;
            labelFolder.Text = "Will create file: " + createdFn;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            createdFn = "";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
