using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblStat.Hide();
            lblStat.Text = "100%";
        }
        string[] pastas = new string[] { "[OPTIMIZER]", @"\[OPGames]", @"\[OPSystem]", @"\[OPScreen]", @"\[Backup]" };
        private void btn1_Click(object sender, EventArgs e)
        {
            lblStat.Hide();
            Process.Start(pastas[0] + pastas[1] + @"\OptimizeGames.reg");
            lblStat.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblStat.Hide();
            Process.Start(pastas[0] + pastas[2] + @"\OptimizeSystem.reg");
            lblStat.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblStat.Hide();
            Process.Start(pastas[0] + pastas[3] + @"\OptimizeFullscreen.reg");
            lblStat.Show();
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            lblStat.Hide();
            Process.Start(pastas[0] + pastas[4] + @"\OptimizeGames.reg");
            lblStat.Show();
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            lblStat.Hide();
            Process.Start(pastas[0] + pastas[4] + @"\OptimizeSystem.reg");
            lblStat.Show();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            lblStat.Hide();
            Process.Start(pastas[0] + pastas[4] + @"\OptimizeFullscreen.reg");
            lblStat.Show();
        }
    }
}
