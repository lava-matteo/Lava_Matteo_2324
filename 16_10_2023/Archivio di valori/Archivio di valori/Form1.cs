namespace Archivio_di_valori
{
    public partial class Form1 : Form
    {

        private int[] vett = new int[1000];
        private int minimo, massimo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private int occorrenzeDi(int num)
        {
            int occorrenze = 0;
            foreach (int i in vett)
            {
                if (i == num)
                {
                    occorrenze++;
                }
            }
            return occorrenze;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0")
                {
                    throw new Exception();
                }
                for (int i = 0; i < vett.Length; i++)
                {
                    if (vett[i] == 0)
                    {
                        vett[i] = int.Parse(textBox1.Text);
                        break;
                    }
                }
                vett.Append(int.Parse(textBox1.Text));
                MessageBox.Show("numero inserito in archivio");
                Archivio.Items.Add(textBox1.Text);
                textBox1.Text = null;

                massimoMinimo();
            }

            catch
            {
                MessageBox.Show("Il numero inserito non è valido");
                textBox1.Text = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label7.Text = occorrenzeDi(int.Parse(textBox2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("il numero inserito non è valido");
                label7.Text = "...";
            }
        }

        private void massimoMinimo()
        {
            int x = 0;
            foreach (int i in vett)
            {
                if (i != 0)
                {
                    x++;
                    if (i > massimo)
                    {
                        massimo = i;
                    }
                    if (i < minimo | x == 1)
                    {
                        minimo = i;
                    }
                }
            }
            label4.Text = minimo.ToString();
            label6.Text = massimo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aggiunta = 0;
            try
            {
                aggiunta = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("il numero inserito non è valido");
                textBox3.Text = null;
            }

            for (int i = 0; i < vett.Length; i++)
            {
                if (vett[i] != 0)
                {
                    vett[i] = vett[i] + aggiunta;
                }
            }
            massimoMinimo();
            Archivio.Items.Clear();
            foreach (int i in vett)
            {
                if (i != 0) 
                {
                    Archivio.Items.Add(i);
                }
            }
        }
    }
}