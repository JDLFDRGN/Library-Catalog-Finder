
namespace LibraryCatalogFinder
{
    partial class Form1
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
            this.Library = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.ComboBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Library)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Library
            // 
            this.Library.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Library.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Library.Location = new System.Drawing.Point(4, 50);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(589, 493);
            this.Library.TabIndex = 0;
            // 
            // Categories
            // 
            this.Categories.FormattingEnabled = true;
            this.Categories.Items.AddRange(new object[] {
            "All",
            "Automotive",
            "Communication",
            "Databases",
            "Electronic media",
            "Electronics",
            "Electronics Engineering",
            "Game Art",
            "Game Design",
            "Game Programming",
            "Graphics",
            "ICT",
            "Mechatronics",
            "Networking",
            "Plumbing",
            "Programming",
            "Utilities",
            "Web Design"});
            this.Categories.Location = new System.Drawing.Point(602, 112);
            this.Categories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(165, 21);
            this.Categories.TabIndex = 1;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(602, 176);
            this.ISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(165, 20);
            this.ISBN.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(602, 245);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(165, 20);
            this.Title.TabIndex = 3;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(602, 310);
            this.Author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(165, 20);
            this.Author.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(682, 348);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 24);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(4, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Library Catalog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 44);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.Color.Cyan;
            this.panel2.Location = new System.Drawing.Point(602, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 43);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.Library);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Library System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Library)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Library;
        private System.Windows.Forms.ComboBox Categories;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

