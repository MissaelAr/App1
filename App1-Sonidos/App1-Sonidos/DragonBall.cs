using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Media;

namespace App1_Sonidos
{
    class DragonBall : Guerrero
    {
        public DragonBall(string name, Image photo)
            : base(name, photo)
        {

        }


        public override void Reproduce()
        {
            SoundPlayer cancion = new SoundPlayer("DragonBall.wav");
            cancion.Play();
        }
    }
}
