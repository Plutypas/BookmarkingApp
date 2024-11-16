using System.Text.RegularExpressions;

namespace BookmarkingApp
{
    public partial class Main : Form
    {
        Folder main;
        bool warning;

        public Main(ref Folder root, bool rootWarning)
        {
            InitializeComponent();
            main = root;
            warning = rootWarning;
            nameBox.Text = main.getName();
            this.Text = "Bookmark Builder - " + main.getName();
            if (rootWarning)
            {
                exitButton.Text = "Exit and Export";
            }
            RedrawDirectory();
        }

        private void Directory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Directory.SelectedIndex > -1)
            {
                if (Directory.SelectedItem.GetType().Equals(new Link().GetType()))
                {
                    Link link = (Link)Directory.SelectedItem;
                    LinkInput form = new LinkInput(ref link);
                    form.ShowDialog();
                }
                else if (Directory.SelectedItem.GetType().Equals(new Folder("").GetType()))
                {
                    Folder folder = (Folder)Directory.SelectedItem;
                    Main form = new Main(ref folder, false);
                    form.ShowDialog();
                }
                RedrawDirectory();
            }
        }

        private void RedrawDirectory()
        {
            Directory.Items.Clear();
            foreach (Link link in main.getLinks())
            {
                Directory.Items.Add(link);
            }
            foreach (Folder folder in main.getFolders())
            {
                Directory.Items.Add(folder);
            }
            Directory.Refresh();
        }

        private void LinkButton_Click(object sender, EventArgs e)
        {
            main.newLink();
            RedrawDirectory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.newFolder();
            RedrawDirectory();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            main.setName(nameBox.Text);
            this.Text = "Bookmark Builder - " + main.getName();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Directory.SelectedIndex > -1) {
                if (Directory.SelectedItem.GetType().Equals(new Link().GetType()))
                {
                    Link link = (Link)Directory.SelectedItem;
                    main.getLinks().Remove(link);
                }
                else if (Directory.SelectedItem.GetType().Equals(new Folder("").GetType()))
                {
                    Folder folder = (Folder)Directory.SelectedItem;
                    main.getFolders().Remove(folder);
                }
                RedrawDirectory();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (warning)
            {
                Warning form = new Warning();
                form.ShowDialog();
                if (form.close)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            Loader form = new Loader(ref main);
            form.ShowDialog();
            nameBox.Text=main.getName();
            this.Text = "Bookmark Builder - " + main.getName();
            RedrawDirectory();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            Regex banned = new Regex(@"]|{|}|[[]|[""]|'|,");
            nameButton.Enabled = !banned.IsMatch(nameBox.Text);
        }
    }
}