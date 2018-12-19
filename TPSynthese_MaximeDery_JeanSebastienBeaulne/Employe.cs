using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPSynthese_MaximeDery_JeanSebastienBeaulne
{
    public class Employe
    {
        public int noEmploye { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public DateTime dateEmbauche { get; set; }
        public string posteEmploi { get; set; }
        public double salaire { get; set; }
        public double commission { get; set; }
        public string noTelephone { get; set; }
        public Boolean permanence { get; set; }
        public int statut { get; set; }
        public DateTime dateNaissance { get; set; }
        public string commentaire { get; set; }
        public string sexe { get; set; }
        public int noMagasin { get; set; }

        public Employe(int noEmploye, string prenom, string nom, DateTime dateEmbauche, string posteEmploi, double salaire, double commission, string noTel, Boolean permanence, 
                        int status, DateTime dateNaissance, string commentaire, string sexe, int noMagasin)
        {
            this.noEmploye = noEmploye;
            this.prenom = prenom;
            this.nom = nom;
            this.dateEmbauche = dateEmbauche;
            this.posteEmploi = posteEmploi;
            this.salaire = salaire;
            this.commission = commission;
            this.noTelephone = noTel;
            this.permanence = permanence;
            this.statut = statut;
            this.dateNaissance = dateNaissance;
            this.commentaire = commentaire;
            this.sexe = sexe;
            this.noMagasin = noMagasin;
        }

        public override string ToString()
        {

            return prenom + nom;
        }
    }
}
