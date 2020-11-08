using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Car_Register : Form
    {
        public Car_Register()
        {
            InitializeComponent();
        }

        private void Car_Register_Load(object sender, EventArgs e)
        {

        }

        private void register_menu_Click(object sender, EventArgs e)
        {

        }

        private void aboutus_menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by \n 1.Abenezer Ayalneh \n 2.Beniam Tibebu \n 3.Doni Tamrat \n 4.Hermon Shimelis");
        }

        private void product_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Buying_price_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Load_img_Click(object sender, EventArgs e)
        {
            //openFileDialog1 load = new openFileDialog1();
        }

        private void color_combo_SelectedIndexChanged(object sender, EventArgs e)
            {
                //to add the list of all the known colors in the combo box
            
                List<string> colorslist = new List<string>();

                string[] allColors = Enum.GetNames(typeof(System.Drawing.KnownColor));
                string[] systemEnvironmentColors = new string[(typeof(System.Drawing.SystemColors)).GetProperties().Length];

                int index = 0;

                foreach (MemberInfo member in (typeof(System.Drawing.SystemColors)).GetProperties())
                {
                    systemEnvironmentColors[index++] = member.Name;
                }

                foreach (string color in allColors)
                {
                    if (Array.IndexOf(systemEnvironmentColors, color) < 0)
                    {
                        colorslist.Add(color);
                    }
                }

                color_combo.DataSource = colorslist;
        }



        private void type_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> car_types = new List<string>();
            car_types.Add("Family Van");
            car_types.Add("Offroad");
            car_types.Add("Luxury");
            //car_types.Add("Occasional");

            type_combo.DataSource = car_types;


        }
    }
}
