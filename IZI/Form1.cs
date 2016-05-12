using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void actionsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void actionChoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iziDataSet.zoos' table. You can move, or remove it, as needed.
            this.zoosTableAdapter.Fill(this.iziDataSet.zoos);
            // TODO: This line of code loads data into the 'iziDataSet.foods' table. You can move, or remove it, as needed.
            this.foodsTableAdapter.Fill(this.iziDataSet.foods);
            // TODO: This line of code loads data into the 'iziDataSet.animals' table. You can move, or remove it, as needed.
            this.animalsTableAdapter.Fill(this.iziDataSet.animals);

        }
    }
}
