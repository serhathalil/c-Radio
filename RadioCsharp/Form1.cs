using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.130.169.199:80 ";
            label2.Text = "Kral Pop";
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.210:80/";
            label2.Text = "Ntv Spor";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.30:80";
            label2.Text = "Kral Rock";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://46.20.7.126:80 ";
            label2.Text = "Best Fm";
        }

      
        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://37.75.11.179/fenomen/FenomenAkustik_mpeg_128_home/icecast.audio   ";
            label2.Text = "Fenomen";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.165.197.36:8000/istanbulfm ";
            label2.Text = "İstanbul Fm";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://95.130.169.205:80 ";
            label2.Text = "Kral Oyun";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin.netradyom.com:5959";
            label2.Text = "Makro Fm";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://31.3.0.45:8102";
            label2.Text = "Number 1";
        }

  
        private void button6_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "	http://46.20.3.234:80";
            label2.Text = "Show Radyo";
        }


    }
}
