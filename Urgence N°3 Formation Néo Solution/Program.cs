using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgence_N_3_Formation_Néo_Solution
{
    class Program
    {
        /* Il est temps de reconstruire le QG des héros!
         * Il faut faire vite pour contre attaquer!
         * 
         * Utiliser les collections pour créer une classe QG_Hero qui contient
         * une liste de héro (appelés 'heros'), et qui implémente la fonction 
         * CompteHéro() qui retourne le nombre de héro présent dans le QG.
         * 
         * Pour cet exercice, une classe "Héro" simplifiée vous est fourni dans un fichier à part.
         * Par contre, interdit de toucher au Main! ;)
         * 
         * 1°) Créer la classe QG_Hero sans un fichier à part (QG_Hero.cs par exemple)
         * 2°) Ajouter une collection de héro. Initialisez la dans le constructeur de la classe
         * 3°) Ajouter CompteHéro()
         * 4°) Vérifier que votre code fonctionne en compilant et executant le code.
         * 5°) Ajouter une fonction PresentationHeros() dans le QG qui parcours la liste des
         *     héros et leur fait appeler la fonction Presentation()
         * 
         * GOD SPEED!
        */

        static void Main(string[] args)
        {
            Hero h0 = new Hero("Batman", "la super classe !");
            h0.Presentation();

            Hero h1 = new Hero("SuperMan", "la super force !");
            Hero h2 = new Hero("Flash", "la super vitesse !");
            Hero h3 = new Hero("AquaMan", "le contole de la vie aquatique !");
            Hero h4 = new Hero("WonderWoman", "la super intelligence !");
            Hero h5 = new Hero("MartianHunter", "la capacité à voler !");

            QG_Hero QG = new QG_Hero();

            Console.WriteLine("Il y a " + QG.CompteHéro() + " héro(s) dans le QG!");

            QG.heros.Add(h1);
            QG.heros.Add(h2);
            Console.WriteLine("Il y a " + QG.CompteHéro() + " héro(s) dans le QG!");

            QG.heros.Add(h3);
            QG.heros.Add(h4);
            QG.heros.Add(h5);
            Console.WriteLine("Il y a " + QG.CompteHéro() + " héro(s) dans le QG!");

            QG.PresentationHeros();
        }
    }
}
