using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    class Jogador
    {
        public string nome { get; set }
        public DateTime data { get; set }
        public string email { get; set }
        public DateTime celular { get; set }
        public string cidade { get; set }

        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\CRUD _SOLO\\WindowsFormsApp1\\WindowsFormsApp1\\DbJogador.mdf;Integrated Security = True");
    }
}
