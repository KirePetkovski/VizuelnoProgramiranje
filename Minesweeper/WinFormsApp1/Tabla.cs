using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WinFormsApp1
{
    public class Tabla
    {
        //cuvanje i azuriranje na podatocite na tablata
        public Boolean[,] Bomba { get; set; }
        public Boolean[,] Zname { get; set; }
        public Boolean[,] Otvoreno { get; set; }

        //vlezni argumenti za kreiranje na tablata
        public int Bombi { get; set; }
        public int Kocki { get; set; }

        //proverka na otvoreni polinja
        public int BroiPolinja { get; set; }

        //odreduvanje na proizvolni koordinati
        //na polinjata so mini
        private Random rnd = new Random();
        private int r1, r2;

        public Tabla(int Bombi, int Kocki)
        {
            this.Bombi = Bombi;
            this.Kocki = Kocki;
            this.BroiPolinja = Bombi;

            this.Bomba = new Boolean[Kocki, Kocki];
            this.Zname = new Boolean[Kocki, Kocki];
            this.Otvoreno = new Boolean[Kocki, Kocki];

            for (int i = 0; i < Kocki; i++)
            {
                for (int j = 0; j < Kocki; j++)
                {
                    Bomba[i, j] = false;
                    Zname[i, j] = false;
                    Otvoreno[i, j] = false;
                }
            }
            int count = 0;

            while (count < Bombi)
            {
                r1 = rnd.Next(0, Kocki - 1);
                r2 = rnd.Next(0, Kocki - 1);

                if (Bomba[r1, r2] == false)
                {
                    Bomba[r1, r2] = true;
                    count++;

                }
            }
        }

        public void KrajNaIgrata(Graphics g)
        {
            for (int i = 0; i < Kocki; i++)
            {
                for (int j = 0; j < Kocki; j++)
                {                                               
                    if (Bomba[i, j])                        //za sekoe pole proveruva dali e mina 
                    {
                        Rect rectangle = new Rect(i, j);
                        rectangle.DrawMina(g);              //dokolku poleto ima mina se crta krug
                    }
                }
            }
        }

        public int izbrojBombi(int coorX, int coorY)
        {
            int okolina = 0;
            int x, y;

            for (var i = -1; i <= 1; i++)
            {
                for (var j = -1; j <= 1; j++)
                {
                    if ((i == 0) && (j == 0)) { continue; }
                    x = coorX + i;
                    y = coorY + j;
                    if ((x >= 0) && (x < Kocki) && (y >= 0) && (y < Kocki))
                    {
                        if (Bomba[x, y] == true)
                            okolina++;
                    }

                }
            }

            return okolina;
        }

        public void PecatiBroevi(int coorX, int coorY, Graphics g)
        {
            BroiPolinja++;                                  //gi broi otvorenite polinja

            int okolina = izbrojBombi(coorX, coorY);        //go pomni brojot na mini vo sosestvoto  
            int x = 0, y = 0;                               //pomoshni indeksi

            Otvoreno[coorX, coorY] = true;                  //zapomni deka poleto e otvoreno

            Rect rectangle = new Rect(coorX, coorY);        
            rectangle.DrawOtvorena(g);                  

            if (okolina == 0)
            {                                               //dokolku nema mina vo sosednite 8 polinja
                for (var i = -1; i <= 1; i++)               //gi izminuva sosednite polinja 
                {
                    for (var j = -1; j <= 1; j++)
                    { 
                        if ((i == 0) && (j == 0)) continue;      //skokni gi indeksite na vcitanoto pole
                       
                        x = coorX + i;          
                        y = coorY + j;

                        //ako poleto posto proveri dali e zatvoreno
                        if ((x >= 0) && (x < Kocki) && (y >= 0) && (y < Kocki) && (Otvoreno[x, y] == false)&&(Zname[x, y] == false))
                        {
                            PecatiBroevi(x, y, g);              //povtorija funkcijata za sosednoto pole
                        }
                    }
                }
            }
            else
            {                                                   //ako okolina e pogolema od 0 togash
                rectangle.DrawBroj(g, okolina.ToString());      //prikazi go brojot
            }
            rectangle.Draw(g);                                  //nacrtaj linii vrz poleto
        }

    }
}

