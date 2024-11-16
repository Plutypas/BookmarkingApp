namespace BookmarkingApp
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.entry = new System.Windows.Forms.RichTextBox();
            this.Warning = new System.Windows.Forms.Label();
            this.Append = new System.Windows.Forms.CheckBox();
            this.Duplicates = new System.Windows.Forms.CheckBox();
            this.load = new System.Windows.Forms.Button();
            this.separate = new System.Windows.Forms.CheckBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entry
            // 
            this.entry.Location = new System.Drawing.Point(12, 12);
            this.entry.Name = "entry";
            this.entry.Size = new System.Drawing.Size(815, 319);
            this.entry.TabIndex = 0;
            this.entry.Text = "";
            this.entry.TextChanged += new System.EventHandler(this.entry_TextChanged);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(241, 370);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(586, 75);
            this.Warning.TabIndex = 1;
            this.Warning.Text = resources.GetString("Warning.Text");
            // 
            // Append
            // 
            this.Append.AutoSize = true;
            this.Append.Location = new System.Drawing.Point(12, 381);
            this.Append.Name = "Append";
            this.Append.Size = new System.Drawing.Size(154, 29);
            this.Append.TabIndex = 2;
            this.Append.Text = "Append mode";
            this.Append.UseVisualStyleBackColor = true;
            this.Append.CheckedChanged += new System.EventHandler(this.Append_CheckedChanged);
            // 
            // Duplicates
            // 
            this.Duplicates.AutoSize = true;
            this.Duplicates.Enabled = false;
            this.Duplicates.Location = new System.Drawing.Point(12, 416);
            this.Duplicates.Name = "Duplicates";
            this.Duplicates.Size = new System.Drawing.Size(223, 29);
            this.Duplicates.TabIndex = 3;
            this.Duplicates.Text = "Replace duplicate items";
            this.Duplicates.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            this.load.Enabled = false;
            this.load.Location = new System.Drawing.Point(241, 337);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(400, 34);
            this.load.TabIndex = 4;
            this.load.Text = "Load Bookmark";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // separate
            // 
            this.separate.AutoSize = true;
            this.separate.Location = new System.Drawing.Point(12, 346);
            this.separate.Name = "separate";
            this.separate.Size = new System.Drawing.Size(218, 29);
            this.separate.TabIndex = 5;
            this.separate.Text = "Add as separate folder";
            this.separate.UseVisualStyleBackColor = true;
            this.separate.CheckedChanged += new System.EventHandler(this.separate_CheckedChanged);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(647, 337);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(179, 34);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Cancel and Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.separate);
            this.Controls.Add(this.load);
            this.Controls.Add(this.Duplicates);
            this.Controls.Add(this.Append);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.entry);
            this.Name = "Loader";
            this.Text = "Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox entry;
        private Label Warning;
        private CheckBox Append;
        private CheckBox Duplicates;
        private Button load;
        private CheckBox separate;
        private Button Exit;
    }
}