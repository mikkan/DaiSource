using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnXayDungPhanMem
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void ptb_Start_MouseEnter(object sender, EventArgs e)
        {
           // ptb_Start.Image = Properties.Resources.BatDau_MouseOver;
        }


        private void ptb_Start_MouseLeave(object sender, EventArgs e)
        {
           // ptb_Start.Image = DoAnXayDungPhanMem.Properties.Resources.BatDau;
        }

        private void ptb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
