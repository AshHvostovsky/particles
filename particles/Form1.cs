using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace particles
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        Emitter emitter; 

        ColorPoint point1; // добавил поле под первую точку
        ColorPoint point2; // добавил поле под вторую точку
        ColorPoint point3; // добавил поле под третью точку
        AntiGravityPoint point4; // добавил поле под четвертую точку

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 90,
                Spreading = 30,
                SpeedMin = 6,
                SpeedMax = 15,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.Black),
                ParticlesPerTick = 10,
                X = picDisplay.Width/2,
                Y = picDisplay.Height,
            };

        

     

            // привязываем цветные области к полям
            point1 = new ColorPoint
            {
                X = (float)(picDisplay.Width * 0.25),
                Y = picDisplay.Height / 2,
                ToColor = Color.Black,
                FromColor = Color.Red,
            };
            point2 = new ColorPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
                ToColor = Color.Black,
                FromColor = Color.Blue,
            };
            point3 = new ColorPoint
            {
                X = (float)(picDisplay.Width * 0.75),
                Y = picDisplay.Height / 2,
                ToColor = Color.Black,
                FromColor = Color.Green,
            };

            // антигравитрон
            point4 = new AntiGravityPoint
            {
                X = 10,
                Y = 10,
            };

            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // а тут в эмиттер передаем положение мышки
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;

            // а тут передаем положение мыши, в положение гравитона
            point4.X = e.X;
            point4.Y = e.Y;
        }

        private void x1_Scroll(object sender, EventArgs e)
        {
            point1.X = x1.Value; 
        }

        private void y1_Scroll(object sender, EventArgs e)
        {
            point1.Y = y1.Value; 
        }

        private void s1_Scroll(object sender, EventArgs e)
        {
            point1.RadArea = s1.Value;
        }

        private void x2_Scroll(object sender, EventArgs e)
        {
            point2.X = x2.Value;
        }

        private void y2_Scroll(object sender, EventArgs e)
        {
            point2.Y = y2.Value;
        }

        private void s2_Scroll(object sender, EventArgs e)
        {
            point2.RadArea = s2.Value;
        }

        private void x3_Scroll(object sender, EventArgs e)
        {
            point3.X = x3.Value;
        }

        private void y3_Scroll(object sender, EventArgs e)
        {
            point3.Y = y3.Value;
        }

        private void s3_Scroll(object sender, EventArgs e)
        {
            point3.RadArea = s3.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point1.FromColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            point2.FromColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            point3.FromColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            emitter.RadiusMax = trackBar2.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                point4.Power = 50;
            }
            else
            {
                point4.Power = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                emitter.GravitationY = 0.1f;
            }
            else
            {
                emitter.GravitationY = 0.0f;
            }
        }
    }
}
