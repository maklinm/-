using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GlaMenu
{
    
    public partial class TestGameForm : Form
    {
        public bool Tite1;
        public bool Tite2;
        public bool Tite3;
        public bool Tite4;
        public TestGameForm()
        {
            InitializeComponent();
            
        }

        private void TestGameForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            
        }
        


        private void knopP_Click_1(object sender, EventArgs e)
        {
            knopP.Visible = false;
            
            if (knopP.Visible == false)
            {
                LampaRa.Visible = true;
                
                LampaPuck.Visible = true;
                lampa.Visible = true;
            }
            if (knopP.Visible == true)
            {
                KnopSt.Visible = false;
                
            }
            SoundPlayer simpleSou = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSou.Play();
        }

        private void knopS_Click(object sender, EventArgs e)
        {
            knopS.Visible = false;
            
            if (knopS.Visible == false)
            {
                
                LampaRa.Visible = true;//
            }
            if (knopS.Visible == true)
            {
                KnopSt.Visible = false;
                
            }
            SoundPlayer simpleSou = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSou.Play();
        }

        private void knopPN_Click_1(object sender, EventArgs e)
        {
            knopP.Visible = true;
            Tite1 = knopP.Visible;
            if (knopP.Visible == true)
            {
                
                lampa.Visible = false;
                LampaRa.Visible = false;
                lampa2.Visible = true;
                
                //StreamWriter stream = new StreamWriter("C:\\тренажер\\shared_file.txt", true);
                //stream.WriteLine(data);
            }
            
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();


        }
        

        //public delegate void ClickToPacetbool(bool Pacet);

        //public ClickToPacetbool Pacet {
        //    get;
        //    set; 
        //}
        
       
        private void Pacet1_Click_1(object sender, EventArgs e)
        {
            Pacet1.Visible = false;
            Tite2= Pacet1.Visible;
            if (Pacet1.Visible == false)
            {
                
                
                //File.WriteAllText("C:\\тренажер\\shared_filetwo.txt", data1);
                PanPac.Visible = false;

            }
            SoundPlayer simpleSo = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\MuzTum.wav");
            simpleSo.Play();
        }

        private void Pacet2_Click_1(object sender, EventArgs e)
        {
            Pacet1.Visible = true;
            if (Pacet1.Visible == true)
            {
               
                PAcOT.Visible = false;
            }
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\MuzTum.wav");
            simpleSound.Play();

        }

        private void tumb1_Click_1(object sender, EventArgs e)
        {
            tumb2.Visible = true;
            if (tumb2.Visible == true)
            {
                TumBKl.Visible = false;
                
            }

            if (tumb2.Visible == true)
            {
                KTP.Visible = false;
                La_271.Visible = true;
            }
            SoundPlayer se = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Knopamp.wav");
            se.Play();
           

        }

        private void buttM_Click_1(object sender, EventArgs e)
        {
            buttM.Visible = false;
            if (buttM.Visible == false)
            {
                TimMe.Visible = false;
                
            }
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            simpleSound.Play();
        }

        private void knopSN_Click_1(object sender, EventArgs e)
        {  
            knopS.Visible = true;
            
            if (knopS.Visible == true)
            {
                LampaRa.Visible = false;               
                lampa2.Visible = false;
                lamp3_1.Visible = true;
                lamp3_1.Show();
                
            }
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }



        private void tumb2_Click(object sender, EventArgs e)
        {
            tumb2.Visible = false;
            Tite3 = tumb2.Visible;
            if (tumb2.Visible == false)
            {
                TumOT.Visible = false;
                
                
                //File.WriteAllText("C:\\тренажер\\shared_filethree.txt", data2);

            }
            if (tumb2.Visible == false)
            {
                KTP.Visible = true;
                La_271.Visible = false;
                La_272.Visible = true;
                
            }
            if(tumb1.Visible == false)
            {
                LampnKTP.Visible = true;
                KTP.Visible = false;
            }
            
            SoundPlayer pal = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopamp_rabotaem.wav");
            pal.Play();



        }




        private void buttD_Click(object sender, EventArgs e)
        {
            buttM.Visible = true;
            Tite4 = buttM.Visible;
            if (buttM.Visible == true)
            {
                TimDis.Visible = false;
                
                
                //File.WriteAllText("C:\\тренажер\\shared_filefour.txt", data3);
            }
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            simpleSound.Play();
        }


        private void VinM_Click(object sender, EventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();
            this.Close();
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();
        }

        private void Pacet1_MouseEnter(object sender, EventArgs e)
        {
            PanPac.Visible = true;


        }

        private void Pacet2_MouseEnter(object sender, EventArgs e)
        {
            PAcOT.Visible = true;

        }

        private void tumb2_MouseEnter(object sender, EventArgs e)
        {
            TumOT.Visible = true;
        }

        private void tumb1_MouseEnter(object sender, EventArgs e)
        {
            TumBKl.Visible = true;
        }

        private void buttM_MouseEnter(object sender, EventArgs e)
        {
            TimMe.Visible = true;
        }

        private void buttD_MouseEnter(object sender, EventArgs e)
        {
            TimDis.Visible = true;
        }

        private void buttM_MouseLeave(object sender, EventArgs e)
        {
            TimMe.Visible = false;
        }

        private void buttD_MouseLeave(object sender, EventArgs e)
        {
            TimDis.Visible = false;
        }

        private void tumb2_MouseLeave(object sender, EventArgs e)
        {
            TumOT.Visible = false;
            
            
        }

        private void tumb1_MouseLeave(object sender, EventArgs e)
        {
            TumBKl.Visible = false;
        }

        private void Pacet1_MouseLeave(object sender, EventArgs e)
        {
            PanPac.Visible = false;
        }

        private void Pacet2_MouseLeave(object sender, EventArgs e)
        {
            PAcOT.Visible = false;
        }

        private void knopP_MouseEnter(object sender, EventArgs e)
        {
            KnopPu.Visible = true;
        }

        private void knopP_MouseLeave(object sender, EventArgs e)
        {
            KnopPu.Visible = false;
        }

        private void knopS_MouseEnter(object sender, EventArgs e)
        {
            KnopSt.Visible = true;
        }

        private void knopS_MouseLeave(object sender, EventArgs e)
        {
            KnopSt.Visible = false;
        }

        private void ZavClick_Click(object sender, EventArgs e)
        {
            if (Tite1 == true && Tite2 == false && Tite3 == false && Tite4 == true)
            {
                string data = "PanelOneTesttrue";
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
            if ((tumb2.Visible == true) && (Pacet1.Visible == false) && (buttM.Visible == true) && (lampa2.Visible == true))
            {
                DialogResult Q = MessageBox.Show(
                    "Отсутствие питания пульта",
                    "ЭКСТРЕННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            if ((tumb2.Visible == false) && (Pacet1.Visible == true) && (buttM.Visible == true) && (lampa2.Visible == true))
            {
                DialogResult R = MessageBox.Show(
                    "Включите сеть питания",
                    "ЭКСТРЕННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            if ((tumb2.Visible == false) && (Pacet1.Visible == false) && (buttM.Visible == false) && (lampa2.Visible == true))
            {
                DialogResult S = MessageBox.Show(
                    "На данном режиме невозможно использование такого соостояния тумблера",
                    "ЭКСТРЕННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            if ((tumb2.Visible == false) && (Pacet1.Visible == false) && (buttM.Visible == true) && (lamp3_1.Visible == true))
            {
                DialogResult D = MessageBox.Show(
                    "Запуск пульта остановлен",
                    "ЭКСТРЕННОЕ СООБЩЕНИЕ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        Point Last;
        private void TestGameForm_MouseDown(object sender, MouseEventArgs e)
        {
            Last = new Point(e.X, e.Y);
        }
        private void TestGameForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - Last.X;
                this.Top += e.Y - Last.Y;
            }
        }

        

        private void Ppult2_Click(object sender, EventArgs e)
        {
            TestForm2 testForm2 = new TestForm2();
            testForm2.Show();
            this.Close();
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();
        }

        private void La_272_MouseLeave(object sender, EventArgs e)
        {
            label112.Visible= false;
        }

        private void La_272_MouseEnter(object sender, EventArgs e)
        {
            label112.Visible = true;
        }

        private void LampaRa_Click(object sender, EventArgs e)
        {

        }

        private void lampa2_Click(object sender, EventArgs e)
        {

        }
    }
}
