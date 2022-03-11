using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Produit_MVC.Models.repositories
{
   public interface IRepository<T> 

    {
        IList<T> Lister();
        T ListerSelonId(int id);
        void Ajouter(T element);
        void Modifier(int id, T element);
        void Suprimer(int id);
    }
}
