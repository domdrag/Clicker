using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2
{
    public partial class objekt : UserControl
    {
        public int mBodovi;
        public event EventHandler kupljeno;
        private int mCijena;
        private int mKoliko;
        private string mIme;
        public string putanja
        {
            set { 
                Image image = Image.FromFile(value);
                pictureBox1.Image = image;
            }
        }
        public string ime
        {
            get { return mIme; }
            set
            {
                mIme = value;
                imeLabel.Text = mIme;
            }
        }
        public int koliko
        {
            get { return mKoliko; }
            set
            {
                mKoliko = value;
                imamLabel.Text = "Imam: " + mKoliko.ToString();
            }
        }
        public int cijena
        {
            get { return mCijena; }
            set
            {
                mCijena = value;
                cijenaLabel.Text = "Cijena: " + mCijena.ToString();
            }
        }
        public int bodova
        {
            set { 
                if (value >= cijena)
                {
                    kupiButton.Enabled = true;
                }
                else {
                    kupiButton.Enabled = false;
                }
            }
        }

        public objekt(int i)
        {
            InitializeComponent();
            koliko = 0;
            string path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            switch (i)
            {
                case 0: ime = "Miš"; cijena = 10; mBodovi = 5; putanja = path + "\\mis.png"; break;
                case 1: ime = "Gamepad"; cijena = 30; mBodovi = 20; putanja = path + "\\gamepad.png"; break;
                case 2: ime = "Robot"; cijena = 300; mBodovi = 50; putanja = path + "\\robot.png"; break;
            }
            this.Dock = DockStyle.Top;
        }
        private void kupi_Click(object sender, EventArgs e)
        {
            kupljeno?.Invoke(this, EventArgs.Empty);
        }

    }
}
