using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlaMenu
{
    public partial class ProbGameFrom : Form
    {
        public bool Tite1;
        public bool Tite2;
        public bool Tite3;
        public bool Tite4;
        public ProbGameFrom()
        {
            InitializeComponent();
        }

        private void ProbGameFrom_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void Pacet2_Click(object sender, EventArgs e)
        {
            Pacet1.Visible = true;
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\MuzTum.wav");
            simpleSound.Play();
        }

        private void Pacet1_Click(object sender, EventArgs e)
        {
            Pacet1.Visible = false;
            Pacet2.Visible = true;
            Tite2 = Pacet2.Visible;
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\MuzTum.wav");
            simpleSound.Play();
        }

        private void knopPN_Click(object sender, EventArgs e)
        {
            knopP.Visible = true;
            Tite1 = knopP.Visible;
            if (knopP.Visible == true)
            {
                lampa.Visible = false;
                lampa2.Visible = true;
                Lampa_RA.Visible = false;

            }
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void knopP_Click(object sender, EventArgs e)
        {
            knopP.Visible = false;
            if (knopP.Visible == false)
            {
                Lampa_PU.Visible = true;
                Lampa_RA.Visible = true;               
                lampa.Visible = true;
            }
            SoundPlayer simpleOut = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleOut.Play();
        }

        private void knopS_Click(object sender, EventArgs e)
        {
            knopS.Visible = false;
            if (knopS.Visible == false)
            {
                
                Lampa_RA.Visible = true;
            }
             SoundPlayer simpleOut = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleOut.Play();
        }

        private void knopSN_Click(object sender, EventArgs e)
        {
            knopS.Visible = true;
            if (knopS.Visible == true)
            {
                
                Lampa_RA.Visible = false;
                lampa2.Visible = false;
                lamp3_1.Visible = true;

                lamp3_1.Show();
            }
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void buttD_Click(object sender, EventArgs e)
        {
            buttM.Visible = true;
            
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            simpleSound.Play();
        }

        private void buttM_Click(object sender, EventArgs e)
        {
            buttM.Visible = false;
            buttD.Visible = true;
            Tite4 = buttD.Visible;
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            simpleSound.Play();
        }

        private void tumb1_Click(object sender, EventArgs e)
        {
            tumb2.Visible = true;
            if (tumb2.Visible == true)
            {
                KTP.Visible = false;
                lam_27_1.Visible = true;
            }
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Knopamp.wav");
            simpleSound.Play();
        }

        private void tumb2_Click(object sender, EventArgs e)
        {
            tumb2.Visible = false;
            tumb1.Visible = true;
            Tite3 = tumb1.Visible;
            if (tumb2.Visible == false)
            {
                KTP.Visible = true;
                lam_27_1.Visible = false;
                Lam_27_2.Visible = true;
            }
            if(tumb1.Visible==false)
            {
                KTP.Visible = false;
                lampa_TU.Visible = true;
            }
            SoundPlayer pal = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopamp_rabotaem.wav");
            pal.Play();
        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            
            Menu menu= new Menu();
            menu.Show();
            this.Close();
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();


        }

       
        Point Jew;
        private void ProbGameFrom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - Jew.X;
                this.Top += e.Y - Jew.Y;
            }
        }

        private void ProbGameFrom_MouseDown(object sender, MouseEventArgs e)
        {
            Jew = new Point(e.X, e.Y); 
        }

        private void strel_1_Click(object sender, EventArgs e)
        {
            ProbtwoGame probtwo = new ProbtwoGame();
            this.Close();
            probtwo.Show();            
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();

        }

        private void KU_Probno_Click(object sender, EventArgs e)
        {
            if (Tite1 == true && Tite2 == true && Tite3 == true && Tite4 == true)
            {
                string data = "PanelOneRegimRabot";
                File.WriteAllText(@"\тренажер\Exe\Operators\shared_file.txt", data);
            }
            if ((tumb2.Visible == false) && (Pacet1.Visible == false) && (buttM.Visible == true) && (lampa2.Visible == true))
            {
                DialogResult W = MessageBox.Show(
                    "Успешный запсук программы",
                    "Системные сообщения",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.None
                    );
                if (W == DialogResult.OK)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();

                }

            }
            if ((tumb2.Visible == true) && (Pacet1.Visible == false) && (buttM.Visible == false) && (lampa2.Visible == true))
            {
                DialogResult Q = MessageBox.Show(
                    "Отсутствие питания пульта",
                    "ЭКСТРЕНННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            if ((tumb2.Visible == false) && (Pacet1.Visible == true) && (buttM.Visible == false) && (lampa2.Visible == true))
            {
                DialogResult R = MessageBox.Show(
                    "Включите сеть питания",
                    "ЭКСТРЕНННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            if ((tumb2.Visible == false) && (Pacet1.Visible == false) && (buttM.Visible == true) && (lampa2.Visible == true))
            {
                DialogResult S = MessageBox.Show(
                    "На данном режиме невозможно использование такого соостояния тумблера",
                    "ЭКСТРЕНННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            if ((tumb2.Visible == false) && (Pacet1.Visible == false) && (buttM.Visible == false) && (lamp3_1.Visible == true))
            {
                DialogResult D = MessageBox.Show(
                    "Запуск пульта остановлен",
                    "ЭКСТРЕНННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }
    }
}
