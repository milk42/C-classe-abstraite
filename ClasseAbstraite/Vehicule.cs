using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite
{
    public abstract class Vehicule
    {
        public string Matricule { get; set; }
        public string Annee { get; set; }
        public int Prix { get; set; }

        public Vehicule(string matricule, string annee, int prix)
        {
            Matricule = matricule;
            Annee = annee;
            Prix = prix;
        }

        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return " Définition de ce véhicule : Matricule =  " + Matricule + "; Année du modèle = " + Annee + "; Prix = " + Prix ;
        }
    }
}
