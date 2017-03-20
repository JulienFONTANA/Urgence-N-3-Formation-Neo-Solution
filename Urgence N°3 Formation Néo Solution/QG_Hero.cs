using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgence_N_3_Formation_Néo_Solution
{
    public class QG_Hero
    {
        // Liste de héros (collection)
        public List<Hero> heros { get; set; }

        // Constructeur et initialisation de la liste
        public QG_Hero()
        {
            heros = new List<Hero>();
        }

        // Retour du nombre de héros
        public int CompteHéro()
        {
            return heros.Count;
        }

        // Méthode de présentation de tout les héros!
        public void PresentationHeros()
        {
            foreach (var hero in heros)
            {
                hero.Presentation();
            }
        }
    }
}
