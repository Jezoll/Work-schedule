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
    
    
    public partial class rozliczaj : Form
    {
        DzieńPracy dzieńPracy;
        private void Form1_Load(object sender, EventArgs e)
        { 
            foreach (Pracownik p in Pracownik.Pracownicy)
                comboBox1.Items.Add(p);
            if (dzieńPracy.Pracownik == comboBox1.SelectedItem)
                label2.Text = dzieńPracy.Przepracowane_godziny.ToString();



        }



        void obliczenia(Pracownik pracownik)
        {
            decimal suma = 0;
            decimal kara = 0;
            decimal nadgodz = 0;
            foreach (DzieńPracy dzieńPracy in DzieńPracy.DniPracy)
            {
                if (dzieńPracy.Pracownik == pracownik)
                {
                    decimal suma1 = 0;
                    if (dzieńPracy.Przepracowane_godziny < dzieńPracy.Zaplanowane_godziny)
                    {
                        suma = dzieńPracy.Przepracowane_godziny * dzieńPracy.Pracownik.Stawka;
                        decimal róż = dzieńPracy.Zaplanowane_godziny - dzieńPracy.Przepracowane_godziny;
                        decimal x = róż * dzieńPracy.Pracownik.Stawka * 3;
                        suma -= x;
                        kara += x;
                    }
                    else if (dzieńPracy.Przepracowane_godziny > dzieńPracy.Zaplanowane_godziny)
                    {
                        suma = dzieńPracy.Zaplanowane_godziny * dzieńPracy.Pracownik.Stawka;
                        decimal róż = dzieńPracy.Przepracowane_godziny - dzieńPracy.Zaplanowane_godziny;
                        decimal x = róż * dzieńPracy.Pracownik.Stawka * 3;
                        suma += x;
                        nadgodz += x;
                    }
                    else
                    {
                        suma = dzieńPracy.Przepracowane_godziny * dzieńPracy.Pracownik.Stawka;
                    }


                    suma += suma1;
                }
                label3.Text = "Suma łącznego wynagrodzenia wynosi: " + suma.ToString() + " zł";
                label4.Text = "Wartość obniżonego wynagrodzenia wynosi: " + kara.ToString() + "zł";
                label5.Text = "Wartość nadgodzinnego wynagrodzenia wynosi: " + nadgodz.ToString() + "zł";
            }
        }
        


        public rozliczaj()
        {
            
            
          
            InitializeComponent();
            foreach (Pracownik p in Pracownik.Pracownicy)
                comboBox1.Items.Add(p);






        }
       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            obliczenia((Pracownik)comboBox1.SelectedItem);
        }
    }
}
