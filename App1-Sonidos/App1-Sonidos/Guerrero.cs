using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Media;

namespace App1_Sonidos
{
    abstract class Guerrero
    {
        private string _nombre;

        public string NombreGuerrero
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private Image _foto;

        public Image FotoGuerrero
        {
            get { return _foto; }
            set { _foto = value; }
        }


        public Guerrero(string nom, Image picture)
        {
            this.NombreGuerrero = nom;
            this.FotoGuerrero = picture;
        }

        private string caricatura;

        public string P_caricatura
        {
            get { return caricatura; }
            set { caricatura = value; }
        }
        
        


        public virtual void Reproduce()
        {
        }
        

        
    }
}
