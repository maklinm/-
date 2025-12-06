using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
namespace GlaMenu
{
    public partial class TestForm2 : Form
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

        public TestForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TestGameForm testGameForm=new TestGameForm();
            testGameForm.Show();
            this.Close();
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Clipck.wav");
            simpleSound.Play();
            
        }

        private void Tomotk_Click(object sender, EventArgs e)
        {
            Tomotk.Visible = false;
            Tomvk.Visible = true;
            Formtesttumb = Tomvk.Visible;
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Knopamp.wav");
            simpleSound.Play();
            if (Tomotk.Visible == false)
            {

                Tth2.Enabled = true;
                Thk1.Enabled = true;
                Tor1.Enabled = true;
                Tme1.Enabled = true;
            }
            
        }

        private void Tomvk_Click(object sender, EventArgs e)
        {
            Tomotk.Visible = true;
            
            SoundPlayer simpleSound1 = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Knopamp.wav");
            simpleSound1.Play();
            if (Tomotk.Visible == true)
            {
                Tth2.Enabled = false;
                Thk1.Enabled = false;
                Tor1.Enabled = false;
                Tme1.Enabled = false;
            }
            

        }

        private void Tth1_Click(object sender, EventArgs e)//true
        {
            Tth2.Visible = true;
            SoundPlayer s = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            s.Play();
            
            if (Tth2.Visible == true)
            {
                lampF1.Visible = true;
                new_lampF1.Visible = false;
                indik.Visible = false;
            }

        }

        private void Tth2_Click(object sender, EventArgs e)
        {
            Tth2.Visible = false;
            Tth1.Visible = true;
            SoundPlayer se = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            se.Play();
            FormtestChastota = Tth1.Visible;
            if (Tth2.Visible==false)
            {

                new_lampF1.Visible = true;
                lampF1.Visible = false;
                indik.Visible = true;
            }

        }

        private void Thk1_Click(object sender, EventArgs e)
        {
            Thk1.Visible = false;
            Thk2.Visible = true;
            FormtestShkala = Thk2.Visible;
            SoundPlayer sou = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            sou.Play();
            
        }

        private void Thk2_Click(object sender, EventArgs e)//true
        {
            Thk1.Visible = true;
            
            SoundPlayer souv = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            souv.Play();
            
        }

        private void Tor1_Click(object sender, EventArgs e)
        {
            Tor1.Visible = false;
            Tor2.Visible = true;
            FormtestOri = Tor2.Visible;
            SoundPlayer soun = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            soun.Play();

        }

        private void Tor2_Click(object sender, EventArgs e)//true
        {
            Tor1.Visible = true;
            
            SoundPlayer sewq = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            sewq.Play();
        }

        private void Tme1_Click(object sender, EventArgs e)
        {
            Tme1.Visible = false;
            Tme2.Visible=true;
            Formtestmest = Tme2.Visible;
            SoundPlayer see = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            see.Play();
        }

        private void Tme2_Click(object sender, EventArgs e)//true
        {
            Tme1.Visible=true;
            
            SoundPlayer seeww = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\knopka-schelchok.wav");
            seeww.Play();
        }

        private void Tumb1M2P_Click(object sender, EventArgs e)
        {
            Tumb1M2P.Visible = false;
            Tumb1D2P.Visible = true;
            FormTestMestDist = Tumb1D2P.Visible;
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            simpleSound.Play();
        }

        private void Tumb1D2P_Click(object sender, EventArgs e)
        {
            Tumb1M2P.Visible = true;
            
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\zvuk41.wav");
            simpleSound.Play();
        }

        private void Knstart1_Click(object sender, EventArgs e)
        {
            Knstart1.Visible = false;
            Knstart1_1.Visible = true;
            FormTestAD = Knstart1_1.Visible;
            SoundPlayer simpleSoun = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSoun.Play();
            LamPaNaADoff.Visible = false;
            LamPaNa_AD.Visible = true;
        }

        private void Knstart1_1_Click(object sender, EventArgs e)
        {
            Knstart1.Visible = true;
            
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void Knstart2_Click(object sender, EventArgs e)
        {
            Knstart2.Visible = false;
            Knstart2_1.Visible = true;
            FormtestESD = Knstart2_1.Visible;
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

        private void Knstart3_Click(object sender, EventArgs e)
        {
            Knstart3.Visible = false;
            Knstart3_1.Visible = true;
            FormtestPSH = Knstart3_1.Visible;
            SoundPlayer simpleSou3 = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSou3.Play();
            LamPaNaPSHoff.Visible= false;
            LamPaNa_PSH.Visible = true;
            

        }

        private void Knstart3_1_Click(object sender, EventArgs e)
        {
            Knstart3.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
           
        }

        private void Knstop1_Click(object sender, EventArgs e)
        {
            Knstop1.Visible = false;
            SoundPlayer simpleSound = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSound.Play();
            LamPaNa_AD.Visible= false;
            LamPaNaADoff.Visible = true;
        }

        private void Knstop1_1_Click(object sender, EventArgs e)
        {
            Knstop1.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void Knstop2_Click(object sender, EventArgs e)
        {
            Knstop2.Visible = false;
            SoundPlayer simpleSou7 = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSou7.Play();
            LamPaNA_IDS.Visible = false;
            LamPaNaIDSoff.Visible = true;
        }

        private void Knstop2_1_Click(object sender, EventArgs e)
        {
            Knstop2.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
        }

        private void Knstop3_Click(object sender, EventArgs e)
        {
            Knstop3.Visible = false;
            SoundPlayer simpleSou9 = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopkones.wav");
            simpleSou9.Play();
            LamPaNa_PSH.Visible= false;
            LamPaNaPSHoff.Visible = true;
            

        }

        private void Knstop3_1_Click(object sender, EventArgs e)
        {
            Knstop3.Visible = true;
            SoundPlayer simple = new SoundPlayer(@"\тренажер\Тренажерный комплекс\GlaMenu\Muzknopktwos.wav");
            simple.Play();
            
        }

        private void Tomotk_MouseEnter(object sender, EventArgs e)
        {
            pitOTK.Visible = true;

        }

        private void Tomotk_MouseLeave(object sender, EventArgs e)
        {
            pitOTK.Visible = false;
            Warning_scr.Visible = true;
        }

        private void Knstop3_MouseEnter(object sender, EventArgs e)
        {
            PSH_OTK.Visible = true;
        }

        private void Knstop3_MouseLeave(object sender, EventArgs e)
        {
            PSH_OTK.Visible = false;
        }

        private void Knstart3_MouseEnter(object sender, EventArgs e)
        {
            PSH_l_Zap.Visible = true;
        }

        private void Knstart3_MouseLeave(object sender, EventArgs e)
        {
            PSH_l_Zap.Visible= false;
        }

        private void Tomvk_MouseEnter(object sender, EventArgs e)
        {
            pit27.Visible = true;
        }

        private void Tomvk_MouseLeave(object sender, EventArgs e)
        {
            pit27.Visible = false;
            Warning_scr.Visible = false;
            
        }

        private void Tth1_MouseEnter(object sender, EventArgs e)
        {
            F1_.Visible= true;
        }

        private void Tth1_MouseLeave(object sender, EventArgs e)
        {
            F1_.Visible= false;
        }

        private void Thk2_MouseEnter(object sender, EventArgs e)
        {
            Hkl_Dal.Visible= true;
        }

        private void Thk2_MouseLeave(object sender, EventArgs e)
        {
            Hkl_Dal.Visible= false;
        }

        private void Thk1_MouseEnter(object sender, EventArgs e)
        {
            HKl_Dal_off.Visible= true;
        }

        private void Thk1_MouseLeave(object sender, EventArgs e)
        {
            HKl_Dal_off.Visible = false;
        }

        private void Tor2_MouseEnter(object sender, EventArgs e)
        {
            Or_Text.Visible= true;
        }

        private void Tor2_MouseLeave(object sender, EventArgs e)
        {
            Or_Text.Visible= false;
        }

        private void Tor1_MouseEnter(object sender, EventArgs e)
        {
            Or_ot.Visible= true;
        }

        private void Tor1_MouseLeave(object sender, EventArgs e)
        {
            Or_ot.Visible= false;
        }

        private void Tme2_MouseEnter(object sender, EventArgs e)
        {
            lab1.Visible= true;
        }

        private void Tme2_MouseLeave(object sender, EventArgs e)
        {
            lab1.Visible= false;
        }

        private void Tme1_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible= true;
        }

        private void Tme1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible= false;
        }

        private void Tumb1M2P_MouseEnter(object sender, EventArgs e)
        {
            dist_nagru.Visible= true;
        }

        private void Tumb1M2P_MouseLeave(object sender, EventArgs e)
        {
            dist_nagru.Visible= false;
        }

        private void Tumb1D2P_MouseEnter(object sender, EventArgs e)
        {
            mest_nagru.Visible= true;
        }

        private void Tumb1D2P_MouseLeave(object sender, EventArgs e)
        {
            mest_nagru.Visible= false;
        }

        private void Knstart1_MouseEnter(object sender, EventArgs e)
        {
            VklA.Visible= true;
        }

        private void Knstart2_MouseEnter(object sender, EventArgs e)
        {
            lag.Visible= true;
        }

        private void Knstart2_MouseLeave(object sender, EventArgs e)
        {
            lag.Visible= false;
        }

        private void Knstop2_MouseEnter(object sender, EventArgs e)
        {
            laf.Visible= true;
        }

        private void Knstop2_MouseLeave(object sender, EventArgs e)
        {
            laf.Visible= false;
        }

        private void Knstart1_MouseLeave(object sender, EventArgs e)
        {
            VklA.Visible = false;
        }

        private void Knstop1_MouseEnter(object sender, EventArgs e)
        {
            OtkA.Visible = true;
        }

        private void Knstop1_MouseLeave(object sender, EventArgs e)
        {
            OtkA.Visible= false;
        }
        Point post;
        private void TestForm2_MouseDown(object sender, MouseEventArgs e)
        {
            post = new Point(e.X, e.Y);
        }

        private void TestForm2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - post.X;
                this.Top += e.Y - post.Y;
            }
        }

        private void TestForm2_Load(object sender, EventArgs e)
        {

        }

        private void KU_Probno_Click(object sender, EventArgs e)
        {
            // установка параметров
            //if (Formtesttumb==true && Formtestmest==true && FormtestOri ==true && FormtestShkala==true &&
            //    FormtestChastota ==true && FormTestMestDist == true &&
            //    FormTestAD==true && FormtestESD==true && FormtestPSH == true)
            //{
            //    string data = "PanelTwoTesttrue";
            //    File.WriteAllText("C:\\тренажер\\shared_file.txt", data);
            //}
            //if ((Tomvk.Visible == true) && (Tme2.Visible = true) && (Thk2.Visible == true) &&
            //    (Tor2.Visible == true) && (Tth1.Visible == true) && (Tumb1D2P.Visible == true) && 
            //    (Knstart1_1.Visible == true) && (Knstart2_1.Visible == true) && (Knstart3_1.Visible == true))
            //{
            //    DialogResult W = MessageBox.Show(
            //        "Успешный запсук программы",
            //        "Системные сообщения",
            //        MessageBoxButtons.OKCancel,
            //        MessageBoxIcon.None
            //        );
            //    if (W == DialogResult.OK)
            //    {
            //        this.Hide();
            //        Menu M = new Menu();
            //        M.Show();
            //    }
            //}
            if (Formtesttumb == true && Formtestmest == true && FormtestOri == true && FormtestShkala == true &&
                FormtestChastota == true && FormTestMestDist == true &&
                FormTestAD == true && FormtestESD == true && FormtestPSH == true)
            {
                string data = "PanelTwoTesttrue";
                File.WriteAllText(@"\тренажер\Exe\Operators\shared_file.txt", data);
            }
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNa_PSH.Visible == true))
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
                && (LamPaNA_IDS.Visible == true) && (LamPaNaPSHoff.Visible == true))
            {
                DialogResult y = MessageBox.Show(
                    "Ошибка подключения, переключите кнопку ПСЧ в состояние <включено> ",
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNaADoff.Visible == true)
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == false) && (LamPaNa_AD.Visible == true)
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == true) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == true)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == false) && (Thk1.Visible == true) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
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
            if ((Tomotk.Visible == false) && (Tth2.Visible == true) && (Thk1.Visible == false) && (Tor1.Visible == false)
                 && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
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
            if ((Tomotk.Visible == true) && (Tth2.Visible == false) && (Thk1.Visible == false) && (Tor1.Visible == false)
                && (Tme1.Visible == false) && (Tumb1M2P.Visible == true) && (LamPaNa_AD.Visible == true)
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


            //if (E == DialogResult.OK)
            //{
            //    this.Hide();
            //    Menu M = new Menu();
            //    M.Show();

            //}
        }
    }
}

