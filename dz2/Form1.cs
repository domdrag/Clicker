using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2
{
    public partial class Form1 : Form
    {
        private int broj_bodova = 0;
        objekt oMis, oGamePad, oRobot;
        public int brojBodova
        {
            get { return broj_bodova; }
            set
            {
                broj_bodova = value;
                bodoviLabel.Text = string.Format("{0} \nBodova", brojBodova);
                check_mis();
                check_gamepad();
                check_robot();
            }
        }

        public Form1()
        {
            InitializeComponent();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oMis = null;
            oGamePad = null;
            oRobot = null;
            formTimer.Start();
            if (DateTime.Now.Hour < 10)
                porukeTextBox.AppendText("0");
            porukeTextBox.AppendText(DateTime.Now.Hour.ToString() + ":");
            if (DateTime.Now.Minute < 10)
                porukeTextBox.AppendText("0");
            porukeTextBox.AppendText(DateTime.Now.Minute.ToString());
            porukeTextBox.AppendText(" Započeta nova igra");
            porukeTextBox.AppendText(Environment.NewLine);
        }


        private void bodoviButton_Click(object sender, EventArgs e)
        {
            ++brojBodova;
        }
        private void check_mis()
        {
            if (oMis != null)
            {
                oMis.bodova = brojBodova;
            }
            if (broj_bodova >= 10 && oMis == null)
            {
                oMis = new objekt(0);
                oMis.kupljeno += (sender_, e_) =>
                {
                    var element = (objekt)sender_;
                    brojBodova -= element.cijena;
                    ++element.koliko;
                    if (DateTime.Now.Hour < 10)
                        porukeTextBox.AppendText("0");
                    porukeTextBox.AppendText(DateTime.Now.Hour.ToString() + ":");
                    if (DateTime.Now.Minute < 10)
                        porukeTextBox.AppendText("0");
                    porukeTextBox.AppendText(DateTime.Now.Minute.ToString());
                    porukeTextBox.AppendText(string.Format(" Novi broj miševa: {0}\n", element.koliko));
                    porukeTextBox.AppendText(Environment.NewLine);
                    element.cijena += (int)((double)15 / 100 * element.cijena);
                };
                splitContainer2.Panel1.Controls.Add(oMis);
            }
        }
        private void check_gamepad()
        {
            if (oGamePad != null)
            {
                oGamePad.bodova = brojBodova;
            }
            if (broj_bodova >= 30 && oGamePad == null)
            {
                oGamePad = new objekt(1);
                oGamePad.kupljeno += (sender_, e_) =>
                {
                    var element = (objekt)sender_;
                    brojBodova -= element.cijena;
                    ++element.koliko;
                    if (DateTime.Now.Hour < 10)
                        porukeTextBox.AppendText("0");
                    porukeTextBox.AppendText(DateTime.Now.Hour.ToString() + ":");
                    if (DateTime.Now.Minute < 10)
                        porukeTextBox.AppendText("0");
                    porukeTextBox.AppendText(DateTime.Now.Minute.ToString());
                    porukeTextBox.AppendText(string.Format(" Novi broj gamepada: {0}\n", element.koliko));
                    porukeTextBox.AppendText(Environment.NewLine);
                    element.cijena += (int)((double)15 / 100 * element.cijena);
                };
                splitContainer2.Panel1.Controls.Add(oGamePad);
            }
        }

        private void check_robot()
        {
            if (oRobot != null)
            {
                oRobot.bodova = brojBodova;
            }
            if (broj_bodova >= 300 && oRobot == null)
            {
                oRobot = new objekt(2);
                oRobot.kupljeno += (sender_, e_) =>
                {
                    var element = (objekt)sender_;
                    brojBodova -= element.cijena;
                    ++element.koliko;
                    if (DateTime.Now.Hour < 10)
                        porukeTextBox.AppendText("0");
                    porukeTextBox.AppendText(DateTime.Now.Hour.ToString() + ":");
                    if (DateTime.Now.Minute < 10)
                        porukeTextBox.AppendText("0");
                    porukeTextBox.AppendText(DateTime.Now.Minute.ToString());
                    porukeTextBox.AppendText(string.Format(" Novi broj robota: {0}\n", element.koliko));
                    porukeTextBox.AppendText(Environment.NewLine);
                    element.cijena += (int)((double)15 / 100 * element.cijena);
                };
                splitContainer2.Panel1.Controls.Add(oRobot);
            }
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            if (oMis != null)
                brojBodova += oMis.koliko * oMis.mBodovi;
            if (oGamePad != null)
                brojBodova += oGamePad.koliko * oGamePad.mBodovi;
            if (oRobot != null)
                brojBodova += oRobot.koliko * oRobot.mBodovi;
        }

        private void NovaIgra(object sender, EventArgs e)
        {
            splitContainer2.Panel1.Controls.Clear();
            oMis = null;
            oGamePad = null;
            oRobot = null;
            brojBodova = 0;
            porukeTextBox.Clear();
            if (DateTime.Now.Hour < 10)
                porukeTextBox.AppendText("0");
            porukeTextBox.AppendText(DateTime.Now.Hour.ToString() + ":");
            if(DateTime.Now.Minute < 10)
                porukeTextBox.AppendText("0");
            porukeTextBox.AppendText(DateTime.Now.Minute.ToString());
            porukeTextBox.AppendText(" Započeta nova igra");
            porukeTextBox.AppendText(Environment.NewLine);
      
        }

    }
}
