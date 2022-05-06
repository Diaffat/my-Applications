namespace WindowsForms_App21
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregi = new System.Windows.Forms.Button();
            this.btnInside = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnsetting);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btnInside);
            this.panel1.Controls.Add(this.btnregi);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 1, 0, 1);
            this.panel1.Size = new System.Drawing.Size(1026, 105);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnregi
            // 
            this.btnregi.BackColor = System.Drawing.Color.Brown;
            this.btnregi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnregi.FlatAppearance.BorderSize = 0;
            this.btnregi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregi.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnregi.Image = ((System.Drawing.Image)(resources.GetObject("btnregi.Image")));
            this.btnregi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregi.Location = new System.Drawing.Point(15, 25);
            this.btnregi.Name = "btnregi";
            this.btnregi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnregi.Size = new System.Drawing.Size(164, 75);
            this.btnregi.TabIndex = 0;
            this.btnregi.Text = "Registration";
            this.btnregi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregi.UseMnemonic = false;
            this.btnregi.UseVisualStyleBackColor = false;
            this.btnregi.Click += new System.EventHandler(this.btnregi_Click);
            // 
            // btnInside
            // 
            this.btnInside.BackColor = System.Drawing.Color.Brown;
            this.btnInside.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInside.FlatAppearance.BorderSize = 0;
            this.btnInside.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInside.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInside.Image = ((System.Drawing.Image)(resources.GetObject("btnInside.Image")));
            this.btnInside.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInside.Location = new System.Drawing.Point(179, 25);
            this.btnInside.Name = "btnInside";
            this.btnInside.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInside.Size = new System.Drawing.Size(164, 75);
            this.btnInside.TabIndex = 1;
            this.btnInside.Text = "Inside";
            this.btnInside.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInside.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInside.UseMnemonic = false;
            this.btnInside.UseVisualStyleBackColor = false;
            this.btnInside.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Brown;
            this.btnreport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnreport.Image = ((System.Drawing.Image)(resources.GetObject("btnreport.Image")));
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(343, 25);
            this.btnreport.Name = "btnreport";
            this.btnreport.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnreport.Size = new System.Drawing.Size(164, 75);
            this.btnreport.TabIndex = 2;
            this.btnreport.Text = "Reports";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreport.UseMnemonic = false;
            this.btnreport.UseVisualStyleBackColor = false;
            // 
            // btnsetting
            // 
            this.btnsetting.BackColor = System.Drawing.Color.Brown;
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(507, 25);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnsetting.Size = new System.Drawing.Size(164, 75);
            this.btnsetting.TabIndex = 3;
            this.btnsetting.Text = "Settings";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseMnemonic = false;
            this.btnsetting.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(671, 25);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(164, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Notification";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Brown;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(835, 25);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(164, 75);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseMnemonic = false;
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1365, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.enregistrerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.enregistrerToolStripMenuItem.Text = "Exit";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnInside;
        private System.Windows.Forms.Button btnregi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    }
}

