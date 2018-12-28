using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VadAUTO
{
    public partial class MeniuPrincipal : Form
    {
        private bool isCollapsed=true;
        private bool isCollapsed2=true; 
        string path= System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public MeniuPrincipal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            Bitmap logo = new Bitmap(path+"\\VadAUTOLogo.png");
           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Bitmap up = new Bitmap(path + "\\up-arrow.png");
                setariButton.Image = up;
               
                SetariPanel.Height += 10;
                if (SetariPanel.Size == SetariPanel.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                Bitmap down = new Bitmap(path + "\\down-arrow.png");
                setariButton.Image = down;
               
                SetariPanel.Height -= 10;
                if (SetariPanel.Size == SetariPanel.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void setariButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                Bitmap up = new Bitmap(path + "\\up-arrow.png");
                vanzariButton.Image = up;

                vanzariPanel.Height += 10;
                if (vanzariPanel.Size == vanzariPanel.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                Bitmap down = new Bitmap(path + "\\down-arrow.png");
                vanzariButton.Image = down;
                vanzariPanel.Height -= 10;
                if (vanzariPanel.Size == vanzariPanel.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
