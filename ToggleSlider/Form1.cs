using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToggleSlider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void toggleSliderComponent1_CheckChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void toggleSliderComponent1_CheckChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
