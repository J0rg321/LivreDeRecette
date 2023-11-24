using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LivreDeRecette
{
    public class Ingredient
    {
        public int id {get;set;}
        public string name_of_ingredient { get;set;}
        public string measurement { get; set; }

        public static List<Ingredient> GetAll()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            string query = "select * from ingredient";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ingredient ing = new Ingredient();
                ing.id = (int)reader["id"];
                ing.name_of_ingredient = (string)reader["name_of_ingredient"];

                ingredients.Add(ing);
            }
            return ingredients;
        }

    }
}
