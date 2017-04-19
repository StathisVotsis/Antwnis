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
    public partial class Magazine : Form
    {
        public Magazine()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex==4)
            {
                OpenFileDialog od = new OpenFileDialog();
                od.ShowDialog();
                if (od.FileName != "")
                {
                    label1.Text = od.FileName;
                    dataGridView1.CurrentCell.Value = Image.FromFile(label1.Text);
                }
            }
        }

        private void Magazine_Load(object sender, EventArgs e)
        {    
            try
            {
                // TODO: This line of code loads data into the 'antwnisDataSet.magazine' table. You can move, or remove it, as needed.
                this.magazineTableAdapter.Fill(this.antwnisDataSet.magazine);
            }
            catch (Exception)
            {
                MessageBox.Show("Δεν φορτώνει η βάση δεδομένων - Εκτελέστε επανεκκίνηση προγράμματος ή καλέστε τον administrator");
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Λάθος στην αποθήκευση");
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.magazineTableAdapter.Update(this.antwnisDataSet.magazine);
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
                this.magazineTableAdapter.Update(this.antwnisDataSet.magazine);
            }
            catch (Exception)
            {
                MessageBox.Show("Λάθος στην αποθήκευση");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Διαγραφή εγγραφής?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.magazineBindingSource.RemoveCurrent();
                try
                {
                    this.magazineTableAdapter.Update(this.antwnisDataSet.magazine);
                }
                catch (Exception)
                {
                    MessageBox.Show("Λάθος στην αποθήκευση");
                }
            }
        }

        private void Magazine_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Validate();
                this.magazineBindingSource.EndEdit();
                this.magazineTableAdapter.Update(this.antwnisDataSet.magazine);
            }
            catch (Exception)
            {
                MessageBox.Show("Λάθος στην αποθήκευση");
            }
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }
    }
}
