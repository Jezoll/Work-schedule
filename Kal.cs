using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikPracy
{
    public partial class Kal : Form
    {
        public Kal()
        {
            InitializeComponent();
        

        
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Data";
            dataGridView1.Columns[1].Name = "Zaplanowane godz.";
            dataGridView1.Columns[2].Name = "Pracownik";
            dataGridView1.Columns[3].Name = "Godz. Przeprac.";
            

            dataGridView1.Rows.Clear();
            foreach (DzieńPracy dp in DzieńPracy.DniPracy)
                dataGridView1.Rows.Add(dp.Data.ToString(), dp.zaplanowane_godziny, dp.Pracownik, dp.przepracowane_godziny);
        }

        void wyśw()
        {
            dataGridView1.Rows.Clear();
            foreach (DzieńPracy dp in DzieńPracy.DniPracy)
                dataGridView1.Rows.Add(dp.Data.ToString(), dp.zaplanowane_godziny, dp.Pracownik, dp.przepracowane_godziny);
        }
            private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DzieńPracy nowy = new DzieńPracy();
            adddnirobocze form = new adddnirobocze(nowy);

            form.ShowDialog();

            DzieńPracy.DniPracy.Add(nowy);

                wyśw();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DzieńPracy.DniPracy.Remove(DzieńPracy.DniPracy[dataGridView1.SelectedCells[0].RowIndex]);

            wyśw();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            DzieńPracy dzieńPracy = DzieńPracy.DniPracy[index];

            adddnirobocze form = new adddnirobocze(dzieńPracy);
            form.ShowDialog();

            wyśw();
        }

        private void rozliczajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rozliczaj form = new rozliczaj();
            form.ShowDialog();
        }
    }
}
