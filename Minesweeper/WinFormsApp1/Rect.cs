using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsApp1
{
    public class Rect
    {

        public int X { get; set; }
        public int Y { get; set; }


        public Rect(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawRectangle(pen, new Rectangle(40 * X, 40 * Y, 40, 40));
            pen.Dispose();
        }

        public void DrawZname(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.DarkRed);
            g.FillRectangle(brush, new Rectangle(40 * X, 40 * Y, 40, 40));
            brush.Dispose();
        }

        public void DrawZatvorena(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 90, 83));
            g.FillRectangle(brush, new Rectangle(40 * X, 40 * Y, 40, 40));
            brush.Dispose();
        }

        public void DrawOtvorena(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            g.FillRectangle(brush, new Rectangle(40 * X, 40 * Y, 40, 40));
            brush.Dispose();
        }

        public void DrawBroj(Graphics g, string okolina)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            switch (okolina)
            {
                case "1": brush = new SolidBrush(Color.Maroon); break;
                case "2": brush = new SolidBrush(Color.Firebrick); break;
                case "3": brush = new SolidBrush(Color.DarkGoldenrod); break;
                case "4": brush = new SolidBrush(Color.Green); break;
                case "5": brush = new SolidBrush(Color.Teal); break;
                case "6": brush = new SolidBrush(Color.Purple); break;
                case "7": brush = new SolidBrush(Color.Blue); break;
                case "8": brush = new SolidBrush(Color.Gray); break;
            }

            Font font = new Font("Arial", 20.0f);
            g.DrawString(okolina, font, brush, X * 40 + 8, Y * 40 + 5);
            brush.Dispose();
        }

        public void DrawMina(Graphics g)
        {
            SolidBrush bre = new SolidBrush(Color.Black);
            g.FillEllipse(bre, new Rectangle(40 * X + 10, 40 * Y + 10, 20, 20));
            bre.Dispose();
        }
    }
}
