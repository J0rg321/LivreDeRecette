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
        // Select all the ingredients to their respective recipes with the quantities from the SQL Data Base
        public int id { get; set; }
        public int ingredientID { get; set; }
        public string ingredientName { get; set; }
        public string measurement { get; set; }
        public int recipeID { get; set; }
        public float ingredientQuantities { get; set; }

        public static List<Quantities> GetAll(int id)
        {
            List<Quantities> quantities = new List<Quantities>();

            string query = "SELECT * FROM quantities INNER JOIN ingredients ON ingredients.id = quantities.ingredientID WHERE quantities.recipeID = " + id;
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Quantities _quantity = new Quantities();
                _quantity.id = (int)reader["id"];
                _quantity.ingredientID = (int)reader["ingredientID"];
                _quantity.measurement = (string)reader["measurement"];
                _quantity.ingredientName = (string)reader["ingredientName"];
                _quantity.recipeID = (int)reader["recipeID"];
                _quantity.ingredientQuantities = (float)reader["ingredientQuantities"];
                


                quantities.Add(_quantity); 
            }
            reader.Close();
            return quantities;
        }

    }

}
