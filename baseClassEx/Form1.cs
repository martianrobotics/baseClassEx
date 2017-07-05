using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baseClassEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyBaseClass mbc = new MyBaseClass("baseClass Needs This!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySubclass msc = new MySubclass("subclass needs this!", 88);
        }
    }
}
