using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OleDb.OleDbCommand;
using System.Exception;


namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ob3 =new Form3();
            ob3.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var conn = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\Users\\Roopa\\Documents\\Buisness.accdb");
            conn.Open();
            OleDbCommand cmd =new OleDbCommand("SELECT (*) FROM Table1", conn);
            conn.Open();
            
            
                int i;
                i =Convert.ToInt32(cmd.ExecuteReader());
                if (i == 1)
                {
                MessageBox.Show("Success");
                }
               else
                {MessageBox.Show("Invalid User Name or Password");
               }
            


        }
    }
}