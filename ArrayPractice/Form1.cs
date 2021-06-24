﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();

        int[] vx = new int[3] ;
        int[] vy = new int[3];
        int score = 100;

        public Form1()
        {
            InitializeComponent();

            for (int ii = 0; ii < 3; ii++)
            {
                MessageBox.Show("" + ii);
            }

            for (int i = 0; i < 3; i++)
            {
                vx[i] = rand.Next(-20, 21);
                vy[i] = rand.Next(-20, 21);
            }
            

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score--;
            scoreLabel.Text = $"Score {score:000}";

            label1.Left += vx[0];
            label1.Top += vy[0];
            label2.Left += vx[2];
            label2.Top += vy[2];
            label3.Left += vx[3];
            label3.Top += vy[3];

            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }

            if (label2.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label2.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label2.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }

            if (label3.Left < 0)
            {
                vx[3] = Math.Abs(vx[3]);
            }
            if (label3.Top < 0)
            {
                vy[3] = Math.Abs(vy[3]);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx[3] = -Math.Abs(vx[3]);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[3] = -Math.Abs(vy[3]);
            }

            Point fpos = PointToClient(MousePosition);

            if ((fpos.X >= label1.Left)
                && (fpos.X < label1.Right)
                && (fpos.Y >= label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                label1.Visible = false;
            }

            if ((fpos.X >= label2.Left)
                && (fpos.X < label2.Right)
                && (fpos.Y >= label2.Top)
                && (fpos.Y < label2.Bottom))
            {
                label2.Visible = false;
            }

            if ((fpos.X >= label3.Left)
                && (fpos.X < label3.Right)
                && (fpos.Y >= label3.Top)
                && (fpos.Y < label3.Bottom))
            {
                label3.Visible = false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}