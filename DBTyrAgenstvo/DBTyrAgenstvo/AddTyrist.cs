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
    public partial class AddTyrist : Form
    {
        string connectionstr = "";
        public AddTyrist(string constr)
        {
            connectionstr = constr;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstr);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Tyrist([First Name],[Last Name],Prices,[By Father]) VALUES (@First_Name,@Last_Name,@Prices,@By_Father)", connection);
            command.Parameters.Add("@First_Name", textBox1.Text);
            command.Parameters.Add("@Last_Name", textBox2.Text);
            command.Parameters.Add("@Prices", textBox3.Text);
            command.Parameters.Add("@By_Father", textBox4.Text);

            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
