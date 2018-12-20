using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTyrAgenstvo
{
    public partial class Search : Form
    {
        string connectionstr = "";
        public Search(string constr)
        {
            connectionstr = constr;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstr);
            connection.Open();
            string money = textBox1.Text;
            SqlCommand command = new SqlCommand("SELECT Price FROM Putivka WHERE Price<="+money, connection);
            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
