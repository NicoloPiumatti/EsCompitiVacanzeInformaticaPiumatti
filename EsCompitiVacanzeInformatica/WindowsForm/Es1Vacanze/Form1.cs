using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es1Vacanze
{
    public partial class Form1 : Form
    {
        List<contatti> cont = new List<contatti>();

        public Form1()
        {
            InitializeComponent();
        }

        private void caricaDati()
        {
            cont.Clear();
            StreamReader sr = new StreamReader("contatti.txt");
            string[] spl;
            string line;
            int i = 1;
            while ((line = sr.ReadLine()) != null)
            {
                contatti c = new contatti();
                spl = line.Split(';');
                c.nome = spl[0];
                c.numTelefono = spl[1];
                cont.Add(c);
            }
            sr.Close();
        }
        private void visualizzaRubricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caricaDati();
            int min;
            for (int i = 0; i <= cont.Count - 2; i++)
            {
                min = i;
                for (int j = i + 1; j <= cont.Count - 1; j++)
                {
                    if (cont[min].nome.CompareTo(cont[j].nome) > 0)
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    contatti temp = cont[i];
                    cont[i] = cont[min];
                    cont[min] = temp;
                }
            }
            int contatore = 1;
            foreach (contatti c in cont)
            {
                MessageBox.Show("Contatto numero " + contatore + ". Nome: " + c.nome + " / Num Telefono: " + c.numTelefono);
                contatore++;
            }
        }

        private void visualizzaNominativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caricaDati();
            int i = 1;
            foreach(contatti con in cont)
            {
                MessageBox.Show("Contatto numero " + i + ". Nome: " + con.nome);
                i++;
            }
        }

        private void modificaDatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caricaDati();
            if (txtNominativo.Text == "" || txtNuovo.Text == "")
            {
                MessageBox.Show("Riempi entrambi i campi di testo!");
                return;
            }
            bool trovato = false;
            foreach (contatti c in cont)
            {
                if (c.nome == txtNominativo.Text)
                {
                    c.nome = txtNuovo.Text;
                    c.numTelefono = txtNumTelefono.Text;
                    trovato = true;
                }
            }
            if (trovato == false)
            {
                MessageBox.Show("Contatto non trovato.");
                return;
            }
            StreamWriter sw = new StreamWriter("contatti.txt", false);
            foreach (contatti c in cont)
            {
                sw.WriteLine(c.nome + ";" + c.numTelefono);
            }
            sw.Close();
            MessageBox.Show("File modificato con successo");
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuovoNominativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("contatti.txt", true);
            contatti conta = new contatti();
            conta.nome = txtNome.Text;
            conta.numTelefono = txtTelefono.Text;
            cont.Add(conta);
            sw.WriteLine(conta.nome + ";" + conta.numTelefono);
            sw.Close();
            MessageBox.Show("Inserimento completato!");
        }
    }
}
