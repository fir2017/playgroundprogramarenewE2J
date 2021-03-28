using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float px = 10;
        float py = 10;
        float ax = 10;
        float ay = 10;
        float gs = 20;
        float tc = 20;
        float xv = 0;
        float yv = 0;
        Random rnd = new Random();


        public class pair {
            public pair(){}
            public pair(float a, float b){x = a; y = b;}
            public float x;
            public float y;
        }
        List< pair > tail = new List<pair>(5);

        void fshift(ref List<pair> x)
        {
            pair tmp = x[x.Count-1];
            for (int i = x.Count-1; i >= 0; i--)
            {


                x[x.Count - i] = x[x.Count - (i - 1)];
                
            }
            x[0] = tmp;
        }

        void game()
        {
            px += xv;
            py += yv;
            if (px < 0)
            {
                px = tc - 1;
            }
            if (px > tc - 1)
            {
                px = 0;
            }
            if (py == 0)
            {
                py = tc - 1;
            }
            if (py == tc - 1)
            {
                py = 0;
            }
            userControl11.g.DrawRectangle(userControl11.p, 0, 0, userControl11.Width, userControl11.Height);

            for (int i = 0; i < tail.Count - 1; i++)
            {
                userControl11.g.DrawRectangle(userControl11.p, (float)tail[i].x * gs, (float)tail[i].y * gs, (float)gs - 2, (float)gs - 2);
               
                //array or queue or stack needed
                if(tail[i].x==px && tail[i].y==py){
                //tail=5;

                }

                tail.Add( new pair(px,  py));
                while (tail.Count > 5)
                {
                   fshift(ref tail);
                }


                if (ax == px && ay == py)
                {
                    // tail++;
                    ax = (float)Math.Floor(rnd.Next(6) * tc);
                    ay = (float)Math.Floor(rnd.Next(6) * tc);
                }

                userControl11.g.DrawRectangle(userControl11.p, (float)ax * gs, (float)ay * gs, (float)gs - 2, (float)gs - 2);
            }
            userControl11.Refresh();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (; ; )
            { 
                game();
                Thread.Sleep(5);
            }
        }

        private void userControl11_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    xv = -1; yv = 0;
                    break;
                case Keys.D:
                    xv = 0; yv = -1;
                    break;
                case Keys.W:
                    xv = 1; yv = 0;
                    break;
                case Keys.S:
                    xv = 0; yv = -1;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    xv = -1; yv = 0;
                    break;
                case Keys.D:
                    xv = 0; yv = -1;
                    break;
                case Keys.W:
                    xv = 1; yv = 0;
                    break;
                case Keys.S:
                    xv = 0; yv = -1;
                    break;
            }
            this.Text = e.KeyCode.ToString();
        }
    }
}
