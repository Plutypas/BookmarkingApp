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

namespace BookmarkingApp
{
    public partial class Loader : Form
    {
        public Folder main;
        public Loader(ref Folder root)
        {
            main = root;
            InitializeComponent();
        }

        private void Append_CheckedChanged(object sender, EventArgs e)
        {
            Duplicates.Enabled = Append.Checked;
            separate.Enabled = !Append.Checked;
            if (!Append.Checked)
            {
                Duplicates.Checked = false;
            }
        }

        private void separate_CheckedChanged(object sender, EventArgs e)
        {
            Append.Enabled = !separate.Checked;
            Duplicates.Enabled = !separate.Checked && Append.Checked;
            if (separate.Checked)
            {
                Append.Checked = false;
                Duplicates.Checked = false;
            }
        }

        private string getFolderName()
        {
            Regex extract = new Regex(@"([""'])toplevel_name([""']):\s([""'])[a-zA-Z0-9\s]+([""'])");
            Regex refine = new Regex(@"([""'])(?:(?=(\\?))\2.)*?\1");

            string bookmark = string.Join("", entry.Lines);
            string name = refine.Matches(extract.Match(bookmark).ToString())[1].ToString();
            return name.Substring(1, name.Length - 2);
        }

        private Folder generateFolder(string bookmark, string name)
        {
            Folder output = new Folder(name);

            Regex extract = new Regex(@"([""'])(?:(?=(\\?))\2.)*?\1");
            Regex folders = new Regex(@"([""'])children([""']):\s[[][^]]+]");
            int foldercount = 0;
            for (int i = 0; i < extract.Matches(bookmark).Count(); i++)
            {
                string selection = extract.Matches(bookmark)[i].ToString();
                if (selection == "\"url\"")
                {
                    selection = extract.Matches(bookmark)[i + 1].ToString();
                    string link = selection.Substring(1, selection.Length - 2);
                    selection = extract.Matches(bookmark)[i + 3].ToString();
                    string linkName = selection.Substring(1, selection.Length - 2);
                    output.newLink();
                    output.getLinks()[output.getLinks().Count - 1].setChanges(linkName, link);
                }

                if (selection == "\"children\"")
                {
                    Regex namePattern = new Regex(@"([""'])name([""']):\s[^,]+,\s*([""'])children([""'])");

                    string fname = extract.Matches(namePattern.Matches(bookmark)[foldercount].ToString())[1].ToString();
                    fname = fname.Substring(1, fname.Length - 2);

                    string folderdata = folders.Matches(bookmark)[foldercount].ToString();
                    folderdata = folderdata.Substring(10, folderdata.Length - 12);

                    Warning.Text = folderdata;

                    i = i + extract.Matches(folderdata).Count();
                    foldercount++;

                    output.newFolder();
                    output.getFolders()[output.getFolders().Count() - 1].replace(generateFolder(folderdata, fname));
                }

            }
            return output;
        }

        private bool valid(string input)
        {
            Regex link = new Regex(@"{\s*[""]url[""]:\s[""][^""]*[""],\s*[""]name[""]:\s[""][^""]*[""]\s*}");
            Regex folder = new Regex(@"{\s*[""]name[""]: [""][^""]*[""],\s*[""]children[""]:\s[[][^]]*]\s*}");
            Regex toplevel = new Regex(@"{\s*[""]toplevel_name[""]:\s[""][^""]*[""]\s*},");
            Regex brackets = new Regex(@"{");

            int completec = 0;
            int completes = 0;
            foreach (char character in input)
            {
                switch (character)
                {
                    case '{':
                        completec++;
                        break;
                    case '}':
                        completec--;
                        break;
                    case '[':
                        completes++;
                        break;
                    case ']':
                        completes--;
                        break;
                    default:
                        break;
                }
            }
            if (completes!=0 && completec!=0) { return false; }
            if (toplevel.Matches(input).Count()!=1) { return false; }
            if (brackets.Matches(input).Count()!=(toplevel.Matches(input).Count()+folder.Matches(input).Count()+link.Matches(input).Count())) { return false; }

            return true;
        }

        private void load_Click(object sender, EventArgs e)
        {
            Folder folder = generateFolder(string.Join("", entry.Lines), getFolderName());
            if (Append.Checked)
            {
                if (Duplicates.Checked)
                {
                    this.main.replaceDuplicates(folder);
                }
                this.main.merge(folder);
            }
            else if (separate.Checked)
            {
                this.main.newFolder();
                this.main.getFolders()[this.main.getFolders().Count() - 1].replace(folder);
            }
            else
            {
                this.main.replace(folder);
            }
            Close();
        }

        private void entry_TextChanged(object sender, EventArgs e)
        {
            load.Enabled = valid(string.Join("", entry.Lines));
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
