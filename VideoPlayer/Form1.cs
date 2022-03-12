using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WMPLib;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        string vid;
        double start = 69, end = 69;

        public Form1()
        {
            InitializeComponent();

            System.Timers.Timer t = new System.Timers.Timer();
            t.Interval = 5; // In milliseconds
            t.AutoReset = true; // Stops it from repeating
            t.Elapsed += new ElapsedEventHandler(loopTime);
            t.Start();
        }

        private void loadVideo_Click(object sender, EventArgs e)
        {
            videoDialog.ShowDialog();
            vid = videoDialog.FileName;

            axWindowsMediaPlayer1.URL = vid;
            axWindowsMediaPlayer1.Refresh();
            axWindowsMediaPlayer1.settings.rate = 0.01f;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {


        }

        private void THISISEPIC(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {

        }

        private void loopTime(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (start != 69 && end != 69)
                {
                    Console.WriteLine("Current Pos: " + axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
                    if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition > start)
                    {
                        Console.WriteLine("Returning");
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = end;
                        
                    }
                }

            } catch (Exception)
            {

            }   

        }


        private void forwardFrame_Click(object sender, EventArgs e)
        {
            ((WMPLib.IWMPControls2)axWindowsMediaPlayer1.Ctlcontrols).step(1);
            //axWindowsMediaPlayer1.Refresh();
        }

        private void backFrame_Click(object sender, EventArgs e)
        {
            IWMPControls2 Ctlcontrols2 = (IWMPControls2)axWindowsMediaPlayer1.Ctlcontrols;

            double frameRate = axWindowsMediaPlayer1.network.encodedFrameRate;
            double step = 1.0 / frameRate;

            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= step; //Go backwards
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }

        private void endBtn_CheckedChanged(object sender, EventArgs e)
        {
            end = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            Console.WriteLine(end);
        }

        private void startBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            end = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            Console.WriteLine(end);
        }

        private void endBtn_CheckedChanged_1(object sender, EventArgs e)
        {
            start = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            Console.WriteLine(start);
        }

        private void loopBtn_Click(object sender, EventArgs e)
        {

        }

        private void startBtn_CheckedChanged(object sender, EventArgs e)
        {
            start = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            Console.WriteLine(start);
        }
    }
}
