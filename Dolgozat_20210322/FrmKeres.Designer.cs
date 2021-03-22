namespace Dolgozat_20210322
{
    partial class FrmKeres
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
            this.dgvKeres = new System.Windows.Forms.DataGridView();
            this.Keres = new System.Windows.Forms.TextBox();
            this.konyvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKeres
            // 
            this.dgvKeres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.konyvID,
            this.helyezes,
            this.nev});
            this.dgvKeres.Location = new System.Drawing.Point(22, 80);
            this.dgvKeres.Name = "dgvKeres";
            this.dgvKeres.Size = new System.Drawing.Size(789, 315);
            this.dgvKeres.TabIndex = 3;
            this.dgvKeres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Keres
            // 
            this.Keres.Location = new System.Drawing.Point(22, 33);
            this.Keres.Name = "Keres";
            this.Keres.Size = new System.Drawing.Size(789, 20);
            this.Keres.TabIndex = 4;
            this.Keres.TextChanged += new System.EventHandler(this.Keres_TextChanged);
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
            this.helyezes.HeaderText = "Cím";
            this.helyezes.Name = "helyezes";
            this.helyezes.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "Helyezés";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // FrmKeres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 407);
            this.Controls.Add(this.Keres);
            this.Controls.Add(this.dgvKeres);
            this.Name = "FrmKeres";
            this.Text = "FrmKeres";
            this.Load += new System.EventHandler(this.FrmKeres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKeres;
        private System.Windows.Forms.TextBox Keres;
        private System.Windows.Forms.DataGridViewTextBoxColumn konyvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
    }
}