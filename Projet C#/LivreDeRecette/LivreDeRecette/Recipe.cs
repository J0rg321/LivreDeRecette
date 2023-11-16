using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivreDeRecette
{
    public class Recipe
    {

        public int choiceOne = 1;
        public int choiceTwo = 2;

        //constructor

        public Recipe(int choiceOne, int choiceTwo)
        {

            this.choiceOne = choiceOne;
            this.choiceTwo = choiceTwo;

        }
        //methods
        public void Welcome()
        {
            Console.WriteLine("Bonjour bienvenu(e) dans le livre de recettes");

        }
        public void Choice()
        {
            Console.WriteLine("Que souhaitez-vous faire aujourd'hui ? :\n Chercher (1) ou créer une recette (2) ?");

        }
        public void LookingFor()
        {
            Console.WriteLine("absolument rien pour l'instant"); //TODO ➡ chercher une recette parmis la base de données

        }
        public void Create()
        {

            Console.WriteLine("absolument rien pour l'instant"); //TODO ➡ créer une recette qui sera accessible depuis la base données

        }
        /*
         * 1// méthode pour chercher une recette
         * 
         * 2// méthode pour créér une recette
         * 
         * 3// méthode pour supprimer une recette
         * 
         * 4// créer un mode cuisson ➡ une fois la recette choisie, les étapes 
         * s'affichent une par une à l'aide d'un bouton etc...
         * 
         */
    }
}
