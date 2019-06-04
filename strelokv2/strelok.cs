using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strelokv2
{
    public partial class Strelok : Form
    {
        public Random r = new Random();
        public static Graphics g;
        public static int a = 0, b = 0, a1, b1, x, y, with, heght;
        public static int trai = 0;
        public static int count;
        public static int hitcount = 0;
        List<Player> playersList = new List<Player>();

        Check[] array = new Check[6];
        struct Col
        {
            public int r;
            public int g;
            public int b;
        }

        struct Check
        {
            public Col c;
            public int ball;
        }

        public Strelok()
        {
            InitializeComponent();
            LoginForm lf = new LoginForm();
            Col[] suck = new Col[6];
            suck[0].r = 0; suck[0].g = 0; suck[0].b = 0; suck[1].r = 255; suck[1].g = 255; suck[1].b = 255;
            suck[2].r = 0; suck[2].g = 0; suck[2].b = 255; suck[3].r = 188; suck[3].g = 33; suck[3].b = 33;
            suck[4].r = 255; suck[4].g = 243; suck[4].b = 67; suck[5].r = 19; suck[5].g = 19; suck[5].b = 19;
            for (int i = 0; i < 6; i++)
            {
                array[i].ball = i+1;
                array[i].c.r = suck[i].r;
                array[i].c.g = suck[i].g;
                array[i].c.b = suck[i].b;
            }   
            lf.ShowDialog();
        }

        #region prog

        public void trycount()
        {
            attempt.Text = Convert.ToString("Попытка №" + " " + (trai + 1));
            hit.Text = Convert.ToString("Попаданий" + " " + hitcount +" " + "очков" + " " + count);
        }

        public void point()
        {
            pointreset();
            a = r.Next(20, 350);
            b  = r.Next(20, 350);
            int with = 5, heght = 5;
            SolidBrush brush = new SolidBrush(Color.Green);
            g.DrawEllipse(Pens.Green, a, b, with, heght);
            g.FillEllipse(brush, a, b, with, heght); 
        }

        public void pointreset()
        {
            a1 = a; b1 = b;
            int with = 5, heght = 5;
            SolidBrush brush1 = new SolidBrush(Color.LightSteelBlue);
            g.DrawEllipse(Pens.LightSteelBlue, a1, b1, with, heght);
            g.FillEllipse(brush1, a1, b1, with, heght);
        }

        public void field()
        {
            
            g.DrawLine(new Pen(Color.Red, 5), new Point(0, 0), new Point(800, 0));

            g.DrawLine(new Pen(Color.Red, 5), new Point(0, 0), new Point(0, 460));
            int x1 = 40, x2 = 40, y1 = 0, y2 = 10;
            for (int i = 0; i < 40; i++)
            {
                g.DrawLine(new Pen(Color.Red, 2), new Point(x1, y1), new Point(x2, y2));
                x1 += 40; x2 += 40;
            }
            int x3 = 0, y3 = 40, x4 = 10, y4 = 40;
            for (int i = 0; i < 28; i++)
            {
                g.DrawLine(new Pen(Color.Red, 2), new Point(x3, y3), new Point(x4, y4));
                y3 += 40; y4 += 40;
            }
        }

        /*public void target()
        {
            SolidBrush[] br = { new SolidBrush(Color.FromArgb(40,40,40)), new SolidBrush(Color.FromArgb(255,255,255)), new SolidBrush(Color.FromArgb(38,38,38)),
                                new SolidBrush(Color.FromArgb(254,254,254)), new SolidBrush(Color.FromArgb(36,36,36)), new SolidBrush(Color.FromArgb(252,252,252)),
                                new SolidBrush(Color.FromArgb(34,34,34)),  new SolidBrush(Color.FromArgb(250,250,250)),  new SolidBrush(Color.FromArgb(32,32,32)),
                                new SolidBrush(Color.FromArgb(248,248,248))};
            int x = 350;
            int y = 150;
            int width = 200; int height = 200;
            for (int i = 0; i <= 9; i++)
            {
                g.DrawEllipse(Pens.Black, x, y, width, height);
                g.FillEllipse(br[i], x, y, width, height);
                height -= 24; width -= 24;
                x += 12; y += 12;
            }          
        }*/

        public void shoot()
        {
             x = Convert.ToInt32(textBoxX.Text) + a;
             y = Convert.ToInt32(textBoxY.Text) + b;

            SolidBrush brush = new SolidBrush(Color.Pink);
            g.DrawEllipse(Pens.Black, x, y, with, heght);
            g.FillEllipse(brush, x, y, 10, 10);
            Bitmap bi = new Bitmap(panel1.BackgroundImage);
            if (Math.Pow(x - 610, 2) + Math.Pow(y - 315, 2) <= 10000)
            {
                hitcount++;
                Win();
                MessageBox.Show("Попал");
                for (int i = 0; i < 6; i++)
                {
                    if (array[i].c.r == bi.GetPixel(x, y).R && array[i].c.g == bi.GetPixel(x, y).G && array[i].c.b == bi.GetPixel(x, y).B)
                    {
                        count += array[i].ball;
                        
                    }
                }
            }
            else MessageBox.Show("Не попал");
                     
            trai++;
            trycount();
            //battleshootingxyToolStripMenuItem.Enabled = true;


        }

        private void ruleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.Show();

            
        }

        private void рейтингToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "";
            int n;
            if (playersList.Count < 10)
                n = playersList.Count;
            else n = 10;
            for (int i = 0; i < n; i++)
            {
                str += playersList[i].name + " " + playersList[i].score.ToString() + "\n";
            }
            MessageBox.Show(str);
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X+" "+ e.Y);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("score.txt");
            for (int i = 0; i < playersList.Count; i++)
            {
                sw.WriteLine(playersList[i].name + " " + playersList[i].score);
            }
            sw.Write("STOP");
            sw.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelLogin.Text = LoginForm.login;
            FileRead();
            trycount();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();
           // g = Graphics.FromImage(panel1.BackgroundImage);

            point();
            field();
            //target();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxX.Text !="" && textBoxY.Text !="")
            {
                shoot();
                textBoxX.Text = "";
                textBoxY.Text = "";
                
                
                
               // MessageBox.Show(bi.GetPixel(x,y).R.ToString()+ " " + bi.GetPixel(x, y).G.ToString()+ " " + bi.GetPixel(x, y).B.ToString());
                
                point();
            }
            
        }

        #endregion

        
        private void FileRead()
        {
            StreamReader sr = new StreamReader("score.txt");
            string s = sr.ReadLine();
            while (s != "STOP")
            {
                string[] str = s.Split();
                Player p = new Player(str[0], Convert.ToInt32(str[1]));
                playersList.Add(p);
                s = sr.ReadLine();
            }
            sr.Close();
            playersList.Sort();
            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].name == labelLogin.Text)
                    return;
            }
            playersList.Add(new Player(labelLogin.Text, count));
        }

        private void Win()
        {
            for (int i = 0; i < playersList.Count; i++)
            {
                if (playersList[i].name == labelLogin.Text)
                {
                    playersList[i].score += count;
                    playersList.Sort();
                    break;
                }
            }
        }


    }

    class Player : IComparable<Player>
    {
        public string name;
        public int score;
        
        public Player(string str, int n)
        {
            name = str;
            score = n;
        }

        public int CompareTo(Player other)
        {
            if (score == other.score)
                return 0;
            if (score < other.score)
                return 1;
            else return -1;
        }
    }
}
