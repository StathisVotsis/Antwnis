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
    public partial class CheckMagazine : Form
    {
        public CheckMagazine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Στάθης Βότσης" + "\n" + "\n" + "stathisvotsis.com" + "\n" + "6974090755" + "\n" + "stathisvotsis@gmail.com");
        }
    }
}
