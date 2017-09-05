//Paxston Gulledge
//Week 3 Assignment 3, August 22, 2017
//Exercise 1, create a family database with 10 entries
//Exercise 2, display the first name and last name of the entries in a program
//This was all done with the data connections/data source built in functions of visual studio.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3Assignment3Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Working with our database file
            this.familyTableAdapter.Fill(this.familyNameDataSet.Family);

        }
    }
}
