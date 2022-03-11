using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Produit_MVC.Models.repositories
{
    public class ProduitRepository : IRepository<Produit>
    {

        public IList<Produit> produits { get; set; }

        public ProduitRepository()
        {
            produits = new List<Produit>()
            {
                new Produit
                {
                    id=1,
                    reference="L102R",
                    designation="EPSON ECOTEK l102rR",
                    description="Imrimante avec wifi",
                    disponible= true,
                    famille = new Famille{id=1,nom="Imprimante"}

                },
                new Produit
                 {
                    id=2,
                    reference="L103R",
                    designation="EPSON ECOTEK2 l102rR",
                    description="Imrimante sans wifi",
                    disponible= true,
                    famille = new Famille{id=2,nom="Imprimante2"}

                },
                new Produit
                  {
                    id=3,
                    reference="L103R",
                    designation="EPSON ECOTEK3 l102rR",
                    description="Imrimante avec wifi",
                    disponible= true,
                    famille = new Famille{id=3,nom="Imprimante"}

                }
            };
        }
        public void Ajouter(Produit element)
        {
             produits.Add(element);
        }

        public IList<Produit> Lister()
        {
            return produits;
        }

        public Produit ListerSelonId(int id)
        {
            return produits.Single(b => b.id == id);
        }

        public void Modifier(int id, Produit element)
        {
            var AncienProduit = produits.SingleOrDefault(b => b.id == id);
            AncienProduit.reference = element.reference;
            AncienProduit.designation = element.designation;
            AncienProduit.description = element.description;
            AncienProduit.disponible = element.disponible;
            AncienProduit.famille = element.famille;
        }

        public void Suprimer(int id)
        {
            var AncienProduit = ListerSelonId(id);
            produits.Remove(AncienProduit);
        }
    }
}
