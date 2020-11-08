using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class emp_register : Form
    {
        public emp_register()
        {
            InitializeComponent();
        }

        private void aboutus_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by \n 1.Abenezer Ayalneh \n 2.Beniam Tibebu \n 3.Doni Tamrat \n 4.Hermon Shimelis");
        }
    }
}
