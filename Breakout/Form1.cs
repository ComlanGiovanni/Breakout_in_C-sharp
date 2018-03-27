using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout
{
    public partial class Form1 : Form
    {
        public int verticalSpeed;
        public int horizontalSpeed;

        //Form1 constructor 
        public Form1()
        {
            verticalSpeed = 5;
            horizontalSpeed = 5;
            InitializeComponent();//Component initailisation (all form etc)
        }

        //Tick eventhandler
        private void Timer1_Tick(object sender, EventArgs e)
        {
            imgBall.Top += verticalSpeed;//Evry 100 millscond the distance btw the top increase
            //imgBall.Left += horizontalSpeed;

            if(imgBall.Bottom > this.ClientSize.Height)//ClientSize.Height is the height of the application
                verticalSpeed *= -1;//change direction

            if (imgBall.Top < 0)
                verticalSpeed *= -1;
            
            if(imgBall.Right > this.ClientSize.Width)
                horizontalSpeed *= -1;

            if (imgBall.Left < 0)
                horizontalSpeed *= -1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
