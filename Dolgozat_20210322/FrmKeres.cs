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
    public partial class FrmKeres : Form
    {
        SqlConnection conn;
        public FrmKeres(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Keres_TextChanged(object sender, EventArgs e)
        {
            Szures(Keres.Text);
        }

        private void FrmKeres_Load(object sender, EventArgs e)
        {
            Szures("");
        }

        private void Szures(string kulcsszo)
        {
            dgvKeres.Rows.Clear();
            conn.Open();

            var r = new SqlCommand(
                "SELECT konyv.id,cim,helyezes FROM konyv " +
                "INNER JOIN szerzo ON konyv.szerzoId = szerzo.id " +
                $"WHERE cim LIKE '{kulcsszo}%'"+ "ORDER BY helyezes ASC;",
                conn).ExecuteReader();

            while (r.Read())
            {
                dgvKeres.Rows.Add(r[2],r[1] );
            }
            conn.Close();
        }
    }
}
