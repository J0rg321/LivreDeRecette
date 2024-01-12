using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivreDeRecette
{
    // Select all the steps from a specific recipe by his ID
    public class Steps
    {
        public int id { get; set; }
        public string stepName { get; set; }
        public int stepNumber { get; set; }
        public string content { get; set; }
        public int recipeID { get; set; }

        public static List<Steps> GetAll(int id)
        {
            List<Steps> steps = new List<Steps>();

            string query = "select * from steps WHERE recipeID =" + id;
            MySqlCommand cmd = new MySqlCommand(query, Program.conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Steps _step = new Steps();
                _step.id = (int)reader["id"];
                _step.stepName = (string)reader["stepName"];
                _step.stepNumber = (int)reader["stepNumber"];
                _step.content = (string)reader["content"];
                _step.recipeID = (int)reader["recipeID"];

                steps.Add(_step);
            }
            reader.Close();
            return steps;
        }


    }
}
