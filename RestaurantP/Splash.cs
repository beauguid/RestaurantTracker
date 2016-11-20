using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantP
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        Timer t; //Global timer created to time the splash screen

        private void Splash_Shown(object sender, EventArgs e)
        {
            //Loading control style and speed of loading
            pbLoading.Style = ProgressBarStyle.Marquee;
            pbLoading.MarqueeAnimationSpeed = 120;

            //Timer runs for 2 secs then function t_Tick is call
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            t.Tick += new EventHandler(t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            t.Stop();//Timer is stop

            pbLoading.Style = ProgressBarStyle.Blocks;

            this.DialogResult = DialogResult.OK;
        }
    }
}
