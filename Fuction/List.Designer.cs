namespace Fuction
{
    partial class List
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
            this.massageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.rollTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // massageRichTextBox
            // 
            this.massageRichTextBox.Location = new System.Drawing.Point(94, 96);
            this.massageRichTextBox.Name = "massageRichTextBox";
            this.massageRichTextBox.Size = new System.Drawing.Size(135, 194);
            this.massageRichTextBox.TabIndex = 0;
            this.massageRichTextBox.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(135, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(245, 70);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(245, 110);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // rollTextBox
            // 
            this.rollTextBox.Location = new System.Drawing.Point(94, 36);
            this.rollTextBox.Name = "rollTextBox";
            this.rollTextBox.Size = new System.Drawing.Size(135, 20);
            this.rollTextBox.TabIndex = 4;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rollTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.massageRichTextBox);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox massageRichTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox rollTextBox;
    }
}