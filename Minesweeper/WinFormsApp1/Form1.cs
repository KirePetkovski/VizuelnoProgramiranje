using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Tabla tabla { get; set; }

        private int coorX;
        private int coorY;
        private bool igraj = true;
        private bool kreiraj = false;

       
        Graphics g;
        Kreiraj KreirajForm = new Kreiraj();

        public Form1()
        {
            InitializeComponent();
           
        }

        public void Postavi(int Golemina)                   //promenija goleminata na formata
        {
            Form1.ActiveForm.Width = Golemina;
            Form1.ActiveForm.Height = Golemina;

            panel.Width = Golemina;
            panel.Height = Golemina;
            panel.Visible = true;
            panel.Enabled = true;

            btnKreiraj.Visible = false;
            btnProfesionalen.Visible = false;
            btnSreden.Visible = false;
            btnPocetnicki.Visible = false;

            g = panel.CreateGraphics();
        }

        private void btnPocetnicki_Click(object sender, EventArgs e)
        {
            kreiraj = true;
            igraj = true;

            tabla = new Tabla(10, 9);
            Postavi(480);

            Invalidate(true);
        }
        private void btnSreden_Click(object sender, EventArgs e)
        {
            kreiraj = true;
            igraj = true;

            tabla = new Tabla(40, 16);
            Postavi(760);

            Invalidate(true);
        }

        private void btnProfesionalen_Click(object sender, EventArgs e)
        {
            kreiraj = true;
            igraj = true;

            tabla = new Tabla(100, 22);
            Postavi(1000);

            Invalidate(true);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (KreirajForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                kreiraj = true;
                igraj = true;
                tabla = KreirajForm.PomniTabla;                     //prezemi gi vleznite argumenti od formata Kreiraj

                int raz = tabla.Kocki + 3;
                Postavi(raz * 40);

                Invalidate(true);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            int okolina = 0;

            e.Graphics.Clear(Color.OliveDrab);

            for (int i = 0; i < tabla.Kocki; i++)
            {
                for (int j = 0; j < tabla.Kocki; j++)
                {
                    Rect rectangle = new Rect(i, j);                    //klasa za crtanje

                    if (tabla.Otvoreno[i, j] == true)                   //ako poleto e otvoreno                   
                    {
                        rectangle.DrawOtvorena(g);                      //nacrtaj kocka za otvoreno pole
                        okolina = tabla.izbrojBombi(i, j);              //izbroj bombi vo sosestvoto

                        if (okolina > 0)                                //ako ima broj
                        { 
                            rectangle.DrawBroj(g, okolina.ToString());  //vpishi go brojot
                        }
                    }
                    else                                                //ako poleto e zatvoreno
                    {
                        if (tabla.Zname[i, j] == false)                 //proveri dali ne e postaveni zname
                        {  
                            rectangle.DrawZatvorena(g);                 //nacrtaj zatvoreno pole
                        }
                        else
                        { 
                            rectangle.DrawZname(g);                     //nacrtaj zname
                        }
                    }
                    rectangle.Draw(g);                                  //nacrtaj linii vrz kockite
                }
            }

            if (igraj == false)                                         //dali igrata e zavrshena
            {
                tabla.KrajNaIgrata(g);                                  //nacrtaj mini (krugovi)
            }
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (igraj)                                          //dali moze da se igra
            {
                //koordinatoto pole pretvori gi vo indeksi
                coorX = e.X / 40;                                                    
                coorY = e.Y / 40;

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    if ((coorX >= 0) && (coorY >= 0) && (coorX < tabla.Kocki) && (coorY < tabla.Kocki))
                    {

                        if ((tabla.Otvoreno[coorX, coorY] == false) && (tabla.Zname[coorX, coorY] == false))
                        {
                            tabla.Otvoreno[coorX, coorY] = true;

                            if (tabla.Bomba[coorX, coorY] == true)
                            {
                                igraj = false;
                                tabla.KrajNaIgrata(g);            //prikazi bombi
                                MessageBox.Show("Погодивте бомба!", "Крај на играта", MessageBoxButtons.OK);

                            }
                            else
                            {
                                ////kliknato e pole koe ne e mina. proveri dali vo okolinata ima mina
                                tabla.PecatiBroevi(coorX, coorY, g);       
                            }
                            Invalidate(false);
                        }
                    }
                    
                    if (tabla.BroiPolinja == tabla.Kocki * tabla.Kocki)  //dali se site polinja otvoreni
                    {
                        MessageBox.Show("Честитки! ги пронајдовте сите мини.", "Крај на играта", MessageBoxButtons.OK);
                    }
                }

                if (e.Button == System.Windows.Forms.MouseButtons.Right)    //crtaj zname 
                {
                    Rect rectangle = new Rect(coorX, coorY);

                    if (tabla.Zname[coorX, coorY] == true)                  //ako ima zname togash izbrishi go
                    {
                        tabla.Zname[coorX, coorY] = false;
                        rectangle.DrawZatvorena(g);
                    }
                    else
                    {                                                       //inaku nacrtaj zname
                        if (tabla.Zname[coorX, coorY] == false && tabla.Otvoreno[coorX, coorY] == false)
                        {
                            tabla.Zname[coorX, coorY] = true;
                            rectangle.DrawZname(g);
                        }
                    }

                    rectangle.Draw(g);
                }
            }
        }

        private void menuIzlez_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuKraj_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                tabla.KrajNaIgrata(g);
                igraj = false;
            }
        }

        private void menuPocetno_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Width = 450;
            Form1.ActiveForm.Height = 600;

            btnKreiraj.Visible = true;
            btnProfesionalen.Visible = true;
            btnSreden.Visible = true;
            btnPocetnicki.Visible = true;

            panel.Visible = false;
            panel.Enabled = false;

            g = panel.CreateGraphics();
        }

        private void menuOdnovo_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                igraj = true;
                for (int i = 0; i < tabla.Kocki; i++)
                {
                    for (int j = 0; j < tabla.Kocki; j++)
                    {
                        tabla.Otvoreno[i, j] = false;
                        tabla.Zname[i, j] = false;

                        Rect rectangle = new Rect(i, j);
                        rectangle.DrawZatvorena(g);
                        rectangle.Draw(g);
                    }
                }
            }
        }

        private void menuNovaIgra_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                igraj = true;

                int newKocki = tabla.Kocki;
                int newBombi = tabla.Bombi;

                tabla = new Tabla(newBombi, newKocki);

                newKocki = (newKocki + 3) * 40;
                Postavi(newKocki);

                Invalidate(true);
            }
        }
    }
}
