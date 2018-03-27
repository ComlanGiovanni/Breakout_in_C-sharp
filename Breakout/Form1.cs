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

        public const int row = 7;
        public const int col = 7;

        public PictureBox[,] blocks;

        //Form1 constructor 
        public Form1()
        {
            verticalSpeed = 10;
            horizontalSpeed = 10;
            CreateBlocks();
            InitializeComponent();//Component initailisation (all form etc)
        }

        private void CreateBlocks()
        {
            int blockHeight = 25;
            int blockWidth = 100;

            blocks = new PictureBox[row, col]; //6X6

            for( int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    blocks[x, y] = new PictureBox
                    {

                        //priopriety
                        Width = blockWidth,
                        Height = blockHeight,
                        Top = blockHeight * x,
                        Left = blockWidth * y,

                        BackColor = Color.Black,//RGB code if u want
                        BorderStyle = BorderStyle.Fixed3D
                    };//put picture box in the 5x5

                    this.Controls.Add(blocks[x, y]);
                }
            }
        }

        //Tick eventhandler
        private void Timer1_Tick(object sender, EventArgs e)
        {
            imgBall.Top += verticalSpeed;//Evry 100 millscond the distance btw the top increase
            imgBall.Left += horizontalSpeed;

            if(imgBall.Bottom > this.ClientSize.Height)//ClientSize.Height is the height of the application
                verticalSpeed *= -1;//Change direction

            if (imgBall.Top < 0)
                verticalSpeed *= -1;
            
            if(imgBall.Right > this.ClientSize.Width)
                horizontalSpeed *= -1;

            if (imgBall.Left < 0)
                horizontalSpeed *= -1;

            if (imgBall.Bounds.IntersectsWith(imgBar.Bounds) == true)
            {
                verticalSpeed *= -1;
                //horizontalSpeed *= -1;
            }

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if(imgBall.Bounds.IntersectsWith(blocks[x,y].Bounds) && blocks[x,y].Visible == true)//return true or false
                    {
                        blocks[x, y].Visible = false;
                        verticalSpeed *= -1;
                    }
                }
            }
        }

        //different event for over the bar

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            imgBar.Left = e.X - (imgBar.Width/2); //Place the cursor in the middle
        }
    }
}
