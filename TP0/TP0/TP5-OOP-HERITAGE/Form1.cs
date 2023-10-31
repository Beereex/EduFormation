using System.Diagnostics;

namespace TP5_OOP_HERITAGE
{
    public partial class Form1 : Form
    {
        private List<Package> packages = new List<Package>();
        public Form1()
        {
            InitializeComponent();
        }

        private void switchEnable(bool enabled)
        {
            txtInstructionsSuppl.Enabled = checkOxygen.Enabled = txtTemperature.Enabled = txtTempsLimite.Enabled = enabled;
        }

        private void checkSpecialPackage_CheckedChanged(object sender, EventArgs e)
        {
            switchEnable(checkSpecialPackage.Checked);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous sortir?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (object text in this.Controls)
            {
                try
                {
                    ((TextBox)text).Text = "";
                }
                catch
                {
                    continue;
                }
                checkSpecialPackage.Checked = checkOxygen.Checked = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Package package;
            if (checkSpecialPackage.Checked)
            {
                package = new SpecialPackage(int.Parse(txtPackageId.Text), int.Parse(txtLivraisonId.Text), txtDesctiption.Text, txtInstructions.Text,
                    txtDimensions.Text, double.Parse(txtPoids.Text), double.Parse(txtValeur.Text), txtInstructionsSuppl.Text, checkOxygen.Checked, double.Parse(txtTemperature.Text),
                    DateTime.Parse(txtTempsLimite.Text));
            }
            else
            {
                package = new Package(int.Parse(txtPackageId.Text), int.Parse(txtLivraisonId.Text), txtDesctiption.Text, txtInstructions.Text,
                    txtDimensions.Text, double.Parse(txtPoids.Text), double.Parse(txtValeur.Text));
            }
            packages.Add(package);
            btnClear.PerformClick();
            MessageBox.Show("new Package added");
        }

        private void fillFromPackage(Package package)
        {
            txtLivraisonId.Text = package.LivraisonId.ToString();
            txtDesctiption.Text = package.Description;
            txtInstructions.Text = package.Instructions;
            txtDimensions.Text = package.Dimensions;
            txtPoids.Text = package.Poids.ToString();
            txtValeur.Text = package.Valeur.ToString();
            txtDimensions.Text = package.Dimensions.ToString();
            if (package is SpecialPackage)
            {
                checkSpecialPackage.Checked = true;
                txtInstructionsSuppl.Text = ((SpecialPackage)package).InformationSuppl;
                checkOxygen.Checked = ((SpecialPackage)package).OxygenRequis;
                txtTemperature.Text = ((SpecialPackage)package).Temperature.ToString();
                txtTempsLimite.Text = ((SpecialPackage)package).TempsLimite.Date.ToString();
            }
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            int packId;
            Package? target = null;
            try
            {
                packId = int.Parse(txtPackageId.Text);
                foreach (Package package in packages)
                {
                    if (package.PackageId == packId)
                    {
                        target = package;
                    }
                    else continue;
                }
                if (target == null)
                {
                    MessageBox.Show("package not found!");
                    Debug.WriteLine("debugger");
                }
                else
                {
                    fillFromPackage(target);
                }
            }
            catch
            {
                MessageBox.Show("package id incorrect!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int packId;
            bool removed = false;
            try
            {
                packId = int.Parse(txtPackageId.Text);
                for(int i = 0; i < packages.Count; i++)
                {
                    if(packId == packages[i].PackageId)
                    {
                        packages.RemoveAt(i);
                        removed = true;
                        btnClear.PerformClick();
                        break;
                    }
                }
                if (!removed)
                {
                    MessageBox.Show("package not found!");
                }
                else
                {
                    MessageBox.Show("package was removed successfuly!");
                }
            }
            catch
            {
                MessageBox.Show("package id incorrect!");
            }
        }
    }
}