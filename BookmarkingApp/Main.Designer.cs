namespace BookmarkingApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Directory = new System.Windows.Forms.ListBox();
            this.LinkButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Directory
            // 
            this.Directory.FormattingEnabled = true;
            this.Directory.ItemHeight = 25;
            this.Directory.Location = new System.Drawing.Point(208, 25);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(311, 404);
            this.Directory.TabIndex = 0;
            this.Directory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Directory_MouseDoubleClick);
            // 
            // LinkButton
            // 
            this.LinkButton.Location = new System.Drawing.Point(12, 25);
            this.LinkButton.Name = "LinkButton";
            this.LinkButton.Size = new System.Drawing.Size(190, 34);
            this.LinkButton.TabIndex = 1;
            this.LinkButton.Text = "Make new link";
            this.LinkButton.UseVisualStyleBackColor = true;
            this.LinkButton.Click += new System.EventHandler(this.LinkButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make new folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 398);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(190, 31);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(12, 358);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(190, 34);
            this.nameButton.TabIndex = 4;
            this.nameButton.Text = "Change folder name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 105);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(190, 34);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete selected item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(190, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit current folder";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 278);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(190, 34);
            this.load.TabIndex = 8;
            this.load.Text = "Load bookmark data";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.load);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LinkButton);
            this.Controls.Add(this.Directory);
            this.Name = "Main";
            this.Text = "Bookmark Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListBox Directory;
        private Button LinkButton;
        private Button button1;
        private TextBox nameBox;
        private Button nameButton;
        private Button deleteButton;
        private Button exitButton;
        private Button load;
    }
}