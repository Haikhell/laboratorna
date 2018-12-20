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
    public partial class Zvit : Form
    {
        string connectionstr = "";
        public Zvit(string constr)
        {
            connectionstr = constr;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionstr);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Zvit(Pytivka,Data,Name) VALUES (@Putivka,@Data,@Name)", connection);
            command.Parameters.Add("@Putivka", textBox1.Text);
            command.Parameters.Add("@Data", textBox2.Text);
            command.Parameters.Add("@Name", textBox3.Text);

            command.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }
    }
}
