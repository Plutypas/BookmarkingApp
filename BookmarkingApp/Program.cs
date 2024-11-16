namespace BookmarkingApp
{
    public class Folder
    {
        string name;
        List<Link> links = new List<Link>();
        List<Folder> folders = new List<Folder>();
        public Folder(string name)
        {
            this.name = name;
        }
        public void replace(Folder folder)
        {
            this.name=folder.name;
            links=new List<Link>();
            folders=new List<Folder>();
            this.merge(folder);
        }
        public void merge(Folder folder)
        {
            foreach (Link link in folder.getLinks())
            {
                this.links.Add(new Link());
                this.links[this.links.Count() - 1].setChanges(link.getName(), link.getLink());
            }
            foreach (Folder f in folder.getFolders())
            {
                this.folders.Add(new Folder(f.name));
                this.folders[this.folders.Count() - 1].replace(f);
            }
        }
        public void replaceDuplicates(Folder folder)
        {
            List<Link> linkList = new List<Link>();
            foreach (Link newLink in folder.links)
            {
                foreach (Link oldLink in this.links)
                {
                    if (newLink.getName().ToUpper()== oldLink.getName().ToUpper()
                        || newLink.getLink().ToUpper() == oldLink.getLink().ToUpper())
                    {
                        oldLink.setChanges(newLink.getName(), newLink.getLink());
                        linkList.Add(oldLink);
                    }

                }
            }
            foreach (Link item in linkList) {
                this.links.Remove(item);
            }
            List<Folder> folderList = new List<Folder>();
            foreach (Folder newFolder in folder.folders)
            {
                foreach (Folder oldFolder in this.folders)
                {
                    if (newFolder.name == oldFolder.name)
                    {
                        this.replaceDuplicates(newFolder);
                        folderList.Add(oldFolder);
                    }
                }
            }
            foreach (Folder item in folderList)
            {
                this.folders.Remove(item);
            }
        }
        public void setName(string name) {
            this.name = name;
        }
        override public string ToString()
        {
            return "FOLDER - " + name;
        }
        public void newLink()
        {
            this.links.Add(new Link());
        }
        public void newFolder()
        {
            this.folders.Add(new Folder("New Folder"));
        }
        public string getName()
        {
            return this.name;
        }
        public List<Link> getLinks()
        {
            return links;
        }
        public List<Folder> getFolders()
        {
            return folders;
        }
    }

    public class Link
    {
        string name;
        string link;
        public Link()
        {
            this.name = "New Link";
            this.link = "Link";
        }
        public string getName()
        {
            return name;
        }
        public string getLink()
        {
            return link;
        }
        override public string ToString()
        {
            return (name);
        }
        public void setChanges(string name, string link)
        {
            this.name = name;
            this.link = link;
        }
    }
    internal static class Program
    {
        public static async void Output(Folder main)
        {
            List<string> lines = new List<string>();
            lines.Add("[");
            lines.Add("  {");
            lines.Add("    \"toplevel_name\": " + "\"" + main.getName() + "\"");
            lines.Add("  },");
            foreach (Link link in main.getLinks())
            {
                lines.Add("  {");
                lines.Add("    \"url\": " + "\"" + link.getLink() + "\",");
                lines.Add("    \"name\": " + "\"" + link.getName() + "\"");
                lines.Add("  },");
            }
            if (main.getFolders().Count() == 0)
            {
                lines[lines.Count() - 1] = "  }";
            }
            else
            {
                foreach (Folder folder in main.getFolders())
                {
                    lines.Add("  {");
                    lines.Add("    \"name\": " + "\"" + folder.getName() + "\",");
                    lines.Add("    \"children\": " + "[");
                    foreach (Link link in folder.getLinks())
                    {
                        lines.Add("      {");
                        lines.Add("        \"url\": " + "\"" + link.getLink() + "\",");
                        lines.Add("        \"name\": " + "\"" + link.getName() + "\"");
                        lines.Add("      },");
                    }
                    if (folder.getFolders().Count() == 0)
                    {
                        lines[lines.Count() - 1] = "      }";
                    }
                    lines.Add("    ]");
                    lines.Add("  },");
                    if (folder.getName() == main.getFolders()[main.getFolders().Count() - 1].getName())
                    {
                        lines[lines.Count() - 1] = "  }";
                    }
                }
            }
            lines.Add("]");
            await File.WriteAllLinesAsync(main.getName() + ".txt", lines);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Folder root = new Folder("Main");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main(ref root, true));
            Output(root);
        }
    }
}