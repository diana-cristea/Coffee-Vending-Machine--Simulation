using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace simulator
{
    public partial class Form1 : Form
    {
    

        public bool cafea_instant = false;
        public bool cafea_macinata = false;
        public bool pahar_mediu = false;
        public bool pahar_mare = false;


        public Form1()
        {
            InitializeComponent();
        }


        public void adauga_evenimente()
        {
            comboBox1.Items.Add("apasare buton dorit");
            comboBox1.Items.Add("introducere tastă pentru revenire");
            comboBox1.Items.Add("cantarirea monedelor");
            comboBox1.Items.Add("validarea acțiunii de către automat");
            comboBox1.Items.Add("introducere tastă pentru confirmare");
            comboBox1.Items.Add("alegerea metodei de plata cash");
            comboBox1.Items.Add("alegerea platii cu cardul");
            comboBox1.Items.Add("respingerea acțiunii");
            comboBox1.Items.Add("introducere bani");
            comboBox1.Items.Add("verificare invalida");
            comboBox1.Items.Add("validarea platii cash");
            comboBox1.Items.Add("validarea platii cu cardul");
            comboBox1.Items.Add("selectarea cantitatii de zahar");
            comboBox1.Items.Add("incalzire apa");
            comboBox1.Items.Add("eliberare pahar");
            comboBox1.Items.Add("eliberare zahar si paleta");
            comboBox1.Items.Add("macinare cafea");
            comboBox1.Items.Add("eliberare cafea macinata");
            comboBox1.Items.Add("eliberare cafea instant");
            comboBox1.Items.Add("eliberare apa");
            comboBox1.Items.Add("eliberare cafea preparata");
            comboBox1.Items.Add("finalizare produs");
            comboBox1.Items.Add("eliberare lapte praf");
            comboBox1.Items.Add("preparare spuma");
            comboBox1.Items.Add("eliberare spuma");
            comboBox1.Items.Add("returnare bani in cazul erorii");
            comboBox1.Items.Add("eroare la eliberarea amestecului");
            comboBox1.Items.Add("eliberare rest");
            comboBox1.Items.Add("afisare mesaj sfarsit tranzactie");

        }

        public void adauga_sortimente_cafea()
        {
            comboBox2.Items.Add("Expresso scurt");
            comboBox2.Items.Add("Expresso lung");
            comboBox2.Items.Add("Caffe latte");
            comboBox2.Items.Add("Latte Machiatto");
            comboBox2.Items.Add("Cappucino");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adauga_evenimente();
            adauga_sortimente_cafea();
            progressBar1.Maximum = 5;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 100;
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 20000;
            trackBar2.TickStyle = TickStyle.BottomRight;
            trackBar2.TickFrequency = 100;
            trackBar2.Value = 20000;
            trackBar3.Minimum = 0;
            trackBar3.Maximum = 3000;
            trackBar3.TickStyle = TickStyle.BottomRight;
            trackBar3.TickFrequency = 20;
            trackBar3.Value = 3000;
            trackBar4.Minimum = 0;
            trackBar4.Maximum = 3000;
            trackBar4.TickStyle = TickStyle.BottomRight;
            trackBar4.TickFrequency = 20;
            trackBar4.Value = 3000;
            trackBar5.Minimum = 0;
            trackBar5.Maximum = 3000;
            trackBar5.TickStyle = TickStyle.BottomRight;
            trackBar5.TickFrequency = 20;
            trackBar5.Value = 3000;
            trackBar6.Minimum = 0;
            trackBar6.Maximum = 700;
            trackBar6.TickStyle = TickStyle.BottomRight;
            trackBar6.TickFrequency = 50;
            trackBar6.Value = 700;
            trackBar7.Minimum = 0;
            trackBar7.Maximum = 900;
            trackBar7.TickStyle = TickStyle.BottomRight;
            trackBar7.TickFrequency = 50;
            trackBar7.Value = 900;
            trackBar8.Minimum = 0;
            trackBar8.Maximum = 2000;
            trackBar8.TickStyle = TickStyle.BottomRight;
            trackBar8.TickFrequency = 10;
            trackBar8.Value = 2000;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.Text = ("Buna ziua!\n Va rugam selectati tipul de pahar!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == ("apasare buton dorit")) {
                MessageBox.Show("q0 -> q1");
                textBox1.Clear();
                textBox1.Text = ("q1");
                    }
            if (comboBox1.SelectedItem == ("introducere tastă pentru revenire"))
            {
                MessageBox.Show("q1 -> q0");
                textBox1.Clear();
                textBox1.Text = ("q0");
            }
            if (comboBox1.SelectedItem == ("cantarirea monedelor"))
            {
                MessageBox.Show("q1 -> q2");
                textBox1.Clear();
                textBox1.Text = ("q2");
            }
            if (comboBox1.SelectedItem == ("validarea acțiunii de către automat"))
            {
                MessageBox.Show("q5 -> q7");
                textBox1.Clear();
                textBox1.Text = ("q7");
            }
            if (comboBox1.SelectedItem == ("introducere tastă pentru confirmare"))
            {
                MessageBox.Show("q2 -> q3");
                textBox1.Clear();
                textBox1.Text = ("q3");
            }
            if (comboBox1.SelectedItem == ("alegerea platii cu cardul"))
            {
                MessageBox.Show("q3 -> q8");
                textBox1.Clear();
                textBox1.Text = ("q8");
            }
            if (comboBox1.SelectedItem == ("alegerea metodei de plata cash"))
            {
                MessageBox.Show("q3 -> q4");
                textBox1.Clear();
                textBox1.Text = ("q4");
            }
            if (comboBox1.SelectedItem == ("respingerea acțiunii"))
            {
                if (textBox1.Text == ("q6"))
                {
                    MessageBox.Show("q6 -> q5");
                    textBox1.Clear();
                    textBox1.Text = ("q5");
                }
                else 
                {
                   
                        MessageBox.Show("q8 -> q3");
                        textBox1.Clear();
                        textBox1.Text = ("q3");
                  
                }
            }
            if (comboBox1.SelectedItem == ("verificare invalida"))
            {
                MessageBox.Show("q5->q6");
                textBox1.Clear();
                textBox1.Text = ("q6");
            }
            if (comboBox1.SelectedItem == ("introducere bani"))
            {
                MessageBox.Show("q4 -> q5 Prima introducere\n" +
                   "q7 -> q5 Se introduc bani pana suma este suficienta");
                textBox1.Clear();
                textBox1.Text = ("q5");
            }
            if (comboBox1.SelectedItem == ("validarea platii cash"))
            {
                MessageBox.Show("q7 -> q9");
                textBox1.Clear();
                textBox1.Text = ("q9");
            }
            if (comboBox1.SelectedItem == ("validarea platii cu cardul"))
            {
                MessageBox.Show("q8 -> q9");
                textBox1.Clear();
                textBox1.Text = ("q9");
            }
            if (comboBox1.SelectedItem == ("selectarea cantitatii de zahar"))
            {
                MessageBox.Show("q9 -> q10");
                textBox1.Clear();
                textBox1.Text = ("q10");
            }
            if (comboBox1.SelectedItem == ("incalzire apa"))
            {
                MessageBox.Show("q10 -> q11");
                textBox1.Clear();
                textBox1.Text = ("q11");
            }
            if (comboBox1.SelectedItem == ("eliberare pahar"))
            {
                MessageBox.Show("q11 -> q12");
                textBox1.Clear();
                textBox1.Text = ("q12");
            }
            if (comboBox1.SelectedItem == ("eliberare zahar si paleta"))
            {
                MessageBox.Show("q12 -> q13");
                textBox1.Clear();
                textBox1.Text = ("q13");
            }
            if (comboBox1.SelectedItem == ("macinare cafea"))
            {
                MessageBox.Show("q13 -> q14");
                textBox1.Clear();
                textBox1.Text = ("q14");
            }
            if (comboBox1.SelectedItem == ("eliberare cafea macinata"))
            {
                MessageBox.Show("q14 -> q15");
                textBox1.Clear();
                textBox1.Text = ("q15");
            }
            if (comboBox1.SelectedItem == ("eliberare cafea instant"))
            {
                MessageBox.Show("q13 -> q15");
                textBox1.Clear();
                textBox1.Text = ("q15");
            }
            if (comboBox1.SelectedItem == ("eliberare apa"))
                if (comboBox2.SelectedItem == ("Cappucino") | comboBox2.SelectedItem == ("Latte Machiatto") | comboBox2.SelectedItem == ("Caffe latte"))
                {
                    if (textBox1.Text == ("q15"))
                    {
                        MessageBox.Show("q15 -> q16");
                        textBox1.Clear();
                        textBox1.Text = ("q16");
                    }
                    else
                    {
                        MessageBox.Show("q18 -> q19");
                        textBox1.Clear();
                        textBox1.Text = ("q19");
                    }

                }
                else
                {
                    MessageBox.Show("q15 -> q16");
                    textBox1.Clear();
                    textBox1.Text = ("q16");
                }
            if (comboBox1.SelectedItem == ("eliberare cafea preparata"))
            {
                MessageBox.Show("q16 -> q17");
                textBox1.Clear();
                textBox1.Text = ("q17");
            }
            if (comboBox1.SelectedItem == ("finalizare produs"))
                if (comboBox2.SelectedItem == ("Cappucino") | comboBox2.SelectedItem == ("Latte Machiatto") | comboBox2.SelectedItem == ("Caffe latte"))
                {
                    MessageBox.Show("q21 ->q23 Daca produsul contine lapte");
                    textBox1.Clear();
                    textBox1.Text = ("q23");
                }
                else { MessageBox.Show("q17 -> q23 Daca produsul nu contine lapte");
                    textBox1.Clear();
                    textBox1.Text = ("q23"); 
                }
            if (comboBox1.SelectedItem == ("eliberare lapte praf"))
                    {
                        MessageBox.Show("q17 -> q18");
                        textBox1.Clear();
                        textBox1.Text = ("q18");
                    }
            if (comboBox1.SelectedItem == ("preparare spuma"))
            {
                MessageBox.Show("q19 -> q20");
                textBox1.Clear();
                textBox1.Text = ("q20");
            }
            if (comboBox1.SelectedItem == ("eliberare spuma"))
            {
                MessageBox.Show("q20 -> q21");
                textBox1.Clear();
                textBox1.Text = ("q21");
            }
            if (comboBox1.SelectedItem == ("returnare bani in cazul erorii"))
            {
                MessageBox.Show("q22 -> q24");
                textBox1.Clear();
                textBox1.Text = ("q24");
            }
            if (comboBox1.SelectedItem == ("eroare la eliberarea amestecului"))
            {
                MessageBox.Show("q21 -> q22");
                textBox1.Clear();
                textBox1.Text = ("q22");
            }
            if (comboBox1.SelectedItem == ("eliberare rest"))
            {
                MessageBox.Show("q23 -> q24");
                textBox1.Clear();
                textBox1.Text = ("q24");
            }
            if (comboBox1.SelectedItem == ("afisare mesaj sfarsit tranzactie"))
            {
                MessageBox.Show("q24 -> q0 Intoarcere in starea initiala");
                textBox1.Clear();
                textBox1.Text = ("q0");
            }


            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Expresso scurt" | comboBox2.SelectedItem == "Expresso lung")
            {
                if (radioButton2.Checked == true)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("apasare buton dorit");
                    comboBox1.Items.Add("introducere tastă pentru revenire");
                    comboBox1.Items.Add("cantarirea monedelor");
                    comboBox1.Items.Add("validarea acțiunii de către automat");
                    comboBox1.Items.Add("verificare invalida");
                    comboBox1.Items.Add("introducere tastă pentru confirmare");
                    comboBox1.Items.Add("alegerea metodei de plata cash");
                    comboBox1.Items.Add("alegerea platii cu cardul");
                    comboBox1.Items.Add("respingerea acțiunii");
                    comboBox1.Items.Add("introducere bani");
                    comboBox1.Items.Add("validarea platii cash");
                    comboBox1.Items.Add("validarea platii cu cardul");
                    comboBox1.Items.Add("selectarea cantitatii de zahar");
                    comboBox1.Items.Add("incalzire apa");
                    comboBox1.Items.Add("eliberare pahar");
                    comboBox1.Items.Add("eliberare zahar si paleta");
                    comboBox1.Items.Add("eliberare cafea instant");
                    comboBox1.Items.Add("eliberare apa");
                    comboBox1.Items.Add("eliberare cafea preparata");
                    comboBox1.Items.Add("finalizare produs");
                    comboBox1.Items.Add("returnare bani in cazul erorii");
                    comboBox1.Items.Add("eroare la eliberarea amestecului");
                    comboBox1.Items.Add("eliberare rest");
                    comboBox1.Items.Add("afisare mesaj sfarsit tranzactie");

                }
                if(radioButton3.Checked==true)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("apasare buton dorit");
                    comboBox1.Items.Add("introducere tastă pentru revenire");
                    comboBox1.Items.Add("cantarirea monedelor");
                    comboBox1.Items.Add("validarea acțiunii de către automat");
                    comboBox1.Items.Add("verificare invalida");
                    comboBox1.Items.Add("introducere tastă pentru confirmare");
                    comboBox1.Items.Add("alegerea metodei de plata cash");
                    comboBox1.Items.Add("alegerea platii cu cardul");
                    comboBox1.Items.Add("respingerea acțiunii");
                    comboBox1.Items.Add("introducere bani");
                    comboBox1.Items.Add("validarea platii cash");
                    comboBox1.Items.Add("validarea platii cu cardul");
                    comboBox1.Items.Add("selectarea cantitatii de zahar");
                    comboBox1.Items.Add("incalzire apa");
                    comboBox1.Items.Add("eliberare pahar");
                    comboBox1.Items.Add("eliberare zahar si paleta");
                    comboBox1.Items.Add("macinare cafea");
                    comboBox1.Items.Add("eliberare cafea macinata");
                    comboBox1.Items.Add("eliberare apa");
                    comboBox1.Items.Add("eliberare cafea preparata");
                    comboBox1.Items.Add("finalizare produs");
                    comboBox1.Items.Add("returnare bani in cazul erorii");
                    comboBox1.Items.Add("eroare la eliberarea amestecului");
                    comboBox1.Items.Add("eliberare rest");
                    comboBox1.Items.Add("afisare mesaj sfarsit tranzactie");
                }
            }
            if (comboBox2.SelectedItem == ("Cappucino") | comboBox2.SelectedItem == ("Latte Machiatto") | comboBox2.SelectedItem == ("Caffe latte"))
            {
                if (radioButton2.Checked == true)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("apasare buton dorit");
                    comboBox1.Items.Add("introducere tastă pentru revenire");
                    comboBox1.Items.Add("cantarirea monedelor");
                    comboBox1.Items.Add("validarea acțiunii de către automat");
                    comboBox1.Items.Add("verificare invalida");
                    comboBox1.Items.Add("introducere tastă pentru confirmare");
                    comboBox1.Items.Add("alegerea metodei de plata cash");
                    comboBox1.Items.Add("alegerea platii cu cardul");
                    comboBox1.Items.Add("respingerea acțiunii");
                    comboBox1.Items.Add("introducere bani");
                    comboBox1.Items.Add("validarea platii cash");
                    comboBox1.Items.Add("validarea platii cu cardul");
                    comboBox1.Items.Add("selectarea cantitatii de zahar");
                    comboBox1.Items.Add("incalzire apa");
                    comboBox1.Items.Add("eliberare pahar");
                    comboBox1.Items.Add("eliberare zahar si paleta");
                    comboBox1.Items.Add("eliberare cafea instant");
                    comboBox1.Items.Add("eliberare apa");
                    comboBox1.Items.Add("eliberare cafea preparata");
                    comboBox1.Items.Add("finalizare produs");
                    comboBox1.Items.Add("eliberare lapte praf");
                    comboBox1.Items.Add("preparare spuma");
                    comboBox1.Items.Add("eliberare spuma");
                    comboBox1.Items.Add("returnare bani in cazul erorii");
                    comboBox1.Items.Add("eroare la eliberarea amestecului");
                    comboBox1.Items.Add("eliberare rest");
                    comboBox1.Items.Add("afisare mesaj sfarsit tranzactie");
                }
                if (radioButton3.Checked == true)
                {
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("apasare buton dorit");
                    comboBox1.Items.Add("introducere tastă pentru revenire");
                    comboBox1.Items.Add("cantarirea monedelor");
                    comboBox1.Items.Add("validarea acțiunii de către automat");
                    comboBox1.Items.Add("verificare invalida");
                    comboBox1.Items.Add("introducere tastă pentru confirmare");
                    comboBox1.Items.Add("alegerea metodei de plata cash");
                    comboBox1.Items.Add("alegerea platii cu cardul");
                    comboBox1.Items.Add("respingerea acțiunii");
                    comboBox1.Items.Add("introducere bani");
                    comboBox1.Items.Add("validarea platii cash");
                    comboBox1.Items.Add("validarea platii cu cardul");
                    comboBox1.Items.Add("selectarea cantitatii de zahar");
                    comboBox1.Items.Add("incalzire apa");
                    comboBox1.Items.Add("eliberare pahar");
                    comboBox1.Items.Add("eliberare zahar si paleta");
                    comboBox1.Items.Add("macinare cafea");
                    comboBox1.Items.Add("eliberare cafea macinata");
                    comboBox1.Items.Add("eliberare apa");
                    comboBox1.Items.Add("eliberare cafea preparata");
                    comboBox1.Items.Add("finalizare produs");
                    comboBox1.Items.Add("eliberare lapte praf");
                    comboBox1.Items.Add("preparare spuma");
                    comboBox1.Items.Add("eliberare spuma");
                    comboBox1.Items.Add("returnare bani in cazul erorii");
                    comboBox1.Items.Add("eroare la eliberarea amestecului");
                    comboBox1.Items.Add("eliberare rest");
                    comboBox1.Items.Add("afisare mesaj sfarsit tranzactie");
                }


            }

            richTextBox1.Text = ("Va rugam introduceti o suma de bani cel putin egala cu valoarea produsului!");

        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (cafea_macinata)
            {
                radioButton3.Checked = false;
                cafea_macinata = false;
            }
            cafea_instant = true;
            comboBox1.Items.Remove("macinare cafea");
            comboBox1.Items.Remove("eliberare cafea macinata");
            richTextBox1.Text = ("Va rugam selectati bautura dorita!");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(cafea_instant)
            {
                radioButton2.Checked = false;
                cafea_instant = false;
            }
            cafea_macinata = true;
            comboBox1.Items.Remove("eliberare cafea instant");
            richTextBox1.Text = ("Va rugam selectati bautura dorita!");
        }


        public void check_state()
        {
            
        }


        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }
        private void label22_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString(); 
            if( trackBar1.Value < 80)
            {
                MessageBox.Show("Apa nu a atins temperatura necesara");
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                progressBar1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                trackBar1.Enabled = false;
                trackBar2.Enabled = false;
                trackBar3.Enabled = false;
                trackBar4.Enabled = false;
                trackBar5.Enabled = false;
                trackBar6.Enabled = false;
                trackBar7.Enabled = false;
                trackBar8.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label9.Text = trackBar2.Value.ToString();
            if(trackBar2.Value < 240)
            {
                MessageBox.Show("Nu exista suficienta apa in bazin!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label11.Text = trackBar3.Value.ToString();
            if (trackBar3.Value < 30)
            {
                MessageBox.Show("Nu exista suficient lapte praf pentru preparare!");
                richTextBox1.Text = ("Sunt disponibile doar bauturi fara lapte");
                comboBox2.Items.Remove("Latte Machiatto");
                comboBox2.Items.Remove("Caffe latte");
                comboBox2.Items.Remove("Cappucino");
            }
        }
       

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label13.Text = trackBar4.Value.ToString();
            if (trackBar4.Value < 30)
            {
                MessageBox.Show("Nu exista suficienta cafea macinata pentru preparare!");
                radioButton3.Enabled = false;
                richTextBox1.Text = ("Sunt disponibile doar bauturile pe baza de cafea instant");
            }
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label15.Text = trackBar5.Value.ToString();
            if (trackBar5.Value < 30)
            {
                MessageBox.Show("Nu exista suficienta cafea instant pentru preparare!");
                radioButton2.Enabled = false;
                richTextBox1.Text = ("Sunt disponibile doar bauturile pe baza de cafea boabe");
            }
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label17.Text = trackBar6.Value.ToString();
            if (trackBar6.Value == 0 )
            {
                MessageBox.Show("Nu mai sunt pahare!");
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                progressBar1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                trackBar1.Enabled = false;
                trackBar2.Enabled = false;
                trackBar3.Enabled = false;
                trackBar4.Enabled = false;
                trackBar5.Enabled = false;
                trackBar6.Enabled = false;
                trackBar7.Enabled = false;
                trackBar8.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label19.Text = trackBar7.Value.ToString();
            if ((float.Parse(textBox4.Text) / 0.5) * 3 > trackBar7.Value ) MessageBox.Show("Nu se poate da rest!");

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (pahar_mediu)
            {
                pahar_mediu = false;
                checkBox1.Checked = false;
            }
            pahar_mare = true;
            if (checkBox2.Checked == true)
                textBox2.Text = (3).ToString();
            richTextBox1.Text = ("Va rugam alegeti tipul de cafea dorit!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pahar_mare)
            {
                pahar_mare = false;
                checkBox2.Checked = false;

            }
            pahar_mediu = true;

            if (checkBox1.Checked == true)
                textBox2.Text = (2).ToString();
            richTextBox1.Text = ("Va rugam alegeti tipul de cafea dorit!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0) progressBar1.Value--;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value<5) progressBar1.Value++;
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            label21.Text = trackBar8.Value.ToString();
            if (trackBar8.Value < 20)
            {
                MessageBox.Show("Nu mai este zahar");
                button1.Enabled = false;
                button2.Enabled = false;
                progressBar1.Enabled = false;
                button4.Enabled = false;
                richTextBox1.Text = ("Nu mai este zahar disponibil");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(textBox3.Text) - float.Parse(textBox2.Text) < 0)
                {
                    textBox4.Text = (0).ToString();
                    MessageBox.Show("Nu ati introdus suficienti bani!");

                }
                else
                {
                    textBox4.Text = (float.Parse(textBox3.Text) - float.Parse(textBox2.Text)).ToString();
                    richTextBox1.Text = ("Va rugam selectati cantitatea de zahar!");
                }

                    if (float.Parse(textBox3.Text) > 5)
                {
                    textBox4.Text = (0).ToString();
                    MessageBox.Show("Aparatul nu accepta bancnote mai mari de 5 lei");
                }
                
            }
            catch
            {

            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
            string[] s1 = new string[] { "apasare buton dorit","introducere tastă pentru revenire","cantarirea monedelor","validarea acțiunii de către automat",
                         "verificare invalida", "introducere tastă pentru confirmare", "alegerea metodei de plata cash", "alegerea platii cu cardul", "respingerea acțiunii",
                        "introducere bani", "validarea platii cash", "validarea platii cu cardul", "selectarea cantitatii de zahar", "incalzire apa", "eliberare pahar",
                        "eliberare zahar si paleta", "eliberare cafea instant", "eliberare apa", "eliberare cafea preparata", "finalizare produs", "returnare bani in cazul erorii",
                        "eroare la eliberarea amestecului", "eliberare rest", "afisare mesaj sfarsit tranzactie" };

            string[] s2 = new string[] { "apasare buton dorit","introducere tastă pentru revenire","cantarirea monedelor","validarea acțiunii de către automat",
                         "verificare invalida", "introducere tastă pentru confirmare", "alegerea metodei de plata cash", "alegerea platii cu cardul", "respingerea acțiunii",
                        "introducere bani", "validarea platii cash", "validarea platii cu cardul", "selectarea cantitatii de zahar", "incalzire apa", "eliberare pahar",
                        "eliberare zahar si paleta","macinare cafea", "eliberare cafea macinata", "eliberare apa", "eliberare cafea preparata", "finalizare produs", "returnare bani in cazul erorii",
                        "eroare la eliberarea amestecului", "eliberare rest", "afisare mesaj sfarsit tranzactie" };

            string[] s3 = new string[] { "apasare buton dorit","introducere tastă pentru revenire","cantarirea monedelor","validarea acțiunii de către automat",
                         "verificare invalida", "introducere tastă pentru confirmare", "alegerea metodei de plata cash", "alegerea platii cu cardul", "respingerea acțiunii",
                        "introducere bani", "validarea platii cash", "validarea platii cu cardul", "selectarea cantitatii de zahar", "incalzire apa", "eliberare pahar",
                        "eliberare zahar si paleta", "eliberare cafea instant", "eliberare apa", "eliberare cafea preparata", "finalizare produs", "eliberare lapte praf",
                        "preparare spuma", "eliberare spuma", "returnare bani in cazul erorii", "eroare la eliberarea amestecului", "eliberare rest", "afisare mesaj sfarsit tranzactie" };

            string[] s4 = new string[] { "apasare buton dorit","introducere tastă pentru revenire","cantarirea monedelor","validarea acțiunii de către automat",
                         "verificare invalida", "introducere tastă pentru confirmare", "alegerea metodei de plata cash", "alegerea platii cu cardul", "respingerea acțiunii",
                        "introducere bani", "validarea platii cash", "validarea platii cu cardul", "selectarea cantitatii de zahar", "incalzire apa", "eliberare pahar",
                        "eliberare zahar si paleta","macinare cafea", "eliberare cafea macinata", "eliberare apa", "eliberare cafea preparata", "finalizare produs","eliberare lapte praf",
                        "preparare spuma", "eliberare spuma", "returnare bani in cazul erorii", "eroare la eliberarea amestecului", "eliberare rest", "afisare mesaj sfarsit tranzactie" };


            if (comboBox2.SelectedItem == "Expresso scurt" | comboBox2.SelectedItem == "Expresso lung")
            {
                if (radioButton2.Checked == true)
                {
                    if (textBox1.Text == ("q1"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[1]);
                        comboBox1.Items.Add(s1[2]);


                    }

                    if (textBox1.Text == ("q2"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[5]);
                    }

                    if (textBox1.Text == ("q3"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[6]);
                        comboBox1.Items.Add(s1[7]);
                    }

                    if (textBox1.Text == ("q4"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[9]);
                    }

                    if (textBox1.Text == ("q5"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[3]);
                        comboBox1.Items.Add(s1[4]);
                    }

                    if (textBox1.Text == ("q6"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[8]);
                    }

                    if (textBox1.Text == ("q7"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[9]);
                        comboBox1.Items.Add(s1[10]);
                    }

                    if (textBox1.Text == ("q8"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[8]);
                        comboBox1.Items.Add(s1[11]);
                    }

                    if (textBox1.Text == ("q9"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[12]);
                    }

                    if (textBox1.Text == ("q10"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[13]);
                    }

                    if(textBox1.Text == ("q11"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[14]);
                    }

                    if(textBox1.Text == ("q12"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[15]);
                    }

                    if(textBox1.Text == ("q13"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[16]);
                    }

                    if(textBox1.Text == ("q15"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[17]);
                    }

                    if (textBox1.Text == ("q16"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[18]);
                    }

                    if (textBox1.Text == ("q17"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[19]);
                        comboBox1.Items.Add(s1[21]);
                    }

                    if (textBox1.Text == ("q22"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[20]);
                    }

                    if (textBox1.Text == ("q23"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[22]);
                    }

                    if (textBox1.Text == ("q24"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[23]);
                    }

                }
                if (radioButton3.Checked == true)
                {
                    if (textBox1.Text == ("q1"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[1]);
                        comboBox1.Items.Add(s2[2]);


                    }

                    if (textBox1.Text == ("q2"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[5]);
                    }

                    if (textBox1.Text == ("q3"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[6]);
                        comboBox1.Items.Add(s2[7]);
                    }

                    if (textBox1.Text == ("q4"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[9]);
                    }

                    if (textBox1.Text == ("q5"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[3]);
                        comboBox1.Items.Add(s2[4]);
                    }

                    if (textBox1.Text == ("q6"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[8]);
                    }

                    if (textBox1.Text == ("q7"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[9]);
                        comboBox1.Items.Add(s2[10]);
                    }

                    if (textBox1.Text == ("q8"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[8]);
                        comboBox1.Items.Add(s2[11]);
                    }

                    if (textBox1.Text == ("q9"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[12]);
                    }

                    if (textBox1.Text == ("q10"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[13]);
                    }

                    if (textBox1.Text == ("q11"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[14]);
                    }

                    if (textBox1.Text == ("q12"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[15]);
                    }

                    if (textBox1.Text == ("q13"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[16]);
                    }

                    if (textBox1.Text == ("q14"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[17]);
                    }

                    if (textBox1.Text == ("q15"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[18]);
                    }

                    if (textBox1.Text == ("q16"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[19]);
                    }

                    if (textBox1.Text == ("q17"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[20]);
                        comboBox1.Items.Add(s2[22]);
                    }

                    if (textBox1.Text == ("q22"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[21]);
                    }

                    if (textBox1.Text == ("q23"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[23]);
                    }

                    if (textBox1.Text == ("q24"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s2[24]);
                    }
                }
            }
            if (comboBox2.SelectedItem == ("Cappucino") | comboBox2.SelectedItem == ("Latte Machiatto") | comboBox2.SelectedItem == ("Caffe latte"))
            {
                if (radioButton2.Checked == true)
                {
                    if (textBox1.Text == ("q1"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[1]);
                        comboBox1.Items.Add(s3[2]);


                    }

                    if (textBox1.Text == ("q2"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[5]);
                    }

                    if (textBox1.Text == ("q3"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[6]);
                        comboBox1.Items.Add(s3[7]);
                    }

                    if (textBox1.Text == ("q4"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[9]);
                    }

                    if (textBox1.Text == ("q5"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s1[3]);
                        comboBox1.Items.Add(s3[4]);
                    }

                    if (textBox1.Text == ("q6"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[8]);
                    }

                    if (textBox1.Text == ("q7"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[9]);
                        comboBox1.Items.Add(s3[10]);
                    }

                    if (textBox1.Text == ("q8"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[8]);
                        comboBox1.Items.Add(s3[11]);
                    }

                    if (textBox1.Text == ("q9"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[12]);
                    }

                    if (textBox1.Text == ("q10"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[13]);
                    }

                    if (textBox1.Text == ("q11"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[14]);
                    }

                    if (textBox1.Text == ("q12"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[15]);
                    }

                    if (textBox1.Text == ("q13"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[16]);
                    }

                    if (textBox1.Text == ("q15"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[17]);
                    }

                    if (textBox1.Text == ("q16"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[18]);
                    }

                    if (textBox1.Text == ("q17"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[20]);
                        comboBox1.Items.Add(s3[24]);
                    }

                    if (textBox1.Text == ("q18"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[17]);
                    }

                    if (textBox1.Text == ("q19"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[21]);
                    }

                    if (textBox1.Text == ("q20"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[22]);
                    }

                    if (textBox1.Text == ("q21"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[19]);
                        comboBox1.Items.Add(s3[24]);
                    }

                    if (textBox1.Text == ("q22"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[23]);
                    }

                    if (textBox1.Text == ("q23"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[26]);
                    }

                    if (textBox1.Text == ("q24"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s3[26]);
                    }
                }
                if (radioButton3.Checked == true)
                {
                    if (textBox1.Text == ("q1"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[1]);
                        comboBox1.Items.Add(s4[2]);

                    }

                    if (textBox1.Text == ("q2"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[5]);
                    }

                    if (textBox1.Text == ("q3"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[6]);
                        comboBox1.Items.Add(s4[7]);
                    }

                    if (textBox1.Text == ("q4"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[9]);
                    }

                    if (textBox1.Text == ("q5"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[3]);
                        comboBox1.Items.Add(s4[4]);
                    }

                    if (textBox1.Text == ("q6"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[8]);
                    }

                    if (textBox1.Text == ("q7"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[9]);
                        comboBox1.Items.Add(s4[10]);
                    }

                    if (textBox1.Text == ("q8"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[8]);
                        comboBox1.Items.Add(s4[11]);
                    }

                    if (textBox1.Text == ("q9"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[12]);
                    }

                    if (textBox1.Text == ("q10"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[13]);
                    }

                    if (textBox1.Text == ("q11"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[14]);
                    }

                    if (textBox1.Text == ("q12"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[15]);
                    }

                    if (textBox1.Text == ("q13"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[16]);
                    }

                    if (textBox1.Text == ("q14"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[17]);
                    }

                    if (textBox1.Text == ("q15"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[18]);
                    }

                    if (textBox1.Text == ("q16"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[19]);
                    }

                    if (textBox1.Text == ("q17"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[21]);
                        comboBox1.Items.Add(s4[25]);
                    }

                    if (textBox1.Text == ("q18"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[18]);
                    }

                    if (textBox1.Text == ("q19"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[22]);
                    }

                    if (textBox1.Text == ("q20"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[23]);
                    }

                    if (textBox1.Text == ("q21"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[20]);
                        comboBox1.Items.Add(s4[25]);
                    }

                    if (textBox1.Text == ("q22"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[24]);
                    }

                    if (textBox1.Text == ("q23"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[26]);
                    }

                    if (textBox1.Text == ("q24"))
                    {
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add(s4[27]);
                    }
                }


            }
            if( textBox1.Text==("q23"))
                richTextBox1.Text = ("Va rugam ridicati paharul si restul daca este cazul!");
            if (textBox1.Text == ("q22"))
                richTextBox1.Text = ("A aparut o eroare la eliberare.Creditul va fi restituit.Ne cerem scuze pentru discofortul creat!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            
        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox2.Text = string.Empty;
            comboBox1.Items.Clear();
            adauga_evenimente();
            trackBar1.Value = 100;
            trackBar2.Value = 20000;
            trackBar3.Value = 3000;
            trackBar4.Value = 3000;
            trackBar5.Value = 3000;
            trackBar6.Value = 700;
            trackBar7.Value = 900;
            trackBar8.Value = 2000;
            label5.Text = "100";
            label9.Text = "20000";
            label11.Text = "3000";
            label13.Text = "3000";
            label15.Text = "3000";
            label17.Text = "700";
            label19.Text = "900";
            label21.Text = "2000";
            progressBar1.Value = 0;
            richTextBox1.Text = ("Buna ziua!\n Va rugam selectati tipul de pahar!");
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            progressBar1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;
            trackBar4.Enabled = true;
            trackBar5.Enabled = true;
            trackBar6.Enabled = true;
            trackBar7.Enabled = true;
            trackBar8.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            comboBox2.Items.Clear();
            adauga_sortimente_cafea();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ("Va rugam asteptati sa se prepare bautura!");
        }
    }
    }
