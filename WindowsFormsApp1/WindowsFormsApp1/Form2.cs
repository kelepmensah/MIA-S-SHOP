using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Mexican torta is a big, delicious sandwich, served on a crusty white sandwich roll. " +
                "This one is filled with steak, pinto beans, and avocado, and is bursting with Mexican flavors.","item details");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A panini sandwich with avocado mayonnaise is layered with smoked turkey, roasted red" +
                " peppers, and provolone cheese, and pressed until the sandwich is crisp and toasted and the filling is melted.","item details");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A cheese sandwich is a basic sandwich generally made with one or more varieties of cheese on" +
                " any sort of bread, such as flat bread or wheat bread, that may also include spreads such as butter or mayonnaise.","item details");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("one of the most popular fillings includes prosciutto, creamy soft cheeses like" +
                " squacquerone, tomatoes, and a handful of peppery wild arugula this is made with maize" +
                " flour and called la pjida ad furmantounin Romagnolan dialect.","item details");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Reuben sandwich is an American grilled sandwich composed of corned beef, Swiss cheese," +
                " sauerkraut, and Russian dressing, grilled between slices of rye bread. It is associated with kosher-style" +
                " delicatessens, but it is not kosher, because it contains both meat and cheese.","item details");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submarine sandwich consisting of a length of bread or roll split lengthwise and filled with a" +
                " variety of meats, cheeses, vegetables, and condiments.","item details");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
