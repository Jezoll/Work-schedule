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

    public partial class Form1 : Form
    {
        


        internal void dopiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pracownik nowy = new Pracownik();
            Dodawanie form = new Dodawanie(nowy);
            form.ShowDialog();
            Pracownik.Pracownicy.Add(nowy);
            wyśw();
        }
        public Form1()
        {
            InitializeComponent();
        }
       
            private void wyśw()
        {
            dataGridView1.Rows.Clear();
            foreach (Pracownik p in Pracownik.Pracownicy)
                dataGridView1.Rows.Add(p.Imię, p.Nazwisko, p.Stawka, p.Rozpoczął.ToString(), p.Urodzony.ToString(), p.Urząd, p.NrTel);
            

    }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Imię";
            dataGridView1.Columns[1].Name = "Nazwisko";
            dataGridView1.Columns[2].Name = "Stawka";
            dataGridView1.Columns[3].Name = "Rozpoczął";
            dataGridView1.Columns[4].Name = "Urodzony";
            dataGridView1.Columns[5].Name = "Urząd";
            dataGridView1.Columns[6].Name = "Nr Tel";
            

           



            Pracownik p = new Pracownik();
            p.Imię = "Andrzej";
            p.Nazwisko = "Strejlau";
            p.Adres = "Szczypiornistów";
            p.NrTel = "13 59 512";
            p.Stawka = 50;
            p.Urząd = "Warszawa Mokotów";
            p.Rozpoczął = new DateTime(1954, 1, 1);
            p.Urodzony = new DateTime(1940, 2, 19);
           
            Pracownik.Pracownicy.Add(p);

            p = new Pracownik();
            p.Imię = "Jacek";
            p.Nazwisko = "Gmoch";
            p.Adres = "Arki Noego";
            p.NrTel = "12 55 222";
            p.Stawka = 35;
            p.Urząd = "Warszawa Południe";
            p.Rozpoczął = new DateTime(1953, 1, 1);
            p.Urodzony = new DateTime(1939, 1, 13);
            Pracownik.Pracownicy.Add(p);

            p = new Pracownik();
            p.Imię = "Antoni";
            p.Nazwisko = "Piechniczek";
            p.Adres = "Lipińska";
            p.NrTel = "34 119 5412";
            p.Stawka = 60;
            p.Urząd = "Świętochłowice";
            p.Rozpoczął = new DateTime(1954, 1, 1);
            p.Urodzony = new DateTime(1942, 5, 5);
            Pracownik.Pracownicy.Add(p);

            DzieńPracy dzieńPracy = new DzieńPracy();
            dzieńPracy.Data = new DateTime(2021, 06, 1);
            dzieńPracy.Liczba_godzin = 8;
            dzieńPracy.Zaplanowane_godziny = 8;
            dzieńPracy.Przepracowane_godziny = 8;
            dzieńPracy.pracownik = p;
            DzieńPracy.DniPracy.Add(dzieńPracy);

            dzieńPracy = new DzieńPracy();
            dzieńPracy.Data = new DateTime(2009, 12, 1);
            dzieńPracy.Liczba_godzin = 8;
            dzieńPracy.Zaplanowane_godziny = 8;
            dzieńPracy.Przepracowane_godziny = 8;
            dzieńPracy.pracownik = Pracownik.Pracownicy[1];
            DzieńPracy.DniPracy.Add(dzieńPracy);

            dzieńPracy = new DzieńPracy();
            dzieńPracy.Data = new DateTime(2005, 10, 12);
            dzieńPracy.Liczba_godzin = 8;
            dzieńPracy.Zaplanowane_godziny = 8;
            dzieńPracy.Przepracowane_godziny = 8;
            dzieńPracy.pracownik = Pracownik.Pracownicy[0];
            DzieńPracy.DniPracy.Add(dzieńPracy);

            
            

            


                wyśw();
            

        }

        void refresh()
        {
            //DzieńPracy.DniPracy.Sort();

            //dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            //int col_nr = 0;
            //dataGridView1.Columns.Add("col" + col_nr++, "dzień miesiąca");
            //dataGridView1.Columns.Add("col" + col_nr++, "zaplanowanych godzin");

            //foreach (Pracownik p in Pracownik.Pracownicy)
            //{
            //    int ind = dataGridView1.Columns.Add("col" + col_nr++, "Zaplanowane " + p);
            //    dataGridView1.Columns[ind].Tag = p;
            //}


            //foreach (Pracownik p in Pracownik.Pracownicy)
            //    dataGridView1.Columns[dataGridView1.Columns.Add("col" + col_nr++, "Przepracowane " + p)].Tag = p;


            //foreach (DzieńPracy dzień in DzieńPracy.DniPracy)
            //{
            //    List<object> val = new List<object>();
            //    val.Add(dzień.Nr_dnia_miesiąca);
            //    val.Add(dzień.Liczba_godzin);
            //    {
            //        foreach (Pracownik p in Pracownik.Pracownicy)
            //            if (dzień[p] > 0)
            //                val.Add(dzień[p]);
            //            else
            //               val.Add("");

            //        for (int i = 0; i < Pracownik.Pracownicy.Count; i++)
            //           if (dzień.Przepracowane_godziny[i] > 0)
            //             val.Add(dzień.Przepracowane_godziny[i]);
            //           else
            //               val.Add("");

            //        dataGridView1.Rows[dataGridView1.Rows.Add(val.ToArray())].Tag = dzień;
            //    }
            //}

        } private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pracownik.Pracownicy.Remove(Pracownik.Pracownicy[dataGridView1.SelectedCells[0].RowIndex]);

            wyśw();
        }

        private void edytujtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            Pracownik pracownik = Pracownik.Pracownicy[index];

            Dodawanie form = new Dodawanie(pracownik);
            form.ShowDialog();

            wyśw();

        }

        private void rozliczajtoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kal form = new Kal();
            form.ShowDialog();

        }
    }
}

        


    

    

