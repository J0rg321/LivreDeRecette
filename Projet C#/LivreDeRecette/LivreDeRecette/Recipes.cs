using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivreDeRecette
{

    public class Recipes
    {
        public int id { get; set; }
        public string recipeName { get; set; }
        public bool vegetarian { get; set; }
        public string preparationTime { get; set; }
        public string recipeType { get; set; }
        public string lvl { get; set; }

        public static List<Recipes> GetAll()
        {
            List<Recipes> recipes = new List<Recipes>();

            string query = "select * from recipes";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Recipes _recipe = new Recipes();
                _recipe.id = (int)reader["id"];
                _recipe.recipeName = (string)reader["recipeName"];
                _recipe.vegetarian = (bool)reader["vegetarian"];
                _recipe.preparationTime = (string)reader["preparationTime"];
                _recipe.recipeType = (string)reader["recipeType"];
                _recipe.lvl = (string)reader["lvl"];

                recipes.Add(_recipe);
            }
            return recipes;
        }
    }
}
