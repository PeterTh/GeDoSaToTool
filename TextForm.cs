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
        TextStyle defineStyle = new TextStyle(Brushes.DarkBlue, null, FontStyle.Regular);
        TextStyle keywordStyle = new TextStyle(Brushes.DarkRed, null, FontStyle.Bold);
        TextStyle fadedStyle = new TextStyle(SystemBrushes.ControlLight, null, FontStyle.Bold);
        TextStyle commentStyle = new TextStyle(Brushes.DarkOliveGreen, null, FontStyle.Italic);
        TextStyle commentHeaderStyle = new TextStyle(Brushes.DarkOliveGreen, null, FontStyle.Italic | FontStyle.Bold);

        AutocompleteMenu popupMenu;
        string fileName = "", startFn, keywordRegex = "BASE_KWD";

        List<string> keywords = new List<string>();
        bool isEditable, isShader, isList;

        private void LoadFile(string fn)
        {
            if (fn == fileName) return;
            if (!String.IsNullOrEmpty(fileName) && buttonSave.Enabled)
            {
                var res = MessageBox.Show("Do you want to save your changes to " + fileName + "?", "Query", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                {
                    profileComboBox.SelectedItem = fileName;
                    return;
                }
                if (res == DialogResult.Yes) buttonSave_Click(null, null);
            }
            fileName = fn;
            Text = "GeDoSaTo Text " + (isEditable ? "Editor" : "Viewer") + " - " + fileName;
            fastColoredTextBox.Text = System.IO.File.ReadAllText(fileName);
            fastColoredTextBox.ClearUndo();
            buttonSave.Enabled = false;
            userButton.Enabled = !fn.Contains("_user.");
        }

        public TextForm(string fn, bool editable, List<string> kws = null)
        {
            InitializeComponent();
            isEditable = editable;
            startFn = fn;
            isShader = Path.GetExtension(fn) == ".fx";
            isList = Path.GetFileName(fn).Contains("list") && Path.GetFileName(fn).Contains(".txt");

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
                if (Path.GetExtension(fn) == ".ini" || Path.GetExtension(fn) == ".fx")
                {
                    filterTextBox_TextChanged(null, null);
                    profileComboBox.Visible = true;
                    profileLabel.Visible = true;

                    filterLabel.Visible = true;
                    filterTextBox.Visible = true;

                    if (Path.GetExtension(fn) == ".ini")
                    {
                        addProfileButton.Visible = true;
                        deleteButton.Visible = true;
                        userButton.Visible = true;
                    }
                }

                // create autocompletion menu
                popupMenu = new FastColoredTextBoxNS.AutocompleteMenu(fastColoredTextBox);
                popupMenu.MinFragmentLength = 2;
                popupMenu.Items.SetAutocompleteItems(keywords);
                popupMenu.Items.MaximumSize = new System.Drawing.Size(200, 300);
                popupMenu.Items.Width = 200;

                // adjust for shaders
                if (isShader)
                {
                    fastColoredTextBox.ShowLineNumbers = true;
                    fastColoredTextBox.HighlightFoldingIndicator = true;
                    fastColoredTextBox.LeftBracket = '(';
                    fastColoredTextBox.RightBracket = ')';
                    fastColoredTextBox.LeftBracket2 = '{';
                    fastColoredTextBox.RightBracket2 = '}';
                }

                // adjust for lists
                if (isList)
                {
                    buttonSort.Visible = true;
                }
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

            if (!isShader)
            {
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

                if (isList)
                {
                    e.ChangedRange.SetStyle(keywordStyle, @"\|\|");
                }
            }
            else
            {
                e.ChangedRange.ClearStyle(commentStyle);
                e.ChangedRange.SetStyle(commentStyle, @"/\*.*?\*/", RegexOptions.Multiline | RegexOptions.Singleline);
                e.ChangedRange.SetStyle(commentStyle, @"//.*$", RegexOptions.Multiline);

                e.ChangedRange.ClearStyle(defineStyle);
                e.ChangedRange.SetStyle(defineStyle, @"^\s*#define.*$", RegexOptions.Multiline);
                e.ChangedRange.SetStyle(defineStyle, @"^\s*#include.*$", RegexOptions.Multiline);
                e.ChangedRange.SetStyle(defineStyle, @"^\s*#if.*$", RegexOptions.Multiline);
                e.ChangedRange.SetStyle(defineStyle, @"^\s*#ifdef.*$", RegexOptions.Multiline);
                e.ChangedRange.SetStyle(defineStyle, @"^\s*#ifndef.*$", RegexOptions.Multiline);
                e.ChangedRange.SetStyle(defineStyle, @"^\s*#else.*$", RegexOptions.Multiline);
                e.ChangedRange.SetStyle(defineStyle, @"^\s*#endif.*$", RegexOptions.Multiline);

                e.ChangedRange.SetFoldingMarkers("{", "}");
            }
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

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string t = fastColoredTextBox.Text;
            var arr = t.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            var subset = arr.SkipWhile((s) => s.StartsWith("#") || s.Length == 0);
            var sslist = subset.ToList();
            sslist.Sort();
            sslist.RemoveAll((s) => s.Trim().Length == 0);
            var res = arr.TakeWhile((s) => s.StartsWith("#") || s.Length == 0);
            var reslist = res.ToList();
            reslist.AddRange(sslist);
            fastColoredTextBox.Text = String.Join("\r\n", reslist);
        }

        private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFile(profileComboBox.Text);
        }

        private void addProfileToList(string profilefn, List<string> list)
        {
            string filter = filterTextBox.Text.Trim();
            if (File.Exists(profilefn) && (filter.Length == 0 || Regex.IsMatch(profilefn, Regex.Escape(filter).Replace(" ", ".*"), RegexOptions.IgnoreCase)))
            {
                list.Add(profilefn);
            }
            var extension = Path.GetExtension(profilefn);
            var userfn = profilefn.Replace(extension, "_user" + extension);
            if (File.Exists(userfn) && (filter.Length == 0 || Regex.IsMatch(userfn, Regex.Escape(filter).Replace(" ", ".*"), RegexOptions.IgnoreCase)))
            {
                list.Add(userfn);
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            var newItems = new List<string>();
            addProfileToList(startFn, newItems);
            string justfn = Path.GetFileName(startFn);
            string dir = Path.GetDirectoryName(startFn).Replace("assets", "config");
            dir = dir.Replace("\\dx9", "");
            foreach (var d in Directory.EnumerateDirectories(dir))
            {
                var profilefn = Path.Combine(d, justfn);
                addProfileToList(profilefn, newItems);
            }
            if(newItems.Count > 0) {
                profileComboBox.Items.Clear();
                foreach(var i in newItems) profileComboBox.Items.Add(i);
                profileComboBox.SelectedIndex = 0;
            }
        }

        private void selectProfile(string fn)
        {
            if (profileComboBox.Items.Contains(fn))
            {
                profileComboBox.SelectedItem = fn;
            }
            else
            {
                profileComboBox.Items.Insert(0, fn);
                profileComboBox.SelectedIndex = 0;
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            string ext = Path.GetExtension(fileName);
            string userfn = fileName.Replace(ext, "_user" + ext);
            if (File.Exists(userfn))
            {
                selectProfile(userfn);
                return;
            }
            var result = MessageBox.Show("Creating a user profile for " + fileName
                + "\n\nUser profiles extend base profiles (overriding their settings) and persist over updates of GeDoSaTo. You should use them to store settings specific to your system or your own graphical preferences.\n\nProceed?",
                "User Profile Creation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                string defaultText = "# Lines starting with \"#\" are ignored by GeDoSaTo and used to provide documentation\n"
                                   + "\n"
                                   + "# This is a user config file override for " + fileName + "\n"
                                   + "# Look in that file for possible settings and their documentation\n"
                                   + "# Add your custom settings below\n\n";
                var stream = new StreamWriter(userfn);
                stream.Write(defaultText);
                stream.Close();
                selectProfile(userfn);
            }
        }

        private void addProfileButton_Click(object sender, EventArgs e)
        {
            var form = new NewProfileForm(startFn);
            var res = form.Prompt();
            if (!string.IsNullOrEmpty(res))
            {
                string defaultText = "# Lines starting with \"#\" are ignored by GeDoSaTo and used to provide documentation\n"
                                   + "\n"
                                   + "# This is a profile file for " + Path.GetDirectoryName(res).Replace("config\\","") + "\n\n";
                Directory.CreateDirectory(Path.GetDirectoryName(res));
                var stream = new StreamWriter(res);
                stream.Write(defaultText);
                stream.Close();
                profileComboBox.Items.Insert(0, res);
                profileComboBox.SelectedIndex = 0;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete " + fileName + "?", "Delete File", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                File.Delete(fileName);
                var dir = Path.GetDirectoryName(fileName);
                if (!Directory.EnumerateFileSystemEntries(dir).Any()) Directory.Delete(dir);
                filterTextBox_TextChanged(null, null);
            }
        }
    }
}