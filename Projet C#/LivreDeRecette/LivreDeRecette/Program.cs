/// Author : Jorge Miguel Pinto Costa - Alessia Mavraj
/// Porject : Livre de recettes
/// Date : 12.01.2024
/// Version 1.0

using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivreDeRecette
{
    internal static class Program
    {
        public static MySqlConnection conn;


        // Opens the SQL Connection


        [STAThread]
        static void Main(string[] args)
        {
            string server = "localhost";
            string database = "cooking";
            string username = "root";
            string password = "Pa$$w0rd";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + username + ";" + "PASSWORD=" + password + ";";

            conn = new MySqlConnection(constring);
            conn.Open();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
