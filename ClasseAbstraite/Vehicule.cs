using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite
{
    public abstract class Vehicule
    {
        private string matricule { get; set; }
        private int annee { get; set; }
        private int prix { get; set; }

        public abstract void Demarrer();
        public abstract void Accelerer();

        public override string ToString()
        {
            return " Définition de ce véhicule : Matricule =  " + matricule + "; Année du modèle = " + annee + "; Prix = " + prix ;
        }
    }
}
