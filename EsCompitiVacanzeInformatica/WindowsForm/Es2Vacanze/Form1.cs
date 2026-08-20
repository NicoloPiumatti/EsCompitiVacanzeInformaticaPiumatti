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

namespace Es2Vacanze
{
    public partial class Form1 : Form
    {
        List<caratteristiche> car = new List<caratteristiche>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            caricaLista(car, "Obj.txt");
            btnVisBtnPnl.Visible = true;
            pnlVisBtn.Visible = true;
        }

        private void caricaLista(List<caratteristiche> car, string file)
        {
            car.Clear();
            StreamReader sr = new StreamReader(file);
            string[] spl;
            string line;
            while((line = sr.ReadLine()) != null)
            {
                spl = line.Split('|', ';');
                caratteristiche caratteristiche = new caratteristiche();
                caratteristiche.nome = spl[0];
                caratteristiche.posX = int.Parse(spl[1]);
                caratteristiche.posY = int.Parse(spl[2]);
                caratteristiche.width = int.Parse(spl[3]);
                caratteristiche.height = int.Parse(spl[4]);
                caratteristiche.colore = spl[5];
                car.Add(caratteristiche);
            }
            sr.Close();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            pnlNuovoOgg.Visible = true;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            caratteristiche carat = new caratteristiche();
            carat.nome = txtNome.Text;
            carat.posX = Convert.ToInt32(nudX.Value);
            carat.posY = Convert.ToInt32(nudY.Value);
            carat.width = Convert.ToInt32(nudW.Value);
            carat.height = Convert.ToInt32(nudH.Value);
            carat.colore = txtColore.Text;
            car.Add(carat);
            StreamWriter sw = new StreamWriter("Obj.txt", true);
            sw.WriteLine(carat.nome + "|" + carat.posX + ";" + carat.posY + "|" + carat.width + ";" + carat.height + "|" + carat.colore);
            sw.Close();
            MessageBox.Show("caricamento lista e file completati!");
        }

        private void btnVisBtnPnl_Click(object sender, EventArgs e)
        {
            btnVisBtnPnl.Controls.Clear();
            StreamReader sr = new StreamReader("Obj.txt");
            foreach(caratteristiche c in car)
            {
                Button btn = new Button();
                btn.Name = c.nome;
                btn.Location = new Point(c.posX, c.posY);
                btn.Width = c.width;
                btn.Height = c.height;
                btn.BackColor = Color.FromName(c.colore);
                btn.Click += new EventHandler(btnDinamico_Click);
                btn.KeyPress += new KeyPressEventHandler(btnDinamico_KeyPress);
                pnlVisBtn.Controls.Add(btn);
            }
            sr.Close();
        }

        private void btnDinamico_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            Button btn = (Button)sender;
            btn.ForeColor = Color.Black;
            btn.Text = c.ToString();
            switch(c)
            {
                case 'C':
                    btn.Text = "";
                break;
                case 'R':
                    btn.ForeColor = Color.Red;
                break;
            }
        }

        private void btnDinamico_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
        }

        private void lblIndice_Click(object sender, EventArgs e)
        {
            foreach (caratteristiche c in car)
            {
                if ("btn" + txtIndice.Text == c.nome)
                {
                    lblIndice.ForeColor = Color.FromName(c.colore);
                    MessageBox.Show("Colore modificato!");
                    return;
                }
                else
                {
                    MessageBox.Show("Inserire un indice valido");
                }
            }
        }
    }
}
