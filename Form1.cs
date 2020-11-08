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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            //add the condition here;
            /* */
            home_form hm = new home_form();
            this.Hide();
            hm.Show();
        }

        private void about_us_login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by \n 1.Abenezer Ayalneh \n 2.Beniam Tibebu \n 3.Doni Tamrat \n 4.Hermon Shimelis");
        }
    }
}
