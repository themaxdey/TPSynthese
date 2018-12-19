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
        public string magasinSelectionne;
        public Magasin magasinCourant;
        public Employe[] tabEmployes;
        public Employe employeCourant;

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

        private void listBoxMagasin_SelectedIndexChanged(object sender, EventArgs e)
        {
            magasinSelectionne = listBoxMagasin.GetItemText(listBoxMagasin.SelectedItem);

            for (int i = 0; i < tabMagasins.Length; i++)
            {
                if(magasinSelectionne.Equals(tabMagasins[i].nomMagasin))
                {
                    magasinCourant = tabMagasins[i];
                }
            }

            for (int i = 0; i < tabEmployes.Length; i++)
            {
                if (tabEmployes[i].noMagasin == magasinCourant.noMagasin)
                {
                    listBoxEmploye.Items.Add(tabEmployes[i].ToString());
                }
            }
        }

        private void listBoxEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tabNom;
            string nomComplet;
            string nom;

            nomComplet = listBoxEmploye.GetItemText(listBoxEmploye.SelectedItem);

            tabNom = nomComplet.Split(null);

            nom = tabNom[1];

            for(int i = 0; i < tabEmployes.Length; i++)
            {
                if (tabEmployes[i].nom.Equals(nom)){
                    employeCourant = tabEmployes[i];
                }
            }

            buttonModifier.Enabled = true;
            buttonSupprimer.Enabled = true;
            buttonAjouter.Enabled = false;

            textBoxPrenom.Text = employeCourant.prenom;
            textBoxNumTel.Text = employeCourant.noTelephone;
            textBoxNom.Text = employeCourant.nom;
            labelNumeroEmploye.Text = employeCourant.noEmploye.ToString();

            switch (employeCourant.noMagasin)
            {
                case 1:
                    radioButtonStRoch.Checked = true;
                    break;
                case 2:
                    radioButtonHauteVille.Checked = true;
                    break;
                case 3:
                    radioButtonRosemont.Checked = true;
                    break;
                case 4:
                    radioButtonStCatherine.Checked = true;
                    break;
                case 5:
                    radioButtonStMartin.Checked = true;
                    break;
            }

            switch (employeCourant.sexe)
            {
                case "Masculin":
                    radioButtonSexeHomme.Checked = true;
                    break;
                case "Féminin":
                    radioButtonSexeFemme.Checked = true;
                    break;
            }

            switch (employeCourant.permanence)
            {
                case true:
                    radioButtonPermanenceOui.Checked = true;
                    break;
                case false:
                    radioButtonPermanenceNon.Checked = false;
                    break;
            }

            switch (employeCourant.posteEmploi)
            {
                case "Gérant":
                    radioButtonGerant.Checked = true;
                    break;
                case "Vendeur":
                    radioButtonVendeur.Checked = true;
                    break;
                case "Analyste":
                    radioButtonAnalyste.Checked = true;
                    break;
                case "Conseiller":
                    radioButtonConseiller.Checked = true;
                    break;
                case "Directeur":
                    radioButtonDirecteur.Checked = true;
                    break;

            }

            //Mettre les valeurs dans le date/time picker embauche et naissance

            
        }
    }
}
