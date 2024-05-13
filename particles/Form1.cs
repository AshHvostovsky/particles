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
        List<Particle> particlesList = new List<Particle>();

        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // добавим поле для эмиттера
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
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(200, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width/2,
                Y = picDisplay.Height,
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся
        

        // гравитон
        
        emitter.impactPoints.Add(new GravityPoint
        {
            X = (float)(picDisplay.Width * 0.25),
            Y = picDisplay.Height / 2
        });



        // снова гравитон
        emitter.impactPoints.Add(new GravityPoint
        {
            X = (float)(picDisplay.Width * 0.75),
            Y = picDisplay.Height / 2
        });

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
            // а тут в эмиттер передаем положение мыфки
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void x1_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = x1.Value; // направлению эмиттера присваиваем значение ползунка
        }
    }
}
