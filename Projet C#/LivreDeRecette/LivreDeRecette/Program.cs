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


        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 


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
