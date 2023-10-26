namespace Ex034
{
    public partial class Form1 : Form
    {
        //Normalement kansta3mlo class bach tkoun les objects li kancréew kaykoun
        //3ndhoum fonctionalité, walaking 7it tp, 9diw bli wajed
        private struct Client
        {
            public int Id;
            public String Prenom;
            public String Nom;
            public DateTime DateDeNaissance;
        }

        //list b7al tableau, walakin lfar9 fla taille
        //tableau ay7taj n3tiw taille definit 9bl manst3mlouh
        //o aykhass ndiro m3ah wa7ed lvariable li kaytracké lina l current index / count

        //amma list fa raha dinamique n9dro nzido li bghina blmethod .add(client)
        //o n9dro n3rfo count directement b list.Count
        private List<Client> tabClient = new List<Client>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        //had lmethod katcréer lina wa7ed l'object client
        //bsti3mal les parametres nom, prenom, date de naissance
        //o katretourné lina l'object bach ndkhlouh fliste apres
        private Client createClient(String Nom, String Prenom, String DdN)
        {
            Client newClient = new Client();
            newClient.Id = tabClient.Count;
            //tabClient.Count le nombre d'elements li ftableau
            //au debut katkoun liste khawya (count = 0)
            //mnin kancréew client lawal kan3tiwh (id = count = 0)
            //mnin n ajoutéw lclient l liste, atwli (count = 1)
            //o lclient jay li aytajouta ayakhod (id = count = 1) ...
            newClient.Prenom = Prenom;
            newClient.Nom = Nom;
            newClient.DateDeNaissance = DateTime.Parse(DdN);
            //7it 3ndna textbox howa li kanakhdo mno date de naissance
            //ya3ni la date de naissance dialna 3ndha type string (txtBox.Text)
            //so bach nstoréwha fstruct dialna aykhssna lconversion mn string l datetime
            return newClient;
        }

        //had lmethod bach n ajoutéw client l la list dial les client
        //apes kanafichéw messagebox 
        private void addClient(Client client)
        {
            tabClient.Add(client);
            //.add client l la list
            MessageBox.Show(
                txtNom.Text + " " + txtPrenom.Text + " à été ajouté avec success",
                "new Slave Added",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            //had foreach raha mamtloubach ftp, lhadaf mnha annana finma nzidou chi client
            //jdid l liste nchoufo ga3 les client li deja dkhlna
            foreach(Client i in  tabClient )
            {
                Console.WriteLine("Client N° {0}: {1} {2}, {3}", i.Id, i.Nom, i.Prenom, i.DateDeNaissance);
                MessageBox.Show(
                "Client N° "+ i.Id+": " + i.Nom + " " + i.Prenom +", " + i.DateDeNaissance);
            }
            //ida bghina nkhdmo b des tableaux
            //Client[] tabClients = new Client[100];
            //int index = 0;
            ////mnin nbghiw ncréew client jdid
            //client.id = index;
            ////o mnin nbghiw n ajoutéw lclient l tableau
            //tabClients[index++]=client;

        }

        //hadi katvidé lina les textBoxes
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

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //hadi makaynach ftp
            Application.Exit();
        }
    }
}