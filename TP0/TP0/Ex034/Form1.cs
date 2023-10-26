namespace Ex034
{
    public partial class Form1 : Form
    {
        private struct Client
        {
            public int Id;
            public String Prenom;
            public String Nom;
            public DateTime DateDeNaissance;
        }

        private List<Client> tabClient = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private Client createClient(String Nom, String Prenom, String DdN)
        {
            Client newClient = new Client();
            newClient.Id = tabClient.Count;
            newClient.Prenom = Prenom;
            newClient.Nom = Nom;
            newClient.DateDeNaissance = DateTime.Parse(DdN);
            return newClient;
        }

        private void addClient(Client client)
        {
            tabClient.Add(client);
            MessageBox.Show(
                txtNom.Text + " " + txtPrenom.Text + " à été ajouté avec success",
                "new Slave Added",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            foreach(Client i in  tabClient )
            {
                Console.WriteLine("Client N° {0}: {1} {2}, {3}", i.Id, i.Nom, i.Prenom, i.DateDeNaissance);
                MessageBox.Show(
                "Client N° "+ i.Id+": " + i.Nom + " " + i.Prenom +", " + i.DateDeNaissance);
            }
        }

        private void clearTextBoxes()
        {
            txtPrenom.Text = txtNom.Text = txtDdn.Text = "";
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            Client newClient = createClient(txtPrenom.Text, txtNom.Text, txtDdn.Text);
            addClient(newClient);
            clearTextBoxes();          
        }
    }
}