using System.Diagnostics;

namespace Playlist_musica
{
    public partial class Form1 : Form
    {

        List<Brano> playlist = new List<Brano>();

        public Form1()
        {
            InitializeComponent();
        }


        public void lista_Aggiorna()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < playlist.Count(); i++)
            {
                listBox1.Items.Add($"{i + 1} - {playlist[i].Informazioni()}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | int.Parse(textBox5.Text) < 1 | int.Parse(textBox4.Text) < 1)
                {
                    throw new Exception();
                }
                Brano brano = new Brano(textBox1.Text, textBox2.Text, int.Parse(textBox5.Text), checkBox1.Checked, textBox3.Text, int.Parse(textBox4.Text));

                foreach (Brano i in playlist)
                {
                    if (i.Informazioni() == brano.Informazioni())
                    {
                        MessageBox.Show("Il Brano è già presente in playlist");
                        return;
                    }
                }

                playlist.Add(brano);

                lista_Aggiorna();
            }
            catch
            {
                MessageBox.Show("Dati inseriti non validi.");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.RemoveAt(int.Parse(textBox6.Text) - 1);
                lista_Aggiorna();
            }
            catch
            {
                MessageBox.Show("Dati inseriti non validi.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                playlist[int.Parse(textBox6.Text) - 1].Modifica(textBox11.Text, textBox9.Text, textBox12.Text, int.Parse(textBox8.Text), int.Parse(textBox10.Text), checkBox2.Checked);
                lista_Aggiorna();
            }
            catch
            {
                MessageBox.Show("Dati inseriti non validi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                Brano brano = new Brano(textBox16.Text, playlist[int.Parse(textBox18.Text) - 1].Autore, int.Parse(textBox13.Text), checkBox3.Checked, playlist[int.Parse(textBox18.Text) - 1].Album, playlist[int.Parse(textBox18.Text) - 1].Tracce);

                foreach (Brano i in playlist)
                {
                    if (i.Informazioni() == brano.Informazioni())
                    {
                        MessageBox.Show("Il Brano è già presente in playlist");
                        return;
                    }
                }

                playlist.Add(brano); /*(string titolo, string autore, int durata, bool ghost_track, string album, int tracce)*/

                lista_Aggiorna();

            }
            catch
            {
                MessageBox.Show("Dati inseriti non validi.");
            }
        }
    }
}