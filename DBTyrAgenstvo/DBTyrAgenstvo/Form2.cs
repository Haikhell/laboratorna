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
    public partial class Form2 : Form
    {
        private string a = "";
        public Form2(string con)
        {
            InitializeComponent();
            a = con;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(a);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO TyrAgent(License,[Name agent],[Id Result]) VALUES (@License,@Name_agent,@Id_Result)",connection);
            command.Parameters.Add("@License",textBox1.Text);
            command.Parameters.Add("@Name_agent",textBox2.Text);
            command.Parameters.Add("@Id_Result", textBox3.Text);

            command.ExecuteNonQuery();
            connection.Close();
            this.Close();

            
        }
    }
}
