using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p1.Top += 5;
            p1.Left += 5;
            Rectangle r = new Rectangle(p1.Location.X, p1.Location.Y, p1.Width, p1.Height);
            
            if (ClientRectangle.IntersectsWith(r))
            {
                p1.Top *= -1;
                p1.Left *= -1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt1.Text != "")
            txt3.Text = (int.Parse(txt1.Text) + int.Parse(txt2.Text)).ToString();
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void bt_Tru_Click(object sender, EventArgs e)
        {
            txt3.Text = (int.Parse(txt1.Text) - int.Parse(txt2.Text)).ToString();
        }
    }
}
