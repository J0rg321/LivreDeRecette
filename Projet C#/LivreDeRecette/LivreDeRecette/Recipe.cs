using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;

namespace LivreDeRecette
{

    public class Recipe
    {
        public int recipeID { get; set; }
        public string recipeName { get; set; }
        public bool vegetarian { get; set; }
        public int preparationTime { get; set; }
        public string recipeType { get; set; }
        public string lvl { get; set; }
        public string ingredientName { get; set; }
        public string measurement { get; set; }
        public float ingredientQuantities { get; set; }
        public int ingredientID { get; set; }

        public static List<Recipe> GetAll(List <string> sortIngredients)
        {
            List<Recipe> recipes = new List<Recipe>();

            string query = "SELECT DISTINCT recipeName, recipeID, vegetarian, preparationTime, recipeType, lvl FROM quantities " +
                "INNER JOIN recipes ON recipes.id = recipeID INNER JOIN " +
                "ingredients ON ingredients.id = ingredientID WHERE recipeName IS NOT NULL ";
                foreach(string checkedIngredient in sortIngredients)
                {
                query += checkedIngredient;
                }
            query += ";";
                

            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Recipe _recipe = new Recipe();
                _recipe.recipeID = (int)reader["recipeID"];
                _recipe.recipeName = (string)reader["recipeName"];
                _recipe.vegetarian = (bool)reader["vegetarian"];
                _recipe.preparationTime = (int)reader["preparationTime"];
                _recipe.recipeType = (string)reader["recipeType"];
                _recipe.lvl = (string)reader["lvl"];
                
                recipes.Add(_recipe);
            }
            reader.Close();
            return recipes;
        }

        public static List<Recipe> GetAllVeggies(List<string> sortIngredients)
        {
            List<Recipe> recipes = new List<Recipe>();

            string query = "SELECT DISTINCT recipeName, recipeID, vegetarian, preparationTime, recipeType, lvl FROM quantities " +
                "INNER JOIN recipes ON recipes.id = recipeID INNER JOIN " +
                "ingredients ON ingredients.id = ingredientID Where vegetarian = 1 ";
            foreach (string checkedIngredient in sortIngredients)
            {
                query += checkedIngredient;
            }
            query += ";";

            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Recipe _recipe = new Recipe();
                _recipe.recipeID = (int)reader["recipeID"];
                _recipe.recipeName = (string)reader["recipeName"];
                _recipe.vegetarian = (bool)reader["vegetarian"];
                _recipe.preparationTime = (int)reader["preparationTime"];
                _recipe.recipeType = (string)reader["recipeType"];
                _recipe.lvl = (string)reader["lvl"];
                if (_recipe.vegetarian == true)
                {
                    recipes.Add(_recipe);
                }

            }
            reader.Close();
            return recipes;
        }
        public static Recipe GetOne(int id)
        {
            string query = "SELECT * from quantities inner join ingredients ON ingredients.id = ingredientID  " +
                "INNER JOIN recipes ON recipes.id = recipeID WHERE recipeID = " + id;
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
                Recipe _recipe = new Recipe();
                _recipe.recipeID = (int)reader["recipeID"];
                _recipe.recipeName = (string)reader["recipeName"];
                _recipe.vegetarian = (bool)reader["vegetarian"];
                _recipe.preparationTime = (int)reader["preparationTime"];
                _recipe.recipeType = (string)reader["recipeType"];
                _recipe.lvl = (string)reader["lvl"];
                _recipe.ingredientName = (string)reader["ingredientName"];
                _recipe.measurement = (string)reader["measurement"];
                _recipe.ingredientQuantities = (float)reader["ingredientQuantities"];
                
            reader.Close();
            return _recipe;
        }

    }
}
