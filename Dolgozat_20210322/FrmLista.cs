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
    public partial class FrmLista : Form
    {
        SqlConnection conn;
        public FrmLista()
        {
            conn = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database = nagykonyv;");
            InitializeComponent();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            //Kezdés: 14:26
            //Vége: 16:48

            conn.Open();

            var r = new SqlCommand(
                "SELECT konyv.id,helyezes,szerzo.nev,cim FROM konyv,szerzo WHERE konyv.szerzoId = szerzo.id ORDER BY helyezes ASC",
                conn).ExecuteReader();

            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2], r[3]);
            }

            conn.Close();
        }

        private void úJKÖNYVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKonyv frm = new FrmKonyv(conn);
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKeres frm = new FrmKeres(conn);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                try
                {
                    FrmKonyv frm = new FrmKonyv(conn);
                    frm.dgvr = dataGridView1.Rows[e.RowIndex];
                    frm.ShowDialog();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message.ToString());
                }
            }
        }

    }
}
