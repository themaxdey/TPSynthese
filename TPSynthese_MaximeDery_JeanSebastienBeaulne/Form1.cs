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

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void sauvegarderLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6.PerformClick();
        }

        private void ouvrirLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOuvrir.PerformClick();
        }

        private void buttonOuvrir_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAjouter.PerformClick();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonModifier.PerformClick();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSupprimer.PerformClick();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonRechercher.PerformClick();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "Modifier un employé";
            buttonAjouterBD.Visible = false;
            buttonSupprimerBD.Visible = false;
            buttonUpdateBD.Visible = false;

            tabControl1.SelectedTab = tabPage2;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "Supprimer un employé";
            buttonAjouterBD.Visible = false;
            buttonSupprimerBD.Visible = true;
            buttonUpdateBD.Visible = false;

            tabControl1.SelectedTab = tabPage2;
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "Rechercher un employé";
            buttonAjouterBD.Visible = false;
            buttonSupprimerBD.Visible = false;
            buttonUpdateBD.Visible = false;

            tabControl1.SelectedTab = tabPage2;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "Ajouter un employé";
            buttonAjouterBD.Visible = true;
            buttonSupprimerBD.Visible = false;
            buttonUpdateBD.Visible = false;

            tabControl1.SelectedTab = tabPage2;
        }

        private void TabControl_Click(object sender, EventArgs e)
        {
            
            if( tabControl1.SelectedTab == tabPage1)
            {
                labelTitre.Text = "Visualisation de la base de données";
            }
        }
    }
}
