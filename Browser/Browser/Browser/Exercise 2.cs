using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Browser
{
    public partial class Exercise_2 : Form
    {
        private Random random = new Random();
        private bool running = false;
        public Exercise_2()
        {
            InitializeComponent();
            Pos1.Click += btnPos1_Click;
            Pos2.Click += btnPos2_Click;
            Pos3.Click += btnPos3_Click;
            Pos4.Click += btnPos4_Click;
            btnstartstop.Click += btnStartStop_Click;
            lbltext.MouseEnter += lblText_MouseEnter;
            btnTarget.MouseEnter += btnTarget_MouseEnter;
            btnText.Click += btnChangeText_Click;
            Btnd.Click += btnDown_Click;
            BtnU.Click += btnUp_Click;
            BtnNext.Click += btn_Ex3;

        }

        private void bntPos1_Click (object sender,EventArgs e)
        {
            lbltext.Location = new Point(20, 20);
        }
        private void btnPos1_Click(object sender, EventArgs e)
        { lbltext.Location = new Point(20, 20);

        }
        private void btnPos2_Click(object sender, EventArgs e) 
        { lbltext.Location = new Point(200, 20);
        
        }
        private void btnPos3_Click(object sender, EventArgs e)
        { lbltext.Location = new Point(20, 150); 
        
        }
        private void btnPos4_Click(object sender, EventArgs e) 
        { lbltext.Location = new Point(200, 150); 
        
        }
        private void lblText_MouseEnter(object sender, EventArgs e)
        {
            int x = random.Next(0, this.ClientSize.Width - lbltext.Width);
            int y = random.Next(0, this.ClientSize.Height - lbltext.Height);
            lbltext.Location = new Point(x, y);
        }
        private void btnTarget_MouseEnter(object sender, EventArgs e)
        {
            Rectangle area = Screen.PrimaryScreen.WorkingArea;
            int x = random.Next(0, area.Width - this.Width);
            int y = random.Next(0, area.Height - this.Height);
            this.Location = new Point(x, y);
        }
        private void btnChangeText_Click(object sender, EventArgs e)
        {
            btnTarget.Text = "Joking :)";
            
        }
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            running = !running;
            if (running)
            {
                btnstartstop.Text = "Stop";
               btnindicator.BackColor = Color.Green;
            }
            else
            {
                btnstartstop.Text = "Start";
                btnindicator.BackColor = Color.Red;
            }
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            lbltext.Location = new Point(20, 20);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            lbltext.Location = new Point(20, this.ClientSize.Height - lbltext.Height - 20);
        }
        private Ex3 E3;
        private void btn_Ex3(object sender, EventArgs e)
        {
            if (E3 == null || E3.IsDisposed)
            {
                E3 = new Ex3();

            }
            E3.Show();
            E3.BringToFront();
            this.Hide();
        }
    }
}
