using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefterim
{
    public partial class Programcı : Form
    {
        public Programcı()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://vahap.my.canva.site/vahapdogan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
