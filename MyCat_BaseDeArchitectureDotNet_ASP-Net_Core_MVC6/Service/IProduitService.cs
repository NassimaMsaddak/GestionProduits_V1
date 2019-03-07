using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCat_BaseDeArchitectureDotNet_ASP_Net_Core_MVC6.Service
{
    public interface IProduitService
{
        Produit Save(Produit p);
        IEnumerable<Produit> FindAll();
        IEnumerable<Produit> ProduitParMC(string mc);
        Produit GetOne(int ID);
        void Update(Produit p);
        void Delete(int ID);
    }
}
