using System.Diagnostics;

namespace Morra_Cinese
{
    public partial class Form1 : Form
    {

        private int punteggioUmano = 0, punteggioPC = 0;
        private Image carta = Image.FromFile(@"carta.jpg");
        private Image forbici = Image.FromFile(@"forbici.jpg");
        private Image sasso = Image.FromFile(@"sasso.png");
        private int sceltaUmano, sceltaPC;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }
        private void label2_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            punteggioUmano = 0;
            punteggioPC = 0;
            label2.Text = punteggioUmano.ToString();
            label5.Text = punteggioPC.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void SceltaPC()
        {
            Random scelta = new Random();
            int immagine = scelta.Next(0, 3);
            if (immagine == 0)
            {
                pictureBox5.Image = Image.FromFile(@"sasso.png");
                sceltaPC = 1;
            }
            else if (immagine == 1)
            {
                pictureBox5.Image = Image.FromFile(@"carta.jpg");
                sceltaPC = 2;
            }
            else
            {
                pictureBox5.Image = Image.FromFile(@"forbici.jpg");
                sceltaPC = 3;
            }
            AssegnaPunti();
            label2.Text = punteggioUmano.ToString();
            label5.Text = punteggioPC.ToString();

        }

        private void AssegnaPunti()
        {
            Debug.WriteLine(sceltaUmano);
            Debug.WriteLine(sceltaPC);
            if (sceltaPC == sceltaUmano)
            {
            }
            else if ((sceltaPC == 1 & sceltaUmano == 2) | (sceltaPC == 2 & sceltaUmano == 3) | (sceltaPC == 3 & sceltaUmano == 1))
            {
                punteggioUmano++;
            }
            else
            {
                punteggioPC++;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*sasso*/
            pictureBox4.Image = sasso;
            sceltaUmano = 1;
            SceltaPC();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /*carta*/
            pictureBox4.Image = carta;
            sceltaUmano = 2;
            SceltaPC();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*forbice*/
            pictureBox4.Image = forbici;
            sceltaUmano = 3;
            SceltaPC();
        }
    }
}