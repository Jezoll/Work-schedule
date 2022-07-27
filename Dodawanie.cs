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
    public partial class Dodawanie : Form
    {
    
        Pracownik pracownik;
        internal Dodawanie(Pracownik pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void zatwierdz_Click(object sender, EventArgs e)
        {
            pracownik.Imię = textBoximię.Text;
            pracownik.Nazwisko = textBoxnazwisko.Text;
            pracownik.Urodzony = dateTimePickerurodzony.Value;
            pracownik.Rozpoczął = dateTimePickerrozpoczął.Value;
            pracownik.Adres = textBoxadres.Text;
            pracownik.Urząd = textBoxurząd.Text;
            pracownik.NrTel = textBoxnrtel.Text;
            pracownik.Stawka = numericUpDownstawka.Value;
            

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void textBoxnazwisko_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
