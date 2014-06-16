using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.IO;

namespace GeDoSaToTool
{
    public partial class TextForm : Form
    {
        TextStyle linkStyle = new TextStyle(Brushes.Blue, null, FontStyle.Underline);
        TextStyle boldStyle = new TextStyle(null, null, FontStyle.Bold);
        TextStyle italicStyle = new TextStyle(null, null, FontStyle.Italic);
        TextStyle keywordStyle = new TextStyle(Brushes.DarkRed, null, FontStyle.Bold);
        TextStyle fadedStyle = new TextStyle(SystemBrushes.ControlLight, null, FontStyle.Bold);
        TextStyle commentStyle = new TextStyle(Brushes.DarkOliveGreen, null, FontStyle.Italic);
        TextStyle commentHeaderStyle = new TextStyle(Brushes.DarkOliveGreen, null, FontStyle.Italic | FontStyle.Bold);
        AutocompleteMenu popupMenu;
        string fileName, keywordRegex = "BASE_KWD";

        List<string> keywords = new List<string>();
        bool editable;

        private void LoadFile(string fn)
        {
            fileName = fn;
            Text = "GeDoSaTo Text " + (editable ? "Editor" : "Viewer") + " - " + fileName;
            fastColoredTextBox.Text = System.IO.File.ReadAllText(fileName);
            buttonSave.Enabled = false;
        }

        public TextForm(string fn, bool editable, List<string> kws = null)
        {
            InitializeComponent();
            this.editable = editable;

            // generate KW regex
            if (kws != null) keywords = kws;
            keywords.Sort((x, y) => y.Length.CompareTo(x.Length)); // tricky - syntax highlighting via regexp will chose first!
            foreach (var s in keywords) keywordRegex += "|" + s;

            // load file
            profileComboBox.Items.Add(fn);
            profileComboBox.SelectedIndex = 0; // this also loads the file

            if (!editable)
            {
                fastColoredTextBox.ReadOnly = true;
                buttonSave.Visible = false;
            }
            else
            {
                // generate profile list if ini file
                if (Path.GetExtension(fn) == ".ini")
                {
                    string justfn = Path.GetFileName(fn);
                    string dir = Path.GetDirectoryName(fn);
                    foreach (var d in Directory.EnumerateDirectories(dir))
                    {
                        var profilefn = Path.Combine(d, justfn);
                        if (File.Exists(profilefn))
                        {
                            profileComboBox.Items.Add(profilefn);
                        }
                    }
                    profileComboBox.Visible = true;
                    profileLabel.Visible = true;
                }

                // create autocompletion menu
                popupMenu = new FastColoredTextBoxNS.AutocompleteMenu(fastColoredTextBox);
                popupMenu.MinFragmentLength = 2;
                popupMenu.Items.SetAutocompleteItems(keywords);
                popupMenu.Items.MaximumSize = new System.Drawing.Size(200, 300);
                popupMenu.Items.Width = 200;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                if (buttonSave.Enabled) buttonSave_Click(this, null);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void fastColoredTextBox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            buttonSave.Enabled = true;

            e.ChangedRange.ClearStyle(commentHeaderStyle);
            e.ChangedRange.SetStyle(commentHeaderStyle, @"#{40,}[^\n]*\n[^\n]*#.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(commentHeaderStyle, @"^## \w[^\n]*", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(commentStyle);
            e.ChangedRange.SetStyle(commentStyle, @"#.*$", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(linkStyle);
            e.ChangedRange.SetStyle(linkStyle, @"\w+@\w+\.\w+");
            e.ChangedRange.SetStyle(linkStyle, @"http:[^\s]*");

            e.ChangedRange.ClearStyle(boldStyle);
            e.ChangedRange.SetStyle(boldStyle, @"\*([^\n]+\n*){1,3}\*", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(boldStyle, @"^[^\n]+\n*(?=^={5,}\s*$)", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(fadedStyle);
            e.ChangedRange.SetStyle(fadedStyle, @"^={5,}\s*$", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(italicStyle);
            e.ChangedRange.SetStyle(italicStyle, @"^.*:\s*$\n*(?=-|1\))", RegexOptions.Multiline);

            e.ChangedRange.ClearStyle(keywordStyle);
            e.ChangedRange.SetStyle(keywordStyle, keywordRegex);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, fastColoredTextBox.Text);
            buttonSave.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFile(profileComboBox.Text);
        }
    }
}