using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TP5_OOP_HERITAGE
{
    internal class SpecialPackage : Package
    {
        public SpecialPackage(int packageId, int livraisonId, string description, string instructions, string dimentions, double poids, double valeur,
            string informationSuppl, bool oxygenRequis, double temperature, DateTime tempsLimite)
            : base(packageId, livraisonId, description, instructions, dimentions, poids, valeur)
        {
            this.InformationSuppl = informationSuppl;
            this.OxygenRequis = oxygenRequis;
            this.Temperature = temperature;
            this.TempsLimite = tempsLimite;
        }

        public string InformationSuppl { get; set; }
        public bool OxygenRequis { get; set; }
        public double Temperature { get; set; }
        public DateTime TempsLimite { get; set; }
    }
}
