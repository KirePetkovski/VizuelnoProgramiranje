#1.Правила и начин на игра


   Загатка видео-игри (puzzle) сочинуваат уникатен жанр на видео-игри кои нагласуваат решавање на загатки. Жанрот е многу обемен, но обично вклучува одредено ниво на апстракција и може да ги користи боите, облиците, броевите, физиката или сложените правила. За разлика од многу видео игри, загатка видео-игрите често ги користат „животите“на обиди за решавање на проблемот. Во овој тип на игра припаѓа minesweeper и целта на играта е да се отворат сите полиња кои не содржат мина. Доколку се отвори поле кое содржи мина играта завршува и се прикажуваат останатите полиња кои содржат мини. Мините можат да се пронајдат со помош на броевите кој се наоѓаат во полињата. Броевите даваат информација за мините во сосеството, односно тие се податок кој покажуваат колку мини се наоѓаат во осумте соседни полиња. Празните полиња покажуваат дека во соседните полиња не се наоѓа мина. Соседните осум полиња се безбени да се отворат, па самата програма ги отвара полињата. За да се одбегне кликнување на поле исполнето со мина може да се означи со десното копче на глувчето, а за бришењето на ознаката е овозможено со повторно кликнување на десното копче на глувчето.

   Таблата за игра може да се креира со четири критериуми: почетнички, среден, професионален и сопствена опција.
*	Почетничката табла содржи 9 редици и 9 колони, односно 81 поле исполнети со 10 мини. 
*	Средната табла содржи 16 редици и 16 колони, односно 256 полиња исполнети со 40 мини.
*	Почетничката табла содржи 22 редици и 22 колони, односно 484 полиња исполнети со 100 мини. 
*	Сопстената опција е ограничена со редици и колони меѓу 9 и 22, исполнети со 121 можни мини. Дополнителе услов, бројот на мини не смее да биде поголем од една четвртина од бројот на полиња.


#2.Изглед на програмата

###2.1.Почетно мени

   На почетното мени се поставени четири копчиња. Копчињата содржат исти наредби, но со различни вредности за креирањето на таблата зависно од степенот на играта. Ја повикуваат метода Postavi(int Golemina) која содржи наредби за изгледот на формата. Односно, копчињата стануваат невидливи, формата на апликацијата се зголемува и се создава област за графика. Во наредната наредба на копчињата, ќе го повикаат конструкторот на класта Tabla со соодветни на параметри на критериумот кој сме го одбрале. Конструкторот добива информации за ширина на таблата и бројот на мини.

###2.2.Цртање на таблата

   Откако ќе се дефинираат и декларираат променливите во класата Tabla, следува процесот на цртање на таблата. Креирана е класата Rect која ги содржи методите за цртање на коцка, круг (мина) и број. Коцката е обоена темно зелена (ако полето е затворено) и бела (ако полето е отворено, односно било кликнато на него). Броевите се впишиваат врз отворени полиња и го означува бројот на мини кој ги има во неговите осум соседни полиња. Кругот означува дека има мина во полето. Круговите се исцртуваат само кога играта е изгубена, односно е кликнато на поле со мина.    
   Конструкторот на класата Rect прима два аргументи кој се целобројни. Ги означуваат координатите на полето. Истите се множат со 40 за да ја испечати коцката на точната позиција во формата. Висината и ширината на една коцка е 40 пиксели. Според истиот принцит се исцртуваат полињата кои се кликнати. Преку методата void panel_MouseClick ги зима координатите на кликнатата позиција врз формата и ги дели со 40. Добиените вредности се користат како индекси со кои се ажурираат низите од класата Tabla. Доколку е кликнато на поле кое во соседните осум полиња нема мина, ќе се отворат соседните полиња. Ќе продолжи да ги отвара соседните полиња се додена не најде поле кое е исполнето со некоја цифра или до границата на таблата. 
   
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


