using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat_20210322
{
    public partial class FrmKonyv : Form
    {
        SqlConnection conn;
        public DataGridViewRow dgvr;
        public FrmKonyv(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void FrmKonyv_Load(object sender, EventArgs e)
        {
            btnModosit.Enabled = false;
            btnTorol.Enabled = false;
            tbID.Enabled = false;

            conn.Open();

            var r = new SqlCommand(
                "SELECT nev FROM szerzo ORDER BY id ASC",
                conn).ExecuteReader();

            while (r.Read())
            {
                cbSzerzo.Items.Add(r[0]);
            }

            conn.Close();

            /*
             * FrmLista dgv sor adatainak beolvasása
      
            tbID.Text = dgvr.Cells[0].Value.ToString();
            cbSzerzo.Text = dgvr.Cells[1].Value.ToString();
            tbCim.Text = dgvr.Cells[2].Value.ToString();
            tbHelyezes.Text = dgvr.Cells[3].Value.ToString(); 

            btnRogzit.Enabled = false;
            */



        }

        public void kiirdgv()
        {
            tbID.Text = dgvr.Cells[0].Value.ToString();
            cbSzerzo.Text = dgvr.Cells[1].Value.ToString();
            tbCim.Text = dgvr.Cells[2].Value.ToString();
            tbHelyezes.Text = dgvr.Cells[3].Value.ToString();
        }

        public void feltolt()
        {
            string szerzo = cbSzerzo.Text;
            string cim = tbCim.Text;
            string helyezes = tbHelyezes.Text;

            conn.Open();

            var r = new SqlCommand(
                "INSERT INTO konyv(cim, szerzo, helyezes) VALUES ()",
                conn).ExecuteReader();

            while (r.Read())
            {
                cbSzerzo.Items.Add(r[0]);
            }

            conn.Close();
        }



        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan Rögzíti?", "Figyelmeztetés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void btnModosit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan módosítja?", "Figyelmeztetés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan törli?", "Figyelmeztetés", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                Close();
            }
        }
    }
}
