﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace particles
{

    public class Emitter
    {
        public int ParticlesCount = 1000;

        public int X; // координата X центра эмиттера, будем ее использовать вместо MousePositionX
        public int Y; // соответствующая координата Y 
        public int Direction = 0; // вектор направления в градусах куда сыпет эмиттер
        public int Spreading = 360; // разброс частиц относительно Direction
        public int SpeedMin = 1; // начальная минимальная скорость движения частицы
        public int SpeedMax = 10; // начальная максимальная скорость движения частицы
        public int RadiusMin = 1; // минимальный радиус частицы
        public int RadiusMax = 5; // максимальный радиус частицы
        public int LifeMin = 100; // минимальное время жизни частицы
        public int LifeMax = 200; // максимальное время жизни частицы

        public Boolean directionBool = false;

        public int ParticlesPerTick = 1; // добавил новое поле

        public Color ColorFrom = Color.White; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц


        List<Particle> particlesList = new List<Particle>();

        public List<IImpactPoint> impactPoints = new List<IImpactPoint>(); // <<< ТАК ВОТ

        public int MousePositionX;
        public int MousePositionY;

        public float GravitationX = 0;
        public float GravitationY = 0.1f; // пусть гравитация будет силой один пиксель за такт, нам хватит

        /* добавил метод */
        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }

        
        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick; // фиксируем счетчик сколько частиц нам создавать за тик

            foreach (var particle in particlesList)
            {
                particle.Life -= 1;  // не трогаем
                if (particle.Life <= 0)
                {
                    ResetParticle(particle); // заменили этот блок на вызов сброса частицы 
                }
                else
                {
                    // каждая точка по-своему воздействует на вектор скорости
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    // а это старый код, его не трогаем
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            for (var i = 0; i < 10; ++i)
            {
                if (particlesList.Count < ParticlesCount)
                {
                    var particle = CreateParticle(); // и собственно теперь тут его вызываем
                    ResetParticle(particle);
                    particlesList.Add(particle);
                }
                else
                {
                    break; // а если частиц уже 500 штук, то ничего не генерирую
                }
            }
            if (Direction < 45)
            {
                directionBool = true;
            }
            else if (Direction > 135)
            {
                directionBool = false;
            }

            if (!directionBool)
            {
                Direction--;
            }
            else
            {
                Direction++;
            }
        }

        public void Render(Graphics g)
        {
            // это не трогаем
            foreach (var particle in particlesList)
            {
                particle.Draw(g);
            }
            foreach (var point in impactPoints)
            {
                point.Render(g); // это добавили
            }
        }
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(LifeMin, LifeMax);

            particle.X = X;
            particle.Y = Y;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);

            particle.FromColor = Color.White;
            particle.ToColor = Color.FromArgb(0, Color.Black);

        }
    }

}
