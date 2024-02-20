namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }
        private void IniciarPersonajes()
        {
            Player = new Link(this, 0, 0, 30, 0, 0);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
        }
    }
}