using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_1_3_Assignment_PHILIP_GRAHAM
{
    public partial class BasicInput : Form
    {
        public BasicInput()
            ///Phiip Graham
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(NudAge.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            lblOutput.Text = ($"Hi , {name} you have roughly {82 - age} years left to live and you are {2.51 - height} meters shorter than the tallest person alive right now. ");


            


        }
    }
}
