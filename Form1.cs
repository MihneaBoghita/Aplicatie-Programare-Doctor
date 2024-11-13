using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Programare_Doctor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked && checkBox4.Checked && checkedListBox1.SelectedItem != null)
            { 
                StreamWriter s = new StreamWriter("Date.txt", true);
                s.WriteLine(" ");
                s.Write("Nume: ");
                s.WriteLine(textBox1.Text);
                s.Write("Prenume: ");
                s.WriteLine(textBox2.Text);

                if (radioButton1.Checked)
                    s.Write("Genul: Femeie");
                else
                    if (radioButton2.Checked)
                    s.Write("Genul: Barbat");

                s.WriteLine();

                s.Write("Data nasterii: ");
                s.WriteLine(dateTimePicker1.Value.ToString());

                s.Write("Adresa: ");
                s.WriteLine(textBox3.Text);

                s.Write("Simtome: ");
                s.WriteLine(checkedListBox1.SelectedItem.ToString());
                s.Write(" ");

                s.Close();

                string m = "Inregistrare cu succes! ";
                MessageBox.Show(m);
            }
            else
            {
                string messege = "Nu sunteti de acord cu procesarea datelor sau nu ati completat toate capurile. ";
                MessageBox.Show(messege);
            }
        }
    }
}
