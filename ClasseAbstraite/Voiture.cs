using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite
{
    public class Voiture : Vehicule
    {
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
