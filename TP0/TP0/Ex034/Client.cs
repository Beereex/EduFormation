using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex034
{

    //hadi lpartie dial tp d poo
    internal class Client
    {
        private int clientId;
        private string prenom;
        private string nom;
        private string email;
        private string password;
        private string adresse;
        private string societe;

        //hado des constructeurs, mnin kancéew un object bhad lclass o kaninitalisiwh
        //automatiquement kandiro appel lwhda mn had les constructeurs
        //3la 7ssab les arguments li 3tina flcreation

        //constructeur vide, clienId default -1
        public Client()
        {
            clientId = -1;
        }

        //constructeur w/ id
        public Client(int aId)
        {
            clientId = aId;
        }
        
        //hada fih ghir get 7it read only, maymknch nbdlo lvaleur dialo outside lclass
        public int ClientId { 
            get {
                return clientId; 
            }
        }

        //normalement mnin kandiro lgetters o setters, kandiro des operations
        //matalan password kaykoun naked, kancriptéwh 9bl makankhrjouh blgetter
        //o kandécriptéwh mnin kanakhdouh bsetter
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        public string Nom
        {
            get 
            {
                return nom;
            }
            set 
            {
                nom = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set 
            { 
                password = value; 
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }
            set 
            { 
                adresse = value; 
            }
        }

        public string Societe
        {
            get
            {
                return societe;
            }
            set
            {
                societe = value;
            }
        }


        //hadi hia lblassa li fiha probleme, tp majach m3ah wa7ed lfichier text
        //hadak lfichier text normalement howa li fih lcode dial had lmethod
        //lcode li hna ana li zaydo o machi fonctionel
        public void LogOn(string email, string password)
        {
            if(this.email.Equals(email) && this.password.Equals(password))
            {
                MessageBox.Show("Welcome to Hell", "\u3503", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 form1 = new Form1();
                LogOn logon = new LogOn();            
                form1.Show();
                logon.Dispose();
            }
            else
            {
                MessageBox.Show("Email ou Mot de Passe Incorrects","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //same thing, khass fichier "code.txt"
        public int AjouterClient(string aEmail, string aPassword, string aPrenom, string aNom, string aSociete, string aAdresse)
        {
            return 0;
        }
    }
}
