using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_OOP_HERITAGE
{
    internal class Package
    {
        public Package(int packageId, int livraisonId, string description, string instructions, string dimensions, double poids, double valeur) {
            this.PackageId = packageId;
            this.Valeur = valeur;
            this.Description = description;
            this.Instructions = instructions;
            this.LivraisonId = livraisonId;
            this.Dimensions = dimensions;
        }

        public int PackageId { get; set; }
        public int LivraisonId { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public string Dimensions { get; set; }
        public double Poids { get; set; }
        public double Valeur { get; set;}
    }
}
