using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LivreDeRecette
{
    public class Ingredients
    {
        public int id {get;set;}
        public string ingredientName { get;set;}
        public string measurement { get; set; }

        public static List<Ingredients> GetAll()
        {
            List<Ingredients> ingredients = new List<Ingredients>();

            string query = "select * from ingredients";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ingredients _ingrendient = new Ingredients();
                _ingrendient.id = (int)reader["id"];
                _ingrendient.ingredientName = (string)reader["ingredientName"];
                _ingrendient.measurement = (string)reader["measurement"];
                ingredients.Add(_ingrendient);
            }
            return ingredients;
        }

    }
}
