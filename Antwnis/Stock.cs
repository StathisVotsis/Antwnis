using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antwnis
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        //DataTable dbdataset;
        //DataTable dt = new DataTable();

        private void Stock_Load(object sender, EventArgs e)
        {   
            try
            {
                // TODO: This line of code loads data into the 'antwnisDataSet1.magazine' table. You can move, or remove it, as needed.
                this.magazineTableAdapter.Fill(this.antwnisDataSet1.magazine);
            }
            catch (Exception)
            {
                MessageBox.Show("Δεν φορτώνει η βάση δεδομένων - Εκτελέστε επανεκκίνηση προγράμματος ή καλέστε τον administrator");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //DataView DV = new DataView(dbdataset);
            //DV.RowFilter = string.Format("Name LIKE '%{0}%'", textBox1.Text);
            //dataGridView1.DataSource = DV;
            magazineBindingSource.Filter = string.Format("Name LIKE '%{0}%'", textBox1.Text);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Λάθος στην αποθήκευση");
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.magazineTableAdapter.Update(this.antwnisDataSet1.magazine);
            }
            catch (Exception)
            {
                MessageBox.Show("Λάθος στην αποθήκευση");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.magazineBindingSource.EndEdit();
                this.magazineTableAdapter.Update(this.antwnisDataSet1.magazine);
            }
            catch (Exception)
            {
                MessageBox.Show("Λάθος στην αποθήκευση");
            }
        }

        private void Stock_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.magazineBindingSource.EndEdit();
                this.magazineTableAdapter.Update(this.antwnisDataSet1.magazine);
            }
            catch (Exception)
            {
                
            }
        }

        private void στοίχειαAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Στάθης Βότσης" + "\n" + "\n" + "stathisvotsis.com" + "\n" + "6974090755" + "\n" + "stathisvotsis@gmail.com");
        }

        private void έλεγχοςStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock sc = new Stock();
            sc.Show();
            this.Close();
        }

        private void περιοδικάToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magazine mg = new Magazine();
            mg.Show();
            this.Close();
        }

        private void νέαΚαταχώρησηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mg = new Form1();
            mg.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
