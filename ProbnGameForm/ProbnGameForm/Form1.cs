using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProbnGameForm
{
    public partial class Probn : Form
    {
        public Probn()
        {
            InitializeComponent();
            MaximizeBox= false;
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Пробный запуск";
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        





        private void buttM_Click_1(object sender, EventArgs e)
        {
            buttM.Visible = false;
        }

        private void buttD_Click(object sender, EventArgs e)
        {
            buttM.Visible = true;
        }

        private void tumb1_Click_1(object sender, EventArgs e)
        {
            tumb2.Visible = true;
        }

        private void tumb2_Click_1(object sender, EventArgs e)
        {
            tumb2.Visible = false;
        }

        private void Pacet1_Click_1(object sender, EventArgs e)
        {
            Pacet1.Visible = false;
        }

        private void Pacet2_Click_1(object sender, EventArgs e)
        {
            Pacet1.Visible = true;
        }

        private void knopSN_Click_1(object sender, EventArgs e)
        {
            knopS.Visible = true;
            if (knopS.Visible == true)
            {
                lampa2.Visible = false;
                lamp3_1.Visible = true;

                lamp3_1.Show();
            }
        }

        private void knopS_Click(object sender, EventArgs e)
        {
            knopS.Visible = false;
            if (knopS.Visible == false)
            {
                lamp3_1.Visible = false;
            }
        }

        private void knopPN_Click_1(object sender, EventArgs e)
        {
            knopP.Visible = true;
            if (knopP.Visible == true)
            {
                lampa.Visible = false;
                lampa2.Visible = true;

            }
        }

        private void knopP_Click_1(object sender, EventArgs e)
        {
            knopP.Visible = false;
            if (knopP.Visible == false)
            {
                lampa2.Visible = false;
                lampa.Visible = true;
            }
        }
    }
}

 
