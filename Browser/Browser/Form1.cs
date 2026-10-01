using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        private ColorChanger changer = new ColorChanger();
        public Form1()
        {
            InitializeComponent();

            UP.Click += btnUp_Click;
            Down.Click += btnDown_Click;
            left.Click += btnLeft_Click;
            right.Click += btnRight_Click;
            Stop.Click += btnStop_Click;
            Start.Click += btnStart_Click;
            timer1.Tick += timer1_Tick;
            textPeriod.TextChanged += txtPeriod_TextChanged;
           // timer1.Interval = 300;

        }

         private void btnUp_Click(object sender, EventArgs e)
     {
         textBox1.Text = "You pressed UP";
            this.Top -= step;
     }
          private void btnDown_Click(object sender, EventArgs e)
         {
             textBox1.Text = "You pressed DOWN";
            this.Top += step;
         }
        private void btnLeft_Click(object sender, EventArgs e)
         {
             textBox1.Text = "You pressed LEFT";
            this.Left -= step;

         }
         private void btnRight_Click(object sender, EventArgs e)
         {
             textBox1.Text = "You pressed RIGHT";
            this.Left += step;
        }
        private int step = 20;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = changer.GetRandomColor();
        }
        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            int period;
            if (int.TryParse(textPeriod.Text, out period) && period > 0)
            {
                timer1.Interval = period;
                textPeriod.BackColor = Color.White;
            }
            else
            {
                textPeriod.BackColor = Color.LightCoral;
            }
        }


       



       





















    }
}
