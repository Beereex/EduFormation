using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex034
{
    internal class Client
    {
        private int clientId;
        private string prenom;
        private string nom;
        private string email;
        private string password;
        private string adresse;
        private string societe;

        public Client()
        {
            clientId = -1;
        }

        public Client(int aId)
        {
            clientId = aId;
        }
        
        public int ClientId { 
            get {
                return clientId; 
            }
        }

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

        public int AjouterClient(string aEmail, string aPassword, string aPrenom, string aNom, string aSociete, string aAdresse)
        {
            return 0;
        }
    }
}
