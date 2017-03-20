using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgence_N_3_Formation_Néo_Solution
{
    public class Hero
    {
        // Attributs
        public string Nom { get; set; }
        public string Pouvoir { get; set; }

        // Constructeur
        public Hero(string n, string p)
        {
            Nom = n;
            Pouvoir = p;
        }

        // Méthode de présentation du Héro
        public void Presentation()
        {
            Console.WriteLine("Je suis " + Nom + " et mon pouvoir est " + Pouvoir);
        }
    }
}
