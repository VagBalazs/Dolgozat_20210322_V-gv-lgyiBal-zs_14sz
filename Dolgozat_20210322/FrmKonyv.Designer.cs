namespace Dolgozat_20210322
{
    partial class FrmKonyv
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHelyezes = new System.Windows.Forms.TextBox();
            this.cbSzerzo = new System.Windows.Forms.ComboBox();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(101, 30);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(58, 20);
            this.tbID.TabIndex = 0;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szerző:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cím:";
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(101, 108);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(173, 20);
            this.tbCim.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Helyezés:";
            // 
            // tbHelyezes
            // 
            this.tbHelyezes.Location = new System.Drawing.Point(101, 146);
            this.tbHelyezes.Name = "tbHelyezes";
            this.tbHelyezes.Size = new System.Drawing.Size(58, 20);
            this.tbHelyezes.TabIndex = 6;
            // 
            // cbSzerzo
            // 
            this.cbSzerzo.FormattingEnabled = true;
            this.cbSzerzo.Location = new System.Drawing.Point(101, 69);
            this.cbSzerzo.Name = "cbSzerzo";
            this.cbSzerzo.Size = new System.Drawing.Size(173, 21);
            this.cbSzerzo.TabIndex = 8;
            // 
            // btnRogzit
            // 
            this.btnRogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRogzit.Location = new System.Drawing.Point(15, 206);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(86, 57);
            this.btnRogzit.TabIndex = 10;
            this.btnRogzit.Text = "Rögzítés";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModosit.Location = new System.Drawing.Point(132, 206);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(86, 57);
            this.btnModosit.TabIndex = 11;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorol.Location = new System.Drawing.Point(246, 206);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(86, 57);
            this.btnTorol.TabIndex = 12;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // FrmKonyv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 285);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.cbSzerzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbHelyezes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Name = "FrmKonyv";
            this.Text = "FrmKonyv";
            this.Load += new System.EventHandler(this.FrmKonyv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHelyezes;
        private System.Windows.Forms.ComboBox cbSzerzo;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorol;
    }
}