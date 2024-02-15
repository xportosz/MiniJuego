using System;
using System.Collections.Generic;
using System.Text;


namespace VegaJuego
{
    internal class Link : Personaje
    {
        private int salud;
        private int escudo;
        private int arma;

        public Link(Level1 vegaZelda, int x, int y, int s, int e, int a): base(vegaZelda, x, y)
        {

            salud = s; 
            escudo=e; 
            arma = a;
        }

        public int Arma
        {
            get { return arma;}
            set { arma = value; }
        }

        public int Escudo
        {
            get { return escudo; }
            set { escudo = value; }
        }
        public int Salud
        {
            get { return salud; }
            set { salud = value; }
        }

        public void mover(KeyPressEventArgs e)
        {
            if(e.KeyChar== 'w' && (Caja.Location.Y > 0))
            {
                this.Direccion = "ARRIBA";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Arriba;
                this.Caja.Location = new Point(this.Caja.Location.X, this.Caja.Location.Y - 10);
            }
            if(e.KeyChar== 's' && (Caja.Location.Y < Lienzo.Size.Height -160))
            {
                this.Direccion = "ABAJO";

            }
        }
    }
}
