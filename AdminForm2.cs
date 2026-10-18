using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kerbnikov_PR07_GIT
{
    public partial class AdminForm2 : Form
    {
        public AdminForm2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void AdminForm2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
