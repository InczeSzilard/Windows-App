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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
            BtnBold.Click += btnBold_Click;
            BtnNormal.Click += btnNormal_Click;
            BtnItalic.Click += btnItalic_Click;
            BtnColor.Click += btnColor_Click;

            
        }

        

        private void btnNormal_Click(object sender, EventArgs e)
        { 
            LbText2.Font = new Font("Arial", 12, FontStyle.Regular); 
            LbText2.ForeColor = Color.Black; 
        }
        private void btnBold_Click(object sender, EventArgs e) 
        {
            LbText2.Font = new Font("Arial", 12, FontStyle.Bold);
            LbText2.ForeColor = Color.Blue; 
        }
        private void btnItalic_Click(object sender, EventArgs e)
        { 
            LbText2.Font = new Font("Arial", 12, FontStyle.Italic);
            LbText2.ForeColor = Color.Green; 
        }
        private void btnColor_Click(object sender, EventArgs e) 
        {
            LbText2.Font = new Font("Arial", 12, FontStyle.Underline);
            LbText2.ForeColor = Color.Red; 
        }



        private void Ex3_Paint(object sender, PaintEventArgs e)
        {
            if (!drawRectangle)
                return;

            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 2);

            Rectangle rectangle = new Rectangle(100, 100, 300, 200);

            g.DrawRectangle(pen, rectangle);

            g.DrawLine(
                pen,
                rectangle.Left,
                rectangle.Top,
                rectangle.Right,
                rectangle.Bottom
            );

            g.DrawLine(
                pen,
                rectangle.Right,
                rectangle.Top,
                rectangle.Left,
                rectangle.Bottom
            );

            pen.Dispose();
        }
        private void Ex3_Load(object sender, EventArgs e)
        {
        }
        private bool drawRectangle = true;
        private void ClearForm()
        {
            drawRectangle = false;
            this.Invalidate();
        }
    }
}
