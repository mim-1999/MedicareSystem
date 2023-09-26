
namespace MedicareProject
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pharmacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availmedicines = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.Label();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pharmacyToolStripMenuItem,
            this.userQueriesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1095, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pharmacyToolStripMenuItem
            // 
            this.pharmacyToolStripMenuItem.Name = "pharmacyToolStripMenuItem";
            this.pharmacyToolStripMenuItem.Size = new System.Drawing.Size(182, 42);
            this.pharmacyToolStripMenuItem.Text = "Pharmacy";
            // 
            // userQueriesToolStripMenuItem
            // 
            this.userQueriesToolStripMenuItem.Name = "userQueriesToolStripMenuItem";
            this.userQueriesToolStripMenuItem.Size = new System.Drawing.Size(229, 42);
            this.userQueriesToolStripMenuItem.Text = "User Queries";
            this.userQueriesToolStripMenuItem.Click += new System.EventHandler(this.userQueriesToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(138, 42);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // availmedicines
            // 
            this.availmedicines.AutoSize = true;
            this.availmedicines.BackColor = System.Drawing.Color.LightGray;
            this.availmedicines.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availmedicines.Location = new System.Drawing.Point(316, 57);
            this.availmedicines.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.availmedicines.Name = "availmedicines";
            this.availmedicines.Size = new System.Drawing.Size(396, 46);
            this.availmedicines.TabIndex = 1;
            this.availmedicines.Text = "Available Medicines";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Silver;
            this.type.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(28, 178);
            this.type.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(69, 28);
            this.type.TabIndex = 2;
            this.type.Text = "Type";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Silver;
            this.name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(28, 241);
            this.name.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(79, 28);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Silver;
            this.price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(23, 306);
            this.price.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(74, 28);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.BackColor = System.Drawing.Color.Silver;
            this.image.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Location = new System.Drawing.Point(23, 370);
            this.image.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(84, 28);
            this.image.TabIndex = 5;
            this.image.Text = "Image";
            // 
            // idtextbox
            // 
            this.idtextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextbox.Location = new System.Drawing.Point(103, 175);
            this.idtextbox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(208, 34);
            this.idtextbox.TabIndex = 6;
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextbox.Location = new System.Drawing.Point(103, 238);
            this.nametextbox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(208, 34);
            this.nametextbox.TabIndex = 7;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextbox.Location = new System.Drawing.Point(103, 302);
            this.pricetextbox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(208, 34);
            this.pricetextbox.TabIndex = 8;
            // 
            // browse
            // 
            this.browse.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(170, 562);
            this.browse.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(87, 33);
            this.browse.TabIndex = 10;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.WhiteSmoke;
            this.insert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(22, 601);
            this.insert.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(89, 38);
            this.insert.TabIndex = 11;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.WhiteSmoke;
            this.update.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(129, 601);
            this.update.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(92, 38);
            this.update.TabIndex = 12;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(233, 601);
            this.delete.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(87, 38);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(326, 601);
            this.reset.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(92, 38);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(428, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 487);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.BackColor = System.Drawing.Color.Silver;
            this.idlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(38, 117);
            this.idlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(38, 28);
            this.idlabel.TabIndex = 16;
            this.idlabel.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 112);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 34);
            this.textBox1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 356);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1095, 656);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.image);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.type);
            this.Controls.Add(this.availmedicines);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pharmacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userQueriesToolStripMenuItem;
        private System.Windows.Forms.Label availmedicines;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label image;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}