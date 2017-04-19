using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Antwnis
{
    public partial class Form1 : Form
    {
        string MyConnectionString = "server=localhost;user id = antwnis; password=antwnis@123;port=3307;characterset=utf8;database=antwnis;";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'antwnisDataSet3.magazine' table. You can move, or remove it, as needed.
            this.magazineTableAdapter.Fill(this.antwnisDataSet3.magazine);
        }

        private void στοίχειαAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Στάθης Βότσης" + "\n" + "\n" + "stathisvotsis.com" + "\n" + "6974090755" + "\n" + "stathisvotsis@gmail.com");
        }

        private void νέαΚαταχώρησηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mg = new Form1();
            mg.Show();
            this.Close();
        }

        private void περιοδικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magazine2 mg = new Magazine2();
            mg.Show();
            this.Close();
        }

        private void έλεγχοςStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock mg = new Stock();
            mg.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            magazineBindingSource.Filter = string.Format("Name LIKE '%{0}%'", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                DateTime localDate = DateTime.Now;
                String cultureName =  "el-GR" ;
                var culture = new CultureInfo(cultureName);
                string date1 = localDate.ToString(culture);
                string var1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                int var = Int32.Parse(var1);
               
                if (var1!="")
                {
                    string var2 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    int var3 = Int32.Parse(var2);
                    var3 = var3 - 1;
                    
                    try
                    {
                        MySqlConnection myConn3 = new MySqlConnection(MyConnectionString);
                        string Query3 = "update antwnis.magazine set Quantity = '" + var3.ToString() + "' where AA = '"+var1+"' ;";
                        MySqlCommand cmdDatabase3 = new MySqlCommand(Query3, myConn3);
                        MySqlDataReader myReader3;
                        try
                        {
                            myConn3.Open();
                            myReader3 = cmdDatabase3.ExecuteReader();
                            while (myReader3.Read())
                            {

                            }
                            myConn3.Close();
                            // TODO: This line of code loads data into the 'antwnisDataSet3.magazine' table. You can move, or remove it, as needed.
                            this.magazineTableAdapter.Fill(this.antwnisDataSet3.magazine);
                        }
                        catch (Exception) { MessageBox.Show("Error on Update 1"); }/////

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error on Update 2");
                    }

                    string Query4 = "insert into transactions (AA,Date) values ('"+var1+"','" + date1 + "');";
                    MySqlConnection myConn4 = new MySqlConnection(MyConnectionString);
                    MySqlCommand cmdDatabase4 = new MySqlCommand(Query4, myConn4);
                    MySqlDataReader myReader4;
                    try
                    {
                        myConn4.Open();
                        myReader4 = cmdDatabase4.ExecuteReader();
                        while (myReader4.Read())
                        {
                            //nothing this time to do
                        }   
                        myConn4.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Λάθος");

                    }
                }
            }
        }
    }
}
