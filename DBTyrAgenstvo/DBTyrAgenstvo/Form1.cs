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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        string constr= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\source\repos\DBTyrAgenstvo\DBTyrAgenstvo\Agentstvo.mdf;Integrated Security=True";
        private void func(string zapit)
        {
            string a = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ivan\source\repos\DBTyrAgenstvo\DBTyrAgenstvo\Agentstvo.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(a);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(zapit, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void tyrAgenstvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM TyrAgent";
            func(zap);
        }

        private void moneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM money";
            func(zap);
        }

        private void putivkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM Putivka";
            func(zap);
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM Result";
            func(zap);
        }

        private void tyristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM Tyrist";
            func(zap);
        }

        private void zakladToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM Zaklad";
            func(zap);
        }

        private void zvitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM Zvit";
            func(zap);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(constr);
            form.ShowDialog();
            string zap = "SELECT * FROM TyrAgent";
            func(zap);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM TyrAgent";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand command =new SqlCommand("DELETE FROM TyrAgent WHERE Id=@id",connection);
            command.Parameters.Add("@id",Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
            command.ExecuteNonQuery();
            connection.Close();
            func(zap);

        }

        private void tyristToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM Tyrist";
            func(zap);

        }

        private void zvitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zvit zvit = new Zvit(constr);
            zvit.ShowDialog();
            
        }

        private void deleteTyristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string zap = "SELECT * FROM Tyrist";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Tyrist WHERE Id=@id", connection);
            command.Parameters.Add("@id", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value));
            command.ExecuteNonQuery();
            connection.Close();
            func(zap);
        }

        private void addTyristToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTyrist add = new AddTyrist(constr);
            add.ShowDialog();
            string zap = "SELECT * FROM Tyrist";
            func(zap);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string money = textBox1.Text;
            string zap = "SELECT * FROM Putivka WHERE Price<=" + money;
            func(zap);
        }
    }
}
