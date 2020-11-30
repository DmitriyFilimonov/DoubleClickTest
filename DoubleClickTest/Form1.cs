using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleClickTest
{
    public partial class Form1 : Form
    {
        int a = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(a++);
        }
    }
}
