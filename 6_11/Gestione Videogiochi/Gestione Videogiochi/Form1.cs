using System.CodeDom.Compiler;

namespace Gestione_Videogiochi
{
    public partial class Form1 : Form
    {
        public List<Videogioco> Videogiochi = new List<Videogioco>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Console console = new Console(textBox2.Text);
                DateOnly data_acquisto = new DateOnly(int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));

                Videogioco gioco = new Videogioco(textBox1.Text, double.Parse(textBox3.Text), data_acquisto, console);
                Videogiochi.Add(gioco);
                Aggiorna();
            }
            catch
            {
                MessageBox.Show("I dati inseriti non sono validi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Videogiochi.RemoveAt(listBox1.SelectedIndex);
                Aggiorna();
            }
            catch
            {
                MessageBox.Show("seleziona un videogioco dalla lista");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Videogioco temp = new Videogioco(Videogiochi[listBox1.SelectedIndex]);
                try
                {


                    Console console = new Console(textBox2.Text);
                    DateOnly data_acquisto = new DateOnly(int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));


                    Videogiochi[listBox1.SelectedIndex].Titolo = textBox1.Text;
                    Videogiochi[listBox1.SelectedIndex].Prezzo = double.Parse(textBox3.Text);
                    Videogiochi[listBox1.SelectedIndex].Console = console;
                    Videogiochi[listBox1.SelectedIndex].DataAquisto = data_acquisto;
                    Aggiorna();
                }
                catch
                {
                    Videogiochi[listBox1.SelectedIndex] = temp;
                    MessageBox.Show("i dati inseriti non sono validi");
                }
            }
            catch
            {
                MessageBox.Show("seleziona un gioco dalla lista");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Videogioco clone = new Videogioco(Videogiochi[listBox1.SelectedIndex]);
                Videogiochi.Add(clone);
                Aggiorna();
            }
            catch
            {
                MessageBox.Show("seleziona un gioco dalla lista");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Videogiochi.Clear();
            Aggiorna();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Videogioco item in Videogiochi)
            {
                if (item.Console.Nome == textBox7.Text | textBox7.Text.Length == 0)
                {
                    listBox1.Items.Add($"{item.Titolo} - {item.Console.Nome} - {item.Prezzo}€ - {item.DataAquisto}");
                }
            }
        }

        private void Aggiorna()
        {
            listBox1.Items.Clear();
            double massimo = 0, minimo = 0, medio = 0;
            for (int i = 0; i < Videogiochi.Count; i++)
            {
                Videogioco item = Videogiochi[i];
                medio = medio + item.Prezzo;
                if (massimo < item.Prezzo)
                {
                    massimo = item.Prezzo;
                }
                if (minimo > item.Prezzo | i == 0)
                {
                    minimo = item.Prezzo;
                }
                listBox1.Items.Add($"{item.Titolo} - {item.Console.Nome} - {item.Prezzo}€ - {item.DataAquisto}");
            }
            medio = medio / Videogiochi.Count;

            max.Text = $"Prezzo più alto: {massimo}";
            min.Text = $"Prezzo più basso: {minimo}";
            average.Text = $"Prezzo medio: {Math.Round(medio, 2)}";
        }
    }
}