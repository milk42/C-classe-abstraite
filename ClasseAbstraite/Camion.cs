using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite
{
    public class Camion : Vehicule
    {
        public override void Accelerer()
        {
            Console.WriteLine("Je suis un camion et j'accelère doucement");
        }

        public override void Demarrer()
        {
            Console.WriteLine("Je suis un camion et je démarre doucement");
        }
    }
}
