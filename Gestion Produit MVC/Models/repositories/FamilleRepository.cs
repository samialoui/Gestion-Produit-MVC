using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Produit_MVC.Models.repositories
{
    public class FamilleRepository : IRepository<Famille>
    {
        public IList<Famille> familles { get; set; }

        public FamilleRepository()
        {
            familles = new List<Famille>()
            {
            new Famille
            {
                id = 1,nom = "Imprimante"
            },
            new Famille
            {
                id=2, nom="Pc"

            },
            new Famille
            {
                id = 3, nom = "Caméra"

            }
            };
        }
        public void Ajouter(Famille element)
        {
            familles.Add(element);
        }

        public IList<Famille> Lister()
        {
            return familles;
        }

        public Famille ListerSelonId(int id)
        {
          return  familles.Single(a => a.id == id);
        }

        public void Modifier(int id, Famille element)
        {
            var AncienneFamille = familles.SingleOrDefault(a => a.id == id);
            AncienneFamille.nom = element.nom;
        }

        public void Suprimer(int id)
        {
            var AncienneFamille = ListerSelonId(id);
            familles.Remove(AncienneFamille);
        }
    }
}
