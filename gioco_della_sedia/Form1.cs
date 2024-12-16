namespace gioco_della_sedia
{
    public partial class Form1 : Form
    {
        static List<Thread> threads = new List<Thread>();
        static int numSedie;
        static int numSedieLibere;
        static object lockObject = new object();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void avviaGioco_Click(object sender, EventArgs e)
        {
            int numBambini = int.Parse(txtBambini.Text);
            if (numBambini <= 0)
            {
                MessageBox.Show("Il numero di bambini deve essere maggiore di 0.");
                return;
            }
            Console.WriteLine("Benvenuti al gioco delle sedie musicali!");
            Console.WriteLine("Inserisci il numero di bambini: " + numBambini);
            int numSedie = int.Parse(txtSedie.Text);
            if (numSedie <= 0)
            {
                MessageBox.Show("Il numero di sedie deve essere maggiore di 0.");
                return;
            }
            numSedieLibere = numSedie;
            threads.Clear();
            listBoxGiocatori.Items.Clear();
            for (int i = 0; i < numBambini; i++)
            {
                Thread thread = new Thread(Play);
                thread.Name = "Bambino" + i;
                threads.Add(thread);
                listBoxGiocatori.Items.Add("Bambino" + i);
                thread.Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
            lblStatoGioco.Text = "Il gioco è finito. Tutti i bambini hanno vinto!";
        }

        static void Play()
        {
            Random random = new Random();
            string nome = Thread.CurrentThread.Name;
            while (numSedieLibere > 1)
            {
                    lblStatoGioco.Text = $"La musica si è fermata! {nome} si è seduto.";
                Thread.Sleep(random.Next(1000, 2000));
                lock (lockObject)
                {
                    if (numSedieLibere > 0)
                    {
                        numSedieLibere--;
                            listBoxGiocatori.Items.Remove(nome);
                    }
                    else
                    {
                        lblStatoGioco.Text = $"{nome} è eliminato.";
                        break;
                    }
                }
            }
        }
    }
}
