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
    public partial class adddnirobocze : Form
    {
        DzieńPracy dzieńPracy;
        internal adddnirobocze(DzieńPracy dzieńPracy)
        {
            InitializeComponent();
            this.dzieńPracy = dzieńPracy;
            foreach (Pracownik p in Pracownik.Pracownicy)
                comboBox1.Items.Add(p);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dzieńPracy.Data = dateTimePicker1.Value;
            dzieńPracy.zaplanowane_godziny = numericUpDown1.Value ;
            dzieńPracy.Pracownik = (Pracownik)comboBox1.SelectedItem;
            dzieńPracy.przepracowane_godziny = numericUpDown2.Value;

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
