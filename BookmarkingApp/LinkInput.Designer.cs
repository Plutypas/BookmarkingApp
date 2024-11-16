namespace BookmarkingApp
{
    partial class LinkInput
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(77, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(400, 31);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(77, 49);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(400, 31);
            this.linkBox.TabIndex = 1;
            this.linkBox.TextChanged += new System.EventHandler(this.linkBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(28, 52);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(43, 25);
            this.linkLabel.TabIndex = 3;
            this.linkLabel.Text = "Link";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(77, 86);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(282, 34);
            this.submit.TabIndex = 4;
            this.submit.Text = "Save and Exit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(365, 86);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Cancel";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // LinkInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 130);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.nameBox);
            this.Name = "LinkInput";
            this.Text = "Edit Link";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameBox;
        private TextBox linkBox;
        private Label NameLabel;
        private Label linkLabel;
        private Button submit;
        private Button exitButton;
    }
}