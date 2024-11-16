using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookmarkingApp
{
    public partial class Warning : Form
    {
        public bool close { get; set; }
        public Warning()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            close = true;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            close = false;
            Close();
        }
    }
}
