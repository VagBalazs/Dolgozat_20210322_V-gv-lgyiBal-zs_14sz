namespace Dolgozat_20210322
{
    partial class FrmLista
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sZERZŐKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.úJKÖNYVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.konyvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sZERZŐKToolStripMenuItem,
            this.úJKÖNYVToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sZERZŐKToolStripMenuItem
            // 
            this.sZERZŐKToolStripMenuItem.Name = "sZERZŐKToolStripMenuItem";
            this.sZERZŐKToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.sZERZŐKToolStripMenuItem.Text = "SZERZŐK";
            // 
            // úJKÖNYVToolStripMenuItem
            // 
            this.úJKÖNYVToolStripMenuItem.Name = "úJKÖNYVToolStripMenuItem";
            this.úJKÖNYVToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.úJKÖNYVToolStripMenuItem.Text = "ÚJ KÖNYV";
            this.úJKÖNYVToolStripMenuItem.Click += new System.EventHandler(this.úJKÖNYVToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.konyvID,
            this.helyezes,
            this.nev,
            this.cim});
            this.dataGridView1.Location = new System.Drawing.Point(13, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 315);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // konyvID
            // 
            this.konyvID.HeaderText = "konyvID";
            this.konyvID.Name = "konyvID";
            this.konyvID.ReadOnly = true;
            this.konyvID.Visible = false;
            // 
            // helyezes
            // 
            this.helyezes.HeaderText = "helyezes";
            this.helyezes.Name = "helyezes";
            this.helyezes.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "nev";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // cim
            // 
            this.cim.HeaderText = "cim";
            this.cim.Name = "cim";
            this.cim.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(13, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(789, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Keresés szerző vagy cím alapján";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLista";
            this.Text = "Nagykönyv";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sZERZŐKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem úJKÖNYVToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
        private System.Windows.Forms.Button button1;
    }
}

