using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongGame
{
    public class CActLine
    {
        public int x, y, w, h;
    }
    class Hero
    {
        public int x;
        public int y;
        public Bitmap img;
        public int flagimg;
        public int flaglist;

        public List<Bitmap> lwr = new List<Bitmap>();
        public List<Bitmap> lwl = new List<Bitmap>();
        public List<Bitmap> lrr = new List<Bitmap>();
        public List<Bitmap> lrl = new List<Bitmap>();
        public List<Bitmap> ljr = new List<Bitmap>();
        public List<Bitmap> ljl = new List<Bitmap>();
        public List<Bitmap> lc = new List<Bitmap>();
        public List<Bitmap> lsr = new List<Bitmap>();
        public List<Bitmap> lsl = new List<Bitmap>();




    }

    class sabar
    {
        public int x;
        public int y;
        public Bitmap img;
    }
    class makna
    {
        public int x;
        public int y;
        public Bitmap img;
        public int ctmota;
    }
    class bullety
    {
        public int x;
        public int y;
        public Bitmap img;
    }
    class bulletl
    {
        public int x;
        public int y;
        public Bitmap img;
    }
    class sheno
    {


        public int x;
        public int y;
        public Bitmap img;
        public int flagimg;
        public List<Bitmap> lsh = new List<Bitmap>();
       
    }
    class tenen
    {
        public int x;
        public int y;
        public Bitmap img;
        public int flagimg;
        public int flaglist;
        public List<Bitmap> ltny = new List<Bitmap>();
        public List<Bitmap> ltnl = new List<Bitmap>();
        public int flagmota;
    }
    class enemy
    {
        public int x;
        public int y;
        public Bitmap img;
        public int flagimg;
        public List<Bitmap> lenl = new List<Bitmap>();
        public List<Bitmap> lenr = new List<Bitmap>();
        public int flagmota;
    }
    public class CAdvActor
    {
        public Rectangle rcDst, rcSrc;
        public Bitmap img;
    }
    public partial class Form1 : Form
    {
        //hot soret l game oveer 3and kollll meesage box loser bassssssssssssssssssssssssssssssssssssssssssssssssssssss
        Bitmap win = new Bitmap("Winner.jpg");
        List<CAdvActor> LActs = new List<CAdvActor>();
        List<CAdvActor> LActsn = new List<CAdvActor>();
        List<tenen> tnn = new List<tenen>();
        List<sabar> sb = new List<sabar>();
        List<sabar> wl = new List<sabar>();
        List<sabar> st = new List<sabar>();
        List<sabar> ko = new List<sabar>();
        List<sabar> to = new List<sabar>();
        List<sabar> tr = new List<sabar>();
        List<sabar> ard2 = new List<sabar>();
        List<Hero> h = new List<Hero>();
        List<bullety> bur = new List<bullety>();
        List<bulletl> bul = new List<bulletl>();
        List<sabar> ard = new List<sabar>();
        List<sabar> ng = new List<sabar>();
        List<sheno> sh = new List<sheno>();
        List<sabar> elv = new List<sabar>();
        List<sabar> elv2 = new List<sabar>();
        List<sabar> ht = new List<sabar>();
        List<enemy> enr = new List<enemy>();
        List<enemy> enl = new List<enemy>();
        List<sabar> nrr = new List<sabar>();
        List<sabar> nrl = new List<sabar>();
        List<makna> msh = new List<makna>();
        List<sabar> nwb = new List<sabar>();
        List<CActLine> laser = new List<CActLine>();
        Timer tt = new Timer();
        Timer tt2 = new Timer();
        Bitmap off;
        int flagnzelt = 0;
        int ctenemy = 0;
        int i, w, flagelv = 0;
        int flagelv2 = 0;
        int screenboost = 10;
        int anzel = 0;
        int flagcaps;
        int ctclick;
        int fabd2harak = 0;
        int ctclick2 = 100;
        int flagxnta = 1;
        int ct;
        int flagwa2f = 0;
        int cttnen = 0;
        int awelmarasora = 0;
        int flaggrav = 1;
        int flaglaser = 0;
        int flagdown = 0;
        int flagdown2 = 0;
        int cttgroba = 0;
        int flagwall = 0;
        int xwalls;
        int flaga7a = 0;
        int flagenemies = 0;
        int awelmara = 0;
        int awelmara2 = 0;
        int flagdarkmood = 0;
        int flagteer = 0;
        int dn = 6;
        int flagsheno = 1;
        int flaghetawnta4mal = 0;
        int flaghetawntaymen = 0;
        int flagnewbullet = 0;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            this.MouseMove += Form1_MouseMove;
            tt.Tick += Tt_Tick;
            tt.Interval = 100;
            tt.Start();
            tt2.Tick += Tt2_Tick;
            tt2.Interval = 300;
            tt2.Start();


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "," + e.Y;
        }

        private void Tt2_Tick(object sender, EventArgs e)
        {
            if (h[0].flaglist == 5 && flagteer == 0)
            {
                mooveobsleft();
                mooveobsleft();
                mooveobsleft();


                if (h[0].flagimg < 3)
                {
                    h[0].flagimg++;
                    h[0].y -= 40;


                }
                else
                {
                    h[0].flagimg = 0;
                    h[0].flaglist = 1;


                }

            }
            if (h[0].flaglist == 6)
            {
                moveobsright();
                moveobsright();

                if (h[0].flagimg < 3)
                {
                    h[0].flagimg++;
                    h[0].y -= 40;


                }
                else
                {
                    h[0].flagimg = 0;
                    h[0].flaglist = 2;


                }

            }

        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            if (ctclick2 % 90 == 0)
            {

            }
            if (flagnewbullet == 1 && msh.Count > 0)
            {
                if (ctclick2 % 60 == 0)
                {
                    createnewbullets();
                  
                }
            }

            if (flagsheno == 1)
            {
                if (ctclick2 % 60 == 0)
                {
                    createshenyor();
                }

            }
            //if (ctclick2 % 10 == 0)
            //{
            //    createenemies();
            //}
            if (ctclick2 % 30 == 0)
            {
                createnar();
            }

            haraknewbullet();
            haraktnenymen();
            hataktntnshmal();
            checkloser();
            harakelv();
            harakelvtwo();
            gravity();
            harakbulletsymen();
            harakbulletsshmal();
            harakenemyymen();
            harakenemyshmal();
            checkshoot();

            //teer();
            //checkheta();
            if (ctenemy == 20)
            {
                flagwall = 0;
                flagenemies = 0;
                ht.RemoveAt(0);
                ht.RemoveAt(0);
                ctenemy++;
                //createtenen();
            }
            //if(st[1].x < -360 && ctenemy == 0)
            //{
            //    flagwa2f = 1;
            //}
            if (st[1].x < -1270)
            {
                fabd2harak = 1;
                flagnewbullet = 1;
            }
            if (st[1].x < -300 && ctenemy == 0)
            {

                flagwall = 1;
                if (ctclick2 % 50 == 0)
                {
                    flagdarkmood = 1;
                    if (awelmarasora == 0)
                    {
                        LActs.RemoveAt(0);
                        awelmarasora = 1;
                        createnewsora();

                    }


                }
                if (ctclick2 % 100 == 0)
                {
                    flagenemies = 1;
                }
            }
            if (flagenemies == 1)
            {
                if (ctclick2 % 4 == 0)
                {
                    createenemies();
                }
            }
            haraksheno();
            ctclick2++;
            DrawDubb(this.CreateGraphics());
            for (i = 0; i < laser.Count; i++)
            {
                laser.RemoveAt(0);
            }
        }
        void haraknewbullet()
        {
            for (i = 0; i < nwb.Count; i++)
            {
                nwb[i].x += 60;
            }
        }
        void createnewbullets()
        {
            int xbdaya = msh[0].x;
            for (i = 0; i < 5; i++)
            {
                sabar pnn = new sabar();
                pnn.x = xbdaya;
                pnn.y = msh[0].y;
                pnn.img = new Bitmap("Copy of shot.png");
                nwb.Add(pnn);
                xbdaya += 20;
            }
        }
        void createnar()
        {
            if (cttnen < 10)
            {
                if (fabd2harak == 1)
                {
                    if (tnn[0].flaglist == 1)
                    {
                        sabar pnn = new sabar();
                        pnn.x = tnn[0].x + 40;
                        pnn.y = tnn[0].y + 50;
                        pnn.img = new Bitmap("Copy of bulletssy.png");
                        nrr.Add(pnn);
                    }
                    if (tnn[0].flaglist == 2)
                    {
                        sabar pnn = new sabar();
                        pnn.x = tnn[0].x - 10;
                        pnn.y = tnn[0].y + 50;
                        pnn.img = new Bitmap("Copy of bulletss.png");
                        nrl.Add(pnn);
                    }
                }
            }
        }
        void hataktntnshmal()
        {
            if (fabd2harak == 1)
            {
                if (cttnen < 10)
                {
                    if (tnn[0].flaglist == 2)
                    {
                        tnn[0].x -= 6;
                        if (tnn[0].flagimg < 2)
                        {
                            tnn[0].flagimg++;
                        }
                        else
                        {
                            tnn[0].flagimg = 0;
                        }
                        if (tnn[0].x <= -10)
                        {
                            tnn[0].flaglist = 1;
                        }
                    }
                }
            }


        }
        void haraktnenymen()
        {
            if (fabd2harak == 1)
            {
                if (cttnen < 10)
                {
                    if (tnn[0].flaglist == 1)
                    {
                        tnn[0].x += 6;
                        if (tnn[0].flagimg < 2)
                        {
                            tnn[0].flagimg++;
                        }
                        else
                        {
                            tnn[0].flagimg = 0;
                        }
                        if (tnn[0].x >= 1100)
                        {
                            tnn[0].flaglist = 2;
                        }
                    }
                }
            }



        }
        int ctaho = 0;
        void createenemies()
        {
            if (ctenemy < 20)
            {
                Random r = new Random();
                int m = r.Next(0, 3);

                if (m == 1)
                {

                    enemy pnn = new enemy();

                    pnn.x = ht[0].x + 100;
                    pnn.y = this.ClientSize.Height - 126;
                    pnn.flagimg = 0;
                    pnn.flagmota = 0;
                    for (i = 0; i < 4; i++)
                    {
                        pnn.img = new Bitmap("monistarmove-0.png");
                        pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                        pnn.lenl.Add(pnn.img);
                    }
                    enl.Add(pnn);

                }
                if (m == 2)
                {
                    enemy pnn = new enemy();
                    pnn.x = ht[1].x + 20;
                    pnn.y = this.ClientSize.Height - 126;
                    pnn.flagimg = 0;
                    pnn.flagmota = 0;
                    for (i = 0; i < 4; i++)
                    {
                        pnn.img = new Bitmap("monistarmove0.png");
                        pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                        pnn.lenr.Add(pnn.img);
                    }
                    enr.Add(pnn);
                }

            }



        }
        void checkheta()
        {
            if (h[0].x + 60 > to[0].x && flagteer == 0)
            {
                flaghetawnta4mal = 1;

            }
            else
            {
                //flaghetawnta4mal= 0;
            }
            if (h[0].flaglist == 2 || h[0].flaglist == 4)
            {
                if (flagnzelt == 1 && h[0].x < to[0].x + 60)
                {
                    flaghetawntaymen = 1;
                }
                else
                {
                    //flaghetawntaymen = 0;
                }
            }
        }


        void teer()
        {
            if (h[0].x >= tr[0].x && h[0].x <= tr[0].x + tr[0].img.Width && h[0].y + 129 == tr[0].y /*&& h[0].y > to[2].y - 100*/)
            {
                flagteer = 1;
                h[0].flaglist = 5;
            }
            if (flagteer == 1)
            {
                if (h[0].flagimg < 3)
                {
                    h[0].flagimg++;
                }
                else
                {
                    h[0].flagimg = 0;
                }
                if (anzel == 0)
                {
                    h[0].y -= 9;
                    //h[0].x += 4;
                }
                if (anzel == 1)
                {

                    h[0].y += 9;
                    h[0].x -= 5;
                }
                if (h[0].y + 150 < this.ClientSize.Height)
                {
                    mooveobsleft();
                }
                if (h[0].y <= to[2].y - 125)
                {
                    anzel = 1;

                }
                if (h[0].y + 150 >= this.ClientSize.Height)
                {
                    h[0].flagimg = 1;
                    flagteer = 0;

                    flagnzelt = 1;
                }


            }

            //if (anzel !=1)
            //{
            //    if (h[0].x >= tr[0].x && h[0].x <= tr[0].x + tr[0].img.Width && h[0].y + 130 > tr[0].y && h[0].x<to[0].x)
            //    {
            //        flagteer = 1;
            //        h[0].flaglist = 5;

            //    }
            //    if (flagteer == 1)
            //    {
            //        h[0].y -= dn;
            //        h[0].x += 2;

            //        if (h[0].flagimg < 3)
            //        {
            //            h[0].flagimg++;
            //        }
            //        else
            //        {
            //            h[0].flagimg = 0;
            //        }
            //    }
            //    if (h[0].y <= to[2].y - 90)
            //    {
            //        dn = -6;
            //        anzel = 2;
            //        flagteer = 0;
            //        flagxnta = 0;
            //    }
            //    if (anzel == 2)
            //    {
            //        // h[0].y += 6;
            //        if (flagxnta == 0)
            //        {
            //            h[0].x += 2;
            //        }
            //        if (h[0].flagimg < 3)
            //        {
            //            h[0].flagimg++;
            //        }
            //        else
            //        {
            //            h[0].flagimg = 0;
            //        }
            //        if (h[0].y+150==this.ClientSize.Height)
            //        {
            //            h[0].flaglist = 1;
            //            anzel = 1;
            //        }
            //    }

            //}

        }
        void checkshoot()
        {
            if (flaglaser == 0)
            {
                if (h[0].x > ng[0].x)
                {
                    flaglaser = 1;
                    ng.RemoveAt(0);
                }
            }

            if (msh.Count > 0)
            {
                for (i = 0; i < bul.Count; i++)
                {
                    if (bul[i].x < msh[0].x + msh[0].img.Width && bul[i].y > msh[0].y && bul[i].y < msh[0].y + msh[0].img.Height)
                    {
                        msh[0].ctmota++;
                        if (msh[0].ctmota == 4)
                        {
                            msh.RemoveAt(0);
                            break;
                        }
                    }
                }
            }

            if (fabd2harak == 1)
            {
                for (i = 0; i < nwb.Count; i++)
                {
                    if (nwb[i].x > h[0].x && nwb[i].x < h[0].x + 50 && nwb[i].y+5 > h[0].y && nwb[i].y < h[0].y + 150)
                    {
                        MessageBox.Show("Loserr");
                        tt.Stop();
                    }
                }
                if (flaglaser == 1 && cttnen < 10)
                {
                    if (laser.Count > 0 && cttnen < 10)
                    {
                        if (laser[0].y > tnn[0].y + 10 && laser[0].y < tnn[0].y + 200 && cttnen<10)
                        {
                            tnn[0].flagimg = 3;
                            DrawDubb(this.CreateGraphics());
                            tnn[0].flagimg = 0;
                            cttnen++;
                            if (cttnen == 10)
                            {
                                tnn.RemoveAt(0);
                                DrawDubb(this.CreateGraphics());
                            }
                        }
                    }
                }
                for (i = 0; i < nrr.Count; i++)
                {
                    if (nrr[i].x >= h[0].x && nrr[i].x < h[0].x + 20 && nrr[i].y >= h[0].y && nrr[i].y <= h[0].y + 150)
                    {
                        MessageBox.Show("loseerr");
                        tt.Stop();

                    }
                }
                for (i = 0; i < nrl.Count; i++)
                {
                    if (nrl[i].x <= h[0].x + 20 && nrl[i].x > h[0].x && nrl[i].y >= h[0].y && nrl[i].y < h[0].y + 150)
                    {
                        MessageBox.Show("loseerr");
                        tt.Stop();
                    }

                }
                //for (i = 0; i < tnn.Count; i++)
                //{
                //    if (tnn[0].flaglist == 1)
                //    {
                //        if (tnn[0].x > h[0].x && tnn[0].y > h[0].y && tnn[0].y < h[0].y + 150)
                //        {
                //            MessageBox.Show("loserrrr");
                //        }

                //    }
                //    else
                //    {
                //        if (tnn[0].x < h[0].x && tnn[0].y > h[0].y && tnn[0].y < h[0].y + 150)
                //        {
                //            MessageBox.Show("loserrrr");
                //        }
                //    }

                //}
                for (i = 0; i < bur.Count; i++)
                {
                    if (bur[i].x >= tnn[0].x && h[0].y < 200)
                    {
                        bur.RemoveAt(i);
                    }
                }
                for (i = 0; i < bul.Count; i++)
                {
                    if (bul[i].x <= tnn[0].x + 50 && h[0].y < 200)
                    {
                        bul.RemoveAt(i);
                    }
                }
            }

            for (i = 0; i < bul.Count; i++)
            {
                for (int j = 0; j < enl.Count; j++)
                {
                    if (bul[i].x <= enl[j].x + enl[j].lenl[0].Width && bul[i].x > enl[j].x)
                    {

                        enl.RemoveAt(j);
                        bul.RemoveAt(i);
                        ctenemy++;
                        break;





                    }
                }

            }
            for (i = 0; i < bur.Count; i++)
            {
                for (int j = 0; j < enr.Count; j++)
                {
                    if (bur[i].x >= enr[j].x && bur[i].x < enr[j].x + enr[j].lenr[0].Width)
                    {

                        enr.RemoveAt(j);
                        bur.RemoveAt(i);
                        ctenemy++;
                        break;

                    }
                }

            }

        }
        void harakenemyymen()
        {

            for (i = 0; i < enl.Count; i++)
            {
                enl[i].x += 8;
                //if (enl[i].flagimg<2)
                //{
                //    enl[i].flagimg++;
                //}
                //else
                //{
                enl[i].flagimg = 0;
                // }

            }

        }
        void harakenemyshmal()
        {

            for (i = 0; i < enr.Count; i++)
            {
                enr[i].x -= 8;
                //if (enr[i].flagimg < 2)
                //{
                //    enr[i].flagimg++;
                //}
                //else
                //{
                enr[i].flagimg = 0;
                //  }

            }

        }
        void harakelv()
        {
            if (flagelv == 0)
            {
                if (elv[0].y < 150)
                {
                    flagdown = 1;
                }
                if (elv[0].y + 10 >= this.ClientSize.Height)
                {
                    flagdown = 0;

                }
                if (flagdown == 1)
                {



                    if (h[0].x > elv[0].x && h[0].x < elv[0].x + elv[0].img.Width && h[0].y + h[0].lwr[0].Height - 7 == elv[0].y)
                    {
                        h[0].y += 4;
                    }
                    elv[0].y += 4;
                }
                if (flagdown == 0)
                {


                    if (h[0].x > elv[0].x && h[0].x < elv[0].x + elv[0].img.Width && h[0].y + h[0].lwr[0].Height - 7 == elv[0].y)
                    {
                        h[0].y -= 4;
                    }
                    elv[0].y -= 4;

                }
            }



            //if (h[0].x > elv[0].x && h[0].x <= elv[0].x + elv[0].img.Width && h[0].y+145<=elv[0].y &&flagdown==0 && h[0].y < 50)
            //{
            //        flagelv = 1;
            //        h[0].y -= 4;
            //        elv[0].y -= 4;

            //}
            //if (h[0].x > elv[0].x && h[0].x <= elv[0].x + elv[0].img.Width && h[0].y + 145 <= elv[0].y && flagdown == 1&& elv[0].y>this.ClientSize.Height)
            //{
            //    flagelv = 1;
            //    h[0].y += 4;
            //    elv[0].y += 4;

            //}
            //if(h[0].x<elv[0].x || h[0].x>elv[0].x+elv[0].img.Width)
            //{
            //    flagelv = 0;
            //}






        }
        void harakelvtwo()
        {


            if (flagelv2 == 0)
            {
                if (elv2[0].y < 150)
                {
                    flagdown2 = 1;
                }
                if (elv2[0].y + 10 >= this.ClientSize.Height)
                {
                    flagdown2 = 0;

                }
                if (flagdown2 == 1)
                {



                    if (h[0].x > elv2[0].x && h[0].x < elv2[0].x + elv2[0].img.Width && h[0].y + h[0].lwr[0].Height - 7 == elv2[0].y)
                    {
                        h[0].y += 4;
                    }
                    elv2[0].y += 4;
                }
                if (flagdown2 == 0)
                {

                    if (h[0].x > elv2[0].x && h[0].x < elv2[0].x + elv2[0].img.Width && h[0].y + h[0].lwr[0].Height - 7 == elv2[0].y)
                    {
                        h[0].y -= 4;
                    }
                    elv2[0].y -= 4;

                }
            }




        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && flaghetawnta4mal == 1)
            {
                flaghetawnta4mal = 0;



            }
            if (e.KeyCode == Keys.Right && flaghetawntaymen == 1)
            {
                flaghetawntaymen = 0;
                flaga7a = 1;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (h[0].y < this.ClientSize.Height - 153)
                {
                    for (i = 0; i < st.Count; i++)
                    {
                        if (h[0].x > st[i].x && h[0].x < st[i].x + 100)
                        {
                            flagsheno = 0;
                            h[0].flaglist = 7;
                            if (h[0].flagimg < 5)
                            {
                                h[0].flagimg++;
                                h[0].y += 7;
                            }
                            else
                            {
                                h[0].flagimg = 0;

                            }
                        }
                    }

                }


            }
            if (e.KeyCode == Keys.Up)
            {

                for (i = 0; i < st.Count; i++)
                {
                    if (h[0].x > st[i].x && h[0].x < st[i].x + 100 && h[0].y + 145 > ard[0].y)
                    {
                        // h[0].flagimg = 0;
                        h[0].flaglist = 7;
                        if (h[0].flagimg < 5)
                        {
                            h[0].flagimg++;
                            h[0].y -= 7;
                        }
                        else
                        {
                            h[0].flagimg = 0;

                        }
                    }
                }



            }
            if (e.KeyCode == Keys.Z)
            {
                if (flaglaser == 1)
                {

                    createlaser();
                    checkloser();
                    //  

                }
                else
                {
                    h[0].flagimg = 0;
                    if (h[0].flaglist == 0 || h[0].flaglist == 1 || h[0].flaglist == 3 || h[0].flaglist == 8)
                    {
                        h[0].flaglist = 8;
                        createbulletsymen();
                    }
                    if (h[0].flaglist == 2 || h[0].flaglist == 4 || h[0].flaglist == 9)
                    {
                        h[0].flaglist = 9;
                        createbulletshmal();
                    }

                }




            }
            if (e.KeyCode == Keys.Space)
            {
                int z = ctclick;
                h[0].flagimg = 0;


                if (h[0].flaglist == 0 || h[0].flaglist == 1 || h[0].flaglist == 3)
                {
                    h[0].flaglist = 5;
                }
                if (h[0].flaglist == 2 || h[0].flaglist == 4)
                {
                    h[0].flaglist = 6;
                }


            }
            if (e.KeyCode == Keys.CapsLock)
            {

                if (flagcaps == 0)
                {
                    flagcaps = 1;
                    screenboost += 10;
                }
                else
                {
                    flagcaps = 0;
                    screenboost -= 10;
                }
                //if(h[0].flaglist==0|| h[0].flaglist==1)
                //{
                //    h[0].flaglist = 3;
                //}
                //if (h[0].flaglist == 2 || h[0].flagimg==3)
                //{
                //    h[0].flaglist = 4;
                //}
            }
            if (e.KeyCode == Keys.Right && flagcaps == 1)
            {
                mooveobsleft();
                h[0].flaglist = 3;
                if (h[0].flagimg < 7 && flagwall == 0 && flaghetawntaymen == 0)
                {
                    h[0].flagimg++;
                }
                else
                {
                    h[0].flagimg = 0;

                }

            }
            if (e.KeyCode == Keys.Left && flagcaps == 1)
            {
                moveobsright();
                h[0].flaglist = 4;
                if (h[0].flagimg < 7 && flagwall == 0 && flaghetawnta4mal == 0)
                {
                    h[0].flagimg++;
                }
                else
                {
                    h[0].flagimg = 0;

                }


            }

            if (e.KeyCode == Keys.Right && flagcaps == 0 && flagteer == 0)
            {
                mooveobsleft();
                h[0].flaglist = 1;
                if (h[0].flagimg < 9 && flagwall == 0 && flaghetawntaymen == 0)
                {
                    h[0].flagimg++;
                }
                else
                {
                    h[0].flagimg = 0;

                }


            }
            if (e.KeyCode == Keys.Left && flagcaps == 0 && flagteer == 0)
            {
                moveobsright();
                h[0].flaglist = 2;
                if (h[0].flagimg < 9 && flagwall == 0 && flaghetawnta4mal == 0)
                {
                    h[0].flagimg++;
                }
                else
                {
                    h[0].flagimg = 0;

                }

            }
            if (flagdarkmood == 0)
            {
                switch (e.KeyCode)
                {

                    case Keys.Right:

                        if (flagwall == 0 && flaghetawnta4mal == 0)
                        {
                            LActs[0].rcSrc.X += screenboost;
                        }
                        if (LActs[0].rcSrc.X >= LActs[0].img.Width)
                        {
                            LActs[0].rcSrc.X = 0;
                        }
                        break;
                    case Keys.Left:
                        if (LActs[0].rcSrc.X > 0 && flagwall == 0 && flaghetawntaymen == 0)
                        {
                            LActs[0].rcSrc.X -= screenboost;
                        }

                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {

                    case Keys.Right:

                        if (flagwall == 0 && flagwa2f == 0 && fabd2harak == 0)
                        {
                            LActsn[0].rcSrc.X += screenboost;
                        }
                        if (LActsn[0].rcSrc.X >= LActsn[0].img.Width)
                        {
                            LActsn[0].rcSrc.X = 0;
                        }
                        break;
                    case Keys.Left:
                        if (LActsn[0].rcSrc.X > 0 && flagwall == 0 && flagwa2f == 0 && fabd2harak == 0)
                        {
                            LActsn[0].rcSrc.X -= screenboost;
                        }

                        break;
                }
            }

            // DrawDubb(this.CreateGraphics());
        }
        void createlaser()
        {
            CActLine pnn = new CActLine();
            if (h[0].flaglist == 0 || h[0].flaglist == 1 || h[0].flaglist == 3 || h[0].flaglist == 8)
            {
                h[0].flagimg = 0;
                h[0].flaglist = 8;
                pnn.x = h[0].x + 100;
                pnn.y = h[0].y + 24;
                pnn.w = 1000;
                pnn.h = 1;

            }
            if (h[0].flaglist == 2 || h[0].flaglist == 4 || h[0].flaglist == 9)
            {
                h[0].flagimg = 0;
                h[0].flaglist = 9;
                pnn.x = 0;
                pnn.y = h[0].y + 24;
                pnn.w = h[0].x - 24; ;
                pnn.h = 1;
            }
            laser.Add(pnn);

        }
        void haraksheno()
        {

            for (i = 0; i < sh.Count; i++)
            {
                sh[i].x -= 20;

                if (sh[i].flagimg < 2)
                {
                    sh[i].flagimg++;
                }
                else
                {
                    sh[i].flagimg = 0;
                }
            }
        }
        void createshenyor()
        {
            sheno pnn = new sheno();
            pnn.x = 1500;
            pnn.y = this.ClientSize.Height - 100;
            pnn.flagimg = 0;
            for (i = 1; i < 5; i++)
            {
                Bitmap img = new Bitmap("Saw" + i + ".png");
                Color cl = img.GetPixel(0, 0);
                img.MakeTransparent(cl);
                pnn.lsh.Add(img);

            }
            sh.Add(pnn);
        }
        void checkloser()
        {
            //50
            //100
            //90 Y
            for (i = 0; i < sh.Count; i++)
            {
                if (sh[i].y <= h[0].y + 80 && h[0].x + 50 > sh[i].x && h[0].x < sh[i].x)
                {
                    tt.Stop();
                    MessageBox.Show("Loserrrrr");
                }
            }
            for (i = 0; i < enl.Count; i++)
            {
                if (enl[i].x >= 450)
                {
                    tt.Stop();
                    MessageBox.Show("loseer");
                }
            }
            for (i = 0; i < enr.Count; i++)
            {
                if (enr[i].x <= 585)
                {
                    tt.Stop();
                    MessageBox.Show("loseer");
                }
            }
            for (i = 0; i < ko.Count; i++)
            {
                if (h[0].y + 150 >= ko[i].y && h[0].x > ko[i].x && h[0].x < ko[i].x + ko[i].x + ko[i].img.Width-110)
                {
                    tt.Stop();
                    MessageBox.Show("loseer");
                }
            }

        }
        void gravity()
        {
            if (h[0].y > this.ClientSize.Height - 153)
            {
                h[0].y = this.ClientSize.Height - 153;
            }

            if (h[0].y + 145 <= ard[0].y && h[0].y + 145 <= ard[1].y && h[0].y + 145 <= ard[2].y && h[0].y + 145 <= ard[3].y && h[0].x >= ard[0].x && h[0].x < st[1].x + 100 || h[0].x >= elv[0].x && h[0].x < elv[0].x + elv[0].img.Width && h[0].y + h[0].lwr[0].Height - 3 == elv[0].y + 4 || h[0].x > st[0].x && h[0].x <= st[0].x + 100 || h[0].x > st[1].x && h[0].x <= st[1].x + 100 || h[0].x >= tr[0].x && h[0].x <= tr[0].x + tr[0].img.Width && h[0].y + 130 > tr[0].y || flagteer == 1 || h[0].x > ard2[1].x && h[0].x < ard2[1].x + ard2[1].img.Width && h[0].y + 150 >= ard2[1].y || h[0].x >= elv2[0].x && h[0].x < elv2[0].x + elv2[0].img.Width && h[0].y + h[0].lwr[0].Height - 3 == elv2[0].y + 4 || h[0].x > ard2[0].x && h[0].x < ard2[0].x + ard2[0].img.Width && h[0].y + 150 >= ard2[0].y)
            {

                flaggrav = 0;

            }
            else
            {
                flaggrav = 1;
            }

            if (flaggrav == 1)
            {
                if (h[0].y < this.ClientSize.Height - 153)
                {
                    h[0].y += 8;
                }
                
            }



        }
        void createnewsora()
        {
            for (i = 0; i < 1; i++)
            {
                CAdvActor pnn = new CAdvActor();
                pnn.img = new Bitmap("faruk-tokluoglu-l-wR6JpE8lY-unsplash.jpg");
                // pnn.img = new Bitmap("roman-datsiuk-mW_yoqe6pkM-unsplash.jpg");
                pnn.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                LActsn.Add(pnn);
            }
        }
        void harakbulletsymen()
        {
            for (i = 0; i < nrr.Count; i++)
            {
                nrr[i].x += 50;
            }

            for (i = 0; i < bur.Count; i++)
            {
                bur[i].x += 50;
            }
        }
        void harakbulletsshmal()
        {
            for (i = 0; i < nrl.Count; i++)
            {
                nrl[i].x -= 50;
            }

            for (i = 0; i < bul.Count; i++)
            {
                bul[i].x -= 50;
            }

        }
        void moveobsright()
        {
            if (flagwall == 0 && flaghetawntaymen == 0)
            {
                for (i = 0; i < sb.Count; i++)
                {
                    sb[i].x += screenboost;
                }
                for (i = 0; i < st.Count; i++)
                {
                    st[i].x += screenboost;
                }
                for (i = 0; i < ard.Count; i++)
                {
                    ard[i].x += screenboost;
                }
                for (i = 0; i < sh.Count; i++)
                {
                    sh[i].x += screenboost;
                }
                for (i = 0; i < elv.Count; i++)
                {
                    elv[i].x += screenboost;
                }
                for (i = 0; i < elv2.Count; i++)
                {
                    elv2[i].x += screenboost;
                }
                for (i = 0; i < ht.Count; i++)
                {
                    ht[i].x += screenboost;
                }
                for (i = 0; i < ko.Count; i++)
                {
                    ko[i].x += screenboost;
                }
                for (i = 0; i < to.Count; i++)
                {
                    to[i].x += screenboost;
                }
                for (i = 0; i < tr.Count; i++)
                {
                    tr[i].x += screenboost;
                }
                for (i = 0; i < ard2.Count; i++)
                {
                    ard2[i].x += screenboost;
                }
                for (i = 0; i < tnn.Count; i++)
                {
                    tnn[i].x += screenboost;
                }
                for (i = 0; i < msh.Count; i++)
                {
                    msh[i].x += screenboost;
                }
                for (i = 0; i < wl.Count; i++)
                {
                    wl[i].x += screenboost;
                }
                for (i = 0; i < ng.Count; i++)
                {
                    ng[i].x += screenboost;
                }

            }


        }
        void mooveobsleft()
        {
            if (flagnzelt == 1)
            {
                flaghetawnta4mal = 0;
            }
            if (flaga7a == 1)
            {
                flaghetawnta4mal = 0;
            }
            if (flagwall == 0 && flaghetawnta4mal == 0)
            {
                for (i = 0; i < sb.Count; i++)
                {
                    sb[i].x -= screenboost;
                }
                for (i = 0; i < st.Count; i++)
                {
                    st[i].x -= screenboost;
                }
                for (i = 0; i < ard.Count; i++)
                {
                    ard[i].x -= screenboost;
                }
                for (i = 0; i < sh.Count; i++)
                {
                    sh[i].x -= screenboost;
                }
                for (i = 0; i < elv.Count; i++)
                {
                    elv[i].x -= screenboost;
                }
                for (i = 0; i < elv2.Count; i++)
                {
                    elv2[i].x -= screenboost;
                }
                if (flagwa2f == 0)
                {
                    for (i = 0; i < ht.Count; i++)
                    {
                        ht[i].x -= screenboost;
                    }
                }

                for (i = 0; i < ko.Count; i++)
                {
                    ko[i].x -= screenboost;
                }
                for (i = 0; i < to.Count; i++)
                {
                    to[i].x -= screenboost;
                }
                for (i = 0; i < tr.Count; i++)
                {
                    tr[i].x -= screenboost;
                }
                for (i = 0; i < ard2.Count; i++)
                {
                    ard2[i].x -= screenboost;
                }
                for (i = 0; i < tnn.Count; i++)
                {
                    tnn[i].x -= screenboost;
                }
                for (i = 0; i < msh.Count; i++)
                {
                    msh[i].x -= screenboost;
                }
                for (i = 0; i < wl.Count; i++)
                {
                    wl[i].x -= screenboost;
                }
                for (i = 0; i < ng.Count; i++)
                {
                    ng[i].x -= screenboost;
                }
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawDubb(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            CreateActor();
        }
        void createbulletsymen()
        {

            bullety pnn = new bullety();
            pnn.x = h[0].x + 60;
            pnn.y = h[0].y + 24;
            pnn.img = new Bitmap("Bulletyn.jpg");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            bur.Add(pnn);

        }
        void createbulletshmal()
        {
            bulletl pnn = new bulletl();
            pnn.x = h[0].x + 5;
            pnn.y = h[0].y + 24;
            pnn.img = new Bitmap("Bulletln.jpg");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            bul.Add(pnn);

        }
        void CreateActor()
        {
            if (flagdarkmood == 0)
            {
                for (i = 0; i < 1; i++)
                {
                    CAdvActor pnn = new CAdvActor();
                    pnn.img = new Bitmap("edited.jpeg");
                    pnn.rcSrc = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                    pnn.rcDst = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);
                    LActs.Add(pnn);
                }
            }
            for (i = 0; i < 1; i++)
            {
                sabar pnn = new sabar();
                pnn.x = 1500;
                pnn.y = this.ClientSize.Height - 75;
                pnn.img = new Bitmap("1547649531-CpHwlkgRAO.png");
                sb.Add(pnn);
            }

            int xst = 2050;
            for (i = 0; i < 2; i++)
            {
                sabar pnn = new sabar();
                pnn.x = xst;
                pnn.y = 400;
                pnn.img = new Bitmap("stairs_full.png");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                st.Add(pnn);
                xst += 900;
            }
            int xard = 2050;
            for (i = 0; i < 4; i++)
            {
                sabar pnn = new sabar();
                pnn.x = xard;
                pnn.y = 380;
                pnn.img = new Bitmap("ard.png");
                //  pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                ard.Add(pnn);
                xard += 250;
            }
            int xb = st[0].x + st[0].img.Width + 5;
            for (i = 0; i < 3; i++)
            {
                sabar pnn = new sabar();
                pnn.x = xb;
                pnn.y = this.ClientSize.Height - 35;
                pnn.img = new Bitmap("D6.png");
                ko.Add(pnn);
                xb += pnn.img.Width;

            }
            int yht = this.ClientSize.Height - 75;
            for (i = 0; i < 3; i++)
            {
                sabar pnn = new sabar();
                pnn.x = 1100;
                pnn.y = yht;
                pnn.img = new Bitmap("Copy of tile73.png");
                to.Add(pnn);
                yht -= pnn.img.Height;

            }
            int xardb3ed = 5000;
            for (i = 0; i < 2; i++)
            {
                sabar pnn = new sabar();
                pnn.x = xardb3ed;
                pnn.y = 450;
                pnn.img = new Bitmap("goodwall.png");
                ard2.Add(pnn);
                xardb3ed += 1000;

            }
            for (i = 0; i < 1; i++)
            {
                sabar pnn = new sabar();
                pnn.x = 750;
                pnn.y = this.ClientSize.Height - 40;
                pnn.img = new Bitmap("Copy of Untitled-1.png");
                tr.Add(pnn);
            }
            for (i = 0; i < 1; i++)
            {
                sabar pnn = new sabar();
                pnn.x = 5300;
                //pnn.x = 600;
                //pnn.y = this.ClientSize.Height - 10;
                pnn.y = 400;
                pnn.img = new Bitmap("Transporter4.png");
                elv2.Add(pnn);
            }
            for (i = 0; i < 1; i++)
            {
                sabar pnn = new sabar();
                pnn.x = 5900;
                //pnn.x = 400;
                //pnn.y = this.ClientSize.Height - 10;
                pnn.y = 100;
                pnn.img = new Bitmap("Transporter4.png");
                elv.Add(pnn);
            }
            int xwalls = 3200;
            for (i = 0; i < 2; i++)
            {

                sabar pnn = new sabar();
                pnn.x = xwalls;
                pnn.y = this.ClientSize.Height - 285;
                pnn.img = new Bitmap("images-removebg-preview.png");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                ht.Add(pnn);
                xwalls += 1050;
                ctaho++;
            }
            for (i = 0; i < 1; i++)
            {
                tenen pnn = new tenen();
                pnn.x = 5000;
                pnn.y = 50;
                pnn.flagmota = 0;
                pnn.flaglist = 1;
                pnn.flagimg = 0;
                for (i = 0; i < 4; i++)
                {
                    Bitmap img = new Bitmap("Copy of g" + i + ".png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.ltny.Add(img);
                }
                for (i = 0; i < 4; i++)
                {
                    Bitmap img = new Bitmap("Copy of gl" + i + ".png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.ltnl.Add(img);
                }
                tnn.Add(pnn);
            }
            for (i = 0; i < 1; i++)
            {
                makna pnn = new makna();
                pnn.x = 5000;
                pnn.y = ard[0].y;
                pnn.ctmota = 0;
                pnn.img = new Bitmap("machine.png");
                msh.Add(pnn);
            }
            int xwl = ard2[0].x - 5;
            for (i = 0; i < 4; i++)
            {
                sabar pnn = new sabar();
                pnn.x = xwl;
                pnn.y = this.ClientSize.Height - 200;
                pnn.img = new Bitmap("Copy of ww.png");
                wl.Add(pnn);
                if (i == 0)
                {
                    xwl = ard2[0].x + ard2[0].img.Width + 40;
                }
                if (i == 1)
                {
                    xwl = ard2[1].x - 5;
                }
                if (i == 2)
                {
                    xwl = ard2[1].x + ard2[1].img.Width + 40;
                }
            }
            for (i = 0; i < 1; i++)
            {
                sabar pnn = new sabar();
                pnn.x = ard2[1].x + 140;
                pnn.y = ard2[1].y - 75;
                pnn.img = new Bitmap("Copy of Sawdoor.png");
                ng.Add(pnn);
            }


            for (i = 0; i < 1; i++)
            {
                Hero pnn = new Hero();
                pnn.x = 515;
                pnn.y = this.ClientSize.Height - 153;
                pnn.flagimg = 0;
                pnn.flaglist = 0;
                for (i = 1; i < 11; i++)
                {
                    Bitmap img = new Bitmap("walk" + i + "R.png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.lwr.Add(img);
                }
                for (i = 1; i < 11; i++)
                {
                    Bitmap img = new Bitmap("walk" + i + "L.png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.lwl.Add(img);
                }
                for (i = 1; i < 9; i++)
                {
                    Bitmap img = new Bitmap("run-" + i + ".png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.lrr.Add(img);

                }
                for (i = 1; i < 9; i++)
                {
                    Bitmap img = new Bitmap("run" + i + ".png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.lrl.Add(img);

                }
                for (i = 1; i < 5; i++)
                {
                    Bitmap img = new Bitmap("jump-" + i + ".png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.ljr.Add(img);

                }
                for (i = 1; i < 5; i++)
                {
                    Bitmap img = new Bitmap("jump" + i + ".png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.ljl.Add(img);

                }

                for (i = 0; i < 1; i++)
                {
                    Bitmap img = new Bitmap("shoot.png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.lsr.Add(img);
                }
                for (i = 0; i < 1; i++)
                {
                    Bitmap img = new Bitmap("shootl.png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.lsl.Add(img);
                }
                for (i = 1; i < 7; i++)
                {
                    Bitmap img = new Bitmap("climb-" + i + ".png");
                    Color cl = img.GetPixel(0, 0);
                    img.MakeTransparent(cl);
                    pnn.lc.Add(img);
                }



                h.Add(pnn);


            }


        }
        void DrawScene(Graphics g)
        {
            //1=walkymen
            //2=walk4mal
            //3=runymen
            //4=run4emal
            //5=jumnbymen
            //6=jumb4mal
            //7=climb
            //8=shotright
            //9=shootlelft
            //62X150 L HEROO

            g.Clear(Color.Black);

            if (flagdarkmood == 0)
            {
                for (int i = 0; i < LActs.Count; i++)
                {
                    if (LActs[i].rcSrc.X + ClientSize.Width > LActs[i].img.Width)
                    {
                        //1
                        int cxRem = LActs[i].img.Width - LActs[i].rcSrc.X;
                        Rectangle Dst1 = new Rectangle(0, 0, cxRem, ClientSize.Height);
                        Rectangle Src1 = new Rectangle(LActs[i].rcSrc.X, 0, cxRem, ClientSize.Height);
                        g.DrawImage(LActs[i].img, Dst1, Src1, GraphicsUnit.Pixel);
                        //2
                        int cxRem2 = ClientSize.Width - cxRem;
                        Rectangle src2 = new Rectangle(0, 0, cxRem2, ClientSize.Height);
                        Rectangle Dst2 = new Rectangle(cxRem, 0, cxRem2, ClientSize.Height);
                        g.DrawImage(LActs[i].img, Dst2, src2, GraphicsUnit.Pixel);
                    }
                    else
                    {
                        g.DrawImage(LActs[i].img, LActs[i].rcDst, LActs[i].rcSrc, GraphicsUnit.Pixel);
                    }
                }

            }
            else
            {
                for (int i = 0; i < LActsn.Count; i++)
                {
                    if (LActsn[i].rcSrc.X + ClientSize.Width > LActsn[i].img.Width)
                    {
                        //1
                        int cxRem = LActsn[i].img.Width - LActsn[i].rcSrc.X;
                        Rectangle Dst1 = new Rectangle(0, 0, cxRem, ClientSize.Height);
                        Rectangle Src1 = new Rectangle(LActsn[i].rcSrc.X, 0, cxRem, ClientSize.Height);
                        g.DrawImage(LActsn[i].img, Dst1, Src1, GraphicsUnit.Pixel);
                        //2
                        int cxRem2 = ClientSize.Width - cxRem;
                        Rectangle src2 = new Rectangle(0, 0, cxRem2, ClientSize.Height);
                        Rectangle Dst2 = new Rectangle(cxRem, 0, cxRem2, ClientSize.Height);
                        g.DrawImage(LActsn[i].img, Dst2, src2, GraphicsUnit.Pixel);
                    }
                    else
                    {
                        g.DrawImage(LActsn[i].img, LActsn[i].rcDst, LActsn[i].rcSrc, GraphicsUnit.Pixel);
                    }
                }

            }

            //for(i=0;i<sb.Count;i++)
            //{
            //    g.DrawImage(sb[i].img, sb[i].x, sb[i].y);
            //}
            for (i = 0; i < bur.Count; i++)
            {
                g.DrawImage(bur[i].img, bur[i].x, bur[i].y);
            }
            for (i = 0; i < wl.Count; i++)
            {
                g.DrawImage(wl[i].img, wl[i].x, wl[i].y); ;
            }
            for (i = 0; i < bul.Count; i++)
            {
                g.DrawImage(bul[i].img, bul[i].x, bul[i].y);
            }
            for (i = 0; i < st.Count; i++)
            {
                g.DrawImage(st[i].img, st[i].x, st[i].y);
            }
            for (i = 0; i < ard.Count; i++)
            {
                g.DrawImage(ard[i].img, ard[i].x, ard[i].y);
            }
            for (i = 0; i < sh.Count; i++)
            {
                w = sh[0].flagimg;
                g.DrawImage(sh[i].lsh[w], sh[i].x, sh[i].y);
            }
            for (i = 0; i < elv.Count; i++)
            {
                g.DrawImage(elv[i].img, elv[i].x, elv[i].y);
            }
            for (i = 0; i < elv2.Count; i++)
            {
                g.DrawImage(elv2[i].img, elv2[i].x, elv2[i].y);
            }
            for (i = 0; i < ht.Count; i++)
            {
                g.DrawImage(ht[i].img, ht[i].x, ht[i].y);
            }
            for (i = 0; i < enl.Count; i++)
            {
                w = enl[i].flagimg;
                g.DrawImage(enl[i].lenl[w], enl[i].x, enl[i].y);
            }
            for (i = 0; i < enr.Count; i++)
            {
                w = enr[i].flagimg;
                g.DrawImage(enr[i].lenr[w], enr[i].x, enr[i].y);
            }
            for (i = 0; i < ko.Count; i++)
            {
                g.DrawImage(ko[i].img, ko[i].x, ko[i].y);
            }
            //for (i = 0; i < to.Count; i++)
            //{
            //    g.DrawImage(to[i].img, to[i].x, to[i].y);
            //}
            //for (i = 0; i < tr.Count; i++)
            //{
            //    g.DrawImage(tr[i].img, tr[i].x, tr[i].y);
            //}
            for (i = 0; i < ard2.Count; i++)
            {
                g.DrawImage(ard2[i].img, ard2[i].x, ard2[i].y);
            }
            for (i = 0; i < nrr.Count; i++)
            {
                g.DrawImage(nrr[i].img, nrr[i].x, nrr[i].y);
            }
            for (i = 0; i < nrl.Count; i++)
            {
                g.DrawImage(nrl[i].img, nrl[i].x, nrl[i].y);
            }
            for (i = 0; i < msh.Count; i++)
            {
                g.DrawImage(msh[i].img, msh[i].x, msh[i].y);
            }
            for (i = 0; i < nwb.Count; i++)
            {
                g.DrawImage(nwb[i].img, nwb[i].x, nwb[i].y);
            }
            for (i = 0; i < ng.Count; i++)
            {
                g.DrawImage(ng[i].img, ng[i].x, ng[i].y);
            }

            for (int i = 0; i < laser.Count; i++)
            {
                Pen brush = new Pen(Color.YellowGreen);
                if (h[0].flaglist == 0 || h[0].flaglist == 1 || h[0].flaglist == 3 || h[0].flaglist == 8)
                {
                    g.DrawRectangle(brush, laser[i].x, laser[i].y, laser[i].w, laser[i].h);
                }
                if (h[0].flaglist == 2 || h[0].flaglist == 4 || h[0].flaglist == 9)
                {
                    g.DrawRectangle(brush, laser[i].x, laser[i].y, laser[i].w, laser[i].h);
                }

            }


            for (i = 0; i < h.Count; i++)
            {

                if (h[0].flaglist == 1 || h[0].flaglist == 0)
                {
                    w = h[0].flagimg;

                    g.DrawImage(h[i].lwr[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 2)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].lwl[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 3)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].lrr[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 4)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].lrl[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 5)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].ljr[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 6)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].ljl[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 8)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].lsr[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 9)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].lsl[w], h[i].x, h[i].y);
                }
                if (h[0].flaglist == 7)
                {
                    w = h[0].flagimg;
                    g.DrawImage(h[i].lc[w], h[i].x, h[i].y);
                }


            }
            for (i = 0; i < tnn.Count; i++)
            {
                if (tnn[0].flaglist == 1)
                {
                    w = tnn[0].flagimg;
                    g.DrawImage(tnn[i].ltny[w], tnn[i].x, tnn[i].y);
                }
                if (tnn[0].flaglist == 2)
                {
                    w = tnn[0].flagimg;
                    g.DrawImage(tnn[i].ltnl[w], tnn[i].x, tnn[i].y);
                }

            }
            if(cttnen==10)
            {
                g.DrawImage(win, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
                
            }


        }
        void DrawDubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            DrawScene(g2);
            g.DrawImage(off, 0, 0);

        }

    }
}
