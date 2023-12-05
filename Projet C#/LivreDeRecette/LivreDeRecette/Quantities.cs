using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LivreDeRecette
{
    public class Quantities
    {
        public int id { get; set; }
        public int ingredientID { get; set; }
        public int recipeID { get; set; }
        public float ingredientQuantities { get; set; }

        public static List<Quantities> GetAll()
        {
            List<Quantities> quantities = new List<Quantities>();

            string query = "select * from ingredients";
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Quantities _quantity = new Quantities();
                _quantity.id = (int)reader["id"];
                _quantity.ingredientID = (int)reader["ingredientID"];
                _quantity.recipeID = (int)reader["recipeID"];
                _quantity.ingredientQuantities = (float)reader["ingredientQuantities"];

                quantities.Add(_quantity); 
            }
            return quantities;
        }
    }

}
