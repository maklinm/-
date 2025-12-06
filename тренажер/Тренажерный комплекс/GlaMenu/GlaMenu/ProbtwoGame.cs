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
    public partial class ProbtwoGame : Form
    {
        public bool Formtesttumb;
        public bool Formtestmest;
        public bool FormtestOri;
        public bool FormtestShkala;
        public bool FormtestChastota;
        public bool FormTestMestDist;
        public bool FormTestAD;
        public bool FormtestESD;
        public bool FormtestPSH;
        public ProbtwoGame()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProbGameFrom probGameFrom=new ProbGameFrom();
            this.Close();
            probGameFrom.Show();            
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();
        }
        private void butD1_Click(object sender, EventArgs e)
        {
            butD1.Visible = false;
            buttD.Visible = true;
            FormTestMestDist = buttD.Visible;
            SoundPlayer soundPlayer = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            soundPlayer.Play();
        }
        private void buttD_Click(object sender, EventArgs e)
        {
            butD1.Visible = true;
            SoundPlayer soundPlayer = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            soundPlayer.Play();
        }
        private void Downtub_Click(object sender, EventArgs e)
        {
            Downtub.Visible = false;
            Uptub.Visible = true;
            Formtesttumb = Uptub.Visible;
            SoundPlayer play = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Knopamp.wav");
            play.Play();
            
            if (Downtub.Visible==false)
            {
                Tth2.Enabled = true;
                Thk1.Enabled = true;
                Tor1.Enabled = true;
                Tme1.Enabled = true;
            }
        }
        private void Uptub_Click(object sender, EventArgs e)
        {
            Downtub.Visible = true;
            
            SoundPlayer play = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Knopamp.wav");
            play.Play();
            if(Downtub.Visible==true)
            {
                Tth2.Enabled = false;
                Thk1.Enabled = false;
                Tor1.Enabled = false;
                Tme1.Enabled = false;
            }
        }
        private void Thk2_Click(object sender, EventArgs e)
        {
            Thk1.Visible = true;
            SoundPlayer s = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            s.Play();

        }

        private void Thk1_Click(object sender, EventArgs e)
        {
            Thk1.Visible = false;
            Thk2.Visible = true;
            FormtestShkala =Thk2.Visible;
            SoundPlayer s = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            s.Play();
        }

        private void Tor2_Click(object sender, EventArgs e)
        {
            Tor1.Visible = true;
            SoundPlayer sewq = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            sewq.Play();
        }

        private void Tor1_Click(object sender, EventArgs e)
        {
            Tor1.Visible = false;
            Tor2.Visible=true;
            FormtestOri=Tor2.Visible;
            SoundPlayer sewq = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            sewq.Play();
        }

        private void Tme2_Click(object sender, EventArgs e)
        {
            Tme1.Visible = true;
            
            SoundPlayer seeww = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            seeww.Play();
        }

        private void Tme1_Click(object sender, EventArgs e)
        {
            Tme1.Visible = false;
            Tme2.Visible=true;
            Formtestmest=Tme2.Visible;
            SoundPlayer seeww = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            seeww.Play();
        }

        private void Knstart1_Click(object sender, EventArgs e)
        {
            Knstart1.Visible = false;
            Knstart2.Visible=true;
            FormTestAD= Knstart2.Visible;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simple.Play();
            LamPaNaADoff.Visible = false;
            LamPaNa_AD.Visible = true;
        }

        private void Knstart1_1_Click(object sender, EventArgs e)
        {
            Knstart1.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void Knstop1_1_Click(object sender, EventArgs e)
        {
            Knstop1.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void Knstop1_Click(object sender, EventArgs e)
        {
            Knstop1.Visible = false;
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSound.Play();
            LamPaNa_AD.Visible = false;
            LamPaNaADoff.Visible = true;
        }

        private void Knstop2_1_Click(object sender, EventArgs e)
        {
            Knstop2.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void Knstop2_Click(object sender, EventArgs e)
        {
            Knstop2.Visible = false;
            SoundPlayer simpleSo = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSo.Play();
            LamPaNA_IDS.Visible = false;
            LamPaNaIDSoff.Visible = true;
        }

        private void Knstop3_1_Click(object sender, EventArgs e)
        {
            Knstop3.Visible = true;
            SoundPlayer simpl = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simpl.Play();
        }

        private void Knstop3_Click(object sender, EventArgs e)
        {
            Knstop3.Visible = false;
            SoundPlayer si = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            si.Play();
            LamPaNa_PSH.Visible = false;
            LamPaNaPSHoff.Visible = true;
        }

        private void Knstart2_Click(object sender, EventArgs e)
        {
            Knstart2.Visible = false;
            Knstart2_1.Visible = true;
            FormtestESD =Knstart2_1.Visible;
            SoundPlayer simpleSou1 = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSou1.Play();
            LamPaNaIDSoff.Visible = false;
            LamPaNA_IDS.Visible = true;
        }

        private void Knstart2_1_Click(object sender, EventArgs e)
        {
            Knstart2.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void Knstart3_1_Click(object sender, EventArgs e)
        {
            Knstart3.Visible = true;
            SoundPlayer simpleSou3 = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSou3.Play();
            LamPaNaPSHoff.Visible = false;
            LamPaNa_PSH.Visible = true;
        }

        private void Knstart3_Click(object sender, EventArgs e)
        {
            Knstart3.Visible = false;
            Knstart3_1.Visible = true;
            FormtestPSH = Knstart3_1.Visible;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void LamPaNaPSHoff_Click(object sender, EventArgs e)
        {

        }

        private void LamPaNa_PSH_Click(object sender, EventArgs e)
        {

        }

        private void LamPaNA_IDS_Click(object sender, EventArgs e)
        {

        }

        private void LamPaNaIDSoff_Click(object sender, EventArgs e)
        {

        }

        private void LamPaNaADoff_Click(object sender, EventArgs e)
        {

        }

        private void LamPaNa_AD_Click(object sender, EventArgs e)
        {

        }

        private void Tth1_Click(object sender, EventArgs e)
        {
            Tth2.Visible = true;
            SoundPlayer s = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            s.Play();
            if (Tth2.Visible == true)
            {
                lampF1.Visible = true;
                new_lampF1.Visible = false;
            }
        }

        private void Tth2_Click(object sender, EventArgs e)
        {
            Tth2.Visible = false;
            Tth1.Visible= true;
            FormtestChastota=Tth1.Visible;
            SoundPlayer se = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            se.Play();

            if (Tth2.Visible == false)
            {

                new_lampF1.Visible = true;
                lampF1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Formtesttumb == true && Formtestmest == true && FormtestOri == true && FormtestShkala == true &&
                FormtestChastota == true && FormTestMestDist == true &&
                FormTestAD == true && FormtestESD == true && FormtestPSH == true)
            {
                string data = "Panel-TWO-RegimRabot";
                File.WriteAllText(@"\тренажер\Exe\Operators\shared_file.txt", data);
            }
            if ((Downtub.Visible==false)&&(Tth2.Visible==false)&&(Thk1.Visible==false)&&(Tor1.Visible==false)
                &&(Tme1.Visible==false)&&(butD1.Visible==true)&&(LamPaNa_AD.Visible==true)
                &&(LamPaNA_IDS.Visible==true)&&(LamPaNa_PSH.Visible==true))
            {
                DialogResult W = MessageBox.Show(
                    "Успешный запсук программы",
                    "Системные сообщения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );
                if (W == DialogResult.OK)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();

                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNaPSHoff.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                    "Ошибка подключения, переключите кнопку ПСЧ в состояние <включено> ",
                    "Cистемные сообщения",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
                if(y==DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNaIDSoff.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                    "Ошибка подключения, переключите кнопку ЭСД в состояние <включено> ",
                    "Cистемные сообщения",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNaADoff.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                   "Ошибка подключения, переключите кнопку АД в состояние <включено> ",
                   "Cистемные сообщения",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                   "Ошибка подключения, переключите тумблер на дистанционный режим управления ",
                   "Cистемные сообщения",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == true) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                   "Ошибка подключения, включите переключатель в режим местного управления ",
                   "Cистемные сообщения",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == true)
                && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                   "Ошибка подключения, включите переключатель ориентира для отображения на индикаторе" +
                   " кругового обзора ",
                   "Cистемные сообщения",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == true) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                   "Ошибка подключения, включите переключатель для шкалы дальности ",
                   "Cистемные сообщения",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == false) && (Tth2.Visible == true) && (Thk1.Visible == false) && (Tor1.Visible == false)
                 && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                 && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                   "Ошибка подключения, включите переключатель для установки частоты ",
                   "Cистемные сообщения",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }
            if ((Downtub.Visible == true) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (buttD.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                   "Ошибка подключения, включите тумблер в режим питания ",
                   "Cистемные сообщения",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Asterisk);
                if (y == DialogResult.Cancel)
                {
                    this.Hide();
                    Menu M = new Menu();
                    M.Show();
                }
            }


        }
        Point post;
        private void ProbtwoGame_MouseDown(object sender, MouseEventArgs e)
        {
            post = new Point(e.X, e.Y);
        }

        private void ProbtwoGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - post.X;
                this.Top += e.Y - post.Y;
            }
        }

        private void ProbtwoGame_Load(object sender, EventArgs e)
        {

        }
    }
}
