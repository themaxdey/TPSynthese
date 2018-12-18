using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSynthese_MaximeDery_JeanSebastienBeaulne
{
    public partial class Form1 : Form
    {
        public Magasin[] tabMagasins;

        public Form1()
        {
            InitializeComponent();

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelTitre.Text = "Visualisation de la base de données";
        }
    }
}
