using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookmarkingApp.Link;
using static BookmarkingApp.Folder;
using System.Text.RegularExpressions;

namespace BookmarkingApp
{
    public partial class LinkInput : Form
    {
        Link subject;
        public LinkInput(ref Link link)
        {
            InitializeComponent();
            nameBox.Text = link.getName();
            linkBox.Text = link.getLink();
            subject = link;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            subject.setChanges(nameBox.Text, linkBox.Text);
            submit.ForeColor = Color.Green;
            submit.Text = "Changes Submitted!";
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void validate()
        {
            Regex banned = new Regex(@"]|{|}|[[]|[""]|'|,");
            submit.Enabled = !banned.IsMatch(nameBox.Text) && !banned.IsMatch(linkBox.Text);
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void linkBox_TextChanged(object sender, EventArgs e)
        {
            validate();
        }
    }
}
