﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstraite
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion camion1 = new Camion("matricule1","2017", 25679);
            Voiture voiture1 = new Voiture("matricule2", "2016", 15679);
        }
    }
}