###2.3.Паѓачко мени 

   Поставени се две паѓачки менија, Прозорец и Игра. Во Прозорец, методата за Почетно мени содржи наредби преку кои ширината и висината на формата се намалуваат. Исто така, копчињата ги прави видливи. Методата btnKreiraj_Click е рефеденца до копчето Креирај и менито Креирај игра. Со повикување на методата се отвара нова форма за создавање на сопствен критериум за игра. Според дадените услови за играта, бројот на „коцки“ во еден ред и колона мода да биде помеѓу 9 и 22. Односно, бројот на полиња не смее да биде помал од 25 и поголем од 484. Минималниот број на мини е 5, а максималниот број е една четвртина од бројот на полиња на таблата. Методата за излез содржи една наредба за исклучување на апликацијата.
   Паѓачкото мени Игра содржи три методи со кои се ажурираат дводимензионалните низи сместени во класата Tabla. Методата за Нова игра ги користи истите наредби како и наредбите во копчињата. Создава нова табла на играње со истите критериуми за игра. Методата Покажи ги бомбите ја повикува методата KrajNaIgrata која се наоѓа во класта Tabla. Методата за менито Играј одново содржи наредби преку кој ги ресетира низите Otvoreno и Zname. Односно оваа методота ги затвара сите отворени полиња и ги брише поставените знамиња.

#3.Класа Tabla

###3.1.Податочни структури

   Преку класата Tabla се креира играта и го контролира текот на играта. Дводимензионалните низи Bomba, Zname и Otvoreno чуваат информации за полињата на таблата. Индексите на низите ги означуваат полињата. Во конструкторот на класта, се декларираат точно број на индекси колку што се потребни коцки за да се нацрта таблата.  Со кликање на некое поле, програмата ги знае индексите на полето со делење на координатите на кликнатата позиција со 40. Доколку не е кликнато на поле со мина, низите Zname и Otvoreno ќе ги ажурираат своите вредности. Низата Bomba не се ажурира во текот на програмата. Во неа се чуваат индексите на полињата кои се исполнети со мина. Додавањето на мини во програмата е овозможено со помош на променливите r1 и r2 кои имаат некоја случајна вредност (не поголема од вредноста на kocki) и служат како индекси на дводимензионалната низа Bomba. Променливите Bombi и Kocki се влезни аргументи на конструкторот и преку нив класата бобива информации за комплексноста на играта. 
   
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


###3.2.Метода KrajNaIgrata

   Методата го блокира конвертирањето од програмските координати во индекси на низа. Во овој дел не работи дејството со кликовите, односно доколку кликнете на некое затворено поле или доколку го означите како знаме, нема да се изврши дејството. Оваа метода се повикува кога играта е изгубена, кога сте кликнале на затворено поле кое содржи мина или сте притиснале од паѓачкото мени Играј => Покажи ги бомбите. Пред повикот на методата поставена е наредба за прозорец со информација дека играта е завршена. Овозможено е започнување на нова игра, со креирање на нова табла.
   
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

###3.3.Метода PecatiBroevi

   Методата PecatiBroevi ги добива соодветните индекси кои одговараат на координатите на последното кликнато поле. Нејзината улога е да ги отвори сите соседни полиња и ако некое од нив е празно, односно не содржи број или мина, самата функција се повикува со индекси на тоа поле. На овој начин се врши рекурзија. На почеток на методата се повикува функцијата IzbrojBombi. Вредноста која ја враќа функцијата одговара на бројот на соседни полиња кои содржат мина. Полето не содржи број, односно во сосеството нема мина, само ако оваа функција врати вредност 0. Во наредните наредби проверува дали полето кое е кликнато не содржи број. Ако условот е точен, се отвара тоа поле и преку два for циклуси почнувајќи од вредноста -1 до вредноста 1 се отвараат затворените соседни полиња кои не се означени со знаме. Следно, проверува дали тоа соседно поле содржи број или знаме. Доколку полето не е означено со знаме и полето е исполнето со број, затвореното поле се отвара и се црта со бела боја. Рекурзијата трае се додека има затворено соседно поле кое не содржи број или стигне до границата на таблата. Играта е освоена кога полињата кои содржат мина ќе бидат означени со црвено поле и сите останати полиња ќе бидат отворени. Односно кога променливата BroiPolinja ќе има вредност која е еднаква на бројот на полињата на таблата. За најава дека играта е освоена се појавува прозорче со порака: „Честитки! Ги пронајдовте мините.“


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
                        if ((x >= 0) && (x < Kocki) && (y >= 0) && (y < Kocki) && (Otvoreno[x, y] == false) && (Zname[x, y] == false))
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



