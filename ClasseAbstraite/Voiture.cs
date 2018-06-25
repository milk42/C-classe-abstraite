using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite
{
    public class Voiture : Vehicule
    {
        public Voiture(string matricule, string annee, int prix) : base(matricule, annee, prix)
        {
        }

        public override void Accelerer()
        {
            Console.WriteLine("Je suis une voiture et j'accelère rapidement");
        }

        public override void Demarrer()
        {
            Console.WriteLine("Je suis une voiture et je démarre rapidement");
        }
    }
}
